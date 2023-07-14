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
    public partial class ProductAnalytics : Form
    {
        InventorydbContext context;

        public ProductAnalytics()
        {
            InitializeComponent();
        }

        private void ProductAnalytics_Load(object sender, EventArgs e)
        {
            context = new InventorydbContext();
            var products = from p in context.MyInventories where p.Quantity <= 30 select p;
            Utils.RenderDataGridView(dataGridView1, products.ToList(), totalProductsLabel);
        }
    }
}
