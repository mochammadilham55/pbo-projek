namespace projek_pbo.view
{
    partial class formKelolaPengembalian
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
            label2 = new Label();
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
            panel3 = new Panel();
            dgvSewa = new DataGridView();
            colPenyewa = new DataGridViewTextBoxColumn();
            colAlat = new DataGridViewTextBoxColumn();
            colMulai = new DataGridViewTextBoxColumn();
            colKembali = new DataGridViewTextBoxColumn();
            colKeterangan = new DataGridViewTextBoxColumn();
            flpCari = new FlowLayoutPanel();
            lblCari = new Label();
            txtCari = new TextBox();
            btnCari = new Button();
            pnlJarak = new Panel();
            panel4 = new Panel();
            tblDetail = new TableLayoutPanel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dtpKembali = new DateTimePicker();
            txtTerlambat = new TextBox();
            txtDenda = new TextBox();
            txtTotalDenda = new TextBox();
            label9 = new Label();
            label10 = new Label();
            chkAdaKerusakan = new CheckBox();
            txtDendaKerusakan = new TextBox();
            txtKeterangan = new TextBox();
            btnProses = new Button();
            panel2 = new Panel();
            lblPengguna = new Label();
            pnlSidebar.SuspendLayout();
            pnlUtama.SuspendLayout();
            pnlIsi.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSewa).BeginInit();
            flpCari.SuspendLayout();
            panel4.SuspendLayout();
            tblDetail.SuspendLayout();
            panel2.SuspendLayout();
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
            btnPengembaian.BackColor = Color.FromArgb(62, 122, 60);
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
            btnPengembaian.UseVisualStyleBackColor = false;
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
            // label2
            //
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(47, 93, 58);
            label2.Location = new Point(40, 18);
            label2.Name = "label2";
            label2.Size = new Size(430, 38);
            label2.TabIndex = 0;
            label2.Text = "Kelola Pengembalian dan Denda";
            //
            // pnlUtama
            //
            pnlUtama.Controls.Add(pnlIsi);
            pnlUtama.Controls.Add(panel2);
            pnlUtama.Dock = DockStyle.Fill;
            pnlUtama.Location = new Point(250, 0);
            pnlUtama.Name = "pnlUtama";
            pnlUtama.Size = new Size(1062, 720);
            pnlUtama.TabIndex = 11;
            //
            // pnlIsi
            //
            pnlIsi.BackColor = Color.FromArgb(247, 245, 238);
            pnlIsi.Controls.Add(panel3);
            pnlIsi.Controls.Add(pnlJarak);
            pnlIsi.Controls.Add(panel4);
            pnlIsi.Dock = DockStyle.Fill;
            pnlIsi.Location = new Point(0, 78);
            pnlIsi.Name = "pnlIsi";
            pnlIsi.Padding = new Padding(45, 20, 45, 30);
            pnlIsi.Size = new Size(1062, 642);
            pnlIsi.TabIndex = 1;
            //
            // panel3
            //
            panel3.BackColor = Color.White;
            panel3.Controls.Add(dgvSewa);
            panel3.Controls.Add(flpCari);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(45, 20);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(30, 10, 30, 18);
            panel3.Size = new Size(972, 334);
            panel3.TabIndex = 0;
            //
            // dgvSewa
            //
            dgvSewa.AllowUserToAddRows = false;
            dgvSewa.AllowUserToDeleteRows = false;
            dgvSewa.AllowUserToResizeColumns = false;
            dgvSewa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSewa.BackgroundColor = Color.White;
            dgvSewa.BorderStyle = BorderStyle.None;
            dgvSewa.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSewa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSewa.Columns.AddRange(new DataGridViewColumn[] { colPenyewa, colAlat, colMulai, colKembali, colKeterangan });
            dgvSewa.Dock = DockStyle.Fill;
            dgvSewa.EnableHeadersVisualStyles = false;
            dgvSewa.GridColor = Color.FromArgb(236, 232, 218);
            dgvSewa.Location = new Point(30, 56);
            dgvSewa.MultiSelect = false;
            dgvSewa.Name = "dgvSewa";
            dgvSewa.ReadOnly = true;
            dgvSewa.RowHeadersVisible = false;
            dgvSewa.RowHeadersWidth = 51;
            dgvSewa.RowTemplate.Height = 34;
            dgvSewa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSewa.Size = new Size(912, 260);
            dgvSewa.TabIndex = 12;
            dgvSewa.CellClick += dgvSewa_CellClick;
            //
            // colPenyewa
            //
            colPenyewa.HeaderText = "Penyewa";
            colPenyewa.MinimumWidth = 6;
            colPenyewa.Name = "colPenyewa";
            colPenyewa.ReadOnly = true;
            //
            // colAlat
            //
            colAlat.HeaderText = "Alat";
            colAlat.MinimumWidth = 6;
            colAlat.Name = "colAlat";
            colAlat.ReadOnly = true;
            //
            // colMulai
            //
            colMulai.HeaderText = "Mulai";
            colMulai.MinimumWidth = 6;
            colMulai.Name = "colMulai";
            colMulai.ReadOnly = true;
            //
            // colKembali
            //
            colKembali.HeaderText = "Rencana Kembali";
            colKembali.MinimumWidth = 6;
            colKembali.Name = "colKembali";
            colKembali.ReadOnly = true;
            //
            // colKeterangan
            //
            colKeterangan.HeaderText = "Keterangan";
            colKeterangan.MinimumWidth = 6;
            colKeterangan.Name = "colKeterangan";
            colKeterangan.ReadOnly = true;
            //
            // flpCari
            //
            flpCari.Controls.Add(lblCari);
            flpCari.Controls.Add(txtCari);
            flpCari.Controls.Add(btnCari);
            flpCari.Dock = DockStyle.Top;
            flpCari.Location = new Point(30, 10);
            flpCari.Name = "flpCari";
            flpCari.Size = new Size(912, 46);
            flpCari.TabIndex = 2;
            flpCari.WrapContents = false;
            //
            // lblCari
            //
            lblCari.AutoSize = true;
            lblCari.Location = new Point(0, 9);
            lblCari.Margin = new Padding(0, 9, 10, 0);
            lblCari.Name = "lblCari";
            lblCari.Size = new Size(142, 20);
            lblCari.TabIndex = 3;
            lblCari.Text = "Cari nama penyewa:";
            //
            // txtCari
            //
            txtCari.Location = new Point(152, 5);
            txtCari.Margin = new Padding(0, 5, 14, 0);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(260, 27);
            txtCari.TabIndex = 13;
            //
            // btnCari
            //
            btnCari.BackColor = Color.FromArgb(62, 122, 60);
            btnCari.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            btnCari.ForeColor = Color.White;
            btnCari.Location = new Point(426, 4);
            btnCari.Margin = new Padding(0, 4, 0, 0);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(80, 30);
            btnCari.TabIndex = 28;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = false;
            btnCari.Click += btnCari_Click;
            //
            // pnlJarak
            //
            pnlJarak.Dock = DockStyle.Bottom;
            pnlJarak.Location = new Point(45, 354);
            pnlJarak.Name = "pnlJarak";
            pnlJarak.Size = new Size(972, 20);
            pnlJarak.TabIndex = 2;
            //
            // panel4
            //
            panel4.BackColor = Color.White;
            panel4.Controls.Add(tblDetail);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(45, 374);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(30, 6, 30, 12);
            panel4.Size = new Size(972, 238);
            panel4.TabIndex = 1;
            //
            // tblDetail
            //
            tblDetail.ColumnCount = 4;
            tblDetail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblDetail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblDetail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblDetail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblDetail.Controls.Add(label4, 0, 0);
            tblDetail.Controls.Add(label5, 0, 1);
            tblDetail.Controls.Add(label6, 1, 1);
            tblDetail.Controls.Add(label7, 2, 1);
            tblDetail.Controls.Add(label8, 3, 1);
            tblDetail.Controls.Add(dtpKembali, 0, 2);
            tblDetail.Controls.Add(txtTerlambat, 1, 2);
            tblDetail.Controls.Add(txtDenda, 2, 2);
            tblDetail.Controls.Add(txtTotalDenda, 3, 2);
            tblDetail.Controls.Add(label9, 1, 3);
            tblDetail.Controls.Add(label10, 2, 3);
            tblDetail.Controls.Add(chkAdaKerusakan, 0, 4);
            tblDetail.Controls.Add(txtDendaKerusakan, 1, 4);
            tblDetail.Controls.Add(txtKeterangan, 2, 4);
            tblDetail.Controls.Add(btnProses, 3, 5);
            tblDetail.Dock = DockStyle.Top;
            tblDetail.Location = new Point(30, 6);
            tblDetail.Name = "tblDetail";
            tblDetail.RowCount = 6;
            tblDetail.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tblDetail.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tblDetail.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tblDetail.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tblDetail.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tblDetail.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tblDetail.Size = new Size(912, 206);
            tblDetail.TabIndex = 0;
            //
            // label4
            //
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(47, 93, 58);
            tblDetail.SetColumnSpan(label4, 4);
            label4.Location = new Point(0, 12);
            label4.Margin = new Padding(0, 0, 0, 2);
            label4.Name = "label4";
            label4.Size = new Size(147, 20);
            label4.TabIndex = 14;
            label4.Text = "Detail Pengembalian";
            //
            // label5
            //
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(0, 36);
            label5.Margin = new Padding(0, 0, 0, 2);
            label5.Name = "label5";
            label5.Size = new Size(120, 20);
            label5.TabIndex = 15;
            label5.Text = "Tanggal Kembali";
            //
            // label6
            //
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(228, 36);
            label6.Margin = new Padding(0, 0, 0, 2);
            label6.Name = "label6";
            label6.Size = new Size(106, 20);
            label6.TabIndex = 16;
            label6.Text = "Hari terlambat";
            //
            // label7
            //
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(456, 36);
            label7.Margin = new Padding(0, 0, 0, 2);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 17;
            label7.Text = "Denda";
            //
            // label8
            //
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(684, 36);
            label8.Margin = new Padding(0, 0, 0, 2);
            label8.Name = "label8";
            label8.Size = new Size(88, 20);
            label8.TabIndex = 18;
            label8.Text = "Total denda";
            //
            // dtpKembali
            //
            dtpKembali.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpKembali.Format = DateTimePickerFormat.Short;
            dtpKembali.Location = new Point(0, 61);
            dtpKembali.Margin = new Padding(0, 0, 24, 0);
            dtpKembali.Name = "dtpKembali";
            dtpKembali.Size = new Size(204, 27);
            dtpKembali.TabIndex = 19;
            dtpKembali.ValueChanged += dtpKembali_ValueChanged;
            //
            // txtTerlambat
            //
            txtTerlambat.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTerlambat.ReadOnly = true;
            txtTerlambat.Location = new Point(228, 61);
            txtTerlambat.Margin = new Padding(0, 0, 24, 0);
            txtTerlambat.Name = "txtTerlambat";
            txtTerlambat.Size = new Size(204, 27);
            txtTerlambat.TabIndex = 20;
            //
            // txtDenda
            //
            txtDenda.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDenda.ReadOnly = true;
            txtDenda.Location = new Point(456, 61);
            txtDenda.Margin = new Padding(0, 0, 24, 0);
            txtDenda.Name = "txtDenda";
            txtDenda.Size = new Size(204, 27);
            txtDenda.TabIndex = 21;
            //
            // txtTotalDenda
            //
            txtTotalDenda.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTotalDenda.ReadOnly = true;
            txtTotalDenda.Location = new Point(684, 61);
            txtTotalDenda.Margin = new Padding(0, 0, 24, 0);
            txtTotalDenda.Name = "txtTotalDenda";
            txtTotalDenda.Size = new Size(204, 27);
            txtTotalDenda.TabIndex = 22;
            //
            // label9
            //
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(228, 94);
            label9.Margin = new Padding(0, 0, 0, 2);
            label9.Name = "label9";
            label9.Size = new Size(122, 20);
            label9.TabIndex = 24;
            label9.Text = "Denda kerusakan";
            //
            // label10
            //
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            tblDetail.SetColumnSpan(label10, 2);
            label10.Location = new Point(456, 94);
            label10.Margin = new Padding(0, 0, 0, 2);
            label10.Name = "label10";
            label10.Size = new Size(85, 20);
            label10.TabIndex = 26;
            label10.Text = "Keterangan";
            //
            // chkAdaKerusakan
            //
            chkAdaKerusakan.Anchor = AnchorStyles.Left;
            chkAdaKerusakan.AutoSize = true;
            chkAdaKerusakan.Location = new Point(0, 121);
            chkAdaKerusakan.Margin = new Padding(0);
            chkAdaKerusakan.Name = "chkAdaKerusakan";
            chkAdaKerusakan.Size = new Size(127, 24);
            chkAdaKerusakan.TabIndex = 23;
            chkAdaKerusakan.Text = "Ada kerusakan";
            chkAdaKerusakan.UseVisualStyleBackColor = true;
            chkAdaKerusakan.CheckedChanged += chkAdaKerusakan_CheckedChanged;
            //
            // txtDendaKerusakan
            //
            txtDendaKerusakan.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDendaKerusakan.Location = new Point(228, 119);
            txtDendaKerusakan.Margin = new Padding(0, 0, 24, 0);
            txtDendaKerusakan.Name = "txtDendaKerusakan";
            txtDendaKerusakan.Size = new Size(204, 27);
            txtDendaKerusakan.TabIndex = 25;
            txtDendaKerusakan.TextChanged += txtDendaKerusakan_TextChanged;
            //
            // txtKeterangan
            //
            txtKeterangan.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tblDetail.SetColumnSpan(txtKeterangan, 2);
            txtKeterangan.Location = new Point(456, 119);
            txtKeterangan.Margin = new Padding(0, 0, 24, 0);
            txtKeterangan.Name = "txtKeterangan";
            txtKeterangan.Size = new Size(432, 27);
            txtKeterangan.TabIndex = 27;
            //
            // btnProses
            //
            btnProses.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnProses.BackColor = Color.FromArgb(62, 122, 60);
            btnProses.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            btnProses.ForeColor = Color.White;
            btnProses.Location = new Point(684, 166);
            btnProses.Margin = new Padding(0, 0, 24, 2);
            btnProses.Name = "btnProses";
            btnProses.Size = new Size(204, 38);
            btnProses.TabIndex = 29;
            btnProses.Text = "Proses Pengembalian";
            btnProses.UseVisualStyleBackColor = false;
            btnProses.Click += btnProses_Click;
            //
            // panel2
            //
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lblPengguna);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 0, 45, 0);
            panel2.Size = new Size(1062, 78);
            panel2.TabIndex = 0;
            //
            // lblPengguna
            //
            lblPengguna.Dock = DockStyle.Right;
            lblPengguna.Location = new Point(567, 0);
            lblPengguna.Name = "lblPengguna";
            lblPengguna.Size = new Size(450, 78);
            lblPengguna.TabIndex = 1;
            lblPengguna.Text = "Masuk sebagai: Petugas";
            lblPengguna.TextAlign = ContentAlignment.MiddleRight;
            //
            // formKelolaPengembalian
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 720);
            Controls.Add(pnlUtama);
            Controls.Add(pnlSidebar);
            MinimumSize = new Size(1150, 680);
            Name = "formKelolaPengembalian";
            Text = "Kelola Pengembalian - Agri-Rent";
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlUtama.ResumeLayout(false);
            pnlIsi.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSewa).EndInit();
            flpCari.ResumeLayout(false);
            flpCari.PerformLayout();
            panel4.ResumeLayout(false);
            tblDetail.ResumeLayout(false);
            tblDetail.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
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
        private Panel panel2;
        private Label lblPengguna;
        private Panel panel4;
        private Panel panel3;
        private FlowLayoutPanel flpCari;
        private Panel pnlJarak;
        private TableLayoutPanel tblDetail;
        private DataGridView dgvSewa;
        private TextBox txtCari;
        private Label lblCari;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private DateTimePicker dtpKembali;
        private TextBox txtTerlambat;
        private Label label8;
        private Label label10;
        private TextBox txtKeterangan;
        private Label label9;
        private TextBox txtDendaKerusakan;
        private CheckBox chkAdaKerusakan;
        private TextBox txtTotalDenda;
        private TextBox txtDenda;
        private Button btnProses;
        private Button btnCari;
        private DataGridViewTextBoxColumn colPenyewa;
        private DataGridViewTextBoxColumn colAlat;
        private DataGridViewTextBoxColumn colMulai;
        private DataGridViewTextBoxColumn colKembali;
        private DataGridViewTextBoxColumn colKeterangan;
    }
}