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

        public List<Penyewa> AmbilPenyewa()
        {
            return databaseHelper.AmbilDaftar("SELECT * FROM penyewa ORDER BY nama, id",
                r => new Penyewa((int)r["id"], (string)r["nama"], r["no_telepon"] as string ?? "", r["alamat"] as string ?? ""));
        }

        public List<AlatPertanian> AmbilAlatTersedia()
        {
            return databaseHelper.AmbilDaftar("SELECT * FROM alat WHERE status = 'Tersedia' AND kondisi <> 'PerluServis' ORDER BY kode", AlatRepository.Petakan);
        }

        public List<RingkasanSewa> AmbilRiwayat(string cari)
        {
            return databaseHelper.AmbilDaftar(
                "SELECT q.*, COALESCE((SELECT SUM(nominal) FROM pembayaran b WHERE b.penyewaan_id = q.sewa_id AND b.status = 'Lunas'), 0) AS dibayar, " +
                "COALESCE((SELECT string_agg(DISTINCT metode, ', ') FROM pembayaran b WHERE b.penyewaan_id = q.sewa_id AND b.status = 'Lunas'), '-') AS metode_bayar " +
                "FROM (" + SqlPilih + "WHERE p.nama ILIKE @cari OR a.kode ILIKE @cari OR a.nama ILIKE @cari) q ORDER BY q.tanggal_mulai DESC, q.sewa_id DESC",
                r => new RingkasanSewa(Petakan(r), (decimal)r["dibayar"], (string)r["metode_bayar"]),
                ("@cari", "%" + cari.Trim() + "%"));
        }

        public int SimpanSewaDanPembayaran(Penyewaan sewa, Pembayaran bayar)
        {
            int id = 0;
            databaseHelper.JalankanTransaksi((conn, tx) =>
            {
                // UPDATE bersyarat mengunci alat dan mencegah dua petugas menyewa alat yang sama.
                using var kunci = databaseHelper.BuatCommand(conn, tx,
                    "UPDATE alat SET status = 'Disewa' WHERE kode = @kode AND status = 'Tersedia' AND kondisi <> 'PerluServis' AND tarif_per_hari = @tarif " +
                    "AND NOT EXISTS (SELECT 1 FROM penyewaan WHERE alat_kode = @kode AND status = 'Aktif')",
                    ("@kode", sewa.Alat.Kode), ("@tarif", sewa.TarifPerHari));
                if (kunci.ExecuteNonQuery() != 1)
                    throw new InvalidOperationException("Alat atau tarif telah berubah. Muat ulang data.");

                int idPenyewa = sewa.Penyewa.Id;
                if (idPenyewa == 0)
                {
                    using var pelanggan = databaseHelper.BuatCommand(conn, tx,
                        "INSERT INTO penyewa (nama, no_telepon, alamat) VALUES (@nama, @telepon, @alamat) RETURNING id",
                        ("@nama", sewa.Penyewa.Nama), ("@telepon", sewa.Penyewa.NoTelepon), ("@alamat", sewa.Penyewa.Alamat));
                    idPenyewa = (int)pelanggan.ExecuteScalar()!;
                }

                using var transaksi = databaseHelper.BuatCommand(conn, tx,
                    "INSERT INTO penyewaan (penyewa_id, alat_kode, tarif_per_hari, tanggal_mulai, tanggal_rencana_kembali, status) " +
                    "VALUES (@penyewa, @kode, @tarif, @mulai, @kembali, 'Aktif') RETURNING id",
                    ("@penyewa", idPenyewa), ("@kode", sewa.Alat.Kode), ("@tarif", sewa.TarifPerHari),
                    ("@mulai", DateOnly.FromDateTime(sewa.TanggalMulai)), ("@kembali", DateOnly.FromDateTime(sewa.TanggalRencanaKembali)));
                id = (int)transaksi.ExecuteScalar()!;

                using var pembayaran = databaseHelper.BuatCommand(conn, tx,
                    "INSERT INTO pembayaran (penyewaan_id, metode, nominal, tanggal, status, jumlah_diterima, bank_tujuan, no_referensi) " +
                    "VALUES (@id, @metode, @nominal, @tanggal, 'Lunas', @diterima, NULLIF(@bank, ''), NULLIF(@ref, ''))",
                    ("@id", id), ("@metode", bayar.Metode), ("@nominal", bayar.Nominal),
                    ("@tanggal", DateOnly.FromDateTime(DateTime.Today)), ("@diterima", bayar.JumlahDiterima),
                    ("@bank", bayar.Metode == "Transfer" ? bayar.BankTujuan : ""), ("@ref", bayar.Metode == "Transfer" ? bayar.NoReferensi : ""));
                pembayaran.ExecuteNonQuery();
            });
            return id;
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
