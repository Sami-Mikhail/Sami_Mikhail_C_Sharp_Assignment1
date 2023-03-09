using System.Web;
using System.Web.Mvc;

namespace Sami_Mikhail_C_Sharp_Assignment1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
