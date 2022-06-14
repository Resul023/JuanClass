using JuanPr.DAL;
using JuanPr.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuanPr.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ProductViewController productVW = new ProductViewController
            {
                Products = _context.Products.ToList(),
            
            };
            return View(productVW);
        }
    }
}
