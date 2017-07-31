using System.Collections.Generic;

namespace AresDataProvider.Data.RZP
{
	public class RZPResultModel
	{
		public string TaxId { get; set; }

		public string Name { get; set; }

		public AddressData Address { get; set; }

		public List<string> ScopeOfBusiness { get; set; }
	}
}