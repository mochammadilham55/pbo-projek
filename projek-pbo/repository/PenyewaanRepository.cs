using Npgsql;
using projek_pbo.model;

namespace projek_pbo.repository
{
    public class PenyewaanRepository : IPenyewaanRepository
    {
        // Kolom alat dibaca apa adanya (a.*) agar bisa dipetakan oleh AlatRepository.Petakan.
        // Kolom penyewaan dan penyewa diberi alias supaya tidak bentrok dengan kolom alat.
        private const string SqlPilih =
            "SELECT a.*, " +
            "       s.id AS sewa_id, s.tarif_per_hari AS sewa_tarif, s.tanggal_mulai, " +
            "       s.tanggal_rencana_kembali, s.status AS sewa_status, " +
            "       p.id AS penyewa_id, p.nama AS penyewa_nama, p.no_telepon, p.alamat " +
            "FROM penyewaan s " +
            "JOIN penyewa p ON p.id = s.penyewa_id " +
            "JOIN alat a ON a.kode = s.alat_kode ";

        private static Penyewaan Petakan(NpgsqlDataReader r)
        {
            var penyewa = new Penyewa(
                (int)r["penyewa_id"],
                (string)r["penyewa_nama"],
                r["no_telepon"] as string ?? "",
                r["alamat"] as string ?? "");

            return new Penyewaan(
                (int)r["sewa_id"],
                penyewa,
                AlatRepository.Petakan(r),
                (decimal)r["sewa_tarif"],
                r.GetFieldValue<DateTime>(r.GetOrdinal("tanggal_mulai")),
                r.GetFieldValue<DateTime>(r.GetOrdinal("tanggal_rencana_kembali")),
                Enum.Parse<StatusSewa>((string)r["sewa_status"]));
        }

        public List<Penyewaan> AmbilSewaAktif(string namaPenyewa)
        {
            return databaseHelper.AmbilDaftar(
                SqlPilih +
                "WHERE s.status = 'Aktif' AND p.nama ILIKE @nama " +
                "ORDER BY s.tanggal_rencana_kembali",
                Petakan,
                ("@nama", "%" + namaPenyewa.Trim() + "%"));
        }

        public List<Penyewaan> AmbilTerakhir(int jumlah)
        {
            return databaseHelper.AmbilDaftar(
                SqlPilih + "ORDER BY s.tanggal_mulai DESC, s.id DESC LIMIT @jumlah",
                Petakan,
                ("@jumlah", jumlah));
        }

        public int HitungAktif()
        {
            return Convert.ToInt32(databaseHelper.AmbilNilai(
                "SELECT COUNT(*) FROM penyewaan WHERE status = @status",
                ("@status", StatusSewa.Aktif.ToString())));
        }

        public int HitungTerlambat(DateTime hariIni)
        {
            return Convert.ToInt32(databaseHelper.AmbilNilai(
                "SELECT COUNT(*) FROM penyewaan WHERE status = @status AND tanggal_rencana_kembali < @hariIni",
                ("@status", StatusSewa.Aktif.ToString()),
                ("@hariIni", DateOnly.FromDateTime(hariIni))));
        }

        // Rentang tanggal [awal, akhir): awal ikut dihitung, akhir tidak.
        public decimal TotalPembayaranLunas(DateTime awal, DateTime akhir)
        {
            return Convert.ToDecimal(databaseHelper.AmbilNilai(
                "SELECT COALESCE(SUM(nominal), 0) FROM pembayaran " +
                "WHERE status = @status AND tanggal >= @awal AND tanggal < @akhir",
                ("@status", "Lunas"),
                ("@awal", DateOnly.FromDateTime(awal)),
                ("@akhir", DateOnly.FromDateTime(akhir))));
        }
    }
}
