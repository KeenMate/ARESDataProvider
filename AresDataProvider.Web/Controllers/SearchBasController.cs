using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Configuration;
using System.Web.Http;
using System.Web.Http.Cors;
using AresDataProvider.Data.Basic;
using AresDataProvider.Web.Helpers;
using NLog;

namespace AresDataProvider.Web.Controllers
{
	[EnableCorsByDomain]
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

			BasicResultModel result;

			try
			{
				result = provider.GetCompanyByTaxId(taxId);
			}
			catch (Exception e)
			{
				logger.Error($"{correlationId} - Error appeared: {e}");
				result = new BasicResultModel { Error = "Request failed" };
				return result;
			}

			logger.Debug($"{correlationId} - Search Basic Data ended. Time:{watch.Elapsed}");

			result.TimeTaken = watch.Elapsed;
			return result;
		}
	}
}
