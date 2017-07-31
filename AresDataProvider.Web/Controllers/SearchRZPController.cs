using System;
using System.Diagnostics;
using System.Web.Http;
using System.Web.Http.Cors;
using AresDataProvider.Data.RZP;
using NLog;

namespace AresDataProvider.Web.Controllers
{
	[EnableCors("https://keenmate.sharepoint.com", "*", "*")]
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

			RZPResultModel result = provider.GetCompanyByTaxId(taxId);

			logger.Debug($"{correlationId} - Search RZP Request ended. Time:{watch.Elapsed}");

			return result;
		}
	}
}
