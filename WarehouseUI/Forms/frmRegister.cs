using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WarehouseUI.Forms
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            // 1. Extract string items from form controls
            string fullName = txtFullName.Text.Trim();
            string username = txtRegisterUsername.Text.Trim();
            string password = txtRegisterPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // 2. Empty field check bounds validation
            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblErrorMsg.Text = "All fields are strictly required.";
                lblErrorMsg.Visible = true;
                return;
            }

            // 3. Confirm password matching safety rule
            if (password != confirmPassword)
            {
                lblErrorMsg.Text = "Passwords do not match.";
                lblErrorMsg.Visible = true;
                return;
            }

            try
            {
                var userRepo = new WarehouseUI.Data.UserRepository();

                // 4. Duplicate identity check prevent duplication rows
                if (userRepo.UsernameExists(username))
                {
                    lblErrorMsg.Text = "Username is already taken.";
                    lblErrorMsg.Visible = true;
                    return;
                }

                // 5. Fire insert statement script into local table array
                userRepo.Register(username, password, fullName);

                MessageBox.Show("Staff account created successfully! Please log in.", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Redirect back to login block layout automatically
                var loginForm = new WarehouseUI.Forms.frmLogin();
                loginForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Registration Fault: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            var loginForm = new WarehouseUI.Forms.frmLogin();
            loginForm.Show();
            this.Hide();
        }



        

        private void btnToggleRegisterPasswords_Click(object sender, EventArgs e)
        {

            // Toggle both fields at the exact same time
            if (txtRegisterPassword.UseSystemPasswordChar)
            {
                txtRegisterPassword.UseSystemPasswordChar = false;
                txtConfirmPassword.UseSystemPasswordChar = false;
                btnToggleRegisterPasswords.Text = "🙈";
            }
            else
            {
                txtRegisterPassword.UseSystemPasswordChar = true;
                txtConfirmPassword.UseSystemPasswordChar = true;
                btnToggleRegisterPasswords.Text = "👁";
            }
        }
    }
}

