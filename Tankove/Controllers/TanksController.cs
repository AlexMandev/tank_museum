using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tankove.Data;
using Tankove.Models;

namespace Tankove.Controllers
{
    public class TanksController : Controller
    {
        private readonly ApplicationDbContext _db;

        public TanksController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Tanks> objList = _db.Tanks;
            return View(objList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Tanks obj)
        {
            if (ModelState.IsValid)
            {
                _db.Tanks.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        
        //action of the button delete in the table page
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Tanks.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //action of the button delete in the form
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Tanks.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
            _db.Tanks.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index"); 
        }
    }
}
