
using projek_pbo.model;
using projek_pbo.repository;

namespace projek_pbo.controller
{
    public class c_Penyewaan
    {
        private readonly PenyewaanRepository repository =
            new PenyewaanRepository();

        public List<AlatPertanian> AmbilAlatTersedia()
        {
            return repository.AmbilAlatTersedia();
        }

        public List<DataSewa> AmbilDaftarSewa()
        {
            return repository.AmbilDaftarSewa();
        }

        public List<Penyewaan> AmbilSewaAktif(
            string cariNamaPenyewa = "")
        {
            return repository.AmbilSewaAktif(
                cariNamaPenyewa);
        }

        public Hasil SimpanSewa(
            string nama,
            string telepon,
            string alamat,
            AlatPertanian alat,
            DateTime tanggalMulai,
            DateTime tanggalKembali,
            string metode,
            decimal jumlahDiterima,
            string bank,
            string referensi)
        {
            return Hasil.Coba(() =>
            {
                if (alat == null)
                    throw new ArgumentException(
                        "Pilih alat terlebih dahulu.");

                var penyewa = new Penyewa(
                    0, nama, telepon, alamat);

                var sewa = new Penyewaan(
                    0,
                    penyewa,
                    alat,
                    alat.TarifPerHari,
                    tanggalMulai,
                    tanggalKembali,
                    StatusSewa.Aktif);

                decimal total = sewa.HitungTotalBiaya();

                Pembayaran pembayaran;

                if (metode == "Tunai")
                {
                    pembayaran = new PembayaranTunai(
                        total, jumlahDiterima);
                }
                else if (metode == "Transfer")
                {
                    pembayaran = new PembayaranTransfer(
                        total,
                        jumlahDiterima,
                        bank,
                        referensi);
                }
                else
                {
                    throw new ArgumentException(
                        "Pilih metode pembayaran.");
                }

                repository.Simpan(sewa, pembayaran);

                return "Penyewaan berhasil disimpan. Total: " +
                       total.ToString("C0",
                           System.Globalization.CultureInfo
                               .GetCultureInfo("id-ID"));
            });
        }
    }
}
