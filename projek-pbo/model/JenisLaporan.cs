using System;
using System.Collections.Generic;
using System.Text;

namespace projek_pbo.model
{
    public enum JenisLaporan
    {
        Pendapatan,
        Alat, 
        Denda
    }
    //Mengubah enum ke teks yang tampil di pilihan jenis laporan dan sebaliknya.
    public static class JenisLaporanTeks
    {
        public static readonly string[] Semua = { "Laporan Pendapatan", "Laporan Alat", "Laporan Denda" };
        public static string KeTeks(this JenisLaporan jenis)
        {
            return jenis switch
            {
                JenisLaporan.Pendapatan => "Laporan Pendapatan",
                JenisLaporan.Alat => "Laporan Alat",
                JenisLaporan.Denda => "Laporan Denda",
                _ => throw new ArgumentException("Jenis laporan tidak dikenal.")
            };
        }
        public static JenisLaporan DariTeks(string teks)
        {
            return teks switch
            {
                "Laporan Pendapatan" => JenisLaporan.Pendapatan,
                "Laporan Alat" => JenisLaporan.Alat,
                "Laporan Denda" => JenisLaporan.Denda,
                _ => throw new ArgumentException("Jenis laporan wajib dipilih.")
            };
        }
    }
}
