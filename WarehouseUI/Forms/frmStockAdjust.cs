using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using WarehouseUI.Data;
using WarehouseUI.Models;

namespace WarehouseUI.Forms
{
    public partial class frmStockAdjust : Form
    {
        private readonly TransactionRepository _txnRepo = new TransactionRepository();
        private readonly InventoryRepository _invRepo = new InventoryRepository();
        private string _currentType = "IN"; // tracks whether IN or OUT is selected

        public frmStockAdjust()
        {
            InitializeComponent();
            LoadProducts();
            LoadTransactions();
            SetType("IN"); // default to Stock IN
        }

        private void LoadProducts()
        {
            DataTable dt = _invRepo.GetAll();
            cmbProduct.DisplayMember = "ProductName";
            cmbProduct.ValueMember = "ProductID";
            cmbProduct.DataSource = dt;
            cmbProduct.SelectedIndex = -1;
        }

        private void LoadTransactions()
        {
            dgvTransactions.DataSource = _txnRepo.GetAll();
        }

        private void SetType(string type)
        {
            _currentType = type;

            if (type == "IN")
            {
                StockIN.BackColor = Color.FromArgb(40, 167, 69);  // green = active
                StockIN.ForeColor = Color.White;
                StockOUT.BackColor = Color.FromArgb(60, 60, 60);   // dark = inactive
                StockOUT.ForeColor = Color.Silver;
                txtSupplier.Enabled = true;
                txtCustomer.Enabled = false;
            }
            else
            {
                StockOUT.BackColor = Color.FromArgb(220, 53, 69);  // red = active
                StockOUT.ForeColor = Color.White;
                StockIN.BackColor = Color.FromArgb(60, 60, 60);
                StockIN.ForeColor = Color.Silver;
                txtSupplier.Enabled = false;
                txtCustomer.Enabled = true;
            }
        }

        private void UpdateCurrentStockLabel()
        {
            if (cmbProduct.SelectedIndex < 0) return;

            // 1. Safe guard check against null references
            if (cmbProduct.SelectedValue == null) return;

            int productID = 0;

            // 2. If it is still in the binding phase, read directly from the Row View layout
            if (cmbProduct.SelectedValue is System.Data.DataRowView drv)
            {
                productID = Convert.ToInt32(drv["ProductID"]);
            }
            else
            {
                // 3. Otherwise, pull the fully loaded scalar index integer value normally
                productID = Convert.ToInt32(cmbProduct.SelectedValue);
            }

            DataTable dt = _invRepo.GetAll();

            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToInt32(row["ProductID"]) == productID)
                {
                    Currentstock.Text = $"Current Stock: {row["Quantity"]} units";
                    return;
                }
            }
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCurrentStockLabel();
        }

        private void StockIN_Click(object sender, EventArgs e)
        {
            SetType("IN");
        }

        private void StockOUT_Click(object sender, EventArgs e)
        {
            SetType("OUT");
        }

        private void btnConfirmm_Click(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a product.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtQuantity.Value <= 0)
            {
                MessageBox.Show("Quantity must be greater than 0.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int productID = Convert.ToInt32(cmbProduct.SelectedValue);
            int qty = (int)txtQuantity.Value;
            string productName = cmbProduct.Text;

            // Get category name for the log
            string categoryName = string.Empty;
            DataTable dt = _invRepo.GetAll();
            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToInt32(row["ProductID"]) == productID)
                {
                    categoryName = row["CategoryName"].ToString() ?? string.Empty;
                    break;
                }
            }

            // 1. Update stock
            _txnRepo.StockAdjust(productID, qty, _currentType);

            // 2. Log transaction
            _txnRepo.Log(new WarehouseUI.Models.Transaction
            {
                ProductID = productID,
                ProductName = productName,
                CategoryName = categoryName,
                Quantity = qty,
                Price = 0,
                TransactionType = _currentType,
                SupplierName = txtSupplier.Text.Trim(),
                CustomerName = txtCustomer.Text.Trim(),
                Remarks = txtRemarks.Text.Trim()
            });

            MessageBox.Show($"Stock {_currentType} recorded successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadTransactions();
            UpdateCurrentStockLabel();
            ClearFields();
        }

        private void ClearFields()
        {
            txtQuantity.Value = 0;
            txtSupplier.Text = string.Empty;
            txtCustomer.Text = string.Empty;
            txtRemarks.Text = string.Empty;
        }

        // Leave empty
        private void txtQuantity_ValueChanged(object sender, EventArgs e) { }
        private void txtSupplier_TextChanged(object sender, EventArgs e) { }
        private void txtCustomer_TextChanged(object sender, EventArgs e) { }
        private void txtRemarks_TextChanged(object sender, EventArgs e) { }
        private void dgvTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void Currentstock_Click(object sender, EventArgs e) { }
    }
}