using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinFormsApp.Model;

namespace XamarinFormsApp.ViewModel
{
    public class ProductListViewModel
    {
        public ProductListViewModel()
        {
            Products = new List<Product>()
            {
                new Product() {Name = "Water Bottle", Price = 1.00m },
                new Product() {Name = "Stapler", Price = 1600.00m },
                new Product() {Name = "Screwdriver", Price = 6.00m }
            };
        }
        public List<Product> Products { get; set; }
    }
}
