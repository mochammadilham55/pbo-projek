using projek_pbo.model;
using projek_pbo.repository;

namespace projek_pbo.controller
{
    public class c_Auth
    {
        private readonly IPenggunaRepository penggunaRepository = new PenggunaRepository();

        public static Pengguna? PenggunaAktif { get; private set; }

        public Hasil Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrEmpty(password))
                return Hasil.Gagal("Username dan password wajib diisi.");

            return Hasil.Coba(() =>
            {
                Pengguna? pengguna = penggunaRepository.CariByUsername(username.Trim());
                if (pengguna == null || !pengguna.CekPassword(password))
                    throw new InvalidOperationException("Username atau password salah.");

                PenggunaAktif = pengguna;
                return $"Selamat datang, {pengguna.NamaLengkap}.";
            });
        }

        public void Logout()
        {
            PenggunaAktif = null;
        }
    }
}
