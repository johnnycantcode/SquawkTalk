using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SquawkTalk
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Map all the routs on the DefaultController to user only ActionName 
            //(i.e. htt://www.SquawkTalk.net/AboutUs instead of htt://www.SquawkTalk.net/Default/AboutUs)
           // routes.MapDefaultController<Controllers.DefaultController>();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
