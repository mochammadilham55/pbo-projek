using projek_pbo.model;

namespace projek_pbo.repository
{
    public interface IPenggunaRepository
    {
        List<Pengguna> AmbilSemua();
        Pengguna? CariById(int id);
        Pengguna? CariByUsername(string username);
        bool UsernameSudahDipakai(string username, int kecualiId);
        void Tambah(Pengguna pengguna);
        void Ubah(Pengguna pengguna);
        void Hapus(int id);
    }
}
