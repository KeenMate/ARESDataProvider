using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace AresDataProvider.Web
{
	public class WebApiApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();
			GlobalConfiguration.Configure(WebApiConfig.Register);
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);
		}

		protected void Application_BeginRequest(object sender, EventArgs e)
		{
			HttpCookie cookie = Request.Cookies.Get("Language");

			if (cookie?.Value != null)
			{
				Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(cookie.Value);
				Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(cookie.Value);
			}
			else
			{
				Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("cs-CZ");
				Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("cs-CZ");
			}
		}
	}
}
