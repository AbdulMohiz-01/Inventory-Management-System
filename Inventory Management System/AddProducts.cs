using Inventory_Management_System.Models;
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
    public partial class AddProducts : Form
    {
        private int height = 83;
        List<MyInventory> products = new List<MyInventory>();

        public AddProducts()
        {
            InitializeComponent();
            // disable its title bar
            this.ControlBox = false;

        }
        private void addNewProduct_Click_1(object sender, EventArgs e)
        {
            // Create a new GroupBox
            GroupBox newGroupBox = new GroupBox();
            // Set the size of the GroupBox
            newGroupBox.Size = new Size(885, 80);
            // Set the location of the GroupBox
            newGroupBox.Location = new Point(3, height);
            height += 83;

            // Iterate through the controls in the existing GroupBox
            foreach (Control c in productgroupbox.Controls)
            {
                // Create a new instance of the same control type
                Control? newControl = Activator.CreateInstance(c.GetType()) as Control;

                // Set the properties of the new control to match the original control
                newControl.Location = c.Location;
                // if the textBox is multine set newControl to multiline
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    if (t.Multiline)
                    {
                        TextBox t2 = (TextBox)newControl;
                        t2.Multiline = true;
                    }
                }
                // if the control is combo box set the new control to combo box and all the items
                if (c is ComboBox)
                {
                    ComboBox t = (ComboBox)c;
                    ComboBox t2 = (ComboBox)newControl;
                    foreach (var item in t.Items)
                    {
                        t2.Items.Add(item);
                    }
                    // set dropdown style to dropdownList
                    t2.DropDownStyle = ComboBoxStyle.DropDownList;
                }
                newControl.Size = c.Size;
                newControl.Name = c.Name;


                // Add the new control to the new GroupBox
                newGroupBox.Controls.Add(newControl);
            }
            // append newGroupBox to a productspanel
            productspanel.Controls.Add(newGroupBox);
            removeProduct.Enabled = true;
        }

        private void removeProduct_Click(object sender, EventArgs e)
        {
            // remove the last GroupBox from the productspanel
            if (productspanel.Controls.Count > 1)
            {
                productspanel.Controls.RemoveAt(productspanel.Controls.Count - 1);
                height -= 83;
            }
            if (productspanel.Controls.Count == 1)
            {
                removeProduct.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void savebutton_Click(object sender, EventArgs e)
        {
            // iterate through the productspanel
            foreach (GroupBox g in productspanel.Controls)
            {
                // iterate through the controls in the GroupBox
                foreach (Control c in g.Controls)
                {
                    // if the control is a textbox
                    if (c is TextBox)
                    {
                        // if the textbox is empty
                        if (c.Text == "")
                        {
                            // display message of empty field
                            MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    // if the control is a combobox
                    if (c is ComboBox)
                    {
                        // if the combobox is empty
                        if (c.Text == "")
                        {
                            // display message of empty field
                            MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
            // display a message box to confirm the save
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                // if the user clicks yes
                // iterate through the productspanel and get every product value and add it to the products list
                foreach (GroupBox g in productspanel.Controls)
                {
                    string name = "";
                    int price = 0;
                    int quantity = 0;
                    string description = "";
                    string category = "";
                    // iterate through the controls in the GroupBox
                    foreach (Control c in g.Controls)
                    {
                        // if the control is a textbox
                        if (c is TextBox)
                        {
                            // if the textbox is nameTextBox
                            if (c.Name == "nameTextBox")
                            {
                                name = c.Text;
                            }
                            // if the textbox is priceTextBox
                            if (c.Name == "priceTextBox")
                            {
                                price = int.Parse(c.Text);
                            }
                            // if the textbox is descriptionTextBox
                            if (c.Name == "descriptionTextBox")
                            {
                                description = c.Text;
                            }
                        }
                        if (c is NumericUpDown)
                        {
                            if (c.Name == "quantityNumericUpDown")
                            {
                                quantity = (int)((NumericUpDown)c).Value;
                            }
                        }
                        // if the control is a combobox
                        if (c is ComboBox)
                        {
                            // if the combobox is categoryComboBox
                            if (c.Name == "categoryComboBox")
                            {
                                category = c.Text;
                            }
                        }
                    }
                    // add the product to the products list
                    products.Add(new MyInventory(name, price, quantity, description, category));
                }
                // display a message box to confirm the save
                InventorydbContext context = new InventorydbContext();
                // check if the product already exists via its name and description
                foreach (var product in products)
                {
                    var query = from p in context.MyInventories
                                where p.Name == product.Name && p.Description == product.Description
                                select p;
                    // if the product already exists
                    if (query.Count() > 0)
                    {
                        // display a message box to confirm the save
                        DialogResult dialogResult2 = MessageBox.Show("The product " + product.Name + " already exists, do you want to update it?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult2 == DialogResult.Yes)
                        {
                            // if the user clicks yes
                            // update the product
                            var query2 = from p in context.MyInventories
                                         where p.Name == product.Name && p.Description == product.Description
                                         select p;
                            foreach (var p in query2)
                            {
                                p.Name = product.Name;
                                p.Price = product.Price;
                                p.Quantity = product.Quantity;
                                p.Description = product.Description;
                                p.Category = product.Category;
                            }
                            context.SaveChanges();
                        }
                    }
                    // if the product doesn't exist
                    else
                    {
                        // add the product to the database
                        context.MyInventories.Add(product);
                        context.SaveChanges();
                    }
                }
                MessageBox.Show("Saved Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dialogResult == DialogResult.No)
            {
                // if the user clicks no
                // do nothing
            }


        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // reset productspanel to its initial state
            productspanel.Controls.Clear();
            productspanel.Controls.Add(productgroupbox);
            height = 83;
            removeProduct.Enabled = false;
            products.Clear();
        }

        private void AddProducts_Load(object sender, EventArgs e)
        {

        }
    }
}
