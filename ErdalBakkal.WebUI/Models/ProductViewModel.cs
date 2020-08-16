using ErdalBakkal.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ErdalBakkal.WebUI.Models
{
    public class ProductViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}