using Npgsql;
using projek_pbo.model;

namespace projek_pbo.repository
{
    public class PenggunaRepository : IPenggunaRepository
    {
        private const string SqlPilih = "SELECT id, nama_lengkap, username, password, peran FROM pengguna";

        // Kolom peran menentukan objek yang dibuat: Admin atau Petugas.
        private static Pengguna Petakan(NpgsqlDataReader r)
        {
            return Pengguna.Buat(
                (string)r["peran"],
                (int)r["id"],
                (string)r["nama_lengkap"],
                (string)r["username"],
                (string)r["password"]);
        }

        public List<Pengguna> AmbilSemua()
        {
            return databaseHelper.AmbilDaftar(SqlPilih + " ORDER BY peran, nama_lengkap", Petakan);
        }

        public Pengguna? CariById(int id)
        {
            return databaseHelper.AmbilDaftar(SqlPilih + " WHERE id = @id", Petakan, ("@id", id))
                .FirstOrDefault();
        }

        public Pengguna? CariByUsername(string username)
        {
            return databaseHelper.AmbilDaftar(SqlPilih + " WHERE username = @username", Petakan, ("@username", username))
                .FirstOrDefault();
        }

        public bool UsernameSudahDipakai(string username, int kecualiId)
        {
            object? jumlah = databaseHelper.AmbilNilai(
                "SELECT COUNT(*) FROM pengguna WHERE LOWER(username) = LOWER(@username) AND id <> @id",
                ("@username", username), ("@id", kecualiId));
            return Convert.ToInt64(jumlah) > 0;
        }

        public void Tambah(Pengguna pengguna)
        {
            databaseHelper.Eksekusi(
                "INSERT INTO pengguna (username, nama_lengkap, password, peran) " +
                "VALUES (@username, @nama, @password, @peran)",
                ("@username", pengguna.Username),
                ("@nama", pengguna.NamaLengkap),
                ("@password", pengguna.AmbilPasswordUntukDisimpan()),
                ("@peran", pengguna.Peran));
        }

        public void Ubah(Pengguna pengguna)
        {
            databaseHelper.Eksekusi(
                "UPDATE pengguna SET username = @username, nama_lengkap = @nama, " +
                "password = @password, peran = @peran WHERE id = @id",
                ("@username", pengguna.Username),
                ("@nama", pengguna.NamaLengkap),
                ("@password", pengguna.AmbilPasswordUntukDisimpan()),
                ("@peran", pengguna.Peran),
                ("@id", pengguna.Id));
        }

        public void Hapus(int id)
        {
            databaseHelper.Eksekusi("DELETE FROM pengguna WHERE id = @id", ("@id", id));
        }
    }
}
