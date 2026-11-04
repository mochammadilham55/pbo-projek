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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            btnDashboard = new Button();
            btnAlat = new Button();
            btnSewa = new Button();
            btnPengembaian = new Button();
            btnLaporan = new Button();
            btnUser = new Button();
            dgvTransaksi = new DataGridView();
            panel2 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            label3 = new Label();
            label4 = new Label();
            lbl = new Label();
            lblAlat = new Label();
            lblSewa = new Label();
            lblTelat = new Label();
            lblPendapatan = new Label();
            lblHalaman = new Label();
            btnLogout = new Button();
            Tanggal = new DataGridViewTextBoxColumn();
            Penyewa = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaksi).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(47, 93, 58);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(lblHalaman);
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
            panel1.Size = new Size(250, 657);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(48, 9);
            label1.Name = "label1";
            label1.Size = new Size(144, 38);
            label1.TabIndex = 1;
            label1.Text = "Agri-Rent";
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
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnAlat
            // 
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
            btnAlat.UseVisualStyleBackColor = true;
            btnAlat.Click += btnAlat_Click;
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
            btnSewa.Click += btnSewa_Click;
            // 
            // btnPengembaian
            // 
            btnPengembaian.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 122, 60);
            btnPengembaian.FlatStyle = FlatStyle.Flat;
            btnPengembaian.ForeColor = Color.FromArgb(224, 224, 224);
            btnPengembaian.Location = new Point(11, 246);
            btnPengembaian.Name = "btnPengembaian";
            btnPengembaian.Padding = new Padding(15, 0, 0, 0);
            btnPengembaian.Size = new Size(222, 29);
            btnPengembaian.TabIndex = 4;
            btnPengembaian.Text = "Kelola Pengembalian";
            btnPengembaian.TextAlign = ContentAlignment.MiddleLeft;
            btnPengembaian.UseVisualStyleBackColor = true;
            btnPengembaian.Click += btnPengembaian_Click;
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
            btnLaporan.Click += btnLaporan_Click;
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
            btnUser.Click += btnUser_Click;
            // 
            // dgvTransaksi
            // 
            dgvTransaksi.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(239, 236, 225);
            dgvTransaksi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransaksi.BackgroundColor = Color.White;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(62, 122, 60);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvTransaksi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransaksi.Columns.AddRange(new DataGridViewColumn[] { Tanggal, Penyewa, Column3, Column1, Column2, Column4 });
            dgvTransaksi.EnableHeadersVisualStyles = false;
            dgvTransaksi.GridColor = Color.FromArgb(220, 215, 200);
            dgvTransaksi.Location = new Point(251, 171);
            dgvTransaksi.Name = "dgvTransaksi";
            dgvTransaksi.ReadOnly = true;
            dgvTransaksi.RowHeadersVisible = false;
            dgvTransaksi.RowHeadersWidth = 51;
            dgvTransaksi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransaksi.Size = new Size(1157, 486);
            dgvTransaksi.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(62, 122, 60);
            panel2.Controls.Add(lblAlat);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(271, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 125);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(225, 225, 225);
            label2.Location = new Point(65, 14);
            label2.Name = "label2";
            label2.Size = new Size(113, 23);
            label2.TabIndex = 0;
            label2.Text = "Alat Tersedia";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 165, 38);
            panel3.Controls.Add(lblSewa);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(563, 26);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 125);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(179, 65, 47);
            panel4.Controls.Add(lblTelat);
            panel4.Controls.Add(lbl);
            panel4.Location = new Point(855, 26);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 125);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(139, 94, 52);
            panel5.Controls.Add(lblPendapatan);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(1146, 26);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 125);
            panel5.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(139, 94, 52);
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(225, 225, 225);
            label3.Location = new Point(40, 15);
            label3.Name = "label3";
            label3.Size = new Size(179, 23);
            label3.TabIndex = 1;
            label3.Text = "Pendapatan Bulan Ini";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(225, 225, 225);
            label4.Location = new Point(78, 14);
            label4.Name = "label4";
            label4.Size = new Size(98, 23);
            label4.TabIndex = 1;
            label4.Text = "Sewa Aktif";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl.ForeColor = Color.FromArgb(225, 225, 225);
            lbl.Location = new Point(53, 14);
            lbl.Name = "lbl";
            lbl.Size = new Size(138, 23);
            lbl.TabIndex = 2;
            lbl.Text = "Sewa Terlambat";
            // 
            // lblAlat
            // 
            lblAlat.AutoSize = true;
            lblAlat.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlat.Location = new Point(90, 47);
            lblAlat.Name = "lblAlat";
            lblAlat.Size = new Size(46, 54);
            lblAlat.TabIndex = 1;
            lblAlat.Text = "0";
            // 
            // lblSewa
            // 
            lblSewa.AutoSize = true;
            lblSewa.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSewa.Location = new Point(101, 47);
            lblSewa.Name = "lblSewa";
            lblSewa.Size = new Size(46, 54);
            lblSewa.TabIndex = 2;
            lblSewa.Text = "0";
            // 
            // lblTelat
            // 
            lblTelat.AutoSize = true;
            lblTelat.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelat.Location = new Point(93, 47);
            lblTelat.Name = "lblTelat";
            lblTelat.Size = new Size(46, 54);
            lblTelat.TabIndex = 3;
            lblTelat.Text = "0";
            // 
            // lblPendapatan
            // 
            lblPendapatan.AutoSize = true;
            lblPendapatan.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendapatan.Location = new Point(67, 47);
            lblPendapatan.Name = "lblPendapatan";
            lblPendapatan.Size = new Size(124, 54);
            lblPendapatan.TabIndex = 4;
            lblPendapatan.Text = "Rp0,-";
            // 
            // lblHalaman
            // 
            lblHalaman.AutoSize = true;
            lblHalaman.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHalaman.ForeColor = SystemColors.ControlLightLight;
            lblHalaman.Location = new Point(48, 47);
            lblHalaman.Name = "lblHalaman";
            lblHalaman.Size = new Size(130, 31);
            lblHalaman.TabIndex = 7;
            lblHalaman.Text = "Dashboard";
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 122, 60);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(10, 616);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(15, 0, 0, 0);
            btnLogout.Size = new Size(92, 29);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += button1_Click;
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
            // formDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 245, 238);
            ClientSize = new Size(1408, 657);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(dgvTransaksi);
            Controls.Add(panel1);
            Name = "formDashboard";
            Text = "formDashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaksi).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnUser;
        private Button btnLaporan;
        private Button btnPengembaian;
        private Button btnSewa;
        private Button btnAlat;
        private Button btnDashboard;
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
        private Button btnLogout;
        private Label lblHalaman;
        private DataGridViewTextBoxColumn Tanggal;
        private DataGridViewTextBoxColumn Penyewa;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
    }
}