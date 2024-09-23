using Microsoft.AspNetCore.Mvc;
using Moq;
using Practice5_DataAccess.Data;
using Practice5_Model.Models;
using Practice5_WebApp.Controllers;
using Xunit.Abstractions;

namespace Practice5.Tests.ProductTests
{
	public class ProductFixture
	{
		public Mock<ApplicationDbContext> MockDbContext { get; private set; }
		public ProductController ProductController { get; private set; }

		public ProductController prod => new ProductController(MockDbContext.Object);

		public ProductFixture()
		{
			MockDbContext = new Mock<ApplicationDbContext>();
			ProductController = new ProductController(MockDbContext.Object);
		}
	}
	public class ProductTest : IClassFixture<ProductFixture>
	{
		private readonly ITestOutputHelper _TestOutPutHelper;
		private readonly ProductFixture _productFixture;

		public ProductTest(ITestOutputHelper testOutputHelper, ProductFixture productFixture)
		{
			_TestOutPutHelper = testOutputHelper;
			_productFixture = productFixture;
		}

		[Fact]
		public void FetchProducts_ReturnsListOfProducts()
		{
			var products = new List<Product> {
				new Product { Product_Id = 1, ProductName = "Grape"},
				new Product{Product_Id = 2, ProductName = "Apple"}
			}.AsQueryable();

			_productFixture.MockDbContext.Setup(db => db.Products).Returns((Microsoft.EntityFrameworkCore.DbSet<Product>)products);

			var result = _productFixture.ProductController.Index();
			var viewResult = Assert.IsType<ViewResult>(result);
			var model = Assert.IsAssignableFrom<List<Product>>(viewResult.ViewData.Model);

			Assert.Equal(2, model.Count);
		}


		[Fact]
		public void Upsert_Get_ReturnsViewResult_WithProduct()
		{

			var mockProduct = new Product { Product_Id = 1, ProductName = "Lemon" };
			_productFixture.MockDbContext.Setup(db => db.Products.First(It.IsAny<Func<Product, bool>>())).Returns(mockProduct);


			var result = _productFixture.ProductController.Upsert(1);


			var viewResult = Assert.IsType<ViewResult>(result);
			var model = Assert.IsAssignableFrom<Product>(viewResult.ViewData.Model);
			Assert.Equal(1, model.Product_Id);
		}

		[Fact]
		public async Task Upsert_Update_ReturnsRedirectToActionResult()
		{

			var product = new Product { Product_Id = 0, ProductName = "WaterMelon" };


			var result = await _productFixture.ProductController.Upsert(product);


			var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
			Assert.Equal("Index", redirectToActionResult.ActionName);
		}

		[Fact]
		public async Task Upsert_Create_ReturnsRedirectToActionResult()
		{

			var product = new Product { Product_Id = 1, ProductName = "WaterMelon" };


			var result = await _productFixture.ProductController.Upsert(product);


			var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
			Assert.Equal("Index", redirectToActionResult.ActionName);
		}

		public async Task Upsert_Delete_ReturnsRedirectToActionResult()
		{

			var products = new List<Product> {
				new Product { Product_Id = 1, ProductName = "Grape"},
				new Product{Product_Id = 2, ProductName = "Apple"}
			}.AsQueryable();

			_productFixture.MockDbContext.Setup(db => db.Products).Returns((Microsoft.EntityFrameworkCore.DbSet<Product>)products);

			var result = _productFixture.ProductController.Delete(1);
			var viewResult = Assert.IsType<ViewResult>(result);
			var model = Assert.IsAssignableFrom<List<Product>>(viewResult.ViewData.Model);

			Assert.Equal(1, model.Count);
		}
	}
}