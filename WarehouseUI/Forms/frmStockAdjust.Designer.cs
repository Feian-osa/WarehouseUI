namespace WarehouseUI.Forms
{
    partial class frmStockAdjust
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
            panelStockInputs = new Panel();
            txtRemarks = new TextBox();
            txtCustomer = new TextBox();
            txtSupplier = new TextBox();
            btnConfirmm = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            txtQuantity = new NumericUpDown();
            StockOUT = new Button();
            StockIN = new Button();
            Currentstock = new Label();
            cmbProduct = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            labelcs = new Label();
            label2 = new Label();
            panel1 = new Panel();
            dgvTransactions = new DataGridView();
            label9 = new Label();
            ProductName = new DataGridViewTextBoxColumn();
            TransactionType = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            SupplierCustomer = new DataGridViewTextBoxColumn();
            TransactionDate = new DataGridViewTextBoxColumn();
            panelformHeader.SuspendLayout();
            panelStockInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantity).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
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
            label1.Location = new Point(25, 20);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 0;
            label1.Text = " 🔃 Stock in / out";
            // 
            // panelStockInputs
            // 
            panelStockInputs.BackColor = Color.Transparent;
            panelStockInputs.Controls.Add(txtRemarks);
            panelStockInputs.Controls.Add(txtCustomer);
            panelStockInputs.Controls.Add(txtSupplier);
            panelStockInputs.Controls.Add(btnConfirmm);
            panelStockInputs.Controls.Add(label8);
            panelStockInputs.Controls.Add(label7);
            panelStockInputs.Controls.Add(label6);
            panelStockInputs.Controls.Add(txtQuantity);
            panelStockInputs.Controls.Add(StockOUT);
            panelStockInputs.Controls.Add(StockIN);
            panelStockInputs.Controls.Add(Currentstock);
            panelStockInputs.Controls.Add(cmbProduct);
            panelStockInputs.Controls.Add(label5);
            panelStockInputs.Controls.Add(label4);
            panelStockInputs.Controls.Add(labelcs);
            panelStockInputs.Controls.Add(label2);
            panelStockInputs.Dock = DockStyle.Top;
            panelStockInputs.Location = new Point(0, 50);
            panelStockInputs.Name = "panelStockInputs";
            panelStockInputs.Size = new Size(800, 180);
            panelStockInputs.TabIndex = 1;
            // 
            // txtRemarks
            // 
            txtRemarks.BackColor = Color.FromArgb(20, 20, 21);
            txtRemarks.ForeColor = Color.Gray;
            txtRemarks.Location = new Point(409, 131);
            txtRemarks.Name = "txtRemarks";
            txtRemarks.PlaceholderText = "Optional note";
            txtRemarks.Size = new Size(127, 23);
            txtRemarks.TabIndex = 15;
            txtRemarks.TextChanged += txtRemarks_TextChanged;
            // 
            // txtCustomer
            // 
            txtCustomer.BackColor = Color.FromArgb(20, 20, 21);
            txtCustomer.ForeColor = Color.Gray;
            txtCustomer.Location = new Point(226, 131);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.PlaceholderText = "e.g. XYZ Corp";
            txtCustomer.Size = new Size(127, 23);
            txtCustomer.TabIndex = 14;
            txtCustomer.TextChanged += txtCustomer_TextChanged;
            // 
            // txtSupplier
            // 
            txtSupplier.BackColor = Color.FromArgb(20, 20, 21);
            txtSupplier.ForeColor = Color.Gray;
            txtSupplier.Location = new Point(31, 131);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.PlaceholderText = "e.g. ABC Suppliers";
            txtSupplier.Size = new Size(127, 23);
            txtSupplier.TabIndex = 13;
            txtSupplier.TextChanged += txtSupplier_TextChanged;
            // 
            // btnConfirmm
            // 
            btnConfirmm.BackColor = Color.FromArgb(20, 20, 21);
            btnConfirmm.FlatAppearance.BorderColor = Color.FromArgb(85, 85, 85);
            btnConfirmm.FlatStyle = FlatStyle.Flat;
            btnConfirmm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmm.ForeColor = Color.White;
            btnConfirmm.Location = new Point(560, 123);
            btnConfirmm.Name = "btnConfirmm";
            btnConfirmm.Size = new Size(120, 31);
            btnConfirmm.TabIndex = 12;
            btnConfirmm.Text = "✔️ Confirm";
            btnConfirmm.UseVisualStyleBackColor = false;
            btnConfirmm.Click += btnConfirmm_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Gray;
            label8.Location = new Point(427, 107);
            label8.Name = "label8";
            label8.Size = new Size(71, 21);
            label8.TabIndex = 11;
            label8.Text = "Remarks";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(213, 107);
            label7.Name = "label7";
            label7.Size = new Size(179, 21);
            label7.TabIndex = 10;
            label7.Text = "Customer name (if OUT)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(25, 107);
            label6.Name = "label6";
            label6.Size = new Size(154, 21);
            label6.TabIndex = 9;
            label6.Text = "Supplier name (if IN)";
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.FromArgb(20, 20, 21);
            txtQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantity.ForeColor = Color.White;
            txtQuantity.Location = new Point(560, 52);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(120, 29);
            txtQuantity.TabIndex = 8;
            txtQuantity.ValueChanged += txtQuantity_ValueChanged;
            // 
            // StockOUT
            // 
            StockOUT.BackColor = Color.FromArgb(47, 53, 56);
            StockOUT.FlatStyle = FlatStyle.Flat;
            StockOUT.ForeColor = Color.Gray;
            StockOUT.Location = new Point(427, 52);
            StockOUT.Name = "StockOUT";
            StockOUT.Size = new Size(86, 22);
            StockOUT.TabIndex = 7;
            StockOUT.Text = "Stock OUT";
            StockOUT.UseVisualStyleBackColor = false;
            StockOUT.Click += StockOUT_Click;
            // 
            // StockIN
            // 
            StockIN.BackColor = Color.FromArgb(46, 204, 113);
            StockIN.FlatStyle = FlatStyle.Flat;
            StockIN.ForeColor = Color.White;
            StockIN.Location = new Point(335, 52);
            StockIN.Name = "StockIN";
            StockIN.Size = new Size(86, 22);
            StockIN.TabIndex = 6;
            StockIN.Text = "Stock IN";
            StockIN.UseVisualStyleBackColor = false;
            StockIN.Click += StockIN_Click;
            // 
            // Currentstock
            // 
            Currentstock.AutoSize = true;
            Currentstock.BackColor = Color.FromArgb(11, 37, 69);
            Currentstock.ForeColor = Color.FromArgb(74, 144, 226);
            Currentstock.Location = new Point(213, 56);
            Currentstock.Name = "Currentstock";
            Currentstock.Size = new Size(60, 15);
            Currentstock.TabIndex = 5;
            Currentstock.Text = "😂50 units";
            Currentstock.Click += Currentstock_Click;
            // 
            // cmbProduct
            // 
            cmbProduct.BackColor = Color.FromArgb(20, 20, 21);
            cmbProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbProduct.ForeColor = Color.White;
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(25, 56);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(121, 29);
            cmbProduct.TabIndex = 4;
            cmbProduct.SelectedIndexChanged += cmbProduct_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(584, 15);
            label5.Name = "label5";
            label5.Size = new Size(70, 21);
            label5.TabIndex = 3;
            label5.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(370, 15);
            label4.Name = "label4";
            label4.Size = new Size(121, 21);
            label4.TabIndex = 2;
            label4.Text = "Movement Type";
            // 
            // labelcs
            // 
            labelcs.AutoSize = true;
            labelcs.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelcs.ForeColor = Color.Gray;
            labelcs.Location = new Point(195, 15);
            labelcs.Name = "labelcs";
            labelcs.Size = new Size(108, 21);
            labelcs.TabIndex = 1;
            labelcs.Text = "Current Stock ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(25, 15);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 0;
            label2.Text = "Select Product";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvTransactions);
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 230);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(15);
            panel1.Size = new Size(800, 220);
            panel1.TabIndex = 16;
            // 
            // dgvTransactions
            // 
            dgvTransactions.BackgroundColor = Color.FromArgb(18, 22, 26);
            dgvTransactions.BorderStyle = BorderStyle.None;
            dgvTransactions.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(18, 22, 26);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Columns.AddRange(new DataGridViewColumn[] { ProductName, TransactionType, Quantity, SupplierCustomer, TransactionDate });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(18, 22, 26);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(31, 56, 100);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTransactions.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTransactions.EnableHeadersVisualStyles = false;
            dgvTransactions.GridColor = Color.FromArgb(35, 39, 42);
            dgvTransactions.Location = new Point(18, 35);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.RowHeadersVisible = false;
            dgvTransactions.Size = new Size(764, 167);
            dgvTransactions.TabIndex = 1;
            dgvTransactions.CellContentClick += dgvTransactions_CellContentClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DimGray;
            label9.Location = new Point(18, 15);
            label9.Name = "label9";
            label9.Size = new Size(158, 17);
            label9.TabIndex = 0;
            label9.Text = "RECENT TRANSACTIONS";
            // 
            // ProductName
            // 
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "PRODUCT";
            ProductName.Name = "ProductName";
            ProductName.Width = 150;
            // 
            // TransactionType
            // 
            TransactionType.DataPropertyName = "TransactionType";
            TransactionType.HeaderText = "TYPE";
            TransactionType.Name = "TransactionType";
            TransactionType.Width = 150;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "QTY";
            Quantity.Name = "Quantity";
            Quantity.Width = 150;
            // 
            // SupplierCustomer
            // 
            SupplierCustomer.DataPropertyName = "SupplierCustomer";
            SupplierCustomer.HeaderText = "SUPPLEIR/CUSTOMER";
            SupplierCustomer.Name = "SupplierCustomer";
            SupplierCustomer.Width = 190;
            // 
            // TransactionDate
            // 
            TransactionDate.DataPropertyName = "TransactionDate";
            TransactionDate.HeaderText = "DATE";
            TransactionDate.Name = "TransactionDate";
            TransactionDate.Width = 130;
            // 
            // frmStockAdjust
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 21);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panelStockInputs);
            Controls.Add(panelformHeader);
            Name = "frmStockAdjust";
            Text = "frmStockAdjust";
            panelformHeader.ResumeLayout(false);
            panelformHeader.PerformLayout();
            panelStockInputs.ResumeLayout(false);
            panelStockInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantity).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelformHeader;
        private Label label1;
        private Panel panelStockInputs;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label labelcs;
        private ComboBox cmbProduct;
        private Button StockIN;
        private Label Currentstock;
        private NumericUpDown txtQuantity;
        private Button StockOUT;
        private Label label6;
        private Button btnConfirmm;
        private Label label8;
        private Label label7;
        private TextBox txtSupplier;
        private TextBox txtRemarks;
        private TextBox txtCustomer;
        private Panel panel1;
        private Label label9;
        private DataGridView dgvTransactions;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn TransactionType;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn SupplierCustomer;
        private DataGridViewTextBoxColumn TransactionDate;
    }
}