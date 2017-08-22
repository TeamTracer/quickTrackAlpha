using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuickTrack.Controllers
{
    public class InventoryController : Controller
	{
		//
		// GET: /Inventory/

		public ActionResult inventoryManagement()
        {
            return View ();
		}

		public ActionResult inventoryStock()
		{
			return View();
		}
    }
}
