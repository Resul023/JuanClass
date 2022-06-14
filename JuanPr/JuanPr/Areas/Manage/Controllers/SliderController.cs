using JuanPr.Areas.ViewModel;
using JuanPr.DAL;
using JuanPr.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JuanPr.Models;
namespace JuanPr.Areas.Manage.Controllers
{
    [Area("manage")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;

        public SliderController(AppDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            HomeViewModel homeVW = new HomeViewModel
            {
                /*Services = _context.Services.ToList(),*/
                Sliders = _context.Sliders.ToList(),
                /*Products = _context.Products.ToList(),*/

            };
            return View(homeVW);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Slider slider)
        {
            if (!ModelState.IsValid)
            {
                  return View();
            }

            if (slider == null)
            {
                return Content("There are problem in the process");
            }

            _context.Sliders.Add(slider);
            _context.SaveChanges();

            return RedirectToAction("index");

        }
        public IActionResult Edit(int id) 
        {
            Slider slider = _context.Sliders.FirstOrDefault(x => x.Id == id);
            if (slider == null)
            {
                return Content("There are problem in the process");
            }
            return View(slider);
        }
        [HttpPost]
        public IActionResult Edit(Slider slider)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            Slider isExists = _context.Sliders.FirstOrDefault(x => x.Id == slider.Id);

            if (isExists == null)
            {
                return Content("There are problem in the process");
            }

            isExists.Title1 = slider.Title1;
            isExists.Title2 = slider.Title2;
            _context.SaveChanges();

            return RedirectToAction("index");

        }
        public IActionResult Delete(int id) 
        {
            Slider slider = _context.Sliders.FirstOrDefault(x => x.Id == id);
            
            if (slider == null)
            {
                return Content("There are problem in the process");
            }

            _context.Sliders.Remove(slider);
            _context.SaveChanges();
            return Ok();
        }

    }
}
