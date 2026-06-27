using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using WarehouseUI.Data;
using WarehouseUI.Models;

namespace WarehouseUI.Forms
{
    public partial class frmInventory : Form
    {
        private readonly InventoryRepository _repo = new InventoryRepository();
        private int _selectedProductID = -1;

        public frmInventory()
        {
            InitializeComponent();
            dgvInventory.AutoGenerateColumns = false;
            LoadCategories();
            LoadProducts();
        }

        private void LoadProducts()
        {
            
            dgvInventory.DataSource = _repo.GetAll();
        }

        private void LoadCategories()
        {
            DataTable dt = _repo.GetCategories();
            cmbCategory.DataSource = dt;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            _repo.Add(BuildItem());
            MessageBox.Show("Product added successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadProducts();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedProductID < 0)
            {
                MessageBox.Show("Please select a product from the grid first.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateInputs()) return;

            InventoryItem item = BuildItem();
            item.ProductID = _selectedProductID;
            _repo.Update(item);
            MessageBox.Show("Product updated successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadProducts();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedProductID < 0)
            {
                MessageBox.Show("Please select a product from the grid first.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this product?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                _repo.Delete(_selectedProductID);
                MessageBox.Show("Product deleted.", "Deleted",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProducts();
                ClearFields();
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
                LoadProducts();
            else
                dgvInventory.DataSource = _repo.Search(txtSearch.Text);
        }

        // button6 = Show All
        private void button6_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            LoadProducts();
        }

        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvInventory.Rows[e.RowIndex];

            _selectedProductID = Convert.ToInt32(row.Cells["ProductID"].Value);
            txtProductName.Text = row.Cells["ProductName"].Value?.ToString();
            reorderlvl.Text = row.Cells["ReorderLevel"].Value?.ToString();
            UnitPrice.Text = row.Cells["UnitPric"].Value?.ToString();
            txtQuantity.Value = Convert.ToDecimal(row.Cells["Quantity"].Value);

            // Match category in dropdown
            string catName = row.Cells["CategoryName"].Value?.ToString()!;
            foreach (DataRowView drv in cmbCategory.Items)
            {
                if (drv["CategoryName"].ToString() == catName)
                {
                    cmbCategory.SelectedItem = drv;
                    break;
                }
            }
        }

        private InventoryItem BuildItem()
        {
            return new InventoryItem
            {
                ProductName = txtProductName.Text.Trim(),
                CategoryID = (int)cmbCategory.SelectedValue!,
                Quantity = (int)txtQuantity.Value,
                ReorderLevel = int.Parse(reorderlvl.Text.Trim()),
                UnitPrice = decimal.Parse(UnitPrice.Text.Trim()),
            };
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Product name is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbCategory.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a category.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!int.TryParse(reorderlvl.Text, out _))
            {
                MessageBox.Show("Reorder level must be a whole number.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!decimal.TryParse(UnitPrice.Text, out _))
            {
                MessageBox.Show("Unit price must be a number.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void ClearFields()
        {
            txtProductName.Text = string.Empty;
            txtSearch.Text = string.Empty;
            reorderlvl.Text = string.Empty;
            UnitPrice.Text = string.Empty;
            txtQuantity.Value = 0;
            cmbCategory.SelectedIndex = -1;
            _selectedProductID = -1;
        }

        // These just trigger search on Enter key — leave empty or add if needed
        private void txtProductName_TextChanged(object sender, EventArgs e) { }
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtQuantity_ValueChanged(object sender, EventArgs e) { }
        private void reorderlvl_TextChanged(object sender, EventArgs e) { }
        private void UnitPrice_TextChanged(object sender, EventArgs e) { }
        private void txtSearch_TextChanged(object sender, EventArgs e) { }
    }
}