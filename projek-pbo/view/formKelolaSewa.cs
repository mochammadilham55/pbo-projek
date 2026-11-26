using projek_pbo.controller;
using projek_pbo.model;

namespace projek_pbo.view
{
    public partial class formKelolaSewa : Form
    {
        private readonly c_Penyewaan controller = new();
        private readonly ComboBox pelanggan = new() { DropDownStyle = ComboBoxStyle.DropDownList };
        private readonly ComboBox alat = new() { DropDownStyle = ComboBoxStyle.DropDownList };
        private readonly ComboBox metode = new() { DropDownStyle = ComboBoxStyle.DropDownList };
        private readonly TextBox nama = new() { MaxLength = 100 };
        private readonly TextBox telepon = new() { MaxLength = 20 };
        private readonly TextBox alamat = new() { MaxLength = 200 };
        private readonly TextBox bank = new() { MaxLength = 50 };
        private readonly TextBox referensi = new() { MaxLength = 50 };
        private readonly DateTimePicker kembali = new() { Format = DateTimePickerFormat.Short };
        private readonly NumericUpDown diterima = new() { Maximum = 9999999999.99m, DecimalPlaces = 2, ThousandsSeparator = true };
        private readonly Label rincian = new() { AutoSize = true };
        private readonly Button simpan = new() { Text = "Simpan sewa dan pembayaran", AutoSize = true };
        private readonly TextBox cari = new();
        private readonly DataGridView riwayat = new() { Dock = DockStyle.Fill, ReadOnly = true, AllowUserToAddRows = false, AllowUserToDeleteRows = false, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill };
        private record PilihanPenyewa(Penyewa? Data, string Teks);
        private record PilihanAlat(AlatPertanian Data, string Teks);

        public formKelolaSewa()
        {
            InitializeComponent();
            Navigasi.PasangSidebar(this, btnDashboard, btnAlat, btnSewa, btnPengembaian,
                btnLaporan, btnUser, btnLogout, lblPengguna);
            BangunIsi();
            MuatData();
        }

        private void BangunIsi()
        {
            var tabs = new TabControl { Dock = DockStyle.Fill };
            var transaksi = new TabPage("Transaksi baru") { BackColor = Color.White, AutoScroll = true };
            var sejarah = new TabPage("Riwayat sewa");
            tabs.TabPages.Add(transaksi);
            tabs.TabPages.Add(sejarah);
            pnlIsi.Controls.Add(tabs);

            var form = new TableLayoutPanel { Dock = DockStyle.Top, AutoSize = true, ColumnCount = 2, Padding = new Padding(12) };
            form.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180));
            form.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            transaksi.Controls.Add(form);

            void Baris(string teks, Control kontrol)
            {
                int n = form.RowCount++;
                form.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                form.Controls.Add(new Label { Text = teks, AutoSize = true, Anchor = AnchorStyles.Left, Margin = new Padding(3, 7, 3, 7) }, 0, n);
                kontrol.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                kontrol.Margin = new Padding(3, 5, 3, 5);
                form.Controls.Add(kontrol, 1, n);
            }

            kembali.MinDate = DateTime.Today.AddDays(1);
            kembali.Value = kembali.MinDate;
            metode.Items.AddRange(new object[] { "Tunai", "Transfer" });
            metode.SelectedIndex = 0;
            pelanggan.DisplayMember = "Teks";
            alat.DisplayMember = "Teks";
            Baris("Penyewa", pelanggan);
            Baris("Nama", nama);
            Baris("No. telepon", telepon);
            Baris("Alamat", alamat);
            Baris("Alat tersedia", alat);
            Baris("Tanggal mulai", new Label { Text = Tampilan.Tanggal(DateTime.Today), AutoSize = true });
            Baris("Rencana kembali", kembali);
            Baris("Metode pembayaran", metode);
            Baris("Uang diterima (Rp)", diterima);
            Baris("Bank tujuan", bank);
            Baris("No. referensi transfer", referensi);
            Baris("Rincian biaya", rincian);
            Baris("", simpan);
            simpan.BackColor = Color.FromArgb(47, 93, 58);
            simpan.ForeColor = Color.White;

            var pencarian = new FlowLayoutPanel { Dock = DockStyle.Top, AutoSize = true, Padding = new Padding(6) };
            var tombolCari = new Button { Text = "Cari", AutoSize = true };
            var refresh = new Button { Text = "Muat ulang", AutoSize = true };
            pencarian.Controls.Add(new Label { Text = "Cari penyewa / alat", AutoSize = true });
            pencarian.Controls.Add(cari);
            pencarian.Controls.Add(tombolCari);
            pencarian.Controls.Add(refresh);
            sejarah.Controls.Add(riwayat);
            sejarah.Controls.Add(pencarian);
            foreach (string judul in new[] { "ID", "Penyewa", "Alat", "Mulai", "Rencana kembali", "Total", "Dibayar", "Metode", "Status" })
                riwayat.Columns.Add("kolom" + riwayat.Columns.Count, judul);

