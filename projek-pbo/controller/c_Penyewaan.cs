using projek_pbo.model;
using projek_pbo.repository;

namespace projek_pbo.controller
{
    public class c_Penyewaan
    {
        private readonly IPenyewaanRepository penyewaanRepository = new PenyewaanRepository();

        private static void PastikanAkses()
        {
            if (c_Auth.PenggunaAktif?.MenuTersedia().Contains(MenuAplikasi.KelolaSewa) != true)
                throw new InvalidOperationException("Anda tidak memiliki akses Kelola Sewa.");
        }

        public List<Penyewaan> AmbilSewaAktif(string cariNamaPenyewa = "")
        {
            PastikanAkses();
            return penyewaanRepository.AmbilSewaAktif(cariNamaPenyewa);
        }

        public List<Penyewa> AmbilPenyewa() { PastikanAkses(); return penyewaanRepository.AmbilPenyewa(); }
        public List<AlatPertanian> AmbilAlatTersedia() { PastikanAkses(); return penyewaanRepository.AmbilAlatTersedia(); }
        public List<RingkasanSewa> AmbilRiwayat(string cari = "") { PastikanAkses(); return penyewaanRepository.AmbilRiwayat(cari); }

        public Penyewaan Hitung(Penyewa penyewa, AlatPertanian alat, DateTime mulai, DateTime kembali)
        {
            return new Penyewaan(0, penyewa, alat, alat.TarifPerHari, mulai, kembali, StatusSewa.Aktif);
        }

        public Hasil BuatSewa(Penyewa penyewa, AlatPertanian alat, DateTime mulai, DateTime kembali,
            string metode, decimal diterima, string bank, string referensi)
        {
            return Hasil.Coba(() =>
            {
                PastikanAkses();
                if (mulai.Date != DateTime.Today)
                    throw new ArgumentException("Transaksi sewa langsung dimulai hari ini.");
                if (penyewa.Nama.Length > 100 || penyewa.NoTelepon.Length > 20 || penyewa.Alamat.Length > 200)
                    throw new ArgumentException("Data penyewa melebihi panjang yang diizinkan.");
                if (alat.Status != StatusAlat.Tersedia || alat.Kondisi == KondisiAlat.PerluServis)
                    throw new InvalidOperationException("Alat tidak tersedia untuk disewa.");
                var sewa = Hitung(penyewa, alat, mulai, kembali);
                var bayar = new Pembayaran(metode, sewa.HitungTotalBiaya(), diterima, bank, referensi);
                int id = penyewaanRepository.SimpanSewaDanPembayaran(sewa, bayar);
                return $"Sewa #{id} berhasil disimpan. Pembayaran lunas. Kembalian: Rp{bayar.Kembalian:N2}";
            });
        }
    }
}
