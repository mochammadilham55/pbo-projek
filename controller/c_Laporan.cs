using System;
using System.Collections.Generic;
using System.Text;
using projek_pbo.model;
using projek_pbo.repository;

namespace projek_pbo.controller
{
    public class c_Laporan
    {
        private readonly ILaporanRepository laporanRepository = new LaporanRepository();

        // Hasil.Berhasil = false berarti laporan null dan Hasil.Pesan berisi alasannya untuk View.
        public (Hasil Hasil, HasilLaporan? Laporan) BuatLaporan(JenisLaporan jenis, DateTime awal, DateTime akhir)
        {
            HasilLaporan? isi = null;

            Hasil hasil = Hasil.Coba(() =>
            {
                PastikanAdmin();

                // Pada form periode akhir ikut dihitung, sedangkan repository memakai batas akhir yang tidak ikut.
                DateTime awalData = awal.Date;
                DateTime batasAkhir = akhir.Date.AddDays(1);

                Laporan laporan = jenis switch
                {
                    JenisLaporan.Pendapatan => new LaporanPendapatan(awal, akhir,
                        laporanRepository.AmbilPendapatan(awalData, batasAkhir)),
                    JenisLaporan.Alat => new LaporanAlat(awal, akhir,
                        laporanRepository.AmbilPemakaianAlat(awalData, batasAkhir)),
                    JenisLaporan.Denda => new LaporanDenda(awal, akhir,
                        laporanRepository.AmbilDenda(awalData, batasAkhir)),
                    _ => throw new ArgumentException("Jenis laporan tidak dikenal.")
                };

                isi = laporan.BuatLaporan();
                return $"{isi.Judul} berhasil dibuat.";
            });

            return (hasil, isi);
        }

        private static void PastikanAdmin()
        {
            if (c_Auth.PenggunaAktif is not Admin)
                throw new InvalidOperationException("Hanya Admin yang dapat melihat laporan.");
        }
    }
}
