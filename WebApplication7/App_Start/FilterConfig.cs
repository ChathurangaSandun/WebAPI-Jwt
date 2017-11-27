using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using AuthorizeAttribute = System.Web.Mvc.AuthorizeAttribute;

namespace WebApplication7
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new AuthorizeAttribute());
        }
        
    }
}
