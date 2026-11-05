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
            panel1 = new Panel();
            btnLogout = new Button();
            btnUser = new Button();
            btnLaporan = new Button();
            btnPengembaian = new Button();
            btnSewa = new Button();
            btnAlat = new Button();
            btnDashboard = new Button();
            label1 = new Label();
            pnlUtama = new Panel();
            pnlIsi = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            lblPengguna = new Label();
            dgvSewa = new DataGridView();
            label3 = new Label();
            txtCari = new TextBox();
            lblCari = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtTerlambat = new TextBox();
            dtpKembali = new DateTimePicker();
            txtDenda = new TextBox();
            txtTotalDenda = new TextBox();
            chkAdaKerusakan = new CheckBox();
            txtDendaKerusakan = new TextBox();
            label9 = new Label();
            txtKeterangan = new TextBox();
            label10 = new Label();
            button1 = new Button();
            btnProses = new Button();
            btnCari = new Button();
            colPenyewa = new DataGridViewTextBoxColumn();
            colAlat = new DataGridViewTextBoxColumn();
            colMulai = new DataGridViewTextBoxColumn();
            colKembali = new DataGridViewTextBoxColumn();
            colKeterangan = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            pnlUtama.SuspendLayout();
            pnlIsi.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSewa).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(47, 93, 58);
            label2.Location = new Point(257, 18);
            label2.Name = "label2";
            label2.Size = new Size(430, 38);
            label2.TabIndex = 0;
            label2.Text = "Kelola Pengembalian dan Denda";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(47, 93, 58);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnUser);
            panel1.Controls.Add(btnLaporan);
            panel1.Controls.Add(btnPengembaian);
            panel1.Controls.Add(btnSewa);
            panel1.Controls.Add(btnAlat);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 633);
            panel1.TabIndex = 10;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 122, 60);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(9, 592);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(15, 0, 0, 0);
            btnLogout.Size = new Size(223, 29);
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
            btnUser.Location = new Point(0, 243);
            btnUser.Name = "btnUser";
            btnUser.Padding = new Padding(15, 0, 0, 0);
            btnUser.Size = new Size(250, 29);
            btnUser.TabIndex = 6;
            btnUser.Text = "Kelola user";
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
            btnPengembaian.ForeColor = Color.FromArgb(224, 224, 224);
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
            btnDashboard.Click += btnDashboard_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(50, 30, 30, 30);
            label1.Size = new Size(224, 98);
            label1.TabIndex = 1;
            label1.Text = "Agri-Rent";
            // 
            // pnlUtama
            // 
            pnlUtama.Controls.Add(pnlIsi);
            pnlUtama.Controls.Add(panel2);
            pnlUtama.Dock = DockStyle.Fill;
            pnlUtama.Location = new Point(0, 0);
            pnlUtama.Name = "pnlUtama";
            pnlUtama.Size = new Size(1082, 633);
            pnlUtama.TabIndex = 11;
            // 
            // pnlIsi
            // 
            pnlIsi.BackColor = Color.FromArgb(247, 245, 238);
            pnlIsi.Controls.Add(panel4);
            pnlIsi.Controls.Add(panel3);
            pnlIsi.Dock = DockStyle.Right;
            pnlIsi.Location = new Point(250, 78);
            pnlIsi.Name = "pnlIsi";
            pnlIsi.Padding = new Padding(24);
            pnlIsi.Size = new Size(832, 555);
            pnlIsi.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(btnProses);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(txtKeterangan);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(txtDendaKerusakan);
            panel4.Controls.Add(chkAdaKerusakan);
            panel4.Controls.Add(txtTotalDenda);
            panel4.Controls.Add(txtDenda);
            panel4.Controls.Add(dtpKembali);
            panel4.Controls.Add(txtTerlambat);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(27, 319);
            panel4.Name = "panel4";
            panel4.Size = new Size(778, 229);
            panel4.TabIndex = 1;
            panel4.Paint += panel4_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btnCari);
            panel3.Controls.Add(lblCari);
            panel3.Controls.Add(txtCari);
            panel3.Controls.Add(dgvSewa);
            panel3.Location = new Point(27, 27);
            panel3.Name = "panel3";
            panel3.Size = new Size(778, 281);
            panel3.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lblPengguna);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1082, 78);
            panel2.TabIndex = 0;
            // 
            // lblPengguna
            // 
            lblPengguna.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPengguna.AutoSize = true;
            lblPengguna.Location = new Point(1537, 30);
            lblPengguna.Name = "lblPengguna";
            lblPengguna.Size = new Size(165, 20);
            lblPengguna.TabIndex = 1;
            lblPengguna.Text = "Masuk sebagai: Petugas";
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
            dgvSewa.EnableHeadersVisualStyles = false;
            dgvSewa.GridColor = Color.FromArgb(236, 232, 218);
            dgvSewa.Location = new Point(24, 51);
            dgvSewa.MultiSelect = false;
            dgvSewa.Name = "dgvSewa";
            dgvSewa.ReadOnly = true;
            dgvSewa.RowHeadersVisible = false;
            dgvSewa.RowHeadersWidth = 51;
            dgvSewa.RowTemplate.Height = 34;
            dgvSewa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSewa.Size = new Size(730, 217);
            dgvSewa.TabIndex = 12;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(890, 32);
            label3.Name = "label3";
            label3.Size = new Size(165, 20);
            label3.TabIndex = 2;
            label3.Text = "Masuk sebagai: Petugas";
            // 
            // txtCari
            // 
            txtCari.Location = new Point(172, 15);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(149, 27);
            txtCari.TabIndex = 13;
            // 
            // lblCari
            // 
            lblCari.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCari.AutoSize = true;
            lblCari.Location = new Point(24, 18);
            lblCari.Name = "lblCari";
            lblCari.Size = new Size(142, 20);
            lblCari.TabIndex = 3;
            lblCari.Text = "Cari nama penyewa:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(29, 14);
            label4.Name = "label4";
            label4.Size = new Size(147, 20);
            label4.TabIndex = 14;
            label4.Text = "Detail Pengembalian";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(29, 48);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 15;
            label5.Text = "Tangal Kembali";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(219, 47);
            label6.Name = "label6";
            label6.Size = new Size(106, 20);
            label6.TabIndex = 16;
            label6.Text = "Hari terlambat";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(403, 48);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 17;
            label7.Text = "Denda";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(593, 50);
            label8.Name = "label8";
            label8.Size = new Size(88, 20);
            label8.TabIndex = 18;
            label8.Text = "Total denda";
            // 
            // txtTerlambat
            // 
            txtTerlambat.Location = new Point(217, 74);
            txtTerlambat.Name = "txtTerlambat";
            txtTerlambat.ReadOnly = true;
            txtTerlambat.Size = new Size(137, 27);
            txtTerlambat.TabIndex = 14;
            // 
            // dtpKembali
            // 
            dtpKembali.Format = DateTimePickerFormat.Short;
            dtpKembali.Location = new Point(33, 74);
            dtpKembali.Name = "dtpKembali";
            dtpKembali.Size = new Size(158, 27);
            dtpKembali.TabIndex = 19;
            // 
            // txtDenda
            // 
            txtDenda.Location = new Point(403, 73);
            txtDenda.Name = "txtDenda";
            txtDenda.ReadOnly = true;
            txtDenda.Size = new Size(137, 27);
            txtDenda.TabIndex = 20;
            // 
            // txtTotalDenda
            // 
            txtTotalDenda.Location = new Point(593, 73);
            txtTotalDenda.Name = "txtTotalDenda";
            txtTotalDenda.ReadOnly = true;
            txtTotalDenda.Size = new Size(137, 27);
            txtTotalDenda.TabIndex = 21;
            // 
            // chkAdaKerusakan
            // 
            chkAdaKerusakan.AutoSize = true;
            chkAdaKerusakan.Enabled = false;
            chkAdaKerusakan.Location = new Point(35, 153);
            chkAdaKerusakan.Name = "chkAdaKerusakan";
            chkAdaKerusakan.Size = new Size(127, 24);
            chkAdaKerusakan.TabIndex = 22;
            chkAdaKerusakan.Text = "Ada kerusakan";
            chkAdaKerusakan.UseVisualStyleBackColor = true;
            // 
            // txtDendaKerusakan
            // 
            txtDendaKerusakan.Location = new Point(217, 152);
            txtDendaKerusakan.Name = "txtDendaKerusakan";
            txtDendaKerusakan.Size = new Size(137, 27);
            txtDendaKerusakan.TabIndex = 23;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(217, 118);
            label9.Name = "label9";
            label9.Size = new Size(122, 20);
            label9.TabIndex = 24;
            label9.Text = "Denda kerusakan";
            // 
            // txtKeterangan
            // 
            txtKeterangan.Location = new Point(403, 152);
            txtKeterangan.Name = "txtKeterangan";
            txtKeterangan.Size = new Size(327, 27);
            txtKeterangan.TabIndex = 25;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(403, 118);
            label10.Name = "label10";
            label10.Size = new Size(85, 20);
            label10.TabIndex = 26;
            label10.Text = "Keterangan";
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnProses
            // 
            btnProses.BackColor = Color.FromArgb(0, 192, 0);
            btnProses.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            btnProses.Location = new Point(570, 185);
            btnProses.Name = "btnProses";
            btnProses.Size = new Size(160, 39);
            btnProses.TabIndex = 27;
            btnProses.Text = "Submit";
            btnProses.UseVisualStyleBackColor = false;
            // 
            // btnCari
            // 
            btnCari.BackColor = Color.FromArgb(0, 192, 0);
            btnCari.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            btnCari.Location = new Point(352, 9);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(58, 39);
            btnCari.TabIndex = 28;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = false;
            // 
            // colPenyewa
            // 
            colPenyewa.HeaderText = "penyewa";
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
            colKembali.HeaderText = "Kembali";
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
            // formKelolaPengembalian
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 633);
            Controls.Add(panel1);
            Controls.Add(pnlUtama);
            Name = "formKelolaPengembalian";
            Text = "formKelolaPengembalian";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlUtama.ResumeLayout(false);
            pnlIsi.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSewa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Panel panel1;
        private Button btnLogout;
        private Button btnUser;
        private Button btnLaporan;
        private Button btnPengembaian;
        private Button btnSewa;
        private Button btnAlat;
        private Button btnDashboard;
        private Label label1;
        private Panel pnlUtama;
        private Panel pnlIsi;
        private Panel panel2;
        private Label lblPengguna;
        private Panel panel4;
        private Panel panel3;
        private DataGridView dgvSewa;
        private TextBox txtCari;
        private Label label3;
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
        private Button button1;
        private Button btnCari;
        private DataGridViewTextBoxColumn colPenyewa;
        private DataGridViewTextBoxColumn colAlat;
        private DataGridViewTextBoxColumn colMulai;
        private DataGridViewTextBoxColumn colKembali;
        private DataGridViewTextBoxColumn colKeterangan;
    }
}