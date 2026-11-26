
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using projek_pbo.model;
using projek_pbo.controller;
using projek_pbo.repository;

namespace projek_pbo.view
{
    public partial class formKelolaSewa : Form
    {
        private readonly c_Penyewaan controller =
            new c_Penyewaan();

        private readonly CultureInfo indonesia =
            CultureInfo.GetCultureInfo("id-ID");

        private TextBox txtNama = new TextBox();
        private TextBox txtTelepon = new TextBox();
        private TextBox txtAlamat = new TextBox();

        private ComboBox cboAlat = new ComboBox();
        private ComboBox cboMetode = new ComboBox();

        private DateTimePicker dtpMulai =
            new DateTimePicker();

        private DateTimePicker dtpKembali =
            new DateTimePicker();

        private NumericUpDown nudDiterima =
            new NumericUpDown();

        private TextBox txtBank = new TextBox();
        private TextBox txtReferensi = new TextBox();

        private Label lblDurasi = new Label();
        private Label lblBiayaDasar = new Label();
        private Label lblDiskon = new Label();
        private Label lblTotal = new Label();

        private DataGridView dgvSewa =
            new DataGridView();

        private Button btnSimpan = new Button();

        public formKelolaSewa()
        
        {
            InitializeComponent();
            InisialisasiMetodePembayaran();
            cboMetode.SelectedIndexChanged += (sender, e) => 
            Navigasi.PasangSidebar(
                this,
                btnDashboard,
                btnAlat,
                btnSewa,
                btnPengembaian,
                btnLaporan,
                btnUser,
                btnLogout,
                lblPengguna);

            BuatTampilan();
            AturEvent();
            AturMetodePembayaran();

            MuatAlat();
            MuatDaftarSewa();
            HitungBiaya();
        }

        private void BuatTampilan()
        {
            pnlIsi.Controls.Clear();

            var root = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 2,
                Padding = new Padding(4),
                BackColor = Color.FromArgb(247, 245, 238)
            };

