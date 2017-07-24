using System;
using System.Globalization;
using System.Threading;
using System.Web.Mvc;

namespace AresDataProvider.Web.Controllers
{
	public class DemoViewController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		protected override void OnActionExecuting(ActionExecutingContext filterContext)
		{
			try
			{
				Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture((string)filterContext.RouteData.Values["lang"]);
				Thread.CurrentThread.CurrentUICulture = new CultureInfo((string)filterContext.RouteData.Values["lang"]);
			}
			catch(Exception) { }
		}
	}
}