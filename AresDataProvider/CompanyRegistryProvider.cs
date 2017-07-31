using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;
using AresDataProvider.Data.Registry;
using AresDataProvider.Mappers;
using AresDataProvider.Helpers;
using AresDataProvider.ProviderData.Registry;
using NLog;

namespace AresDataProvider
{
	public class CompanyRegistryProvider : BaseProvider
	{
		public CompanyRegistryProvider(Guid correlationId)
		{
			CorrelationId = correlationId;
			BaseUrl = "http://wwwinfo.mfcr.cz/cgi-bin/ares/darv_or.cgi";
			Logger = LogManager.GetCurrentClassLogger();
		}

		public CompanyRegistryProvider(Guid correlationId, string baseUrl)
		{
			CorrelationId = correlationId;
			BaseUrl = baseUrl;
			Logger = LogManager.GetCurrentClassLogger();
		}

		public RegistryResultModel GetCompanyData(string taxId = "", bool extended = false)
		{
			Logger.Debug($"{CorrelationId} - Request Registry Data for taxId:{taxId} started");

			Stopwatch watch = Stopwatch.StartNew();

			string url = PrepareUrl(new Dictionary<string, string>
			{
				{
					"ico",
					taxId
				}
			});

			Logger.Debug($"{CorrelationId} - Url generated for taxId:{taxId} is {url}");

			Ares_odpovedi result = WebRequestHelper.XmlWebRequestSequence<Ares_odpovedi>(
				url);

			Logger.Debug($"{CorrelationId} - Got Response from ARES. Time:{watch.Elapsed}");
			watch.Restart();

			RegistryResultModel model = extended
				? BaseMapper.MapExtendedRegistryData(result)
				: BaseMapper.MapRegistryData(result);

			Logger.Debug($"{CorrelationId} - ARES response mapped. Time:{watch.Elapsed}");

			return model;
		}
	}
}