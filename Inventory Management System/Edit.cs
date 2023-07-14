using Inventory_Management_System.Models;
using Inventory_Management_System.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class Edit : Form
    {
        private int productID = 0;
        public Edit()
        {
            InitializeComponent();
        }

        public Edit(MyInventory product)
        {
            InitializeComponent();
            productID = product.Id;
            nameTextBox.Text = product.Name;
            priceTextBox.Text = product.Price.ToString();
            quantityTextBox.Text = product.Quantity.ToString();
            descriptionTextBox.Text = product.Description;
            categoryComboBox.Text = product.Category;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // get the data from the form
            var name = nameTextBox.Text;
            var price = Convert.ToInt32(priceTextBox.Text);
            var quantity = Convert.ToInt32(quantityTextBox.Text);
            var description = descriptionTextBox.Text;
            var category = categoryComboBox.Text;

            // check if the product already exists on the basis
            InventorydbContext context = new InventorydbContext();
            var product = context.MyInventories.Where(p => p.Id == productID).FirstOrDefault();
            if (product != null)
            {
                product.Name = name;
                product.Price = price;
                product.Quantity = quantity;
                product.Description = description;
                product.Category = category;
                context.SaveChanges();

                Utils.RenderDataGridView(((ViewProducts)Application.OpenForms["ViewProducts"]).dataGridView1, context.MyInventories.ToList(), ((ViewProducts)Application.OpenForms["ViewProducts"]).totalProductsLabel);
                MessageBox.Show("Product updated successfully");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Product not found");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // clear all fields
            nameTextBox.Text = "";
            priceTextBox.Text = "";
            quantityTextBox.Text = "";
            descriptionTextBox.Text = "";

        }
    }
}
