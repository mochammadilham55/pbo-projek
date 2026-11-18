using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace projek_pbo.view
{
    public partial class formLaporan : Form
    {
        public formLaporan()
        {
            InitializeComponent();
            Navigasi.PasangSidebar(this, btnDashboard, btnKelolaAlat, btnKelolaSewa, btnKelolaPengembalian,
                btnLaporan, btnKelolaUser, btnLogout);
            SidebarStyle.Apply(pnlSidebar, btnLaporan);
        }

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



        private void formLaporan_Load(object sender, EventArgs e)
        {

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