            root.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 72));

            root.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 28));

            root.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 245));

            root.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100));

            pnlIsi.Controls.Add(root);

            // FORM INPUT
            var panelForm = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Padding = new Padding(10),
                Margin = new Padding(4)
            };

            root.Controls.Add(panelForm, 0, 0);

            var judulForm = new Label
            {
                Text = "Data Penyewaan",
                Font = new Font(
                    "Segoe UI", 11, FontStyle.Bold),
                Dock = DockStyle.Top,
                Height = 30
            };

            var tabelInput = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 3,
                RowCount = 3
            };

            for (int i = 0; i < 3; i++)
            {
                tabelInput.ColumnStyles.Add(
                    new ColumnStyle(
                        SizeType.Percent, 33.33f));

                tabelInput.RowStyles.Add(
                    new RowStyle(
                        SizeType.Percent, 33.33f));
            }

            panelForm.Controls.Add(tabelInput);
            panelForm.Controls.Add(judulForm);

            // BARIS 1
            TambahField(
                tabelInput,
                "Nama penyewa",
                txtNama,
                0, 0);

            TambahField(
                tabelInput,
                "No. telepon",
                txtTelepon,
                1, 0);

            TambahField(
                tabelInput,
                "Alamat",
                txtAlamat,
                2, 0);

            // BARIS 2
            TambahField(
                tabelInput,
                "Alat (tersedia)",
                cboAlat,
                0, 1);

            TambahField(
                tabelInput,
                "Tanggal mulai",
                dtpMulai,
                1, 1);

            TambahField(
                tabelInput,
                "Rencana kembali",
                dtpKembali,
                2, 1);

            // BARIS 3
            TambahField(
                tabelInput,
                "Metode pembayaran",
                cboMetode,
                0, 2);

            TambahField(
                tabelInput,
                "Jumlah diterima (Tunai)",
                nudDiterima,
                1, 2);

            // INPUT TRANSFER        
        var panelTransfer = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 1,
            RowCount = 2,
            Padding = new Padding(3)
        };

        panelTransfer.RowStyles.Add(
            new RowStyle(SizeType.Absolute, 22));

        panelTransfer.RowStyles.Add(
            new RowStyle(SizeType.Percent, 100));

        var lblTransfer = new Label
        {
            Text = "Bank / No. referensi (Transfer)",
            Dock = DockStyle.Fill,
            Font = new Font("Segoe UI", 8.5f),
            TextAlign = ContentAlignment.MiddleLeft
        };

        txtBank.Dock = DockStyle.Fill;
        txtBank.PlaceholderText = "Muncul bila Transfer";
        txtBank.Font = new Font("Segoe UI", 8.5f);
        txtBank.Margin = new Padding(0, 2, 0, 2);
        txtBank.Height = 28;

        txtReferensi.Visible = false;

        panelTransfer.Controls.Add(lblTransfer, 0, 0);
        panelTransfer.Controls.Add(txtBank, 0, 1);

        tabelInput.Controls.Add(panelTransfer, 2, 2);

            // RINCIAN BIAYA
            var panelBiaya = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Padding = new Padding(12),
                Margin = new Padding(4)
            };

            root.Controls.Add(panelBiaya, 1, 0);

            var judulBiaya = new Label
            {
                Text = "Rincian biaya",
                Font = new Font(
                    "Segoe UI", 11, FontStyle.Bold),
                Dock = DockStyle.Top,
                Height = 30
            };

            panelBiaya.Controls.Add(judulBiaya);

            var rincian = new TableLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 110,
                ColumnCount = 2,
                RowCount = 4
            };

            rincian.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 60));

            rincian.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 40));

            panelBiaya.Controls.Add(rincian);

            TambahRincian(
                rincian, "Durasi", lblDurasi, 0);

            TambahRincian(
                rincian, "Biaya dasar",
                lblBiayaDasar, 1);

            TambahRincian(
                rincian, "Diskon", lblDiskon, 2);

            TambahRincian(
                rincian, "Total", lblTotal, 3);

            lblTotal.Font =
                new Font(
                    "Segoe UI", 10, FontStyle.Bold);

            btnSimpan.Text = "Simpan Sewa";
            btnSimpan.Dock = DockStyle.Bottom;
            btnSimpan.Height = 40;
            btnSimpan.BackColor =
                Color.FromArgb(62, 122, 60);
            btnSimpan.ForeColor = Color.White;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.FlatAppearance.BorderSize = 0;

            panelBiaya.Controls.Add(btnSimpan);

            // DAFTAR SEWA
            var panelDaftar = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Padding = new Padding(10),
                Margin = new Padding(4)
            };

            root.Controls.Add(panelDaftar);
            root.SetColumnSpan(panelDaftar, 2);

            var judulDaftar = new Label
            {
                Text = "Daftar Sewa",
                Font = new Font(
                    "Segoe UI", 11, FontStyle.Bold),
                Dock = DockStyle.Top,
                Height = 30
            };

            panelDaftar.Controls.Add(judulDaftar);

            dgvSewa.Dock = DockStyle.Fill;
            dgvSewa.ReadOnly = true;
            dgvSewa.AllowUserToAddRows = false;
            dgvSewa.AllowUserToDeleteRows = false;

            dgvSewa.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvSewa.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvSewa.RowHeadersVisible = false;
            dgvSewa.BackgroundColor = Color.White;
            dgvSewa.BorderStyle = BorderStyle.None;

            dgvSewa.Columns.Clear();

            dgvSewa.Columns.Add("Penyewa", "Penyewa");
            dgvSewa.Columns.Add("Alat", "Alat");
            dgvSewa.Columns.Add("Mulai", "Mulai");

            dgvSewa.Columns.Add(
                "Kembali", "Rencana kembali");

            dgvSewa.Columns.Add("Total", "Total");

            dgvSewa.Columns.Add(
                "Pembayaran", "Pembayaran");

            dgvSewa.Columns["Total"]!
                .DefaultCellStyle.Format = "C0";

            dgvSewa.Columns["Total"]!
                .DefaultCellStyle.FormatProvider = indonesia;

            panelDaftar.Controls.Add(dgvSewa);
        }

        // MEMBUAT LABEL DAN INPUT
        private void TambahField(
            TableLayoutPanel tabel,
            string judul,
            Control input,
            int kolom,
            int baris)
        {
            var panel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 2,
                Padding = new Padding(3)
            };

            panel.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 22));

            panel.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100));

            var label = new Label
            {
                Text = judul,
                Dock = DockStyle.Fill,
                Font = new Font(
                    "Segoe UI", 8.5f),
                TextAlign = ContentAlignment.MiddleLeft
            };

            input.Dock = DockStyle.Fill;
            input.Margin = new Padding(0, 2, 0, 2);

            panel.Controls.Add(label, 0, 0);
            panel.Controls.Add(input, 0, 1);

            tabel.Controls.Add(panel, kolom, baris);
        }

        // RINCIAN BIAYA
        private void TambahRincian(
            TableLayoutPanel tabel,
            string judul,
            Label nilai,
            int baris)
        {
            var label = new Label
            {
                Text = judul,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft
            };

            nilai.Text = "0";
            nilai.Dock = DockStyle.Fill;

            nilai.TextAlign =
                ContentAlignment.MiddleRight;

            tabel.Controls.Add(label, 0, baris);
            tabel.Controls.Add(nilai, 1, baris);
        }

        // EVENT
        private void AturEvent()
        {
            cboAlat.SelectedIndexChanged +=
                (s, e) => HitungBiaya();

            dtpMulai.ValueChanged +=
                (s, e) => HitungBiaya();

            dtpKembali.ValueChanged +=
                (s, e) => HitungBiaya();

            cboMetode.SelectedIndexChanged +=
                (s, e) => AturMetodePembayaran();

            btnSimpan.Click +=
                (s, e) => SimpanSewa();
        }

        // MEMUAT ALAT
        private void MuatAlat()
        {
            try
            {
                cboAlat.DataSource =
                    controller.AmbilAlatTersedia();

                cboAlat.DisplayMember = "Kode";

                cboAlat.Format += (s, e) =>
                {
                    if (e.ListItem is AlatPertanian alat)
                    {
                        e.Value =
                            alat.Kode + " - " + alat.Nama;
                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat alat: " + ex.Message);
            }
        }

       
            // METODE PEMBAYARAN
            private void AturMetodePembayaran()
            {
                bool transfer = cboMetode.SelectedItem?.ToString() == "Transfer";

                txtBank.Enabled = transfer;
                txtReferensi.Enabled = transfer;

                if (!transfer)
                {
                    txtBank.Clear();
                    txtReferensi.Clear();
                }
            }

                // INISIALISASI METODE PEMBAYARAN
                private void InisialisasiMetodePembayaran()
                {
                    cboMetode.Items.Clear();

                    cboMetode.Items.Add("Tunai");
                    cboMetode.Items.Add("Transfer");

                    cboMetode.DropDownStyle = ComboBoxStyle.DropDownList;
                    cboMetode.SelectedIndex = 0;

                    AturMetodePembayaran();
                }

        // MENGHITUNG BIAYA
        private void HitungBiaya()
        {
            if (cboAlat.SelectedItem
                is not AlatPertanian alat)
            {
                return;
            }

            int durasi =
                (dtpKembali.Value.Date -
                 dtpMulai.Value.Date).Days;

            if (durasi <= 0)
            {
                lblDurasi.Text = "0 hari";
                lblBiayaDasar.Text = "Rp 0";
                lblDiskon.Text = "Rp 0";
                lblTotal.Text = "Rp 0";
                return;
            }

            decimal biayaDasar =
                alat.TarifPerHari * durasi;

            int hariDiskon =
                Math.Max(0, durasi - 7);

            decimal diskon =
                hariDiskon *
                alat.TarifPerHari * 0.10m;

            decimal total =
                biayaDasar - diskon;

            lblDurasi.Text =
                durasi + " hari";

            lblBiayaDasar.Text =
                biayaDasar.ToString("C0", indonesia);

            lblDiskon.Text =
                diskon.ToString("C0", indonesia);

            lblTotal.Text =
                total.ToString("C0", indonesia);
        }

        // SIMPAN SEWA
        private void SimpanSewa()
        {
            if (cboAlat.SelectedItem
                is not AlatPertanian alat)
            {
                MessageBox.Show(
                    "Pilih alat terlebih dahulu.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show(
                    "Nama penyewa harus diisi.");
                txtNama.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTelepon.Text))
            {
                MessageBox.Show(
                    "Nomor telepon harus diisi.");
                txtTelepon.Focus();
                return;
            }

            if (dtpKembali.Value.Date <= dtpMulai.Value.Date)
            {
                MessageBox.Show(
                    "Tanggal kembali harus setelah tanggal mulai.");
                return;
            }

            if (cboMetode.Text == "Transfer")
            {
                if (string.IsNullOrWhiteSpace(txtBank.Text) ||
                    string.IsNullOrWhiteSpace(txtReferensi.Text))
                {
                    MessageBox.Show(
                        "Bank dan nomor referensi harus diisi.");
                    return;
                }
            }

            decimal jumlahDiterima = nudDiterima.Value;

            var hasil = controller.SimpanSewa(
                txtNama.Text,
                txtTelepon.Text,
                txtAlamat.Text,
                alat,
                dtpMulai.Value,
                dtpKembali.Value,
                cboMetode.Text,
                jumlahDiterima,
                txtBank.Text,
                txtReferensi.Text);

            if (!hasil.Berhasil)
            {
                MessageBox.Show(
                    hasil.Pesan,
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            MessageBox.Show(
                hasil.Pesan,
                "Berhasil",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            BersihkanForm();
            MuatAlat();
            MuatDaftarSewa();
            HitungBiaya();
        }

        // MEMUAT DAFTAR SEWA
        private void MuatDaftarSewa()
        {
            try
            {
                dgvSewa.Rows.Clear();

                List<DataSewa> daftar =
                    controller.AmbilDaftarSewa();

                foreach (DataSewa sewa in daftar)
                {
                    int baris = dgvSewa.Rows.Add(
                        sewa.Penyewa,
                        sewa.Alat,
                        sewa.Mulai.ToString("dd/MM/yyyy"),
                        sewa.Kembali.ToString("dd/MM/yyyy"),
                        sewa.Total,
                        sewa.StatusPembayaran);

                    if (sewa.StatusPembayaran == "Lunas")
                    {
                        dgvSewa.Rows[baris]
                            .Cells["Pembayaran"]
                            .Style.BackColor =
                            Color.FromArgb(220, 240, 220);
                    }
                    else
                    {
                        dgvSewa.Rows[baris]
                            .Cells["Pembayaran"]
                            .Style.BackColor =
                            Color.FromArgb(250, 230, 190);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat daftar sewa: " +
                    ex.Message);
            }
        }

        // MEMBERSIHKAN FORM
        private void BersihkanForm()
        {
            txtNama.Clear();
            txtTelepon.Clear();
            txtAlamat.Clear();

            nudDiterima.Value = 0;

            txtBank.Clear();
            txtReferensi.Clear();

            dtpMulai.Value = DateTime.Today;

            dtpKembali.Value =
                DateTime.Today.AddDays(1);

            cboMetode.SelectedIndex = 0;
        }
    }
}
