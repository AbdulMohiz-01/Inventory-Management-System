using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory_Management_System.Models;

namespace Inventory_Management_System.Resources
{
    public static class Utils
    {
        public static void RenderDataGridView(DataGridView dataGridView, List<MyInventory> products, Label totalProducts)
        {
            dataGridView.DataSource = products;
            dataGridView.Columns["Id"].Visible = false;
            dataGridView.Columns["Name"].HeaderText = "Name";
            dataGridView.Columns["Price"].HeaderText = "Price";
            dataGridView.Columns["Quantity"].HeaderText = "Quantity";
            dataGridView.Columns["Description"].HeaderText = "Description";
            dataGridView.Columns["Category"].HeaderText = "Category";

            // adjust the width of the columns
            dataGridView.Columns["Name"].Width = 137;
            dataGridView.Columns["Price"].Width = 120;
            dataGridView.Columns["Quantity"].Width = 120;
            dataGridView.Columns["Description"].Width = 280;
            dataGridView.Columns["Category"].Width = 170;

            // Update TotalProducts label in ViewProducts.cs
            totalProducts.Text = products.Count.ToString();
        }
    }
}
