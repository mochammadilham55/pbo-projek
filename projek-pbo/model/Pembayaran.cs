namespace projek_pbo.model
{
    // Pembayaran lunas dicatat bersama penyewaan, bukan transaksi terpisah.
    public class Pembayaran
    {
        public string Metode { get; }
        public decimal Nominal { get; }
        public decimal JumlahDiterima { get; }
        public string BankTujuan { get; }
        public string NoReferensi { get; }
        public decimal Kembalian => Metode == "Tunai" ? JumlahDiterima - Nominal : 0;

        public Pembayaran(string metode, decimal nominal, decimal diterima, string bank, string referensi)
        {
            if (nominal <= 0 || nominal > 9999999999.99m)
                throw new ArgumentException("Total pembayaran di luar batas.");
            if (metode != "Tunai" && metode != "Transfer")
                throw new ArgumentException("Metode pembayaran tidak valid.");
            Metode = metode;
            Nominal = nominal;
            BankTujuan = bank.Trim();
            NoReferensi = referensi.Trim();
            if (metode == "Tunai" && (diterima < nominal || diterima > 9999999999.99m))
                throw new ArgumentException("Jumlah uang tunai tidak mencukupi atau di luar batas.");
            if (metode == "Transfer" && (BankTujuan.Length == 0 || NoReferensi.Length == 0 ||
                BankTujuan.Length > 50 || NoReferensi.Length > 50))
                throw new ArgumentException("Bank dan referensi transfer wajib diisi, maksimal 50 karakter.");
            JumlahDiterima = metode == "Tunai" ? diterima : nominal;
        }
    }

    public record RingkasanSewa(Penyewaan Sewa, decimal Dibayar, string Metode);
}
