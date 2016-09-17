using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Web_AnhNgoc_Edition1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
             name: "XemChiTietKhoahoc",
               url: "Chitiet/{id}",
             defaults: new { controller = "ChiTiet_Content", action = "Chitiet_Khoahoc", id = UrlParameter.Optional }

             );
            //Admin
            //Login
            routes.MapRoute(
            name: "Login",
              url: "Login",
            defaults: new { controller = "LoginAdmin", action = "Login", id = UrlParameter.Optional }

            );
            //Logout
            routes.MapRoute(
        name: "Logout",
          url: "Logout",
        defaults: new { controller = "LoginAdmin", action = "DangXuat", id = UrlParameter.Optional }
              //Qlbaiviet
              );
            routes.MapRoute(
        name: "Quanlybaiviet",
          url: "Quanlybaiviet",
        defaults: new { controller = "Manage_Aricle_Detail", action = "qlBaiViet", id = UrlParameter.Optional }

          );
            routes.MapRoute(
        name: "Quanlykhoahoc",
            url: "Quanlykhoahoc",
        defaults: new { controller = "Manage_Aricle_Detail", action = "qlKhoahoc", id = UrlParameter.Optional }

          );
            routes.MapRoute(
 name: "ManaMenuCap3",
     url: "ManaMenuCap3",
 defaults: new { controller = "Mana_Menu", action = "Mana_Menu_Child_ChildList", id = UrlParameter.Optional }

   );
            routes.MapRoute(
     name: "ManaMenuCap2",
         url: "ManaMenuCap2",
     defaults: new { controller = "Mana_Menu", action = "Mana_Menu_ChildList", id = UrlParameter.Optional }

       );


            routes.MapRoute(
             name: "ManaMenuCap1",
             url: "ManaMenuCap1",
             defaults: new { controller = "Mana_Menu", action = "Mana_Menu_ParentList", id = UrlParameter.Optional }
         );
            routes.MapRoute(
      name: "ManaUser",
      url: "ManaUser",
      defaults: new { controller = "Manage_User", action = "Index", id = UrlParameter.Optional }
  );

            routes.MapRoute(
            name: "Default",
            url: "{controller}/{action}/{id}",
            defaults: new { controller = "Home", action = "Home_Page", id = UrlParameter.Optional }
        );


        }
    }
}
