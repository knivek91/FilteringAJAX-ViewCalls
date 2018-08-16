using System.Web.Mvc;
using Newtonsoft.Json;

namespace Controllers
{
    public class HomeController : Controller
    {
        [Filters.AuthorizeView]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Credential()
        {
            return View();
        }

        [Filters.AutorizarAJAX]
        [HttpPost]
        public string AjaxCall()
        {
            return "Done";
        }

        [HttpGet]
        public string CreateSession()
        {
            Session["MySession"] = new { Id = HttpContext.Session.SessionID };
            return JsonConvert.SerializeObject(Session["MySession"]);
        }

        [HttpGet]
        public string CleanSession()
        {
            Session["MySession"] = null;
            return "Clean";
        }

        [HttpGet]
        public string NullSession()
        {
            Session["MySession"] = null;
            return "Clean";
        }

    }
}