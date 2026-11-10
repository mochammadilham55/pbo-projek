using System.Data.Common;

namespace projek_pbo.controller
{
    // Hasil sebuah aksi untuk ditampilkan oleh View: berhasil atau gagal, beserta pesannya.
    public class Hasil
    {
        public bool Berhasil { get; }
        public string Pesan { get; }

        private Hasil(bool berhasil, string pesan)
        {
            Berhasil = berhasil;
            Pesan = pesan;
        }

        public static Hasil Sukses(string pesan) => new Hasil(true, pesan);
        public static Hasil Gagal(string pesan) => new Hasil(false, pesan);

        // Menjalankan aksi dan mengubah exception dari Model/Repository menjadi pesan untuk View.
        public static Hasil Coba(Func<string> aksi)
        {
            try
            {
                return Sukses(aksi());
            }
            catch (ArgumentException ex)
            {
                return Gagal(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                return Gagal(ex.Message);
            }
            catch (DbException ex)
            {
                return Gagal("Terjadi kesalahan database: " + ex.Message);
            }
        }
    }
}
