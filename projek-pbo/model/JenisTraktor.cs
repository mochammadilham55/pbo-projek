namespace projek_pbo.model
{
    public enum JenisTraktor
    {
        Roda2,
        Roda4
    }

    // Mengubah enum ke teks yang tampil di layar ("Roda 4") dan sebaliknya.
    public static class JenisTraktorTeks
    {
        public static readonly string[] Semua = { "Roda 2", "Roda 4" };

        public static string KeTeks(this JenisTraktor jenis)
        {
            return jenis == JenisTraktor.Roda2 ? "Roda 2" : "Roda 4";
        }

        public static JenisTraktor DariTeks(string teks)
        {
            return teks switch
            {
                "Roda 2" => JenisTraktor.Roda2,
                "Roda 4" => JenisTraktor.Roda4,
                _ => throw new ArgumentException("Jenis traktor wajib dipilih.")
            };
        }
    }
}
