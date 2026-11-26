namespace projek_pbo.model
{
    public class DendaKerusakan : IDenda
    {
        public decimal Nominal { get; }
        public string Keterangan { get; }

        public DendaKerusakan(decimal nominal, string keterangan)
        {
            if (nominal <= 0)
                throw new ArgumentException("Denda kerusakan harus lebih dari 0.");
            if (string.IsNullOrWhiteSpace(keterangan))
                throw new ArgumentException("Keterangan kerusakan wajib diisi.");

            Nominal = nominal;
            Keterangan = keterangan.Trim();
        }

        public decimal HitungDenda()
        {
            return Nominal;
        }
    }
}
