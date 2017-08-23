using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuickTrack.Controllers
{
    public class DispatchController : Controller
	{
		//
		// GET: /Dispatch/

		public ActionResult dispatchManagement()
        {
            return View ();
		}

		public ActionResult dispatchSchedule()
		{
			return View();
		}

        public ActionResult dispatchMonitoring()
        {
            return View ();
        }
    }
}
