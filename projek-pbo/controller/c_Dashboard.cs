using System.Globalization;
using projek_pbo.model;
using projek_pbo.repository;

namespace projek_pbo.controller
{
    public class c_Dashboard
    {
        private const int JumlahTransaksiTerakhir = 10;
        private static readonly CultureInfo Indonesia = new CultureInfo("id-ID");

        private readonly IAlatRepository alatRepository = new AlatRepository();
        private readonly IPenyewaanRepository penyewaanRepository = new PenyewaanRepository();
        private readonly IPengembalianRepository pengembalianRepository = new PengembalianRepository();

        // Urutan kartu: alat tersedia, sewa aktif, sewa terlambat, pendapatan bulan ini.
        public List<Kartu> AmbilKartu()
        {
            DateTime hariIni = DateTime.Today;
            DateTime awalBulan = new DateTime(hariIni.Year, hariIni.Month, 1);
            DateTime awalBulanDepan = awalBulan.AddMonths(1);

            // Pendapatan = pembayaran yang sudah lunas + denda pengembalian, keduanya pada bulan berjalan.
            decimal pendapatan = penyewaanRepository.TotalPembayaranLunas(awalBulan, awalBulanDepan)
                               + pengembalianRepository.TotalDenda(awalBulan, awalBulanDepan);

            return new List<Kartu>
            {
                new Kartu("Alat Tersedia", alatRepository.HitungTersedia().ToString()),
                new Kartu("Sewa Aktif", penyewaanRepository.HitungAktif().ToString()),
                new Kartu("Sewa Terlambat", penyewaanRepository.HitungTerlambat(hariIni).ToString()),
                new Kartu("Pendapatan Bulan Ini", "Rp" + pendapatan.ToString("N0", Indonesia))
            };
        }

        public List<Penyewaan> AmbilTransaksiTerakhir()
        {
            return penyewaanRepository.AmbilTerakhir(JumlahTransaksiTerakhir);
        }
    }
}
