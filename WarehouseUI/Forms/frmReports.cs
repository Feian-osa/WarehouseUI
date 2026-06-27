using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using WarehouseUI.Data;

namespace WarehouseUI.Forms
{
    public partial class frmReports : Form
    {
        private readonly InventoryRepository _invRepo = new InventoryRepository();
        private readonly TransactionRepository _txnRepo = new TransactionRepository();

        public frmReports()
        {
            InitializeComponent();
            SetupReportTypes();
        }

        private void SetupReportTypes()
        {
            cmbReportType.Items.Clear();
            cmbReportType.Items.Add("Product List");
            cmbReportType.Items.Add("Low Stock Report");
            cmbReportType.Items.Add("Transaction Summary");
            cmbReportType.SelectedIndex = 0;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (cmbReportType.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a report type.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = new DataTable();

            switch (cmbReportType?.SelectedItem?.ToString())
            {
                case "Product List":
                    dt = _invRepo.GetAll();
                    break;

                case "Low Stock Report":
                    dt = GetLowStockReport();
                    break;

                case "Transaction Summary":
                    dt = _txnRepo.GetAll();
                    break;
            }

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;
        }

        private DataTable GetLowStockReport()
        {
            using (var con = DbConnection.GetConnection())
            {
                con.Open();
                string sql = @"
                    SELECT p.ProductName,
                           c.CategoryName,
                           p.Quantity,
                           p.ReorderLevel,
                           CASE WHEN p.Quantity = 0                    THEN 'Out of Stock'
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
                return dt;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Generate a report first before exporting.", "Nothing to Export",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog dlg = new SaveFileDialog
            {
                Filter = "CSV file (*.csv)|*.csv",
                FileName = $"Report_{cmbReportType.SelectedItem}_{DateTime.Now:yyyyMMdd}.csv"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var sb = new StringBuilder();

                // Header row
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                    sb.Append(col.HeaderText + ",");
                sb.AppendLine();

                // Data rows
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                        sb.Append(cell.Value?.ToString() + ",");
                    sb.AppendLine();
                }

                File.WriteAllText(dlg.FileName, sb.ToString());
                MessageBox.Show($"Report exported to:\n{dlg.FileName}", "Export Successful",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Leave empty
        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void reportlbl_Click(object sender, EventArgs e) { }
    }
}