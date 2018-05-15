using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using AutoFixture;

namespace PTCData
{
    public class TrainingProductService
    {
	    private List<TrainingProduct> _mockData;

	    public IEnumerable<TrainingProduct> Get()
	    {
		    _mockData = new List<TrainingProduct>();
			return CreateMockData();
	    }

	    //private IEnumerable<TrainingProduct> CreateMockData()
	    //{
		   // var fixture = new Fixture();
		   // return fixture.Create<List<TrainingProduct>>();
	    //}

		private List<TrainingProduct> CreateMockData()
		{


			_mockData.Add(new TrainingProduct
			{
				ProductId = 1,
				ProductName = "Extending Bootstrap with CSS, JavaScript and jQuery",
				IntroductionDate = Convert.ToDateTime("6/11/2015", new CultureInfo("en-US")),
				Url = "http://bit.ly/1SNzc0i",
				Price = Convert.ToDecimal(29.00)
			});

			_mockData.Add(new TrainingProduct
			{
				ProductId = 2,
				ProductName = "Build your own Bootstrap Business Application Template in MVC",
				IntroductionDate = Convert.ToDateTime("1/29/2015", new CultureInfo("en-US")),
				Url = "http://bit.ly/1I8ZqZg",
				Price = Convert.ToDecimal(29.00)
			});

			_mockData.Add(new TrainingProduct
			{
				ProductId = 3,
				ProductName = "Building Mobile Web Sites Using Web Forms, Bootstrap, and HTML5",
				IntroductionDate = Convert.ToDateTime("8/28/2014", new CultureInfo("en-US")),
				Url = "http://bit.ly/1J2dcrj",
				Price = Convert.ToDecimal(29.00)
			});

			_mockData.Add(new TrainingProduct
			{
				ProductId = 4,
				ProductName = "How to Start and Run A Consulting Business",
				IntroductionDate = Convert.ToDateTime("9/12/2013", new CultureInfo("en-US")),
				Url = "http://bit.ly/1L8kOwd",
				Price = Convert.ToDecimal(29.00)
			});

			_mockData.Add(new TrainingProduct
			{
				ProductId = 5,
				ProductName = "The Many Approaches to XML Processing in .NET Applications",
				IntroductionDate = Convert.ToDateTime("7/22/2013", new CultureInfo("en-US")),
				Url = "http://bit.ly/1DBfUqd",
				Price = Convert.ToDecimal(29.00)
			});

			_mockData.Add(new TrainingProduct
			{
				ProductId = 6,
				ProductName = "WPF for the Business Programmer",
				IntroductionDate = Convert.ToDateTime("6/12/2009", new CultureInfo("en-US")),
				Url = "http://bit.ly/1UF858z",
				Price = Convert.ToDecimal(29.00)
			});

			_mockData.Add(new TrainingProduct
			{
				ProductId = 7,
				ProductName = "WPF for the Visual Basic Programmer - Part 1",
				IntroductionDate = Convert.ToDateTime("12/16/2014", new CultureInfo("en-US")),
				Url = "http://bit.ly/1uFxS7C",
				Price = Convert.ToDecimal(29.00)
			});

			_mockData.Add(new TrainingProduct
			{
				ProductId = 8,
				ProductName = "WPF for the Visual Basic Programmer - Part 2",
				IntroductionDate = Convert.ToDateTime("2/18/2014", new CultureInfo("en-US")),
				Url = "http://bit.ly/1MjQ9NG",
				Price = Convert.ToDecimal(29.00)
			});

			return _mockData;
		}

	    public void Add(TrainingProduct productForCreation)
	    {
			_mockData.Add(new TrainingProduct
			{
				ProductId = _mockData.Count + 1,
				ProductName = productForCreation.ProductName,
				IntroductionDate = Convert.ToDateTime(productForCreation.IntroductionDate),
				Url = productForCreation.Url,
				Price = Convert.ToDecimal(productForCreation.Price)
			});
		}
    }
}
