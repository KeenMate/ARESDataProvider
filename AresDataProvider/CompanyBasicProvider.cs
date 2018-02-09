using System;
using System.Collections.Generic;
using System.Diagnostics;
using AresDataProvider.Data.Basic;
using AresDataProvider.Helpers;
using AresDataProvider.Mappers;
using AresDataProvider.ProviderData.Basic;
using NLog;

namespace AresDataProvider
{
	public class CompanyBasicProvider : BaseProvider
	{
		#region Constructors

		public CompanyBasicProvider(Guid correlationId)
		{
			this.CorrelationId = correlationId;
			BaseUrl = "http://wwwinfo.mfcr.cz/cgi-bin/ares/darv_bas.cgi";
			Logger = LogManager.GetCurrentClassLogger();
		}

		public CompanyBasicProvider(Guid correlationId, string baseUrl)
		{
			this.CorrelationId = correlationId;
			BaseUrl = baseUrl;
			Logger = LogManager.GetCurrentClassLogger();
		}

		#endregion

		public BasicResultModel GetCompanyByTaxId(string taxId)
		{
			Logger.Debug($"{CorrelationId} - Request Basic Data for taxId:{taxId} started");

			Stopwatch watch = Stopwatch.StartNew();

			Ares_odpovedi aresResponse = WebRequestHelper.XmlWebRequestSequence<Ares_odpovedi>(
				PrepareUrl(new Dictionary<string, string>
				{
					{
						"ico",
						taxId
					}
				})
			);

			Logger.Debug($"{CorrelationId} - Got Response from ARES. Time:{watch.Elapsed}");
			watch.Restart();

			BasicResultModel result = BaseMapper.MapBasicData(aresResponse);

			Logger.Debug($"{CorrelationId} - ARES response mapped. Time:{watch.Elapsed}");

			return result;
		}
	}
}