
using Npgsql;
using projek_pbo.model;

namespace projek_pbo.repository
{
    public class PenyewaanRepository : IPenyewaanRepository
    {
        private const string SqlPilih =
            "SELECT a.*, " +
            "s.id AS sewa_id, " +
            "s.tarif_per_hari AS sewa_tarif, " +
            "s.tanggal_mulai, " +
            "s.tanggal_rencana_kembali, " +
            "s.status AS sewa_status, " +
            "p.id AS penyewa_id, " +
            "p.nama AS penyewa_nama, " +
            "p.no_telepon, p.alamat " +
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
                r.GetFieldValue<DateTime>(
                    r.GetOrdinal("tanggal_mulai")),
                r.GetFieldValue<DateTime>(
                    r.GetOrdinal("tanggal_rencana_kembali")),
                Enum.Parse<StatusSewa>(
                    (string)r["sewa_status"]));
        }

        // Mengambil alat yang tersedia untuk disewa.
        public List<AlatPertanian> AmbilAlatTersedia()
        {
            return new AlatRepository()
                .AmbilSemua()
                .Where(a => a.Status == StatusAlat.Tersedia)
                .ToList();
        }

        // Menyimpan penyewa, penyewaan, pembayaran,
        // dan mengubah status alat dalam satu transaksi.
        public void Simpan(
            Penyewaan sewa,
            Pembayaran pembayaran)
        {
            databaseHelper.JalankanTransaksi((conn, tx) =>
            {
                using var cmdPenyewa =
                    databaseHelper.BuatCommand(
                        conn, tx,
                        @"INSERT INTO penyewa
                          (nama, no_telepon, alamat)
                          VALUES (@nama, @telepon, @alamat)
                          RETURNING id",
                        ("@nama", sewa.Penyewa.Nama),
                        ("@telepon", sewa.Penyewa.NoTelepon),
                        ("@alamat", sewa.Penyewa.Alamat));

                int penyewaId =
                    Convert.ToInt32(cmdPenyewa.ExecuteScalar());

                using var cmdSewa =
                    databaseHelper.BuatCommand(
                        conn, tx,
                        @"INSERT INTO penyewaan
                          (penyewa_id, alat_kode, tarif_per_hari,
                           tanggal_mulai, tanggal_rencana_kembali,
                           status)
                          VALUES
                          (@penyewa, @alat, @tarif,
                           @mulai, @kembali, @status)
                          RETURNING id",
                        ("@penyewa", penyewaId),
                        ("@alat", sewa.Alat.Kode),
                        ("@tarif", sewa.TarifPerHari),
                        ("@mulai", DateOnly.FromDateTime(
                            sewa.TanggalMulai)),
                        ("@kembali", DateOnly.FromDateTime(
                            sewa.TanggalRencanaKembali)),
                        ("@status", StatusSewa.Aktif.ToString()));

                int sewaId =
                    Convert.ToInt32(cmdSewa.ExecuteScalar());

                using var cmdPembayaran =
                    databaseHelper.BuatCommand(
                        conn, tx,
                        @"INSERT INTO pembayaran
                          (penyewaan_id, metode, nominal,
                           tanggal, status, jumlah_diterima,
                           bank_tujuan, no_referensi)
                          VALUES
                          (@sewa, @metode, @nominal,
                           @tanggal, @status, @diterima,
                           @bank, @referensi)",
                        ("@sewa", sewaId),
                        ("@metode", pembayaran.Metode),
                        ("@nominal", pembayaran.Nominal),
                        ("@tanggal", DateOnly.FromDateTime(
                            pembayaran.Tanggal)),
                        ("@status", pembayaran.Status),
                        ("@diterima", pembayaran.JumlahDiterima),
                        ("@bank",
                            pembayaran.BankTujuan == ""
                            ? DBNull.Value
                            : pembayaran.BankTujuan),
                        ("@referensi",
                            pembayaran.NoReferensi == ""
                            ? DBNull.Value
                            : pembayaran.NoReferensi));

                cmdPembayaran.ExecuteNonQuery();

                using var cmdAlat =
                    databaseHelper.BuatCommand(
                        conn, tx,
                        @"UPDATE alat
                          SET status = @status
                          WHERE kode = @kode
                          AND status = @tersedia",
                        ("@status", StatusAlat.Disewa.ToString()),
                        ("@kode", sewa.Alat.Kode),
                        ("@tersedia",
                            StatusAlat.Tersedia.ToString()));

                int jumlahDiubah =
                    cmdAlat.ExecuteNonQuery();

                if (jumlahDiubah != 1)
                    throw new InvalidOperationException(
                        "Alat sudah tidak tersedia. Silakan pilih alat lain.");
            });
        }

        // Mengambil semua penyewaan untuk tabel.
        public List<DataSewa> AmbilDaftarSewa()
        {
            const string sql = @"
                SELECT
                    s.id,
                    p.nama AS penyewa,
                    a.kode AS alat,
                    s.tanggal_mulai,
                    s.tanggal_rencana_kembali,
                    s.tarif_per_hari,
                    COALESCE(
                        s.tarif_per_hari *
                        (s.tanggal_rencana_kembali -
                         s.tanggal_mulai), 0
                    ) AS biaya_dasar,
                    COALESCE(pb.nominal, 0) AS total,
                    COALESCE(pb.status, 'Belum dibayar')
                        AS status_pembayaran
                FROM penyewaan s
                JOIN penyewa p ON p.id = s.penyewa_id
                JOIN alat a ON a.kode = s.alat_kode
                LEFT JOIN pembayaran pb
                    ON pb.penyewaan_id = s.id
                ORDER BY s.id DESC";

            return databaseHelper.AmbilDaftar(
                sql,
                r => new DataSewa
                {
                    Id = (int)r["id"],
                    Penyewa = (string)r["penyewa"],
                    Alat = (string)r["alat"],
                    Mulai = ((DateOnly)r["tanggal_mulai"]).ToDateTime(TimeOnly.MinValue),
                    Kembali = ((DateOnly)r["tanggal_rencana_kembali"]).ToDateTime(TimeOnly.MinValue),
                    Tarif = (decimal)r["tarif_per_hari"],
                    BiayaDasar = (decimal)r["biaya_dasar"],
                    Total = (decimal)r["total"],
                    StatusPembayaran =
                        (string)r["status_pembayaran"]
                });
        }

        public List<Penyewaan> AmbilSewaAktif(
            string namaPenyewa)
        {
            return databaseHelper.AmbilDaftar(
                SqlPilih +
                "WHERE s.status = 'Aktif' " +
                "AND p.nama ILIKE @nama " +
                "ORDER BY s.tanggal_rencana_kembali",
                Petakan,
                ("@nama", "%" + namaPenyewa.Trim() + "%"));
        }

        public List<Penyewaan> AmbilTerakhir(int jumlah)
        {
            return databaseHelper.AmbilDaftar(
                SqlPilih +
                "ORDER BY s.tanggal_mulai DESC, s.id DESC " +
                "LIMIT @jumlah",
                Petakan,
                ("@jumlah", jumlah));
        }

        public int HitungAktif()
        {
            return Convert.ToInt32(
                databaseHelper.AmbilNilai(
                    "SELECT COUNT(*) FROM penyewaan " +
                    "WHERE status = @status",
                    ("@status", StatusSewa.Aktif.ToString())));
        }

        public int HitungTerlambat(DateTime hariIni)
        {
            return Convert.ToInt32(
                databaseHelper.AmbilNilai(
                    "SELECT COUNT(*) FROM penyewaan " +
                    "WHERE status = @status " +
                    "AND tanggal_rencana_kembali < @hariIni",
                    ("@status", StatusSewa.Aktif.ToString()),
                    ("@hariIni",
                        DateOnly.FromDateTime(hariIni))));
        }

        public decimal TotalPembayaranLunas(
            DateTime awal,
            DateTime akhir)
        {
            return Convert.ToDecimal(
                databaseHelper.AmbilNilai(
                    "SELECT COALESCE(SUM(nominal), 0) " +
                    "FROM pembayaran " +
                    "WHERE status = @status " +
                    "AND tanggal >= @awal AND tanggal < @akhir",
                    ("@status", "Lunas"),
                    ("@awal", DateOnly.FromDateTime(awal)),
                    ("@akhir", DateOnly.FromDateTime(akhir))));
        }
    }

    public class DataSewa
    {
        public int Id { get; set; }
        public string Penyewa { get; set; } = "";
        public string Alat { get; set; } = "";
        public DateTime Mulai { get; set; }
        public DateTime Kembali { get; set; }
        public decimal Tarif { get; set; }
        public decimal BiayaDasar { get; set; }
        public decimal Total { get; set; }
        public string StatusPembayaran { get; set; } = "";
    }
}
