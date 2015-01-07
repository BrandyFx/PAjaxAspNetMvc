using System.Web.Helpers;
using System.Web.WebPages;

namespace PAjaxMvc3.Helpers
{
    public static class Pjax
    {
        public static HelperResult RenderBody(string selector, string container = "pjax-container", object options = null)
        {
            return new HelperResult(writer =>
            {
                writer.Write("<div id=\"" + container + "\">");
                ((WebPageBase) HelperPage.PageContext.Page).RenderBody().WriteTo(writer);
                writer.Write("</div>");
                writer.Write("<script>");
                writer.Write("(function ($) { ");
                writer.Write("$(function() { $(document).pjax('" );
                writer.Write( selector );
                writer.Write( "', '#" );
                writer.Write( container );
                writer.Write("'");
                if (options != null)
                {
                    writer.Write(", ");
                    Json.Write(options, writer);
                }
                writer.Write( "); });");
                writer.Write("})(jQuery);");
                writer.Write("</script>");
            });
        }
    }
}