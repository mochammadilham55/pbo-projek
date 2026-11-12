# CLAUDE.md — Agri-Rent (Manajemen Persewaan Alat Pertanian)

Dokumen ini menjelaskan tujuan, rancangan, dan struktur proyek. Baca seluruhnya sebelum membantu, dan ikuti aturan di bagian "Cara bekerja".

**Sumber acuan rancangan:** `Laporan_PBO_Agri-Rent.docx` (Bab III). Jika dokumen ini dan laporan berbeda, laporan yang berlaku; beri tahu saya agar dokumen ini disamakan.

## 1. Tujuan proyek
Aplikasi desktop **Windows Forms (C#, .NET)** bernama **Agri-Rent** untuk mengelola persewaan alat pertanian (traktor dan pompa air). Proyek ini adalah **proyek akhir mata kuliah Pemrograman Berorientasi Objek (PBO)**, jadi tujuan utamanya adalah **menerapkan 4 pilar OOP dengan jelas, natural, dan bisa dijelaskan**, bukan sekadar aplikasi yang jalan.

Pengguna aplikasi: **Admin** (akses penuh) dan **Petugas** (Dashboard, Kelola Sewa, Kelola Pengembalian).

## 2. Fitur
1. **Login** (peran Admin / Petugas); menu sidebar mengikuti `MenuTersedia()` pengguna yang login
2. **Dashboard** (4 kartu: alat tersedia, sewa aktif, terlambat, pendapatan + tabel transaksi terakhir)
3. **CRUD alat pertanian** (atribut umum + atribut khusus per jenis, pencarian)
4. **Kelola sewa dan pembayaran** (penyewa, alat tersedia, tanggal, biaya + diskon otomatis, tunai/transfer)
5. **Kelola pengembalian dan denda**
6. **Laporan**: pendapatan, alat, dan denda per periode
7. **Kelola user** (khusus Admin, prioritas rendah)

## 3. Rancangan class (lapisan Model)
| Class | Jenis | Isi utama |
|---|---|---|
| `Pengguna` | abstract | id, username, nama lengkap, password (privat); `UbahPassword()`, `MenuTersedia()` (abstrak) |
| `Admin`, `Petugas` | turunan `Pengguna` | override `MenuTersedia()` |
| `AlatPertanian` | abstract | kode, nama, merek, deskripsi, tahun keluaran, kondisi, tarif per hari, status (`private set`); `Sewakan()`, `Kembalikan()`, `TandaiRusak()`, `Perbaiki()`; `Jenis` dan `Spesifikasi()` abstrak; validasi tarif, tahun, merek |
| `Traktor` | turunan `AlatPertanian` | tenaga (HP), kapasitas tangki, jenis traktor (Roda 2 / Roda 4) |
| `PompaAir` | turunan `AlatPertanian` | debit (liter/menit), berat, bahan bakar, diameter pipa |
| `Penyewa` | class biasa | nama, nomor telepon, alamat |
| `Penyewaan` | class biasa | tanggal mulai, rencana kembali, status, tarif per hari (salinan); konstanta privat batas hari diskon (7) dan persen diskon (10%); durasi, diskon, total biaya dihitung |
| `Pembayaran` | abstract | nominal, tanggal, status (`private set`); `Proses()` abstrak, `Lunasi()` |
| `PembayaranTunai` | turunan `Pembayaran` | `Proses()` langsung Lunas; jumlah diterima dan kembalian |
| `PembayaranTransfer` | turunan `Pembayaran` | `Proses()` Menunggu Verifikasi; bank tujuan, nomor referensi |
| `Pengembalian` | class biasa | tanggal kembali, hari terlambat, kumpulan `IDenda` (`TambahDenda()`), total denda |
| `IDenda` | interface | `Keterangan`, `HitungDenda()` |
| `DendaTerlambat`, `DendaKerusakan` | implementasi `IDenda` | lihat aturan bisnis |
| `Laporan` | abstract | judul, periode; `BuatLaporan()` abstrak |
| `LaporanPendapatan`, `LaporanAlat`, `LaporanDenda` | turunan `Laporan` | override `BuatLaporan()` |
| `Kartu` | class biasa | judul, nilai (keempat kartu bentuknya sama, jadi tidak dibuat hierarki) |

Enum: `KondisiAlat` (Baik, Cukup, PerluServis), `StatusAlat` (Tersedia, Disewa, Rusak), `JenisTraktor` (Roda2, Roda4), `StatusSewa` (Aktif, Selesai), `StatusPembayaran` (Belum, MenungguVerifikasi, Lunas).

## 4. Penerapan 4 pilar OOP (inti penilaian)
| Pilar | Penerapan |
|---|---|
| **Abstraction** | `Pengguna`, `AlatPertanian`, `Pembayaran`, `Laporan` adalah abstract class; `IDenda` adalah interface |
| **Inheritance** | `Admin`/`Petugas` ← `Pengguna`; `Traktor`/`PompaAir` ← `AlatPertanian`; `PembayaranTunai`/`PembayaranTransfer` ← `Pembayaran`; 3 jenis laporan ← `Laporan` |
| **Polymorphism** | Override: `MenuTersedia()`, `Jenis`, `Spesifikasi()`, `Proses()`, `HitungDenda()` (lewat `IDenda`), `BuatLaporan()`. Overloading: `Cari(kode)` / `Cari(nama, jenis)` |
| **Enkapsulasi** | Field penting privat atau `private set` (status alat, nominal dan status pembayaran, password, persentase dan batas diskon/denda). Perubahan hanya lewat method resmi (`Sewakan()`, `Kembalikan()`, `TandaiRusak()`, `Perbaiki()`, `Proses()`, `Lunasi()`) dengan validasi di dalam class |

Sengaja **tidak** dibuat OOP karena tidak natural: `HitungTarifSewa()` tidak di-override (rumus tarif sama untuk semua alat), tidak ada abstract class `Denda` (cukup `IDenda`), kartu dashboard cukup satu class `Kartu`, overloading hanya pada pencarian alat.

Jangan menghapus atau melemahkan penerapan ini demi kode yang lebih singkat. Jangan memaksakan inheritance di tempat yang tidak natural.

## 5. Aturan bisnis
- **Atribut alat:** kondisi (keadaan fisik: Baik, Cukup, Perlu servis) berbeda dari status (ketersediaan: Tersedia, Disewa, Rusak).
- **Validasi alat:** tarif > 0, tahun keluaran tidak di masa depan, merek tidak boleh kosong.
- **Biaya sewa:** dihitung per hari dengan satu rumus untuk semua alat; penyewaan hanya menyimpan tanggal (tanpa jam).
- **Diskon durasi otomatis:** 10% hanya untuk hari yang melebihi 7 hari.
- **Denda keterlambatan** = hari terlambat × (10% × tarif per hari), maksimal **100% dari total biaya sewa (setelah diskon)**. Dibuat otomatis saat pengembalian diproses.
- **Denda kerusakan:** diinput manual, wajib > 0, wajib ada keterangan. Jika ada kerusakan, alat ditandai Rusak.
- **Total denda** = denda keterlambatan + denda kerusakan (jika ada).
- **Alur status alat:** Tersedia → Disewa (`Sewakan()`) → Tersedia (`Kembalikan()`) atau Rusak (`TandaiRusak()`); Rusak → Tersedia (`Perbaiki()`).
- Alat yang tidak berstatus Tersedia tidak boleh disewa.
- Tanggal rencana kembali harus setelah tanggal mulai.
- Pembayaran tunai langsung Lunas; transfer berstatus Menunggu Verifikasi sampai `Lunasi()`.

```
durasi         = tanggalRencanaKembali - tanggalMulai        (hari)
hariDiskon     = max(0, durasi - 7)
biayaDasar     = tarifPerHari x durasi
diskon         = hariDiskon x tarifPerHari x 10%
totalBiaya     = biayaDasar - diskon
hariTerlambat  = max(0, tanggalKembali - tanggalRencanaKembali)
dendaTerlambat = min(hariTerlambat x 10% x tarifPerHari, totalBiaya)
totalDenda     = dendaTerlambat + dendaKerusakan
```

## 6. Struktur proyek (MVC + Repository)
Arah ketergantungan **satu arah**:

```
View → Controller → Repository → databaseHelper → Database
              ↘ Model ↙ (dipakai semua lapisan)
```

| Folder | Isi | Larangan |
|---|---|---|
| `model/` | Class domain, enum, abstract class, interface, aturan bisnis | Tidak boleh memakai koneksi database, `MessageBox`, atau kontrol WinForms |
| `repository/` | Simpan dan ambil objek dari database, termasuk interface `I...Repository` (pengguna, alat, penyewaan, pengembalian) | Tidak ada tampilan dan tidak ada aturan bisnis |
| `controller/` | `c_Auth`, `c_Pengguna`, `c_Alat`, `c_Penyewaan`, `c_Pengembalian`, `c_Laporan`, `c_Dashboard` | Tidak membuat `MessageBox` atau mengatur kontrol; kembalikan hasil (berhasil/gagal + pesan) ke View |
| `view/` | `FormLogin`, `formDashboard`, `formKelolaAlat`, `formKelolaSewa`, `formKelolaPengembalian`, `formLaporan`, `formKelolaUser` | Tidak ada SQL; hanya event handler yang memanggil Controller |
| `databaseHelper.cs` | Satu pintu ke database: koneksi, eksekusi query berparameter, transaksi, inisialisasi tabel | |

Method utama controller:
- `c_Auth`: `Login()`, `Logout()`
- `c_Pengguna`: `TambahPengguna()`, `UbahPengguna()`, `HapusPengguna()`, `AmbilSemuaPengguna()`
- `c_Alat`: `TambahAlat()`, `UbahAlat()`, `HapusAlat()`, `Cari(kode)`, `Cari(nama, jenis)`, `AmbilSemuaAlat()`
- `c_Penyewaan`: `BuatSewa()`, `CatatPembayaran()`, `AmbilSewaAktif()`
- `c_Pengembalian`: `ProsesPengembalian()`, `TambahDendaKerusakan()`
- `c_Laporan`: `BuatLaporan()`
- `c_Dashboard`: `AmbilKartu()`, `AmbilTransaksiTerakhir()`

Aturan penting:
- **Semua query memakai parameter** (`@nilai`), jangan menggabungkan string (cegah SQL injection).
- Password disimpan **apa adanya (tanpa hash)** di kolom `password`, karena hashing belum termasuk materi. Laporan masih menyebut hash dan perlu disamakan.
- Pewarisan di database: satu tabel per hierarki dengan kolom pembeda (`alat.jenis`, `pembayaran.metode`, `denda.jenis`). Repository memetakan baris ke subclass yang tepat saat membaca.
- `Laporan` dan `Kartu` tidak mengambil data sendiri; datanya diberikan dari Controller.
- Pelanggaran aturan di Model dilempar sebagai exception, ditangkap Controller, dan diubah menjadi pesan untuk View.
- Operasi yang mengubah beberapa tabel sekaligus (buat sewa + ubah status alat + simpan pembayaran; simpan pengembalian + denda + status sewa + status alat) harus dalam **satu transaksi**.

## 7. Basis data
PostgreSQL, database `agri-rent`, diakses lewat Npgsql. Tujuh tabel:
- `pengguna` (id, username UNIQUE, nama_lengkap, password, peran)
- `alat` (kode PK, nama, jenis, merek, deskripsi, tahun_keluaran, kondisi, tarif_per_hari, status, tenaga_hp, kapasitas_tangki, jenis_traktor, debit_liter_per_menit, berat_kg, bahan_bakar, diameter_pipa_inci). Kolom khusus jenis lain bernilai NULL.
- `penyewa` (id, nama, no_telepon, alamat)
- `penyewaan` (id, penyewa_id FK, alat_kode FK, tarif_per_hari salinan, tanggal_mulai, tanggal_rencana_kembali, status)
- `pembayaran` (id, penyewaan_id FK, metode, nominal, tanggal, status, jumlah_diterima, bank_tujuan, no_referensi)
- `pengembalian` (id, penyewaan_id FK UNIQUE, tanggal_kembali)
- `denda` (id, pengembalian_id FK, jenis, keterangan, nominal, hari_terlambat)

Detail tipe data ada di laporan, Tabel 3.14–3.20.

## 8. Kondisi saat ini
- Target framework `net10.0-windows`, Npgsql 10.0.3, dikembangkan di Visual Studio. Proyek bisa di-build dan dibuka di `FormLogin`.
- Sudah ada desain: `FormLogin`, `formDashboard`, `formKelolaAlat` (baru panel Traktor), `formKelolaPengembalian`, `FormKelolaUser` (class di dalamnya masih bernama `FormDaftar`). `formKelolaSewa` dan `formLaporan` belum lengkap.
- Folder `model/` masih berisi file kosong lama (`kelolaDataAlat.cs`, `kelolaSewa.cs`, `kelolaPengembalian.cs`, `laporan.cs`) yang tidak sesuai rancangan. Tanyakan ke saya sebelum menghapus atau mengganti nama.
- `controller/` dan `repository/` masih kosong. `databaseHelper.cs` baru berisi `GetConnection()`.
- `bin/` dan `obj/` masih ter-commit di repo.

## 9. Konvensi
- Bahasa penamaan domain: **Indonesia** (`Penyewaan`, `TarifPerHari`). Penamaan teknis bawaan C# tetap Inggris.
- Class, method, property: **PascalCase**. Field private: **camelCase**. Pengecualian: class controller memakai awalan `c_` (`c_Auth`, `c_Alat`, …) sesuai laporan.
- Nama kontrol WinForms memakai prefiks jelas: `btn`, `lbl`, `txt`, `dgv`, `pnl`, `cmb`, `dtp`, `chk`. Hindari nama bawaan seperti `label3`.
- Warna tema (format `R; G; B`): hijau tua `47; 93; 58` (sidebar, header, judul), hijau `62; 122; 60` (menu aktif, tombol utama), krem `247; 245; 238` (latar), cokelat `139; 94; 52` (aksen), kuning `224; 165; 38` (tombol Ubah, peringatan), merah bata `179; 65; 47` (Logout, Hapus, terlambat). Pakai palet ini untuk setiap form baru.
- Setiap halaman adalah satu Form tersendiri dengan sidebar di dalamnya.
- Validasi ditaruh di dalam class model, bukan di Form.
- Jangan membuat komentar yang hanya mengulang isi kode.

## 10. Cara bekerja
- **Jangan mengubah, membuat, atau menghapus file apa pun tanpa izin saya**, termasuk menjalankan build atau perintah git yang mengubah file.
- **Jelaskan dulu, kode belakangan.** Untuk fitur baru, jelaskan pendekatan dan class yang terlibat sebelum menulis kode. Saya sedang belajar dan ingin memahami hasilnya.
- Jangan menulis ulang banyak file sekaligus. Ubah sekecil mungkin dan sebutkan file mana yang berubah.
- **Jangan mengedit `*.Designer.cs` secara manual** kecuali saya minta. Perubahan tampilan sebaiknya lewat Designer di Visual Studio; beri saya langkahnya.
- Jangan commit atau push tanpa diminta. Folder `bin/` dan `obj/` tidak boleh masuk repo (pastikan `.gitignore` benar).
- Perubahan ke branch utama sebaiknya lewat Pull Request.
- Kalau ada dua cara yang masuk akal, tanyakan dulu, jangan memilih diam-diam.
- Kalau permintaan saya bertentangan dengan rancangan di dokumen ini atau laporan (misalnya merusak enkapsulasi), beri tahu sebelum mengerjakan.
- Jangan menambah paket NuGet atau mengganti database tanpa persetujuan.

## 11. Urutan pengerjaan yang disepakati
1. Model (uji dulu tanpa database)
2. `databaseHelper` dan skema tabel
3. Repository (uji CRUD)
4. Controller
5. View: Login → CRUD Alat → Sewa → Pengembalian → Laporan → Dashboard (data nyata) → Kelola User
