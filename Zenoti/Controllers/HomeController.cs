using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace Zenoti.Controllers
{
	public class HomeController : Controller
	{
		HomeManager homeManager = new HomeManager();

		public ActionResult Index ()
		{
			
			return View ();
		}

		public JsonResult GetBusinessList() {
			var response = new ServiceResponse();
			try {

				var start = Request.Params.Get(AppConstants.START);
				var size = Request.Params.Get(AppConstants.SIZE);
				var businessName = Request.Params.Get(AppConstants.BUSINESS_NAME);
				var businessType = Request.Params.Get(AppConstants.BUSINESS_TYPE);

				int startValue, sizeValue;

				startValue = !String.IsNullOrWhiteSpace(start) && int.TryParse(start, out startValue) ? Math.Max(0, startValue) : AppConstants.START_VALUE;
				sizeValue = !String.IsNullOrWhiteSpace(size) && int.TryParse(size, out sizeValue) ? Math.Max(0, sizeValue) : AppConstants.SIZE_VALUE;

				response.status = true;
				response.result = homeManager.GetBusinessList(startValue, sizeValue, businessName, businessType);

				return Json(response);
			} catch (Exception e){
				response.result = e.GetBaseException ().Message;
				return Json (response);
			}
		}
	}
}

