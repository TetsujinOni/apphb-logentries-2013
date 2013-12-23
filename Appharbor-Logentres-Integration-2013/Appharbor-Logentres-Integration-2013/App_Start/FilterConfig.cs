using System.Web;
using System.Web.Mvc;

namespace Appharbor_Logentres_Integration_2013
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
