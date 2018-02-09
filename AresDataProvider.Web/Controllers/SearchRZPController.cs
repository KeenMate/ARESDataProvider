using System;
using System.Diagnostics;
using System.Web.Http;
using System.Web.Http.Cors;
using AresDataProvider.Data.RZP;
using AresDataProvider.Web.Helpers;
using NLog;

namespace AresDataProvider.Web.Controllers
{
	[EnableCorsByDomain]
	public class SearchRZPController : ApiController
	{
		private readonly ILogger logger = LogManager.GetCurrentClassLogger();

		[HttpGet]
		public RZPResultModel ByTaxId(string taxId)
		{
			Guid correlationId = Guid.NewGuid();
			Stopwatch watch = Stopwatch.StartNew();

			logger.Debug($"{correlationId} - Search RZP Request for taxId:{taxId} started");

			CompanyTradesmanProvider provider = new CompanyTradesmanProvider(correlationId);

			RZPResultModel result;

			//try
			//{
			//	result = provider.GetCompanyByTaxId(taxId);
			//}
			//catch (Exception e)
			//{
			//	logger.Error($"{correlationId} - Error appeared: {e}");
			//	result = new RZPResultModel { Error = "Request failed" };
			//}
			result = provider.GetCompanyByTaxId(taxId);

			logger.Debug($"{correlationId} - Search RZP Request ended. Time:{watch.Elapsed}");

			result.TimeTaken = watch.Elapsed;
			return result;
		}
	}
}
