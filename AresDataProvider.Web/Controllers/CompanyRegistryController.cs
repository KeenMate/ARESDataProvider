using System;
using System.Web.Http;
using System.Web.Http.Cors;
using AresDataProvider.Data;

namespace AresDataProvider.Web.Controllers
{
	[EnableCors("https://keenmate.sharepoint.com", "*", "*")]
	public class CompanyRegistryController : ApiController
	{
		[HttpGet]
		public CompanyDataModel By(string taxId = "", bool extended = false)
		{
			int x;
			if (taxId.Length != 8 || !int.TryParse(taxId, out x))
				return new ExtendedCompanyDataModel
				{
					Error = "Tax ID is not valid"
				};

			CompanyRegistryProvider provider = new CompanyRegistryProvider();

			return provider.GetCompanyData(taxId, extended);
		}
	}
}