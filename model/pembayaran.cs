
using System;

namespace projek_pbo.model
{
    public abstract class Pembayaran
    {
        public decimal Nominal { get; set; }
        public decimal JumlahDiterima { get; set; }
        public DateTime Tanggal { get; set; }

        public abstract string Metode { get; }
        public abstract string Status { get; }

        public virtual string BankTujuan => "";
        public virtual string NoReferensi => "";

        protected Pembayaran(decimal nominal, decimal jumlahDiterima)
        {
            if (nominal <= 0)
                throw new ArgumentException("Nominal harus lebih dari 0.");

            if (jumlahDiterima < nominal)
                throw new ArgumentException("Jumlah pembayaran kurang.");

            Nominal = nominal;
            JumlahDiterima = jumlahDiterima;
            Tanggal = DateTime.Now;
        }
    }
}
