using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuickTrack.Controllers
{
    public class AssetController : Controller
	{
		//
		// GET: /Asset/

		public ActionResult assetManagement()
		{
			return View();
		}
		public ActionResult assetCheckInTransaction()
        {
            return View ();
        }
    }
}
