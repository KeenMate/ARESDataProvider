using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml.Serialization;
using AresDataProvider.Data.ES;
using AresDataProvider.Helpers;
using AresDataProvider.Mappers;
using AresDataProvider.ProviderData.ES;
using NLog;

namespace AresDataProvider
{
	public class CompanyESProvider : BaseProvider
	{
		#region Constructors

		public CompanyESProvider(Guid correlationId)
		{
			CorrelationId = correlationId;
			BaseUrl = "https://wwwinfo.mfcr.cz/cgi-bin/ares/ares_es.cgi";
			Logger = LogManager.GetCurrentClassLogger();
		}

		public CompanyESProvider(Guid correlationId, string baseUrl)
		{
			CorrelationId = correlationId;
			BaseUrl = baseUrl;
			Logger = LogManager.GetCurrentClassLogger();
		}

		#endregion

		public ESResultModel Search(string taxId = "", string name = "", string city = "")
		{
			Logger.Debug($"{CorrelationId} - Request with query:{{taxId:{taxId}, name: {name}, city: {city}}} started");
			Stopwatch timer = Stopwatch.StartNew();

			string url = PrepareUrl(new Dictionary<string, string>
			{
				{
					"ico",
					taxId
				},
				{
					"obch_jm",
					name
				},
				{
					"obec",
					city
				}
			});

			Logger.Debug($"{CorrelationId} - Generated Url for ES request: {url}");

			Ares_odpovedi aresResponse = WebRequestHelper.XmlWebRequestSequence<Ares_odpovedi>(
				url);
			Logger.Debug($"{CorrelationId} - Got response from ARES. Time:{timer.Elapsed}");
			timer.Restart();

			ESResultModel result = BaseMapper.MapESData(aresResponse);

			Logger.Debug($"{CorrelationId} - Ares response mapped. Time:{timer.Elapsed}");
			return result;
		}

		public ESResultModel GetCompanyByTaxId(string taxId)
		{
			Logger.Debug($"{CorrelationId} - Request for taxId:{taxId} started");
			Stopwatch timer = Stopwatch.StartNew();

			Ares_odpovedi ares = taxId.Length != 8 ? null : WebRequestHelper.XmlWebRequestSequence<Ares_odpovedi>(BaseUrl + "?ico=" + taxId);
			ESResultModel result;

			if (ares != null && ares.Odpoved.Help == null)
			{
				result = new ESResultModel
				{
					ItemsFound = Convert.ToInt16(ares.Odpoved.Pocet_zaznamu),
					Items = ares.Odpoved.V.S.Select(x => new ESCompanyModel
					{
						Address = x.Jmn,
						Name = x.Ojm,
						TaxId = x.Ico
					}).ToList()
				};
			}
			else if (ares?.Odpoved.Help != null)
			{
				Logger.Debug($"{CorrelationId} - ARES response contains Help node. taxId:{taxId}. HelpMsg:{ares.Odpoved.Help.R}");
				result = new ESResultModel
				{
					ItemsFound = 0,
					Items = null,
					Errors = ares.Odpoved.Help.R
				};
			}
			else
				return null;

			Logger.Debug($"{CorrelationId} - Request finished, Time: {timer.Elapsed}");
			return result;
		}
	}
}