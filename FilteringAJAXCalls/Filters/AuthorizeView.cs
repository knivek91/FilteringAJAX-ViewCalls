using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Filters
{
    public class AuthorizeView : ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            if (HttpContext.Current.Session["MySession"] == null)
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary
                    {
                        { "controller", "Home" },
                        { "action", "Credential" }
                    });
            }

            base.OnActionExecuting(filterContext);
        }

    }
}