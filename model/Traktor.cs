namespace projek_pbo.model
{
    public class Traktor : AlatPertanian
    {
        public int TenagaHp { get; private set; }
        public decimal KapasitasTangki { get; private set; }
        public JenisTraktor JenisTraktor { get; private set; }

        public Traktor(string kode, string nama, string merek, string deskripsi,
            int tahunKeluaran, KondisiAlat kondisi, decimal tarifPerHari, StatusAlat status,
            int tenagaHp, decimal kapasitasTangki, JenisTraktor jenisTraktor)
            : base(kode, nama, merek, deskripsi, tahunKeluaran, kondisi, tarifPerHari, status)
        {
            UbahSpesifikasi(tenagaHp, kapasitasTangki, jenisTraktor);
        }

        public override string Jenis => "Traktor";

        public void UbahSpesifikasi(int tenagaHp, decimal kapasitasTangki, JenisTraktor jenisTraktor)
        {
            if (tenagaHp <= 0)
                throw new ArgumentException("Tenaga traktor harus lebih dari 0 HP.");
            if (kapasitasTangki <= 0)
                throw new ArgumentException("Kapasitas tangki harus lebih dari 0 liter.");

            TenagaHp = tenagaHp;
            KapasitasTangki = kapasitasTangki;
            JenisTraktor = jenisTraktor;
        }

        public override string Spesifikasi()
        {
            return $"{JenisTraktor.KeTeks()}, {TenagaHp} HP, tangki {KapasitasTangki:0.##} L";
        }
    }
}
