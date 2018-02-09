using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Cors;
using System.Web.Http.Cors;

namespace AresDataProvider.Web.Helpers
{
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = false)]
	public class EnableCorsByDomainAttribute : Attribute, ICorsPolicyProvider
	{
		private readonly CorsPolicy policy;

		public EnableCorsByDomainAttribute()
		{
			policy = new CorsPolicy
			{
				AllowAnyMethod = true,
				AllowAnyHeader = true
			};

			var originsString = Configuration.AllowedCorsDomains;
			if (String.IsNullOrEmpty(originsString)) return;
			foreach (var origin in originsString.Split(','))
			{
				policy.Origins.Add(origin);
			}
		}

		public Task<CorsPolicy> GetCorsPolicyAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			return Task.FromResult(policy);
		}
	}
}