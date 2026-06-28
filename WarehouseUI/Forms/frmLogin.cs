using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace WarehouseUI.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 1. Gather raw string entries from text inputs
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text; // Leave passwords un-trimmed to preserve spaces

            // 2. Perform quick field validation check
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 3. Fire database query using your repository class
                var userRepo = new WarehouseUI.Data.UserRepository();
                bool isValidUser = userRepo.ValidateLogin(username, password);

                if (isValidUser)
                {
                    // Launch main panel container dashboard window on success
                    var mainDashboard = new WarehouseUI.Forms.frmMain();
                    mainDashboard.Show();

                    this.Hide(); // Hide the current login screen canvas wrapper panel
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection Error: {ex.Message}", "Database System Fault", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGoToRegister_Click(object sender, EventArgs e)
        {
            var registerForm = new WarehouseUI.Forms.frmRegister();
            registerForm.Show();
            this.Hide();
        }

        private void btnToggleLoginPassword_Click(object sender, EventArgs e)
        {
            // Toggle the system password masking state back and forth
    if (txtPassword.UseSystemPasswordChar)
            {
                // Unmask the text so the user can see what they typed
                txtPassword.UseSystemPasswordChar = false;
                btnToggleLoginPassword.Text = "🙈";
            }
            else
            {
                // Re-mask the text securely back into system password dots
                txtPassword.UseSystemPasswordChar = true;
                btnToggleLoginPassword.Text = "👁";
            }
        }
    }
    }

