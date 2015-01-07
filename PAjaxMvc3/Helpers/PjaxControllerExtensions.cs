using System.Web.Mvc;

namespace PAjaxMvc3.Helpers
{
    public static class PjaxControllerExtensions
    {
        public static PjaxViewResult PJaxView(this Controller controller)
        {
            return PJaxView(controller, null, null);
        }

        public static PjaxViewResult PJaxView(this Controller controller, object model)
        {
            return PJaxView(controller, null, model);
        }

        public static PjaxViewResult PJaxView(this Controller controller, string viewName)
        {
            return PJaxView(controller, viewName, null);
        }

        public static PjaxViewResult PJaxView(this Controller controller, string viewName, object model)
        {
            if (model != null)
                controller.ViewData.Model = model;
           
            return new PjaxViewResult
            {
                ViewName = viewName,
                ViewData = controller.ViewData,
                TempData = controller.TempData,
                ViewEngineCollection = controller.ViewEngineCollection
            };
        }
    }
}