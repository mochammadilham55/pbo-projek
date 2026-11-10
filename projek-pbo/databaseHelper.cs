using Npgsql;

namespace projek_pbo
{
    internal static class databaseHelper
    {
        private static readonly string connectionString =
            "Host=localhost;Port=5432;Database=agri-rent;Username=postgres;Password=1";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }

        // Semua nilai masuk sebagai parameter (@nama), tidak pernah digabung ke string SQL.
        public static NpgsqlCommand BuatCommand(NpgsqlConnection conn, NpgsqlTransaction? tx,
            string sql, params (string Nama, object? Nilai)[] parameter)
        {
            var cmd = new NpgsqlCommand(sql, conn, tx);
            foreach (var (nama, nilai) in parameter)
                cmd.Parameters.AddWithValue(nama, nilai ?? DBNull.Value);
            return cmd;
        }

        public static int Eksekusi(string sql, params (string Nama, object? Nilai)[] parameter)
        {
            using var conn = GetConnection();
            conn.Open();
            using var cmd = BuatCommand(conn, null, sql, parameter);
            return cmd.ExecuteNonQuery();
        }

        public static object? AmbilNilai(string sql, params (string Nama, object? Nilai)[] parameter)
        {
            using var conn = GetConnection();
            conn.Open();
            using var cmd = BuatCommand(conn, null, sql, parameter);
            object? hasil = cmd.ExecuteScalar();
            return hasil == DBNull.Value ? null : hasil;
        }

        public static List<T> AmbilDaftar<T>(string sql, Func<NpgsqlDataReader, T> petakan,
            params (string Nama, object? Nilai)[] parameter)
        {
            var daftar = new List<T>();
            using var conn = GetConnection();
            conn.Open();
            using var cmd = BuatCommand(conn, null, sql, parameter);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
                daftar.Add(petakan(reader));
            return daftar;
        }

        // Menjalankan beberapa perintah sebagai satu kesatuan: berhasil semua atau dibatalkan semua.
        public static void JalankanTransaksi(Action<NpgsqlConnection, NpgsqlTransaction> langkah)
        {
            using var conn = GetConnection();
            conn.Open();
            using var tx = conn.BeginTransaction();
            try
            {
                langkah(conn, tx);
                tx.Commit();
            }
            catch
            {
                tx.Rollback();
                throw;
            }
        }

        public static void InisialisasiDatabase()
        {
            JalankanTransaksi((conn, tx) =>
            {
                BuatCommand(conn, tx, SqlBuatTabel).ExecuteNonQuery();

                long jumlahPengguna = (long)BuatCommand(conn, tx, "SELECT COUNT(*) FROM pengguna").ExecuteScalar()!;
                if (jumlahPengguna == 0)
                    BuatCommand(conn, tx, SqlPenggunaAwal).ExecuteNonQuery();

                long jumlahAlat = (long)BuatCommand(conn, tx, "SELECT COUNT(*) FROM alat").ExecuteScalar()!;
                if (jumlahAlat == 0)
                    BuatCommand(conn, tx, SqlDataContoh).ExecuteNonQuery();
            });
        }

        private const string SqlBuatTabel = @"
CREATE TABLE IF NOT EXISTS pengguna (
    id            SERIAL PRIMARY KEY,
    username      VARCHAR(50)  NOT NULL UNIQUE,
    nama_lengkap  VARCHAR(100) NOT NULL,
    password      VARCHAR(255) NOT NULL,
    peran         VARCHAR(20)  NOT NULL CHECK (peran IN ('Admin', 'Petugas'))
);

CREATE TABLE IF NOT EXISTS alat (
    kode                   VARCHAR(10)   PRIMARY KEY,
    nama                   VARCHAR(100)  NOT NULL,
    jenis                  VARCHAR(20)   NOT NULL CHECK (jenis IN ('Traktor', 'PompaAir')),
    merek                  VARCHAR(50)   NOT NULL,
    deskripsi              TEXT,
    tahun_keluaran         INT           NOT NULL,
    kondisi                VARCHAR(20)   NOT NULL,
    tarif_per_hari         NUMERIC(12,2) NOT NULL CHECK (tarif_per_hari > 0),
    status                 VARCHAR(20)   NOT NULL,
    tenaga_hp              INT,
    kapasitas_tangki       NUMERIC(8,2),
    jenis_traktor          VARCHAR(10),
    debit_liter_per_menit  NUMERIC(8,2),
    berat_kg               NUMERIC(8,2),
    bahan_bakar            VARCHAR(20),
    diameter_pipa_inci     NUMERIC(4,1)
);

CREATE TABLE IF NOT EXISTS penyewa (
    id          SERIAL PRIMARY KEY,
    nama        VARCHAR(100) NOT NULL,
    no_telepon  VARCHAR(20),
    alamat      VARCHAR(200)
);

CREATE TABLE IF NOT EXISTS penyewaan (
    id                       SERIAL PRIMARY KEY,
    penyewa_id               INT           NOT NULL REFERENCES penyewa(id),
    alat_kode                VARCHAR(10)   NOT NULL REFERENCES alat(kode),
    tarif_per_hari           NUMERIC(12,2) NOT NULL,
    tanggal_mulai            DATE          NOT NULL,
    tanggal_rencana_kembali  DATE          NOT NULL,
    status                   VARCHAR(20)   NOT NULL,
    CHECK (tanggal_rencana_kembali > tanggal_mulai)
);

CREATE TABLE IF NOT EXISTS pembayaran (
    id               SERIAL PRIMARY KEY,
    penyewaan_id     INT           NOT NULL REFERENCES penyewaan(id) ON DELETE CASCADE,
    metode           VARCHAR(20)   NOT NULL,
    nominal          NUMERIC(12,2) NOT NULL,
    tanggal          DATE          NOT NULL,
    status           VARCHAR(30)   NOT NULL,
    jumlah_diterima  NUMERIC(12,2),
    bank_tujuan      VARCHAR(50),
    no_referensi     VARCHAR(50)
);

CREATE TABLE IF NOT EXISTS pengembalian (
    id               SERIAL PRIMARY KEY,
    penyewaan_id     INT  NOT NULL UNIQUE REFERENCES penyewaan(id),
    tanggal_kembali  DATE NOT NULL
);

CREATE TABLE IF NOT EXISTS denda (
    id               SERIAL PRIMARY KEY,
    pengembalian_id  INT           NOT NULL REFERENCES pengembalian(id) ON DELETE CASCADE,
    jenis            VARCHAR(20)   NOT NULL,
    keterangan       VARCHAR(200),
    nominal          NUMERIC(12,2) NOT NULL,
    hari_terlambat   INT
);";

