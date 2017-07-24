using System.Collections.Generic;

namespace AresDataProvider.Data
{
	public class CompanySearchResult
	{
		public int ItemsFound { get; set; }

		public List<CompanySearchItem> Items { get; set; }

		public List<string> Errors { get; set; }
	}
}