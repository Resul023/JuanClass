using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuanPr.Models
{
    public class ProductCategories
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CategoriesId { get; set; }
        public Category Category { get; set; }
    }
}
