using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Unity;
using WebApiUnity.Repository;

namespace WebApiUnity
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {



            var container = new UnityContainer();
            container.RegisterType<IRepository, Repositoryi>();
            config.DependencyResolver = new UnityResolver(container);



            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
