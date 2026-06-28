namespace WarehouseUI.Forms
{
    partial class frmLowStockAlerts
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
            panel1 = new Panel();
            btnRefresh = new Button();
            lblBadge = new Label();
            lblAlertHeader = new Label();
            dgvLowStock = new DataGridView();
            ProductName = new DataGridViewTextBoxColumn();
            CategoryName = new DataGridViewTextBoxColumn();
            ReorderLevel = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLowStock).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 34, 34);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(lblBadge);
            panel1.Controls.Add(lblAlertHeader);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 60);
            panel1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(85, 85, 85);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(634, 15);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(112, 34);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "🔄 Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblBadge
            // 
            lblBadge.BackColor = Color.FromArgb(61, 27, 27);
            lblBadge.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBadge.ForeColor = Color.FromArgb(255, 107, 107);
            lblBadge.Location = new Point(216, 22);
            lblBadge.Name = "lblBadge";
            lblBadge.Size = new Size(182, 21);
            lblBadge.TabIndex = 1;
            lblBadge.Text = "3 items need attention";
            lblBadge.Click += lblBadge_Click;
            // 
            // lblAlertHeader
            // 
            lblAlertHeader.AutoSize = true;
            lblAlertHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlertHeader.ForeColor = Color.White;
            lblAlertHeader.Location = new Point(12, 22);
            lblAlertHeader.Name = "lblAlertHeader";
            lblAlertHeader.Size = new Size(158, 21);
            lblAlertHeader.TabIndex = 0;
            lblAlertHeader.Text = "⚠ Low stock alerts";
            lblAlertHeader.Click += lblAlertHeader_Click;
            // 
            // dgvLowStock
            // 
            dgvLowStock.BackgroundColor = Color.FromArgb(18, 22, 26);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(26, 28, 30);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLowStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLowStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLowStock.Columns.AddRange(new DataGridViewColumn[] { ProductName, CategoryName, ReorderLevel, Quantity, Status });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(18, 22, 26);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvLowStock.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLowStock.Dock = DockStyle.Fill;
            dgvLowStock.EnableHeadersVisualStyles = false;
            dgvLowStock.GridColor = Color.FromArgb(40, 45, 53);
            dgvLowStock.Location = new Point(0, 60);
            dgvLowStock.Name = "dgvLowStock";
            dgvLowStock.RowHeadersVisible = false;
            dgvLowStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLowStock.Size = new Size(800, 390);
            dgvLowStock.TabIndex = 1;
            dgvLowStock.CellContentClick += dgvLowStock_CellContentClick;
            // 
            // ProductName
            // 
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "PRODUCT NAME";
            ProductName.Name = "ProductName";
            ProductName.Width = 180;
            // 
            // CategoryName
            // 
            CategoryName.DataPropertyName = "CategoryName";
            CategoryName.HeaderText = "CATEGORY";
            CategoryName.Name = "CategoryName";
            CategoryName.Width = 160;
            // 
            // ReorderLevel
            // 
            ReorderLevel.DataPropertyName = "ReorderLevel";
            ReorderLevel.HeaderText = "REORDER LEVEL";
            ReorderLevel.Name = "ReorderLevel";
            ReorderLevel.Width = 150;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "STOCK LEVEL";
            Quantity.Name = "Quantity";
            Quantity.Width = 150;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "STATUS";
            Status.Name = "Status";
            Status.Width = 150;
            // 
            // frmLowStockAlerts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 21);
            ClientSize = new Size(800, 450);
            Controls.Add(dgvLowStock);
            Controls.Add(panel1);
            Name = "frmLowStockAlerts";
            Text = "frmLowStockAlerts";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLowStock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRefresh;
        private Label lblBadge;
        private Label lblAlertHeader;
        private DataGridView dgvLowStock;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn ReorderLevel;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Status;
    }
}