using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml.Serialization;
using AresDataProvider.Data;

namespace AresDataProvider
{
	public class CompanySearchProvider
	{
		public string BaseUrl { get; } = "https://wwwinfo.mfcr.cz/cgi-bin/ares/ares_es.cgi";

		public CompanySearchProvider() { }

		public CompanySearchProvider(string baseUrl)
		{
			BaseUrl = baseUrl;
		}

		public CompanySearchResult Search(string name = "", string city = "", string taxId = "")
		{
			List<string> queryParts = new List<string>(5);

			string query = prepareQuery(name, city, taxId, queryParts);

			Ares_odpovedi ares = webRequestXml<Ares_odpovedi>(BaseUrl + query);

			CompanySearchResult result;
			if (ares.Odpoved.Help != null)
			{
				result = new CompanySearchResult
				{
					ItemsFound = 0,
					Items = null,
					Errors = ares.Odpoved.Help.R
				};
			}
			else
			{
				result = new CompanySearchResult
				{
					ItemsFound = Convert.ToInt16(ares.Odpoved.Pocet_zaznamu),
					Items = ares.Odpoved.V.S.Select(x => new CompanySearchItem
					{
						Address = x.Jmn,
						Name = x.Ojm,
						TaxId = x.Ico
					}).ToList(),
					Errors = null
				};
			}

			return result;
		}

		private static string prepareQuery(string name, string city, string taxId, List<string> queryParts)
		{
			if (name != string.Empty)
				queryParts.Add("obch_jm=" + name);
			if (city != string.Empty)
				queryParts.Add("obec=" + city);
			if (taxId != string.Empty)
				queryParts.Add("ico=" + taxId);

			StringBuilder query = new StringBuilder();

			query.Append("?");

			for (int i = 0; i < queryParts.Count; i++)
			{
				if (i > 0)
				{
					query.Append("&");
				}
				query.Append(queryParts[i]);
			}

			return query.ToString();
		}

		public CompanySearchResult SearchByTaxId(string taxId)
		{
			Ares_odpovedi ares = taxId.Length != 8 ? null : webRequestXml<Ares_odpovedi>(BaseUrl + "?ico=" + taxId);
			CompanySearchResult result;

			if (ares != null && ares.Odpoved.Help == null)
			{
				result = new CompanySearchResult
				{
					ItemsFound = Convert.ToInt16(ares.Odpoved.Pocet_zaznamu),
					Items = ares.Odpoved.V.S.Select(x => new CompanySearchItem
					{
						Address = x.Jmn,
						Name = x.Ojm,
						TaxId = x.Ico
					}).ToList()
				};
			}
			else if (ares.Odpoved.Help != null)
			{
				result = new CompanySearchResult
				{
					ItemsFound = 0,
					Items = null,
					Errors = ares.Odpoved.Help.R
				};
			}
			else
				return null;
			return result;
		}

		/// <summary>
		/// This makes request to Url and awaits XML response, which is converted
		/// </summary>
		/// <typeparam name="T">type, what should return be converted to </typeparam>
		/// <param name="url">Url containing query</param>
		/// <returns></returns>
		private T webRequestXml<T>(string url)
		{
			WebRequest request = WebRequest.Create(url);

			request.Method = "GET";
			request.ContentType = "application/xml";

			WebResponse webResponse = request.GetResponse();

			T response;
			XmlSerializer serializer = new XmlSerializer(typeof(T));

			using (Stream stream = webResponse.GetResponseStream())
			{
				response = (T)serializer.Deserialize(stream);
			}

			return response;
		}
	}
}