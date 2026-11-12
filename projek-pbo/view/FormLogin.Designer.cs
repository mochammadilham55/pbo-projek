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
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(170, 140);
            panel1.Name = "panel1";
            panel1.Size = new Size(356, 346);
            panel1.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(62, 122, 60);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(47, 93, 58);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(102, 254);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(158, 29);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(128, 199);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(191, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(128, 119);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(191, 27);
            txtUsername.TabIndex = 1;
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
            label2.Location = new Point(128, 36);
            label2.Name = "label2";
            label2.Size = new Size(97, 41);
            label2.TabIndex = 0;
            label2.Text = "Login";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(247, 245, 238);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(583, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(634, 628);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(123, 229);
            label4.Name = "label4";
            label4.Size = new Size(191, 50);
            label4.TabIndex = 2;
            label4.Text = "Agri-Rent\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(123, 288);
            label5.Name = "label5";
            label5.Size = new Size(256, 20);
            label5.TabIndex = 7;
            label5.Text = "Manajemen Persewaan Alat Pertanian";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(223, 164, 38);
            label6.Location = new Point(116, 279);
            label6.Name = "label6";
            label6.Size = new Size(127, 62);
            label6.TabIndex = 8;
            label6.Text = "_____";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 93, 58);
            ClientSize = new Size(1217, 628);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(panel2);
            AcceptButton = btnLogin;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - Agri-Rent";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label3;
        private Button btnLogin;
        private Panel panel2;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}