using JuanPr.DAL;
using JuanPr.Models;
using JuanPr.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace JuanPr.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
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

        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}
