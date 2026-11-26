using System;
using System.Collections.Generic;
using System.Text;

namespace projek_pbo.model
{
    // Baris data mentah yang diberikan Controller ke class laporan.
    // Laporan tidak mengambil data sendiri; ketiga record ini hanya pembawa data.
    public record DataPendapatan(DateTime Tanggal, string Penyewa, string Alat,
        string Jenis, string Keterangan, decimal Nominal);

    public record DataAlatLaporan(AlatPertanian Alat, int JumlahSewa, decimal PendapatanSewa);

    public record DataDenda(DateTime Tanggal, string Penyewa, string Alat,
        string Jenis, string Keterangan, decimal Nominal);
}
