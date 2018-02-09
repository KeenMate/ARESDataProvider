using System;
using System.Configuration;
using System.Linq;
using System.Web.Configuration;

namespace AresDataProvider.Web.Helpers
{
	public static class Configuration
	{
		public static string AllowedCorsDomains => GetValue<string>("AllowedCorsDomains");

		private static T GetValue<T>(string name, string prefix = "")
		{
			string n = prefix.Length > 0 ? $"{prefix}:{name}" : $"{name}";

			if (
				ConfigurationManager.AppSettings.Keys.Cast<string>()
					.Any(x => x.Equals(n, StringComparison.InvariantCultureIgnoreCase)))
			{
				var val = ConfigurationManager.AppSettings[n];

				switch (typeof(T).Name.ToLower())
				{
					case "int16":
					{
						int v = Convert.ToInt16(val);
						return (T)Convert.ChangeType(v, typeof(T));
					}
					case "int32":
					{
						int v = Convert.ToInt32(val);
						return (T)Convert.ChangeType(v, typeof(T));
					}
					case "string":
					{
						return (T)Convert.ChangeType(val, typeof(T));
					}
					case "boolean":
					{
						bool v = bool.Parse(val);
						return (T)Convert.ChangeType(v, typeof(T));
					}
					default:
					{
						return default(T);
					}
				}
			}

			return default(T);
		}
	}
}