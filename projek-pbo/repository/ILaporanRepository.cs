using System;
using System.Collections.Generic;
using System.Text;
using projek_pbo.model;

namespace projek_pbo.repository
{
    //semua tentang tanggal berbentu [awal; akhir) : awal ikut dihiutng, akhir tidak.
    public interface ILaporanRepository
    {
        List<DataPendapatan> AmbilPendapatan(DateTime awal, DateTime akhir);
        List<DataAlatLaporan> AmbilPemakaianAlat(DateTime awal, DateTime akhir);
        List<DataDenda> AmbilDenda(DateTime awal, DateTime akhir);
    }
}
