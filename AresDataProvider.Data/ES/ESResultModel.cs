using System;
using System.Collections.Generic;

namespace AresDataProvider.Data.ES
{
	public class ESResultModel
	{
		public int ItemsFound { get; set; }

		public List<ESCompanyModel> Items { get; set; }

		public List<string> Errors { get; set; }

		public TimeSpan Time { get; set; }
	}
}