using System.Web.Http;
using System.Web.Http.Cors;
using AresDataProvider.Data;


namespace AresDataProvider.Web.Controllers
{
	[EnableCors(origins: "https://keenmate.sharepoint.com", methods: "*", headers: "*")]
	public class SearchController : ApiController
	{
		[HttpGet]
		public CompanySearchResult By(string name = "", string city = "", string taxId = "")
		{
			CompanySearchProvider provider = new CompanySearchProvider();

			CompanySearchResult result = provider.Search(name, city, taxId);

			return result;
		}

		[HttpGet]
		public CompanySearchResult ByTaxId(string taxId)
		{
			if (taxId.Length != 8)
				return null;

			CompanySearchProvider provider = new CompanySearchProvider();

			CompanySearchResult response = provider.SearchByTaxId(taxId);

			return response;
		}
	}
}
