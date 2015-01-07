using System.Web.Mvc;
using PAjaxMvc3.Helpers;

namespace PAjaxMvc3.Controllers
{
    public class ApplicationController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home";

            return PAjax();
        }

        public ActionResult Dinosaurs()
        {
            ViewBag.Title = "Dinosaurs";

            return PAjax();
        }

        public ActionResult Aliens()
        {
            ViewBag.Title = "Aliens";

            return PAjax();
        }

        protected ActionResult PAjax(
            string viewName = null,
            string masterName = null,
            object model = null)
        {
            return Request.IsPAjaxRequest() ?
                   PartialView(viewName, model) :
                   View(viewName, model) as ActionResult;
        }
    }
}