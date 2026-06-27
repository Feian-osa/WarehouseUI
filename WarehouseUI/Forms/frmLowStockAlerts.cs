using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using WarehouseUI.Data;

namespace WarehouseUI.Forms
{
    public partial class frmLowStockAlerts : Form
    {
        private readonly InventoryRepository _repo = new InventoryRepository();

        public frmLowStockAlerts()
        {
            InitializeComponent();
            LoadAlerts();
        }

        private void LoadAlerts()
        {
            using (var con = DbConnection.GetConnection())
            {
                con.Open();
                string sql = @"
                    SELECT p.ProductName,
                           c.CategoryName,
                           p.Quantity,
                           p.ReorderLevel,
                           CASE WHEN p.Quantity = 0               THEN 'Out of Stock'
                                WHEN p.Quantity <= p.ReorderLevel * 0.5 THEN 'Critical'
                                ELSE 'Low'
                           END AS Status
                    FROM Products p
                    JOIN Categories c ON p.CategoryID = c.CategoryID
                    WHERE p.Quantity <= p.ReorderLevel
                    ORDER BY p.Quantity ASC";

                var da = new Microsoft.Data.SqlClient.SqlDataAdapter(sql, con);
                var dt = new DataTable();
                da.Fill(dt);
                dgvLowStock.AutoGenerateColumns = false; // Prevents duplicate columns from appearing
                dgvLowStock.DataSource = dt;
                lblBadge.Text = $"{dt.Rows.Count} items need attention";
            }

            // Update badge count
            lblBadge.Text = $"{dgvLowStock.Rows.Count} items need attention";
            lblBadge.ForeColor = dgvLowStock.Rows.Count > 0
                ? Color.FromArgb(220, 53, 69)
                : Color.FromArgb(40, 167, 69);

            // Color-code rows
            foreach (DataGridViewRow row in dgvLowStock.Rows)
            {
                string status = row.Cells["Status"].Value?.ToString()!;
                switch (status)
                {
                    case "Out of Stock":
                        row.DefaultCellStyle.BackColor = Color.FromArgb(80, 30, 30);
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(255, 100, 100);
                        break;
                    case "Critical":
                        row.DefaultCellStyle.BackColor = Color.FromArgb(80, 50, 20);
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(255, 165, 0);
                        break;
                    default:
                        row.DefaultCellStyle.BackColor = Color.FromArgb(60, 55, 20);
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(255, 220, 80);
                        break;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAlerts();
        }

        // Leave empty
        private void lblBadge_Click(object sender, EventArgs e) { }
        private void dgvLowStock_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void lblAlertHeader_Click(object sender, EventArgs e) { }
    }
}