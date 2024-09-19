using Microsoft.AspNetCore.Mvc;
using Practice5_DataAccess.Data;
using Practice5_Model.Models;

namespace Practice5_WebApp.Controllers
{
	public class InventoryController : Controller
	{
		private readonly ApplicationDbContext _db;

		public InventoryController(ApplicationDbContext db)
		{

			_db = db;
		}
		public IActionResult Index()
		{
			List<Inventory> objList = _db.Inventories.ToList();

			return View(objList);
		}

		public IActionResult Upsert(int? id)
		{
			Inventory obj = new Inventory();
			if (id == null || id == 0)
			{
				//Create
				return View(obj);
			}
			//Edit
			obj = _db.Inventories.First(p => p.Inventory_Id == id);
			if (obj == null)
			{
				return NotFound();
			}
			return View(obj);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Upsert(Inventory obj)
		{
			if (obj.Inventory_Id == 0)
			{
				//Create
				_db.Inventories.Add(obj);
			}
			else
			{
				//Update
				_db.Inventories.Update(obj);
			}
			_db.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult Delete(int id)
		{
			Inventory obj = new Inventory();
			//Edit
			obj = _db.Inventories.First(p => p.Inventory_Id == id);
			if (obj == null)
			{
				return NotFound();
			}

			_db.Inventories.Remove(obj);
			_db.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
