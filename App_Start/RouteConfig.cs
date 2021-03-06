﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EasyFarm
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "Invernadero",
               url: "{controller}/{action}/{TipoCultivo}/{Modo}/{Temperatura}/{HumedadRelativa}/{HumedadSuelo}/{parametros}/{Riego}/{TemporizadorRiego}/{Flujo}"
           );
        }
    }
}
