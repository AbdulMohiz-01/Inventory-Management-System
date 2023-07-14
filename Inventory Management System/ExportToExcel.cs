using Inventory_Management_System.Models;
using System;
using System.Linq;
using System.IO;
using OfficeOpenXml;
using Microsoft.EntityFrameworkCore;
using System.IO.Packaging;


namespace Inventory_Management_System
{
    public partial class ExportToExcel : Form
    {
        public ExportToExcel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string exportPath = @"E:\Exported Data\";
            if (!Directory.Exists(exportPath))
            {
                Directory.CreateDirectory(exportPath);
            }

            string fileName = "ExportedData.xlsx";
            string filePath = Path.Combine(exportPath, fileName);



            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Sheet1");

                //Retrieve data from database using EF
                using (var dbContext = new InventorydbContext())
                {
                    var data = dbContext.MyInventories.ToList();

                    // write data to excel
                    worksheet.Cells[1, 1].Value = "Id";
                    worksheet.Cells[1, 2].Value = "Name";
                    worksheet.Cells[1, 3].Value = "Price";
                    worksheet.Cells[1, 4].Value = "Quantity";
                    worksheet.Cells[1, 5].Value = "Description";
                    worksheet.Cells[1, 6].Value = "Category";

                    for (int i = 0; i < data.Count; i++)
                    {
                        worksheet.Cells[i + 2, 1].Value = data[i].Id;
                        worksheet.Cells[i + 2, 2].Value = data[i].Name;
                        worksheet.Cells[i + 2, 3].Value = data[i].Price;
                        worksheet.Cells[i + 2, 4].Value = data[i].Quantity;
                        worksheet.Cells[i + 2, 5].Value = data[i].Description;
                        worksheet.Cells[i + 2, 6].Value = data[i].Category;
                    }
                }
                package.SaveAs(new FileInfo(filePath));
                MessageBox.Show("Data exported successfully!");
            }


        }
    }
}
