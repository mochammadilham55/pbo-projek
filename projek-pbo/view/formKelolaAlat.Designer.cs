namespace projek_pbo.view
{
    partial class formKelolaAlat
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
            pnlDaftar = new Panel();
            dgvAlat = new DataGridView();
            colKode = new DataGridViewTextBoxColumn();
            colNama = new DataGridViewTextBoxColumn();
            colJenis = new DataGridViewTextBoxColumn();
            colTahun = new DataGridViewTextBoxColumn();
            colSpesifikasi = new DataGridViewTextBoxColumn();
            colTarif = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            flpCari = new FlowLayoutPanel();
            txtCari = new TextBox();
            cmbFilterJenis = new ComboBox();
            btnCari = new Button();
            pnlJarak = new Panel();
            pnlForm = new Panel();
            flpTombol = new FlowLayoutPanel();
            btnTambah = new Button();
            btnUbah = new Button();
            btnHapus = new Button();
            btnBersihkan = new Button();
            pnlPompaAir = new TableLayoutPanel();
            lblSpesifikasiPompa = new Label();
            lblDebit = new Label();
            lblBerat = new Label();
            lblBahanBakar = new Label();
            lblDiameterPipa = new Label();
            txtDebit = new TextBox();
            txtBerat = new TextBox();
            cmbBahanBakar = new ComboBox();
            txtDiameterPipa = new TextBox();
            pnlTraktor = new TableLayoutPanel();
            lblSpesifikasiTraktor = new Label();
            lblTenaga = new Label();
            lblKapasitasTangki = new Label();
            lblJenisTraktor = new Label();
            txtTenaga = new TextBox();
            txtKapasitasTangki = new TextBox();
            cmbJenisTraktor = new ComboBox();
            tblForm = new TableLayoutPanel();
            lblKode = new Label();
            lblNama = new Label();
            lblMerek = new Label();
            lblJenis = new Label();
            txtKode = new TextBox();
            txtNama = new TextBox();
            txtMerek = new TextBox();
            cmbJenis = new ComboBox();
            lblTahun = new Label();
            lblKondisi = new Label();
            lblTarif = new Label();
            lblStatus = new Label();
            txtTahun = new TextBox();
            cmbKondisi = new ComboBox();
            txtTarif = new TextBox();
            txtStatus = new TextBox();
            lblDeskripsi = new Label();
            txtDeskripsi = new TextBox();
            pnlHeader = new Panel();
            lblJudul = new Label();
            lblPengguna = new Label();
            pnlSidebar.SuspendLayout();
            pnlUtama.SuspendLayout();
            pnlIsi.SuspendLayout();
            pnlDaftar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlat).BeginInit();
            flpCari.SuspendLayout();
            pnlForm.SuspendLayout();
            flpTombol.SuspendLayout();
            pnlPompaAir.SuspendLayout();
            pnlTraktor.SuspendLayout();
            tblForm.SuspendLayout();
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
            pnlSidebar.Size = new Size(250, 840);
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
            btnLogout.Location = new Point(12, 792);
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
            btnAlat.BackColor = Color.FromArgb(62, 122, 60);
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
            btnAlat.UseVisualStyleBackColor = false;
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
            pnlUtama.BackColor = Color.FromArgb(247, 245, 238);
            pnlUtama.Controls.Add(pnlIsi);
            pnlUtama.Controls.Add(pnlHeader);
            pnlUtama.Dock = DockStyle.Fill;
            pnlUtama.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlUtama.Location = new Point(250, 0);
            pnlUtama.Margin = new Padding(2);
            pnlUtama.Name = "pnlUtama";
            pnlUtama.Size = new Size(1062, 840);
            pnlUtama.TabIndex = 6;
            // 
            // pnlIsi
            // 
            pnlIsi.Controls.Add(pnlDaftar);
            pnlIsi.Controls.Add(pnlJarak);
            pnlIsi.Controls.Add(pnlForm);
            pnlIsi.Dock = DockStyle.Fill;
            pnlIsi.Location = new Point(0, 65);
            pnlIsi.Name = "pnlIsi";
            pnlIsi.Padding = new Padding(45, 20, 45, 30);
            pnlIsi.Size = new Size(1062, 775);
            pnlIsi.TabIndex = 4;
            // 
            // pnlDaftar
            // 
            pnlDaftar.BackColor = Color.White;
            pnlDaftar.Controls.Add(dgvAlat);
            pnlDaftar.Controls.Add(flpCari);
            pnlDaftar.Dock = DockStyle.Fill;
            pnlDaftar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlDaftar.Location = new Point(45, 378);
            pnlDaftar.Margin = new Padding(2);
            pnlDaftar.Name = "pnlDaftar";
            pnlDaftar.Padding = new Padding(37, 12, 37, 18);
            pnlDaftar.Size = new Size(972, 367);
            pnlDaftar.TabIndex = 31;
            // 
            // dgvAlat
            // 
            dgvAlat.AllowUserToAddRows = false;
            dgvAlat.AllowUserToDeleteRows = false;
            dgvAlat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlat.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(47, 93, 58);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(47, 93, 58);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAlat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAlat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlat.Columns.AddRange(new DataGridViewColumn[] { colKode, colNama, colJenis, colTahun, colSpesifikasi, colTarif, colStatus });
            dgvAlat.Dock = DockStyle.Fill;
            dgvAlat.EnableHeadersVisualStyles = false;
            dgvAlat.Location = new Point(37, 56);
            dgvAlat.Margin = new Padding(2);
            dgvAlat.MultiSelect = false;
            dgvAlat.Name = "dgvAlat";
            dgvAlat.ReadOnly = true;
            dgvAlat.RowHeadersVisible = false;
            dgvAlat.RowHeadersWidth = 62;
            dgvAlat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlat.Size = new Size(898, 293);
            dgvAlat.TabIndex = 36;
            dgvAlat.CellClick += dgvAlat_CellClick;
            // 
            // colKode
            // 
            colKode.FillWeight = 60F;
            colKode.HeaderText = "Kode";
            colKode.MinimumWidth = 8;
            colKode.Name = "colKode";
            colKode.ReadOnly = true;
            // 
            // colNama
            // 
            colNama.HeaderText = "Merek / Nama";
            colNama.MinimumWidth = 8;
            colNama.Name = "colNama";
            colNama.ReadOnly = true;
            // 
            // colJenis
            // 
            colJenis.FillWeight = 60F;
            colJenis.HeaderText = "Jenis";
            colJenis.MinimumWidth = 8;
            colJenis.Name = "colJenis";
            colJenis.ReadOnly = true;
            // 
            // colTahun
            // 
            colTahun.FillWeight = 45F;
            colTahun.HeaderText = "Tahun";
            colTahun.MinimumWidth = 8;
            colTahun.Name = "colTahun";
            colTahun.ReadOnly = true;
            // 
            // colSpesifikasi
            // 
            colSpesifikasi.FillWeight = 140F;
            colSpesifikasi.HeaderText = "Spesifikasi";
            colSpesifikasi.MinimumWidth = 8;
            colSpesifikasi.Name = "colSpesifikasi";
            colSpesifikasi.ReadOnly = true;
            // 
            // colTarif
            // 
            colTarif.FillWeight = 70F;
            colTarif.HeaderText = "Tarif / Hari";
            colTarif.MinimumWidth = 8;
            colTarif.Name = "colTarif";
            colTarif.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.FillWeight = 60F;
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 8;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // flpCari
            // 
            flpCari.Controls.Add(txtCari);
            flpCari.Controls.Add(cmbFilterJenis);
            flpCari.Controls.Add(btnCari);
            flpCari.Dock = DockStyle.Top;
            flpCari.Location = new Point(37, 12);
            flpCari.Name = "flpCari";
            flpCari.Size = new Size(898, 44);
            flpCari.TabIndex = 31;
            flpCari.WrapContents = false;
            // 
            // txtCari
            // 
            txtCari.Location = new Point(0, 3);
            txtCari.Margin = new Padding(0, 3, 14, 3);
            txtCari.Name = "txtCari";
            txtCari.PlaceholderText = "Cari kode, nama, atau merek";
            txtCari.Size = new Size(342, 27);
            txtCari.TabIndex = 32;
            // 
            // cmbFilterJenis
            // 
            cmbFilterJenis.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterJenis.FormattingEnabled = true;
            cmbFilterJenis.Items.AddRange(new object[] { "Semua Jenis", "Traktor", "Pompa Air" });
            cmbFilterJenis.Location = new Point(356, 3);
            cmbFilterJenis.Margin = new Padding(0, 3, 14, 3);
            cmbFilterJenis.Name = "cmbFilterJenis";
            cmbFilterJenis.Size = new Size(130, 28);
            cmbFilterJenis.TabIndex = 33;
            // 
            // btnCari
            // 
            btnCari.BackColor = Color.FromArgb(47, 93, 58);
            btnCari.ForeColor = Color.White;
            btnCari.Location = new Point(500, 3);
            btnCari.Margin = new Padding(0, 3, 0, 3);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(80, 28);
            btnCari.TabIndex = 34;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = false;
            btnCari.Click += btnCari_Click;
            // 
            // pnlJarak
            // 
            pnlJarak.Dock = DockStyle.Top;
            pnlJarak.Location = new Point(45, 358);
            pnlJarak.Name = "pnlJarak";
            pnlJarak.Size = new Size(972, 20);
            pnlJarak.TabIndex = 3;
            // 
            // pnlForm
            // 
            pnlForm.BackColor = Color.White;
            pnlForm.Controls.Add(flpTombol);
            pnlForm.Controls.Add(pnlPompaAir);
            pnlForm.Controls.Add(pnlTraktor);
            pnlForm.Controls.Add(tblForm);
            pnlForm.Dock = DockStyle.Top;
            pnlForm.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlForm.Location = new Point(45, 20);
            pnlForm.Margin = new Padding(2);
            pnlForm.Name = "pnlForm";
            pnlForm.Padding = new Padding(37, 10, 37, 10);
            pnlForm.Size = new Size(972, 338);
            pnlForm.TabIndex = 2;
            // 
            // flpTombol
            // 
            flpTombol.Controls.Add(btnTambah);
            flpTombol.Controls.Add(btnUbah);
            flpTombol.Controls.Add(btnHapus);
            flpTombol.Controls.Add(btnBersihkan);
            flpTombol.Dock = DockStyle.Top;
            flpTombol.Location = new Point(37, 370);
            flpTombol.Name = "flpTombol";
            flpTombol.Padding = new Padding(0, 8, 0, 0);
            flpTombol.Size = new Size(898, 46);
            flpTombol.TabIndex = 26;
            flpTombol.WrapContents = false;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.FromArgb(62, 122, 60);
            btnTambah.ForeColor = Color.White;
            btnTambah.Location = new Point(2, 8);
            btnTambah.Margin = new Padding(2, 0, 20, 0);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(100, 30);
            btnTambah.TabIndex = 27;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnUbah
            // 
            btnUbah.BackColor = Color.FromArgb(224, 165, 38);
            btnUbah.Location = new Point(124, 8);
            btnUbah.Margin = new Padding(2, 0, 20, 0);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(100, 30);
            btnUbah.TabIndex = 28;
            btnUbah.Text = "Ubah";
            btnUbah.UseVisualStyleBackColor = false;
            btnUbah.Click += btnUbah_Click;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.FromArgb(179, 65, 47);
            btnHapus.ForeColor = Color.White;
            btnHapus.Location = new Point(246, 8);
            btnHapus.Margin = new Padding(2, 0, 20, 0);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(100, 30);
            btnHapus.TabIndex = 29;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnBersihkan
            // 
            btnBersihkan.FlatStyle = FlatStyle.Flat;
            btnBersihkan.ForeColor = Color.FromArgb(47, 93, 58);
            btnBersihkan.Location = new Point(368, 8);
            btnBersihkan.Margin = new Padding(2, 0, 20, 0);
            btnBersihkan.Name = "btnBersihkan";
            btnBersihkan.Size = new Size(100, 30);
            btnBersihkan.TabIndex = 30;
            btnBersihkan.Text = "Bersihkan";
            btnBersihkan.UseVisualStyleBackColor = true;
            btnBersihkan.Click += btnBersihkan_Click;
            // 
            // pnlPompaAir
            // 
            pnlPompaAir.ColumnCount = 4;
            pnlPompaAir.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlPompaAir.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlPompaAir.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlPompaAir.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlPompaAir.Controls.Add(lblSpesifikasiPompa, 0, 0);
            pnlPompaAir.Controls.Add(lblDebit, 0, 1);
            pnlPompaAir.Controls.Add(lblBerat, 1, 1);
            pnlPompaAir.Controls.Add(lblBahanBakar, 2, 1);
            pnlPompaAir.Controls.Add(lblDiameterPipa, 3, 1);
            pnlPompaAir.Controls.Add(txtDebit, 0, 2);
            pnlPompaAir.Controls.Add(txtBerat, 1, 2);
            pnlPompaAir.Controls.Add(cmbBahanBakar, 2, 2);
            pnlPompaAir.Controls.Add(txtDiameterPipa, 3, 2);
            pnlPompaAir.Dock = DockStyle.Top;
            pnlPompaAir.Location = new Point(37, 278);
            pnlPompaAir.Name = "pnlPompaAir";
            pnlPompaAir.RowCount = 3;
            pnlPompaAir.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            pnlPompaAir.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            pnlPompaAir.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            pnlPompaAir.Size = new Size(898, 92);
            pnlPompaAir.TabIndex = 21;
            pnlPompaAir.Visible = false;
            // 
            // lblSpesifikasiPompa
            // 
            lblSpesifikasiPompa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblSpesifikasiPompa.AutoSize = true;
            pnlPompaAir.SetColumnSpan(lblSpesifikasiPompa, 4);
            lblSpesifikasiPompa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSpesifikasiPompa.ForeColor = Color.FromArgb(47, 93, 58);
            lblSpesifikasiPompa.Location = new Point(0, 12);
            lblSpesifikasiPompa.Margin = new Padding(0, 0, 0, 2);
            lblSpesifikasiPompa.Name = "lblSpesifikasiPompa";
            lblSpesifikasiPompa.Size = new Size(160, 20);
            lblSpesifikasiPompa.TabIndex = 0;
            lblSpesifikasiPompa.Text = "Spesifikasi Pompa Air";
            // 
            // lblDebit
            // 
            lblDebit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDebit.AutoSize = true;
            lblDebit.Location = new Point(0, 36);
            lblDebit.Margin = new Padding(0, 0, 0, 2);
            lblDebit.Name = "lblDebit";
            lblDebit.Size = new Size(133, 20);
            lblDebit.TabIndex = 1;
            lblDebit.Text = "Debit (Liter/Menit)";
            // 
            // lblBerat
            // 
            lblBerat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblBerat.AutoSize = true;
            lblBerat.Location = new Point(224, 36);
            lblBerat.Margin = new Padding(0, 0, 0, 2);
            lblBerat.Name = "lblBerat";
            lblBerat.Size = new Size(76, 20);
            lblBerat.TabIndex = 3;
            lblBerat.Text = "Berat (Kg)";
            // 
            // lblBahanBakar
            // 
            lblBahanBakar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblBahanBakar.AutoSize = true;
            lblBahanBakar.Location = new Point(448, 36);
            lblBahanBakar.Margin = new Padding(0, 0, 0, 2);
            lblBahanBakar.Name = "lblBahanBakar";
            lblBahanBakar.Size = new Size(91, 20);
            lblBahanBakar.TabIndex = 5;
            lblBahanBakar.Text = "Bahan Bakar";
            // 
            // lblDiameterPipa
            // 
            lblDiameterPipa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDiameterPipa.AutoSize = true;
            lblDiameterPipa.Location = new Point(672, 36);
            lblDiameterPipa.Margin = new Padding(0, 0, 0, 2);
            lblDiameterPipa.Name = "lblDiameterPipa";
            lblDiameterPipa.Size = new Size(141, 20);
            lblDiameterPipa.TabIndex = 7;
            lblDiameterPipa.Text = "Diameter Pipa (Inci)";
            // 
            // txtDebit
            // 
            txtDebit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDebit.Location = new Point(0, 61);
            txtDebit.Margin = new Padding(0, 0, 24, 0);
            txtDebit.Name = "txtDebit";
            txtDebit.PlaceholderText = "1100";
            txtDebit.Size = new Size(200, 27);
            txtDebit.TabIndex = 1;
            // 
            // txtBerat
            // 
            txtBerat.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBerat.Location = new Point(224, 61);
            txtBerat.Margin = new Padding(0, 0, 24, 0);
            txtBerat.Name = "txtBerat";
            txtBerat.PlaceholderText = "27";
            txtBerat.Size = new Size(200, 27);
            txtBerat.TabIndex = 2;
            // 
            // cmbBahanBakar
            // 
            cmbBahanBakar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbBahanBakar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBahanBakar.FormattingEnabled = true;
            cmbBahanBakar.Items.AddRange(new object[] { "Bensin", "Solar", "Listrik" });
            cmbBahanBakar.Location = new Point(448, 61);
            cmbBahanBakar.Margin = new Padding(0, 0, 24, 0);
            cmbBahanBakar.Name = "cmbBahanBakar";
            cmbBahanBakar.Size = new Size(200, 28);
            cmbBahanBakar.TabIndex = 3;
            // 
            // txtDiameterPipa
            // 
            txtDiameterPipa.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDiameterPipa.Location = new Point(672, 61);
            txtDiameterPipa.Margin = new Padding(0, 0, 24, 0);
            txtDiameterPipa.Name = "txtDiameterPipa";
            txtDiameterPipa.PlaceholderText = "3";
            txtDiameterPipa.Size = new Size(202, 27);
            txtDiameterPipa.TabIndex = 4;
            // 
            // pnlTraktor
            // 
            pnlTraktor.ColumnCount = 4;
            pnlTraktor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlTraktor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlTraktor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlTraktor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlTraktor.Controls.Add(lblSpesifikasiTraktor, 0, 0);
            pnlTraktor.Controls.Add(lblTenaga, 0, 1);
            pnlTraktor.Controls.Add(lblKapasitasTangki, 1, 1);
            pnlTraktor.Controls.Add(lblJenisTraktor, 2, 1);
            pnlTraktor.Controls.Add(txtTenaga, 0, 2);
            pnlTraktor.Controls.Add(txtKapasitasTangki, 1, 2);
            pnlTraktor.Controls.Add(cmbJenisTraktor, 2, 2);
            pnlTraktor.Dock = DockStyle.Top;
            pnlTraktor.Location = new Point(37, 186);
            pnlTraktor.Name = "pnlTraktor";
            pnlTraktor.RowCount = 3;
            pnlTraktor.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            pnlTraktor.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            pnlTraktor.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            pnlTraktor.Size = new Size(898, 92);
            pnlTraktor.TabIndex = 20;
            // 
            // lblSpesifikasiTraktor
            // 
            lblSpesifikasiTraktor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblSpesifikasiTraktor.AutoSize = true;
            pnlTraktor.SetColumnSpan(lblSpesifikasiTraktor, 4);
            lblSpesifikasiTraktor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSpesifikasiTraktor.ForeColor = Color.FromArgb(47, 93, 58);
            lblSpesifikasiTraktor.Location = new Point(0, 12);
            lblSpesifikasiTraktor.Margin = new Padding(0, 0, 0, 2);
            lblSpesifikasiTraktor.Name = "lblSpesifikasiTraktor";
            lblSpesifikasiTraktor.Size = new Size(137, 20);
            lblSpesifikasiTraktor.TabIndex = 0;
            lblSpesifikasiTraktor.Text = "Spesifikasi Traktor";
            // 
            // lblTenaga
            // 
            lblTenaga.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTenaga.AutoSize = true;
            lblTenaga.Location = new Point(0, 36);
            lblTenaga.Margin = new Padding(0, 0, 0, 2);
            lblTenaga.Name = "lblTenaga";
            lblTenaga.Size = new Size(90, 20);
            lblTenaga.TabIndex = 1;
            lblTenaga.Text = "Tenaga (HP)";
            // 
            // lblKapasitasTangki
            // 
            lblKapasitasTangki.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblKapasitasTangki.AutoSize = true;
            lblKapasitasTangki.Location = new Point(224, 36);
            lblKapasitasTangki.Margin = new Padding(0, 0, 0, 2);
            lblKapasitasTangki.Name = "lblKapasitasTangki";
            lblKapasitasTangki.Size = new Size(161, 20);
            lblKapasitasTangki.TabIndex = 3;
            lblKapasitasTangki.Text = "Kapasitas Tangki (Liter)";
            // 
            // lblJenisTraktor
            // 
            lblJenisTraktor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblJenisTraktor.AutoSize = true;
            lblJenisTraktor.Location = new Point(448, 36);
            lblJenisTraktor.Margin = new Padding(0, 0, 0, 2);
            lblJenisTraktor.Name = "lblJenisTraktor";
            lblJenisTraktor.Size = new Size(90, 20);
            lblJenisTraktor.TabIndex = 5;
            lblJenisTraktor.Text = "Jenis Traktor";
            // 
            // txtTenaga
            // 
            txtTenaga.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTenaga.Location = new Point(0, 61);
            txtTenaga.Margin = new Padding(0, 0, 24, 0);
            txtTenaga.Name = "txtTenaga";
            txtTenaga.PlaceholderText = "75";
            txtTenaga.Size = new Size(200, 27);
            txtTenaga.TabIndex = 1;
            // 
            // txtKapasitasTangki
            // 
            txtKapasitasTangki.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtKapasitasTangki.Location = new Point(224, 61);
            txtKapasitasTangki.Margin = new Padding(0, 0, 24, 0);
            txtKapasitasTangki.Name = "txtKapasitasTangki";
            txtKapasitasTangki.PlaceholderText = "60";
            txtKapasitasTangki.Size = new Size(200, 27);
            txtKapasitasTangki.TabIndex = 2;
            // 
            // cmbJenisTraktor
            // 
            cmbJenisTraktor.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbJenisTraktor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJenisTraktor.FormattingEnabled = true;
            cmbJenisTraktor.Items.AddRange(new object[] { "Roda 2", "Roda 4" });
            cmbJenisTraktor.Location = new Point(448, 61);
            cmbJenisTraktor.Margin = new Padding(0, 0, 24, 0);
            cmbJenisTraktor.Name = "cmbJenisTraktor";
            cmbJenisTraktor.Size = new Size(200, 28);
            cmbJenisTraktor.TabIndex = 3;
            // 
            // tblForm
            // 
            tblForm.ColumnCount = 4;
            tblForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblForm.Controls.Add(lblKode, 0, 0);
            tblForm.Controls.Add(lblNama, 1, 0);
            tblForm.Controls.Add(lblMerek, 2, 0);
            tblForm.Controls.Add(lblJenis, 3, 0);
            tblForm.Controls.Add(txtKode, 0, 1);
            tblForm.Controls.Add(txtNama, 1, 1);
            tblForm.Controls.Add(txtMerek, 2, 1);
            tblForm.Controls.Add(cmbJenis, 3, 1);
            tblForm.Controls.Add(lblTahun, 0, 2);
            tblForm.Controls.Add(lblKondisi, 1, 2);
            tblForm.Controls.Add(lblTarif, 2, 2);
            tblForm.Controls.Add(lblStatus, 3, 2);
            tblForm.Controls.Add(txtTahun, 0, 3);
            tblForm.Controls.Add(cmbKondisi, 1, 3);
            tblForm.Controls.Add(txtTarif, 2, 3);
            tblForm.Controls.Add(txtStatus, 3, 3);
            tblForm.Controls.Add(lblDeskripsi, 0, 4);
            tblForm.Controls.Add(txtDeskripsi, 0, 5);
            tblForm.Dock = DockStyle.Top;
            tblForm.Location = new Point(37, 10);
            tblForm.Name = "tblForm";
            tblForm.RowCount = 6;
            tblForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tblForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tblForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tblForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tblForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tblForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tblForm.Size = new Size(898, 176);
            tblForm.TabIndex = 0;
            // 
            // lblKode
            // 
            lblKode.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblKode.AutoSize = true;
            lblKode.Location = new Point(0, 2);
            lblKode.Margin = new Padding(0, 0, 0, 2);
            lblKode.Name = "lblKode";
            lblKode.Size = new Size(44, 20);
            lblKode.TabIndex = 0;
            lblKode.Text = "Kode";
            // 
            // lblNama
            // 
            lblNama.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblNama.AutoSize = true;
            lblNama.Location = new Point(224, 2);
            lblNama.Margin = new Padding(0, 0, 0, 2);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(80, 20);
            lblNama.TabIndex = 1;
            lblNama.Text = "Nama Alat";
            // 
            // lblMerek
            // 
            lblMerek.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblMerek.AutoSize = true;
            lblMerek.Location = new Point(448, 2);
            lblMerek.Margin = new Padding(0, 0, 0, 2);
            lblMerek.Name = "lblMerek";
            lblMerek.Size = new Size(50, 20);
            lblMerek.TabIndex = 2;
            lblMerek.Text = "Merek";
            // 
            // lblJenis
            // 
            lblJenis.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblJenis.AutoSize = true;
            lblJenis.Location = new Point(672, 2);
            lblJenis.Margin = new Padding(0, 0, 0, 2);
            lblJenis.Name = "lblJenis";
            lblJenis.Size = new Size(40, 20);
            lblJenis.TabIndex = 3;
            lblJenis.Text = "Jenis";
            // 
            // txtKode
            // 
            txtKode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtKode.CharacterCasing = CharacterCasing.Upper;
            txtKode.Location = new Point(0, 27);
            txtKode.Margin = new Padding(0, 0, 24, 0);
            txtKode.MaxLength = 10;
            txtKode.Name = "txtKode";
            txtKode.PlaceholderText = "TR-001";
            txtKode.Size = new Size(200, 27);
            txtKode.TabIndex = 1;
            // 
            // txtNama
            // 
            txtNama.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNama.Location = new Point(224, 27);
            txtNama.Margin = new Padding(0, 0, 24, 0);
            txtNama.Name = "txtNama";
            txtNama.PlaceholderText = "Traktor Roda 4";
            txtNama.Size = new Size(200, 27);
            txtNama.TabIndex = 2;
            // 
            // txtMerek
            // 
            txtMerek.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMerek.Location = new Point(448, 27);
            txtMerek.Margin = new Padding(0, 0, 24, 0);
            txtMerek.Name = "txtMerek";
            txtMerek.PlaceholderText = "Kubota";
            txtMerek.Size = new Size(200, 27);
            txtMerek.TabIndex = 3;
            // 
            // cmbJenis
            // 
            cmbJenis.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbJenis.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJenis.FormattingEnabled = true;
            cmbJenis.Items.AddRange(new object[] { "Traktor", "Pompa Air" });
            cmbJenis.Location = new Point(672, 27);
            cmbJenis.Margin = new Padding(0, 0, 24, 0);
            cmbJenis.Name = "cmbJenis";
            cmbJenis.Size = new Size(202, 28);
            cmbJenis.TabIndex = 4;
            cmbJenis.SelectedIndexChanged += cmbJenis_SelectedIndexChanged;
            // 
            // lblTahun
            // 
            lblTahun.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTahun.AutoSize = true;
            lblTahun.Location = new Point(0, 60);
            lblTahun.Margin = new Padding(0, 0, 0, 2);
            lblTahun.Name = "lblTahun";
            lblTahun.Size = new Size(109, 20);
            lblTahun.TabIndex = 4;
            lblTahun.Text = "Tahun Keluaran";
            // 
            // lblKondisi
            // 
            lblKondisi.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblKondisi.AutoSize = true;
            lblKondisi.Location = new Point(224, 60);
            lblKondisi.Margin = new Padding(0, 0, 0, 2);
            lblKondisi.Name = "lblKondisi";
            lblKondisi.Size = new Size(58, 20);
            lblKondisi.TabIndex = 5;
            lblKondisi.Text = "Kondisi";
            // 
            // lblTarif
            // 
            lblTarif.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTarif.AutoSize = true;
            lblTarif.Location = new Point(448, 60);
            lblTarif.Margin = new Padding(0, 0, 0, 2);
            lblTarif.Name = "lblTarif";
            lblTarif.Size = new Size(125, 20);
            lblTarif.TabIndex = 6;
            lblTarif.Text = "Tarif Per Hari (Rp)";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(672, 60);
            lblStatus.Margin = new Padding(0, 0, 0, 2);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(124, 20);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Status (Otomatis)";
            // 
            // txtTahun
            // 
            txtTahun.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTahun.Location = new Point(0, 85);
            txtTahun.Margin = new Padding(0, 0, 24, 0);
            txtTahun.MaxLength = 4;
            txtTahun.Name = "txtTahun";
            txtTahun.PlaceholderText = "2020";
            txtTahun.Size = new Size(200, 27);
            txtTahun.TabIndex = 5;
            // 
            // cmbKondisi
            // 
            cmbKondisi.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbKondisi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKondisi.FormattingEnabled = true;
            cmbKondisi.Items.AddRange(new object[] { "Baik", "Cukup", "Perlu servis" });
            cmbKondisi.Location = new Point(224, 85);
            cmbKondisi.Margin = new Padding(0, 0, 24, 0);
            cmbKondisi.Name = "cmbKondisi";
            cmbKondisi.Size = new Size(200, 28);
            cmbKondisi.TabIndex = 6;
            // 
            // txtTarif
            // 
            txtTarif.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTarif.Location = new Point(448, 85);
            txtTarif.Margin = new Padding(0, 0, 24, 0);
            txtTarif.Name = "txtTarif";
            txtTarif.PlaceholderText = "800.000";
            txtTarif.Size = new Size(200, 27);
            txtTarif.TabIndex = 7;
            // 
            // txtStatus
            // 
            txtStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtStatus.BackColor = Color.FromArgb(247, 245, 238);
            txtStatus.Location = new Point(672, 85);
            txtStatus.Margin = new Padding(0, 0, 24, 0);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(202, 27);
            txtStatus.TabIndex = 99;
            txtStatus.TabStop = false;
            // 
            // lblDeskripsi
            // 
            lblDeskripsi.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDeskripsi.AutoSize = true;
            lblDeskripsi.Location = new Point(0, 118);
            lblDeskripsi.Margin = new Padding(0, 0, 0, 2);
            lblDeskripsi.Name = "lblDeskripsi";
            lblDeskripsi.Size = new Size(69, 20);
            lblDeskripsi.TabIndex = 8;
            lblDeskripsi.Text = "Deskripsi";
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tblForm.SetColumnSpan(txtDeskripsi, 4);
            txtDeskripsi.Location = new Point(0, 144);
            txtDeskripsi.Margin = new Padding(0, 0, 24, 0);
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(874, 27);
            txtDeskripsi.TabIndex = 8;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblJudul);
            pnlHeader.Controls.Add(lblPengguna);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(0, 0, 45, 0);
            pnlHeader.Size = new Size(1062, 65);
            pnlHeader.TabIndex = 3;
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.BackColor = Color.Transparent;
            lblJudul.ForeColor = Color.FromArgb(47, 93, 58);
            lblJudul.Location = new Point(40, 12);
            lblJudul.Margin = new Padding(2, 0, 2, 0);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(289, 37);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Kelola Alat Pertanian";
            // 
            // lblPengguna
            // 
            lblPengguna.BackColor = Color.White;
            lblPengguna.Dock = DockStyle.Right;
            lblPengguna.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPengguna.Location = new Point(567, 0);
            lblPengguna.Margin = new Padding(2, 0, 2, 0);
            lblPengguna.Name = "lblPengguna";
            lblPengguna.Size = new Size(450, 65);
            lblPengguna.TabIndex = 1;
            lblPengguna.Text = "Masuk sebagai: Admin";
            lblPengguna.TextAlign = ContentAlignment.MiddleRight;
            // 
            // formKelolaAlat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 840);
            Controls.Add(pnlUtama);
            Controls.Add(pnlSidebar);
            MinimumSize = new Size(1150, 680);
            Name = "formKelolaAlat";
            Text = "Kelola Alat - Agri-Rent";
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlUtama.ResumeLayout(false);
            pnlIsi.ResumeLayout(false);
            pnlDaftar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAlat).EndInit();
            flpCari.ResumeLayout(false);
            flpCari.PerformLayout();
            pnlForm.ResumeLayout(false);
            flpTombol.ResumeLayout(false);
            pnlPompaAir.ResumeLayout(false);
            pnlPompaAir.PerformLayout();
            pnlTraktor.ResumeLayout(false);
            pnlTraktor.PerformLayout();
            tblForm.ResumeLayout(false);
            tblForm.PerformLayout();
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
        private Panel pnlHeader;
        private Label lblJudul;
        private Label lblPengguna;
        private Panel pnlIsi;
        private Panel pnlJarak;
        private Panel pnlForm;
        private TableLayoutPanel tblForm;
        private Label lblKode;
        private Label lblNama;
        private Label lblMerek;
        private Label lblJenis;
        private Label lblTahun;
        private Label lblKondisi;
        private Label lblTarif;
        private Label lblStatus;
        private Label lblDeskripsi;
        private TextBox txtKode;
        private TextBox txtNama;
        private TextBox txtMerek;
        private ComboBox cmbJenis;
        private TextBox txtTahun;
        private ComboBox cmbKondisi;
        private TextBox txtTarif;
        private TextBox txtStatus;
        private TextBox txtDeskripsi;
        private TableLayoutPanel pnlTraktor;
        private Label lblSpesifikasiTraktor;
        private Label lblTenaga;
        private TextBox txtTenaga;
        private Label lblKapasitasTangki;
        private TextBox txtKapasitasTangki;
        private Label lblJenisTraktor;
        private ComboBox cmbJenisTraktor;
        private TableLayoutPanel pnlPompaAir;
        private Label lblSpesifikasiPompa;
        private Label lblDebit;
        private TextBox txtDebit;
        private Label lblBerat;
        private TextBox txtBerat;
        private Label lblBahanBakar;
        private ComboBox cmbBahanBakar;
        private Label lblDiameterPipa;
        private TextBox txtDiameterPipa;
        private FlowLayoutPanel flpTombol;
        private Button btnTambah;
        private Button btnUbah;
        private Button btnHapus;
        private Button btnBersihkan;
        private Panel pnlDaftar;
        private FlowLayoutPanel flpCari;
        private TextBox txtCari;
        private ComboBox cmbFilterJenis;
        private Button btnCari;
        private DataGridView dgvAlat;
        private DataGridViewTextBoxColumn colKode;
        private DataGridViewTextBoxColumn colNama;
        private DataGridViewTextBoxColumn colJenis;
        private DataGridViewTextBoxColumn colTahun;
        private DataGridViewTextBoxColumn colSpesifikasi;
        private DataGridViewTextBoxColumn colTarif;
        private DataGridViewTextBoxColumn colStatus;
    }
}
