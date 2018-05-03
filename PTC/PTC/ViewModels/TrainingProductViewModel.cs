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

		public string EventCommand { get; set; }
		public TrainingProduct SearchEntity { get; set; } = new TrainingProduct();
		public IEnumerable<TrainingProduct> Products { get; set; } = new List<TrainingProduct>();
		public TrainingProductViewModel()
		{
			EventCommand = ViewModels.EventCommand.List.ToString();
		}
	}
}