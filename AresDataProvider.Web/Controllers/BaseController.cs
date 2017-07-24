using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace AresDataProvider.Web.Controllers
{
	public class BaseController : Controller
	{
		protected override void OnActionExecuting(ActionExecutingContext filterContext)
		{
			var x = filterContext.RouteData;
			base.OnActionExecuting(filterContext);
		}

		protected override IAsyncResult BeginExecute(RequestContext requestContext, AsyncCallback callback, object state)
		{
			return base.BeginExecute(requestContext, callback, state);
		}

		protected override void OnResultExecuted(ResultExecutedContext filterContext)
		{
			base.OnResultExecuted(filterContext);
		}
	}
}