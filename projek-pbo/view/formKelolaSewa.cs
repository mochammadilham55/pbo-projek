using System.Drawing.Drawing2D;
using projek_pbo.controller;
using projek_pbo.model;

namespace projek_pbo.view
{
    public partial class formKelolaSewa : Form
    {
        private static readonly Color HijauTua = Color.FromArgb(45, 87, 55);
        private static readonly Color Hijau = Color.FromArgb(59, 117, 53);
        private static readonly Color Latar = Color.FromArgb(245, 242, 234);
        private static readonly Color Garis = Color.FromArgb(232, 228, 218);
        private readonly c_Penyewaan controller = new();
        private readonly ComboBox nama = new() { DropDownStyle = ComboBoxStyle.DropDown, MaxLength = 100 };
        private readonly TextBox telepon = new() { MaxLength = 20, PlaceholderText = "08xxxxxxxxxx" };
        private readonly TextBox alamat = new() { MaxLength = 200, PlaceholderText = "Alamat" };
        private readonly ComboBox alat = new() { DropDownStyle = ComboBoxStyle.DropDownList };
        private readonly DateTimePicker mulai = new() { Format = DateTimePickerFormat.Custom, CustomFormat = "dd/MM/yyyy", Enabled = false };
        private readonly DateTimePicker kembali = new() { Format = DateTimePickerFormat.Custom, CustomFormat = "dd/MM/yyyy" };
        private readonly ComboBox metode = new() { DropDownStyle = ComboBoxStyle.DropDownList };
        private readonly NumericUpDown diterima = new() { Maximum = 9999999999.99m, DecimalPlaces = 2, ThousandsSeparator = true };
        private readonly TextBox bank = new() { MaxLength = 50, PlaceholderText = "Bank" };
        private readonly TextBox referensi = new() { MaxLength = 50, PlaceholderText = "No. referensi" };
        private readonly TextBox petunjukTransfer = new() { PlaceholderText = "Muncul bila Transfer", Enabled = false };
        private readonly TableLayoutPanel transfer = new() { ColumnCount = 2, RowCount = 1, Dock = DockStyle.Fill, Margin = Padding.Empty };
        private readonly Label durasi = Nilai(), biayaDasar = Nilai(), diskon = Nilai(), total = Nilai();
        private readonly Button simpan = new() { Text = "Simpan Sewa", Dock = DockStyle.Fill, FlatStyle = FlatStyle.Flat };
        private readonly DataGridView riwayat = new()
        {
            Dock = DockStyle.Fill, ReadOnly = true, AllowUserToAddRows = false, AllowUserToDeleteRows = false,
            AllowUserToResizeRows = false, RowHeadersVisible = false, MultiSelect = false,
            SelectionMode = DataGridViewSelectionMode.FullRowSelect, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        };
        private readonly ToolTip tips = new();
        private record PilihanPenyewa(Penyewa Data) { public override string ToString() => Data.Nama + " - " + Data.NoTelepon + " (#" + Data.Id + ")"; }
        private record PilihanAlat(AlatPertanian Data) { public override string ToString() => Data.Kode + " - " + Data.Nama; }

        public formKelolaSewa()
        {
            InitializeComponent();
            Navigasi.PasangSidebar(this, btnDashboard, btnAlat, btnSewa, btnPengembaian,
                btnLaporan, btnUser, btnLogout, lblPengguna);
            AturBingkai();
            BangunIsi();
            MuatData();
            Shown += (_, _) => riwayat.ClearSelection();
            FormClosed += (_, _) => tips.Dispose();
        }

        private static GraphicsPath Sudut(RectangleF r, float radius)
        {
            var p = new GraphicsPath();
            float d = Math.Min(radius * 2, Math.Min(r.Width, r.Height));
            p.AddArc(r.X, r.Y, d, d, 180, 90);
            p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            p.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            p.CloseFigure();
            return p;
        }

