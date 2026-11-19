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
            pnlJarak = new Panel();
            pnlSidebar.SuspendLayout();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLaporan).BeginInit();
            pnlHasil.SuspendLayout();
            pnlTotal.SuspendLayout();
            pnlFilter.SuspendLayout();
            pnlContent.SuspendLayout();
            SuspendLayout();
            //
            // pnlSidebar
            //
            pnlSidebar.BackColor = Color.FromArgb(47, 93, 58);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnKelolaUser);
            pnlSidebar.Controls.Add(btnLaporan);
            pnlSidebar.Controls.Add(btnKelolaPengembalian);
            pnlSidebar.Controls.Add(btnKelolaSewa);
            pnlSidebar.Controls.Add(btnKelolaAlat);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(lblLogo);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(219, 540);
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
            btnLogout.Location = new Point(10, 504);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(198, 26);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            //
            // btnKelolaUser
            //
            btnKelolaUser.Dock = DockStyle.Top;
            btnKelolaUser.FlatAppearance.BorderSize = 0;
            btnKelolaUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 122, 60);
            btnKelolaUser.FlatStyle = FlatStyle.Flat;
            btnKelolaUser.ForeColor = Color.White;
            btnKelolaUser.Location = new Point(0, 208);
            btnKelolaUser.Name = "btnKelolaUser";
            btnKelolaUser.Padding = new Padding(26, 0, 0, 0);
            btnKelolaUser.Size = new Size(219, 27);
            btnKelolaUser.TabIndex = 6;
            btnKelolaUser.Text = "Kelola User";
            btnKelolaUser.TextAlign = ContentAlignment.MiddleLeft;
            btnKelolaUser.UseVisualStyleBackColor = true;
            //
            // btnLaporan
            //
            btnLaporan.BackColor = Color.FromArgb(62, 122, 60);
            btnLaporan.Dock = DockStyle.Top;
            btnLaporan.FlatAppearance.BorderSize = 0;
            btnLaporan.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 122, 60);
            btnLaporan.FlatStyle = FlatStyle.Flat;
            btnLaporan.ForeColor = Color.White;
            btnLaporan.Location = new Point(0, 182);
            btnLaporan.Name = "btnLaporan";
            btnLaporan.Padding = new Padding(26, 0, 0, 0);
            btnLaporan.Size = new Size(219, 27);
            btnLaporan.TabIndex = 5;
            btnLaporan.Text = "Laporan";
            btnLaporan.TextAlign = ContentAlignment.MiddleLeft;
            btnLaporan.UseVisualStyleBackColor = false;
            //
            // btnKelolaPengembalian
            //
            btnKelolaPengembalian.Dock = DockStyle.Top;
            btnKelolaPengembalian.FlatAppearance.BorderSize = 0;
            btnKelolaPengembalian.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 122, 60);
            btnKelolaPengembalian.FlatStyle = FlatStyle.Flat;
            btnKelolaPengembalian.ForeColor = Color.White;
            btnKelolaPengembalian.Location = new Point(0, 154);
            btnKelolaPengembalian.Name = "btnKelolaPengembalian";
            btnKelolaPengembalian.Padding = new Padding(26, 0, 0, 0);
            btnKelolaPengembalian.Size = new Size(219, 27);
            btnKelolaPengembalian.TabIndex = 4;
            btnKelolaPengembalian.Text = "Kelola Pengembalian";
            btnKelolaPengembalian.TextAlign = ContentAlignment.MiddleLeft;
            btnKelolaPengembalian.UseVisualStyleBackColor = true;
            //
            // btnKelolaSewa
            //
            btnKelolaSewa.Dock = DockStyle.Top;
            btnKelolaSewa.FlatAppearance.BorderSize = 0;
            btnKelolaSewa.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 122, 60);
            btnKelolaSewa.FlatStyle = FlatStyle.Flat;
            btnKelolaSewa.ForeColor = Color.White;
            btnKelolaSewa.Location = new Point(0, 128);
            btnKelolaSewa.Name = "btnKelolaSewa";
            btnKelolaSewa.Padding = new Padding(26, 0, 0, 0);
            btnKelolaSewa.Size = new Size(219, 27);
            btnKelolaSewa.TabIndex = 3;
            btnKelolaSewa.Text = "Kelola Sewa";
            btnKelolaSewa.TextAlign = ContentAlignment.MiddleLeft;
            btnKelolaSewa.UseVisualStyleBackColor = true;
            //
            // btnKelolaAlat
            //
            btnKelolaAlat.Dock = DockStyle.Top;
            btnKelolaAlat.FlatAppearance.BorderSize = 0;
            btnKelolaAlat.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 122, 60);
            btnKelolaAlat.FlatStyle = FlatStyle.Flat;
            btnKelolaAlat.ForeColor = Color.White;
            btnKelolaAlat.Location = new Point(0, 100);
            btnKelolaAlat.Name = "btnKelolaAlat";
            btnKelolaAlat.Padding = new Padding(26, 0, 0, 0);
            btnKelolaAlat.Size = new Size(219, 27);
            btnKelolaAlat.TabIndex = 2;
            btnKelolaAlat.Text = "Kelola Alat";
            btnKelolaAlat.TextAlign = ContentAlignment.MiddleLeft;
            btnKelolaAlat.UseVisualStyleBackColor = true;
            //
            // btnDashboard
            //
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 122, 60);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 74);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(26, 0, 0, 0);
            btnDashboard.Size = new Size(219, 27);
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
            lblLogo.Padding = new Padding(44, 22, 26, 22);
            lblLogo.Size = new Size(196, 74);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "Agri-Rent";
            //
            // pnlHeader
            //
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(pnlUser);
            pnlHeader.Controls.Add(lblJudulHalaman);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(219, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(881, 59);
            pnlHeader.TabIndex = 7;
            //
            // lblJudulHalaman
            //
            lblJudulHalaman.AutoSize = true;
            lblJudulHalaman.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJudulHalaman.ForeColor = Color.FromArgb(47, 93, 58);
            lblJudulHalaman.Location = new Point(34, 14);
            lblJudulHalaman.Name = "lblJudulHalaman";
            lblJudulHalaman.Size = new Size(91, 30);
            lblJudulHalaman.TabIndex = 6;
            lblJudulHalaman.Text = "Laporan";
            //
            // pnlUser
            //
            pnlUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlUser.BackColor = Color.White;
            pnlUser.BorderStyle = BorderStyle.None;
            pnlUser.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlUser.Location = new Point(681, 22);
            pnlUser.Name = "pnlUser";
            pnlUser.ReadOnly = true;
            pnlUser.Size = new Size(166, 16);
            pnlUser.TabIndex = 7;
            pnlUser.TabStop = false;
            pnlUser.Text = "Masuk sebagai :";
            pnlUser.TextAlign = HorizontalAlignment.Right;
            pnlUser.TextChanged += textBox1_TextChanged;
            //
            // pnlContent
            //
            pnlContent.BackColor = Color.FromArgb(247, 245, 238);
            pnlContent.Controls.Add(pnlHasil);
            pnlContent.Controls.Add(pnlJarak);
            pnlContent.Controls.Add(pnlFilter);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(219, 59);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(39, 15, 39, 22);
            pnlContent.Size = new Size(881, 541);
            pnlContent.TabIndex = 28;
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
            pnlFilter.Location = new Point(39, 15);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(803, 72);
            pnlFilter.TabIndex = 27;
            //
            // lblJenis
            //
            lblJenis.AutoSize = true;
            lblJenis.Location = new Point(18, 12);
            lblJenis.Name = "lblJenis";
            lblJenis.Size = new Size(78, 15);
            lblJenis.TabIndex = 24;
            lblJenis.Text = "Jenis Laporan";
            //
            // cmbJenis
            //
            cmbJenis.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJenis.FormattingEnabled = true;
            cmbJenis.Items.AddRange(new object[] { "Laporan Pendapatan", "Laporan Pengeluaran", "Grafik", "" });
            cmbJenis.Location = new Point(18, 32);
            cmbJenis.Name = "cmbJenis";
            cmbJenis.Size = new Size(180, 23);
            cmbJenis.TabIndex = 0;
            //
            // lblAwal
            //
            lblAwal.AutoSize = true;
            lblAwal.Location = new Point(218, 12);
            lblAwal.Name = "lblAwal";
            lblAwal.Size = new Size(76, 15);
            lblAwal.TabIndex = 25;
            lblAwal.Text = "Periode Awal";
            //
            // dtpAwal
            //
            dtpAwal.Location = new Point(218, 32);
            dtpAwal.Name = "dtpAwal";
            dtpAwal.Size = new Size(190, 23);
            dtpAwal.TabIndex = 1;
            //
            // lblAkhir
            //
            lblAkhir.AutoSize = true;
            lblAkhir.Location = new Point(428, 12);
            lblAkhir.Name = "lblAkhir";
            lblAkhir.Size = new Size(78, 15);
            lblAkhir.TabIndex = 26;
            lblAkhir.Text = "Periode Akhir";
            //
            // dtpAkhir
            //
            dtpAkhir.Location = new Point(428, 32);
            dtpAkhir.Name = "dtpAkhir";
            dtpAkhir.Size = new Size(190, 23);
            dtpAkhir.TabIndex = 2;
            //
            // btnTampilkan
            //
            btnTampilkan.BackColor = Color.FromArgb(62, 122, 60);
            btnTampilkan.FlatAppearance.BorderSize = 0;
            btnTampilkan.FlatStyle = FlatStyle.Flat;
            btnTampilkan.ForeColor = Color.White;
            btnTampilkan.Location = new Point(638, 30);
            btnTampilkan.Name = "btnTampilkan";
            btnTampilkan.Size = new Size(110, 26);
            btnTampilkan.TabIndex = 3;
            btnTampilkan.Text = "Tampilkan";
            btnTampilkan.UseVisualStyleBackColor = false;
            //
            // pnlJarak
            //
            pnlJarak.Dock = DockStyle.Top;
            pnlJarak.Location = new Point(39, 87);
            pnlJarak.Name = "pnlJarak";
            pnlJarak.Size = new Size(803, 15);
            pnlJarak.TabIndex = 29;
            //
            // pnlHasil
            //
            pnlHasil.BackColor = Color.White;
            pnlHasil.Controls.Add(dgvLaporan);
            pnlHasil.Controls.Add(pnlTotal);
            pnlHasil.Controls.Add(lblJudulLaporan);
            pnlHasil.Dock = DockStyle.Fill;
            pnlHasil.Location = new Point(39, 102);
            pnlHasil.Name = "pnlHasil";
            pnlHasil.Padding = new Padding(13, 8, 13, 0);
            pnlHasil.Size = new Size(803, 417);
            pnlHasil.TabIndex = 21;
            //
            // lblJudulLaporan
            //
            lblJudulLaporan.Dock = DockStyle.Top;
            lblJudulLaporan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblJudulLaporan.ForeColor = Color.FromArgb(47, 93, 58);
            lblJudulLaporan.Location = new Point(13, 8);
            lblJudulLaporan.Name = "lblJudulLaporan";
            lblJudulLaporan.Size = new Size(777, 26);
            lblJudulLaporan.TabIndex = 23;
            lblJudulLaporan.Text = "Laporan Pendapatan ()";
            lblJudulLaporan.TextAlign = ContentAlignment.MiddleLeft;
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
            dgvLaporan.Dock = DockStyle.Fill;
            dgvLaporan.Location = new Point(13, 34);
            dgvLaporan.MultiSelect = false;
            dgvLaporan.Name = "dgvLaporan";
            dgvLaporan.ReadOnly = true;
            dgvLaporan.RowHeadersVisible = false;
            dgvLaporan.RowTemplate.Height = 32;
            dgvLaporan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLaporan.Size = new Size(777, 339);
            dgvLaporan.TabIndex = 12;
            // 
            // pnlTotal
            // 
            pnlTotal.Controls.Add(lblTotalTeks);
            pnlTotal.Controls.Add(lblTotal);
            pnlTotal.Dock = DockStyle.Bottom;
            pnlTotal.Location = new Point(13, 373);
            pnlTotal.Name = "pnlTotal";
            pnlTotal.Size = new Size(777, 44);
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
            // formLaporan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 245, 238);
            ClientSize = new Size(1100, 600);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(1150, 680);
            Name = "formLaporan";
            Text = "Laporan - Agri-Rent";
            Load += formLaporan_Load;
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLaporan).EndInit();
            pnlHasil.ResumeLayout(false);
            pnlTotal.ResumeLayout(false);
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            pnlContent.ResumeLayout(false);
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
        private Panel pnlJarak;
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