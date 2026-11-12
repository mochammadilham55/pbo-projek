using projek_pbo.model;

namespace projek_pbo.repository
{
    public class PengembalianRepository : IPengembalianRepository
    {
        // Empat perubahan dalam satu transaksi: pengembalian, denda, status sewa, dan status alat.
        public void Simpan(Pengembalian pengembalian)
        {
            var sewa = pengembalian.Penyewaan;

            databaseHelper.JalankanTransaksi((conn, tx) =>
            {
                int idPengembalian = (int)databaseHelper.BuatCommand(conn, tx,
                    "INSERT INTO pengembalian (penyewaan_id, tanggal_kembali) " +
                    "VALUES (@sewa, @tanggal) RETURNING id",
                    ("@sewa", sewa.Id),
                    ("@tanggal", DateOnly.FromDateTime(pengembalian.TanggalKembali))).ExecuteScalar()!;

                foreach (IDenda denda in pengembalian.DaftarDenda)
                {
                    databaseHelper.BuatCommand(conn, tx,
                        "INSERT INTO denda (pengembalian_id, jenis, keterangan, nominal, hari_terlambat) " +
                        "VALUES (@pengembalian, @jenis, @keterangan, @nominal, @hari)",
                        ("@pengembalian", idPengembalian),
                        ("@jenis", denda is DendaTerlambat ? "Terlambat" : "Kerusakan"),
                        ("@keterangan", denda.Keterangan),
                        ("@nominal", denda.HitungDenda()),
                        ("@hari", (denda as DendaTerlambat)?.HariTerlambat)).ExecuteNonQuery();
                }

                databaseHelper.BuatCommand(conn, tx,
                    "UPDATE penyewaan SET status = @status WHERE id = @id",
                    ("@status", sewa.Status.ToString()),
                    ("@id", sewa.Id)).ExecuteNonQuery();

                databaseHelper.BuatCommand(conn, tx,
                    "UPDATE alat SET status = @status WHERE kode = @kode",
                    ("@status", sewa.Alat.Status.ToString()),
                    ("@kode", sewa.Alat.Kode)).ExecuteNonQuery();
            });
        }

        // Denda dihitung pada tanggal alat dikembalikan, rentang [awal, akhir).
        public decimal TotalDenda(DateTime awal, DateTime akhir)
        {
            return Convert.ToDecimal(databaseHelper.AmbilNilai(
                "SELECT COALESCE(SUM(d.nominal), 0) FROM denda d " +
                "JOIN pengembalian k ON k.id = d.pengembalian_id " +
                "WHERE k.tanggal_kembali >= @awal AND k.tanggal_kembali < @akhir",
                ("@awal", DateOnly.FromDateTime(awal)),
                ("@akhir", DateOnly.FromDateTime(akhir))));
        }
    }
}
