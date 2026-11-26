using projek_pbo.model;
using projek_pbo.repository;

namespace projek_pbo.controller
{
    public class c_Pengguna
    {
        private readonly IPenggunaRepository penggunaRepository = new PenggunaRepository();

        public List<Pengguna> AmbilSemuaPengguna()
        {
            PastikanAdmin();
            return penggunaRepository.AmbilSemua();
        }

        public Hasil TambahPengguna(string namaLengkap, string username, string password, string peran)
        {
            return Hasil.Coba(() =>
            {
                PastikanAdmin();
                Pengguna pengguna = Pengguna.Buat(peran, 0, namaLengkap, username, password);

                if (penggunaRepository.UsernameSudahDipakai(pengguna.Username, 0))
                    throw new InvalidOperationException($"Username \"{pengguna.Username}\" sudah dipakai.");

                penggunaRepository.Tambah(pengguna);
                return "Pengguna berhasil ditambahkan.";
            });
        }

        // Password boleh dikosongkan bila tidak ingin diubah.
        public Hasil UbahPengguna(int id, string namaLengkap, string username, string passwordBaru, string peran)
        {
            return Hasil.Coba(() =>
            {
                PastikanAdmin();
                Pengguna pengguna = penggunaRepository.CariById(id)
                    ?? throw new InvalidOperationException("Pengguna tidak ditemukan.");

                if (id == c_Auth.PenggunaAktif!.Id && peran != pengguna.Peran)
                    throw new InvalidOperationException("Anda tidak dapat mengubah peran akun Anda sendiri.");

                if (peran != pengguna.Peran)
                    pengguna = pengguna.GantiPeran(peran);

                pengguna.UbahData(namaLengkap, username);
                if (!string.IsNullOrEmpty(passwordBaru))
                    pengguna.UbahPassword(passwordBaru);

                if (penggunaRepository.UsernameSudahDipakai(pengguna.Username, id))
                    throw new InvalidOperationException($"Username \"{pengguna.Username}\" sudah dipakai.");

                penggunaRepository.Ubah(pengguna);
                return "Data pengguna berhasil diubah.";
            });
        }

        public Hasil HapusPengguna(int id)
        {
            return Hasil.Coba(() =>
            {
                PastikanAdmin();
                if (id == c_Auth.PenggunaAktif!.Id)
                    throw new InvalidOperationException("Anda tidak dapat menghapus akun Anda sendiri.");

                penggunaRepository.Hapus(id);
                return "Pengguna berhasil dihapus.";
            });
        }

        private static void PastikanAdmin()
        {
            if (c_Auth.PenggunaAktif is not Admin)
                throw new InvalidOperationException("Hanya Admin yang dapat mengelola pengguna.");
        }
    }
}
