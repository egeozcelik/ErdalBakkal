using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ErdalBakkal.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "ProductList",
               url: "products",
               defaults: new { controller = "Product", action = "Index" }
           );

            routes.MapRoute(
              name: "ProductAdd",
              url: "product/add",
              defaults: new { controller = "Product", action = "Add" }
          );

            routes.MapRoute(
             name: "ProductEdit",
             url: "product/edit/{id}",
             defaults: new { controller = "Product", action = "Edit", id = UrlParameter.Optional }
         );

            routes.MapRoute(
           name: "ProductDelete",
           url: "product/delete/{id}",
           defaults: new { controller = "Product", action = "Delete", id = UrlParameter.Optional }
       );

            routes.MapRoute(
              name: "CategoryList",
              url: "categories",
              defaults: new { controller = "Category", action = "Index" }
          );

            routes.MapRoute(
              name: "CategoryAdd",
              url: "category/add",
              defaults: new { controller = "Category", action = "Add" }
          );

            routes.MapRoute(
                   name: "CategoryDelete",
                   url: "categoryDelete/{id}",
                   defaults: new { controller = "Category", action = "Delete", id = UrlParameter.Optional }
               );

            routes.MapRoute(
                 name: "CategoryUpdate",
                 url: "categoryEdit/{id}",
                 defaults: new { controller = "Category", action = "Edit", id = UrlParameter.Optional }
             );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
