using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Http;


namespace ECommerceSample
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            /*
             * Dikkat hem api routing hem de varsayılan mvc routing aynı projede kullanılacaksa:
             * Önce GlobalConfiguration.Configure(WebApiConfig.Register);
             * Sonra RouteConfig.RegisterRoutes(RouteTable.Routes);
             * 
             * kullanılmalı
             */
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
           
        }
    }
}
