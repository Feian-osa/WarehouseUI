namespace WarehouseUI.Forms
{
    partial class frmMain
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
            panelNav = new Panel();
            label1 = new Label();
            btnDashboard = new Button();
            btnInventory = new Button();
            btnStockAdjust = new Button();
            btnLowStock = new Button();
            btnReports = new Button();
            btnTransactions = new Button();
            btnEOQ = new Button();
            btnProfit = new Button();
            lblTitle = new Label();
            panelContent = new Panel();
            dgvInventorySnapshot = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            lblSnapshotHeader = new Label();
            panel2 = new Panel();
            label12 = new Label();
            label11 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            label10 = new Label();
            label9 = new Label();
            label5 = new Label();
            PanelCardProducts = new Panel();
            label8 = new Label();
            label7 = new Label();
            label4 = new Label();
            panelHeader = new Panel();
            label2 = new Label();
            label3 = new Label();
            panelNav.SuspendLayout();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventorySnapshot).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            PanelCardProducts.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelNav
            // 
            panelNav.BackColor = Color.FromArgb(31, 56, 100);
            panelNav.Controls.Add(label1);
            panelNav.Controls.Add(btnDashboard);
            panelNav.Controls.Add(btnInventory);
            panelNav.Controls.Add(btnStockAdjust);
            panelNav.Controls.Add(btnLowStock);
            panelNav.Controls.Add(btnReports);
            panelNav.Controls.Add(btnTransactions);
            panelNav.Controls.Add(btnEOQ);
            panelNav.Controls.Add(btnProfit);
            panelNav.Controls.Add(lblTitle);
            panelNav.Dock = DockStyle.Left;
            panelNav.Location = new Point(0, 0);
            panelNav.Name = "panelNav";
            panelNav.Size = new Size(200, 611);
            panelNav.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 14;
            label1.Text = "Warehouse UI v1.0";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click_1;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.ImageAlign = ContentAlignment.TopLeft;
            btnDashboard.Location = new Point(6, 65);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(200, 48);
            btnDashboard.TabIndex = 13;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = Color.Transparent;
            btnInventory.FlatAppearance.BorderSize = 0;
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInventory.ForeColor = Color.White;
            btnInventory.ImageAlign = ContentAlignment.TopLeft;
            btnInventory.Location = new Point(3, 119);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(200, 48);
            btnInventory.TabIndex = 7;
            btnInventory.Text = "Inventory";
            btnInventory.TextAlign = ContentAlignment.MiddleLeft;
            btnInventory.UseVisualStyleBackColor = false;
            btnInventory.Click += btnInventory_Click;
            // 
            // btnStockAdjust
            // 
            btnStockAdjust.BackColor = Color.Transparent;
            btnStockAdjust.FlatAppearance.BorderSize = 0;
            btnStockAdjust.FlatStyle = FlatStyle.Flat;
            btnStockAdjust.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStockAdjust.ForeColor = Color.White;
            btnStockAdjust.Location = new Point(6, 173);
            btnStockAdjust.Name = "btnStockAdjust";
            btnStockAdjust.Size = new Size(191, 52);
            btnStockAdjust.TabIndex = 12;
            btnStockAdjust.Text = "Stock IN/OUT";
            btnStockAdjust.TextAlign = ContentAlignment.MiddleLeft;
            btnStockAdjust.UseVisualStyleBackColor = false;
            btnStockAdjust.Click += btnStockAdjust_Click;
            // 
            // btnLowStock
            // 
            btnLowStock.BackColor = Color.Transparent;
            btnLowStock.FlatAppearance.BorderSize = 0;
            btnLowStock.FlatStyle = FlatStyle.Flat;
            btnLowStock.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLowStock.ForeColor = Color.White;
            btnLowStock.Location = new Point(6, 231);
            btnLowStock.Name = "btnLowStock";
            btnLowStock.Size = new Size(191, 52);
            btnLowStock.TabIndex = 11;
            btnLowStock.Text = "Low Stock Alerts";
            btnLowStock.TextAlign = ContentAlignment.MiddleLeft;
            btnLowStock.UseVisualStyleBackColor = false;
            btnLowStock.Click += btnLowStock_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.Transparent;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(3, 289);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(191, 52);
            btnReports.TabIndex = 10;
            btnReports.Text = "Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnTransactions
            // 
            btnTransactions.BackColor = Color.Transparent;
            btnTransactions.FlatAppearance.BorderSize = 0;
            btnTransactions.FlatStyle = FlatStyle.Flat;
            btnTransactions.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransactions.ForeColor = Color.White;
            btnTransactions.Location = new Point(6, 347);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Size = new Size(191, 52);
            btnTransactions.TabIndex = 9;
            btnTransactions.Text = "Transaction Logs";
            btnTransactions.TextAlign = ContentAlignment.MiddleLeft;
            btnTransactions.UseVisualStyleBackColor = false;
            btnTransactions.Click += btnTransactions_Click;
            // 
            // btnEOQ
            // 
            btnEOQ.BackColor = Color.Transparent;
            btnEOQ.FlatAppearance.BorderSize = 0;
            btnEOQ.FlatStyle = FlatStyle.Flat;
            btnEOQ.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEOQ.ForeColor = Color.White;
            btnEOQ.Location = new Point(3, 405);
            btnEOQ.Name = "btnEOQ";
            btnEOQ.Size = new Size(191, 52);
            btnEOQ.TabIndex = 8;
            btnEOQ.Text = "EOQ Calculator";
            btnEOQ.TextAlign = ContentAlignment.MiddleLeft;
            btnEOQ.UseVisualStyleBackColor = false;
            btnEOQ.Click += btnEOQ_Click;
            // 
            // btnProfit
            // 
            btnProfit.BackColor = Color.Transparent;
            btnProfit.FlatAppearance.BorderSize = 0;
            btnProfit.FlatStyle = FlatStyle.Flat;
            btnProfit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfit.ForeColor = Color.White;
            btnProfit.Location = new Point(3, 463);
            btnProfit.Name = "btnProfit";
            btnProfit.Size = new Size(191, 52);
            btnProfit.TabIndex = 1;
            btnProfit.Text = "Profit Predictions";
            btnProfit.TextAlign = ContentAlignment.MiddleLeft;
            btnProfit.UseVisualStyleBackColor = false;
            btnProfit.Click += btnProfit_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(6, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(111, 16);
            lblTitle.TabIndex = 0;
            lblTitle.Text = " Warehouse IMS";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += label1_Click;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(18, 22, 26);
            panelContent.Controls.Add(dgvInventorySnapshot);
            panelContent.Controls.Add(lblSnapshotHeader);
            panelContent.Controls.Add(panel2);
            panelContent.Controls.Add(panel1);
            panelContent.Controls.Add(PanelCardProducts);
            panelContent.Controls.Add(panelHeader);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(200, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(884, 611);
            panelContent.TabIndex = 2;
            // 
            // dgvInventorySnapshot
            // 
            dgvInventorySnapshot.AllowUserToAddRows = false;
            dgvInventorySnapshot.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventorySnapshot.BackgroundColor = Color.FromArgb(30, 35, 42);
            dgvInventorySnapshot.BorderStyle = BorderStyle.None;
            dgvInventorySnapshot.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventorySnapshot.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvInventorySnapshot.Location = new Point(34, 312);
            dgvInventorySnapshot.Name = "dgvInventorySnapshot";
            dgvInventorySnapshot.RowHeadersVisible = false;
            dgvInventorySnapshot.Size = new Size(705, 214);
            dgvInventorySnapshot.TabIndex = 6;
            // 
            // Column1
            // 
            Column1.HeaderText = "Product";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Category";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Qty";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Reorder LVL";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Status";
            Column5.Name = "Column5";
            // 
            // lblSnapshotHeader
            // 
            lblSnapshotHeader.AutoSize = true;
            lblSnapshotHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSnapshotHeader.ForeColor = Color.White;
            lblSnapshotHeader.Location = new Point(34, 288);
            lblSnapshotHeader.Name = "lblSnapshotHeader";
            lblSnapshotHeader.Size = new Size(216, 21);
            lblSnapshotHeader.TabIndex = 5;
            lblSnapshotHeader.Text = "Recent Inventory Snapshot";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 35, 42);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(539, 105);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 120);
            panel2.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.LimeGreen;
            label12.Location = new Point(17, 89);
            label12.Name = "label12";
            label12.Size = new Size(79, 13);
            label12.TabIndex = 3;
            label12.Text = "across all time";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(17, 42);
            label11.Name = "label11";
            label11.Size = new Size(130, 40);
            label11.TabIndex = 4;
            label11.Text = "RS 4.6M";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(17, 14);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 2;
            label6.Text = "Total Stock Value";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 35, 42);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(283, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 120);
            panel1.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(14, 42);
            label10.Name = "label10";
            label10.Size = new Size(34, 40);
            label10.TabIndex = 3;
            label10.Text = "1";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(231, 76, 60);
            label9.Location = new Point(14, 89);
            label9.Name = "label9";
            label9.Size = new Size(79, 13);
            label9.TabIndex = 3;
            label9.Text = "needs reorder";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(14, 14);
            label5.Name = "label5";
            label5.Size = new Size(118, 20);
            label5.TabIndex = 1;
            label5.Text = "Low Stock Alerts";
            // 
            // PanelCardProducts
            // 
            PanelCardProducts.BackColor = Color.FromArgb(30, 35, 42);
            PanelCardProducts.Controls.Add(label8);
            PanelCardProducts.Controls.Add(label7);
            PanelCardProducts.Controls.Add(label4);
            PanelCardProducts.Location = new Point(34, 105);
            PanelCardProducts.Name = "PanelCardProducts";
            PanelCardProducts.Size = new Size(200, 120);
            PanelCardProducts.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.LimeGreen;
            label8.Location = new Point(17, 89);
            label8.Name = "label8";
            label8.Size = new Size(82, 13);
            label8.TabIndex = 2;
            label8.Text = "In 3 categories";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(17, 42);
            label7.Name = "label7";
            label7.Size = new Size(34, 40);
            label7.TabIndex = 1;
            label7.Text = "3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(17, 14);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 0;
            label4.Text = "Total Products";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(26, 28, 30);
            panelHeader.Controls.Add(label2);
            panelHeader.Controls.Add(label3);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(884, 60);
            panelHeader.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(149, 22);
            label2.Name = "label2";
            label2.Size = new Size(164, 15);
            label2.TabIndex = 2;
            label2.Text = "Overview of warehouse status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(34, 15);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 1;
            label3.Text = "Dashboard";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 22, 26);
            ClientSize = new Size(1084, 611);
            Controls.Add(panelContent);
            Controls.Add(panelNav);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WarehouseIMS";
            Click += label1_Click;
            panelNav.ResumeLayout(false);
            panelNav.PerformLayout();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventorySnapshot).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            PanelCardProducts.ResumeLayout(false);
            PanelCardProducts.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelNav;
        private Panel panelContent;
        private Label lblTitle;
        private Button btnInventory;
        private Button btnProfit;
        private Button btnReports;
        private Button btnTransactions;
        private Button btnEOQ;
        private Button btnStockAdjust;
        private Button btnLowStock;
        private Button btnDashboard;
        private Label label1;
        private Panel panelHeader;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private Label label6;
        private Panel panel1;
        private Label label5;
        private Panel PanelCardProducts;
        private Label label7;
        private Label label4;
        private Label label8;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label lblSnapshotHeader;
        private DataGridView dgvInventorySnapshot;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}