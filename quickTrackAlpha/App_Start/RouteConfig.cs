using System.Web.Mvc;
using System.Web.Routing;

namespace quickTrackAlpha
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
			//Home Routes
			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "index", id = UrlParameter.Optional }
			);
			routes.MapRoute(
				name: "Default2",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "mainPage", id = UrlParameter.Optional }
			);

			//Asset Routes
			routes.MapRoute(
				name: "assetManagement",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Asset", action = "assetManagement", id = UrlParameter.Optional }
			);
			routes.MapRoute(
				name: "assetCheckInTransaction",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Asset", action = "assetCheckInTransaction", id = UrlParameter.Optional }
			);

			//Dispatch Routes
			routes.MapRoute(
				name: "dispatchManagement",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Dispatch", action = "dispatchManagement", id = UrlParameter.Optional }
			);

			//EPOD Routes
			routes.MapRoute(
				name: "epodManagement",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Epod", action = "epodManagement", id = UrlParameter.Optional }
			);

			//Inventory Routes
			routes.MapRoute(
				name: "inventoryManagement",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Inventory", action = "inventoryManagement", id = UrlParameter.Optional }
			);
			routes.MapRoute(
				name: "inventoryStock",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Inventory", action = "inventoryStock", id = UrlParameter.Optional }
			);

			//Preventive Routes
			routes.MapRoute(
				name: "preventiveMaintenanceManagement",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Preventive", action = "preventiveMaintenanceManagement", id = UrlParameter.Optional }
			);
        }
    }
}
