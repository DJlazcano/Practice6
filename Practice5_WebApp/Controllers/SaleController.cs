using Microsoft.AspNetCore.Mvc;
using Practice5_DataAccess.Data;
using Practice5_Model.Models;

namespace Practice5_WebApp.Controllers
{
	public class SaleController : Controller
	{

		private readonly ApplicationDbContext _db;

		public SaleController(ApplicationDbContext db)
		{

			_db = db;
		}

		public IActionResult SaleIndex()
		{
			List<Sale> objList = _db.Sales.ToList();

			return View(objList);
		}
		public IActionResult Upsert(int? id)
		{
			Sale obj = new Sale();
			if (id == null || id == 0)
			{
				//Create
				return View(obj);
			}
			//Edit
			obj = _db.Sales.First(p => p.Sale_Id == id);
			if (obj == null)
			{
				return NotFound();
			}
			return View(obj);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Upsert(Sale obj)
		{
			if (obj.Sale_Id == 0)
			{
				//Create
				_db.Sales.Add(obj);
			}
			else
			{
				//Update
				_db.Sales.Update(obj);
			}
			_db.SaveChanges();
			return RedirectToAction("SaleIndex");
		}

		public IActionResult Delete(int id)
		{
			Sale obj = new Sale();
			//Edit
			obj = _db.Sales.First(p => p.Sale_Id == id);
			if (obj == null)
			{
				return NotFound();
			}

			_db.Sales.Remove(obj);
			_db.SaveChanges();
			return RedirectToAction("SaleIndex");
		}
	}
}
