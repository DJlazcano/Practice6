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
	public class PurchaseFixture
	{
		public Mock<ApplicationDbContext> MockDbContext { get; private set; }
		public PurchaseController PurchaseController { get; private set; }

		public PurchaseController purchase => new PurchaseController(MockDbContext.Object);

		public PurchaseFixture()
		{
			MockDbContext = new Mock<ApplicationDbContext>();
			PurchaseController = new PurchaseController(MockDbContext.Object);
		}
	}
	public class PurchaseTest
	{
	}
}
