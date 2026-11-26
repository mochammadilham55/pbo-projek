
using System;

namespace projek_pbo.model
{
    public class Penyewaan
    {
        private const int BatasHariDiskon = 7;
        private const decimal PersenDiskon = 0.10m;

        public int Id { get; }

        public Penyewa Penyewa { get; }

        public AlatPertanian Alat { get; }

        public decimal TarifPerHari { get; }

        public DateTime TanggalMulai { get; }

        public DateTime TanggalRencanaKembali { get; }

        public StatusSewa Status { get; private set; }

        public Penyewaan(
            int id,
            Penyewa penyewa,
            AlatPertanian alat,
            decimal tarifPerHari,
            DateTime tanggalMulai,
            DateTime tanggalRencanaKembali,
            StatusSewa status)
        {
            if (penyewa == null)
                throw new ArgumentNullException(nameof(penyewa));

            if (alat == null)
                throw new ArgumentNullException(nameof(alat));

            if (tanggalRencanaKembali.Date <= tanggalMulai.Date)
                throw new ArgumentException(
                    "Tanggal kembali harus setelah tanggal mulai.");

            if (tarifPerHari <= 0)
                throw new ArgumentException(
                    "Tarif per hari harus lebih dari 0.");

            Id = id;
            Penyewa = penyewa;
            Alat = alat;
            TarifPerHari = tarifPerHari;
            TanggalMulai = tanggalMulai.Date;
            TanggalRencanaKembali =
                tanggalRencanaKembali.Date;
            Status = status;
        }

        public int Durasi =>
            (TanggalRencanaKembali - TanggalMulai).Days;

        public decimal HitungBiayaDasar()
        {
            return TarifPerHari * Durasi;
        }

        public decimal HitungDiskon()
        {
            int hariDiskon =
                Math.Max(0, Durasi - BatasHariDiskon);

            return hariDiskon *
                   TarifPerHari *
                   PersenDiskon;
        }

        public decimal HitungTotalBiaya()
        {
            return HitungBiayaDasar() - HitungDiskon();
        }

        public int HitungHariTerlambat(
            DateTime tanggalKembali)
        {
            return Math.Max(
                0,
                (tanggalKembali.Date -
                 TanggalRencanaKembali).Days);
        }

        public void Selesaikan()
        {
            if (Status != StatusSewa.Aktif)
                throw new InvalidOperationException(
                    "Penyewaan ini sudah selesai.");

            Status = StatusSewa.Selesai;
        }
    }
}
