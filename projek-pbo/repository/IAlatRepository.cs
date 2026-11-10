using projek_pbo.model;

namespace projek_pbo.repository
{
    public interface IAlatRepository
    {
        List<AlatPertanian> AmbilSemua();
        AlatPertanian? Cari(string kode);
        List<AlatPertanian> Cari(string kataKunci, string? jenis);
        void Tambah(AlatPertanian alat);
        void Ubah(AlatPertanian alat);
        void Hapus(string kode);
        int HitungTersedia();
    }
}
