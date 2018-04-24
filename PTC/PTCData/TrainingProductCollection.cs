using System;
using System.Collections.Generic;
using System.Text;
using AutoFixture;

namespace PTCData
{
    public class TrainingProductCollection
    {
	    public IEnumerable<TrainingProduct> Get()
	    {
		    return CreateMockData();
	    }

	    private IEnumerable<TrainingProduct> CreateMockData()
	    {
		    var fixture = new Fixture();
		    return fixture.Create<List<TrainingProduct>>();
	    }
    }
}
