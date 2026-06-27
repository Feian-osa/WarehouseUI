namespace WarehouseUI.Forms
{
    partial class frmReports
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
            btnExport = new Button();
            reportlbl = new Label();
            panelReportControls = new Panel();
            btnGenerate = new Button();
            cmbReportType = new ComboBox();
            dataGridView1 = new DataGridView();
            ProductName = new DataGridViewTextBoxColumn();
            CategoryName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            UnitPricee = new DataGridViewTextBoxColumn();
            TotalValue = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            panelFormHeader.SuspendLayout();
            panelReportControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelFormHeader
            // 
            panelFormHeader.BackColor = Color.FromArgb(26, 28, 30);
            panelFormHeader.Controls.Add(btnExport);
            panelFormHeader.Controls.Add(reportlbl);
            panelFormHeader.Dock = DockStyle.Top;
            panelFormHeader.Location = new Point(0, 0);
            panelFormHeader.Name = "panelFormHeader";
            panelFormHeader.Size = new Size(800, 55);
            panelFormHeader.TabIndex = 0;
            // 
            // btnExport
            // 
            btnExport.FlatAppearance.BorderColor = Color.FromArgb(85, 85, 85);
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(656, 12);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(115, 37);
            btnExport.TabIndex = 1;
            btnExport.Text = "📩Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // reportlbl
            // 
            reportlbl.AutoSize = true;
            reportlbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reportlbl.ForeColor = Color.White;
            reportlbl.Location = new Point(22, 9);
            reportlbl.Name = "reportlbl";
            reportlbl.Size = new Size(86, 20);
            reportlbl.TabIndex = 0;
            reportlbl.Text = "📄Reports";
            reportlbl.Click += reportlbl_Click;
            // 
            // panelReportControls
            // 
            panelReportControls.BackColor = Color.Transparent;
            panelReportControls.Controls.Add(btnGenerate);
            panelReportControls.Controls.Add(cmbReportType);
            panelReportControls.Dock = DockStyle.Top;
            panelReportControls.Location = new Point(0, 55);
            panelReportControls.Name = "panelReportControls";
            panelReportControls.Size = new Size(800, 60);
            panelReportControls.TabIndex = 1;
            // 
            // btnGenerate
            // 
            btnGenerate.FlatAppearance.BorderColor = Color.FromArgb(85, 85, 85);
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(673, 18);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(89, 25);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // cmbReportType
            // 
            cmbReportType.BackColor = Color.FromArgb(26, 28, 30);
            cmbReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReportType.FlatStyle = FlatStyle.Flat;
            cmbReportType.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbReportType.ForeColor = Color.Black;
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Items.AddRange(new object[] { "Product list", "Low stock report", "Transaction summary" });
            cmbReportType.Location = new Point(12, 15);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(595, 28);
            cmbReportType.TabIndex = 0;
            cmbReportType.SelectedIndexChanged += cmbReportType_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(18, 22, 26);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(26, 28, 30);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ProductName, CategoryName, Quantity, UnitPricee, TotalValue, Status });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(18, 22, 26);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(31, 56, 100);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(35, 39, 42);
            dataGridView1.Location = new Point(0, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(800, 335);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            Quantity.HeaderText = "QTY IN STOCK";
            Quantity.Name = "Quantity";
            // 
            // UnitPricee
            // 
            UnitPricee.DataPropertyName = "UnitPrice";
            UnitPricee.HeaderText = "UNIT PRICE";
            UnitPricee.Name = "UnitPricee";
            // 
            // TotalValue
            // 
            TotalValue.DataPropertyName = "TotalValue";
            TotalValue.HeaderText = "TOTAL VALUE";
            TotalValue.Name = "TotalValue";
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "STATUS";
            Status.Name = "Status";
            // 
            // frmReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 21);
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panelReportControls);
            Controls.Add(panelFormHeader);
            Name = "frmReports";
            Text = "frmReports";
            panelFormHeader.ResumeLayout(false);
            panelFormHeader.PerformLayout();
            panelReportControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFormHeader;
        private Button btnExport;
        private Label reportlbl;
        private Panel panelReportControls;
        private ComboBox cmbReportType;
        private Button btnGenerate;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn UnitPricee;
        private DataGridViewTextBoxColumn TotalValue;
        private DataGridViewTextBoxColumn Status;
    }
}