using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
<<<<<<< HEAD
=======
using System.Web.Http;
>>>>>>> 5778c7425840c6f79de49cd3cd2a7f97a9bca9b3
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SistemaPerfiladoCriminal
{
<<<<<<< HEAD
    public class MvcApplication : System.Web.HttpApplication
=======
    public class WebApiApplication : System.Web.HttpApplication
>>>>>>> 5778c7425840c6f79de49cd3cd2a7f97a9bca9b3
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
<<<<<<< HEAD
=======
            GlobalConfiguration.Configure(WebApiConfig.Register);
>>>>>>> 5778c7425840c6f79de49cd3cd2a7f97a9bca9b3
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
