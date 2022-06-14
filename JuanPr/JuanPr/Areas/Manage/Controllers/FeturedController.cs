using JuanPr.Areas.Manage.ViewModel;
using JuanPr.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuanPr.Areas.Manage.Controllers
{
    [Area("manage")]
    public class FeturedController : Controller
    {
        private readonly AppDbContext _context;

        public FeturedController(AppDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            ViewModelFeatured feturedVW = new ViewModelFeatured
            {
                Services = _context.Services.ToList(),
            
            };
            return View(feturedVW);
        }
    }
}
