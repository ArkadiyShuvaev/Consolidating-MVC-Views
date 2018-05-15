using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PTC.ViewModels;
using PTCData;

namespace PTC.Infrastructure
{
	public class TrainingProductViewModelManager
	{
		private readonly TrainingProductViewModel _vm;
		private readonly TrainingProductService _service;

		public TrainingProductViewModelManager(TrainingProductViewModel vm, TrainingProductService service)
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
				case "addproduct":
					AddProduct();
					Get();
					ToggleToListView();
					break;
				case "cancelproduct":
					Get();
					ToggleToListView();
					break;
				case "add":
					ToggleToAddProductView();
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

		private void AddProduct()
		{
			if (_vm.ProductForCreation == null)
			{
				throw new ArgumentNullException(nameof(_vm.ProductForCreation));
			}

			_service.Add(_vm.ProductForCreation);

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

		private void ToggleToListView()
		{
			_vm.IsSearchAreaVisible = true;
			_vm.IsDetailAreaVisible = false;
			_vm.IsListAreaVisible = false;
		}

		private void ToggleToAddProductView()
		{
			_vm.IsSearchAreaVisible = false;
			_vm.IsDetailAreaVisible = true;
			_vm.IsListAreaVisible = false;
		}
	}
}