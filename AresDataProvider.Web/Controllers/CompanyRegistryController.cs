using System.Web.Http;
using System.Web.Http.Cors;
using AresDataProvider.Data;

namespace AresDataProvider.Web.Controllers
{
	[EnableCors("https://keenmate.sharepoint.com", "*", "*")]
	public class CompanyRegistryController : ApiController
	{
		[HttpGet]
		public CompanyDataModel By(string taxId, bool extended = false)
		{
			if (taxId.Length != 8)
				return null;

			CompanyRegistryProvider provider = new CompanyRegistryProvider();

			return provider.GetCompanyData(taxId, extended);
		}
	}
}