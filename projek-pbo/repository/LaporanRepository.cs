using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using projek_pbo.model;

namespace projek_pbo.repository
{
    public class LaporanRepository : ILaporanRepository
    {
        // Pendapatan = pembayaran Lunas (menurut tanggal bayar) + denda (menurut tanggal kembali),
        // sama dengan cara Dashboard menghitung pendapatan.
        private const string SqlPendapatan =
            "SELECT b.tanggal AS tanggal, p.nama AS penyewa, a.kode AS alat_kode, a.nama AS alat_nama, " +
            "       CAST('Sewa' AS VARCHAR) AS jenis, b.metode AS keterangan, b.nominal AS nominal " +
            "FROM pembayaran b " +
            "JOIN penyewaan s ON s.id = b.penyewaan_id " +
            "JOIN penyewa p ON p.id = s.penyewa_id " +
            "JOIN alat a ON a.kode = s.alat_kode " +
            "WHERE b.status = 'Lunas' AND b.tanggal >= @awal AND b.tanggal < @akhir " +
            "UNION ALL " +
            "SELECT k.tanggal_kembali, p.nama, a.kode, a.nama, " +
            "       CAST('Denda' AS VARCHAR), COALESCE(d.keterangan, d.jenis), d.nominal " +
            "FROM denda d " +
            "JOIN pengembalian k ON k.id = d.pengembalian_id " +
            "JOIN penyewaan s ON s.id = k.penyewaan_id " +
            "JOIN penyewa p ON p.id = s.penyewa_id " +
            "JOIN alat a ON a.kode = s.alat_kode " +
            "WHERE k.tanggal_kembali >= @awal AND k.tanggal_kembali < @akhir " +
            "ORDER BY 1, 2";

        // Kolom alat dibaca apa adanya (a.*) agar bisa dipetakan oleh AlatRepository.Petakan.
        // Dua subquery dipisah supaya jumlah sewa tidak berlipat bila satu sewa punya beberapa pembayaran.
        private const string SqlPemakaianAlat =
            "SELECT a.*, " +
            "       (SELECT COUNT(*) FROM penyewaan s " +
            "        WHERE s.alat_kode = a.kode AND s.tanggal_mulai >= @awal AND s.tanggal_mulai < @akhir) AS jumlah_sewa, " +
            "       (SELECT COALESCE(SUM(b.nominal), 0) FROM pembayaran b " +
            "        JOIN penyewaan s ON s.id = b.penyewaan_id " +
            "        WHERE s.alat_kode = a.kode AND b.status = 'Lunas' " +
            "          AND b.tanggal >= @awal AND b.tanggal < @akhir) AS pendapatan_sewa " +
            "FROM alat a ORDER BY a.kode";

        private const string SqlDenda =
            "SELECT k.tanggal_kembali AS tanggal, p.nama AS penyewa, a.kode AS alat_kode, a.nama AS alat_nama, " +
            "       d.jenis AS jenis, COALESCE(d.keterangan, '') AS keterangan, d.nominal AS nominal " +
            "FROM denda d " +
            "JOIN pengembalian k ON k.id = d.pengembalian_id " +
            "JOIN penyewaan s ON s.id = k.penyewaan_id " +
            "JOIN penyewa p ON p.id = s.penyewa_id " +
            "JOIN alat a ON a.kode = s.alat_kode " +
            "WHERE k.tanggal_kembali >= @awal AND k.tanggal_kembali < @akhir " +
            "ORDER BY k.tanggal_kembali, p.nama";

        public List<DataPendapatan> AmbilPendapatan(DateTime awal, DateTime akhir)
        {
            return databaseHelper.AmbilDaftar(SqlPendapatan, PetakanPendapatan,
                ("@awal", DateOnly.FromDateTime(awal)),
                ("@akhir", DateOnly.FromDateTime(akhir)));
        }

        public List<DataAlatLaporan> AmbilPemakaianAlat(DateTime awal, DateTime akhir)
        {
            return databaseHelper.AmbilDaftar(SqlPemakaianAlat, PetakanPemakaianAlat,
                ("@awal", DateOnly.FromDateTime(awal)),
                ("@akhir", DateOnly.FromDateTime(akhir)));
        }

        public List<DataDenda> AmbilDenda(DateTime awal, DateTime akhir)
        {
            return databaseHelper.AmbilDaftar(SqlDenda, PetakanDenda,
                ("@awal", DateOnly.FromDateTime(awal)),
                ("@akhir", DateOnly.FromDateTime(akhir)));
        }

        private static DataPendapatan PetakanPendapatan(NpgsqlDataReader r)
        {
            return new DataPendapatan(
                r.GetFieldValue<DateTime>(r.GetOrdinal("tanggal")),
                (string)r["penyewa"],
                $"{(string)r["alat_kode"]} - {(string)r["alat_nama"]}",
                (string)r["jenis"],
                r["keterangan"] as string ?? "",
                (decimal)r["nominal"]);
        }

        private static DataAlatLaporan PetakanPemakaianAlat(NpgsqlDataReader r)
        {
            return new DataAlatLaporan(
                AlatRepository.Petakan(r),
                Convert.ToInt32(r["jumlah_sewa"]),
                (decimal)r["pendapatan_sewa"]);
        }

        private static DataDenda PetakanDenda(NpgsqlDataReader r)
        {
            return new DataDenda(
                r.GetFieldValue<DateTime>(r.GetOrdinal("tanggal")),
                (string)r["penyewa"],
                $"{(string)r["alat_kode"]} - {(string)r["alat_nama"]}",
                (string)r["jenis"],
                (string)r["keterangan"],
                (decimal)r["nominal"]);
        }
    }
}
