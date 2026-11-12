namespace projek_pbo.view
{
    partial class formKelolaSewa
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
            panel3 = new Panel();
            btnLogout = new Button();
            btnUser = new Button();
            btnLaporan = new Button();
            btnPengembaian = new Button();
            btnSewa = new Button();
            btnAlat = new Button();
            btnDashboard = new Button();
            label1 = new Label();
            pnlUtama = new Panel();
            pnlIsi = new Panel();
            panel2 = new Panel();
            lblPengguna = new Label();
            panel1.SuspendLayout();
            pnlUtama.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(47, 93, 58);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnUser);
            panel1.Controls.Add(btnLaporan);
            panel1.Controls.Add(btnPengembaian);
            panel1.Controls.Add(btnSewa);
            panel1.Controls.Add(btnAlat);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 633);
            panel1.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 125);
            panel3.TabIndex = 9;
            panel3.Paint += panel3_Paint;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 122, 60);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(9, 592);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(15, 0, 0, 0);
            btnLogout.Size = new Size(223, 29);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnUser
            // 
            btnUser.Dock = DockStyle.Top;
            btnUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 122, 60);
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.ForeColor = Color.White;
            btnUser.Location = new Point(0, 243);
            btnUser.Name = "btnUser";
            btnUser.Padding = new Padding(15, 0, 0, 0);
            btnUser.Size = new Size(250, 29);
            btnUser.TabIndex = 6;
            btnUser.Text = "Kelola user";
            btnUser.TextAlign = ContentAlignment.MiddleLeft;
            btnUser.UseVisualStyleBackColor = true;
            // 
            // btnLaporan
            // 
            btnLaporan.Dock = DockStyle.Top;
            btnLaporan.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 122, 60);
            btnLaporan.FlatStyle = FlatStyle.Flat;
            btnLaporan.ForeColor = Color.White;
            btnLaporan.Location = new Point(0, 214);
            btnLaporan.Name = "btnLaporan";
            btnLaporan.Padding = new Padding(15, 0, 0, 0);
            btnLaporan.Size = new Size(250, 29);
            btnLaporan.TabIndex = 5;
            btnLaporan.Text = "Laporan";
            btnLaporan.TextAlign = ContentAlignment.MiddleLeft;
            btnLaporan.UseVisualStyleBackColor = true;
            // 
            // btnPengembaian
            // 
            btnPengembaian.Dock = DockStyle.Top;
            btnPengembaian.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 122, 60);
            btnPengembaian.FlatStyle = FlatStyle.Flat;
            btnPengembaian.ForeColor = Color.FromArgb(224, 224, 224);
            btnPengembaian.Location = new Point(0, 185);
            btnPengembaian.Name = "btnPengembaian";
            btnPengembaian.Padding = new Padding(15, 0, 0, 0);
            btnPengembaian.Size = new Size(250, 29);
            btnPengembaian.TabIndex = 4;
            btnPengembaian.Text = "Kelola Pengembalian";
            btnPengembaian.TextAlign = ContentAlignment.MiddleLeft;
            btnPengembaian.UseVisualStyleBackColor = true;
            // 
            // btnSewa
            // 
            btnSewa.Dock = DockStyle.Top;
            btnSewa.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 122, 60);
            btnSewa.FlatStyle = FlatStyle.Flat;
            btnSewa.ForeColor = Color.White;
            btnSewa.Location = new Point(0, 156);
            btnSewa.Name = "btnSewa";
            btnSewa.Padding = new Padding(15, 0, 0, 0);
            btnSewa.Size = new Size(250, 29);
            btnSewa.TabIndex = 3;
            btnSewa.Text = "Kelola Sewa";
            btnSewa.TextAlign = ContentAlignment.MiddleLeft;
            btnSewa.UseVisualStyleBackColor = true;
            // 
            // btnAlat
            // 
            btnAlat.Dock = DockStyle.Top;
            btnAlat.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 122, 60);
            btnAlat.FlatStyle = FlatStyle.Flat;
            btnAlat.ForeColor = Color.White;
            btnAlat.Location = new Point(0, 127);
            btnAlat.Name = "btnAlat";
            btnAlat.Padding = new Padding(15, 0, 0, 0);
            btnAlat.Size = new Size(250, 29);
            btnAlat.TabIndex = 2;
            btnAlat.Text = "Kelola alat";
            btnAlat.TextAlign = ContentAlignment.MiddleLeft;
            btnAlat.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 122, 60);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 98);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(15, 0, 0, 0);
            btnDashboard.Size = new Size(250, 29);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(50, 30, 30, 30);
            label1.Size = new Size(224, 98);
            label1.TabIndex = 1;
            label1.Text = "Agri-Rent";
            // 
            // pnlUtama
            // 
            pnlUtama.Controls.Add(pnlIsi);
            pnlUtama.Controls.Add(panel2);
            pnlUtama.Dock = DockStyle.Fill;
            pnlUtama.Location = new Point(250, 0);
            pnlUtama.Name = "pnlUtama";
            pnlUtama.Size = new Size(832, 633);
            pnlUtama.TabIndex = 9;
            // 
            // pnlIsi
            // 
            pnlIsi.Dock = DockStyle.Fill;
            pnlIsi.Location = new Point(0, 78);
            pnlIsi.Name = "pnlIsi";
            pnlIsi.Padding = new Padding(24);
            pnlIsi.Size = new Size(832, 555);
            pnlIsi.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblPengguna);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(832, 78);
            panel2.TabIndex = 0;
            // 
            // lblPengguna
            // 
            lblPengguna.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPengguna.AutoSize = true;
            lblPengguna.Location = new Point(655, 30);
            lblPengguna.Name = "lblPengguna";
            lblPengguna.Size = new Size(165, 20);
            lblPengguna.TabIndex = 1;
            lblPengguna.Text = "Masuk sebagai: Petugas";
            // 
            // formKelolaSewa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 245, 238);
            ClientSize = new Size(1082, 633);
            Controls.Add(pnlUtama);
            Controls.Add(panel1);
            Name = "formKelolaSewa";
            Text = "formKelolaSewa";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlUtama.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnLogout;
        private Button btnUser;
        private Button btnLaporan;
        private Button btnPengembaian;
        private Button btnSewa;
        private Button btnAlat;
        private Button btnDashboard;
        private Label label1;
        private Panel pnlUtama;
        private Panel panel2;
        private Label lblPengguna;
        private Panel pnlIsi;
        private Panel panel3;
    }
}