using projek_pbo.controller;
using projek_pbo.model;

namespace projek_pbo.view
{
    public partial class formLaporan : Form
    {
        private readonly c_Laporan controller = new c_Laporan();

        public formLaporan()
        {
            InitializeComponent();
            Navigasi.PasangSidebar(this, btnDashboard, btnAlat, btnSewa, btnPengembaian,
                btnLaporan, btnUser, btnLogout, lblPengguna);
        }

        private void formLaporan_Load(object sender, EventArgs e)
        {
            AturFilter();
            MuatLaporan();
        }

        private void AturFilter()
        {
            cmbJenis.Items.Clear();
            cmbJenis.Items.AddRange(JenisLaporanTeks.Semua);
            cmbJenis.SelectedIndex = 0;

            DateTime hariIni = DateTime.Today;
            dtpAwal.Value = new DateTime(hariIni.Year, hariIni.Month, 1);
            dtpAkhir.Value = hariIni;
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            MuatLaporan();
        }

        private void MuatLaporan()
        {
            try
            {
                JenisLaporan jenis = JenisLaporanTeks.DariTeks(cmbJenis.Text);
                var (hasil, laporan) = controller.BuatLaporan(jenis, dtpAwal.Value, dtpAkhir.Value);

                if (laporan == null)
                {
                    Tampilan.TampilkanHasil(hasil);
                    return;
                }

                IsiTabel(laporan);
            }
            catch (Exception ex)
            {
                Tampilan.Error(ex);
            }
        }

        // Kolom dibuat ulang setiap kali karena ketiga jenis laporan punya kolom yang berbeda.
        private void IsiTabel(HasilLaporan laporan)
        {
            lblJudulLaporan.Text = $"{laporan.Judul} ({laporan.Periode})";
            lblTotalTeks.Text = laporan.LabelTotal;
            lblTotal.Text = laporan.TotalBerupaUang ? Tampilan.Rupiah(laporan.Total) : Tampilan.Angka(laporan.Total);

            dgvLaporan.Columns.Clear();
            foreach (string nama in laporan.Kolom)
                dgvLaporan.Columns.Add(nama, nama);

            foreach (object[] baris in laporan.Baris)
                dgvLaporan.Rows.Add(baris.Select(FormatSel).Cast<object>().ToArray());

            // Kolom angka rata kanan; ditentukan dari isi baris pertama.
            if (laporan.Baris.Count > 0)
            {
                for (int i = 0; i < laporan.Kolom.Count; i++)
                {
                    if (laporan.Baris[0][i] is decimal or int)
                        dgvLaporan.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }

            dgvLaporan.ClearSelection();
        }

        private static string FormatSel(object? nilai)
        {
            return nilai switch
            {
                DateTime tanggal => Tampilan.Tanggal(tanggal),
                decimal uang => Tampilan.Rupiah(uang),
                null => "",
                _ => nilai.ToString() ?? ""
            };
        }
    }
}
