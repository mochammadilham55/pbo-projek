namespace projek_pbo.view
{
    partial class formLaporan
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
            pnlSidebar = new Panel();
            btnLogout = new Button();
            btnUser = new Button();
            btnLaporan = new Button();
            btnPengembaian = new Button();
            btnSewa = new Button();
            btnAlat = new Button();
            btnDashboard = new Button();
            lblLogo = new Label();
            pnlSidebar.SuspendLayout();
            SuspendLayout();
            //
            // pnlSidebar
            //
            pnlSidebar.BackColor = Color.FromArgb(47, 93, 58);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnUser);
            pnlSidebar.Controls.Add(btnLaporan);
            pnlSidebar.Controls.Add(btnPengembaian);
            pnlSidebar.Controls.Add(btnSewa);
            pnlSidebar.Controls.Add(btnAlat);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(lblLogo);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(250, 720);
            pnlSidebar.TabIndex = 10;
            //
            // btnLogout
            //
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogout.BackColor = Color.FromArgb(179, 65, 47);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(150, 50, 36);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(12, 672);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(226, 34);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            //
            // btnUser
            //
            btnUser.Dock = DockStyle.Top;
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 122, 60);
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.ForeColor = Color.White;
            btnUser.Location = new Point(0, 278);
            btnUser.Name = "btnUser";
            btnUser.Padding = new Padding(30, 0, 0, 0);
            btnUser.Size = new Size(250, 36);
            btnUser.TabIndex = 6;
            btnUser.Text = "Kelola User";
            btnUser.TextAlign = ContentAlignment.MiddleLeft;
            btnUser.UseVisualStyleBackColor = true;
            //
            // btnLaporan
            //
            btnLaporan.BackColor = Color.FromArgb(62, 122, 60);
            btnLaporan.Dock = DockStyle.Top;
            btnLaporan.FlatAppearance.BorderSize = 0;
            btnLaporan.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 122, 60);
            btnLaporan.FlatStyle = FlatStyle.Flat;
            btnLaporan.ForeColor = Color.White;
            btnLaporan.Location = new Point(0, 242);
            btnLaporan.Name = "btnLaporan";
            btnLaporan.Padding = new Padding(30, 0, 0, 0);
            btnLaporan.Size = new Size(250, 36);
            btnLaporan.TabIndex = 5;
            btnLaporan.Text = "Laporan";
            btnLaporan.TextAlign = ContentAlignment.MiddleLeft;
            btnLaporan.UseVisualStyleBackColor = false;
            //
            // btnPengembaian
            //
            btnPengembaian.Dock = DockStyle.Top;
            btnPengembaian.FlatAppearance.BorderSize = 0;
            btnPengembaian.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 122, 60);
            btnPengembaian.FlatStyle = FlatStyle.Flat;
            btnPengembaian.ForeColor = Color.White;
            btnPengembaian.Location = new Point(0, 206);
            btnPengembaian.Name = "btnPengembaian";
            btnPengembaian.Padding = new Padding(30, 0, 0, 0);
            btnPengembaian.Size = new Size(250, 36);
            btnPengembaian.TabIndex = 4;
            btnPengembaian.Text = "Kelola Pengembalian";
            btnPengembaian.TextAlign = ContentAlignment.MiddleLeft;
            btnPengembaian.UseVisualStyleBackColor = true;
            //
            // btnSewa
            //
            btnSewa.Dock = DockStyle.Top;
            btnSewa.FlatAppearance.BorderSize = 0;
            btnSewa.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 122, 60);
            btnSewa.FlatStyle = FlatStyle.Flat;
            btnSewa.ForeColor = Color.White;
            btnSewa.Location = new Point(0, 170);
            btnSewa.Name = "btnSewa";
            btnSewa.Padding = new Padding(30, 0, 0, 0);
            btnSewa.Size = new Size(250, 36);
            btnSewa.TabIndex = 3;
            btnSewa.Text = "Kelola Sewa";
            btnSewa.TextAlign = ContentAlignment.MiddleLeft;
            btnSewa.UseVisualStyleBackColor = true;
            //
            // btnAlat
            //
            btnAlat.Dock = DockStyle.Top;
            btnAlat.FlatAppearance.BorderSize = 0;
            btnAlat.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 122, 60);
            btnAlat.FlatStyle = FlatStyle.Flat;
            btnAlat.ForeColor = Color.White;
            btnAlat.Location = new Point(0, 134);
            btnAlat.Name = "btnAlat";
            btnAlat.Padding = new Padding(30, 0, 0, 0);
            btnAlat.Size = new Size(250, 36);
            btnAlat.TabIndex = 2;
            btnAlat.Text = "Kelola Alat";
            btnAlat.TextAlign = ContentAlignment.MiddleLeft;
            btnAlat.UseVisualStyleBackColor = true;
            //
            // btnDashboard
            //
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 122, 60);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 98);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(30, 0, 0, 0);
            btnDashboard.Size = new Size(250, 36);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = true;
            //
            // lblLogo
            //
            lblLogo.AutoSize = true;
            lblLogo.Dock = DockStyle.Top;
            lblLogo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(0, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Padding = new Padding(50, 30, 30, 30);
            lblLogo.Size = new Size(224, 98);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "Agri-Rent";
            // 
            // formLaporan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 656);
            Controls.Add(pnlSidebar);
            MinimumSize = new Size(1150, 680);
            Name = "formLaporan";
            Text = "Laporan - Agri-Rent";
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Button btnLogout;
        private Button btnUser;
        private Button btnLaporan;
        private Button btnPengembaian;
        private Button btnSewa;
        private Button btnAlat;
        private Button btnDashboard;
        private Label lblLogo;
    }
}