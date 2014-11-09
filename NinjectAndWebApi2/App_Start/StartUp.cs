using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Owin;
using Ninject;
using Ninject.Web.Common.OwinHost;
using Ninject.Web.WebApi.OwinHost;
using NinjectAndWebApi2.Infrastructure.Modules;

// ensure that namespace is not NinectAndWebApi2.App_Start
namespace NinjectAndWebApi2
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var config = new HttpConfiguration();
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("text/html"));

            WebApiConfig.Register(config);

            appBuilder.UseWebApi(config);
            appBuilder.UseNinjectMiddleware(() => CreateKernel(config));
            appBuilder.UseNinjectWebApi(config);
        }

        public static IKernel CreateKernel(HttpConfiguration config)
        {
            var kernel = new StandardKernel();

            kernel.Load<PersonModule>();
            // load other modules here (or do other binding)

            return kernel;
        }
    }
}