using System;

namespace projek_pbo.model
{
    public class PembayaranTunai : Pembayaran
    {
        public override string Metode => "Tunai";
        public override string Status => "Lunas";

        public decimal Kembalian => JumlahDiterima - Nominal;

        public PembayaranTunai(decimal nominal, decimal jumlahDiterima)
            : base(nominal, jumlahDiterima)
        {
        }
    }
}