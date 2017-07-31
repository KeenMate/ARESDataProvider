namespace AresDataProvider.Data.Basic
{
	public class BasicResultModel
	{
		public string TaxId { get; set; }

		public string PlaceOfEvidence { get; set; }

		public string Name { get; set; }

		public AddressData Address { get; set; }

		public string Error { get; set; }
	}
}