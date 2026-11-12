using projek_pbo.controller;
using projek_pbo.model;

namespace projek_pbo.view
{
    public partial class formKelolaPengembalian : Form
    {
        private static readonly Color WarnaTerlambat = Color.FromArgb(179, 65, 47);

        private readonly c_Penyewaan penyewaanController = new c_Penyewaan();
        private readonly c_Pengembalian pengembalianController = new c_Pengembalian();
        private Penyewaan? sewaTerpilih;

        public formKelolaPengembalian()
        {
            InitializeComponent();
            Navigasi.PasangSidebar(this, btnDashboard, btnAlat, btnSewa, btnPengembaian,
                btnLaporan, btnUser, btnLogout, lblPengguna);
            dtpKembali.MaxDate = DateTime.Today;
            Shown += (s, e) => dgvSewa.ClearSelection();
            MuatData();
        }

        private void MuatData()
        {
            dgvSewa.Rows.Clear();
            try
            {
                foreach (Penyewaan sewa in penyewaanController.AmbilSewaAktif(txtCari.Text.Trim()))
                {
                    int terlambat = sewa.HitungHariTerlambat(DateTime.Today);
                    string keterangan = terlambat > 0 ? $"Terlambat {terlambat} hari" : "Tepat waktu";

                    int baris = dgvSewa.Rows.Add(sewa.Penyewa.Nama, $"{sewa.Alat.Kode} - {sewa.Alat.Nama}",
                        Tampilan.Tanggal(sewa.TanggalMulai), Tampilan.Tanggal(sewa.TanggalRencanaKembali), keterangan);
                    dgvSewa.Rows[baris].Tag = sewa;
                    if (terlambat > 0)
                        dgvSewa.Rows[baris].Cells[colKeterangan.Index].Style.ForeColor = WarnaTerlambat;
                }
            }
            catch (Exception ex)
            {
                Tampilan.Error(ex);
            }
            Bersihkan();
        }

        private void Bersihkan()
        {
            sewaTerpilih = null;
            dgvSewa.ClearSelection();
            dtpKembali.Value = DateTime.Today;
            chkAdaKerusakan.Checked = false;
            txtDendaKerusakan.Clear();
            txtKeterangan.Clear();
            AturIsianKerusakan();
            PerbaruiRincian();
        }

        private void AturIsianKerusakan()
        {
            txtDendaKerusakan.Enabled = chkAdaKerusakan.Checked;
            txtKeterangan.Enabled = chkAdaKerusakan.Checked;
        }

        // Pratinjau denda dihitung ulang setiap kali isian berubah, sebelum disimpan.
        private void PerbaruiRincian()
        {
            btnProses.Enabled = sewaTerpilih != null;
            if (sewaTerpilih == null)
            {
                txtTerlambat.Clear();
                txtDenda.Clear();
                txtTotalDenda.Clear();
                return;
            }

            RincianDenda rincian = pengembalianController.HitungRincian(sewaTerpilih, dtpKembali.Value.Date,
                chkAdaKerusakan.Checked, txtDendaKerusakan.Text);
            txtTerlambat.Text = $"{rincian.HariTerlambat} hari";
            txtDenda.Text = Tampilan.Rupiah(rincian.DendaTerlambat);
            txtTotalDenda.Text = Tampilan.Rupiah(rincian.TotalDenda);
        }

        private void dgvSewa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvSewa.Rows[e.RowIndex].Tag is not Penyewaan sewa)
                return;

            sewaTerpilih = sewa;
            dtpKembali.MinDate = DateTimePicker.MinimumDateTime;
            dtpKembali.Value = DateTime.Today;
            if (sewa.TanggalMulai <= DateTime.Today)
                dtpKembali.MinDate = sewa.TanggalMulai;
            PerbaruiRincian();
        }

        private void dtpKembali_ValueChanged(object sender, EventArgs e)
        {
            PerbaruiRincian();
        }

        private void chkAdaKerusakan_CheckedChanged(object sender, EventArgs e)
        {
            AturIsianKerusakan();
            PerbaruiRincian();
        }

        private void txtDendaKerusakan_TextChanged(object sender, EventArgs e)
        {
            PerbaruiRincian();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            MuatData();
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            if (sewaTerpilih == null)
                return;
            if (!Tampilan.Konfirmasi($"Proses pengembalian {sewaTerpilih.Alat.Kode} oleh {sewaTerpilih.Penyewa.Nama}?\n" +
                                     $"Total denda: {txtTotalDenda.Text}"))
                return;

            Hasil hasil = pengembalianController.ProsesPengembalian(sewaTerpilih, dtpKembali.Value.Date,
                chkAdaKerusakan.Checked, txtDendaKerusakan.Text, txtKeterangan.Text);
            Tampilan.TampilkanHasil(hasil);
            if (hasil.Berhasil)
                MuatData();
        }
    }
}
