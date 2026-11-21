using System;
using System.Collections.Generic;
using System.Text;

namespace projek_pbo.model
{
    // Isi laporan yang siap ditampilkan View: judul kolom, baris, dan satu angka total.
    // sel berisi nilai asli (DateTime, decimal, int, string); View yang mengatur format tampilannya.

    public record HasilLaporan(string Judul, string Periode,
        IReadOnlyList<string> Kolom, IReadOnlyList<object[]> Baris,
        string LabelTotal, decimal Total, bool TotalBerupaUang);
    
    public abstract class Laporan
    {
        public string Judul { get; }
        public DateTime Awal { get; }
        public DateTime Akhir { get; }

        protected Laporan(string judul, DateTime awal, DateTime akhir)
        {
            if (akhir.Date < awal.Date)
                throw new ArgumentException("Periode akhir tidak boleh sebelum periode awal");
            Judul = judul;
            Awal = awal.Date;
            Akhir = akhir.Date;
        }

        public string Periode => $"{Awal:dd/MM/yyyy} - {Akhir:dd/MM/yyyy}";

        //Polymorphism: setiap jenis laporan menyusun kolom, baris, dan total dengan caranya sendeeiri.
        public abstract HasilLaporan BuatLaporan();
    }
}
