using System.Web;
using System.Web.Mvc;

namespace NorteParcial1CarlaRossi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
