namespace projek_pbo.model
{
    public class DendaTerlambat : IDenda
    {
        private const decimal PersenPerHari = 0.10m;

        private readonly decimal tarifPerHari;
        private readonly decimal totalBiayaSewa;

        public int HariTerlambat { get; }

        public DendaTerlambat(int hariTerlambat, decimal tarifPerHari, decimal totalBiayaSewa)
        {
            if (hariTerlambat < 0)
                throw new ArgumentException("Hari terlambat tidak boleh negatif.");

            HariTerlambat = hariTerlambat;
            this.tarifPerHari = tarifPerHari;
            this.totalBiayaSewa = totalBiayaSewa;
        }

        public string Keterangan => $"Terlambat {HariTerlambat} hari";

        public decimal HitungDenda()
        {
            if (HariTerlambat <= 0)
                return 0;

            decimal denda = HariTerlambat * PersenPerHari * tarifPerHari;
            decimal batasMaksimal = totalBiayaSewa;
            return Math.Min(denda, batasMaksimal);
        }
    }
}
