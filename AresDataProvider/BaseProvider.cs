using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;
using NLog;

namespace AresDataProvider
{
	public abstract class BaseProvider
	{
		public ILogger Logger { get; set; }

		public Guid CorrelationId { get; set; }

		public string BaseUrl { get; set; }

		public string PrepareUrl(Dictionary<string, string> query)
		{
			StringBuilder b = new StringBuilder();

			b.Append($"{BaseUrl}?");

			if (query.ContainsKey("ico"))
			{
				if (query["ico"] == "")
				{
					query.Remove("ico");
					if (query.ContainsKey("obec"))
					{
						if (query["obec"] == "")
						{
							query.Remove("obec");
						}
					}
				}
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

			url += "&max_poc=200";
			//url += "&filtr=1";

			return url;
		}
	}
}