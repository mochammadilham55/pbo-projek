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
            btnDashboard = new Button();
            btnLogout = new Button();
            btnKelolaUser = new Button();
            btnLaporan = new Button();
            btnKelolaPengembalian = new Button();
            btnKelolaSewa = new Button();
            btnKelolaAlat = new Button();
            lblLogo = new Label();
            lblJudulHalaman = new Label();
            pnlHeader = new Panel();
            pnlUser = new TextBox();
            dgvLaporan = new DataGridView();
            cmbJenis = new ComboBox();
            btnTampilkan = new Button();
            pnlHasil = new Panel();
            label1 = new Label();
            pnlTotal = new Panel();
            lblTotalTeks = new Label();
            lblTotal = new Label();
            lblJudulLaporan = new Label();
            lblJenis = new Label();
            lblAwal = new Label();
            lblAkhir = new Label();
            pnlFilter = new Panel();
            dtpAkhir = new DateTimePicker();
            dtpAwal = new DateTimePicker();
            pnlContent = new Panel();
            pnlSidebar.SuspendLayout();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLaporan).BeginInit();
            pnlHasil.SuspendLayout();
            pnlTotal.SuspendLayout();
            pnlFilter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(47, 93, 58);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnKelolaUser);
            pnlSidebar.Controls.Add(btnLaporan);
            pnlSidebar.Controls.Add(btnKelolaPengembalian);
            pnlSidebar.Controls.Add(btnKelolaSewa);
            pnlSidebar.Controls.Add(btnKelolaAlat);
            pnlSidebar.Controls.Add(lblLogo);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Margin = new Padding(3, 2, 3, 2);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(171, 492);
            pnlSidebar.TabIndex = 5;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(47, 93, 58);
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(62, 122, 60);
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 108, 64);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.FromArgb(190, 210, 190);
            btnDashboard.Location = new Point(0, 220);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(14, 0, 0, 0);
            btnDashboard.Size = new Size(171, 44);
            btnDashboard.TabIndex = 6;
            btnDashboard.TabStop = false;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(179, 65, 47);
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 122, 60);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 459);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(171, 33);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnKelolaUser
            // 
            btnKelolaUser.BackColor = Color.FromArgb(47, 93, 58);
            btnKelolaUser.Cursor = Cursors.Hand;
            btnKelolaUser.Dock = DockStyle.Top;
            btnKelolaUser.FlatAppearance.BorderSize = 0;
            btnKelolaUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(62, 122, 60);
            btnKelolaUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 108, 64);
            btnKelolaUser.FlatStyle = FlatStyle.Flat;
            btnKelolaUser.ForeColor = Color.FromArgb(190, 210, 190);
            btnKelolaUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnKelolaUser.Location = new Point(0, 176);
            btnKelolaUser.Margin = new Padding(3, 2, 3, 2);
            btnKelolaUser.Name = "btnKelolaUser";
            btnKelolaUser.Padding = new Padding(14, 0, 0, 0);
            btnKelolaUser.Size = new Size(171, 44);
            btnKelolaUser.TabIndex = 6;
            btnKelolaUser.TabStop = false;
            btnKelolaUser.Text = "Kelola user";
            btnKelolaUser.TextAlign = ContentAlignment.MiddleLeft;
            btnKelolaUser.UseVisualStyleBackColor = false;
            btnKelolaUser.UseWaitCursor = true;
            // 
            // btnLaporan
            // 
            btnLaporan.BackColor = Color.FromArgb(47, 93, 58);
            btnLaporan.Cursor = Cursors.Hand;
            btnLaporan.Dock = DockStyle.Top;
            btnLaporan.FlatAppearance.BorderSize = 0;
            btnLaporan.FlatAppearance.MouseDownBackColor = Color.FromArgb(62, 122, 60);
            btnLaporan.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 108, 64);
            btnLaporan.FlatStyle = FlatStyle.Flat;
            btnLaporan.ForeColor = Color.FromArgb(190, 210, 190);
            btnLaporan.ImageAlign = ContentAlignment.MiddleLeft;
            btnLaporan.Location = new Point(0, 132);
            btnLaporan.Margin = new Padding(3, 2, 3, 2);
            btnLaporan.Name = "btnLaporan";
            btnLaporan.Padding = new Padding(14, 0, 0, 0);
            btnLaporan.Size = new Size(171, 44);
            btnLaporan.TabIndex = 5;
            btnLaporan.TabStop = false;
            btnLaporan.Text = "Laporan";
            btnLaporan.TextAlign = ContentAlignment.MiddleLeft;
            btnLaporan.UseVisualStyleBackColor = false;
            btnLaporan.UseWaitCursor = true;
            // 
            // btnKelolaPengembalian
            // 
            btnKelolaPengembalian.BackColor = Color.FromArgb(47, 93, 58);
            btnKelolaPengembalian.Cursor = Cursors.Hand;
            btnKelolaPengembalian.Dock = DockStyle.Top;
            btnKelolaPengembalian.FlatAppearance.BorderSize = 0;
            btnKelolaPengembalian.FlatAppearance.MouseDownBackColor = Color.FromArgb(62, 122, 60);
            btnKelolaPengembalian.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 108, 64);
            btnKelolaPengembalian.FlatStyle = FlatStyle.Flat;
            btnKelolaPengembalian.ForeColor = Color.FromArgb(190, 210, 190);
            btnKelolaPengembalian.ImageAlign = ContentAlignment.MiddleLeft;
            btnKelolaPengembalian.Location = new Point(0, 88);
            btnKelolaPengembalian.Margin = new Padding(3, 2, 3, 2);
            btnKelolaPengembalian.Name = "btnKelolaPengembalian";
            btnKelolaPengembalian.Padding = new Padding(14, 0, 0, 0);
            btnKelolaPengembalian.Size = new Size(171, 44);
            btnKelolaPengembalian.TabIndex = 4;
            btnKelolaPengembalian.TabStop = false;
            btnKelolaPengembalian.Text = "Kelola Pengembalian";
            btnKelolaPengembalian.TextAlign = ContentAlignment.MiddleLeft;
            btnKelolaPengembalian.UseVisualStyleBackColor = false;
            btnKelolaPengembalian.UseWaitCursor = true;
            btnKelolaPengembalian.Click += btnKelolaPengembalian_Click;
            // 
            // btnKelolaSewa
            // 
            btnKelolaSewa.BackColor = Color.FromArgb(47, 93, 58);
            btnKelolaSewa.Cursor = Cursors.Hand;
            btnKelolaSewa.Dock = DockStyle.Top;
            btnKelolaSewa.FlatAppearance.BorderSize = 0;
            btnKelolaSewa.FlatAppearance.MouseDownBackColor = Color.FromArgb(62, 122, 60);
            btnKelolaSewa.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 108, 64);
            btnKelolaSewa.FlatStyle = FlatStyle.Flat;
            btnKelolaSewa.ForeColor = Color.FromArgb(190, 210, 190);
            btnKelolaSewa.ImageAlign = ContentAlignment.MiddleLeft;
            btnKelolaSewa.Location = new Point(0, 44);
            btnKelolaSewa.Margin = new Padding(3, 2, 3, 2);
            btnKelolaSewa.Name = "btnKelolaSewa";
            btnKelolaSewa.Padding = new Padding(14, 0, 0, 0);
            btnKelolaSewa.Size = new Size(171, 44);
            btnKelolaSewa.TabIndex = 3;
            btnKelolaSewa.TabStop = false;
            btnKelolaSewa.Text = "Kelola Sewa";
            btnKelolaSewa.TextAlign = ContentAlignment.MiddleLeft;
            btnKelolaSewa.UseVisualStyleBackColor = false;
            btnKelolaSewa.UseWaitCursor = true;
            // 
            // btnKelolaAlat
            // 
            btnKelolaAlat.BackColor = Color.FromArgb(47, 93, 58);
            btnKelolaAlat.Cursor = Cursors.Hand;
            btnKelolaAlat.Dock = DockStyle.Top;
            btnKelolaAlat.FlatAppearance.BorderSize = 0;
            btnKelolaAlat.FlatAppearance.MouseDownBackColor = Color.FromArgb(62, 122, 60);
            btnKelolaAlat.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 108, 64);
            btnKelolaAlat.FlatStyle = FlatStyle.Flat;
            btnKelolaAlat.ForeColor = Color.FromArgb(190, 210, 190);
            btnKelolaAlat.ImageAlign = ContentAlignment.MiddleLeft;
            btnKelolaAlat.Location = new Point(0, 0);
            btnKelolaAlat.Margin = new Padding(3, 2, 3, 2);
            btnKelolaAlat.Name = "btnKelolaAlat";
            btnKelolaAlat.Padding = new Padding(14, 0, 0, 0);
            btnKelolaAlat.Size = new Size(171, 44);
            btnKelolaAlat.TabIndex = 2;
            btnKelolaAlat.TabStop = false;
            btnKelolaAlat.Text = "Kelola alat";
            btnKelolaAlat.TextAlign = ContentAlignment.MiddleLeft;
            btnKelolaAlat.UseVisualStyleBackColor = false;
            btnKelolaAlat.UseWaitCursor = true;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = SystemColors.ControlLightLight;
            lblLogo.Location = new Point(11, 21);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(113, 30);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "Agri-Rent";
            // 
            // lblJudulHalaman
            // 
            lblJudulHalaman.AutoSize = true;
            lblJudulHalaman.BackColor = SystemColors.Control;
            lblJudulHalaman.FlatStyle = FlatStyle.Popup;
            lblJudulHalaman.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJudulHalaman.ForeColor = Color.Green;
            lblJudulHalaman.Location = new Point(208, 8);
            lblJudulHalaman.Name = "lblJudulHalaman";
            lblJudulHalaman.Size = new Size(91, 30);
            lblJudulHalaman.TabIndex = 6;
            lblJudulHalaman.Text = "Laporan";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.BackgroundImageLayout = ImageLayout.None;
            pnlHeader.Controls.Add(pnlUser);
            pnlHeader.Controls.Add(lblJudulHalaman);
            pnlHeader.Location = new Point(0, 1);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1055, 59);
            pnlHeader.TabIndex = 7;
            // 
            // pnlUser
            // 
            pnlUser.BackColor = SystemColors.Control;
            pnlUser.Cursor = Cursors.Cross;
            pnlUser.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlUser.Location = new Point(874, 15);
            pnlUser.Name = "pnlUser";
            pnlUser.Size = new Size(166, 23);
            pnlUser.TabIndex = 7;
            pnlUser.Text = "Masuk sebagai :";
            pnlUser.TextChanged += textBox1_TextChanged;
            // 
            // dgvLaporan
            // 
            dgvLaporan.AllowUserToAddRows = false;
            dgvLaporan.AllowUserToDeleteRows = false;
            dgvLaporan.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(250, 248, 242);
            dgvLaporan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvLaporan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLaporan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLaporan.BackgroundColor = Color.White;
            dgvLaporan.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(47, 93, 58);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(247, 245, 238);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvLaporan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvLaporan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLaporan.EnableHeadersVisualStyles = false;
            dgvLaporan.GridColor = Color.FromArgb(236, 232, 218);
            dgvLaporan.Location = new Point(235, 210);
            dgvLaporan.MultiSelect = false;
            dgvLaporan.Name = "dgvLaporan";
            dgvLaporan.ReadOnly = true;
            dgvLaporan.RowHeadersVisible = false;
            dgvLaporan.RowTemplate.Height = 32;
            dgvLaporan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLaporan.Size = new Size(759, 93);
            dgvLaporan.TabIndex = 12;
            // 
            // cmbJenis
            // 
            cmbJenis.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJenis.FormattingEnabled = true;
            cmbJenis.Items.AddRange(new object[] { "Laporan Pendapatan", "Laporan Pengeluaran", "Grafik", "" });
            cmbJenis.Location = new Point(205, 114);
            cmbJenis.Name = "cmbJenis";
            cmbJenis.Size = new Size(121, 23);
            cmbJenis.TabIndex = 17;
            // 
            // btnTampilkan
            // 
            btnTampilkan.BackColor = Color.FromArgb(62, 122, 60);
            btnTampilkan.Font = new Font("Segoe UI", 14F);
            btnTampilkan.ForeColor = Color.White;
            btnTampilkan.Location = new Point(632, 26);
            btnTampilkan.Name = "btnTampilkan";
            btnTampilkan.Size = new Size(113, 34);
            btnTampilkan.TabIndex = 20;
            btnTampilkan.Text = "Tampilkan";
            btnTampilkan.UseVisualStyleBackColor = false;
            // 
            // pnlHasil
            // 
            pnlHasil.BackColor = Color.White;
            pnlHasil.Controls.Add(label1);
            pnlHasil.Controls.Add(pnlTotal);
            pnlHasil.Location = new Point(196, 193);
            pnlHasil.Name = "pnlHasil";
            pnlHasil.Size = new Size(832, 182);
            pnlHasil.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(656, 33);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 23;
            label1.Text = "Rp";
            // 
            // pnlTotal
            // 
            pnlTotal.Controls.Add(lblTotalTeks);
            pnlTotal.Controls.Add(lblTotal);
            pnlTotal.Dock = DockStyle.Bottom;
            pnlTotal.Location = new Point(0, 138);
            pnlTotal.Name = "pnlTotal";
            pnlTotal.Size = new Size(832, 44);
            pnlTotal.TabIndex = 24;
            // 
            // lblTotalTeks
            // 
            lblTotalTeks.BackColor = Color.Transparent;
            lblTotalTeks.Dock = DockStyle.Right;
            lblTotalTeks.Font = new Font("Segoe UI", 9F);
            lblTotalTeks.ImageAlign = ContentAlignment.MiddleRight;
            lblTotalTeks.Location = new Point(492, 0);
            lblTotalTeks.Name = "lblTotalTeks";
            lblTotalTeks.Size = new Size(140, 44);
            lblTotalTeks.TabIndex = 22;
            lblTotalTeks.Text = "Total Pendapatan";
            lblTotalTeks.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Dock = DockStyle.Right;
            lblTotal.Font = new Font("Segoe UI", 13F);
            lblTotal.ForeColor = Color.FromArgb(47, 93, 58);
            lblTotal.Location = new Point(632, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(200, 44);
            lblTotal.TabIndex = 23;
            lblTotal.Text = "Rp 0";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            lblTotal.Click += lblTotal_Click;
            // 
            // lblJudulLaporan
            // 
            lblJudulLaporan.AutoSize = true;
            lblJudulLaporan.Location = new Point(246, 210);
            lblJudulLaporan.Name = "lblJudulLaporan";
            lblJudulLaporan.Size = new Size(127, 15);
            lblJudulLaporan.TabIndex = 23;
            lblJudulLaporan.Text = "Laporan Pendapatan ()";
            // 
            // lblJenis
            // 
            lblJenis.AutoSize = true;
            lblJenis.Location = new Point(218, 93);
            lblJenis.Name = "lblJenis";
            lblJenis.Size = new Size(78, 15);
            lblJenis.TabIndex = 24;
            lblJenis.Text = "Jenis Laporan";
            // 
            // lblAwal
            // 
            lblAwal.AutoSize = true;
            lblAwal.Location = new Point(238, 19);
            lblAwal.Name = "lblAwal";
            lblAwal.Size = new Size(76, 15);
            lblAwal.TabIndex = 25;
            lblAwal.Text = "Periode Awal";
            // 
            // lblAkhir
            // 
            lblAkhir.AutoSize = true;
            lblAkhir.Location = new Point(455, 19);
            lblAkhir.Name = "lblAkhir";
            lblAkhir.Size = new Size(78, 15);
            lblAkhir.TabIndex = 26;
            lblAkhir.Text = "Periode Akhir";
            // 
            // pnlFilter
            // 
            pnlFilter.BackColor = Color.White;
            pnlFilter.Controls.Add(lblAkhir);
            pnlFilter.Controls.Add(dtpAkhir);
            pnlFilter.Controls.Add(lblAwal);
            pnlFilter.Controls.Add(dtpAwal);
            pnlFilter.Controls.Add(btnTampilkan);
            pnlFilter.Location = new Point(196, 74);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(832, 93);
            pnlFilter.TabIndex = 27;
            // 
            // dtpAkhir
            // 
            dtpAkhir.Location = new Point(387, 40);
            dtpAkhir.Name = "dtpAkhir";
            dtpAkhir.Size = new Size(200, 23);
            dtpAkhir.TabIndex = 1;
            // 
            // dtpAwal
            // 
            dtpAwal.Location = new Point(180, 40);
            dtpAwal.Name = "dtpAwal";
            dtpAwal.Size = new Size(191, 23);
            dtpAwal.TabIndex = 0;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(247, 245, 238);
            pnlContent.Location = new Point(165, 59);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(24);
            pnlContent.Size = new Size(887, 433);
            pnlContent.TabIndex = 28;
            // 
            // formLaporan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1052, 492);
            Controls.Add(lblJenis);
            Controls.Add(lblJudulLaporan);
            Controls.Add(cmbJenis);
            Controls.Add(dgvLaporan);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlHeader);
            Controls.Add(pnlFilter);
            Controls.Add(pnlHasil);
            Controls.Add(pnlContent);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "formLaporan";
            Text = "formLaporan";
            Load += formLaporan_Load;
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLaporan).EndInit();
            pnlHasil.ResumeLayout(false);
            pnlHasil.PerformLayout();
            pnlTotal.ResumeLayout(false);
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSidebar;
        private Button btnLogout;
        private Button btnLaporan;
        private Button btnKelolaPengembalian;
        private Button btnKelolaSewa;
        private Button btnKelolaAlat;
        private Label lblLogo;
        private Button btnKelolaUser;
        private Button btnDashboard;
        private Label lblJudulHalaman;
        private Panel pnlHeader;
        private TextBox pnlUser;
        private DataGridView dgvLaporan;
        private ComboBox cmbJenis;
        private Button btnTampilkan;
        private Panel pnlHasil;
        private Label lblTotalTeks;
        private Label label1;
        private Label lblJudulLaporan;
        private Label lblJenis;
        private Label lblAwal;
        private Label lblAkhir;
        private Panel pnlFilter;
        private Panel pnlContent;
        private Panel pnlTotal;
        private Label lblTotal;
        private DateTimePicker dtpAkhir;
        private DateTimePicker dtpAwal;
    }
}