using System;
using System.Web;

namespace PAjaxMvc3.Helpers
{
    public static class HttpRequestBaseExtensions
    {
        public static bool IsPAjaxRequest(this HttpRequestBase intance)
        {
            var header = intance.Headers["X-PJAX"] ?? string.Empty;

            var result = header.Equals(
                bool.TrueString, StringComparison.OrdinalIgnoreCase);

            return result;
        }
    }
}