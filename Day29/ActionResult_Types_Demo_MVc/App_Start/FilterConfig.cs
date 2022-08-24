using System.Web;
using System.Web.Mvc;

namespace ActionResult_Types_Demo_MVc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
