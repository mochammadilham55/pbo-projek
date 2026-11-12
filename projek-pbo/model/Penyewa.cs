namespace projek_pbo.model
{
    public class Penyewa
    {
        public int Id { get; }
        public string Nama { get; }
        public string NoTelepon { get; }
        public string Alamat { get; }

        public Penyewa(int id, string nama, string noTelepon, string alamat)
        {
            if (string.IsNullOrWhiteSpace(nama))
                throw new ArgumentException("Nama penyewa wajib diisi.");

            Id = id;
            Nama = nama.Trim();
            NoTelepon = noTelepon?.Trim() ?? "";
            Alamat = alamat?.Trim() ?? "";
        }
    }
}
