namespace WarehouseUI.Forms
{
    partial class frmTransactionLog
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
            panelFormHeader = new Panel();
            btnRefresh = new Button();
            TxnLogLabel = new Label();
            dgvTransactionLog = new DataGridView();
            TransactionID = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            TransactionType = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            SupplierCustomer = new DataGridViewTextBoxColumn();
            Remarks = new DataGridViewTextBoxColumn();
            TransactionDate = new DataGridViewTextBoxColumn();
            panelFormHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactionLog).BeginInit();
            SuspendLayout();
            // 
            // panelFormHeader
            // 
            panelFormHeader.BackColor = Color.FromArgb(26, 28, 30);
            panelFormHeader.Controls.Add(btnRefresh);
            panelFormHeader.Controls.Add(TxnLogLabel);
            panelFormHeader.Dock = DockStyle.Top;
            panelFormHeader.Location = new Point(0, 0);
            panelFormHeader.Name = "panelFormHeader";
            panelFormHeader.Size = new Size(800, 55);
            panelFormHeader.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(85, 85, 85);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(649, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(118, 30);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "🔄 Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // TxnLogLabel
            // 
            TxnLogLabel.AutoSize = true;
            TxnLogLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxnLogLabel.ForeColor = Color.White;
            TxnLogLabel.Location = new Point(23, 22);
            TxnLogLabel.Name = "TxnLogLabel";
            TxnLogLabel.Size = new Size(142, 20);
            TxnLogLabel.TabIndex = 1;
            TxnLogLabel.Text = "📋 Transaction log";
            TxnLogLabel.Click += TxnLogLabel_Click;
            // 
            // dgvTransactionLog
            // 
            dgvTransactionLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransactionLog.BackgroundColor = Color.FromArgb(18, 22, 26);
            dgvTransactionLog.BorderStyle = BorderStyle.None;
            dgvTransactionLog.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(26, 28, 30);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTransactionLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTransactionLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactionLog.Columns.AddRange(new DataGridViewColumn[] { TransactionID, ProductName, TransactionType, Quantity, Price, SupplierCustomer, Remarks, TransactionDate });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(18, 22, 26);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(31, 56, 100);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTransactionLog.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTransactionLog.Dock = DockStyle.Fill;
            dgvTransactionLog.EnableHeadersVisualStyles = false;
            dgvTransactionLog.GridColor = Color.FromArgb(35, 39, 42);
            dgvTransactionLog.Location = new Point(0, 55);
            dgvTransactionLog.Name = "dgvTransactionLog";
            dgvTransactionLog.RowHeadersVisible = false;
            dgvTransactionLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactionLog.Size = new Size(800, 395);
            dgvTransactionLog.TabIndex = 1;
            dgvTransactionLog.CellContentClick += dgvTransactionLog_CellContentClick;
            // 
            // TransactionID
            // 
            TransactionID.DataPropertyName = "TransactionID";
            TransactionID.HeaderText = "ID";
            TransactionID.Name = "TransactionID";
            // 
            // ProductName
            // 
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "PRODUCT";
            ProductName.Name = "ProductName";
            // 
            // TransactionType
            // 
            TransactionType.DataPropertyName = "TransactionType";
            TransactionType.HeaderText = "TYPE";
            TransactionType.Name = "TransactionType";
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "QTY";
            Quantity.Name = "Quantity";
            // 
            // Price
            // 
            Price.DataPropertyName = "Price";
            Price.HeaderText = "PRICE";
            Price.Name = "Price";
            // 
            // SupplierCustomer
            // 
            SupplierCustomer.DataPropertyName = "SupplierCustomer";
            SupplierCustomer.HeaderText = "SUPPLIER / CUSTOMER";
            SupplierCustomer.Name = "SupplierCustomer";
            // 
            // Remarks
            // 
            Remarks.DataPropertyName = "Remarks";
            Remarks.HeaderText = "REMARKS";
            Remarks.Name = "Remarks";
            // 
            // TransactionDate
            // 
            TransactionDate.DataPropertyName = "TransactionDate";
            TransactionDate.HeaderText = "DATE";
            TransactionDate.Name = "TransactionDate";
            // 
            // frmTransactionLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 21);
            ClientSize = new Size(800, 450);
            Controls.Add(dgvTransactionLog);
            Controls.Add(panelFormHeader);
            Name = "frmTransactionLog";
            Text = "frmTransactionLog";
            panelFormHeader.ResumeLayout(false);
            panelFormHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactionLog).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFormHeader;
        private Label TxnLogLabel;
        private Button btnRefresh;
        private DataGridView dgvTransactionLog;
        private DataGridViewTextBoxColumn TransactionID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn TransactionType;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn SupplierCustomer;
        private DataGridViewTextBoxColumn Remarks;
        private DataGridViewTextBoxColumn TransactionDate;
    }
}