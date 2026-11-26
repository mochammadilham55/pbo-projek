namespace projek_pbo.model
{
    public class PompaAir : AlatPertanian
    {
        public decimal DebitLiterPerMenit { get; private set; }
        public decimal BeratKg { get; private set; }
        public string BahanBakar { get; private set; } = "";
        public decimal DiameterPipaInci { get; private set; }

        public PompaAir(string kode, string nama, string merek, string deskripsi,
            int tahunKeluaran, KondisiAlat kondisi, decimal tarifPerHari, StatusAlat status,
            decimal debitLiterPerMenit, decimal beratKg, string bahanBakar, decimal diameterPipaInci)
            : base(kode, nama, merek, deskripsi, tahunKeluaran, kondisi, tarifPerHari, status)
        {
            UbahSpesifikasi(debitLiterPerMenit, beratKg, bahanBakar, diameterPipaInci);
        }

        public override string Jenis => "Pompa Air";

        public void UbahSpesifikasi(decimal debitLiterPerMenit, decimal beratKg, string bahanBakar, decimal diameterPipaInci)
        {
            if (debitLiterPerMenit <= 0)
                throw new ArgumentException("Debit pompa harus lebih dari 0 liter per menit.");
            if (beratKg <= 0)
                throw new ArgumentException("Berat pompa harus lebih dari 0 kg.");
            if (string.IsNullOrWhiteSpace(bahanBakar))
                throw new ArgumentException("Bahan bakar wajib dipilih.");
            if (diameterPipaInci <= 0)
                throw new ArgumentException("Diameter pipa harus lebih dari 0 inci.");

            DebitLiterPerMenit = debitLiterPerMenit;
            BeratKg = beratKg;
            BahanBakar = bahanBakar.Trim();
            DiameterPipaInci = diameterPipaInci;
        }

        public override string Spesifikasi()
        {
            return $"{DebitLiterPerMenit:0.##} L/menit, {BahanBakar}, pipa {DiameterPipaInci:0.#}\", {BeratKg:0.##} kg";
        }
    }
}
