namespace projek_pbo.model
{
    public abstract class AlatPertanian
    {
        public string Kode { get; }
        public string Nama { get; private set; } = "";
        public string Merek { get; private set; } = "";
        public string Deskripsi { get; private set; } = "";
        public int TahunKeluaran { get; private set; }
        public KondisiAlat Kondisi { get; private set; }
        public decimal TarifPerHari { get; private set; }
        public StatusAlat Status { get; private set; }

        public abstract string Jenis { get; }

        protected AlatPertanian(string kode, string nama, string merek, string deskripsi,
            int tahunKeluaran, KondisiAlat kondisi, decimal tarifPerHari, StatusAlat status)
        {
            if (string.IsNullOrWhiteSpace(kode))
                throw new ArgumentException("Kode alat wajib diisi.");
            if (kode.Trim().Length > 10)
                throw new ArgumentException("Kode alat maksimal 10 karakter.");

            Kode = kode.Trim().ToUpper();
            UbahData(nama, merek, deskripsi, tahunKeluaran, kondisi, tarifPerHari);
            Status = status;
        }

        public void UbahData(string nama, string merek, string deskripsi,
            int tahunKeluaran, KondisiAlat kondisi, decimal tarifPerHari)
        {
            if (string.IsNullOrWhiteSpace(nama))
                throw new ArgumentException("Nama alat wajib diisi.");
            if (string.IsNullOrWhiteSpace(merek))
                throw new ArgumentException("Merek tidak boleh kosong.");
            if (tahunKeluaran > DateTime.Today.Year)
                throw new ArgumentException("Tahun keluaran tidak boleh di masa depan.");
            if (tahunKeluaran < 1900)
                throw new ArgumentException("Tahun keluaran tidak valid.");
            if (tarifPerHari <= 0)
                throw new ArgumentException("Tarif per hari harus lebih dari 0.");

            Nama = nama.Trim();
            Merek = merek.Trim();
            Deskripsi = deskripsi?.Trim() ?? "";
            TahunKeluaran = tahunKeluaran;
            Kondisi = kondisi;
            TarifPerHari = tarifPerHari;
        }

        public void Sewakan()
        {
            if (Status != StatusAlat.Tersedia)
                throw new InvalidOperationException($"Alat {Kode} tidak dapat disewa karena berstatus {Status}.");
            Status = StatusAlat.Disewa;
        }

        public void Kembalikan()
        {
            if (Status != StatusAlat.Disewa)
                throw new InvalidOperationException($"Alat {Kode} tidak sedang disewa.");
            Status = StatusAlat.Tersedia;
        }

        public void TandaiRusak()
        {
            if (Status != StatusAlat.Disewa)
                throw new InvalidOperationException($"Alat {Kode} tidak sedang disewa.");
            Status = StatusAlat.Rusak;
        }

        public void Perbaiki()
        {
            if (Status != StatusAlat.Rusak)
                throw new InvalidOperationException($"Alat {Kode} tidak berstatus Rusak.");
            Status = StatusAlat.Tersedia;
        }

        public abstract string Spesifikasi();
    }
}
