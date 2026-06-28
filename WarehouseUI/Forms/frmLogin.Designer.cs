namespace WarehouseUI.Forms
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            Username = new Label();
            Password = new Label();
            btnLogin = new Button();
            btnGoToRegister = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnToggleLoginPassword = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = Properties.Resources.Screenshot_2026_06_28_140841;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(163, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 47);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(117, 101);
            label1.Name = "label1";
            label1.Size = new Size(167, 30);
            label1.TabIndex = 1;
            label1.Text = "Warehouse IMS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(143, 131);
            label2.Name = "label2";
            label2.Size = new Size(116, 17);
            label2.TabIndex = 2;
            label2.Text = "Sign in to continue";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username.ForeColor = Color.DarkGray;
            Username.Location = new Point(41, 225);
            Username.Name = "Username";
            Username.Size = new Size(67, 17);
            Username.TabIndex = 3;
            Username.Text = "Username";
            Username.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password.ForeColor = Color.LightGray;
            Password.Location = new Point(44, 319);
            Password.Name = "Password";
            Password.Size = new Size(64, 17);
            Password.TabIndex = 4;
            Password.Text = "Password";
            Password.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(58, 63, 68);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(67, 414);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(245, 32);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnGoToRegister
            // 
            btnGoToRegister.BackColor = Color.Transparent;
            btnGoToRegister.FlatAppearance.BorderColor = Color.FromArgb(58, 63, 68);
            btnGoToRegister.FlatStyle = FlatStyle.Flat;
            btnGoToRegister.ForeColor = Color.White;
            btnGoToRegister.Location = new Point(67, 490);
            btnGoToRegister.Name = "btnGoToRegister";
            btnGoToRegister.Size = new Size(245, 40);
            btnGoToRegister.TabIndex = 7;
            btnGoToRegister.Text = "Don't have an account? Register";
            btnGoToRegister.UseVisualStyleBackColor = false;
            btnGoToRegister.Click += btnGoToRegister_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(44, 44, 43);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.ForeColor = Color.LightGray;
            txtUsername.Location = new Point(44, 245);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(334, 23);
            txtUsername.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(44, 44, 43);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(44, 339);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(334, 23);
            txtPassword.TabIndex = 9;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnToggleLoginPassword
            // 
            btnToggleLoginPassword.BackColor = Color.FromArgb(44, 44, 43);
            btnToggleLoginPassword.FlatAppearance.BorderSize = 0;
            btnToggleLoginPassword.FlatStyle = FlatStyle.Flat;
            btnToggleLoginPassword.ForeColor = Color.White;
            btnToggleLoginPassword.Location = new Point(339, 339);
            btnToggleLoginPassword.Name = "btnToggleLoginPassword";
            btnToggleLoginPassword.Size = new Size(39, 23);
            btnToggleLoginPassword.TabIndex = 16;
            btnToggleLoginPassword.Text = "👁";
            btnToggleLoginPassword.UseVisualStyleBackColor = false;
            btnToggleLoginPassword.Click += btnToggleLoginPassword_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 15, 17);
            ClientSize = new Size(404, 561);
            Controls.Add(btnToggleLoginPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnGoToRegister);
            Controls.Add(btnLogin);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label Username;
        private Label Password;
        private Button btnLogin;
        private Button btnGoToRegister;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnToggleLoginPassword;
    }
}