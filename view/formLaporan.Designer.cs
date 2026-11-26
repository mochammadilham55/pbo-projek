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
            pnlUtama = new Panel();
            pnlIsi = new Panel();
            pnlHasil = new Panel();
            dgvLaporan = new DataGridView();
            pnlTotal = new Panel();
            lblTotalTeks = new Label();
            lblTotal = new Label();
            lblJudulLaporan = new Label();
            pnlJarak = new Panel();
            pnlFilter = new Panel();
            btnTampilkan = new Button();
            dtpAkhir = new DateTimePicker();
            lblAkhir = new Label();
            dtpAwal = new DateTimePicker();
            lblAwal = new Label();
            cmbJenis = new ComboBox();
            lblJenis = new Label();
            pnlHeader = new Panel();
            lblJudulHalaman = new Label();
            lblPengguna = new Label();
            pnlSidebar.SuspendLayout();
            pnlUtama.SuspendLayout();
            pnlIsi.SuspendLayout();
            pnlHasil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLaporan).BeginInit();
            pnlTotal.SuspendLayout();
            pnlFilter.SuspendLayout();
            pnlHeader.SuspendLayout();
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
            // pnlUtama
            //
            pnlUtama.Controls.Add(pnlIsi);
            pnlUtama.Controls.Add(pnlHeader);
            pnlUtama.Dock = DockStyle.Fill;
            pnlUtama.Location = new Point(250, 0);
            pnlUtama.Name = "pnlUtama";
            pnlUtama.Size = new Size(1062, 720);
            pnlUtama.TabIndex = 11;
            //
            // pnlIsi
            //
            pnlIsi.BackColor = Color.FromArgb(247, 245, 238);
            pnlIsi.Controls.Add(pnlHasil);
            pnlIsi.Controls.Add(pnlJarak);
            pnlIsi.Controls.Add(pnlFilter);
            pnlIsi.Dock = DockStyle.Fill;
            pnlIsi.Location = new Point(0, 78);
            pnlIsi.Name = "pnlIsi";
            pnlIsi.Padding = new Padding(45, 20, 45, 30);
            pnlIsi.Size = new Size(1062, 642);
            pnlIsi.TabIndex = 1;
            //
            // pnlHasil
            //
            pnlHasil.BackColor = Color.White;
            pnlHasil.Controls.Add(dgvLaporan);
            pnlHasil.Controls.Add(pnlTotal);
            pnlHasil.Controls.Add(lblJudulLaporan);
            pnlHasil.Dock = DockStyle.Fill;
            pnlHasil.Location = new Point(45, 140);
            pnlHasil.Name = "pnlHasil";
            pnlHasil.Padding = new Padding(30, 10, 30, 18);
            pnlHasil.Size = new Size(972, 472);
            pnlHasil.TabIndex = 2;
            //
            // dgvLaporan
            //
            dgvLaporan.AllowUserToAddRows = false;
            dgvLaporan.AllowUserToDeleteRows = false;
            dgvLaporan.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(239, 236, 225);
            dgvLaporan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvLaporan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLaporan.BackgroundColor = Color.White;
            dgvLaporan.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(62, 122, 60);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvLaporan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvLaporan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLaporan.Dock = DockStyle.Fill;
            dgvLaporan.EnableHeadersVisualStyles = false;
            dgvLaporan.GridColor = Color.FromArgb(220, 215, 200);
            dgvLaporan.Location = new Point(30, 42);
            dgvLaporan.MultiSelect = false;
            dgvLaporan.Name = "dgvLaporan";
            dgvLaporan.ReadOnly = true;
            dgvLaporan.RowHeadersVisible = false;
            dgvLaporan.RowHeadersWidth = 51;
            dgvLaporan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLaporan.Size = new Size(912, 362);
            dgvLaporan.TabIndex = 0;
            //
            // pnlTotal
            //
            pnlTotal.Controls.Add(lblTotalTeks);
            pnlTotal.Controls.Add(lblTotal);
            pnlTotal.Dock = DockStyle.Bottom;
            pnlTotal.Location = new Point(30, 404);
            pnlTotal.Name = "pnlTotal";
            pnlTotal.Size = new Size(912, 50);
            pnlTotal.TabIndex = 2;
            //
            // lblTotalTeks
            //
            lblTotalTeks.Dock = DockStyle.Right;
            lblTotalTeks.Location = new Point(492, 0);
            lblTotalTeks.Name = "lblTotalTeks";
            lblTotalTeks.Size = new Size(170, 50);
            lblTotalTeks.TabIndex = 1;
            lblTotalTeks.Text = "Total Pendapatan";
            lblTotalTeks.TextAlign = ContentAlignment.MiddleRight;
            //
            // lblTotal
            //
            lblTotal.Dock = DockStyle.Right;
            lblTotal.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.FromArgb(47, 93, 58);
            lblTotal.Location = new Point(662, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(250, 50);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Rp0";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            //
            // lblJudulLaporan
            //
            lblJudulLaporan.Dock = DockStyle.Top;
            lblJudulLaporan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudulLaporan.ForeColor = Color.FromArgb(47, 93, 58);
            lblJudulLaporan.Location = new Point(30, 10);
            lblJudulLaporan.Name = "lblJudulLaporan";
            lblJudulLaporan.Size = new Size(912, 32);
            lblJudulLaporan.TabIndex = 1;
            lblJudulLaporan.Text = "Laporan";
            lblJudulLaporan.TextAlign = ContentAlignment.MiddleLeft;
            //
            // pnlJarak
            //
            pnlJarak.Dock = DockStyle.Top;
            pnlJarak.Location = new Point(45, 120);
            pnlJarak.Name = "pnlJarak";
            pnlJarak.Size = new Size(972, 20);
            pnlJarak.TabIndex = 1;
            //
            // pnlFilter
            //
            pnlFilter.BackColor = Color.White;
            pnlFilter.Controls.Add(btnTampilkan);
            pnlFilter.Controls.Add(dtpAkhir);
            pnlFilter.Controls.Add(lblAkhir);
            pnlFilter.Controls.Add(dtpAwal);
            pnlFilter.Controls.Add(lblAwal);
            pnlFilter.Controls.Add(cmbJenis);
            pnlFilter.Controls.Add(lblJenis);
            pnlFilter.Dock = DockStyle.Top;
            pnlFilter.Location = new Point(45, 20);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(972, 100);
            pnlFilter.TabIndex = 0;
            //
            // btnTampilkan
            //
            btnTampilkan.BackColor = Color.FromArgb(62, 122, 60);
            btnTampilkan.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            btnTampilkan.ForeColor = Color.White;
            btnTampilkan.Location = new Point(790, 42);
            btnTampilkan.Name = "btnTampilkan";
            btnTampilkan.Size = new Size(120, 30);
            btnTampilkan.TabIndex = 6;
            btnTampilkan.Text = "Tampilkan";
            btnTampilkan.UseVisualStyleBackColor = false;
            btnTampilkan.Click += btnTampilkan_Click;
            //
            // dtpAkhir
            //
            dtpAkhir.CustomFormat = "dd/MM/yyyy";
            dtpAkhir.Format = DateTimePickerFormat.Custom;
            dtpAkhir.Location = new Point(540, 42);
            dtpAkhir.Name = "dtpAkhir";
            dtpAkhir.Size = new Size(220, 27);
            dtpAkhir.TabIndex = 5;
            //
            // lblAkhir
            //
            lblAkhir.AutoSize = true;
            lblAkhir.Location = new Point(540, 16);
            lblAkhir.Name = "lblAkhir";
            lblAkhir.Size = new Size(99, 20);
            lblAkhir.TabIndex = 4;
            lblAkhir.Text = "Periode Akhir";
            //
            // dtpAwal
            //
            dtpAwal.CustomFormat = "dd/MM/yyyy";
            dtpAwal.Format = DateTimePickerFormat.Custom;
            dtpAwal.Location = new Point(290, 42);
            dtpAwal.Name = "dtpAwal";
            dtpAwal.Size = new Size(220, 27);
            dtpAwal.TabIndex = 3;
            //
            // lblAwal
            //
            lblAwal.AutoSize = true;
            lblAwal.Location = new Point(290, 16);
            lblAwal.Name = "lblAwal";
            lblAwal.Size = new Size(97, 20);
            lblAwal.TabIndex = 2;
            lblAwal.Text = "Periode Awal";
            //
            // cmbJenis
            //
            cmbJenis.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJenis.FormattingEnabled = true;
            cmbJenis.Location = new Point(30, 42);
            cmbJenis.Name = "cmbJenis";
            cmbJenis.Size = new Size(230, 28);
            cmbJenis.TabIndex = 1;
            //
            // lblJenis
            //
            lblJenis.AutoSize = true;
            lblJenis.Location = new Point(30, 16);
            lblJenis.Name = "lblJenis";
            lblJenis.Size = new Size(101, 20);
            lblJenis.TabIndex = 0;
            lblJenis.Text = "Jenis Laporan";
            //
            // pnlHeader
            //
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblJudulHalaman);
            pnlHeader.Controls.Add(lblPengguna);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(0, 0, 45, 0);
            pnlHeader.Size = new Size(1062, 78);
            pnlHeader.TabIndex = 0;
            //
            // lblJudulHalaman
            //
            lblJudulHalaman.AutoSize = true;
            lblJudulHalaman.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudulHalaman.ForeColor = Color.FromArgb(47, 93, 58);
            lblJudulHalaman.Location = new Point(40, 18);
            lblJudulHalaman.Name = "lblJudulHalaman";
            lblJudulHalaman.Size = new Size(116, 38);
            lblJudulHalaman.TabIndex = 0;
            lblJudulHalaman.Text = "Laporan";
            //
            // lblPengguna
            //
            lblPengguna.Dock = DockStyle.Right;
            lblPengguna.Location = new Point(567, 0);
            lblPengguna.Name = "lblPengguna";
            lblPengguna.Size = new Size(450, 78);
            lblPengguna.TabIndex = 1;
            lblPengguna.Text = "Masuk sebagai: Admin";
            lblPengguna.TextAlign = ContentAlignment.MiddleRight;
            //
            // formLaporan
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 720);
            Controls.Add(pnlUtama);
            Controls.Add(pnlSidebar);
            MinimumSize = new Size(1150, 680);
            Name = "formLaporan";
            Text = "Laporan - Agri-Rent";
            Load += formLaporan_Load;
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlUtama.ResumeLayout(false);
            pnlIsi.ResumeLayout(false);
            pnlHasil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLaporan).EndInit();
            pnlTotal.ResumeLayout(false);
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
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
        private Panel pnlUtama;
        private Panel pnlIsi;
        private Panel pnlHasil;
        private DataGridView dgvLaporan;
        private Panel pnlTotal;
        private Label lblTotalTeks;
        private Label lblTotal;
        private Label lblJudulLaporan;
        private Panel pnlJarak;
        private Panel pnlFilter;
        private Button btnTampilkan;
        private DateTimePicker dtpAkhir;
        private Label lblAkhir;
        private DateTimePicker dtpAwal;
        private Label lblAwal;
        private ComboBox cmbJenis;
        private Label lblJenis;
        private Panel pnlHeader;
        private Label lblJudulHalaman;
        private Label lblPengguna;
    }
}
