using System;
using System.Collections.Generic;

namespace AresDataProvider.Data.Registry
{
	public class RegistryResultModel
	{
		public string CompanyName { get; set; }

		public DateTime Created { get; set; }

		public string TaxId { get; set; }

		public long Estate { get; set; }

		public decimal? EstatePercent { get; set; }

		public AddressData Address { get; set; }

		public string LegalForm { get; set; }

		public List<string> ScopeOfBusiness { get; set; }

		public string Error { get; set; }

		public TimeSpan TimeTaken { get; set; }
	}
}