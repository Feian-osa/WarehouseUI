namespace WarehouseUI.Forms
{
    partial class frmRegister
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtFullName = new TextBox();
            txtRegisterUsername = new TextBox();
            txtRegisterPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            lblErrorMsg = new Label();
            btnCreateAccount = new Button();
            btnBackToLogin = new Button();
            btnToggleRegisterPasswords = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2026_06_28_142150;
            pictureBox1.Location = new Point(161, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 66);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkBlue;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(270, 116);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 1;
            label1.Text = "Staff";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(101, 103);
            label2.Name = "label2";
            label2.Size = new Size(163, 30);
            label2.TabIndex = 2;
            label2.Text = "Create Account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DarkGray;
            label3.Location = new Point(92, 133);
            label3.Name = "label3";
            label3.Size = new Size(189, 15);
            label3.TabIndex = 3;
            label3.Text = "Register a new warehouse account";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(53, 202);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 4;
            label4.Text = "Ful Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.DarkGray;
            label5.Location = new Point(53, 281);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 5;
            label5.Text = "Username";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.DarkGray;
            label6.Location = new Point(54, 361);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 6;
            label6.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.DarkGray;
            label7.Location = new Point(53, 446);
            label7.Name = "label7";
            label7.Size = new Size(104, 15);
            label7.TabIndex = 7;
            label7.Text = "Confirm Password";
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.FromArgb(44, 44, 43);
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.ForeColor = Color.White;
            txtFullName.Location = new Point(54, 220);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "e.g. Dipu Sharma";
            txtFullName.Size = new Size(329, 23);
            txtFullName.TabIndex = 8;
            // 
            // txtRegisterUsername
            // 
            txtRegisterUsername.BackColor = Color.FromArgb(44, 44, 43);
            txtRegisterUsername.BorderStyle = BorderStyle.FixedSingle;
            txtRegisterUsername.ForeColor = Color.White;
            txtRegisterUsername.Location = new Point(53, 299);
            txtRegisterUsername.Name = "txtRegisterUsername";
            txtRegisterUsername.PlaceholderText = "e.g. Dipu123";
            txtRegisterUsername.Size = new Size(329, 23);
            txtRegisterUsername.TabIndex = 9;
            // 
            // txtRegisterPassword
            // 
            txtRegisterPassword.BackColor = Color.FromArgb(44, 44, 43);
            txtRegisterPassword.BorderStyle = BorderStyle.FixedSingle;
            txtRegisterPassword.ForeColor = Color.White;
            txtRegisterPassword.Location = new Point(53, 379);
            txtRegisterPassword.Name = "txtRegisterPassword";
            txtRegisterPassword.PlaceholderText = "Minimum 6 characters";
            txtRegisterPassword.Size = new Size(329, 23);
            txtRegisterPassword.TabIndex = 10;
            txtRegisterPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.FromArgb(44, 44, 43);
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.ForeColor = Color.White;
            txtConfirmPassword.Location = new Point(53, 464);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PlaceholderText = "Re-enter Password";
            txtConfirmPassword.Size = new Size(329, 23);
            txtConfirmPassword.TabIndex = 11;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.ForeColor = Color.FromArgb(231, 76, 60);
            lblErrorMsg.Location = new Point(144, 515);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(137, 15);
            lblErrorMsg.TabIndex = 12;
            lblErrorMsg.Text = "Passwords do not match";
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.Transparent;
            btnCreateAccount.FlatAppearance.BorderColor = Color.Gray;
            btnCreateAccount.FlatStyle = FlatStyle.Flat;
            btnCreateAccount.ForeColor = Color.White;
            btnCreateAccount.Location = new Point(53, 533);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(330, 32);
            btnCreateAccount.TabIndex = 13;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = false;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // btnBackToLogin
            // 
            btnBackToLogin.BackColor = Color.Transparent;
            btnBackToLogin.FlatAppearance.BorderColor = Color.Gray;
            btnBackToLogin.FlatStyle = FlatStyle.Flat;
            btnBackToLogin.ForeColor = Color.White;
            btnBackToLogin.Location = new Point(52, 571);
            btnBackToLogin.Name = "btnBackToLogin";
            btnBackToLogin.Size = new Size(330, 32);
            btnBackToLogin.TabIndex = 14;
            btnBackToLogin.Text = "👈 Back to Login";
            btnBackToLogin.UseVisualStyleBackColor = false;
            btnBackToLogin.Click += btnBackToLogin_Click;
            // 
            // btnToggleRegisterPasswords
            // 
            btnToggleRegisterPasswords.BackColor = Color.FromArgb(44, 44, 43);
            btnToggleRegisterPasswords.FlatAppearance.BorderSize = 0;
            btnToggleRegisterPasswords.FlatStyle = FlatStyle.Flat;
            btnToggleRegisterPasswords.ForeColor = Color.White;
            btnToggleRegisterPasswords.Location = new Point(343, 379);
            btnToggleRegisterPasswords.Name = "btnToggleRegisterPasswords";
            btnToggleRegisterPasswords.Size = new Size(39, 23);
            btnToggleRegisterPasswords.TabIndex = 15;
            btnToggleRegisterPasswords.Text = "👁";
            btnToggleRegisterPasswords.UseVisualStyleBackColor = false;
            btnToggleRegisterPasswords.Click += btnToggleRegisterPasswords_Click;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 15, 17);
            ClientSize = new Size(404, 681);
            Controls.Add(btnToggleRegisterPasswords);
            Controls.Add(btnBackToLogin);
            Controls.Add(btnCreateAccount);
            Controls.Add(lblErrorMsg);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtRegisterPassword);
            Controls.Add(txtRegisterUsername);
            Controls.Add(txtFullName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRegister";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtFullName;
        private TextBox txtRegisterUsername;
        private TextBox txtRegisterPassword;
        private TextBox txtConfirmPassword;
        private Label lblErrorMsg;
        private Button btnCreateAccount;
        private Button btnBackToLogin;
        private Button btnToggleRegisterPasswords;
    }
}