using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JuanPr.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        [StringLength(maximumLength: 150)]
        public string Title { get; set; }
        [Required]
        [StringLength(maximumLength:50)]
        public double Price { get; set; }
        public double oldPrice { get; set; }
        public string mainIcon { get; set; }
        public string Icon1 { get; set; }
        public string Icon2 { get; set; }
        
        public List<ProductCategories> productCategories { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

    }
}
