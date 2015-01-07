using System;
using System.Web.Mvc;

namespace PAjaxMvc3.Helpers
{
    public class PjaxViewResult : PartialViewResult
    {
        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
                throw new ArgumentNullException("context");
            if (string.IsNullOrEmpty(ViewName))
                ViewName = context.RouteData.GetRequiredString("action");
            ViewEngineResult viewEngineResult = null;
            if (View == null)
            {
                viewEngineResult = FindView(context);
                View = viewEngineResult.View;
            }
            var output = context.HttpContext.Response.Output;
            View.Render(new ViewContext(context, View, ViewData, TempData, output), output);
            var title = ViewData["Title"];
            if (title != null)
                output.Write("<title>" + title + "</title>");
            if (viewEngineResult == null)
                return;
            viewEngineResult.ViewEngine.ReleaseView(context, View);
        }
    }
}