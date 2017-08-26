using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace quickTrackAlpha.Controllers
{
    public class ReportController : Controller
    {

        [Route("Report/reports")]
        public ActionResult reports()
        {
			ViewBag.Message = "Sample only. Do not Copy.";
			ViewBag.Message2 = "Thank You!";
            return View ();
        }

        [Route("Report/Contact")]
		public ActionResult Contact()
		{
			var product = "Product";
			TempData["myTempData"] = product;
			return RedirectToAction("About");
		} 

		[Route("Report/About")]
		public ActionResult About()
		{
			var product = TempData["myTempData"];
			if (product != null)
			{
				ViewBag.Message = "Sucess."; // this will output "beer"
				ViewBag.Message2 = product;
			}
			return View();
		}

		[Route("Report/sampleViewData")]
		public ActionResult sampleViewData()
		{
			ViewData.Add("Id", 1);
			ViewData.Add(new KeyValuePair<string, object>("Name", "Bill"));
			ViewData.Add(new KeyValuePair<string, object>("Age", 20));

			return View();
		}
    }
}
