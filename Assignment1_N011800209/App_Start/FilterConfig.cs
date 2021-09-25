using System.Web;
using System.Web.Mvc;

namespace Assignment1_N011800209
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
