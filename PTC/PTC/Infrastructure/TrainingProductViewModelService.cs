using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PTC.ViewModels;
using PTCData;

namespace PTC.Infrastructure
{
	public class TrainingProductRequestHandler
	{
		private readonly TrainingProductViewModel _vm;
		private readonly TrainingProductService _service;

		public TrainingProductRequestHandler(TrainingProductViewModel vm, TrainingProductService service)
		{
			_vm = vm;
			_service = service;
		}

		public TrainingProductViewModel HandleRequest()
		{
			switch (_vm.EventCommand.ToLowerInvariant())
			{
				case "list":
					return Get();
					break;
				case "add":
					//return View(vm);
					break;
				case "edit":
					//return View(vm);
					break;
				case "search":
					return SearchByName();
					break;

				case "resetsearch":
					return ResetSearch();
					break;
				default:
					throw new ArgumentOutOfRangeException();
			}

			return _vm;
		}

		private TrainingProductViewModel ResetSearch()
		{
			_vm.Products = _service.Get();
			return _vm;
		}

		private TrainingProductViewModel SearchByName()
		{
			var filteredProducts = 
				_service.Get()
					.Where(p => p.ProductName.StartsWith(_vm.SearchEntity.ProductName ?? string.Empty, 
						StringComparison.OrdinalIgnoreCase))
					.ToList();
			//var vm = new TrainingProductViewModel();
			_vm.Products = filteredProducts;
			return _vm;
		}

		private TrainingProductViewModel Get()
		{
			var vm = new TrainingProductViewModel();
			vm.Products = _service.Get();
			return vm;
		}
	}
}