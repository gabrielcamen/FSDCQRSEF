using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Ninject;
using SweetShop.CQRS;

namespace SweetShop
{
    public static class WebApiConfig
    {
        public static IKernel Container { get; private set; }
        
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            ConfigureContainer();
            
            
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        private static void ConfigureContainer()
        {
            Container = new StandardKernel( new SweetShopBindingModule(),
                new CQRSBindingModule());
        }
    }
}
