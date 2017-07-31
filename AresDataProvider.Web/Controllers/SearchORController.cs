using System;
using System.Diagnostics;
using System.Web.Http;
using System.Web.Http.Cors;
using AresDataProvider.Data.Registry;
using NLog;

namespace AresDataProvider.Web.Controllers
{
	[EnableCors("https://keenmate.sharepoint.com", "*", "*")]
	public class SearchORController : ApiController
	{
		private static readonly ILogger logger = LogManager.GetCurrentClassLogger();

		[HttpGet]
		public RegistryResultModel ByTaxId(string taxId = "", bool extended = false)
		{
			Stopwatch watch = Stopwatch.StartNew();
			Guid correlationId = Guid.NewGuid();
			logger.Debug($"{correlationId} - Search Registry Request for taxId:{taxId} started");

			int x;
			if (taxId.Length != 8 || !int.TryParse(taxId, out x))
			{
				logger.Debug($"{correlationId} - TaxId is not valid. Time:{watch.Elapsed}");
				return new ExtendedRegistryResultModel
				{
					Error = "Tax ID is not valid"
				};
			}

			CompanyRegistryProvider provider = new CompanyRegistryProvider(correlationId);

			RegistryResultModel result = provider.GetCompanyData(taxId, extended);

			logger.Debug($"{correlationId} - Registry Request ended. Time: {watch.Elapsed}");

			return result;
		}
	}
}