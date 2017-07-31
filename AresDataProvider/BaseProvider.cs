using System;
using System.Collections.Generic;
using System.Text;
using NLog;

namespace AresDataProvider
{
	public abstract class BaseProvider
	{
		public ILogger Logger { get; set; }

		public Guid CorrelationId { get; set; }

		public string BaseUrl { get; set; }

		//public virtual string PrepareUrl(string taxId)
		//{
		//	StringBuilder b = new StringBuilder();

		//	b.Append(BaseUrl);
		//	b.Append($"?ico={taxId}");

		//	return b.ToString();
		//}

		//public virtual string PrepareUrl(string city, string name)
		//{
		//	StringBuilder b = new StringBuilder();

		//	b.Append(BaseUrl);
		//	if (city != string.Empty)
		//		b.Append($"?obec={city}");
		//	if (name != string.Empty)
		//		b.Append($"&obch_jm={name}");

		//	return b.ToString();
		//}

		public string PrepareUrl(Dictionary<string, string> query)
		{
			StringBuilder b = new StringBuilder();

			b.Append($"{BaseUrl}?");

			if (query.ContainsKey("ico"))
			{
				if (query["ico"] == "")
					query.Remove("ico");
				else
				{
					b.Append($"ico={query["ico"]}");
					goto SkipForEach;
				}
			}

			foreach (KeyValuePair<string, string> pair in query)
			{
				b.Append(pair.Key + "=" + pair.Value + "&");
			}

			SkipForEach: 
			string url = b.ToString().TrimEnd('&');

			return url;
		}
	}
}