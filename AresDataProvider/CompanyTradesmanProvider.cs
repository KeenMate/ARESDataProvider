using System;
using System.Collections.Generic;
using System.Diagnostics;
using AresDataProvider.Data.RZP;
using AresDataProvider.Helpers;
using AresDataProvider.Mappers;
using AresDataProvider.ProviderData.RZP;
using NLog;

namespace AresDataProvider
{
	public class CompanyTradesmanProvider : BaseProvider
	{
		#region Constructors

		public CompanyTradesmanProvider(Guid correlationId)
		{
			this.CorrelationId = correlationId;
			BaseUrl = "http://wwwinfo.mfcr.cz/cgi-bin/ares/darv_rzp.cgi";
			Logger = LogManager.GetCurrentClassLogger();
		}

		public CompanyTradesmanProvider(Guid correlationId, string baseUrl)
		{
			this.CorrelationId = correlationId;
			BaseUrl = baseUrl;
			Logger = LogManager.GetCurrentClassLogger();
		}

		#endregion

		public RZPResultModel GetCompanyByTaxId(string taxId)
		{
			Logger.Debug($"{CorrelationId} - Request RZP Data for taxId:{taxId} started");

			Stopwatch watch = Stopwatch.StartNew();

			Ares_odpovedi aresResponse = WebRequestHelper.XmlWebRequestSequence<Ares_odpovedi>(
				PrepareUrl(new Dictionary<string, string>
				{
					{
						"ico",
						taxId
					}
				}));

			Logger.Debug($"{CorrelationId} - Got ARES reponse. Time:{watch.Elapsed}");
			watch.Restart();

			RZPResultModel result = BaseMapper.MapRZPData(aresResponse);

			Logger.Debug($"{CorrelationId} - ARES response mapped. Time:{watch.Elapsed}");

			return result;
		}
	}
}