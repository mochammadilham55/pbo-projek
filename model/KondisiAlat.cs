namespace projek_pbo.model
{
    public enum KondisiAlat
    {
        Baik,
        Cukup,
        PerluServis
    }

    // Mengubah enum ke teks yang tampil di layar ("Perlu servis") dan sebaliknya.
    public static class KondisiAlatTeks
    {
        public static readonly string[] Semua = { "Baik", "Cukup", "Perlu servis" };

        public static string KeTeks(this KondisiAlat kondisi)
        {
            return kondisi == KondisiAlat.PerluServis ? "Perlu servis" : kondisi.ToString();
        }

        public static KondisiAlat DariTeks(string teks)
        {
            return teks switch
            {
                "Baik" => KondisiAlat.Baik,
                "Cukup" => KondisiAlat.Cukup,
                "Perlu servis" => KondisiAlat.PerluServis,
                _ => throw new ArgumentException("Kondisi alat wajib dipilih.")
            };
        }
    }
}
