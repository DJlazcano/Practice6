using Microsoft.AspNetCore.Mvc;
using Practice5_DataAccess.Data;
using Practice5_Model.Models;

namespace Practice5_WebApp.Controllers
{
    public class PurchaseController : Controller
    {
        private readonly ApplicationDbContext _db;

        public PurchaseController(ApplicationDbContext db)
        {

            _db = db;
        }
        public IActionResult Index()
        {
            List<Purchase> objList = _db.Purchases.ToList();

            return View(objList);
        }

        public IActionResult Upsert(int? id)
        {
            Purchase obj = new Purchase();
            if (id == null || id == 0)
            {
                //Create
                return View(obj);
            }
            //Edit
            obj = _db.Purchases.First(p => p.Purchase_Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Purchase obj)
        {
            if (ModelState.IsValid)
            {
                if (obj.Product_Id == 0)
                {
                    //Create
                    _db.Purchases.Add(obj);
                }
                else
                {
                    //Update
                    _db.Purchases.Update(obj);
                }
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Delete(int id)
        {
            Purchase obj = new Purchase();
            //Edit
            obj = _db.Purchases.First(p => p.Product_Id == id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Purchases.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
