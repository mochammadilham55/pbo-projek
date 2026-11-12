using System.Globalization;
using projek_pbo.controller;

namespace projek_pbo.view
{
    // Format angka/tanggal dan kotak pesan yang dipakai bersama oleh semua form.
    internal static class Tampilan
    {
        private static readonly CultureInfo Indonesia = new CultureInfo("id-ID");
        private const string Judul = "Agri-Rent";

        public static string Rupiah(decimal nilai) => "Rp" + nilai.ToString("N0", Indonesia);

        public static string Angka(decimal nilai) => nilai.ToString("0.##", Indonesia);

        public static string Tanggal(DateTime tanggal) => tanggal.ToString("dd/MM/yyyy");

        public static void Info(string pesan)
        {
            MessageBox.Show(pesan, Judul, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Peringatan(string pesan)
        {
            MessageBox.Show(pesan, Judul, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Error(Exception ex)
        {
            MessageBox.Show("Gagal memuat data.\n\n" + ex.Message, Judul, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void TampilkanHasil(Hasil hasil)
        {
            if (hasil.Berhasil)
                Info(hasil.Pesan);
            else
                Peringatan(hasil.Pesan);
        }

        public static bool Konfirmasi(string pesan)
        {
            return MessageBox.Show(pesan, Judul, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
    }
}
