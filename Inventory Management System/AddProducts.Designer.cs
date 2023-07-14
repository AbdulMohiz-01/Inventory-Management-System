namespace Inventory_Management_System
{
    partial class AddProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.productspanel = new System.Windows.Forms.Panel();
            this.productgroupbox = new System.Windows.Forms.GroupBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.addNewProduct = new System.Windows.Forms.Button();
            this.removeProduct = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.productspanel.SuspendLayout();
            this.productgroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // productspanel
            // 
            this.productspanel.AutoScroll = true;
            this.productspanel.Controls.Add(this.productgroupbox);
            this.productspanel.Location = new System.Drawing.Point(12, 12);
            this.productspanel.Name = "productspanel";
            this.productspanel.Size = new System.Drawing.Size(891, 571);
            this.productspanel.TabIndex = 0;
            // 
            // productgroupbox
            // 
            this.productgroupbox.Controls.Add(this.categoryComboBox);
            this.productgroupbox.Controls.Add(this.descriptionTextBox);
            this.productgroupbox.Controls.Add(this.label5);
            this.productgroupbox.Controls.Add(this.label4);
            this.productgroupbox.Controls.Add(this.nameTextBox);
            this.productgroupbox.Controls.Add(this.label3);
            this.productgroupbox.Controls.Add(this.quantityNumericUpDown);
            this.productgroupbox.Controls.Add(this.label2);
            this.productgroupbox.Controls.Add(this.label1);
            this.productgroupbox.Controls.Add(this.priceTextBox);
            this.productgroupbox.Location = new System.Drawing.Point(3, 3);
            this.productgroupbox.Name = "productgroupbox";
            this.productgroupbox.Size = new System.Drawing.Size(885, 80);
            this.productgroupbox.TabIndex = 6;
            this.productgroupbox.TabStop = false;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Fresh products",
            "Processed products",
            "Organic products",
            "Non-organic products",
            "Fast food",
            "Gourmet foods",
            "Convenience foods"});
            this.categoryComboBox.Location = new System.Drawing.Point(704, 18);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(182, 23);
            this.categoryComboBox.TabIndex = 15;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionTextBox.Location = new System.Drawing.Point(217, 17);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(319, 52);
            this.descriptionTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(704, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Description";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTextBox.Location = new System.Drawing.Point(0, 24);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(211, 21);
            this.nameTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(601, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Price";
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantityNumericUpDown.Location = new System.Drawing.Point(542, 18);
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(53, 21);
            this.quantityNumericUpDown.TabIndex = 8;
            this.quantityNumericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(542, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Quantity";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceTextBox.Location = new System.Drawing.Point(601, 18);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(97, 21);
            this.priceTextBox.TabIndex = 9;
            this.priceTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // savebutton
            // 
            this.savebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(103)))), ((int)(((byte)(116)))));
            this.savebutton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.savebutton.ForeColor = System.Drawing.Color.White;
            this.savebutton.Location = new System.Drawing.Point(810, 582);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(93, 37);
            this.savebutton.TabIndex = 12;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = false;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // addNewProduct
            // 
            this.addNewProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.addNewProduct.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addNewProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.addNewProduct.Location = new System.Drawing.Point(12, 589);
            this.addNewProduct.Name = "addNewProduct";
            this.addNewProduct.Size = new System.Drawing.Size(75, 37);
            this.addNewProduct.TabIndex = 13;
            this.addNewProduct.Text = "Add";
            this.addNewProduct.UseVisualStyleBackColor = false;
            this.addNewProduct.Click += new System.EventHandler(this.addNewProduct_Click_1);
            // 
            // removeProduct
            // 
            this.removeProduct.Enabled = false;
            this.removeProduct.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.removeProduct.Location = new System.Drawing.Point(93, 589);
            this.removeProduct.Name = "removeProduct";
            this.removeProduct.Size = new System.Drawing.Size(75, 37);
            this.removeProduct.TabIndex = 15;
            this.removeProduct.Text = "Remove";
            this.removeProduct.UseVisualStyleBackColor = true;
            this.removeProduct.Click += new System.EventHandler(this.removeProduct_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resetButton.ForeColor = System.Drawing.Color.Black;
            this.resetButton.Location = new System.Drawing.Point(174, 589);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 37);
            this.resetButton.TabIndex = 16;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // AddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(915, 631);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.removeProduct);
            this.Controls.Add(this.addNewProduct);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.productspanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddProducts";
            this.Load += new System.EventHandler(this.AddProducts_Load);
            this.productspanel.ResumeLayout(false);
            this.productgroupbox.ResumeLayout(false);
            this.productgroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel productspanel;
        private GroupBox productgroupbox;
        private Label label1;
        private TextBox priceTextBox;
        private NumericUpDown quantityNumericUpDown;
        private TextBox nameTextBox;
        private Label label3;
        private Label label2;
        private Button savebutton;
        private Button addNewProduct;
        private TextBox descriptionTextBox;
        private Label label4;
        private Label label5;
        private ComboBox categoryComboBox;
        private Button removeProduct;
        private Button resetButton;
    }
}