using Microsoft.AspNetCore.Mvc;
using Moq;
using Practice5_DataAccess.Data;
using Practice5_Model.Models;
using Practice5_WebApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace Practice5.Tests.WebApp.Tests
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
	public class SaleTest : IClassFixture<SaleFixture>
	{
		private readonly ITestOutputHelper _TestOutPutHelper;
		private readonly SaleFixture _saleFixture;

		public SaleTest(ITestOutputHelper testOutputHelper, SaleFixture saleFixture)
		{
			_TestOutPutHelper = testOutputHelper;
			_saleFixture = saleFixture;
		}

		[Fact]
		public void FetchSales_ReturnsListOfSales()
		{
			var sales = new List<Sale> {
				new Sale { Sale_Id = 1, SaleDate = Convert.ToDateTime("2024-09-16 8:23:00 AM"),
					CustomerName = "John", QuantitySold = 100, SalePrice = 15, TotalAmount = 3000, Product_Id = 1},
				new Sale { Sale_Id = 2, SaleDate = Convert.ToDateTime("2024-09-16 8:23:00 AM"),
					CustomerName = "Smith", QuantitySold = 100, SalePrice = 15, TotalAmount = 3000, Product_Id = 2}
			}.AsQueryable();

			_saleFixture.MockDbContext.Setup(db => db.Sales).Returns((Microsoft.EntityFrameworkCore.DbSet<Sale>)sales);

			var result = _saleFixture.SaleController.SaleIndex();
			var viewResult = Assert.IsType<ViewResult>(result);
			var model = Assert.IsAssignableFrom<List<Sale>>(viewResult.ViewData.Model);

			Assert.Equal(2, model.Count);
		}


		[Fact]
		public void Upsert_Get_ReturnsViewResult_WithSale()
		{

			var mockSale = new Sale
			{
				Sale_Id = 1,
				SaleDate = Convert.ToDateTime("2024-09-16 8:23:00 AM"),
				CustomerName = "John",
				QuantitySold = 100,
				SalePrice = 15,
				TotalAmount = 3000,
				Product_Id = 1
			};
			_saleFixture.MockDbContext.Setup(db => db.Sales.First(It.IsAny<Func<Sale, bool>>())).Returns(mockSale);


			var result = _saleFixture.SaleController.Upsert(1);


			var viewResult = Assert.IsType<ViewResult>(result);
			var model = Assert.IsAssignableFrom<Sale>(viewResult.ViewData.Model);
			Assert.Equal(1, model.Sale_Id);
		}

		[Fact]
		public async Task Upsert_Update_ReturnsRedirectToActionResult()
		{

			var mockSale = new Sale
			{
				Sale_Id = 0,
				SaleDate = Convert.ToDateTime("2024-09-16 8:23:00 AM"),
				CustomerName = "John",
				QuantitySold = 100,
				SalePrice = 15,
				TotalAmount = 3000,
				Product_Id = 1
			};


			var result = _saleFixture.SaleController.Upsert(mockSale);


			var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
			Assert.Equal("Index", redirectToActionResult.ActionName);
		}

		[Fact]
		public async Task Upsert_Create_ReturnsRedirectToActionResult()
		{

			var mockSale = new Sale
			{
				Sale_Id = 1,
				SaleDate = Convert.ToDateTime("2024-09-16 8:23:00 AM"),
				CustomerName = "John",
				QuantitySold = 100,
				SalePrice = 15,
				TotalAmount = 3000,
				Product_Id = 1
			};


			var result = _saleFixture.SaleController.Upsert(mockSale);


			var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
			Assert.Equal("Index", redirectToActionResult.ActionName);
		}

		[Fact]
		public void Upsert_Delete_ReturnsRedirectToActionResult()
		{

			var sales = new List<Sale> {
				new Sale { Sale_Id = 1, SaleDate = Convert.ToDateTime("2024-09-16 8:23:00 AM"),
					CustomerName = "John", QuantitySold = 100, SalePrice = 15, TotalAmount = 3000, Product_Id = 1},
				new Sale { Sale_Id = 2, SaleDate = Convert.ToDateTime("2024-09-16 8:23:00 AM"),
					CustomerName = "Smith", QuantitySold = 100, SalePrice = 15, TotalAmount = 3000, Product_Id = 2}
			}.AsQueryable();

			_saleFixture.MockDbContext.Setup(db => db.Sales).Returns((Microsoft.EntityFrameworkCore.DbSet<Sale>)sales);

			var result = _saleFixture.SaleController.Delete(1);
			var viewResult = Assert.IsType<ViewResult>(result);
			var model = Assert.IsAssignableFrom<List<Sale>>(viewResult.ViewData.Model);

			Assert.Equal(1, model.Count);
		}
	}
}

