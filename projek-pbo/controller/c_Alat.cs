using System.Globalization;
using projek_pbo.model;
using projek_pbo.repository;

namespace projek_pbo.controller
{
    public class c_Alat
    {
        public const string NamaTraktor = "Traktor";
        public const string NamaPompaAir = "Pompa Air";
        public const string NamaSemuaJenis = "Semua Jenis";

        private static readonly CultureInfo Indonesia = new CultureInfo("id-ID");

        private readonly IAlatRepository alatRepository = new AlatRepository();

        public List<AlatPertanian> AmbilSemuaAlat()
        {
            return alatRepository.AmbilSemua();
        }

        // Overloading: cari satu alat berdasarkan kode ...
        public AlatPertanian? Cari(string kode)
        {
            return alatRepository.Cari(kode);
        }

        // ... atau cari daftar alat berdasarkan nama/merek dan jenis.
        public List<AlatPertanian> Cari(string nama, string jenis)
        {
            string? jenisDb = jenis switch
            {
                NamaTraktor => "Traktor",
                NamaPompaAir => "PompaAir",
                _ => null
            };
            return alatRepository.Cari(nama, jenisDb);
        }

        public Hasil TambahAlat(InputAlat input)
        {
            return Hasil.Coba(() =>
            {
                AlatPertanian alat = BuatAlat(input);
                if (alatRepository.Cari(alat.Kode) != null)
                    throw new InvalidOperationException($"Kode alat {alat.Kode} sudah dipakai.");

                alatRepository.Tambah(alat);
                return $"Alat {alat.Kode} berhasil ditambahkan.";
            });
        }

        public Hasil UbahAlat(InputAlat input)
        {
            return Hasil.Coba(() =>
            {
                AlatPertanian alat = alatRepository.Cari(input.Kode)
                    ?? throw new InvalidOperationException("Alat tidak ditemukan. Pilih alat dari tabel terlebih dahulu.");
                if (alat.Jenis != input.Jenis)
                    throw new InvalidOperationException("Jenis alat tidak dapat diubah.");

                alat.UbahData(input.Nama, input.Merek, input.Deskripsi,
                    KeBilanganBulat(input.TahunKeluaran, "Tahun keluaran"),
                    KondisiAlatTeks.DariTeks(input.Kondisi),
                    KeDesimal(input.TarifPerHari, "Tarif per hari"));

                if (alat is Traktor traktor)
                {
                    traktor.UbahSpesifikasi(
                        KeBilanganBulat(input.TenagaHp, "Tenaga (HP)"),
                        KeDesimal(input.KapasitasTangki, "Kapasitas tangki"),
                        JenisTraktorTeks.DariTeks(input.JenisTraktor));
                }
                else if (alat is PompaAir pompa)
                {
                    pompa.UbahSpesifikasi(
                        KeDesimal(input.DebitLiterPerMenit, "Debit"),
                        KeDesimal(input.BeratKg, "Berat"),
                        input.BahanBakar,
                        KeDesimal(input.DiameterPipaInci, "Diameter pipa"));
                }

                alatRepository.Ubah(alat);
                return $"Data alat {alat.Kode} berhasil diubah.";
            });
        }

        public Hasil HapusAlat(string kode)
        {
            return Hasil.Coba(() =>
            {
                AlatPertanian alat = alatRepository.Cari(kode)
                    ?? throw new InvalidOperationException("Alat tidak ditemukan. Pilih alat dari tabel terlebih dahulu.");
                if (alat.Status == StatusAlat.Disewa)
                    throw new InvalidOperationException("Alat yang sedang disewa tidak dapat dihapus.");

                alatRepository.Hapus(alat.Kode);
                return $"Alat {alat.Kode} berhasil dihapus.";
            });
        }

        // Alat baru selalu berstatus Tersedia.
        private static AlatPertanian BuatAlat(InputAlat input)
        {
            int tahun = KeBilanganBulat(input.TahunKeluaran, "Tahun keluaran");
            KondisiAlat kondisi = KondisiAlatTeks.DariTeks(input.Kondisi);
            decimal tarif = KeDesimal(input.TarifPerHari, "Tarif per hari");

            return input.Jenis switch
            {
                NamaTraktor => new Traktor(input.Kode, input.Nama, input.Merek, input.Deskripsi,
                    tahun, kondisi, tarif, StatusAlat.Tersedia,
                    KeBilanganBulat(input.TenagaHp, "Tenaga (HP)"),
                    KeDesimal(input.KapasitasTangki, "Kapasitas tangki"),
                    JenisTraktorTeks.DariTeks(input.JenisTraktor)),

                NamaPompaAir => new PompaAir(input.Kode, input.Nama, input.Merek, input.Deskripsi,
                    tahun, kondisi, tarif, StatusAlat.Tersedia,
                    KeDesimal(input.DebitLiterPerMenit, "Debit"),
                    KeDesimal(input.BeratKg, "Berat"),
                    input.BahanBakar,
                    KeDesimal(input.DiameterPipaInci, "Diameter pipa")),

                _ => throw new ArgumentException("Jenis alat wajib dipilih.")
            };
        }

        private static int KeBilanganBulat(string teks, string namaIsian)
        {
            if (!int.TryParse(teks.Trim(), NumberStyles.Integer, Indonesia, out int nilai))
                throw new ArgumentException($"{namaIsian} harus berupa bilangan bulat.");
            return nilai;
        }

        // Format Indonesia: titik pemisah ribuan, koma pemisah desimal (contoh 800.000 atau 2,5).
        private static decimal KeDesimal(string teks, string namaIsian)
        {
            if (!decimal.TryParse(teks.Trim(), NumberStyles.Number, Indonesia, out decimal nilai))
                throw new ArgumentException($"{namaIsian} harus berupa angka.");
            return nilai;
        }
    }
}
