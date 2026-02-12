using System.Web;
using System.Web.Mvc;

namespace WebApplication3_codefirst_Empdepdsg_layout_101
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
