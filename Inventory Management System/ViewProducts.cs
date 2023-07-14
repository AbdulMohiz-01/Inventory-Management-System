using Inventory_Management_System.Models;
using Inventory_Management_System.Resources;
using System.Data;


namespace Inventory_Management_System
{
    public partial class ViewProducts : Form
    {
        public ViewProducts()
        {
            InitializeComponent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            updateData();
        }

        private void ViewProducts_Load(object sender, EventArgs e)
        {

            Utils.RenderDataGridView(dataGridView1, new InventorydbContext().MyInventories.ToList(), totalProductsLabel);

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            updateData();
        }
        private void updateData()
        {
            // check if any cell is selected in the dataGridView1

            if (dataGridView1.SelectedCells.Count > 0)
            {
                var selectedRow = dataGridView1.CurrentRow;
                var product = (MyInventory)selectedRow.DataBoundItem;

                editPanel.Controls.Clear();
                Edit edit = new Edit(product);
                edit.TopLevel = false;
                editPanel.Controls.Add(edit);
                edit.Show();

            }
            else
            {
                // display message of no row selected
                MessageBox.Show("Please select a row to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void orderby_MouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var context = new InventorydbContext();

            // check if the orderByComboBox value is ascending or descending
            if (orderbyComboBox.Text == "Ascending")
            {
                if (e.RowIndex == -1 && e.ColumnIndex == 1)
                {
                    Utils.RenderDataGridView(dataGridView1, ((List<MyInventory>)dataGridView1.DataSource).OrderBy(x => x.Name).ToList(), totalProductsLabel);
                }
                else if (e.RowIndex == -1 && e.ColumnIndex == 4)
                {
                    Utils.RenderDataGridView(dataGridView1, ((List<MyInventory>)dataGridView1.DataSource).OrderBy(x => x.Price).ToList(), totalProductsLabel);

                }
                else if (e.RowIndex == -1 && e.ColumnIndex == 3)
                {
                    Utils.RenderDataGridView(dataGridView1, ((List<MyInventory>)dataGridView1.DataSource).OrderBy(x => x.Quantity).ToList(), totalProductsLabel);

                }
                else
                {
                    MessageBox.Show("Order by may only be used on Name, Quantity, and Price.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (orderbyComboBox.Text == "Descending")
            {
                if (e.RowIndex == -1 && e.ColumnIndex == 1)
                {
                    Utils.RenderDataGridView(dataGridView1, ((List<MyInventory>)dataGridView1.DataSource).OrderByDescending(x => x.Name).ToList(), totalProductsLabel);

                }
                else if (e.RowIndex == -1 && e.ColumnIndex == 4)
                {
                    Utils.RenderDataGridView(dataGridView1, ((List<MyInventory>)dataGridView1.DataSource).OrderByDescending(x => x.Price).ToList(), totalProductsLabel);

                }
                else if (e.RowIndex == -1 && e.ColumnIndex == 3)
                {
                    Utils.RenderDataGridView(dataGridView1, ((List<MyInventory>)dataGridView1.DataSource).OrderByDescending(x => x.Quantity).ToList(), totalProductsLabel);

                }
                else
                {
                    // display message info, "Order by may only be used on Name, Quantity, and Price."
                    MessageBox.Show("Order by may only be used on Name, Quantity, and Price.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // delete button
            // check if any cell is selected in the dataGridView1
            if (dataGridView1.SelectedCells.Count > 0)
            {
                var selectedRow = dataGridView1.CurrentRow;
                var product = (MyInventory)selectedRow.DataBoundItem;

                // display message box, "Are you sure you want to delete this product?"
                var result = MessageBox.Show("Are you sure you want to delete this product?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // delete the product
                    var context = new InventorydbContext();
                    context.MyInventories.Remove(product);
                    context.SaveChanges();

                    // refresh the dataGridView1
                    Utils.RenderDataGridView(dataGridView1, context.MyInventories.ToList(), totalProductsLabel);
                }
            }
            else
            {
                // display message of no row selected
                MessageBox.Show("Please select a row to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var list = from p in new InventorydbContext().MyInventories.ToList()
                       where p.Name.Contains(searchTextBox.Text)
                       select p;
            if (searchCategoryComboBox.SelectedIndex != -1)
            {
                list = from p in list
                       where p.Category == searchCategoryComboBox.Text
                       select p;
            }

            if (list.Count() > 0)
            {
                Utils.RenderDataGridView(dataGridView1, list.ToList(), totalProductsLabel);
            }
            else
            {
                MessageBox.Show("No products found", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void resetSearch_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = "";
            searchCategoryComboBox.SelectedIndex = -1;

            Utils.RenderDataGridView(dataGridView1, new InventorydbContext().MyInventories.ToList(), totalProductsLabel);
        }
    }
}