        private static void Bulatkan(Control kontrol, int radius)
        {
            void Terapkan()
            {
                if (kontrol.Width < 2 || kontrol.Height < 2) return;
                using var path = Sudut(new RectangleF(0, 0, kontrol.Width, kontrol.Height), radius);
                var lama = kontrol.Region;
                kontrol.Region = new Region(path);
                lama?.Dispose();
            }
            kontrol.SizeChanged += (_, _) => Terapkan();
            Terapkan();
        }

        private sealed class KartuPutih : Panel
        {
            public KartuPutih()
            {
                BackColor = Color.White;
                Padding = new Padding(16);
                DoubleBuffered = true;
                Bulatkan(this, 8);
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                if (Width < 3 || Height < 3) return;
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using var p = Sudut(new RectangleF(0.5f, 0.5f, Width - 1, Height - 1), 8);
                using var pen = new Pen(Garis);
                e.Graphics.DrawPath(pen, p);
            }
        }

        private void AturBingkai()
        {
            Font = new Font("Segoe UI", 10F);
            BackColor = Latar;
            pnlUtama.BackColor = Latar;
            pnlIsi.BackColor = Latar;
            pnlIsi.Padding = new Padding(24);
            pnlIsi.AutoScroll = true;
            pnlSidebar.Width = 218;
            pnlSidebar.BackColor = HijauTua;
            panel2.Height = 64;
            panel2.Padding = new Padding(28, 0, 28, 0);
            lblPengguna.Width = 290;
            lblPengguna.Font = new Font("Segoe UI", 9F);
            lblPengguna.ForeColor = Color.FromArgb(65, 65, 65);
            if (c_Auth.PenggunaAktif is Pengguna user)
                lblPengguna.Text = "Masuk sebagai: " + user.Peran;
            var judul = new Label
            {
                Text = "Kelola Sewa dan Pembayaran", Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 16F, FontStyle.Bold), ForeColor = HijauTua,
                TextAlign = ContentAlignment.MiddleLeft, AutoEllipsis = true
            };
            panel2.Controls.Add(judul);
            judul.BringToFront();

            lblLogo.Dock = DockStyle.None;
            lblLogo.AutoSize = false;
            lblLogo.Padding = Padding.Empty;
            lblLogo.Location = new Point(20, 20);
            lblLogo.Size = new Size(190, 42);
            lblLogo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblLogo.TextAlign = ContentAlignment.MiddleLeft;

            var tombol = new (Button Tombol, MenuAplikasi Menu)[]
            {
                (btnDashboard, MenuAplikasi.Dashboard), (btnAlat, MenuAplikasi.KelolaAlat),
                (btnSewa, MenuAplikasi.KelolaSewa), (btnPengembaian, MenuAplikasi.KelolaPengembalian),
                (btnLaporan, MenuAplikasi.Laporan), (btnUser, MenuAplikasi.KelolaUser)
            };
            var menu = c_Auth.PenggunaAktif?.MenuTersedia();
            int y = 82;
            foreach (var (btn, jenis) in tombol)
            {
                btn.Dock = DockStyle.None;
                btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                btn.Location = new Point(8, y);
                btn.Size = new Size(198, 44);
                btn.Padding = new Padding(12, 0, 0, 0);
                btn.UseVisualStyleBackColor = false;
                btn.BackColor = btn == btnSewa ? Hijau : HijauTua;
                btn.Font = new Font("Segoe UI", 10F, btn == btnSewa ? FontStyle.Bold : FontStyle.Regular);
                Bulatkan(btn, 6);
                if (menu == null || menu.Contains(jenis)) y += 50;
            }
            btnLogout.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            btnLogout.SetBounds(8, pnlSidebar.ClientSize.Height - 62, 198, 44);
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Bulatkan(btnLogout, 6);
        }

        private static Label Nilai() => new()
        {
            Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleRight, Text = "-"
        };

