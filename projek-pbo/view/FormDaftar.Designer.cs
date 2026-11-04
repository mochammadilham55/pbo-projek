namespace projek_pbo.view
{
    partial class FormDaftar
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
            btnSubmit = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtNama = new TextBox();
            label5 = new Label();
            txtRole = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 245, 238);
            panel1.Controls.Add(txtRole);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtNama);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnSubmit);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(222, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(356, 386);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(62, 122, 60);
            btnSubmit.FlatAppearance.MouseOverBackColor = Color.FromArgb(47, 93, 58);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(85, 313);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(158, 29);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
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
            txtUsername.Location = new Point(128, 153);
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
            label1.Location = new Point(26, 153);
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
            label2.Location = new Point(85, 24);
            label2.Name = "label2";
            label2.Size = new Size(191, 41);
            label2.TabIndex = 0;
            label2.Text = "Daftar Akun";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(74, 74, 74);
            label4.Location = new Point(26, 112);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 7;
            label4.Text = "Nama";
            label4.Click += label4_Click;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(128, 109);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(191, 27);
            txtNama.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(74, 74, 74);
            label5.Location = new Point(26, 245);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 9;
            label5.Text = "Role";
            // 
            // txtRole
            // 
            txtRole.Location = new Point(128, 242);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(191, 27);
            txtRole.TabIndex = 10;
            txtRole.UseSystemPasswordChar = true;
            // 
            // FormDaftar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 93, 58);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FormDaftar";
            Text = "FormDaftar";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Button btnSubmit;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox txtRole;
        private Label label5;
        private TextBox txtNama;
    }
}