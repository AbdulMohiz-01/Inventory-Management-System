using System;
using System.Collections.Generic;

namespace Inventory_Management_System.Models;

public partial class MyInventory
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int Quantity { get; set; }

    public int Price { get; set; }

    public string Category { get; set; } = null!;

    public MyInventory(string name, int price, int quantity, string description, string category)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
        Description = description;
        Category = category;
    }

    public MyInventory() { }
}
