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
            pnlJarak = new Panel();
            tblForm = new TableLayoutPanel();
            flpTombol = new FlowLayoutPanel();
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
            tblForm.SuspendLayout();
            flpTombol.SuspendLayout();
            pnlSidebar.SuspendLayout();
            pnlUtama.SuspendLayout();
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
            btnUser.BackColor = Color.FromArgb(62, 122, 60);
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
            btnUser.UseVisualStyleBackColor = false;
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
            // pnlIsi
            //
            pnlIsi.BackColor = Color.FromArgb(247, 245, 238);
            pnlIsi.Controls.Add(pnlDaftar);
            pnlIsi.Controls.Add(pnlJarak);
            pnlIsi.Controls.Add(pnlForm);
            pnlIsi.Dock = DockStyle.Fill;
            pnlIsi.Location = new Point(0, 66);
            pnlIsi.Name = "pnlIsi";
            pnlIsi.Padding = new Padding(45, 20, 45, 30);
            pnlIsi.Size = new Size(1062, 654);
            pnlIsi.TabIndex = 1;
            //
            // pnlDaftar
            //
            pnlDaftar.BackColor = SystemColors.ControlLightLight;
            pnlDaftar.Controls.Add(dgvPengguna);
            pnlDaftar.Controls.Add(lblDaftar);
            pnlDaftar.Dock = DockStyle.Fill;
            pnlDaftar.Location = new Point(45, 174);
            pnlDaftar.Name = "pnlDaftar";
            pnlDaftar.Padding = new Padding(30, 6, 30, 18);
            pnlDaftar.Size = new Size(972, 450);
            pnlDaftar.TabIndex = 4;
            //
            // lblDaftar
            //
            lblDaftar.Dock = DockStyle.Top;
            lblDaftar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDaftar.ForeColor = Color.FromArgb(47, 93, 58);
            lblDaftar.Location = new Point(30, 6);
            lblDaftar.Name = "lblDaftar";
            lblDaftar.Size = new Size(912, 36);
            lblDaftar.TabIndex = 11;
            lblDaftar.Text = "Daftar Pengguna";
            lblDaftar.TextAlign = ContentAlignment.MiddleLeft;
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
            dgvPengguna.Dock = DockStyle.Fill;
            dgvPengguna.EnableHeadersVisualStyles = false;
            dgvPengguna.Location = new Point(30, 42);
            dgvPengguna.MultiSelect = false;
            dgvPengguna.Name = "dgvPengguna";
            dgvPengguna.ReadOnly = true;
            dgvPengguna.RowHeadersVisible = false;
            dgvPengguna.RowHeadersWidth = 51;
            dgvPengguna.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPengguna.Size = new Size(912, 390);
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
            // pnlJarak
            //
            pnlJarak.Dock = DockStyle.Top;
            pnlJarak.Location = new Point(45, 154);
            pnlJarak.Name = "pnlJarak";
            pnlJarak.Size = new Size(972, 20);
            pnlJarak.TabIndex = 3;
            //
            // pnlForm
            //
            pnlForm.BackColor = SystemColors.ControlLightLight;
            pnlForm.Controls.Add(flpTombol);
            pnlForm.Controls.Add(tblForm);
            pnlForm.Dock = DockStyle.Top;
            pnlForm.Location = new Point(45, 20);
            pnlForm.Name = "pnlForm";
            pnlForm.Padding = new Padding(30, 10, 30, 10);
            pnlForm.Size = new Size(972, 134);
            pnlForm.TabIndex = 2;
            //
            // tblForm
            //
            tblForm.ColumnCount = 4;
            tblForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblForm.Controls.Add(lblNama, 0, 0);
            tblForm.Controls.Add(lblUsername, 1, 0);
            tblForm.Controls.Add(lblPassword, 2, 0);
            tblForm.Controls.Add(lblPeran, 3, 0);
            tblForm.Controls.Add(txtNama, 0, 1);
            tblForm.Controls.Add(txtUsername, 1, 1);
            tblForm.Controls.Add(txtPassword, 2, 1);
            tblForm.Controls.Add(cmbPeran, 3, 1);
            tblForm.Dock = DockStyle.Top;
            tblForm.Location = new Point(30, 10);
            tblForm.Name = "tblForm";
            tblForm.RowCount = 2;
            tblForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tblForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tblForm.Size = new Size(912, 58);
            tblForm.TabIndex = 0;
            //
            // lblNama
            //
            lblNama.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblNama.AutoSize = true;
            lblNama.Location = new Point(0, 2);
            lblNama.Margin = new Padding(0, 0, 0, 2);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(109, 20);
            lblNama.TabIndex = 0;
            lblNama.Text = "Nama Lengkap";
            //
            // lblUsername
            //
            lblUsername.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(228, 2);
            lblUsername.Margin = new Padding(0, 0, 0, 2);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            //
            // lblPassword
            //
            lblPassword.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(456, 2);
            lblPassword.Margin = new Padding(0, 0, 0, 2);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            //
            // lblPeran
            //
            lblPeran.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPeran.AutoSize = true;
            lblPeran.Location = new Point(684, 2);
            lblPeran.Margin = new Padding(0, 0, 0, 2);
            lblPeran.Name = "lblPeran";
            lblPeran.Size = new Size(45, 20);
            lblPeran.TabIndex = 3;
            lblPeran.Text = "Peran";
            //
            // txtNama
            //
            txtNama.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNama.Location = new Point(0, 27);
            txtNama.Margin = new Padding(0, 0, 24, 0);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(204, 27);
            txtNama.TabIndex = 4;
            //
            // txtUsername
            //
            txtUsername.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.Location = new Point(228, 27);
            txtUsername.Margin = new Padding(0, 0, 24, 0);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(204, 27);
            txtUsername.TabIndex = 5;
            //
            // txtPassword
            //
            txtPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Location = new Point(456, 27);
            txtPassword.Margin = new Padding(0, 0, 24, 0);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(204, 27);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            //
            // cmbPeran
            //
            cmbPeran.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbPeran.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPeran.FormattingEnabled = true;
            cmbPeran.Items.AddRange(new object[] { "Admin", "Petugas" });
            cmbPeran.Location = new Point(684, 27);
            cmbPeran.Margin = new Padding(0, 0, 24, 0);
            cmbPeran.Name = "cmbPeran";
            cmbPeran.Size = new Size(204, 27);
            cmbPeran.TabIndex = 7;
            //
            // flpTombol
            //
            flpTombol.Controls.Add(btnSimpan);
            flpTombol.Controls.Add(btnUbah);
            flpTombol.Controls.Add(btnHapus);
            flpTombol.Controls.Add(btnBersihkan);
            flpTombol.Dock = DockStyle.Top;
            flpTombol.Location = new Point(30, 68);
            flpTombol.Name = "flpTombol";
            flpTombol.Padding = new Padding(0, 8, 0, 0);
            flpTombol.Size = new Size(912, 50);
            flpTombol.TabIndex = 8;
            flpTombol.WrapContents = false;
            //
            // btnSimpan
            //
            btnSimpan.BackColor = Color.FromArgb(62, 122, 60);
            btnSimpan.ForeColor = Color.White;
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Location = new Point(2, 8);
            btnSimpan.Margin = new Padding(2, 0, 20, 0);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(100, 30);
            btnSimpan.TabIndex = 8;
            btnSimpan.Text = "Simpan";
            btnSimpan.Click += btnSimpan_Click;
            //
            // btnUbah
            //
            btnUbah.BackColor = Color.FromArgb(224, 165, 38);
            btnUbah.UseVisualStyleBackColor = false;
            btnUbah.Location = new Point(124, 8);
            btnUbah.Margin = new Padding(2, 0, 20, 0);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(100, 30);
            btnUbah.TabIndex = 9;
            btnUbah.Text = "Ubah";
            btnUbah.Click += btnUbah_Click;
            //
            // btnHapus
            //
            btnHapus.BackColor = Color.FromArgb(179, 65, 47);
            btnHapus.ForeColor = Color.White;
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Location = new Point(246, 8);
            btnHapus.Margin = new Padding(2, 0, 20, 0);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(100, 30);
            btnHapus.TabIndex = 10;
            btnHapus.Text = "Hapus";
            btnHapus.Click += btnHapus_Click;
            //
            // btnBersihkan
            //
            btnBersihkan.FlatStyle = FlatStyle.Flat;
            btnBersihkan.ForeColor = Color.FromArgb(47, 93, 58);
            btnBersihkan.UseVisualStyleBackColor = true;
            btnBersihkan.Location = new Point(368, 8);
            btnBersihkan.Margin = new Padding(2, 0, 20, 0);
            btnBersihkan.Name = "btnBersihkan";
            btnBersihkan.Size = new Size(100, 30);
            btnBersihkan.TabIndex = 11;
            btnBersihkan.Text = "Bersihkan";
            btnBersihkan.Click += btnBersihkan_Click;
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
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblJudul);
            pnlHeader.Controls.Add(lblPengguna);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(0, 0, 45, 0);
            pnlHeader.Size = new Size(1062, 66);
            pnlHeader.TabIndex = 0;
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblJudul.ForeColor = Color.FromArgb(47, 93, 58);
            lblJudul.Location = new Point(40, 17);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(133, 31);
            lblJudul.TabIndex = 1;
            lblJudul.Text = "Kelola User";
            // 
            // lblPengguna
            //
            lblPengguna.Dock = DockStyle.Right;
            lblPengguna.Location = new Point(567, 0);
            lblPengguna.Name = "lblPengguna";
            lblPengguna.Size = new Size(450, 66);
            lblPengguna.TabIndex = 1;
            lblPengguna.Text = "Masuk sebagai: Admin";
            lblPengguna.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FormKelolaUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 93, 58);
            ClientSize = new Size(1312, 720);
            Controls.Add(pnlUtama);
            Controls.Add(pnlSidebar);
            MinimumSize = new Size(1150, 680);
            Name = "FormKelolaUser";
            Text = "Kelola User - Agri-Rent";
            pnlIsi.ResumeLayout(false);
            pnlDaftar.ResumeLayout(false);
            pnlDaftar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPengguna).EndInit();
            pnlForm.ResumeLayout(false);
            tblForm.ResumeLayout(false);
            tblForm.PerformLayout();
            flpTombol.ResumeLayout(false);
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlUtama.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlIsi;
        private Panel pnlJarak;
        private TableLayoutPanel tblForm;
        private FlowLayoutPanel flpTombol;
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
