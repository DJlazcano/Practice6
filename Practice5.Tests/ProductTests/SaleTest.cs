using Moq;
using Practice5_DataAccess.Data;
using Practice5_WebApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Tests.ProductTests
{
	public class SaleFixture
	{
		public Mock<ApplicationDbContext> MockDbContext { get; private set; }
		public SaleController SaleController { get; private set; }

		public SaleController sale => new SaleController(MockDbContext.Object);

		public SaleFixture()
		{
			MockDbContext = new Mock<ApplicationDbContext>();
			SaleController = new SaleController(MockDbContext.Object);
		}
	}
	public class SaleTest
	{
	}
}
