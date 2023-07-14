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
    public partial class Dashboard : Form
    {
        Form? recentLoadedForm = null;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void addProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // AddProducts
            loadForm(new AddProducts());
        }

        private void viewproductlinklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // load ViewProducts
            loadForm(new ViewProducts());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // export to excel
            loadForm(new ExportToExcel());

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // ProductAnalytics
            loadForm(new ProductAnalytics());
        }

        private void loadForm(Form f)
        {
            if (recentLoadedForm != null)
            {
                formpanel.Controls.Remove(recentLoadedForm);
            }
            f.TopLevel = false;
            formpanel.Controls.Add(f);
            f.Show();
            recentLoadedForm = f;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // load home form
            loadForm(new Form1());
        }
    }
}
