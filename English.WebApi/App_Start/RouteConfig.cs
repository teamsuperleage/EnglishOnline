using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace English.WebApi
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
           name: "AllCourse",
           url: "AllCourse.html",
           defaults: new { controller = "Course", action = "Courses"}
          );
            routes.MapRoute(
            name: "Course",
            url: "{controller}/{action}/{id}",
            defaults: new { Controller = "Course", action = "Detail", id = UrlParameter.Optional }
           );
            routes.MapRoute(
            name: "Login",
            url: "{controller}/{action}/{id}",
            defaults: new { Controller = "Account", action = "Login", id = UrlParameter.Optional }
           );
            routes.MapRoute(
            name: "Resgister",
            url: "{controller}/{action}/{id}",
            defaults: new { Controller = "Account", action = "Register", id = UrlParameter.Optional }
           );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.IgnoreRoute("{*botdetect}",
      new { botdetect = @"(.*)BotDetectCaptcha\.ashx" }); 
        }
    }
}
