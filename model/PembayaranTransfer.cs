using System;

namespace projek_pbo.model
{
    public class PembayaranTransfer : Pembayaran
    {
        public override string Metode => "Transfer";
        public override string Status => "Menunggu verifikasi";

        public override string BankTujuan { get; }
        public override string NoReferensi { get; }

        public PembayaranTransfer(
            decimal nominal,
            decimal jumlahDiterima,
            string bankTujuan,
            string noReferensi
        ) : base(nominal, jumlahDiterima)
        {
            if (string.IsNullOrWhiteSpace(bankTujuan))
                throw new ArgumentException("Bank harus diisi.");

            if (string.IsNullOrWhiteSpace(noReferensi))
                throw new ArgumentException("Nomor referensi harus diisi.");

            BankTujuan = bankTujuan;
            NoReferensi = noReferensi;
        }
    }
}