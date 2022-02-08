using Microsoft.AspNetCore.Mvc;
using CSI_340_ChenRoblesWu_Website.Data;
using CSI_340_ChenRoblesWu_Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace CSI_340_ChenRoblesWu_Website.Controllers
{
    public class AccountController : Controller
    {
        private readonly DataContext _db;

        public AccountController(DataContext db)
        {
            _db = db;
        }
        public IActionResult Info()
        {
            var displayData = _db.Book.ToList();
            return View(displayData);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> Create(int book_id)
        {
            if (ModelState.IsValid)
            {
                _db.Add(book_id);
                await _db.SaveChangesAsync();
                return RedirectToAction("ContactInfo");
            }
            return View(book_id);
        }
        
    }
}
