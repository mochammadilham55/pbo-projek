using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
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
            Navigasi.PasangSidebar(this, btnDashboard, btnKelolaAlat, btnKelolaSewa, btnKelolaPengembalian,
                btnLaporan, btnKelolaUser, btnLogout);
            btnTampilkan.Click += btnTampilkan_Click;

            if (c_Auth.PenggunaAktif != null)
                pnlUser.Text = $"Masuk sebagai: {c_Auth.PenggunaAktif.NamaLengkap}";
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
        private void btnTampilkan_Click(object? sender, EventArgs e)
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

        //Kolom dibuat ulang setiap kali karena ketiga jenis laporan punya kolom yang berbeda.
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

            //kolom angka rata kanan; ditentukan dari isi baris pertama.
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
        // dua event di bawah masih dipasang di designer, Hapus kedua method ini 
        // setelah eventnya dikosongkan di jendela properties.


        private void lblJudulHalaman_Click(object sender, EventArgs e)
        {

        }

        // sidebar button
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            new formDashboard().Show();
            this.Hide();
        }
        private void btnKelolaAlat_Click(object sender, EventArgs e)
        {
            new formKelolaAlat().Show();
            this.Hide();
        }

        private void btnKelolaPengembalian_Click(object sender, EventArgs e)
        {
            new formKelolaPengembalian().Show();
            this.Hide();
        }
        private void btnKelolaSewa_Click(object sender, EventArgs e)
        {
            new formKelolaSewa().Show();
            this.Hide();
        }
        private void btnKelolaUser_Click(object sender, EventArgs e)
        {
            new FormKelolaUser().Show();
            this.Hide();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormClosed += (s, e) => Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
            //lblTotal.Text = total.ToString("'Rp '#,##0");
        }
        private void dtpAwal_ValueChanged(object sender, EventArgs e)
        {
            dtpAkhir.MinDate = dtpAwal.Value;
            UpdateJudul();
        }
        //private void formLaporan(object sender, EventArgs e)
        //{
        //    //DateTime now = DateTime.Now;
        //    //dptAwal.Value = new DateTime(now.Year, now.Month, 1);
        //    //dptAkhir.Value = dptAwal_Value.AddMonths(1).AddDays(-1);
        //    //cmbJenis.SelectedIndex = 0;
        //}
        private void UpdateJudul()
        {
            lblJudulHalaman.Text = $"{cmbJenis.Text} ({dtpAwal.Value:dd/MM/yyyy} - {dtpAkhir.Value:dd/MM/yyyy})";
        }
        private void FilterBerubah(object sender, EventArgs e) => UpdateJudul();
        private DataTable AmbilData(DateTime awal, DateTime akhir)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Tanggal", typeof(string));
            dt.Columns.Add("Penyewa", typeof(string));
            dt.Columns.Add("Alat", typeof(string));
            dt.Columns.Add("Biaya sewa", typeof(decimal));
            dt.Columns.Add("Denda", typeof(decimal));
            dt.Columns.Add("Total", typeof(decimal));

            dt.Rows.Add("03/11/2026", "Budi", "TR-001", 900000, 0, 900000);
            dt.Rows.Add("02/11/2026", "Siti", "PA-002", 200000, 10000, 210000);
            dt.Rows.Add("01/11/2026", "Andi", "TR-002", 700000, 0, 700000);
            return dt;
        }
        private void TampilkanData(DataTable dt)
        {
            dgvLaporan.DataSource = dt;
            decimal total = dt.AsEnumerable().Sum(r => r.Field<decimal>("Total"));
            lblTotal.Text = "Total Pendapatan " + total.ToString("'Rp '#,##0");

            lblTotal.Text = total.ToString("'Rp '#,##0");
        }
        private void Tampilkan_Click(object sender, EventArgs e)
        {
            DataTable dt = AmbilData(dtpAwal.Value, dtpAkhir.Value);
            dgvLaporan.DataSource = dt;

            decimal total = 0;
            foreach (DataRow row in dt.Rows)
                total += Convert.ToDecimal(row["Total"]);

            lblTotal.Text = total.ToString("'Rp '#,##0");
        }
        private void FitGrid(int tinggiMaks)
        {
            int h = dgvLaporan.ColumnHeadersHeight
                + dgvLaporan.Rows.Cast<DataGridViewRow>().Sum(r => r.Height) + 2;
            dgvLaporan.Height = Math.Max(h, tinggiMaks);
        }
    }
}

