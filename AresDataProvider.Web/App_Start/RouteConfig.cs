using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AresDataProvider.Web
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
					name: "Default",
					url: "{lang}/{controller}/{action}/{id}",
					defaults: new {lang = "cs-CZ", controller = "DemoView", action = "Index", id = UrlParameter.Optional }
			);
		}
	}
}
