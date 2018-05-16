using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PTCData
{
    public class TrainingProduct
    {
	    public int ProductId { get; set; }
		[DisplayName("Product Name")]
		[Required(ErrorMessage = "Product name must be filled in.")]
		[StringLength(150, MinimumLength = 4, ErrorMessage = "Product name must be greater than {2} and less than {1} symbols.")]
		public string ProductName { get; set; }
		[Range(typeof(DateTime), "1/1/2000", "12/31/2020", ErrorMessage = "Introduction Date must be greather")]
	    public DateTime IntroductionDate { get; set; }
	    public string Url { get; set; }
	    public decimal Price { get; set; }
    }
}
