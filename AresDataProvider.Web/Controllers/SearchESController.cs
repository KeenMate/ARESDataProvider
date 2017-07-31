using System;
using System.Diagnostics;
using System.Web.Http;
using System.Web.Http.Cors;
using AresDataProvider.Data.ES;
using NLog;


namespace AresDataProvider.Web.Controllers
{
	[EnableCors(origins: "https://keenmate.sharepoint.com", methods: "*", headers: "*")]
	public class SearchESController : ApiController
	{
		private static readonly ILogger logger = LogManager.GetCurrentClassLogger();

		[HttpGet]
		public ESResultModel By(string name = "", string city = "", string taxId = "")
		{
			Guid correlationId = Guid.NewGuid();
			Stopwatch watch = Stopwatch.StartNew();
			logger.Debug($"{correlationId} - Search ES Data Request for {{taxId:{taxId}, name:{name}, city:{city}}} started");

			CompanyESProvider provider = new CompanyESProvider(correlationId);

			ESResultModel result = provider.Search(taxId, name, city);

			logger.Debug($"{correlationId} - Search ES Request ended. Time:{watch.Elapsed}");

			return result;
		}

		[HttpGet]
		public ESResultModel ByTaxId(string taxId)
		{
			if (taxId.Length != 8)
				return null;

			Guid correlationId = Guid.NewGuid();

			Stopwatch watch = Stopwatch.StartNew();
			logger.Debug($"{correlationId} - Search ES Request by taxId:{taxId} started");

			CompanyESProvider provider = new CompanyESProvider(correlationId);

			ESResultModel response = provider.GetCompanyByTaxId(taxId);

			logger.Debug($"{correlationId} - Search ES Request by taxId:{taxId} finished. Time:{watch.Elapsed}");

			return response;
		}
	}
}