            pelanggan.SelectedIndexChanged += (_, _) =>
            {
                var p = (pelanggan.SelectedItem as PilihanPenyewa)?.Data;
                nama.Text = p?.Nama ?? "";
                telepon.Text = p?.NoTelepon ?? "";
                alamat.Text = p?.Alamat ?? "";
                nama.ReadOnly = telepon.ReadOnly = alamat.ReadOnly = p != null;
            };
            alat.SelectedIndexChanged += (_, _) => Perbarui();
            kembali.ValueChanged += (_, _) => Perbarui();
            metode.SelectedIndexChanged += (_, _) => Perbarui();
            diterima.ValueChanged += (_, _) => Perbarui();
            simpan.Click += (_, _) => Simpan();
            tombolCari.Click += (_, _) => MuatRiwayat();
            refresh.Click += (_, _) => MuatData();
        }

        private void MuatData()
        {
            try
            {
                var daftar = new List<PilihanPenyewa> { new(null, "Penyewa baru") };
                daftar.AddRange(controller.AmbilPenyewa().Select(p => new PilihanPenyewa(p, $"{p.Nama} - {p.NoTelepon} (#{p.Id})")));
                pelanggan.DataSource = daftar;
                pelanggan.SelectedIndex = 0;
                alat.DataSource = controller.AmbilAlatTersedia().Select(a => new PilihanAlat(a, $"{a.Kode} - {a.Nama} ({Tampilan.Rupiah(a.TarifPerHari)}/hari)")).ToList();
                MuatRiwayat();
                Perbarui();
            }
            catch (Exception ex) { simpan.Enabled = false; Tampilan.Error(ex); }
        }

        private void MuatRiwayat()
        {
            try
            {
                riwayat.Rows.Clear();
                foreach (var item in controller.AmbilRiwayat(cari.Text))
                {
                    var s = item.Sewa;
                    riwayat.Rows.Add(s.Id, s.Penyewa.Nama, s.Alat.Kode + " - " + s.Alat.Nama,
                        Tampilan.Tanggal(s.TanggalMulai), Tampilan.Tanggal(s.TanggalRencanaKembali),
                        Tampilan.Rupiah(s.HitungTotalBiaya()), Tampilan.Rupiah(item.Dibayar), item.Metode, s.Status);
                }
            }
            catch (Exception ex) { Tampilan.Error(ex); }
        }

        private void Perbarui()
        {
            bool tunai = metode.Text == "Tunai";
            diterima.Enabled = tunai;
            bank.Enabled = referensi.Enabled = !tunai;
            simpan.Enabled = false;
            if (alat.SelectedItem is not PilihanAlat pilihan) { rincian.Text = "Tidak ada alat tersedia."; return; }
            try
            {
                var s = controller.Hitung(new Penyewa(0, "Pratinjau", "", ""), pilihan.Data, DateTime.Today, kembali.Value.Date);
                decimal total = s.HitungTotalBiaya();
                rincian.Text = $"{s.Durasi} hari | Dasar: {Tampilan.Rupiah(s.HitungBiayaDasar())}\nDiskon: {Tampilan.Rupiah(s.HitungDiskon())} | Total: {Tampilan.Rupiah(total)}";
                if (tunai) rincian.Text += $"\nKembalian: {Tampilan.Rupiah(Math.Max(0, diterima.Value - total))}";
                simpan.Enabled = total <= diterima.Maximum && (!tunai || diterima.Value >= total);
            }
            catch (ArgumentException ex) { rincian.Text = ex.Message; }
        }

        private void Simpan()
        {
            try
            {
                if (alat.SelectedItem is not PilihanAlat pilihan) return;
                var p = (pelanggan.SelectedItem as PilihanPenyewa)?.Data ?? new Penyewa(0, nama.Text, telepon.Text, alamat.Text);
                if (!Tampilan.Konfirmasi("Simpan transaksi dan pembayaran lunas? Pastikan pembayaran sudah diterima.")) return;
                var hasil = controller.BuatSewa(p, pilihan.Data, DateTime.Today, kembali.Value.Date,
                    metode.Text, diterima.Value, bank.Text, referensi.Text);
                Tampilan.TampilkanHasil(hasil);
                if (hasil.Berhasil)
                {
                    nama.Clear(); telepon.Clear(); alamat.Clear(); bank.Clear(); referensi.Clear();
                    diterima.Value = 0;
                }
                MuatData();
            }
            catch (Exception ex) { Tampilan.Error(ex); }
        }

        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void lblPengguna_Click(object sender, EventArgs e) { }
    }
}
