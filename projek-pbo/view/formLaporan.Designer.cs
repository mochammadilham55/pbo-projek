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
            panel1 = new Panel();
            btnDashboard = new Button();
            btnLogout = new Button();
            lblHalaman = new Label();
            btnKelolaUser = new Button();
            btnLaporan = new Button();
            btnKelolaPengembalian = new Button();
            btnKelolaSewa = new Button();
            btnKelolaAlat = new Button();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            txtsbg = new TextBox();
            dgvAlat = new DataGridView();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(47, 93, 58);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(lblHalaman);
            panel1.Controls.Add(btnKelolaUser);
            panel1.Controls.Add(btnLaporan);
            panel1.Controls.Add(btnKelolaPengembalian);
            panel1.Controls.Add(btnKelolaSewa);
            panel1.Controls.Add(btnKelolaAlat);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(171, 492);
            panel1.TabIndex = 5;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(12, 74);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(105, 23);
            btnDashboard.TabIndex = 6;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Brown;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 122, 60);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(12, 439);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(147, 33);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblHalaman
            // 
            lblHalaman.AutoSize = true;
            lblHalaman.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHalaman.ForeColor = SystemColors.ControlLightLight;
            lblHalaman.Location = new Point(42, 35);
            lblHalaman.Name = "lblHalaman";
            lblHalaman.Size = new Size(0, 25);
            lblHalaman.TabIndex = 7;
            lblHalaman.Click += lblHalaman_Click;
            // 
            // btnKelolaUser
            // 
            btnKelolaUser.BackColor = Color.Transparent;
            btnKelolaUser.FlatAppearance.BorderSize = 0;
            btnKelolaUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 122, 60);
            btnKelolaUser.FlatStyle = FlatStyle.Flat;
            btnKelolaUser.ForeColor = Color.White;
            btnKelolaUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnKelolaUser.Location = new Point(1, 259);
            btnKelolaUser.Margin = new Padding(3, 2, 3, 2);
            btnKelolaUser.Name = "btnKelolaUser";
            btnKelolaUser.Padding = new Padding(13, 0, 0, 0);
            btnKelolaUser.Size = new Size(118, 22);
            btnKelolaUser.TabIndex = 6;
            btnKelolaUser.Text = "Kelola user";
            btnKelolaUser.TextAlign = ContentAlignment.MiddleLeft;
            btnKelolaUser.UseVisualStyleBackColor = false;
            btnKelolaUser.UseWaitCursor = true;
            // 
            // btnLaporan
            // 
            btnLaporan.BackColor = Color.Transparent;
            btnLaporan.FlatAppearance.BorderSize = 0;
            btnLaporan.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 122, 60);
            btnLaporan.FlatStyle = FlatStyle.Flat;
            btnLaporan.ForeColor = Color.White;
            btnLaporan.ImageAlign = ContentAlignment.MiddleLeft;
            btnLaporan.Location = new Point(1, 220);
            btnLaporan.Margin = new Padding(3, 2, 3, 2);
            btnLaporan.Name = "btnLaporan";
            btnLaporan.Padding = new Padding(13, 0, 0, 0);
            btnLaporan.Size = new Size(118, 22);
            btnLaporan.TabIndex = 5;
            btnLaporan.Text = "Laporan";
            btnLaporan.TextAlign = ContentAlignment.MiddleLeft;
            btnLaporan.UseVisualStyleBackColor = false;
            btnLaporan.UseWaitCursor = true;
            // 
            // btnKelolaPengembalian
            // 
            btnKelolaPengembalian.BackColor = Color.Transparent;
            btnKelolaPengembalian.FlatAppearance.BorderSize = 0;
            btnKelolaPengembalian.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 122, 60);
            btnKelolaPengembalian.FlatStyle = FlatStyle.Flat;
            btnKelolaPengembalian.ForeColor = Color.FromArgb(224, 224, 224);
            btnKelolaPengembalian.ImageAlign = ContentAlignment.MiddleLeft;
            btnKelolaPengembalian.Location = new Point(0, 180);
            btnKelolaPengembalian.Margin = new Padding(3, 2, 3, 2);
            btnKelolaPengembalian.Name = "btnKelolaPengembalian";
            btnKelolaPengembalian.Padding = new Padding(13, 0, 0, 0);
            btnKelolaPengembalian.Size = new Size(144, 27);
            btnKelolaPengembalian.TabIndex = 4;
            btnKelolaPengembalian.Text = "Kelola Pengembalian";
            btnKelolaPengembalian.TextAlign = ContentAlignment.MiddleLeft;
            btnKelolaPengembalian.UseVisualStyleBackColor = false;
            btnKelolaPengembalian.UseWaitCursor = true;
            btnKelolaPengembalian.Click += btnKelolaPengembalian_Click;
            // 
            // btnKelolaSewa
            // 
            btnKelolaSewa.BackColor = Color.Transparent;
            btnKelolaSewa.FlatAppearance.BorderSize = 0;
            btnKelolaSewa.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 122, 60);
            btnKelolaSewa.FlatStyle = FlatStyle.Flat;
            btnKelolaSewa.ForeColor = Color.White;
            btnKelolaSewa.ImageAlign = ContentAlignment.MiddleLeft;
            btnKelolaSewa.Location = new Point(0, 145);
            btnKelolaSewa.Margin = new Padding(3, 2, 3, 2);
            btnKelolaSewa.Name = "btnKelolaSewa";
            btnKelolaSewa.Padding = new Padding(13, 0, 0, 0);
            btnKelolaSewa.Size = new Size(118, 22);
            btnKelolaSewa.TabIndex = 3;
            btnKelolaSewa.Text = "Kelola Sewa";
            btnKelolaSewa.TextAlign = ContentAlignment.MiddleLeft;
            btnKelolaSewa.UseVisualStyleBackColor = false;
            btnKelolaSewa.UseWaitCursor = true;
            // 
            // btnKelolaAlat
            // 
            btnKelolaAlat.BackColor = Color.Transparent;
            btnKelolaAlat.FlatAppearance.BorderSize = 0;
            btnKelolaAlat.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 122, 60);
            btnKelolaAlat.FlatStyle = FlatStyle.Flat;
            btnKelolaAlat.ForeColor = Color.White;
            btnKelolaAlat.ImageAlign = ContentAlignment.MiddleLeft;
            btnKelolaAlat.Location = new Point(0, 109);
            btnKelolaAlat.Margin = new Padding(3, 2, 3, 2);
            btnKelolaAlat.Name = "btnKelolaAlat";
            btnKelolaAlat.Padding = new Padding(13, 0, 0, 0);
            btnKelolaAlat.Size = new Size(118, 22);
            btnKelolaAlat.TabIndex = 2;
            btnKelolaAlat.Text = "Kelola alat";
            btnKelolaAlat.TextAlign = ContentAlignment.MiddleLeft;
            btnKelolaAlat.UseVisualStyleBackColor = false;
            btnKelolaAlat.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(11, 21);
            label1.Name = "label1";
            label1.Size = new Size(113, 30);
            label1.TabIndex = 1;
            label1.Text = "Agri-Rent";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(208, 8);
            label2.Name = "label2";
            label2.Size = new Size(118, 30);
            label2.TabIndex = 6;
            label2.Text = "Dashboard";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(txtsbg);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1055, 59);
            panel2.TabIndex = 7;
            // 
            // txtsbg
            // 
            txtsbg.BackColor = SystemColors.Control;
            txtsbg.Cursor = Cursors.Cross;
            txtsbg.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtsbg.Location = new Point(874, 15);
            txtsbg.Name = "txtsbg";
            txtsbg.Size = new Size(166, 23);
            txtsbg.TabIndex = 7;
            txtsbg.Text = "Masuk sebagai :";
            txtsbg.TextChanged += textBox1_TextChanged;
            // 
            // dgvAlat
            // 
            dgvAlat.BackgroundColor = SystemColors.Control;
            dgvAlat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlat.Location = new Point(200, 85);
            dgvAlat.Name = "dgvAlat";
            dgvAlat.Size = new Size(830, 82);
            dgvAlat.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(200, 204);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(830, 121);
            dataGridView1.TabIndex = 12;
            // 
            // formLaporan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1052, 492);
            Controls.Add(dataGridView1);
            Controls.Add(dgvAlat);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "formLaporan";
            Text = "formLaporan";
            Load += formLaporan_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnLogout;
        private Label lblHalaman;
        private Button btnLaporan;
        private Button btnKelolaPengembalian;
        private Button btnKelolaSewa;
        private Button btnKelolaAlat;
        private Label label1;
        private Button btnKelolaUser;
        private Button btnDashboard;
        private Label label2;
        private Panel panel2;
        private TextBox txtsbg;
        private DataGridView dgvAlat;
        private DataGridView dataGridView1;
    }
}