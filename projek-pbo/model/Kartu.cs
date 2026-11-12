namespace projek_pbo.model
{
    // Satu kartu ringkasan di Dashboard. Keempat kartu bentuknya sama, jadi cukup satu class.
    // Nilainya diberikan oleh Controller; Kartu tidak mengambil data sendiri.
    public class Kartu
    {
        public string Judul { get; }
        public string Nilai { get; }

        public Kartu(string judul, string nilai)
        {
            Judul = judul;
            Nilai = nilai;
        }
    }
}
