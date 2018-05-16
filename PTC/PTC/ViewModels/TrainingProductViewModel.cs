using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Web;
using PTCData;

namespace PTC.ViewModels
{
	public class TrainingProductViewModel
	{
		public TrainingProductViewModel()
		{
			EventCommand = ViewModels.EventCommand.List.ToString();
			IsSearchAreaVisible = true;
			IsListAreaVisible = true;
			IsValid = true;
			Mode = "List";
			ProductForCreation = new TrainingProduct
			{
				ProductName = "",
				Price = 0,
				IntroductionDate = DateTime.Today,
				Url = ""
			};
		}

		public string Mode { get; set; }
		public bool IsValid { get; set; }
		public TrainingProduct ProductForCreation { get; set; }
		public string EventCommand { get; set; }
		public TrainingProduct SearchEntity { get; set; } = new TrainingProduct();
		public IEnumerable<TrainingProduct> Products { get; set; } = new List<TrainingProduct>();
		public bool IsDetailAreaVisible { get; set; }
		public bool IsSearchAreaVisible { get; set; }
		public bool IsListAreaVisible { get; set; }
		
	}
}
