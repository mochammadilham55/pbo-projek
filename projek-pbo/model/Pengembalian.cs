namespace projek_pbo.model
{
    public class Pengembalian
    {
        private readonly List<IDenda> daftarDenda = new List<IDenda>();

        public int Id { get; }
        public Penyewaan Penyewaan { get; }
        public DateTime TanggalKembali { get; }

        public Pengembalian(int id, Penyewaan penyewaan, DateTime tanggalKembali)
        {
            if (penyewaan.Status != StatusSewa.Aktif)
                throw new InvalidOperationException("Penyewaan ini sudah dikembalikan.");
            if (tanggalKembali.Date < penyewaan.TanggalMulai)
                throw new ArgumentException("Tanggal kembali tidak boleh sebelum tanggal mulai sewa.");
            if (tanggalKembali.Date > DateTime.Today)
                throw new ArgumentException("Tanggal kembali tidak boleh di masa depan.");

            Id = id;
            Penyewaan = penyewaan;
            TanggalKembali = tanggalKembali.Date;
        }

        public int HariTerlambat => Penyewaan.HitungHariTerlambat(TanggalKembali);

        public IReadOnlyList<IDenda> DaftarDenda => daftarDenda;

        public bool AdaKerusakan => daftarDenda.Any(denda => denda is DendaKerusakan);

        public void TambahDenda(IDenda denda)
        {
            daftarDenda.Add(denda);
        }

        // Polymorphism: setiap denda menghitung dirinya sendiri lewat kontrak IDenda.
        public decimal TotalDenda()
        {
            return daftarDenda.Sum(denda => denda.HitungDenda());
        }

        public void Proses()
        {
            Penyewaan.Selesaikan();

            if (AdaKerusakan)
                Penyewaan.Alat.TandaiRusak();
            else
                Penyewaan.Alat.Kembalikan();
        }
    }
}
