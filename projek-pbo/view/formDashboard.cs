using projek_pbo.controller;
using projek_pbo.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projek_pbo.view
{
    public partial class formDashboard : Form
    {
        private static readonly Color WarnaTerlambat = Color.FromArgb(179, 65, 47);

        private readonly c_Dashboard controller = new c_Dashboard();

        public formDashboard()
        {
            InitializeComponent();
            Navigasi.PasangSidebar(this, btnDashboard, btnAlat, btnSewa, btnPengembaian,
                btnLaporan, btnUser, btnLogout);
            Shown += (s, e) => dgvTransaksi.ClearSelection();
            MuatData();
        }

        private void MuatData()
        {
            try
            {
                List<Kartu> kartu = controller.AmbilKartu();
                lblAlat.Text = kartu[0].Nilai;
                lblSewa.Text = kartu[1].Nilai;
                lblTelat.Text = kartu[2].Nilai;
                lblPendapatan.Text = kartu[3].Nilai;

                dgvTransaksi.Rows.Clear();
                foreach (Penyewaan sewa in controller.AmbilTransaksiTerakhir())
                {
                    bool terlambat = sewa.Status == StatusSewa.Aktif && sewa.HitungHariTerlambat(DateTime.Today) > 0;
                    int baris = dgvTransaksi.Rows.Add(Tampilan.Tanggal(sewa.TanggalMulai), sewa.Penyewa.Nama,
                        $"{sewa.Alat.Kode} - {sewa.Alat.Nama}", sewa.Alat.Jenis,
                        Tampilan.Rupiah(sewa.HitungTotalBiaya()), terlambat ? "Terlambat" : sewa.Status.ToString());
                    if (terlambat)
                        dgvTransaksi.Rows[baris].Cells[Column4.Index].Style.ForeColor = WarnaTerlambat;
                }
            }
            catch (Exception ex)
            {
                Tampilan.Error(ex);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
