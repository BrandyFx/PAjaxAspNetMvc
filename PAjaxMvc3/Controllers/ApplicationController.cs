using System.Web.Mvc;
using PAjaxMvc3.Helpers;

namespace PAjaxMvc3.Controllers
{
    public class ApplicationController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home";

            return Pjax();
        }

        public ActionResult Dinosaurs()
        {
            ViewBag.Title = "Dinosaurs";

            return Pjax();
        }

        public ActionResult Aliens()
        {
            ViewBag.Title = "Aliens";

            return Pjax();
        }

        protected ActionResult Pjax(
            string viewName = null,
            string masterName = null,
            object model = null)
        {
            return Request.IsPAjaxRequest() ?
                   this.PJaxView(viewName, model) :
                   View(viewName, model) as ActionResult;
        }
    }
}