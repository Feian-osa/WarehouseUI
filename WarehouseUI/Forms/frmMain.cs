using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using WarehouseUI.Data;

namespace WarehouseUI.Forms
{
    public partial class frmMain : Form
    {
        private readonly InventoryRepository _invRepo = new InventoryRepository();

        public frmMain()
        {
            InitializeComponent();
            LoadDashboard();
        }

        private void LoadForm(Form child)
        {
            panelContent.Controls.Clear();
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panelContent.Controls.Add(child);
            child.Show();
        }

        private void LoadDashboard()
        {
            panelContent.Controls.Clear();

            int total = _invRepo.GetTotalProducts();
            int lowStock = _invRepo.GetLowStockCount();
            decimal value = _invRepo.GetTotalStockValue();

            Panel statsPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 110,
                BackColor = Color.Transparent,
                Padding = new Padding(16, 16, 16, 0)
            };
            statsPanel.Controls.Add(MakeStatCard("Total Stock Value",
                $"Rs {value:N0}", Color.FromArgb(30, 136, 229), 2));
            statsPanel.Controls.Add(MakeStatCard("Low Stock Alerts",
                lowStock.ToString(), Color.FromArgb(229, 57, 53), 1));
            statsPanel.Controls.Add(MakeStatCard("Total Products",
                total.ToString(), Color.FromArgb(56, 142, 60), 0));

            Label snapLabel = new Label
            {
                Text = "Recent Inventory Snapshot",
                Dock = DockStyle.Top,
                Height = 36,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Padding = new Padding(16, 8, 0, 0)
            };

            DataGridView grid = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AutoGenerateColumns = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                BackgroundColor = Color.FromArgb(30, 30, 30),
                ForeColor = Color.White,
                GridColor = Color.FromArgb(60, 60, 60),
                BorderStyle = BorderStyle.None,
                RowHeadersVisible = false,
                AllowUserToAddRows = false,
                AllowUserToResizeRows = false,
                Font = new Font("Segoe UI", 9)
            };
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.Silver;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            grid.DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            grid.DefaultCellStyle.ForeColor = Color.White;
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(50, 80, 120);
            grid.EnableHeadersVisualStyles = false;
            grid.DataSource = _invRepo.GetAllForDashboard();

            panelContent.Controls.Add(grid);
            panelContent.Controls.Add(snapLabel);
            panelContent.Controls.Add(statsPanel);
        }

        private Panel MakeStatCard(string title, string value, Color accent, int index)
        {
            int cardWidth = (panelContent.Width > 0 ? panelContent.Width : 860) / 3 - 16;

            Panel card = new Panel
            {
                Width = cardWidth,
                Height = 80,
                Left = index * (cardWidth + 12),
                Top = 0,
                BackColor = Color.FromArgb(40, 40, 40)
            };

            card.Controls.Add(new Label
            {
                Text = title,
                ForeColor = Color.Silver,
                Font = new Font("Segoe UI", 8),
                Left = 12,
                Top = 10,
                AutoSize = true
            });
            card.Controls.Add(new Label
            {
                Text = value,
                ForeColor = accent,
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                Left = 12,
                Top = 28,
                AutoSize = true
            });
            return card;
        }

        // ── Nav handlers ──────────────────────────────────────────
        private void btnDashboard_Click(object sender, EventArgs e)
            => LoadDashboard();

        private void btnInventory_Click(object sender, EventArgs e)
            => LoadForm(new frmInventory());

        private void btnStockAdjust_Click(object sender, EventArgs e)
            => LoadForm(new frmStockAdjust());

        private void btnLowStock_Click(object sender, EventArgs e)
            => LoadForm(new frmLowStockAlerts());

        private void btnReports_Click(object sender, EventArgs e)
            => LoadForm(new frmReports());

        private void btnTransactions_Click(object sender, EventArgs e)
            => LoadForm(new frmTransactionLog());

        private void btnEOQ_Click(object sender, EventArgs e)
            => LoadForm(new frmEOQCalculator());

        private void btnProfit_Click(object sender, EventArgs e)
            => LoadForm(new frmProfitPrediction());

        // Designer-wired stubs — leave empty
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
    }
}