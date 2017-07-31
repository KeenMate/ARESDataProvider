using System.IO;
using System.Net;
using System.Xml.Serialization;

namespace AresDataProvider.Helpers
{
	public static class WebRequestHelper
	{
		/// <summary>
		/// This method makes GET request to URL, excepting XML response, which deserializes to T type
		/// </summary>
		/// <typeparam name="T">Type, which should the answer be deserialized to</typeparam>
		/// <param name="url">Url for Request</param>
		/// <returns>Return Deserialized Class from xml</returns>
		public static T XmlWebRequestSequence<T>(string url)
		{
			WebRequest request = WebRequest.Create(url);

			request.Method = "GET";
			request.ContentType = "application/xml";

			WebResponse response = request.GetResponse();

			XmlSerializer serializer = new XmlSerializer(typeof(T));
			T result = default(T);
			using (Stream stream = response.GetResponseStream())
			{
				if (stream != null) result = (T) serializer.Deserialize(stream);
			}

			return result;
		}
	}
}