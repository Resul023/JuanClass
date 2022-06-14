using JuanPr.DAL;
using JuanPr.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuanPr.Areas.Manage.Controllers
{
    [Area("manage")]
    public class CategoriesController : Controller
    {
        private readonly AppDbContext _context;

        public CategoriesController(AppDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            var category = _context.Categories.ToList();
            return View(category);
        }
        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
           
            if (!ModelState.IsValid)
            {
                return View();
            }
            var isExits = _context.Categories.FirstOrDefault(x => x.Name == category.Name);
            if (isExits!=null)
            {
                 ModelState.AddModelError("Name","This name is exits");
            }
            ViewBag.Categories = _context.Categories.ToList();
            _context.Categories.Add(category);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult Edit(int Id) 
        {
            var isExits = _context.Categories.FirstOrDefault(x => x.Id == Id);
            if (isExits == null)
            {
                return View();
            }
            

            return View(isExits);
        }

        [HttpPost]
        public IActionResult Edit(Category category) 
        {
            var isExits = _context.Categories.FirstOrDefault(x => x.Id == category.Id);
            if (!ModelState.IsValid)
            {
                return View();
            }
            
            if (isExits == null)
            {
                return View();
            }
           
            isExits.Name = category.Name;
            _context.SaveChanges();
            return RedirectToAction("index");

        }
        public IActionResult Delete(int Id) 
        {
            var isExists = _context.Categories.FirstOrDefault(x => x.Id == Id);
            if (isExists != null)
            {
                ModelState.AddModelError("Name", "This name is exits");
            }
            _context.Categories.Remove(isExists);
            _context.SaveChanges();
            return Ok();
        }
    }
}
