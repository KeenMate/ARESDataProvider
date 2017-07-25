using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using AresDataProvider.Data;

namespace AresDataProvider.Mappers
{
	public static class RegistryMapper
	{
		public static CompanyDataModel MapBaseData(Data.CompanyRegister.Ares_odpovedi data)
		{
			return data.Odpoved.Vypis_OR != null ? new CompanyDataModel
			{
				Address = new CompanyDataModel.AddressData
				{
					City = data.Odpoved.Vypis_OR.ZAU.SI.N,
					Country = data.Odpoved.Vypis_OR.ZAU.SI.NS,
					Street = data.Odpoved.Vypis_OR.ZAU.SI.NU,
					ZIPCode = data.Odpoved.Vypis_OR.ZAU.SI.PSC
				},
				CompanyName = data.Odpoved.Vypis_OR.ZAU.OF,
				Created = DateTime.ParseExact(data.Odpoved.Vypis_OR.ZAU.DZOR, "yyyy-MM-dd", new CultureInfo("cs-CZ")),
				Estate = data.Odpoved.Vypis_OR.KAP != null ? Convert
					.ToInt64(
						data.Odpoved.Vypis_OR.KAP.ZA.VK.KC
							.Substring(0, data.Odpoved.Vypis_OR.KAP.ZA.VK.KC.IndexOf(';') - 1))
					: 0,
				EstatePercent = data.Odpoved.Vypis_OR.KAP != null ? Convert.ToDecimal(data.Odpoved.Vypis_OR.KAP.ZA.SPL?.PRC ?? string.Empty)
					: 0,
				LegalForm = data.Odpoved.Vypis_OR.ZAU.PFO.NPF,
				ScopeOfBusiness = data.Odpoved.Vypis_OR.CIN != null ? data.Odpoved.Vypis_OR.CIN.PP.T
					: new List<string>(),
				TaxId = data.Odpoved.Vypis_OR.ZAU.ICO
			} : new CompanyDataModel
			{
				Error = data.Odpoved.E.ET
			};
		}

		public static ExtendedCompanyDataModel MapExtendedData(Data.CompanyRegister.Ares_odpovedi data)
		{
			ExtendedCompanyDataModel d;
			if (data.Odpoved.Vypis_OR != null)
			{
				d = new ExtendedCompanyDataModel
				{
					Address = new CompanyDataModel.AddressData
					{
						City = data.Odpoved.Vypis_OR.ZAU.SI.N,
						Country = data.Odpoved.Vypis_OR.ZAU.SI.NS,
						Street = data.Odpoved.Vypis_OR.ZAU.SI.NU,
						ZIPCode = data.Odpoved.Vypis_OR.ZAU.SI.PSC
					},
					CompanyName = data.Odpoved.Vypis_OR.ZAU.OF,
					Created = DateTime.ParseExact(data.Odpoved.Vypis_OR.ZAU.DZOR, "yyyy-mm-dd", new CultureInfo("cs-CZ")),
					Estate = data.Odpoved.Vypis_OR.KAP != null ?
						Convert
							.ToInt64(
								data.Odpoved.Vypis_OR.KAP.ZA.VK.KC.Contains(';') ? data.Odpoved.Vypis_OR.KAP.ZA.VK.KC
									.Substring(0, data.Odpoved.Vypis_OR.KAP.ZA.VK.KC.IndexOf(';') - 1)
									: data.Odpoved.Vypis_OR.KAP.ZA.VK.KC)
						: 0,
					EstatePercent = data.Odpoved.Vypis_OR.KAP != null ? Convert.ToDecimal(data.Odpoved.Vypis_OR.KAP.ZA.SPL?.PRC ?? "0")
						: 0,
					LegalForm = data.Odpoved.Vypis_OR.ZAU.PFO.NPF,
					ScopeOfBusiness = data.Odpoved.Vypis_OR.CIN != null ? data.Odpoved.Vypis_OR.CIN.PP.T
						: new List<string>(),
					TaxId = data.Odpoved.Vypis_OR.ZAU.ICO,
					BoardRulling = data.Odpoved.Vypis_OR.SO != null ? data.Odpoved.Vypis_OR.SO.T
						: string.Empty,
					Share = new ExtendedCompanyDataModel.ShareData
					{
						Amount = data.Odpoved.Vypis_OR.KAP != null ?
							Convert
								.ToInt32(
									data.Odpoved.Vypis_OR.KAP.Akcie?.EM?.Pocet ?? "0")
							: 0,
						ShareType = data.Odpoved.Vypis_OR.KAP != null ?
							data.Odpoved.Vypis_OR.KAP.Akcie?.EM?.DA ?? "None"
							: "None",
						ShareValue = data.Odpoved.Vypis_OR.KAP != null ?
							Convert
								.ToDecimal(
									data.Odpoved.Vypis_OR.KAP.Akcie?.EM?.H?.Substring(0, data.Odpoved.Vypis_OR.KAP.Akcie.EM.H.IndexOf(';')) ?? "0")
							: 0
					}
				};

				d.Members.AddRange(data.Odpoved.Vypis_OR.SO?.CSO?.Select(x => new ExtendedCompanyDataModel.BoardMember
				{
					Address = new CompanyDataModel.AddressData
					{
						City = x.C.FO?.B.N ?? string.Empty,
						Country = x.C.FO?.B.NS ?? string.Empty,
						Street = x.C.FO?.B.NU ?? string.Empty,
						ZIPCode = x.C.FO?.B.PSC ?? string.Empty
					},
					Born = x.C.FO != null ? DateTime.ParseExact(x.C.FO?.DN, "yyyy-MM-dd", new CultureInfo("cs-CZ"))
						: (DateTime?)null,
					EndDate = null,
					FullName = x.C.FO?.J ?? "" + " " + x.C.FO?.P,
					Role = x.C.F,
					MemberStartDate = x.C.CLE != null ? DateTime.ParseExact(x.C.CLE?.DZA, "yyyy-MM-dd", new CultureInfo("cs-CZ"))
						: (DateTime?)null,
					FunctionStartDate = x.C.VF != null ? DateTime.ParseExact(x.C.VF.DZA, "yyyy-MM-dd", new CultureInfo("cs-CZ"))
						: (DateTime?)null
				}) ?? new List<ExtendedCompanyDataModel.BoardMember>());
			}
			else
			{
				d = new ExtendedCompanyDataModel
				{
					Error = data.Odpoved.E.ET
				};
			}

			return d;
		}
	}
}