using projek_pbo.model;
using projek_pbo.repository;

namespace projek_pbo.controller
{
    // Baru berisi pengambilan sewa aktif untuk form pengembalian.
    // BuatSewa() dan CatatPembayaran() menyusul bersama form Kelola Sewa.
    public class c_Penyewaan
    {
        private readonly IPenyewaanRepository penyewaanRepository = new PenyewaanRepository();

        public List<Penyewaan> AmbilSewaAktif(string cariNamaPenyewa = "")
        {
            return penyewaanRepository.AmbilSewaAktif(cariNamaPenyewa);
        }
    }
}
