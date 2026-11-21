using System;
using System.Collections.Generic;
using System.Text;

namespace projek_pbo.model
{
    class LaporanPendapatan : Laporan
    {
        private readonly IReadOnlyList<DataPendapatan> data;

        public LaporanPendapatan(DateTime awal, DateTime akhir, IReadOnlyList<DataPendapatan> data) : base("Laporan Pendapatan", awal, akhir)
        {
            this.data = data;
        }
        public override HasilLaporan BuatLaporan()
        {
            var kolom = new[] {"Tanggal", "Penyewa", "Alat", "Jenis", "Keterangan", "Nominal"};
            var baris = data
                .Select(d => new object[] { d.Tanggal, d.Penyewa, d.Alat, d.Jenis, d.Keterangan, d.Nominal })
                .ToList();
            return new HasilLaporan(Judul, Periode, kolom, baris, "Total Pendapatan", data.Sum(d => d.Nominal), true);
        }
    }
}
