using System.Web;
using System.Web.Mvc;

namespace Filters
{
    public class AutorizarAJAXAttribute : AuthorizeAttribute
    {

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {

            if (filterContext.HttpContext.Request.IsAjaxRequest())
            {
                if (filterContext.HttpContext.Request.IsAjaxRequest())
                {
                    if (HttpContext.Current.Session["MySession"] == null)
                    {
                        filterContext.HttpContext.Response.StatusCode = 999;
                        filterContext.Result = null;
                    }
                }
            }
        }

    }
}