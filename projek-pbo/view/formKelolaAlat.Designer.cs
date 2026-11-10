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
            pnlDaftar = new Panel();
            dgvAlat = new DataGridView();
            colKode = new DataGridViewTextBoxColumn();
            colNama = new DataGridViewTextBoxColumn();
            colJenis = new DataGridViewTextBoxColumn();
            colTahun = new DataGridViewTextBoxColumn();
            colSpesifikasi = new DataGridViewTextBoxColumn();
            colTarif = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            cmbFilterJenis = new ComboBox();
            btnCari = new Button();
            txtCari = new TextBox();
            pnlForm = new Panel();
            pnlPompaAir = new Panel();
            txtDiameterPipa = new TextBox();
            lblDiameterPipa = new Label();
            cmbBahanBakar = new ComboBox();
            lblBahanBakar = new Label();
            txtBerat = new TextBox();
            lblBerat = new Label();
            txtDebit = new TextBox();
            lblDebit = new Label();
            lblSpesifikasiPompa = new Label();
            pnlTraktor = new Panel();
            cmbJenisTraktor = new ComboBox();
            lblJenisTraktor = new Label();
            txtKapasitasTangki = new TextBox();
            lblKapasitasTangki = new Label();
            txtTenaga = new TextBox();
            lblTenaga = new Label();
            lblSpesifikasiTraktor = new Label();
            btnBersihkan = new Button();
            btnHapus = new Button();
            btnUbah = new Button();
            btnTambah = new Button();
            cmbJenis = new ComboBox();
            cmbKondisi = new ComboBox();
            txtKode = new TextBox();
            txtNama = new TextBox();
            txtMerek = new TextBox();
            txtTahun = new TextBox();
            txtStatus = new TextBox();
            txtDeskripsi = new TextBox();
            txtTarif = new TextBox();
            lblDeskripsi = new Label();
            lblStatus = new Label();
            lblTarif = new Label();
            lblKondisi = new Label();
            lblTahun = new Label();
            lblJenis = new Label();
            lblMerek = new Label();
            lblNama = new Label();
            lblKode = new Label();
            pnlHeader = new Panel();
            lblJudul = new Label();
            lblPengguna = new Label();
            pnlSidebar.SuspendLayout();
            pnlUtama.SuspendLayout();
            pnlDaftar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlat).BeginInit();
            pnlForm.SuspendLayout();
            pnlPompaAir.SuspendLayout();
            pnlTraktor.SuspendLayout();
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
            pnlSidebar.TabIndex = 5;
            //
            // btnLogout
            //
            btnLogout.BackColor = Color.FromArgb(179, 65, 47);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 122, 60);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(11, 786);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(15, 0, 0, 0);
            btnLogout.Size = new Size(221, 29);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            //
            // btnUser
            //
            btnUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 122, 60);
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.ForeColor = Color.White;
            btnUser.Location = new Point(10, 352);
            btnUser.Name = "btnUser";
            btnUser.Padding = new Padding(15, 0, 0, 0);
            btnUser.Size = new Size(222, 29);
            btnUser.TabIndex = 6;
            btnUser.Text = "Kelola user";
            btnUser.TextAlign = ContentAlignment.MiddleLeft;
            btnUser.UseVisualStyleBackColor = true;
            //
            // btnLaporan
            //
            btnLaporan.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 122, 60);
            btnLaporan.FlatStyle = FlatStyle.Flat;
            btnLaporan.ForeColor = Color.White;
            btnLaporan.Location = new Point(10, 300);
            btnLaporan.Name = "btnLaporan";
            btnLaporan.Padding = new Padding(15, 0, 0, 0);
            btnLaporan.Size = new Size(222, 29);
            btnLaporan.TabIndex = 5;
            btnLaporan.Text = "Laporan";
            btnLaporan.TextAlign = ContentAlignment.MiddleLeft;
            btnLaporan.UseVisualStyleBackColor = true;
            //
            // btnPengembaian
            //
            btnPengembaian.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 122, 60);
            btnPengembaian.FlatStyle = FlatStyle.Flat;
            btnPengembaian.ForeColor = Color.White;
            btnPengembaian.Location = new Point(11, 246);
            btnPengembaian.Name = "btnPengembaian";
            btnPengembaian.Padding = new Padding(15, 0, 0, 0);
            btnPengembaian.Size = new Size(222, 29);
            btnPengembaian.TabIndex = 4;
            btnPengembaian.Text = "Kelola Pengembalian";
            btnPengembaian.TextAlign = ContentAlignment.MiddleLeft;
            btnPengembaian.UseVisualStyleBackColor = true;
            //
            // btnSewa
            //
            btnSewa.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 122, 60);
            btnSewa.FlatStyle = FlatStyle.Flat;
            btnSewa.ForeColor = Color.White;
            btnSewa.Location = new Point(11, 196);
            btnSewa.Name = "btnSewa";
            btnSewa.Padding = new Padding(15, 0, 0, 0);
            btnSewa.Size = new Size(222, 29);
            btnSewa.TabIndex = 3;
            btnSewa.Text = "Kelola Sewa";
            btnSewa.TextAlign = ContentAlignment.MiddleLeft;
            btnSewa.UseVisualStyleBackColor = true;
            //
            // btnAlat
            //
            btnAlat.BackColor = Color.FromArgb(62, 122, 60);
            btnAlat.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 122, 60);
            btnAlat.FlatStyle = FlatStyle.Flat;
            btnAlat.ForeColor = Color.White;
            btnAlat.Location = new Point(11, 143);
            btnAlat.Name = "btnAlat";
            btnAlat.Padding = new Padding(15, 0, 0, 0);
            btnAlat.Size = new Size(222, 29);
            btnAlat.TabIndex = 2;
            btnAlat.Text = "Kelola alat";
            btnAlat.TextAlign = ContentAlignment.MiddleLeft;
            btnAlat.UseVisualStyleBackColor = false;
            //
            // btnDashboard
            //
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 122, 60);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(11, 96);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(15, 0, 0, 0);
            btnDashboard.Size = new Size(222, 29);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = true;
            //
            // lblLogo
            //
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = SystemColors.ControlLightLight;
            lblLogo.Location = new Point(48, 9);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(144, 38);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "Agri-Rent";
            //
            // pnlUtama
            //
            pnlUtama.BackColor = Color.FromArgb(247, 245, 238);
            pnlUtama.Controls.Add(pnlDaftar);
            pnlUtama.Controls.Add(pnlForm);
            pnlUtama.Controls.Add(pnlHeader);
            pnlUtama.Dock = DockStyle.Fill;
            pnlUtama.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlUtama.Location = new Point(250, 0);
            pnlUtama.Margin = new Padding(2);
            pnlUtama.Name = "pnlUtama";
            pnlUtama.Size = new Size(1062, 840);
            pnlUtama.TabIndex = 6;
            //
            // pnlDaftar
            //
            pnlDaftar.BackColor = Color.White;
            pnlDaftar.Controls.Add(dgvAlat);
            pnlDaftar.Controls.Add(cmbFilterJenis);
            pnlDaftar.Controls.Add(btnCari);
            pnlDaftar.Controls.Add(txtCari);
            pnlDaftar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlDaftar.Location = new Point(45, 406);
            pnlDaftar.Margin = new Padding(2);
            pnlDaftar.Name = "pnlDaftar";
            pnlDaftar.Size = new Size(983, 386);
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
            dgvAlat.EnableHeadersVisualStyles = false;
            dgvAlat.Location = new Point(39, 58);
            dgvAlat.Margin = new Padding(2);
            dgvAlat.MultiSelect = false;
            dgvAlat.Name = "dgvAlat";
            dgvAlat.ReadOnly = true;
            dgvAlat.RowHeadersVisible = false;
            dgvAlat.RowHeadersWidth = 62;
            dgvAlat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlat.Size = new Size(905, 310);
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
            // cmbFilterJenis
            //
            cmbFilterJenis.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterJenis.FormattingEnabled = true;
            cmbFilterJenis.Items.AddRange(new object[] { "Semua Jenis", "Traktor", "Pompa Air" });
            cmbFilterJenis.Location = new Point(397, 18);
            cmbFilterJenis.Margin = new Padding(2);
            cmbFilterJenis.Name = "cmbFilterJenis";
            cmbFilterJenis.Size = new Size(108, 28);
            cmbFilterJenis.TabIndex = 35;
            //
            // btnCari
            //
            btnCari.BackColor = Color.FromArgb(47, 93, 58);
            btnCari.ForeColor = Color.White;
            btnCari.Location = new Point(516, 18);
            btnCari.Margin = new Padding(2);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(80, 27);
            btnCari.TabIndex = 34;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = false;
            btnCari.Click += btnCari_Click;
            //
            // txtCari
            //
            txtCari.Location = new Point(39, 18);
            txtCari.Margin = new Padding(2);
            txtCari.Name = "txtCari";
            txtCari.PlaceholderText = "Cari kode, nama, atau merek";
            txtCari.Size = new Size(342, 27);
            txtCari.TabIndex = 32;
            //
            // pnlForm
            //
            pnlForm.BackColor = Color.White;
            pnlForm.Controls.Add(pnlPompaAir);
            pnlForm.Controls.Add(pnlTraktor);
            pnlForm.Controls.Add(btnBersihkan);
            pnlForm.Controls.Add(btnHapus);
            pnlForm.Controls.Add(btnUbah);
            pnlForm.Controls.Add(btnTambah);
            pnlForm.Controls.Add(cmbJenis);
            pnlForm.Controls.Add(cmbKondisi);
            pnlForm.Controls.Add(txtKode);
            pnlForm.Controls.Add(txtNama);
            pnlForm.Controls.Add(txtMerek);
            pnlForm.Controls.Add(txtTahun);
            pnlForm.Controls.Add(txtStatus);
            pnlForm.Controls.Add(txtDeskripsi);
            pnlForm.Controls.Add(txtTarif);
            pnlForm.Controls.Add(lblDeskripsi);
            pnlForm.Controls.Add(lblStatus);
            pnlForm.Controls.Add(lblTarif);
            pnlForm.Controls.Add(lblKondisi);
            pnlForm.Controls.Add(lblTahun);
            pnlForm.Controls.Add(lblJenis);
            pnlForm.Controls.Add(lblMerek);
            pnlForm.Controls.Add(lblNama);
            pnlForm.Controls.Add(lblKode);
            pnlForm.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlForm.Location = new Point(45, 70);
            pnlForm.Margin = new Padding(2);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(983, 304);
            pnlForm.TabIndex = 2;
            //
            // pnlPompaAir
            //
            pnlPompaAir.Controls.Add(txtDiameterPipa);
            pnlPompaAir.Controls.Add(lblDiameterPipa);
            pnlPompaAir.Controls.Add(cmbBahanBakar);
            pnlPompaAir.Controls.Add(lblBahanBakar);
            pnlPompaAir.Controls.Add(txtBerat);
            pnlPompaAir.Controls.Add(lblBerat);
            pnlPompaAir.Controls.Add(txtDebit);
            pnlPompaAir.Controls.Add(lblDebit);
            pnlPompaAir.Controls.Add(lblSpesifikasiPompa);
            pnlPompaAir.Location = new Point(37, 165);
            pnlPompaAir.Name = "pnlPompaAir";
            pnlPompaAir.Size = new Size(930, 88);
            pnlPompaAir.TabIndex = 21;
            pnlPompaAir.Visible = false;
            //
            // txtDiameterPipa
            //
            txtDiameterPipa.Location = new Point(694, 53);
            txtDiameterPipa.Name = "txtDiameterPipa";
            txtDiameterPipa.PlaceholderText = "3";
            txtDiameterPipa.Size = new Size(150, 27);
            txtDiameterPipa.TabIndex = 4;
            //
            // lblDiameterPipa
            //
            lblDiameterPipa.AutoSize = true;
            lblDiameterPipa.Location = new Point(692, 31);
            lblDiameterPipa.Name = "lblDiameterPipa";
            lblDiameterPipa.Size = new Size(139, 20);
            lblDiameterPipa.TabIndex = 7;
            lblDiameterPipa.Text = "Diameter Pipa (Inci)";
            //
            // cmbBahanBakar
            //
            cmbBahanBakar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBahanBakar.FormattingEnabled = true;
            cmbBahanBakar.Items.AddRange(new object[] { "Bensin", "Solar", "Listrik" });
            cmbBahanBakar.Location = new Point(462, 52);
            cmbBahanBakar.Name = "cmbBahanBakar";
            cmbBahanBakar.Size = new Size(172, 28);
            cmbBahanBakar.TabIndex = 3;
            //
            // lblBahanBakar
            //
            lblBahanBakar.AutoSize = true;
            lblBahanBakar.Location = new Point(460, 31);
            lblBahanBakar.Name = "lblBahanBakar";
            lblBahanBakar.Size = new Size(88, 20);
            lblBahanBakar.TabIndex = 5;
            lblBahanBakar.Text = "Bahan Bakar";
            //
            // txtBerat
            //
            txtBerat.Location = new Point(229, 53);
            txtBerat.Name = "txtBerat";
            txtBerat.PlaceholderText = "27";
            txtBerat.Size = new Size(193, 27);
            txtBerat.TabIndex = 2;
            //
            // lblBerat
            //
            lblBerat.AutoSize = true;
            lblBerat.Location = new Point(227, 31);
            lblBerat.Name = "lblBerat";
            lblBerat.Size = new Size(76, 20);
            lblBerat.TabIndex = 3;
            lblBerat.Text = "Berat (Kg)";
            //
            // txtDebit
            //
            txtDebit.Location = new Point(2, 53);
            txtDebit.Name = "txtDebit";
            txtDebit.PlaceholderText = "1100";
            txtDebit.Size = new Size(197, 27);
            txtDebit.TabIndex = 1;
            //
            // lblDebit
            //
            lblDebit.AutoSize = true;
            lblDebit.Location = new Point(0, 31);
            lblDebit.Name = "lblDebit";
            lblDebit.Size = new Size(134, 20);
            lblDebit.TabIndex = 1;
            lblDebit.Text = "Debit (Liter/Menit)";
            //
            // lblSpesifikasiPompa
            //
            lblSpesifikasiPompa.AutoSize = true;
            lblSpesifikasiPompa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSpesifikasiPompa.ForeColor = Color.FromArgb(47, 93, 58);
            lblSpesifikasiPompa.Location = new Point(0, 4);
            lblSpesifikasiPompa.Name = "lblSpesifikasiPompa";
            lblSpesifikasiPompa.Size = new Size(160, 20);
            lblSpesifikasiPompa.TabIndex = 0;
            lblSpesifikasiPompa.Text = "Spesifikasi Pompa Air";
            //
            // pnlTraktor
            //
            pnlTraktor.Controls.Add(cmbJenisTraktor);
            pnlTraktor.Controls.Add(lblJenisTraktor);
            pnlTraktor.Controls.Add(txtKapasitasTangki);
            pnlTraktor.Controls.Add(lblKapasitasTangki);
            pnlTraktor.Controls.Add(txtTenaga);
            pnlTraktor.Controls.Add(lblTenaga);
            pnlTraktor.Controls.Add(lblSpesifikasiTraktor);
            pnlTraktor.Location = new Point(37, 165);
            pnlTraktor.Name = "pnlTraktor";
            pnlTraktor.Size = new Size(930, 88);
            pnlTraktor.TabIndex = 20;
            //
            // cmbJenisTraktor
            //
            cmbJenisTraktor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJenisTraktor.FormattingEnabled = true;
            cmbJenisTraktor.Items.AddRange(new object[] { "Roda 2", "Roda 4" });
            cmbJenisTraktor.Location = new Point(462, 52);
            cmbJenisTraktor.Name = "cmbJenisTraktor";
            cmbJenisTraktor.Size = new Size(172, 28);
            cmbJenisTraktor.TabIndex = 3;
            //
            // lblJenisTraktor
            //
            lblJenisTraktor.AutoSize = true;
            lblJenisTraktor.Location = new Point(460, 31);
            lblJenisTraktor.Name = "lblJenisTraktor";
            lblJenisTraktor.Size = new Size(90, 20);
            lblJenisTraktor.TabIndex = 5;
            lblJenisTraktor.Text = "Jenis Traktor";
            //
            // txtKapasitasTangki
            //
            txtKapasitasTangki.Location = new Point(229, 53);
            txtKapasitasTangki.Name = "txtKapasitasTangki";
            txtKapasitasTangki.PlaceholderText = "60";
            txtKapasitasTangki.Size = new Size(193, 27);
            txtKapasitasTangki.TabIndex = 2;
            //
            // lblKapasitasTangki
            //
            lblKapasitasTangki.AutoSize = true;
            lblKapasitasTangki.Location = new Point(227, 31);
            lblKapasitasTangki.Name = "lblKapasitasTangki";
            lblKapasitasTangki.Size = new Size(161, 20);
            lblKapasitasTangki.TabIndex = 3;
            lblKapasitasTangki.Text = "Kapasitas Tangki (Liter)";
            //
            // txtTenaga
            //
            txtTenaga.Location = new Point(2, 53);
            txtTenaga.Name = "txtTenaga";
            txtTenaga.PlaceholderText = "75";
            txtTenaga.Size = new Size(197, 27);
            txtTenaga.TabIndex = 1;
            //
            // lblTenaga
            //
            lblTenaga.AutoSize = true;
            lblTenaga.Location = new Point(0, 31);
            lblTenaga.Name = "lblTenaga";
            lblTenaga.Size = new Size(90, 20);
            lblTenaga.TabIndex = 1;
            lblTenaga.Text = "Tenaga (HP)";
            //
            // lblSpesifikasiTraktor
            //
            lblSpesifikasiTraktor.AutoSize = true;
            lblSpesifikasiTraktor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSpesifikasiTraktor.ForeColor = Color.FromArgb(47, 93, 58);
            lblSpesifikasiTraktor.Location = new Point(0, 4);
            lblSpesifikasiTraktor.Name = "lblSpesifikasiTraktor";
            lblSpesifikasiTraktor.Size = new Size(140, 20);
            lblSpesifikasiTraktor.TabIndex = 0;
            lblSpesifikasiTraktor.Text = "Spesifikasi Traktor";
            //
            // btnBersihkan
            //
            btnBersihkan.FlatStyle = FlatStyle.Flat;
            btnBersihkan.ForeColor = Color.FromArgb(47, 93, 58);
            btnBersihkan.Location = new Point(499, 260);
            btnBersihkan.Margin = new Padding(2);
            btnBersihkan.Name = "btnBersihkan";
            btnBersihkan.Size = new Size(90, 27);
            btnBersihkan.TabIndex = 30;
            btnBersihkan.Text = "Bersihkan";
            btnBersihkan.UseVisualStyleBackColor = true;
            btnBersihkan.Click += btnBersihkan_Click;
            //
            // btnHapus
            //
            btnHapus.BackColor = Color.FromArgb(179, 65, 47);
            btnHapus.ForeColor = Color.White;
            btnHapus.Location = new Point(342, 260);
            btnHapus.Margin = new Padding(2);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(90, 27);
            btnHapus.TabIndex = 29;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            //
            // btnUbah
            //
            btnUbah.BackColor = Color.FromArgb(224, 165, 38);
            btnUbah.Location = new Point(190, 260);
            btnUbah.Margin = new Padding(2);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(90, 27);
            btnUbah.TabIndex = 28;
            btnUbah.Text = "Ubah";
            btnUbah.UseVisualStyleBackColor = false;
            btnUbah.Click += btnUbah_Click;
            //
            // btnTambah
            //
            btnTambah.BackColor = Color.FromArgb(62, 122, 60);
            btnTambah.ForeColor = Color.White;
            btnTambah.Location = new Point(39, 260);
            btnTambah.Margin = new Padding(2);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(90, 27);
            btnTambah.TabIndex = 27;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            //
            // cmbJenis
            //
            cmbJenis.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJenis.FormattingEnabled = true;
            cmbJenis.Items.AddRange(new object[] { "Traktor", "Pompa Air" });
            cmbJenis.Location = new Point(650, 29);
            cmbJenis.Margin = new Padding(2);
            cmbJenis.Name = "cmbJenis";
            cmbJenis.Size = new Size(133, 28);
            cmbJenis.TabIndex = 4;
            cmbJenis.SelectedIndexChanged += cmbJenis_SelectedIndexChanged;
            //
            // cmbKondisi
            //
            cmbKondisi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKondisi.FormattingEnabled = true;
            cmbKondisi.Items.AddRange(new object[] { "Baik", "Cukup", "Perlu servis" });
            cmbKondisi.Location = new Point(250, 82);
            cmbKondisi.Margin = new Padding(2);
            cmbKondisi.Name = "cmbKondisi";
            cmbKondisi.Size = new Size(160, 28);
            cmbKondisi.TabIndex = 6;
            //
            // txtKode
            //
            txtKode.CharacterCasing = CharacterCasing.Upper;
            txtKode.Location = new Point(39, 29);
            txtKode.Margin = new Padding(2);
            txtKode.MaxLength = 10;
            txtKode.Name = "txtKode";
            txtKode.PlaceholderText = "TR-001";
            txtKode.Size = new Size(160, 27);
            txtKode.TabIndex = 1;
            //
            // txtNama
            //
            txtNama.Location = new Point(250, 29);
            txtNama.Margin = new Padding(2);
            txtNama.Name = "txtNama";
            txtNama.PlaceholderText = "Traktor Roda 4";
            txtNama.Size = new Size(160, 27);
            txtNama.TabIndex = 2;
            //
            // txtMerek
            //
            txtMerek.Location = new Point(450, 29);
            txtMerek.Margin = new Padding(2);
            txtMerek.Name = "txtMerek";
            txtMerek.PlaceholderText = "Kubota";
            txtMerek.Size = new Size(160, 27);
            txtMerek.TabIndex = 3;
            //
            // txtTahun
            //
            txtTahun.Location = new Point(39, 83);
            txtTahun.Margin = new Padding(2);
            txtTahun.MaxLength = 4;
            txtTahun.Name = "txtTahun";
            txtTahun.PlaceholderText = "2020";
            txtTahun.Size = new Size(160, 27);
            txtTahun.TabIndex = 5;
            //
            // txtStatus
            //
            txtStatus.BackColor = Color.FromArgb(247, 245, 238);
            txtStatus.Location = new Point(650, 83);
            txtStatus.Margin = new Padding(2);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(133, 27);
            txtStatus.TabIndex = 99;
            txtStatus.TabStop = false;
            //
            // txtDeskripsi
            //
            txtDeskripsi.Location = new Point(39, 133);
            txtDeskripsi.Margin = new Padding(2);
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(744, 27);
            txtDeskripsi.TabIndex = 8;
            //
            // txtTarif
            //
            txtTarif.Location = new Point(450, 83);
            txtTarif.Margin = new Padding(2);
            txtTarif.Name = "txtTarif";
            txtTarif.PlaceholderText = "800.000";
            txtTarif.Size = new Size(160, 27);
            txtTarif.TabIndex = 7;
            //
            // lblDeskripsi
            //
            lblDeskripsi.AutoSize = true;
            lblDeskripsi.Location = new Point(37, 110);
            lblDeskripsi.Margin = new Padding(2, 0, 2, 0);
            lblDeskripsi.Name = "lblDeskripsi";
            lblDeskripsi.Size = new Size(69, 20);
            lblDeskripsi.TabIndex = 8;
            lblDeskripsi.Text = "Deskripsi";
            //
            // lblStatus
            //
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(648, 60);
            lblStatus.Margin = new Padding(2, 0, 2, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(124, 20);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Status (Otomatis)";
            //
            // lblTarif
            //
            lblTarif.AutoSize = true;
            lblTarif.Location = new Point(448, 60);
            lblTarif.Margin = new Padding(2, 0, 2, 0);
            lblTarif.Name = "lblTarif";
            lblTarif.Size = new Size(124, 20);
            lblTarif.TabIndex = 6;
            lblTarif.Text = "Tarif Per Hari (Rp)";
            //
            // lblKondisi
            //
            lblKondisi.AutoSize = true;
            lblKondisi.Location = new Point(248, 60);
            lblKondisi.Margin = new Padding(2, 0, 2, 0);
            lblKondisi.Name = "lblKondisi";
            lblKondisi.Size = new Size(58, 20);
            lblKondisi.TabIndex = 5;
            lblKondisi.Text = "Kondisi";
            //
            // lblTahun
            //
            lblTahun.AutoSize = true;
            lblTahun.Location = new Point(37, 60);
            lblTahun.Margin = new Padding(2, 0, 2, 0);
            lblTahun.Name = "lblTahun";
            lblTahun.Size = new Size(109, 20);
            lblTahun.TabIndex = 4;
            lblTahun.Text = "Tahun Keluaran";
            //
            // lblJenis
            //
            lblJenis.AutoSize = true;
            lblJenis.Location = new Point(648, 7);
            lblJenis.Margin = new Padding(2, 0, 2, 0);
            lblJenis.Name = "lblJenis";
            lblJenis.Size = new Size(40, 20);
            lblJenis.TabIndex = 3;
            lblJenis.Text = "Jenis";
            //
            // lblMerek
            //
            lblMerek.AutoSize = true;
            lblMerek.Location = new Point(448, 7);
            lblMerek.Margin = new Padding(2, 0, 2, 0);
            lblMerek.Name = "lblMerek";
            lblMerek.Size = new Size(50, 20);
            lblMerek.TabIndex = 2;
            lblMerek.Text = "Merek";
            //
            // lblNama
            //
            lblNama.AutoSize = true;
            lblNama.Location = new Point(248, 7);
            lblNama.Margin = new Padding(2, 0, 2, 0);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(80, 20);
            lblNama.TabIndex = 1;
            lblNama.Text = "Nama Alat";
            //
            // lblKode
            //
            lblKode.AutoSize = true;
            lblKode.Location = new Point(37, 7);
            lblKode.Margin = new Padding(2, 0, 2, 0);
            lblKode.Name = "lblKode";
            lblKode.Size = new Size(44, 20);
            lblKode.TabIndex = 0;
            lblKode.Text = "Kode";
            //
            // pnlHeader
            //
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblJudul);
            pnlHeader.Controls.Add(lblPengguna);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(2);
            pnlHeader.Name = "pnlHeader";
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
            lblPengguna.AutoSize = true;
            lblPengguna.BackColor = Color.White;
            lblPengguna.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPengguna.Location = new Point(690, 21);
            lblPengguna.Margin = new Padding(2, 0, 2, 0);
            lblPengguna.Name = "lblPengguna";
            lblPengguna.Size = new Size(181, 23);
            lblPengguna.TabIndex = 1;
            lblPengguna.Text = "Masuk sebagai: Admin";
            //
            // formKelolaAlat
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 840);
            Controls.Add(pnlUtama);
            Controls.Add(pnlSidebar);
            Name = "formKelolaAlat";
            Text = "Kelola Alat - Agri-Rent";
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlUtama.ResumeLayout(false);
            pnlDaftar.ResumeLayout(false);
            pnlDaftar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlat).EndInit();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            pnlPompaAir.ResumeLayout(false);
            pnlPompaAir.PerformLayout();
            pnlTraktor.ResumeLayout(false);
            pnlTraktor.PerformLayout();
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
        private Panel pnlForm;
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
        private Panel pnlTraktor;
        private Label lblSpesifikasiTraktor;
        private Label lblTenaga;
        private TextBox txtTenaga;
        private Label lblKapasitasTangki;
        private TextBox txtKapasitasTangki;
        private Label lblJenisTraktor;
        private ComboBox cmbJenisTraktor;
        private Panel pnlPompaAir;
        private Label lblSpesifikasiPompa;
        private Label lblDebit;
        private TextBox txtDebit;
        private Label lblBerat;
        private TextBox txtBerat;
        private Label lblBahanBakar;
        private ComboBox cmbBahanBakar;
        private Label lblDiameterPipa;
        private TextBox txtDiameterPipa;
        private Button btnTambah;
        private Button btnUbah;
        private Button btnHapus;
        private Button btnBersihkan;
        private Panel pnlDaftar;
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
