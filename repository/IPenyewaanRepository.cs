
using projek_pbo.model;

namespace projek_pbo.repository
{
    public interface IPenyewaanRepository
    {
        List<Penyewaan> AmbilSewaAktif(string namaPenyewa);

        List<Penyewaan> AmbilTerakhir(int jumlah);

        int HitungAktif();

        int HitungTerlambat(DateTime hariIni);

        decimal TotalPembayaranLunas(
            DateTime awal,
            DateTime akhir);
    }
}
