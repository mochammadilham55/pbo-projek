namespace projek_pbo.view
{
    partial class formDashboard
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlSidebar = new Panel();
            btnLogout = new Button();
            btnUser = new Button();
            btnLaporan = new Button();
            btnPengembaian = new Button();
            btnSewa = new Button();
            btnAlat = new Button();
            btnDashboard = new Button();
            lblLogo = new Label();
            dgvTransaksi = new DataGridView();
            Tanggal = new DataGridViewTextBoxColumn();
            Penyewa = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            lblAlat = new Label();
            label2 = new Label();
            panel3 = new Panel();
            lblSewa = new Label();
            label4 = new Label();
            panel4 = new Panel();
            lblTelat = new Label();
            lbl = new Label();
            panel5 = new Panel();
            lblPendapatan = new Label();
            label3 = new Label();
            pnlUtama = new Panel();
            pnlJarak = new Panel();
            tblKartu = new TableLayoutPanel();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaksi).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            pnlUtama.SuspendLayout();
            tblKartu.SuspendLayout();
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
            btnLaporan.UseVisualStyleBackColor = true;
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
            btnDashboard.BackColor = Color.FromArgb(62, 122, 60);
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
            btnDashboard.UseVisualStyleBackColor = false;
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
            // dgvTransaksi
            // 
            dgvTransaksi.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(239, 236, 225);
            dgvTransaksi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransaksi.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(62, 122, 60);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTransaksi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransaksi.Columns.AddRange(new DataGridViewColumn[] { Tanggal, Penyewa, Column3, Column1, Column2, Column4 });
            dgvTransaksi.Dock = DockStyle.Fill;
            dgvTransaksi.EnableHeadersVisualStyles = false;
            dgvTransaksi.GridColor = Color.FromArgb(220, 215, 200);
            dgvTransaksi.Location = new Point(45, 179);
            dgvTransaksi.Name = "dgvTransaksi";
            dgvTransaksi.ReadOnly = true;
            dgvTransaksi.RowHeadersVisible = false;
            dgvTransaksi.RowHeadersWidth = 51;
            dgvTransaksi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransaksi.Size = new Size(972, 511);
            dgvTransaksi.TabIndex = 1;
            // 
            // Tanggal
            // 
            Tanggal.HeaderText = "Tanggal";
            Tanggal.MinimumWidth = 6;
            Tanggal.Name = "Tanggal";
            Tanggal.ReadOnly = true;
            // 
            // Penyewa
            // 
            Penyewa.HeaderText = "Nama Penyewa";
            Penyewa.MinimumWidth = 6;
            Penyewa.Name = "Penyewa";
            Penyewa.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Alat";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Jenis";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Total";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Status";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(62, 122, 60);
            panel2.Controls.Add(lblAlat);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0, 0, 20, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(223, 125);
            panel2.TabIndex = 3;
            // 
            // lblAlat
            // 
            lblAlat.Dock = DockStyle.Fill;
            lblAlat.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlat.ForeColor = Color.White;
            lblAlat.Location = new Point(0, 44);
            lblAlat.Name = "lblAlat";
            lblAlat.Size = new Size(223, 81);
            lblAlat.TabIndex = 1;
            lblAlat.Text = "0";
            lblAlat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(225, 225, 225);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(223, 44);
            label2.TabIndex = 0;
            label2.Text = "Alat Tersedia";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 165, 38);
            panel3.Controls.Add(lblSewa);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(243, 0);
            panel3.Margin = new Padding(0, 0, 20, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(223, 125);
            panel3.TabIndex = 1;
            // 
            // lblSewa
            // 
            lblSewa.Dock = DockStyle.Fill;
            lblSewa.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSewa.ForeColor = Color.White;
            lblSewa.Location = new Point(0, 44);
            lblSewa.Name = "lblSewa";
            lblSewa.Size = new Size(223, 81);
            lblSewa.TabIndex = 2;
            lblSewa.Text = "0";
            lblSewa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(225, 225, 225);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(223, 44);
            label4.TabIndex = 1;
            label4.Text = "Sewa Aktif";
            label4.TextAlign = ContentAlignment.BottomCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(179, 65, 47);
            panel4.Controls.Add(lblTelat);
            panel4.Controls.Add(lbl);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(486, 0);
            panel4.Margin = new Padding(0, 0, 20, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(223, 125);
            panel4.TabIndex = 2;
            // 
            // lblTelat
            // 
            lblTelat.Dock = DockStyle.Fill;
            lblTelat.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelat.ForeColor = Color.White;
            lblTelat.Location = new Point(0, 44);
            lblTelat.Name = "lblTelat";
            lblTelat.Size = new Size(223, 81);
            lblTelat.TabIndex = 3;
            lblTelat.Text = "0";
            lblTelat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl
            // 
            lbl.Dock = DockStyle.Top;
            lbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl.ForeColor = Color.FromArgb(225, 225, 225);
            lbl.Location = new Point(0, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(223, 44);
            lbl.TabIndex = 2;
            lbl.Text = "Sewa Terlambat";
            lbl.TextAlign = ContentAlignment.BottomCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(139, 94, 52);
            panel5.Controls.Add(lblPendapatan);
            panel5.Controls.Add(label3);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(729, 0);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(243, 125);
            panel5.TabIndex = 2;
            // 
            // lblPendapatan
            // 
            lblPendapatan.Dock = DockStyle.Fill;
            lblPendapatan.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendapatan.ForeColor = Color.White;
            lblPendapatan.Location = new Point(0, 44);
            lblPendapatan.Name = "lblPendapatan";
            lblPendapatan.Size = new Size(243, 81);
            lblPendapatan.TabIndex = 4;
            lblPendapatan.Text = "Rp0,-";
            lblPendapatan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(139, 94, 52);
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(225, 225, 225);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(243, 44);
            label3.TabIndex = 1;
            label3.Text = "Pendapatan Bulan Ini";
            label3.TextAlign = ContentAlignment.BottomCenter;
            // 
            // pnlUtama
            // 
            pnlUtama.Controls.Add(dgvTransaksi);
            pnlUtama.Controls.Add(pnlJarak);
            pnlUtama.Controls.Add(tblKartu);
            pnlUtama.Dock = DockStyle.Fill;
            pnlUtama.Location = new Point(250, 0);
            pnlUtama.Name = "pnlUtama";
            pnlUtama.Padding = new Padding(45, 30, 45, 30);
            pnlUtama.Size = new Size(1062, 720);
            pnlUtama.TabIndex = 4;
            // 
            // pnlJarak
            // 
            pnlJarak.Dock = DockStyle.Top;
            pnlJarak.Location = new Point(45, 155);
            pnlJarak.Name = "pnlJarak";
            pnlJarak.Size = new Size(972, 24);
            pnlJarak.TabIndex = 3;
            // 
            // tblKartu
            // 
            tblKartu.ColumnCount = 4;
            tblKartu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblKartu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblKartu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblKartu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblKartu.Controls.Add(panel2, 0, 0);
            tblKartu.Controls.Add(panel3, 1, 0);
            tblKartu.Controls.Add(panel4, 2, 0);
            tblKartu.Controls.Add(panel5, 3, 0);
            tblKartu.Dock = DockStyle.Top;
            tblKartu.Location = new Point(45, 30);
            tblKartu.Name = "tblKartu";
            tblKartu.RowCount = 1;
            tblKartu.RowStyles.Add(new RowStyle(SizeType.Absolute, 125F));
            tblKartu.Size = new Size(972, 125);
            tblKartu.TabIndex = 2;
            // 
            // formDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 245, 238);
            ClientSize = new Size(1312, 720);
            Controls.Add(pnlUtama);
            Controls.Add(pnlSidebar);
            MinimumSize = new Size(1150, 680);
            Name = "formDashboard";
            Text = "Dashboard - Agri-Rent";
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaksi).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            pnlUtama.ResumeLayout(false);
            tblKartu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Panel pnlUtama;
        private TableLayoutPanel tblKartu;
        private Panel pnlJarak;
        private DataGridView dgvTransaksi;
        private Panel panel2;
        private Label label2;
        private Label lblAlat;
        private Panel panel3;
        private Label lblSewa;
        private Label label4;
        private Panel panel4;
        private Label lblTelat;
        private Label lbl;
        private Panel panel5;
        private Label lblPendapatan;
        private Label label3;
        private DataGridViewTextBoxColumn Tanggal;
        private DataGridViewTextBoxColumn Penyewa;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
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