using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace NinjectAndWebApi2
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // don't use this if using owin
            //GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
