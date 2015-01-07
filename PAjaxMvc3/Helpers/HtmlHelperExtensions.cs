using System.Web;
using System.Web.Mvc;

namespace PAjaxMvc3.Helpers
{
    public static class HtmlHelperExtensions
    {
        public static IHtmlString PageTitle(this HtmlHelper instance)
        {
            var title = instance.ViewData["Title"] == null ?
                        string.Empty :
						instance.ViewData["Title"] + " - PAjax with ASP.NET MVC";

            return instance.Raw("<title>" + title + "</title>");
        }
    }
}