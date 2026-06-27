namespace WarehouseUI.Forms
{
    partial class frmInventory
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelformHeader = new Panel();
            label1 = new Label();
            panelInputs = new Panel();
            txtQuantity = new NumericUpDown();
            cmbCategory = new ComboBox();
            UnitPrice = new TextBox();
            reorderlvl = new TextBox();
            BtnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtProductName = new TextBox();
            txtUnitPrice = new Label();
            txtReorderLevel = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            dgvInventory = new DataGridView();
            btnShowall = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            ProductID = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            CategoryName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            ReorderLevel = new DataGridViewTextBoxColumn();
            UnitPric = new DataGridViewTextBoxColumn();
            panelformHeader.SuspendLayout();
            panelInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantity).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            SuspendLayout();
            // 
            // panelformHeader
            // 
            panelformHeader.BackColor = Color.FromArgb(26, 28, 30);
            panelformHeader.Controls.Add(label1);
            panelformHeader.Dock = DockStyle.Top;
            panelformHeader.Location = new Point(0, 0);
            panelformHeader.Name = "panelformHeader";
            panelformHeader.Size = new Size(800, 50);
            panelformHeader.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(175, 20);
            label1.TabIndex = 0;
            label1.Text = "Inventory management";
            // 
            // panelInputs
            // 
            panelInputs.BackColor = Color.Transparent;
            panelInputs.Controls.Add(txtQuantity);
            panelInputs.Controls.Add(cmbCategory);
            panelInputs.Controls.Add(UnitPrice);
            panelInputs.Controls.Add(reorderlvl);
            panelInputs.Controls.Add(BtnClear);
            panelInputs.Controls.Add(btnDelete);
            panelInputs.Controls.Add(btnUpdate);
            panelInputs.Controls.Add(btnAdd);
            panelInputs.Controls.Add(txtProductName);
            panelInputs.Controls.Add(txtUnitPrice);
            panelInputs.Controls.Add(txtReorderLevel);
            panelInputs.Controls.Add(label4);
            panelInputs.Controls.Add(label3);
            panelInputs.Controls.Add(label2);
            panelInputs.Dock = DockStyle.Top;
            panelInputs.Location = new Point(0, 50);
            panelInputs.Name = "panelInputs";
            panelInputs.Size = new Size(800, 140);
            panelInputs.TabIndex = 1;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.FromArgb(30, 35, 42);
            txtQuantity.ForeColor = Color.White;
            txtQuantity.Location = new Point(294, 54);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(120, 23);
            txtQuantity.TabIndex = 19;
            txtQuantity.ValueChanged += txtQuantity_ValueChanged;
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.FromArgb(30, 35, 42);
            cmbCategory.ForeColor = Color.White;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(147, 54);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(121, 23);
            cmbCategory.TabIndex = 18;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // UnitPrice
            // 
            UnitPrice.BackColor = Color.FromArgb(30, 35, 42);
            UnitPrice.BorderStyle = BorderStyle.FixedSingle;
            UnitPrice.ForeColor = Color.White;
            UnitPrice.Location = new Point(575, 55);
            UnitPrice.Name = "UnitPrice";
            UnitPrice.Size = new Size(100, 23);
            UnitPrice.TabIndex = 17;
            UnitPrice.TextChanged += UnitPrice_TextChanged;
            // 
            // reorderlvl
            // 
            reorderlvl.BackColor = Color.FromArgb(30, 35, 42);
            reorderlvl.BorderStyle = BorderStyle.FixedSingle;
            reorderlvl.ForeColor = Color.White;
            reorderlvl.Location = new Point(444, 54);
            reorderlvl.Name = "reorderlvl";
            reorderlvl.Size = new Size(100, 23);
            reorderlvl.TabIndex = 16;
            reorderlvl.TextChanged += reorderlvl_TextChanged;
            // 
            // BtnClear
            // 
            BtnClear.FlatAppearance.BorderColor = Color.FromArgb(85, 85, 85);
            BtnClear.FlatStyle = FlatStyle.Flat;
            BtnClear.ForeColor = Color.White;
            BtnClear.Location = new Point(274, 96);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(75, 34);
            BtnClear.TabIndex = 13;
            BtnClear.Text = "❌ Clear";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(85, 85, 85);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(193, 96);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 34);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "🗑️ Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatAppearance.BorderColor = Color.FromArgb(85, 85, 85);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(112, 96);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 34);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "✔️ Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(85, 85, 85);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(31, 96);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 34);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "+ Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtProductName
            // 
            txtProductName.BackColor = Color.FromArgb(30, 35, 42);
            txtProductName.BorderStyle = BorderStyle.FixedSingle;
            txtProductName.ForeColor = Color.White;
            txtProductName.Location = new Point(27, 55);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(100, 23);
            txtProductName.TabIndex = 5;
            txtProductName.TextChanged += txtProductName_TextChanged;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.AutoSize = true;
            txtUnitPrice.ForeColor = Color.DarkGray;
            txtUnitPrice.Location = new Point(585, 26);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(81, 15);
            txtUnitPrice.TabIndex = 4;
            txtUnitPrice.Text = "Unit price (Rs)";
            // 
            // txtReorderLevel
            // 
            txtReorderLevel.AutoSize = true;
            txtReorderLevel.ForeColor = Color.DarkGray;
            txtReorderLevel.Location = new Point(454, 26);
            txtReorderLevel.Name = "txtReorderLevel";
            txtReorderLevel.Size = new Size(75, 15);
            txtReorderLevel.TabIndex = 3;
            txtReorderLevel.Text = "Reorder level";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(331, 26);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 2;
            label4.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DarkGray;
            label3.Location = new Point(173, 26);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 1;
            label3.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(27, 26);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 0;
            label2.Text = "Product Name";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvInventory);
            panel1.Controls.Add(btnShowall);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 190);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(800, 260);
            panel1.TabIndex = 2;
            // 
            // dgvInventory
            // 
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventory.BackgroundColor = Color.FromArgb(26, 28, 30);
            dgvInventory.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(26, 28, 30);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(26, 28, 30);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Columns.AddRange(new DataGridViewColumn[] { ProductID, ProductName, CategoryName, Quantity, ReorderLevel, UnitPric });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(18, 22, 26);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(31, 56, 100);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvInventory.DefaultCellStyle = dataGridViewCellStyle2;
            dgvInventory.Dock = DockStyle.Bottom;
            dgvInventory.EnableHeadersVisualStyles = false;
            dgvInventory.Location = new Point(10, 64);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.Size = new Size(780, 186);
            dgvInventory.TabIndex = 3;
            dgvInventory.CellContentClick += dgvInventory_CellContentClick;
            // 
            // btnShowall
            // 
            btnShowall.Location = new Point(701, 21);
            btnShowall.Name = "btnShowall";
            btnShowall.Size = new Size(75, 23);
            btnShowall.TabIndex = 2;
            btnShowall.Text = "Show All";
            btnShowall.UseVisualStyleBackColor = true;
            btnShowall.Click += button6_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(620, 22);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "🔍Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(30, 35, 42);
            txtSearch.Location = new Point(31, 22);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search By name or Category";
            txtSearch.Size = new Size(583, 23);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // ProductID
            // 
            ProductID.DataPropertyName = "ProductID";
            ProductID.HeaderText = "ID";
            ProductID.Name = "ProductID";
            // 
            // ProductName
            // 
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "PRODUCT NAME";
            ProductName.Name = "ProductName";
            // 
            // CategoryName
            // 
            CategoryName.DataPropertyName = "CategoryName";
            CategoryName.HeaderText = "CATEGORY";
            CategoryName.Name = "CategoryName";
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "QTY";
            Quantity.Name = "Quantity";
            // 
            // ReorderLevel
            // 
            ReorderLevel.DataPropertyName = "ReorderLevel";
            ReorderLevel.HeaderText = "REORDER LVL";
            ReorderLevel.Name = "ReorderLevel";
            // 
            // UnitPric
            // 
            UnitPric.DataPropertyName = "UnitPrice";
            UnitPric.HeaderText = "UNIT PRICE";
            UnitPric.Name = "UnitPric";
            // 
            // frmInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panelInputs);
            Controls.Add(panelformHeader);
            Name = "frmInventory";
            Text = "frmInventory";
            panelformHeader.ResumeLayout(false);
            panelformHeader.PerformLayout();
            panelInputs.ResumeLayout(false);
            panelInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantity).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelformHeader;
        private Label label1;
        private Panel panelInputs;
        private TextBox txtProductName;
        private Label txtUnitPrice;
        private Label txtReorderLevel;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox UnitPrice;
        private TextBox reorderlvl;
        private Button BtnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private NumericUpDown txtQuantity;
        private ComboBox cmbCategory;
        private Panel panel1;
        private TextBox txtSearch;
        private Button btnShowall;
        private Button btnSearch;
        private DataGridView dgvInventory;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn ReorderLevel;
        private DataGridViewTextBoxColumn UnitPric;
    }
}