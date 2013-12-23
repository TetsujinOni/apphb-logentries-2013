using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using log4net;

namespace Appharbor_Logentres_Integration_2013
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof (MvcApplication));
        protected void Application_Start()
        {
            logger.Info("Started example application.");
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            logger.ErrorFormat("{0} sent error with details {1}", sender, e);
        }
    }
}
