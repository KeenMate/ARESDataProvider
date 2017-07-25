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
		public CompanyDataModel By(string taxId = "", string city = "", string name = "", bool extended = false)
		{
			if ((taxId.Length != 8 || !int.TryParse(taxId, out var x)) && city == "" && name == "")
				return new ExtendedCompanyDataModel
				{
					Error = "Tax ID is not valid"
				};
			if (
				city == string.Empty
				&& name == string.Empty
			)
				return new ExtendedCompanyDataModel
				{
					Error = "Query is empty"
				};

			CompanyRegistryProvider provider = new CompanyRegistryProvider();

			return provider.GetCompanyData(taxId, city, name, extended);
		}
	}
}