using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PTC.Infrastructure;
using PTC.ViewModels;
using PTCData;


namespace PTC.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			var handler = new TrainingProductViewModelManager(
				new TrainingProductViewModel(), new TrainingProductService());
			var vm = handler.HandleRequest();
			return View(vm);
		}

		[HttpPost]
		public ActionResult Index(TrainingProductViewModel vm)
		{
			if (!ModelState.IsValid)
			{
				return View(vm);
			}

			var handler = new TrainingProductViewModelManager(
				vm, new TrainingProductService());
			var newVm = handler.HandleRequest();

			//ModelState.Clear();

			return View(newVm);
		}
		
	}
}