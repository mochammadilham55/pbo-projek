namespace projek_pbo.view
{
    partial class FormKelolaUser
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
            pnlIsi = new Panel();
            pnlDaftar = new Panel();
            lblDaftar = new Label();
            dgvPengguna = new DataGridView();
            colNama = new DataGridViewTextBoxColumn();
            colUsername = new DataGridViewTextBoxColumn();
            colPeran = new DataGridViewTextBoxColumn();
            pnlForm = new Panel();
            btnBersihkan = new Button();
            cmbPeran = new ComboBox();
            btnHapus = new Button();
            btnUbah = new Button();
            btnSimpan = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtNama = new TextBox();
            lblPeran = new Label();
            lblPassword = new Label();
            lblUsername = new Label();
            lblNama = new Label();
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
            pnlHeader = new Panel();
            lblJudul = new Label();
            lblPengguna = new Label();
            pnlIsi.SuspendLayout();
            pnlDaftar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPengguna).BeginInit();
            pnlForm.SuspendLayout();
            pnlSidebar.SuspendLayout();
            pnlUtama.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlIsi
            // 
            pnlIsi.BackColor = Color.FromArgb(247, 245, 238);
            pnlIsi.Controls.Add(pnlDaftar);
            pnlIsi.Controls.Add(pnlForm);
            pnlIsi.Dock = DockStyle.Fill;
            pnlIsi.Location = new Point(0, 66);
            pnlIsi.Name = "pnlIsi";
            pnlIsi.Padding = new Padding(24);
            pnlIsi.Size = new Size(1202, 518);
            pnlIsi.TabIndex = 1;
            // 
            // pnlDaftar
            // 
            pnlDaftar.BackColor = SystemColors.ControlLightLight;
            pnlDaftar.Controls.Add(lblDaftar);
            pnlDaftar.Controls.Add(dgvPengguna);
            pnlDaftar.Location = new Point(281, 209);
            pnlDaftar.Name = "pnlDaftar";
            pnlDaftar.Size = new Size(894, 297);
            pnlDaftar.TabIndex = 4;
            // 
            // lblDaftar
            // 
            lblDaftar.AutoSize = true;
            lblDaftar.Location = new Point(30, 23);
            lblDaftar.Name = "lblDaftar";
            lblDaftar.Size = new Size(120, 20);
            lblDaftar.TabIndex = 11;
            lblDaftar.Text = "Daftar Pengguna";
            // 
            // dgvPengguna
            // 
            dgvPengguna.AllowUserToAddRows = false;
            dgvPengguna.AllowUserToDeleteRows = false;
            dgvPengguna.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPengguna.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(47, 93, 58);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPengguna.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPengguna.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPengguna.Columns.AddRange(new DataGridViewColumn[] { colNama, colUsername, colPeran });
            dgvPengguna.EnableHeadersVisualStyles = false;
            dgvPengguna.Location = new Point(19, 61);
            dgvPengguna.MultiSelect = false;
            dgvPengguna.Name = "dgvPengguna";
            dgvPengguna.ReadOnly = true;
            dgvPengguna.RowHeadersVisible = false;
            dgvPengguna.RowHeadersWidth = 51;
            dgvPengguna.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPengguna.Size = new Size(862, 221);
            dgvPengguna.TabIndex = 0;
            dgvPengguna.CellClick += dgvPengguna_CellClick;
            // 
            // colNama
            // 
            colNama.HeaderText = "Nama Lengkap";
            colNama.MinimumWidth = 6;
            colNama.Name = "colNama";
            colNama.ReadOnly = true;
            // 
            // colUsername
            // 
            colUsername.HeaderText = "Username";
            colUsername.MinimumWidth = 6;
            colUsername.Name = "colUsername";
            colUsername.ReadOnly = true;
            // 
            // colPeran
            // 
            colPeran.HeaderText = "Peran";
            colPeran.MinimumWidth = 6;
            colPeran.Name = "colPeran";
            colPeran.ReadOnly = true;
            // 
            // pnlForm
            // 
            pnlForm.BackColor = SystemColors.ControlLightLight;
            pnlForm.Controls.Add(btnBersihkan);
            pnlForm.Controls.Add(cmbPeran);
            pnlForm.Controls.Add(btnHapus);
            pnlForm.Controls.Add(btnUbah);
            pnlForm.Controls.Add(btnSimpan);
            pnlForm.Controls.Add(txtPassword);
            pnlForm.Controls.Add(txtUsername);
            pnlForm.Controls.Add(txtNama);
            pnlForm.Controls.Add(lblPeran);
            pnlForm.Controls.Add(lblPassword);
            pnlForm.Controls.Add(lblUsername);
            pnlForm.Controls.Add(lblNama);
            pnlForm.Location = new Point(281, 32);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(894, 156);
            pnlForm.TabIndex = 2;
            // 
            // btnBersihkan
            // 
            btnBersihkan.FlatStyle = FlatStyle.Flat;
            btnBersihkan.ForeColor = Color.FromArgb(47, 93, 58);
            btnBersihkan.Location = new Point(409, 106);
            btnBersihkan.Name = "btnBersihkan";
            btnBersihkan.Size = new Size(94, 29);
            btnBersihkan.TabIndex = 11;
            btnBersihkan.Text = "Bersihkan";
            btnBersihkan.UseVisualStyleBackColor = true;
            btnBersihkan.Click += btnBersihkan_Click;
            // 
            // cmbPeran
            // 
            cmbPeran.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPeran.FormattingEnabled = true;
            cmbPeran.Items.AddRange(new object[] { "Admin", "Petugas" });
            cmbPeran.Location = new Point(723, 32);
            cmbPeran.Name = "cmbPeran";
            cmbPeran.Size = new Size(151, 28);
            cmbPeran.TabIndex = 7;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.FromArgb(179, 65, 47);
            btnHapus.ForeColor = Color.White;
            btnHapus.Location = new Point(285, 106);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(94, 29);
            btnHapus.TabIndex = 10;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnUbah
            // 
            btnUbah.BackColor = Color.FromArgb(224, 165, 38);
            btnUbah.Location = new Point(154, 106);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(94, 29);
            btnUbah.TabIndex = 9;
            btnUbah.Text = "Ubah";
            btnUbah.UseVisualStyleBackColor = false;
            btnUbah.Click += btnUbah_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.FromArgb(62, 122, 60);
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(30, 106);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 8;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(524, 31);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(179, 27);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(276, 32);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(207, 27);
            txtUsername.TabIndex = 5;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(19, 31);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(229, 27);
            txtNama.TabIndex = 4;
            // 
            // lblPeran
            // 
            lblPeran.AutoSize = true;
            lblPeran.Location = new Point(723, 7);
            lblPeran.Name = "lblPeran";
            lblPeran.Size = new Size(45, 20);
            lblPeran.TabIndex = 3;
            lblPeran.Text = "Peran";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(524, 9);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(276, 9);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(19, 9);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(109, 20);
            lblNama.TabIndex = 0;
            lblNama.Text = "Nama Lengkap";
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
            pnlSidebar.Size = new Size(250, 584);
            pnlSidebar.TabIndex = 10;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(179, 65, 47);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 122, 60);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(12, 543);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(15, 0, 0, 0);
            btnLogout.Size = new Size(223, 29);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.FromArgb(62, 122, 60);
            btnUser.Dock = DockStyle.Top;
            btnUser.FlatAppearance.BorderSize = 0;
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
            btnUser.UseVisualStyleBackColor = false;
            // 
            // btnLaporan
            // 
            btnLaporan.Dock = DockStyle.Top;
            btnLaporan.FlatAppearance.BorderSize = 0;
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
            btnPengembaian.FlatAppearance.BorderSize = 0;
            btnPengembaian.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 122, 60);
            btnPengembaian.FlatStyle = FlatStyle.Flat;
            btnPengembaian.ForeColor = Color.White;
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
            btnSewa.FlatAppearance.BorderSize = 0;
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
            btnAlat.FlatAppearance.BorderSize = 0;
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
            btnDashboard.FlatAppearance.BorderSize = 0;
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
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Dock = DockStyle.Top;
            lblLogo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = SystemColors.ControlLightLight;
            lblLogo.Location = new Point(0, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Padding = new Padding(50, 30, 30, 30);
            lblLogo.Size = new Size(224, 98);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "Agri-Rent";
            // 
            // pnlUtama
            // 
            pnlUtama.Controls.Add(pnlIsi);
            pnlUtama.Controls.Add(pnlHeader);
            pnlUtama.Dock = DockStyle.Fill;
            pnlUtama.Location = new Point(0, 0);
            pnlUtama.Name = "pnlUtama";
            pnlUtama.Size = new Size(1202, 584);
            pnlUtama.TabIndex = 11;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblJudul);
            pnlHeader.Controls.Add(lblPengguna);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1202, 66);
            pnlHeader.TabIndex = 0;
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblJudul.ForeColor = Color.FromArgb(47, 93, 58);
            lblJudul.Location = new Point(272, 17);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(133, 31);
            lblJudul.TabIndex = 1;
            lblJudul.Text = "Kelola User";
            // 
            // lblPengguna
            // 
            lblPengguna.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPengguna.AutoSize = true;
            lblPengguna.Location = new Point(860, 23);
            lblPengguna.Name = "lblPengguna";
            lblPengguna.Size = new Size(158, 20);
            lblPengguna.TabIndex = 1;
            lblPengguna.Text = "Masuk sebagai: Admin";
            // 
            // FormKelolaUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 93, 58);
            ClientSize = new Size(1202, 584);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlUtama);
            Name = "FormKelolaUser";
            Text = "Kelola User - Agri-Rent";
            pnlIsi.ResumeLayout(false);
            pnlDaftar.ResumeLayout(false);
            pnlDaftar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPengguna).EndInit();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlUtama.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlIsi;
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
        private Panel pnlForm;
        private Panel pnlHeader;
        private Label lblJudul;
        private Label lblPengguna;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox txtNama;
        private Label lblPeran;
        private Label lblPassword;
        private Label lblUsername;
        private Label lblNama;
        private Panel pnlDaftar;
        private Button btnHapus;
        private Button btnUbah;
        private Button btnSimpan;
        private Button btnBersihkan;
        private Label lblDaftar;
        private DataGridView dgvPengguna;
        private ComboBox cmbPeran;
        private DataGridViewTextBoxColumn colNama;
        private DataGridViewTextBoxColumn colUsername;
        private DataGridViewTextBoxColumn colPeran;
    }
}