        private const string SqlPenggunaAwal = @"
INSERT INTO pengguna (username, nama_lengkap, password, peran) VALUES
    ('admin',   'Administrator',     'admin123',   'Admin'),
    ('petugas', 'Petugas Persewaan', 'petugas123', 'Petugas');";

        // Data contoh untuk menguji Kelola Alat dan Kelola Pengembalian sebelum fitur Sewa selesai.
        // Tanggal dibuat relatif terhadap hari ini, jadi selalu ada sewa yang terlambat.
        private const string SqlDataContoh = @"
INSERT INTO alat (kode, nama, jenis, merek, deskripsi, tahun_keluaran, kondisi, tarif_per_hari, status,
                  tenaga_hp, kapasitas_tangki, jenis_traktor) VALUES
    ('TR-001', 'Traktor Roda 4',  'Traktor', 'Kubota', 'Traktor untuk pengolahan lahan sawah luas', 2020, 'Baik',  800000, 'Disewa',   34, 38, 'Roda4'),
    ('TR-002', 'Traktor Tangan',  'Traktor', 'Quick',  'Traktor tangan untuk lahan sempit',         2019, 'Cukup', 250000, 'Disewa',   10,  6, 'Roda2'),
    ('TR-003', 'Traktor Roda 4',  'Traktor', 'Yanmar', 'Traktor serbaguna dengan bajak rotari',      2022, 'Baik',  900000, 'Tersedia', 39, 42, 'Roda4');

INSERT INTO alat (kode, nama, jenis, merek, deskripsi, tahun_keluaran, kondisi, tarif_per_hari, status,
                  debit_liter_per_menit, berat_kg, bahan_bakar, diameter_pipa_inci) VALUES
    ('PA-001', 'Pompa Air Irigasi', 'PompaAir', 'Honda',   'Pompa irigasi untuk sawah',          2021, 'Baik',        75000,  'Disewa',   1100, 27,  'Bensin',  3),
    ('PA-002', 'Pompa Air Diesel',  'PompaAir', 'Kubota',  'Pompa diesel untuk sumber air jauh', 2018, 'PerluServis', 100000, 'Rusak',    1000, 45,  'Solar',   3),
    ('PA-003', 'Pompa Air Mini',    'PompaAir', 'Shimizu', 'Pompa listrik untuk kebun',          2023, 'Baik',        50000,  'Tersedia',   30,  8.5,'Listrik', 1);

INSERT INTO penyewa (nama, no_telepon, alamat) VALUES
    ('Budi Santoso', '081234567801', 'Desa Sukorejo, Jember'),
    ('Siti Aminah',  '081234567802', 'Desa Kemuning, Jember'),
    ('Ahmad Fauzi',  '081234567803', 'Desa Ajung, Jember');

INSERT INTO penyewaan (penyewa_id, alat_kode, tarif_per_hari, tanggal_mulai, tanggal_rencana_kembali, status) VALUES
    ((SELECT id FROM penyewa WHERE nama = 'Budi Santoso'), 'TR-001', 800000, CURRENT_DATE - 3,  CURRENT_DATE + 2, 'Aktif'),
    ((SELECT id FROM penyewa WHERE nama = 'Siti Aminah'),  'PA-001',  75000, CURRENT_DATE - 10, CURRENT_DATE - 3, 'Aktif'),
    ((SELECT id FROM penyewa WHERE nama = 'Ahmad Fauzi'),  'TR-002', 250000, CURRENT_DATE - 12, CURRENT_DATE - 2, 'Aktif');

INSERT INTO pembayaran (penyewaan_id, metode, nominal, tanggal, status, jumlah_diterima)
SELECT p.id, 'Tunai', v.nominal, p.tanggal_mulai, 'Lunas', v.nominal
FROM penyewaan p
JOIN (VALUES ('TR-001', 4000000), ('PA-001', 525000), ('TR-002', 2425000)) AS v(alat_kode, nominal)
  ON v.alat_kode = p.alat_kode;";
    }
}
