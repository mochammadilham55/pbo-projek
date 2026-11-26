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
                using var kunci = databaseHelper.BuatCommand(conn, tx,
                    "UPDATE penyewaan SET status = 'Selesai' WHERE id = @id AND status = 'Aktif'", ("@id", sewa.Id));
                if (kunci.ExecuteNonQuery() != 1)
                    throw new InvalidOperationException("Penyewaan sudah tidak aktif. Muat ulang data.");
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



                using var alat = databaseHelper.BuatCommand(conn, tx,
                    "UPDATE alat SET status = @status, kondisi = CASE WHEN @status = 'Rusak' THEN 'PerluServis' ELSE kondisi END WHERE kode = @kode AND status = 'Disewa'",
                    ("@status", pengembalian.AdaKerusakan ? "Rusak" : "Tersedia"),
                    ("@kode", sewa.Alat.Kode));
                if (alat.ExecuteNonQuery() != 1)
                    throw new InvalidOperationException("Status alat telah berubah. Muat ulang data.");
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
