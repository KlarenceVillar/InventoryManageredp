namespace InventoryManageredp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSKU = new TextBox();
            cmbCategory = new TextBox();
            comboBox1 = new ComboBox();
            nudQuantity = new NumericUpDown();
            btnAddProduct = new Button();
            btnUpdateStock = new Button();
            btnRemoveSelected = new Button();
            btnClearAll = new Button();
            checkBox1 = new CheckBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            dgInventory = new DataGridView();
            colSKU = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            ColNAME = new DataGridViewTextBoxColumn();
            ColCategory = new DataGridViewTextBoxColumn();
            lblTotalQty = new Label();
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgInventory).BeginInit();
            SuspendLayout();
            // 
            // txtSKU
            // 
            txtSKU.Location = new Point(24, 14);
            txtSKU.Name = "txtSKU";
            txtSKU.PlaceholderText = "SKU";
            txtSKU.Size = new Size(200, 27);
            txtSKU.TabIndex = 0;
            txtSKU.TextChanged += txtName_TextChanged;
            // 
            // cmbCategory
            // 
            cmbCategory.Location = new Point(24, 44);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.PlaceholderText = "Product Name";
            cmbCategory.Size = new Size(200, 27);
            cmbCategory.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Food", "Beverage", "Household", "Stationery", "Misc" });
            comboBox1.Location = new Point(24, 76);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 28);
            comboBox1.TabIndex = 2;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(24, 108);
            nudQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(60, 27);
            nudQuantity.TabIndex = 3;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(24, 140);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(140, 28);
            btnAddProduct.TabIndex = 4;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // btnUpdateStock
            // 
            btnUpdateStock.Location = new Point(24, 174);
            btnUpdateStock.Name = "btnUpdateStock";
            btnUpdateStock.Size = new Size(140, 28);
            btnUpdateStock.TabIndex = 5;
            btnUpdateStock.Text = "Update Stock";
            btnUpdateStock.UseVisualStyleBackColor = true;
            // 
            // btnRemoveSelected
            // 
            btnRemoveSelected.Location = new Point(240, 14);
            btnRemoveSelected.Name = "btnRemoveSelected";
            btnRemoveSelected.Size = new Size(140, 28);
            btnRemoveSelected.TabIndex = 6;
            btnRemoveSelected.Text = "Remove Selected";
            btnRemoveSelected.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(240, 45);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(140, 28);
            btnClearAll.TabIndex = 7;
            btnClearAll.Text = "Clear All";
            btnClearAll.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(240, 80);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(191, 24);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Confirm before deletion";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "All product", "Food", "Beverage", "Household", "Stationery", "Misc" });
            comboBox2.Location = new Point(240, 110);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(140, 28);
            comboBox2.TabIndex = 9;
            comboBox2.Text = "All product";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(240, 144);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search by SKU/Name...";
            textBox1.Size = new Size(166, 27);
            textBox1.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(240, 177);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "Apply Filter";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(337, 177);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 12;
            button3.Text = "Reset Filter";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dgInventory
            // 
            dgInventory.AllowUserToAddRows = false;
            dgInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgInventory.Columns.AddRange(new DataGridViewColumn[] { colSKU, colQuantity, ColNAME, ColCategory });
            dgInventory.Location = new Point(12, 221);
            dgInventory.Name = "dgInventory";
            dgInventory.ReadOnly = true;
            dgInventory.RowHeadersWidth = 51;
            dgInventory.Size = new Size(574, 296);
            dgInventory.TabIndex = 13;
            dgInventory.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colSKU
            // 
            colSKU.HeaderText = "SKU";
            colSKU.MinimumWidth = 6;
            colSKU.Name = "colSKU";
            colSKU.ReadOnly = true;
            colSKU.Width = 120;
            // 
            // colQuantity
            // 
            colQuantity.HeaderText = "Quantity";
            colQuantity.MinimumWidth = 6;
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            colQuantity.Width = 125;
            // 
            // ColNAME
            // 
            ColNAME.HeaderText = "Name";
            ColNAME.MinimumWidth = 6;
            ColNAME.Name = "ColNAME";
            ColNAME.ReadOnly = true;
            ColNAME.Width = 120;
            // 
            // ColCategory
            // 
            ColCategory.HeaderText = "Category";
            ColCategory.MinimumWidth = 6;
            ColCategory.Name = "ColCategory";
            ColCategory.ReadOnly = true;
            ColCategory.Width = 120;
            // 
            // lblTotalQty
            // 
            lblTotalQty.AutoSize = true;
            lblTotalQty.Location = new Point(12, 534);
            lblTotalQty.Name = "lblTotalQty";
            lblTotalQty.Size = new Size(117, 20);
            lblTotalQty.TabIndex = 14;
            lblTotalQty.Text = "Total Quantity: 0";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 564);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(50, 20);
            lblStatus.TabIndex = 15;
            lblStatus.Text = "Ready";
            lblStatus.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 596);
            Controls.Add(lblStatus);
            Controls.Add(lblTotalQty);
            Controls.Add(dgInventory);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(checkBox1);
            Controls.Add(btnClearAll);
            Controls.Add(btnRemoveSelected);
            Controls.Add(btnUpdateStock);
            Controls.Add(btnAddProduct);
            Controls.Add(nudQuantity);
            Controls.Add(comboBox1);
            Controls.Add(cmbCategory);
            Controls.Add(txtSKU);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgInventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSKU;
        private TextBox cmbCategory;
        private ComboBox comboBox1;
        private NumericUpDown nudQuantity;
        private Button btnAddProduct;
        private Button btnUpdateStock;
        private Button btnRemoveSelected;
        private Button btnClearAll;
        private CheckBox checkBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private DataGridView dgInventory;
        private DataGridViewTextBoxColumn colSKU;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn ColNAME;
        private DataGridViewTextBoxColumn ColCategory;
        private Label lblTotalQty;
        private Label lblStatus;
    }
}
