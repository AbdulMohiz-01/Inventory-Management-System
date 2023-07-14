using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
    public class Product
    {
        public string? Name { get; set; }
        public string? Price { get; set; }
        public string? Quantity { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }

        public Product(string name, string price, string quantity, string description, string category)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Description = description;
            Category = category;
        }

        public Product() { }
    }
}
