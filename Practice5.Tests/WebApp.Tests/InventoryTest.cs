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
	public class InventoryFixture
	{
		public Mock<ApplicationDbContext> MockDbContext { get; private set; }
		public InventoryController InventoryController { get; private set; }

		public InventoryController invent => new InventoryController(MockDbContext.Object);

		public InventoryFixture()
		{
			MockDbContext = new Mock<ApplicationDbContext>();
			InventoryController = new InventoryController(MockDbContext.Object);
		}
	}
	public class InventoryTest : IClassFixture<InventoryFixture>
	{
		private readonly ITestOutputHelper _TestOutPutHelper;
		private readonly InventoryFixture _inventoryFixture;

		public InventoryTest(ITestOutputHelper testOutputHelper, InventoryFixture inventoryFixture)
		{
			_TestOutPutHelper = testOutputHelper;
			_inventoryFixture = inventoryFixture;
		}

		[Fact]
		public void FetchInventory_ReturnsListOfInventory()
		{
			var inventories = new List<Inventory> {
				new Inventory {Inventory_Id =1, Product_Id = 1, Stock = 50},
				new Inventory {Inventory_Id =2, Product_Id = 2, Stock = 100}
			}.AsQueryable();

			_inventoryFixture.MockDbContext.Setup(db => db.Inventories).Returns((Microsoft.EntityFrameworkCore.DbSet<Inventory>)inventories);

			var result = _inventoryFixture.InventoryController.Index();
			var viewResult = Assert.IsType<ViewResult>(result);
			var model = Assert.IsAssignableFrom<List<Inventory>>(viewResult.ViewData.Model);

			Assert.Equal(2, model.Count);
		}


		[Fact]
		public void Upsert_Get_ReturnsViewResult_WithInventory()
		{

			var mockInventory = new Inventory { Inventory_Id = 1, Product_Id = 1, Stock = 30 };
			_inventoryFixture.MockDbContext.Setup(db => db.Inventories.First(It.IsAny<Func<Inventory, bool>>())).Returns(mockInventory);


			var result = _inventoryFixture.InventoryController.Upsert(1);


			var viewResult = Assert.IsType<ViewResult>(result);
			var model = Assert.IsAssignableFrom<Inventory>(viewResult.ViewData.Model);
			Assert.Equal(1, model.Inventory_Id);
		}

		[Fact]
		public async Task Upsert_Update_ReturnsRedirectToActionResult()
		{

			var inventory = new Inventory { Product_Id = 0, Inventory_Id = 3, Stock = 40 };


			var result = _inventoryFixture.InventoryController.Upsert(inventory);


			var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
			Assert.Equal("Index", redirectToActionResult.ActionName);
		}

		[Fact]
		public async Task Upsert_Create_ReturnsRedirectToActionResult()
		{

			var inventory = new Inventory { Product_Id = 1, Inventory_Id = 3, Stock = 40 };



			var result = _inventoryFixture.InventoryController.Upsert(inventory);


			var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
			Assert.Equal("Index", redirectToActionResult.ActionName);
		}

		[Fact]
		public async Task Upsert_Delete_ReturnsRedirectToActionResult()
		{

			var inventories = new List<Inventory> {
				new Inventory {Inventory_Id =1, Product_Id = 1, Stock = 50},
				new Inventory {Inventory_Id =2, Product_Id = 2, Stock = 100}
			}.AsQueryable();

			_inventoryFixture.MockDbContext.Setup(db => db.Inventories).Returns((Microsoft.EntityFrameworkCore.DbSet<Inventory>)inventories);

			var result = _inventoryFixture.InventoryController.Delete(1);
			var viewResult = Assert.IsType<ViewResult>(result);
			var model = Assert.IsAssignableFrom<List<Inventory>>(viewResult.ViewData.Model);

			Assert.Equal(2, model.Count);
		}
	}
}
