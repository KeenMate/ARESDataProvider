using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using AresDataProvider.Data;
using AresDataProvider.Data.Registry;
using AresDataProvider.Data.Basic;
using AresDataProvider.Data.ES;
using AresDataProvider.Data.RZP;

namespace AresDataProvider.Mappers
{
	public static class BaseMapper
	{
		public static BasicResultModel MapBasicData(ProviderData.Basic.Ares_odpovedi data)
		{
			return data.Odpoved.E == null
				? new BasicResultModel
				{
					Address = new BasicResultModel.AddressDataBasic
					{
						City = data.Odpoved.VBAS.AA.N,
						Country = data.Odpoved.VBAS.AA.NS,
						Street = data.Odpoved.VBAS.AA.NU,
						ZipCode = data.Odpoved.VBAS.AA.PSC,
						AddressCode = Convert.ToInt32(data.Odpoved.VBAS.AA.AU.KA),
						CityPartName = data.Odpoved.VBAS.AA.NMC,
						CountryCode = Convert.ToInt32(data.Odpoved.VBAS.AA.KS),
						DistrictName = data.Odpoved.VBAS.AA.NOK,
						DistrictPartName = data.Odpoved.VBAS.AA.NCO,
						HouseNumber = Convert.ToInt32(data.Odpoved.VBAS.AA.CD),
						ObjectCode = Convert.ToInt32(data.Odpoved.VBAS.AA.AU.KO),
						OrientationNumber = Convert.ToInt32(data.Odpoved.VBAS.AA.AU.CO)
					},
					Name = data.Odpoved.VBAS.OF.Text,
					PlaceOfEvidence = data.Odpoved.VBAS.ICO.Zdroj,
					TaxId = data.Odpoved.VBAS.ICO.Text,
					ScopeOfBusiness = data.Odpoved.VBAS.Obory_cinnosti?.Obor_cinnosti?.Select(x => x.T).ToList()
				}
				: new BasicResultModel
				{
					Error = data.Odpoved.E.ET,
					Address = new BasicResultModel.AddressDataBasic()
				};
		}

		public static ESResultModel MapESData(ProviderData.ES.Ares_odpovedi data)
		{
			return new ESResultModel
			{
				Items = data.Odpoved.Help == null
					? data.Odpoved.V?.S?.Select(company => new ESCompanyModel
					{
						Address = company.Jmn,
						Name = company.Ojm,
						TaxId = company.Ico
					}).ToList()
					: null,
				Errors = data.Odpoved.Help?.R,
				ItemsFound = data.Odpoved.Help == null
					? Convert.ToInt32(data.Odpoved.Pocet_zaznamu)
					: 0
			};
		}

		public static RegistryResultModel MapRegistryData(ProviderData.Registry.Ares_odpovedi data)
		{
			return data.Odpoved.Vypis_OR != null ? new RegistryResultModel
			{
				Address = new AddressData
				{
					City = data.Odpoved.Vypis_OR.ZAU.SI.N,
					Country = data.Odpoved.Vypis_OR.ZAU.SI.NS,
					Street = data.Odpoved.Vypis_OR.ZAU.SI.NU,
					ZipCode = data.Odpoved.Vypis_OR.ZAU.SI.PSC
				},
				CompanyName = data.Odpoved.Vypis_OR.ZAU.OF,
				Created = DateTime.ParseExact(data.Odpoved.Vypis_OR.ZAU.DZOR, "yyyy-MM-dd", new CultureInfo("cs-CZ")),
				Estate = data.Odpoved.Vypis_OR.KAP?.ZA?.VK != null ? Convert
						.ToInt64(
							data.Odpoved.Vypis_OR.KAP.ZA.VK.KC
								.Substring(0, data.Odpoved.Vypis_OR.KAP.ZA.VK.KC.IndexOf(';') == -1 ? data.Odpoved.Vypis_OR.KAP.ZA.VK.KC.Length : data.Odpoved.Vypis_OR.KAP.ZA.VK.KC.IndexOf(';') - 1))
					: 0L,
				EstatePercent = data.Odpoved.Vypis_OR.KAP?.ZA?.SPL?.PRC != null ? Convert.ToDecimal(data.Odpoved.Vypis_OR.KAP.ZA.SPL.PRC)
					: (decimal?) null,
				LegalForm = data.Odpoved.Vypis_OR.ZAU.PFO.NPF,
				ScopeOfBusiness = data.Odpoved.Vypis_OR.CIN != null ? data.Odpoved.Vypis_OR.CIN.PP.T
					: new List<string>(),
				TaxId = data.Odpoved.Vypis_OR.ZAU.ICO
			} : new RegistryResultModel
			{
				Error = data.Odpoved.E.ET
			};
		}

		public static ExtendedRegistryResultModel MapExtendedRegistryData(ProviderData.Registry.Ares_odpovedi data)
		{
			ExtendedRegistryResultModel d;
			if (data.Odpoved.Vypis_OR != null)
			{
				d = new ExtendedRegistryResultModel
				{
					Address = new AddressData
					{
						City = data.Odpoved.Vypis_OR.ZAU.SI.N,
						Country = data.Odpoved.Vypis_OR.ZAU.SI.NS,
						Street = data.Odpoved.Vypis_OR.ZAU.SI.NU,
						ZipCode = data.Odpoved.Vypis_OR.ZAU.SI.PSC
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
					Share = new ExtendedRegistryResultModel.ShareData
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

				d.Members.AddRange(data.Odpoved.Vypis_OR.SO?.CSO?.Select(x => new ExtendedRegistryResultModel.BoardMember
				{
					Address = new AddressData
					{
						City = x.C.FO?.B.N ?? string.Empty,
						Country = x.C.FO?.B.NS ?? string.Empty,
						Street = x.C.FO?.B.NU ?? string.Empty,
						ZipCode = x.C.FO?.B.PSC ?? string.Empty
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
				}) ?? new List<ExtendedRegistryResultModel.BoardMember>());
			}
			else
			{
				d = new ExtendedRegistryResultModel
				{
					Address = new AddressData(),
					Error = data.Odpoved.E.ET
				};
			}

			return d;
		}

		public static RZPResultModel MapRZPData(ProviderData.RZP.Ares_odpovedi data)
		{
			return new RZPResultModel
			{
				Address = new AddressData
				{
					City = data.Odpoved.Vypis_RZP.Adresy.A.N,
					Street = data.Odpoved.Vypis_RZP.Adresy.A.NU,
					ZipCode = data.Odpoved.Vypis_RZP.Adresy.A.PSC
				},
				Name = data.Odpoved.Vypis_RZP.ZAU.OF,
				ScopeOfBusiness = data.Odpoved.Vypis_RZP.ZI.Z?.Obory_cinnosti?.Obor_cinnosti.Select(x => x.T).ToList() ?? new List<string>
				{
					data.Odpoved.Vypis_RZP.ZI.Z?.PP
				},
				TaxId = data.Odpoved.Vypis_RZP.ZAU.ICO
			};
		}
	}
}