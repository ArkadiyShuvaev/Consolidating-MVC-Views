using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PTCData;


namespace PTC.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			var collection = new TrainingProductCollection();
			return View(collection.Get());
		}
		
	}
}