        private static void Isian(TableLayoutPanel grid, int kolom, int baris, string judul, Control input)
        {
            var blok = new Panel { Dock = DockStyle.Fill, Margin = new Padding(5, 3, 5, 3) };
            var label = new Label
            {
                Text = judul, Dock = DockStyle.Top, Height = 24, AutoEllipsis = true,
                Font = new Font("Segoe UI", 9F), ForeColor = Color.FromArgb(60, 60, 60)
            };
            input.Dock = DockStyle.Top;
            input.Margin = Padding.Empty;
            input.Font = new Font("Segoe UI", 10F);
            input.Height = 32;
            blok.Controls.Add(input);
            blok.Controls.Add(label);
            grid.Controls.Add(blok, kolom, baris);
        }

        private void BangunIsi()
        {
            mulai.Value = DateTime.Today;
            kembali.MinDate = DateTime.Today.AddDays(1);
            kembali.Value = DateTime.Today.AddDays(3);
            metode.Items.AddRange(new object[] { "Tunai", "Transfer" });
            metode.SelectedIndex = 0;
            nama.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            nama.AutoCompleteSource = AutoCompleteSource.ListItems;
            tips.SetToolTip(nama, "Ketik nama penyewa baru atau pilih penyewa lama dari daftar.");
            tips.SetToolTip(mulai, "Sewa langsung dimulai hari ini.");

            var halaman = new TableLayoutPanel
            {
                Dock = DockStyle.Top, Height = 478, ColumnCount = 1, RowCount = 2,
                Margin = Padding.Empty, Padding = Padding.Empty
            };
            halaman.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            halaman.RowStyles.Add(new RowStyle(SizeType.Absolute, 248));
            halaman.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            pnlIsi.Controls.Add(halaman);

            var atas = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, RowCount = 1, Margin = Padding.Empty };
            atas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72));
            atas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28));
            atas.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            halaman.Controls.Add(atas, 0, 0);

            var kartuForm = new KartuPutih { Dock = DockStyle.Fill, Margin = new Padding(0, 0, 8, 0) };
            var kartuBiaya = new KartuPutih { Dock = DockStyle.Fill, Margin = new Padding(8, 0, 0, 0) };
            atas.Controls.Add(kartuForm, 0, 0);
            atas.Controls.Add(kartuBiaya, 1, 0);

            var grid = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 3, RowCount = 3, Margin = Padding.Empty };
            for (int i = 0; i < 3; i++)
            {
                grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / 3));
                grid.RowStyles.Add(new RowStyle(SizeType.Percent, 100F / 3));
            }
            kartuForm.Controls.Add(grid);

            transfer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45));
            transfer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55));
            bank.Dock = referensi.Dock = DockStyle.Fill;
            bank.Margin = new Padding(0, 0, 3, 0);
            referensi.Margin = new Padding(3, 0, 0, 0);
            transfer.Controls.Add(bank, 0, 0);
            transfer.Controls.Add(referensi, 1, 0);
            var transferHost = new Panel { Height = 32 };
            petunjukTransfer.Dock = DockStyle.Top;
            transferHost.Controls.Add(transfer);
            transferHost.Controls.Add(petunjukTransfer);

            Isian(grid, 0, 0, "Nama penyewa", nama);
            Isian(grid, 1, 0, "No. telepon", telepon);
            Isian(grid, 2, 0, "Alamat", alamat);
            Isian(grid, 0, 1, "Alat (hanya yg tersedia)", alat);
            Isian(grid, 1, 1, "Tanggal mulai", mulai);
            Isian(grid, 2, 1, "Rencana kembali", kembali);
            Isian(grid, 0, 2, "Metode pembayaran", metode);
            Isian(grid, 1, 2, "Jumlah diterima (Tunai)", diterima);
            Isian(grid, 2, 2, "Bank / No. referensi (Transfer)", transferHost);

            var rincian = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, RowCount = 7, Margin = Padding.Empty };
            rincian.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44));
            rincian.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56));
            foreach (int tinggi in new[] { 30, 28, 28, 28, 6, 36 })
                rincian.RowStyles.Add(new RowStyle(SizeType.Absolute, tinggi));
            rincian.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            kartuBiaya.Controls.Add(rincian);
            var judul = new Label { Text = "Rincian biaya", Dock = DockStyle.Fill, ForeColor = HijauTua, Font = new Font("Segoe UI", 11F, FontStyle.Bold) };
            rincian.Controls.Add(judul, 0, 0);
            rincian.SetColumnSpan(judul, 2);

            void BarisBiaya(string teks, Label nilai, int row, bool tebal = false)
            {
                var label = new Label { Text = teks, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft };
                if (tebal)
                {
                    label.ForeColor = nilai.ForeColor = HijauTua;
                    label.Font = nilai.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
                }
                rincian.Controls.Add(label, 0, row);
                rincian.Controls.Add(nilai, 1, row);
            }
            BarisBiaya("Durasi", durasi, 1);
            BarisBiaya("Biaya dasar", biayaDasar, 2);
            BarisBiaya("Diskon", diskon, 3);
            var garis = new Panel { Height = 1, Dock = DockStyle.Top, BackColor = Garis };
            rincian.Controls.Add(garis, 0, 4);
            rincian.SetColumnSpan(garis, 2);
            BarisBiaya("Total", total, 5, true);
            simpan.BackColor = Hijau;
            simpan.ForeColor = Color.White;
            simpan.UseVisualStyleBackColor = false;
            simpan.FlatAppearance.BorderSize = 0;
            simpan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            simpan.Margin = new Padding(0, 4, 0, 0);
            Bulatkan(simpan, 6);
            rincian.Controls.Add(simpan, 0, 6);
            rincian.SetColumnSpan(simpan, 2);

            var daftar = new KartuPutih { Dock = DockStyle.Fill, Margin = new Padding(0, 16, 0, 0) };
            halaman.Controls.Add(daftar, 0, 1);
            var judulDaftar = new Label { Text = "Daftar Sewa", Dock = DockStyle.Top, Height = 34, Font = new Font("Segoe UI", 11F, FontStyle.Bold), ForeColor = HijauTua };
            daftar.Controls.Add(riwayat);
            daftar.Controls.Add(judulDaftar);
            AturTabel();
            var menuTabel = new ContextMenuStrip();
            menuTabel.Items.Add("Cari penyewa / alat...", null, (_, _) => CariRiwayat());
            menuTabel.Items.Add("Tampilkan semua", null, (_, _) => MuatRiwayat());
            menuTabel.Items.Add("Muat ulang alat dan transaksi", null, (_, _) => MuatData());
            riwayat.ContextMenuStrip = menuTabel;
            tips.SetToolTip(judulDaftar, "Klik kanan tabel untuk mencari atau memuat ulang.");
            KeyPreview = true;
            KeyDown += (_, e) =>
            {
                if (e.Control && e.KeyCode == Keys.F) { e.SuppressKeyPress = true; CariRiwayat(); }
                if (e.KeyCode == Keys.F5) { e.SuppressKeyPress = true; MuatData(); }
            };

            nama.SelectedIndexChanged += (_, _) =>
            {
                if (nama.SelectedItem is PilihanPenyewa p)
                {
                    telepon.Text = p.Data.NoTelepon;
                    alamat.Text = p.Data.Alamat;
                }
            };
            nama.TextChanged += (_, _) =>
            {
                bool lama = nama.SelectedItem is PilihanPenyewa p && nama.Text == p.ToString();
                telepon.ReadOnly = alamat.ReadOnly = lama;
            };
            alat.SelectedIndexChanged += (_, _) => Perbarui();
            kembali.ValueChanged += (_, _) => Perbarui();
            metode.SelectedIndexChanged += (_, _) => Perbarui();
            diterima.ValueChanged += (_, _) => Perbarui();
            bank.TextChanged += (_, _) => Perbarui();
            referensi.TextChanged += (_, _) => Perbarui();
            simpan.Click += (_, _) => Simpan();
        }

        private void AturTabel()
        {
            riwayat.BackgroundColor = Color.White;
            riwayat.BorderStyle = BorderStyle.None;
            riwayat.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            riwayat.GridColor = Garis;
            riwayat.EnableHeadersVisualStyles = false;
            riwayat.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            riwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            riwayat.ColumnHeadersHeight = 36;
            riwayat.ColumnHeadersDefaultCellStyle.BackColor = HijauTua;
            riwayat.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            riwayat.ColumnHeadersDefaultCellStyle.SelectionBackColor = HijauTua;
            riwayat.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            riwayat.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            riwayat.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            riwayat.DefaultCellStyle.SelectionBackColor = Color.FromArgb(229, 239, 226);
            riwayat.DefaultCellStyle.SelectionForeColor = Color.Black;
            riwayat.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 246, 240);
            riwayat.RowTemplate.Height = 35;
            string[] judul = { "Penyewa", "Alat", "Mulai", "Rencana kembali", "Total", "Pembayaran" };
            float[] bobot = { 19, 10, 14, 19, 14, 24 };
            for (int i = 0; i < judul.Length; i++)
            {
                int index = riwayat.Columns.Add("kolom" + i, judul[i]);
                riwayat.Columns[index].FillWeight = bobot[i];
                riwayat.Columns[index].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            riwayat.CellPainting += (_, e) =>
            {
                if (e.RowIndex < 0 || e.ColumnIndex != 5 || e.Value == null || e.Graphics == null) return;
                string teks = e.Value.ToString() ?? "";
                bool lunas = teks == "Lunas";
                Color latar = lunas ? Color.FromArgb(225, 240, 219) : Color.FromArgb(250, 235, 193);
                Color tinta = lunas ? HijauTua : Color.FromArgb(132, 95, 30);
                e.Paint(e.ClipBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.SelectionBackground | DataGridViewPaintParts.Border);
                var ukuran = TextRenderer.MeasureText(teks, riwayat.Font);
                int w = Math.Min(e.CellBounds.Width - 10, ukuran.Width + 16);
                if (w > 4)
                {
                    var rect = new Rectangle(e.CellBounds.X + 7, e.CellBounds.Y + (e.CellBounds.Height - 22) / 2, w, 22);
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    using var path = Sudut(rect, 10);
                    using var brush = new SolidBrush(latar);
                    e.Graphics.FillPath(brush, path);
                    TextRenderer.DrawText(e.Graphics, teks, riwayat.Font, rect, tinta, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
                }
                e.Handled = true;
            };
        }

        private void CariRiwayat()
        {
            using var dialog = new Form { Text = "Cari daftar sewa", ClientSize = new Size(360, 105), StartPosition = FormStartPosition.CenterParent, FormBorderStyle = FormBorderStyle.FixedDialog, MinimizeBox = false, MaximizeBox = false };
            var input = new TextBox { PlaceholderText = "Nama penyewa atau kode alat", Left = 12, Top = 12, Width = 336 };
            var ok = new Button { Text = "Cari", DialogResult = DialogResult.OK, Left = 248, Top = 55, Width = 100 };
            dialog.Controls.Add(input);
            dialog.Controls.Add(ok);
            dialog.AcceptButton = ok;
            if (dialog.ShowDialog(this) == DialogResult.OK) MuatRiwayat(input.Text);
        }

        private void MuatAlat()
        {
            alat.DataSource = controller.AmbilAlatTersedia().Select(a => new PilihanAlat(a)).ToList();
            Perbarui();
        }

        private void MuatData()
        {
            try
            {
                nama.DataSource = controller.AmbilPenyewa().Select(p => new PilihanPenyewa(p)).ToList();
                nama.SelectedIndex = -1;
                nama.Text = "";
                telepon.Clear();
                alamat.Clear();
                telepon.ReadOnly = alamat.ReadOnly = false;
                MuatAlat();
                MuatRiwayat();
            }
            catch (Exception ex) { simpan.Enabled = false; Tampilan.Error(ex); }
        }

        private void MuatRiwayat(string cari = "")
        {
            try
            {
                riwayat.Rows.Clear();
                foreach (var item in controller.AmbilRiwayat(cari))
                {
                    var s = item.Sewa;
                    decimal tagihan = s.HitungTotalBiaya();
                    int i = riwayat.Rows.Add(s.Penyewa.Nama, s.Alat.Kode, Tampilan.Tanggal(s.TanggalMulai),
                        Tampilan.Tanggal(s.TanggalRencanaKembali), Tampilan.Rupiah(tagihan), item.Dibayar >= tagihan ? "Lunas" : "Belum lunas");
                    riwayat.Rows[i].Cells[5].ToolTipText = "Metode: " + item.Metode + " | Dibayar: " + Tampilan.Rupiah(item.Dibayar) + " | Sewa: " + s.Status;
                }
                riwayat.ClearSelection();
            }
            catch (Exception ex) { Tampilan.Error(ex); }
        }

        private void Perbarui()
        {
            bool tunai = metode.Text == "Tunai";
            diterima.Enabled = tunai;
            transfer.Visible = !tunai;
            petunjukTransfer.Visible = tunai;
            simpan.Enabled = false;
            durasi.Text = biayaDasar.Text = diskon.Text = total.Text = "-";
            if (alat.SelectedItem is not PilihanAlat pilihan) return;
            try
            {
                var s = controller.Hitung(new Penyewa(0, "Pratinjau", "", ""), pilihan.Data, mulai.Value.Date, kembali.Value.Date);
                decimal tagihan = s.HitungTotalBiaya();
                durasi.Text = s.Durasi + " hari";
                biayaDasar.Text = Tampilan.Rupiah(s.HitungBiayaDasar());
                diskon.Text = Tampilan.Rupiah(s.HitungDiskon());
                total.Text = Tampilan.Rupiah(tagihan);
                tips.SetToolTip(diterima, tunai ? "Kembalian: " + Tampilan.Rupiah(Math.Max(0, diterima.Value - tagihan)) : "");
                simpan.Enabled = tagihan <= diterima.Maximum && (tunai ? diterima.Value >= tagihan :
                    !string.IsNullOrWhiteSpace(bank.Text) && !string.IsNullOrWhiteSpace(referensi.Text));
            }
            catch (ArgumentException ex) { tips.SetToolTip(total, ex.Message); }
        }

        private void Simpan()
        {
            try
            {
                if (alat.SelectedItem is not PilihanAlat pilihan) return;
                var penyewa = nama.SelectedItem is PilihanPenyewa p && nama.Text == p.ToString()
                    ? p.Data : new Penyewa(0, nama.Text, telepon.Text, alamat.Text);
                if (!Tampilan.Konfirmasi("Simpan transaksi dan pembayaran lunas? Pastikan pembayaran sudah diterima.")) return;
                var hasil = controller.BuatSewa(penyewa, pilihan.Data, mulai.Value.Date, kembali.Value.Date,
                    metode.Text, diterima.Value, bank.Text, referensi.Text);
                Tampilan.TampilkanHasil(hasil);
                if (hasil.Berhasil)
                {
                    bank.Clear();
                    referensi.Clear();
                    diterima.Value = 0;
                    MuatData();
                }
                else { MuatAlat(); MuatRiwayat(); }
            }
            catch (Exception ex) { Tampilan.Error(ex); }
        }

        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void lblPengguna_Click(object sender, EventArgs e) { }
    }
}
