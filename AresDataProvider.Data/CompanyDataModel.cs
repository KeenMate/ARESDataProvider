using System;
using System.Collections.Generic;

namespace AresDataProvider.Data
{
	public class CompanyDataModel
	{
		public class AddressData
		{
			public string Country { get; set; }

			public string City { get; set; }

			public string Street { get; set; }

			public string ZIPCode { get; set; }
		}

		public string CompanyName { get; set; }

		public DateTime Created { get; set; }

		public string TaxId { get; set; }

		public long Estate { get; set; }

		public decimal EstatePercent { get; set; }

		public AddressData Address { get; set; }

		public string LegalForm { get; set; }

		public List<string> ScopeOfBusiness { get; set; }

		public string Error { get; set; }
	}
}