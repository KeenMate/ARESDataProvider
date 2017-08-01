using System.Collections.Generic;

namespace AresDataProvider.Data.Basic
{
	public class BasicResultModel
	{
		public class AddressDataBasic : AddressData
		{
			public int CountryCode { get; set; }

			public string DistrictName { get; set; }

			public string DistrictPartName { get; set; }

			public string CityPartName { get; set; }

			public int HouseNumber { get; set; }

			public int OrientationNumber { get; set; }

			public int AddressCode { get; set; }

			public int ObjectCode { get; set; }
		}

		public string TaxId { get; set; }

		public string PlaceOfEvidence { get; set; }

		public List<string> ScopeOfBusiness { get; set; }

		public string Name { get; set; }

		public AddressDataBasic Address { get; set; }

		public string Error { get; set; }
	}
}