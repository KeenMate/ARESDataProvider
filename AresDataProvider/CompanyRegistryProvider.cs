using System;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;
using AresDataProvider.Data;

namespace AresDataProvider
{
	public class CompanyRegistryProvider
	{
		public string BaseUrl { get; set; } = "http://wwwinfo.mfcr.cz/cgi-bin/ares/darv_or.cgi";

		public CompanyDataModel GetCompanyData(string taxId = "", string city = "", string name = "", bool extended = false)
		{
			Data.CompanyRegister.Ares_odpovedi result = webRequestSequence<Data.CompanyRegister.Ares_odpovedi>(prepareUrl(taxId, name, city));

			return extended ? Mappers.RegistryMapper.MapExtendedData(result) : Mappers.RegistryMapper.MapBaseData(result);
		}

		private string prepareUrl(string taxId, string name, string city)
		{
			StringBuilder b = new StringBuilder();
			b.Append(BaseUrl);
			if (taxId != "")
			{
				b.Append($"?ico={taxId}");
				return b.ToString();
			}
			if (name != "")
				b.Append($"?obch_jm={name}");
			if (city != "")
				b.Append($"&obec={city}");

			return b.ToString();
		}

		private static T webRequestSequence<T>(string url)
		{
			WebRequest request = WebRequest.Create(url);

			request.Method = "GET";
			request.ContentType = "application/xml";

			WebResponse response = request.GetResponse();

			XmlSerializer serializer = new XmlSerializer(typeof(T));
			T result;
			using (Stream stream = response.GetResponseStream())
			{
				result = (T)serializer.Deserialize(stream);
			}

			return result;
		}
	}
}