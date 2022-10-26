using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Ejemplo1Asp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                //en las colecciones estan los arreglos
                //en las colecciones estan los maps se almacena como si fueran objetos
                //tienen un indice y un valor
                //en el action se especifica a donde quiere que vaya no se pone la extension
                //en este caso esta es la primera vista que va a mostrar
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "OperasBas", action = "Sumar", id = UrlParameter.Optional }
            );
        }
    }
}
