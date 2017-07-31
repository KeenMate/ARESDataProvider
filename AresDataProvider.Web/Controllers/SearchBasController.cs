using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using AresDataProvider.Data.Basic;
using NLog;

namespace AresDataProvider.Web.Controllers
{
	[EnableCors(origins: "https://keenmate.sharepoint.com", methods: "*", headers: "*")]
	public class SearchBasController : ApiController
	{
		private static readonly ILogger logger = LogManager.GetCurrentClassLogger();

		[HttpGet]
		public BasicResultModel ByTaxId(string taxId)
		{
			Guid correlationId = Guid.NewGuid();
			Stopwatch watch = Stopwatch.StartNew();

			logger.Debug($"{correlationId} - Search Basic Data for taxId:{taxId} started");

			CompanyBasicProvider provider = new CompanyBasicProvider(correlationId);

			BasicResultModel result = provider.GetCompanyByTaxId(taxId);

			logger.Debug($"{correlationId} - Search Basic Data ended. Time:{watch.Elapsed}");

			return result;
		}
	}
}
