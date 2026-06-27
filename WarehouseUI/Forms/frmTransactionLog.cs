using System;
using System.Windows.Forms;
using WarehouseUI.Data;

namespace WarehouseUI.Forms
{
    public partial class frmTransactionLog : Form
    {
        private readonly TransactionRepository _repo = new TransactionRepository();

        public frmTransactionLog()
        {
            InitializeComponent();
            LoadTransactions();
        }

        private void LoadTransactions()
        {
            dgvTransactionLog.DataSource = _repo.GetAll();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTransactions();
        }

        // Leave empty
        private void dgvTransactionLog_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void TxnLogLabel_Click(object sender, EventArgs e) { }
    }
}