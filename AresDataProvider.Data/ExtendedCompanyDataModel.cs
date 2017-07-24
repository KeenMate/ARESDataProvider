using System;
using System.Collections.Generic;

namespace AresDataProvider.Data
{
	public class ExtendedCompanyDataModel : CompanyDataModel
	{
		public class BoardMember
		{
			public string Role { get; set; }

			public string FullName { get; set; }

			public DateTime Born { get; set; }

			public AddressData Address { get; set; }

			public DateTime MemberStartDate { get; set; }

			public DateTime FunctionStartDate { get; set; }

			public DateTime? EndDate { get; set; }
		}

		public class ShareData
		{
			public int Amount { get; set; }

			public string ShareType { get; set; }

			public decimal ShareValue { get; set; }
		}

		public List<BoardMember> Members { get; } = new List<BoardMember>(5);

		public string BoardRuling { get; set; }

		public ShareData Share { get; set; } 
	}
}