using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using log4net;
using log4net.Repository.Hierarchy;

namespace Appharbor_Logentres_Integration_2013
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof (MvcApplication));
        protected void Application_Start()
        {
            logger.Info("Starting example application.");
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            logger.Info("Started example application.");
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            if (logger.IsDebugEnabled)
            {
                NDC.Push("BeginRequest");
                logger.DebugFormat("{0} sent {1}", sender, e.GetType());
                NDC.Pop();
            }
        }
    }
}
