using JuanPr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuanPr.ViewModels
{
    public class HomeViewModel
    {
        public List<Service> Services { get; set; }
        public List<Slider> Sliders { get; set; }
        public List<Product> Products { get; set; }
    }
}
