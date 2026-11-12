using System.Globalization;
using projek_pbo.model;
using projek_pbo.repository;

namespace projek_pbo.controller
{
    public record RincianDenda(int HariTerlambat, decimal DendaTerlambat, decimal DendaKerusakan, decimal TotalDenda);

    public class c_Pengembalian
    {
        private static readonly CultureInfo Indonesia = new CultureInfo("id-ID");

        private readonly IPengembalianRepository pengembalianRepository = new PengembalianRepository();

        // Pratinjau di form; tidak menyimpan apa pun dan tidak melempar error.
        public RincianDenda HitungRincian(Penyewaan sewa, DateTime tanggalKembali, bool adaKerusakan, string nominalKerusakan)
        {
            int hariTerlambat = sewa.HitungHariTerlambat(tanggalKembali);
            decimal dendaTerlambat = new DendaTerlambat(hariTerlambat, sewa.TarifPerHari, sewa.HitungTotalBiaya()).HitungDenda();

            decimal dendaKerusakan = 0;
            if (adaKerusakan && decimal.TryParse(nominalKerusakan, NumberStyles.Number, Indonesia, out decimal nominal) && nominal > 0)
                dendaKerusakan = nominal;

            return new RincianDenda(hariTerlambat, dendaTerlambat, dendaKerusakan, dendaTerlambat + dendaKerusakan);
        }

        public Hasil ProsesPengembalian(Penyewaan sewa, DateTime tanggalKembali,
            bool adaKerusakan, string nominalKerusakan, string keteranganKerusakan)
        {
            return Hasil.Coba(() =>
            {
                var pengembalian = new Pengembalian(0, sewa, tanggalKembali);

                // Denda keterlambatan dibuat otomatis.
                if (pengembalian.HariTerlambat > 0)
                {
                    pengembalian.TambahDenda(new DendaTerlambat(
                        pengembalian.HariTerlambat, sewa.TarifPerHari, sewa.HitungTotalBiaya()));
                }

                if (adaKerusakan)
                    TambahDendaKerusakan(pengembalian, nominalKerusakan, keteranganKerusakan);

                pengembalian.Proses();
                pengembalianRepository.Simpan(pengembalian);

                return $"Pengembalian {sewa.Alat.Kode} oleh {sewa.Penyewa.Nama} berhasil diproses.\n" +
                       $"Total denda: Rp{pengembalian.TotalDenda().ToString("N0", Indonesia)}";
            });
        }

        private static void TambahDendaKerusakan(Pengembalian pengembalian, string nominal, string keterangan)
        {
            if (!decimal.TryParse(nominal.Trim(), NumberStyles.Number, Indonesia, out decimal nilai))
                throw new ArgumentException("Denda kerusakan harus berupa angka.");

            pengembalian.TambahDenda(new DendaKerusakan(nilai, keterangan));
        }
    }
}
