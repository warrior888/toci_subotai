using System.Web;
using System.Web.Mvc;

namespace Toci.MillShop.Ui.Naturals.Api
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
