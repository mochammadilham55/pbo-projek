using projek_pbo.model;

namespace projek_pbo.repository
{
    public interface IPengembalianRepository
    {
        void Simpan(Pengembalian pengembalian);
        decimal TotalDenda(DateTime awal, DateTime akhir);
    }
}
