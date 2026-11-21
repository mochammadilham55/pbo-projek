using System;
using System.Collections.Generic;
using System.Text;

namespace projek_pbo.model
{
    public class LaporanDenda : Laporan
    {
        private readonly IReadOnlyList<DataDenda> data;

        public LaporanDenda(DateTime awal, DateTime akhir, IReadOnlyList<DataDenda> data)  : base("Laporan Denda", awal, akhir)
        {
            this.data = data;
        }
        public override HasilLaporan BuatLaporan()
        {
            var kolom = new[] { "Tanggal Kembali", "Penyewa", "Alat", "Jenis Denda", "Keterangan", "Nominal" };
            var baris = data
                .Select(d => new object[] { d.Tanggal, d.Penyewa, d.Alat, d.Jenis, d.Keterangan, d.Nominal })
                .ToList();
            return new HasilLaporan(Judul, Periode, kolom, baris, "Total Denda", data.Sum(d => d.Nominal), true);
        }
    }
}
