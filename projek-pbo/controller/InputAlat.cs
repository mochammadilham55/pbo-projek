namespace projek_pbo.controller
{
    // Isian form Kelola Alat apa adanya (teks). c_Alat yang mengubahnya ke angka dan enum.
    public class InputAlat
    {
        public string Kode { get; set; } = "";
        public string Nama { get; set; } = "";
        public string Jenis { get; set; } = "";
        public string Merek { get; set; } = "";
        public string Deskripsi { get; set; } = "";
        public string TahunKeluaran { get; set; } = "";
        public string Kondisi { get; set; } = "";
        public string TarifPerHari { get; set; } = "";

        public string TenagaHp { get; set; } = "";
        public string KapasitasTangki { get; set; } = "";
        public string JenisTraktor { get; set; } = "";

        public string DebitLiterPerMenit { get; set; } = "";
        public string BeratKg { get; set; } = "";
        public string BahanBakar { get; set; } = "";
        public string DiameterPipaInci { get; set; } = "";
    }
}
