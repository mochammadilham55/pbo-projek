using System;
using System.Collections.Generic;
using System.Text;

namespace projek_pbo.model
{
    public class LaporanAlat : Laporan
    {
        private readonly IReadOnlyList<DataAlatLaporan> data;
        public LaporanAlat(DateTime awal, DateTime akhir, IReadOnlyList<DataAlatLaporan> data) : base("Laporan Alat", awal, akhir)
        {
            this.data = data;
        }
        public override HasilLaporan BuatLaporan()
        {
            var kolom = new[] { "Kode", "Nama", "Jenis", "Status", "Jumlah Sewa", "Pendapatan Sewa" };
            var baris = data
                .Select(d => new object[]
                {
                    d.Alat.Kode, d.Alat.Nama, d.Alat.Jenis, d.Alat.Status.ToString(), d.JumlahSewa, d.PendapatanSewa
                })
                .ToList();

            return new HasilLaporan(Judul, Periode, kolom, baris, "Jumlah Alat", data.Count, false);
        }
    }
}
