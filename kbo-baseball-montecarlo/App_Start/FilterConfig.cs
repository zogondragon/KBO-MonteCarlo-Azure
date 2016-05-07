using System.Web;
using System.Web.Mvc;

namespace kbo_baseball_montecarlo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
