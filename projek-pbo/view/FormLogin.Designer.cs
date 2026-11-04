namespace projek_pbo.view
{
    partial class FormLogin
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblDaftar = new Label();
            btnLogin = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 245, 238);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(lblDaftar);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(186, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(356, 346);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(74, 74, 74);
            label1.Location = new Point(26, 119);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(47, 93, 58);
            label2.Location = new Point(128, 13);
            label2.Name = "label2";
            label2.Size = new Size(97, 41);
            label2.TabIndex = 0;
            label2.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(74, 74, 74);
            label3.Location = new Point(26, 199);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(128, 119);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(191, 27);
            txtUsername.TabIndex = 1;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(128, 199);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(191, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // lblDaftar
            // 
            lblDaftar.AutoSize = true;
            lblDaftar.ForeColor = Color.FromArgb(139, 94, 52);
            lblDaftar.Location = new Point(26, 314);
            lblDaftar.Name = "lblDaftar";
            lblDaftar.Size = new Size(51, 20);
            lblDaftar.TabIndex = 4;
            lblDaftar.Text = "Daftar";
            lblDaftar.Click += lblDaftar_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(62, 122, 60);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(47, 93, 58);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(85, 254);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(158, 29);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 93, 58);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FormLogin";
            Text = "FormLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label lblDaftar;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label3;
        private Button btnLogin;
    }
}