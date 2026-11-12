using Npgsql;
using projek_pbo.model;

namespace projek_pbo.repository
{
    public class AlatRepository : IAlatRepository
    {
        private const string SqlPilih = "SELECT * FROM alat";

        // Satu tabel untuk seluruh hierarki: kolom jenis menentukan subclass yang dibuat.
        internal static AlatPertanian Petakan(NpgsqlDataReader r)
        {
            string kode = (string)r["kode"];
            string nama = (string)r["nama"];
            string merek = (string)r["merek"];
            string deskripsi = r["deskripsi"] as string ?? "";
            int tahun = (int)r["tahun_keluaran"];
            var kondisi = Enum.Parse<KondisiAlat>((string)r["kondisi"]);
            decimal tarif = (decimal)r["tarif_per_hari"];
            var status = Enum.Parse<StatusAlat>((string)r["status"]);

            string jenis = (string)r["jenis"];
            if (jenis == "Traktor")
            {
                return new Traktor(kode, nama, merek, deskripsi, tahun, kondisi, tarif, status,
                    (int)r["tenaga_hp"],
                    (decimal)r["kapasitas_tangki"],
                    Enum.Parse<JenisTraktor>((string)r["jenis_traktor"]));
            }
            if (jenis == "PompaAir")
            {
                return new PompaAir(kode, nama, merek, deskripsi, tahun, kondisi, tarif, status,
                    (decimal)r["debit_liter_per_menit"],
                    (decimal)r["berat_kg"],
                    (string)r["bahan_bakar"],
                    (decimal)r["diameter_pipa_inci"]);
            }
            throw new InvalidOperationException($"Jenis alat \"{jenis}\" tidak dikenal.");
        }

        public List<AlatPertanian> AmbilSemua()
        {
            return databaseHelper.AmbilDaftar(SqlPilih + " ORDER BY kode", Petakan);
        }

        public AlatPertanian? Cari(string kode)
        {
            return databaseHelper.AmbilDaftar(SqlPilih + " WHERE kode = @kode", Petakan, ("@kode", kode.Trim().ToUpper()))
                .FirstOrDefault();
        }

        public List<AlatPertanian> Cari(string kataKunci, string? jenis)
        {
            const string sql = SqlPilih + " WHERE (kode ILIKE @kata OR nama ILIKE @kata OR merek ILIKE @kata)";
            string kata = "%" + kataKunci.Trim() + "%";

            if (jenis == null)
                return databaseHelper.AmbilDaftar(sql + " ORDER BY kode", Petakan, ("@kata", kata));

            return databaseHelper.AmbilDaftar(sql + " AND jenis = @jenis ORDER BY kode", Petakan,
                ("@kata", kata), ("@jenis", jenis));
        }

        public void Tambah(AlatPertanian alat)
        {
            databaseHelper.Eksekusi(
                "INSERT INTO alat (kode, nama, jenis, merek, deskripsi, tahun_keluaran, kondisi, tarif_per_hari, status, " +
                "tenaga_hp, kapasitas_tangki, jenis_traktor, debit_liter_per_menit, berat_kg, bahan_bakar, diameter_pipa_inci) " +
                "VALUES (@kode, @nama, @jenis, @merek, @deskripsi, @tahun, @kondisi, @tarif, @status, " +
                "@tenaga, @tangki, @jenisTraktor, @debit, @berat, @bahanBakar, @pipa)",
                Parameter(alat));
        }

        public void Ubah(AlatPertanian alat)
        {
            databaseHelper.Eksekusi(
                "UPDATE alat SET nama = @nama, jenis = @jenis, merek = @merek, deskripsi = @deskripsi, " +
                "tahun_keluaran = @tahun, kondisi = @kondisi, tarif_per_hari = @tarif, status = @status, " +
                "tenaga_hp = @tenaga, kapasitas_tangki = @tangki, jenis_traktor = @jenisTraktor, " +
                "debit_liter_per_menit = @debit, berat_kg = @berat, bahan_bakar = @bahanBakar, " +
                "diameter_pipa_inci = @pipa WHERE kode = @kode",
                Parameter(alat));
        }

        public void Hapus(string kode)
        {
            try
            {
                databaseHelper.Eksekusi("DELETE FROM alat WHERE kode = @kode", ("@kode", kode));
            }
            catch (PostgresException ex) when (ex.SqlState == PostgresErrorCodes.ForeignKeyViolation)
            {
                throw new InvalidOperationException("Alat tidak dapat dihapus karena sudah memiliki riwayat sewa.");
            }
        }

        // Kolom khusus jenis lain diisi NULL.
        private static (string, object?)[] Parameter(AlatPertanian alat)
        {
            var traktor = alat as Traktor;
            var pompa = alat as PompaAir;

            return new (string, object?)[]
            {
                ("@kode", alat.Kode),
                ("@nama", alat.Nama),
                ("@jenis", alat is Traktor ? "Traktor" : "PompaAir"),
                ("@merek", alat.Merek),
                ("@deskripsi", alat.Deskripsi),
                ("@tahun", alat.TahunKeluaran),
                ("@kondisi", alat.Kondisi.ToString()),
                ("@tarif", alat.TarifPerHari),
                ("@status", alat.Status.ToString()),
                ("@tenaga", traktor?.TenagaHp),
                ("@tangki", traktor?.KapasitasTangki),
                ("@jenisTraktor", traktor?.JenisTraktor.ToString()),
                ("@debit", pompa?.DebitLiterPerMenit),
                ("@berat", pompa?.BeratKg),
                ("@bahanBakar", pompa?.BahanBakar),
                ("@pipa", pompa?.DiameterPipaInci)
            };
        }

        public int HitungTersedia()
        {
            return Convert.ToInt32(databaseHelper.AmbilNilai(
                "SELECT COUNT(*) FROM alat WHERE status = @status",
                ("@status", StatusAlat.Tersedia.ToString())));
        }
    }
}
