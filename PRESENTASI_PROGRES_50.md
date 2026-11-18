# Agri-Rent — Bahan Presentasi Progres 50%

**Aplikasi Manajemen Persewaan Alat Pertanian (Traktor & Pompa Air)**
Proyek Akhir Pemrograman Berorientasi Objek — C# Windows Forms (.NET 10) + PostgreSQL

---

## Daftar Isi

1. [Gambaran Singkat](#1-gambaran-singkat)
2. [Status Progres](#2-status-progres)
3. [Arsitektur MVC + Repository](#3-arsitektur-mvc--repository)
4. [Penjelasan Setiap Folder dan File](#4-penjelasan-setiap-folder-dan-file)
5. [Alur MVC per Fitur](#5-alur-mvc-per-fitur)
6. [Peta 4 Pilar OOP (letak di kode)](#6-peta-4-pilar-oop-letak-di-kode)
7. [Aturan Bisnis dan Rumus](#7-aturan-bisnis-dan-rumus)
8. [Basis Data](#8-basis-data)
9. [Skenario Demo](#9-skenario-demo)
10. [Kemungkinan Pertanyaan Dosen dan Jawabannya](#10-kemungkinan-pertanyaan-dosen-dan-jawabannya)

---

## 1. Gambaran Singkat

Agri-Rent membantu usaha persewaan alat pertanian mencatat **alat**, **penyewaan**, **pengembalian beserta denda**, dan **laporan**.

Ada dua peran pengguna:

| Peran | Menu yang bisa diakses |
|---|---|
| **Admin** | Dashboard, Kelola Alat, Kelola Sewa, Kelola Pengembalian, Laporan, Kelola User |
| **Petugas** | Dashboard, Kelola Sewa, Kelola Pengembalian |

Teknologi:

- Bahasa C#, Windows Forms, target `net10.0-windows`
- Database PostgreSQL (database `agri-rent`), diakses dengan library **Npgsql**
- Pola arsitektur **MVC + Repository**

---

## 2. Status Progres

| Fitur | Status | Keterangan |
|---|---|---|
| Login + hak akses menu | ✅ Selesai | Menu sidebar mengikuti peran |
| Kelola User | ✅ Selesai | Tambah, ubah, hapus pengguna (khusus Admin) |
| Kelola Alat | ✅ Selesai | CRUD Traktor & Pompa Air + pencarian |
| Kelola Pengembalian & Denda | ✅ Selesai | Denda terlambat otomatis + denda kerusakan |
| Dashboard | ✅ Selesai | 4 kartu ringkasan + tabel transaksi terakhir |
| Kelola Sewa & Pembayaran | ⏳ Berikutnya | Desain form sudah ada |
| Laporan | ⏳ Berikutnya | Desain form sudah ada |

Yang belum dibuat di kode (sesuai rancangan laporan): class `Pembayaran` (abstract), `PembayaranTunai`, `PembayaranTransfer`, `Laporan` (abstract), `LaporanPendapatan`, `LaporanAlat`, `LaporanDenda`, serta method `BuatSewa()` dan `CatatPembayaran()`.

---

## 3. Arsitektur MVC + Repository

```
┌──────────┐    memanggil    ┌──────────────┐   memanggil   ┌──────────────┐   memakai   ┌────────────────┐
│   VIEW   │ ─────────────▶ │  CONTROLLER  │ ────────────▶ │  REPOSITORY  │ ──────────▶ │ databaseHelper │ ──▶ PostgreSQL
│ (Form)   │ ◀───────────── │   (c_...)    │ ◀──────────── │ (...Repo)    │ ◀────────── │                │
└──────────┘   objek Hasil   └──────────────┘  objek Model  └──────────────┘   baris data └────────────────┘
       ╲                            │                             ╱
        ╲───────────────────▶   MODEL (class domain)   ◀─────────╱
                         dipakai oleh semua lapisan
```

**Ketergantungan hanya satu arah.** View tidak pernah menyentuh SQL, dan Model tidak tahu apa-apa tentang database maupun tampilan.

| Lapisan | Tugas | Yang **tidak boleh** dilakukan |
|---|---|---|
| **Model** | Menyimpan data dan aturan bisnis (validasi, rumus biaya, perubahan status) | Memakai database, `MessageBox`, atau kontrol WinForms |
| **Repository** | Menyimpan dan mengambil objek dari database | Menampilkan sesuatu atau berisi aturan bisnis |
| **Controller** | Menghubungkan View dengan Model dan Repository, lalu mengembalikan `Hasil` (berhasil/gagal + pesan) | Menampilkan `MessageBox` atau mengatur kontrol |
| **View** | Menampilkan data dan menangani klik pengguna | Menulis SQL atau menghitung aturan bisnis |

**Cara error mengalir:**

1. Model menemukan pelanggaran aturan, lalu **melempar exception** (`ArgumentException` / `InvalidOperationException`).
2. Controller **menangkapnya** di `Hasil.Coba()` dan mengubahnya menjadi `Hasil.Gagal("pesan")`.
3. View menampilkan pesannya lewat `Tampilan.TampilkanHasil()`.

Contoh: tarif 0 diisi di form, lalu `AlatPertanian.UbahData()` melempar `"Tarif per hari harus lebih dari 0."`, lalu `c_Alat` mengembalikan `Hasil.Gagal`, lalu form menampilkan kotak peringatan.

---

## 4. Penjelasan Setiap Folder dan File

Struktur folder `projek-pbo/`:

```
projek-pbo/
├── Program.cs              ← titik masuk aplikasi
├── databaseHelper.cs       ← satu-satunya pintu ke database
├── model/                  ← class domain + aturan bisnis (OOP utama ada di sini)
├── repository/             ← akses database per objek
├── controller/             ← penghubung View ↔ Model/Repository
└── view/                   ← Form WinForms
```

### 4.1 File di akar proyek

| File | Isi |
|---|---|
| `Program.cs` | Titik masuk aplikasi. Memanggil `databaseHelper.InisialisasiDatabase()` (membuat tabel bila belum ada), lalu membuka `FormLogin`. Kalau database tidak bisa dihubungi, tampil pesan error dan aplikasi berhenti. |
| `databaseHelper.cs` | Satu-satunya pintu ke database. Isinya:<ul><li>`GetConnection()`: membuat koneksi ke PostgreSQL.</li><li>`BuatCommand()`: membuat perintah SQL; **semua nilai dimasukkan sebagai parameter** (`@nama`) sehingga aman dari SQL injection.</li><li>`Eksekusi()`: menjalankan INSERT, UPDATE, atau DELETE.</li><li>`AmbilNilai()`: mengambil satu nilai, misalnya `COUNT(*)`.</li><li>`AmbilDaftar<T>()`: mengambil banyak baris lalu memetakan tiap baris menjadi objek lewat fungsi yang diberikan repository.</li><li>`JalankanTransaksi()`: menjalankan beberapa perintah sebagai satu kesatuan (commit semua atau rollback semua).</li><li>`InisialisasiDatabase()`: `CREATE TABLE IF NOT EXISTS` untuk 7 tabel, lalu mengisi akun awal dan data contoh kalau tabelnya masih kosong.</li></ul> |

### 4.2 Folder `model/` (inti OOP)

| File | Jenis | Penjelasan |
|---|---|---|
| `Pengguna.cs` | **abstract class** | Induk semua pengguna.<ul><li>Field `password` bersifat **private**.</li><li>`Id`, `NamaLengkap`, dan `Username` memakai `private set`.</li><li>Property abstrak `Peran` dan method abstrak `MenuTersedia()`.</li><li>`UbahData()`: validasi nama wajib diisi dan username tanpa spasi.</li><li>`UbahPassword()`: minimal 4 karakter.</li><li>`CekPassword()`: mencocokkan password tanpa membukanya ke luar class.</li><li>`Buat()`: *factory method* yang membuat `Admin` atau `Petugas` dari teks peran.</li><li>`GantiPeran()`: membuat objek baru dengan peran lain dan menyalin passwordnya.</li></ul> |
| `Admin.cs` | turunan `Pengguna` | `Peran = "Admin"`; `MenuTersedia()` mengembalikan keenam menu. |
| `Petugas.cs` | turunan `Pengguna` | `Peran = "Petugas"`; `MenuTersedia()` hanya mengembalikan Dashboard, Kelola Sewa, dan Kelola Pengembalian. |
| `MenuAplikasi.cs` | enum | Daftar menu: Dashboard, KelolaAlat, KelolaSewa, KelolaPengembalian, Laporan, KelolaUser. |
| `AlatPertanian.cs` | **abstract class** | Induk semua alat.<ul><li>Atribut umum: kode, nama, merek, deskripsi, tahun, kondisi, tarif, status. Semua memakai `private set`.</li><li>`UbahData()`: validasi tarif > 0, tahun tidak di masa depan, merek wajib diisi.</li><li>`Sewakan()`, `Kembalikan()`, `TandaiRusak()`, `Perbaiki()`: **satu-satunya cara** mengubah status, masing-masing dengan pengecekan status asal.</li><li>Abstrak: `Jenis` dan `Spesifikasi()`.</li></ul> |
| `Traktor.cs` | turunan `AlatPertanian` | Atribut tambahan: `TenagaHp`, `KapasitasTangki`, `JenisTraktor`. Override `Jenis` → `"Traktor"` dan `Spesifikasi()` → contoh `"Roda 4, 75 HP, tangki 60 L"`. |
| `PompaAir.cs` | turunan `AlatPertanian` | Atribut tambahan: `DebitLiterPerMenit`, `BeratKg`, `BahanBakar`, `DiameterPipaInci`. Override `Jenis` → `"Pompa Air"` dan `Spesifikasi()` → contoh `"1100 L/menit, Bensin, pipa 3", 27 kg"`. |
| `KondisiAlat.cs` | enum + helper | `Baik`, `Cukup`, `PerluServis`. Helper `KeTeks()`/`DariTeks()` mengubah enum ke teks layar ("Perlu servis") dan sebaliknya. |
| `StatusAlat.cs` | enum | `Tersedia`, `Disewa`, `Rusak` (ketersediaan alat, berbeda dengan kondisi fisik). |
| `JenisTraktor.cs` | enum + helper | `Roda2`, `Roda4`, ditambah konversi ke teks "Roda 2"/"Roda 4". |
| `Penyewa.cs` | class biasa | Nama (wajib), nomor telepon, alamat. |
| `Penyewaan.cs` | class biasa | Satu transaksi sewa.<ul><li>**Konstanta private** `BatasHariDiskon = 7` dan `PersenDiskon = 10%`.</li><li>`Status` memakai `private set`.</li><li>Validasi: tanggal rencana kembali harus setelah tanggal mulai.</li><li>Perhitungan: `Durasi`, `HitungBiayaDasar()`, `HitungDiskon()`, `HitungTotalBiaya()`, `HitungHariTerlambat()`.</li><li>`Selesaikan()`: mengubah status menjadi Selesai.</li></ul> |
| `StatusSewa.cs` | enum | `Aktif`, `Selesai`. |
| `IDenda.cs` | **interface** | Kontrak semua jenis denda: property `Keterangan` dan method `HitungDenda()`. |
| `DendaTerlambat.cs` | implementasi `IDenda` | Rumus: hari terlambat × 10% × tarif per hari, **maksimal sebesar total biaya sewa**. Persentasenya disimpan sebagai konstanta private. |
| `DendaKerusakan.cs` | implementasi `IDenda` | Nominal diinput manual. Validasi: nominal > 0 dan keterangan wajib diisi. |
| `Pengembalian.cs` | class biasa | Menyimpan **kumpulan `IDenda`**. Isinya:<ul><li>`TambahDenda()`.</li><li>`TotalDenda()`: menjumlahkan semua denda secara polimorfik.</li><li>`Proses()`: menyelesaikan sewa, lalu alat ditandai Rusak kalau ada kerusakan, atau dikembalikan ke Tersedia kalau tidak.</li><li>Validasi: sewa harus aktif, tanggal kembali tidak sebelum tanggal mulai dan tidak di masa depan.</li></ul> |
| `Kartu.cs` | class biasa | Satu kartu di Dashboard (`Judul`, `Nilai`). Keempat kartu bentuknya sama, jadi tidak dibuat hierarki. |
| `kelolaDataAlat.cs`, `kelolaSewa.cs`, `kelolaPengembalian.cs`, `laporan.cs` | — | File kosong peninggalan awal proyek. **Tidak dipakai dan akan dihapus.** |

### 4.3 Folder `repository/`

Setiap repository punya **interface** (kontrak) dan **class implementasi**. Controller memegang variabel bertipe interface, misalnya `IAlatRepository alatRepository = new AlatRepository();`.

| File | Penjelasan |
|---|---|
| `IPenggunaRepository.cs` / `PenggunaRepository.cs` | Method `AmbilSemua`, `CariById`, `CariByUsername`, `UsernameSudahDipakai`, `Tambah`, `Ubah`, `Hapus`. Saat membaca, kolom `peran` menentukan objek yang dibuat (`Admin` atau `Petugas`) lewat `Pengguna.Buat()`. |
| `IAlatRepository.cs` / `AlatRepository.cs` | Method `AmbilSemua`, `Cari(kode)`, `Cari(kataKunci, jenis)`, `Tambah`, `Ubah`, `Hapus`, `HitungTersedia`.<ul><li>`Petakan()` membaca kolom `jenis` untuk menentukan apakah baris dijadikan objek `Traktor` atau `PompaAir`.</li><li>Kolom khusus jenis lain diisi `NULL`.</li><li>`Hapus()` mengubah error foreign key menjadi pesan "sudah memiliki riwayat sewa".</li></ul> |
| `IPenyewaanRepository.cs` / `PenyewaanRepository.cs` | Method `AmbilSewaAktif(namaPenyewa)`, `AmbilTerakhir(jumlah)`, `HitungAktif`, `HitungTerlambat`, `TotalPembayaranLunas`. Query JOIN tiga tabel (penyewaan, penyewa, alat) lalu dibentuk menjadi objek `Penyewaan` lengkap dengan `Penyewa` dan `AlatPertanian`-nya. |
| `IPengembalianRepository.cs` / `PengembalianRepository.cs` | `Simpan(pengembalian)` menjalankan **4 perubahan dalam 1 transaksi**: insert pengembalian, insert setiap denda, update status sewa, update status alat. `TotalDenda(awal, akhir)` dipakai Dashboard. |

### 4.4 Folder `controller/`

| File | Penjelasan |
|---|---|
| `Hasil.cs` | Objek balasan untuk View: `Berhasil` (bool) dan `Pesan` (string). `Hasil.Coba(aksi)` menjalankan aksi dan menangkap `ArgumentException`, `InvalidOperationException`, serta error database, lalu mengubahnya menjadi `Hasil.Gagal`. |
| `c_Auth.cs` | `Login(username, password)` mencari pengguna dan mencocokkan password lewat `CekPassword()`. Pengguna yang berhasil login disimpan di `c_Auth.PenggunaAktif`. `Logout()` mengosongkannya. |
| `c_Pengguna.cs` | `AmbilSemuaPengguna`, `TambahPengguna`, `UbahPengguna`, `HapusPengguna`. Aturan tambahan:<ul><li>Hanya Admin yang boleh (`PastikanAdmin()` mengecek `PenggunaAktif is Admin`).</li><li>Username tidak boleh kembar.</li><li>Admin tidak bisa mengubah perannya sendiri atau menghapus akunnya sendiri.</li><li>Password yang dikosongkan saat ubah berarti password lama dipertahankan.</li></ul> |
| `InputAlat.cs` | Wadah isian form alat dalam bentuk teks (DTO), supaya parameter method controller tidak terlalu panjang. |
| `c_Alat.cs` | `AmbilSemuaAlat`, **`Cari(kode)`** dan **`Cari(nama, jenis)`** (overloading), `TambahAlat`, `UbahAlat`, `HapusAlat`.<ul><li>`BuatAlat()` membuat objek `Traktor` atau `PompaAir` sesuai pilihan jenis.</li><li>Angka diubah dengan format Indonesia ("800.000", "2,5").</li><li>Alat baru selalu berstatus Tersedia.</li><li>Kode tidak boleh kembar.</li><li>Jenis alat tidak bisa diubah.</li><li>Alat yang sedang disewa tidak bisa dihapus.</li></ul> |
| `c_Penyewaan.cs` | Saat ini berisi `AmbilSewaAktif()` untuk form pengembalian. `BuatSewa()` dan `CatatPembayaran()` menyusul. |
| `c_Pengembalian.cs` | `HitungRincian()`: pratinjau denda di layar, tidak menyimpan apa pun. `ProsesPengembalian()`:<ol><li>Membuat objek `Pengembalian`.</li><li>Menambah `DendaTerlambat` otomatis kalau terlambat.</li><li>Menambah `DendaKerusakan` kalau dicentang.</li><li>Memanggil `Proses()`.</li><li>Menyimpan lewat repository.</li></ol> |
| `c_Dashboard.cs` | `AmbilKartu()` mengembalikan 4 objek `Kartu`: alat tersedia, sewa aktif, sewa terlambat, dan pendapatan bulan ini (pembayaran Lunas + denda). `AmbilTransaksiTerakhir()` mengembalikan 10 penyewaan terbaru. |

### 4.5 Folder `view/`

Setiap Form terdiri dari 3 file: `.cs` (kode event yang kita tulis), `.Designer.cs` (kode tata letak buatan Visual Studio Designer), dan `.resx` (resource Designer).

| File | Penjelasan |
|---|---|
| `FormLogin` | Input username dan password, tombol Login (bisa juga dengan tombol Enter). Kalau berhasil, `Navigasi.SetelahLogin()` membuka Dashboard dan menyembunyikan form login. Saat logout, form login muncul lagi dengan kolom password kosong. |
| `formDashboard` | Mengisi 4 kartu dan tabel transaksi terakhir dari `c_Dashboard`. Status "Terlambat" ditandai warna merah bata. |
| `FormKelolaUser` | Isian nama, username, password, dan peran, ditambah tabel pengguna.<ul><li>Klik baris untuk memilih pengguna: tombol Ubah dan Hapus aktif, tombol Simpan nonaktif.</li><li>Tombol Bersihkan mengosongkan form.</li></ul> |
| `formKelolaAlat` | Isian atribut umum, ditambah panel spesifikasi yang **berganti** sesuai jenis (`pnlTraktor` / `pnlPompaAir`).<ul><li>Status hanya bisa dibaca (diubah otomatis oleh sistem).</li><li>Saat mengubah data, kode dan jenis dikunci.</li><li>Kolom pencarian dan filter jenis.</li></ul> |
| `formKelolaPengembalian` | Tabel sewa aktif; sewa yang terlambat ditandai merah.<ul><li>Pilih sewa, lalu atur tanggal kembali. Hari terlambat, denda, dan total denda **langsung dihitung ulang**.</li><li>Checkbox "Ada kerusakan" mengaktifkan isian nominal dan keterangan.</li><li>Tombol Proses Pengembalian.</li></ul> |
| `formKelolaSewa`, `formLaporan` | Baru desain tampilan dan sidebar. Logikanya menyusul. |
| `Navigasi.cs` | Pengatur perpindahan halaman lewat sidebar.<ul><li>`PasangSidebar()` **menyembunyikan tombol menu yang tidak ada di `MenuTersedia()`** pengguna yang login.</li><li>Membuka form tujuan dan menutup form lama.</li><li>Menangani Logout.</li><li>Menutup form dengan tombol X berarti keluar dari aplikasi.</li></ul> |
| `Tampilan.cs` | Fungsi bantu untuk semua form: format Rupiah (`Rp800.000`), angka, tanggal (dd/MM/yyyy), dan kotak pesan Info, Peringatan, Error, Konfirmasi. |

---

## 5. Alur MVC per Fitur

### 5.1 Login

```
FormLogin.btnLogin_Click
  └─▶ c_Auth.Login(username, password)
        ├─▶ PenggunaRepository.CariByUsername(username)
        │     └─▶ databaseHelper.AmbilDaftar("SELECT ... WHERE username = @username")
        │     └─▶ Pengguna.Buat(peran, ...)  → objek Admin / Petugas
        ├─▶ pengguna.CekPassword(password)      (password tetap private di Model)
        └─▶ simpan ke c_Auth.PenggunaAktif → return Hasil.Sukses
  └─▶ gagal: Tampilan.Peringatan(pesan)
  └─▶ berhasil: Navigasi.SetelahLogin(this) → buka formDashboard
        └─▶ Navigasi.PasangSidebar() → pengguna.MenuTersedia()   (POLYMORPHISM)
              Admin  → 6 tombol tampil
              Petugas→ 3 tombol tampil
```

Poin penting:

- Form tidak tahu cara mengecek password. Pengecekan dilakukan `CekPassword()` di Model.
- Form tidak tahu peran apa saja yang ada. Form cukup memanggil `MenuTersedia()`, dan hasilnya berbeda tergantung objeknya `Admin` atau `Petugas`.

### 5.2 Kelola User

**Tambah pengguna:**

```
FormKelolaUser.btnSimpan_Click
  └─▶ c_Pengguna.TambahPengguna(nama, username, password, peran)
        ├─▶ PastikanAdmin()                         → hanya Admin
        ├─▶ Pengguna.Buat(peran, ...)               → validasi di constructor (UbahData, UbahPassword)
        ├─▶ PenggunaRepository.UsernameSudahDipakai → cegah username kembar
        └─▶ PenggunaRepository.Tambah(pengguna)     → INSERT ... VALUES (@username, ...)
  └─▶ Tampilan.TampilkanHasil(hasil) → MuatData()
```

**Ubah pengguna:**

```
FormKelolaUser.btnUbah_Click
  └─▶ c_Pengguna.UbahPengguna(id, nama, username, passwordBaru, peran)
        ├─▶ CariById(id)
        ├─▶ tolak jika mengubah peran akun sendiri
        ├─▶ peran berubah? → pengguna.GantiPeran(peran)  (objek Admin ↔ Petugas baru)
        ├─▶ pengguna.UbahData(...) ; jika password diisi → pengguna.UbahPassword(...)
        └─▶ PenggunaRepository.Ubah(pengguna)
```

**Hapus pengguna:** setelah konfirmasi, `c_Pengguna.HapusPengguna(id)` menolak kalau yang dihapus adalah akun sendiri, lalu memanggil `PenggunaRepository.Hapus(id)`.

### 5.3 Kelola Alat

**Tambah alat:**

```
formKelolaAlat.btnTambah_Click
  └─▶ AmbilIsian() → objek InputAlat (teks dari form)
  └─▶ c_Alat.TambahAlat(input)
        ├─▶ BuatAlat(input)
        │     ├─ jenis "Traktor"   → new Traktor(...)    ┐ constructor memvalidasi
        │     └─ jenis "Pompa Air" → new PompaAir(...)   ┘ (base → AlatPertanian.UbahData)
        ├─▶ AlatRepository.Cari(kode) → tolak kode kembar
        └─▶ AlatRepository.Tambah(alat) → INSERT; kolom jenis lain = NULL
  └─▶ MuatUlang() → tabel diisi ulang
```

**Menampilkan tabel (polymorphism):**

```
c_Alat.AmbilSemuaAlat() → AlatRepository.AmbilSemua()
   └─▶ Petakan(): kolom jenis = "Traktor" → new Traktor ; "PompaAir" → new PompaAir
formKelolaAlat.TampilkanDaftar(List<AlatPertanian>)
   └─▶ alat.Jenis, alat.Spesifikasi()   ← dipanggil lewat tipe induk, hasilnya sesuai subclass
```

**Ubah alat:** `c_Alat.UbahAlat()` menjalankan langkah berikut:

1. Ambil alat dari database.
2. Tolak kalau jenisnya diganti.
3. Panggil `alat.UbahData(...)`.
4. Kalau objeknya `Traktor`, panggil `UbahSpesifikasi(...)` milik Traktor; kalau `PompaAir`, panggil `UbahSpesifikasi(...)` milik PompaAir.
5. Simpan lewat `AlatRepository.Ubah()`.

**Hapus alat:** `c_Alat.HapusAlat()` menolak kalau status alat Disewa. Kalau alat sudah punya riwayat sewa, database menolak (foreign key), dan repository mengubah error itu menjadi pesan yang jelas.

**Cari alat (overloading):**

```
formKelolaAlat.btnCari_Click
  ├─▶ c_Alat.Cari(kataKunci)          → Cari(string kode): hasil 1 alat atau null
  │      jika ketemu (dan jenis cocok) → tampilkan 1 alat itu
  └─▶ c_Alat.Cari(kataKunci, jenis)   → Cari(string nama, string jenis): daftar alat
         AlatRepository.Cari(...) → WHERE (kode ILIKE @kata OR nama ILIKE @kata OR merek ILIKE @kata) [AND jenis = @jenis]
```

### 5.4 Kelola Pengembalian dan Denda

**Menampilkan sewa aktif:**

```
formKelolaPengembalian.MuatData()
  └─▶ c_Penyewaan.AmbilSewaAktif(cariNama)
        └─▶ PenyewaanRepository → JOIN penyewaan + penyewa + alat → List<Penyewaan>
  └─▶ setiap baris: sewa.HitungHariTerlambat(hari ini) → "Terlambat n hari" (merah) / "Tepat waktu"
```

**Pratinjau denda** (setiap kali tanggal, checkbox, atau nominal berubah):

```
PerbaruiRincian()
  └─▶ c_Pengembalian.HitungRincian(sewa, tanggal, adaKerusakan, nominal)
        ├─▶ sewa.HitungHariTerlambat(tanggal)
        ├─▶ new DendaTerlambat(hari, tarif, totalBiaya).HitungDenda()
        └─▶ return RincianDenda(hari, dendaTerlambat, dendaKerusakan, total)
```

**Proses pengembalian:**

```
formKelolaPengembalian.btnProses_Click
  └─▶ c_Pengembalian.ProsesPengembalian(sewa, tanggal, adaKerusakan, nominal, keterangan)
        ├─▶ new Pengembalian(0, sewa, tanggal)               → validasi tanggal & status sewa
        ├─▶ jika terlambat: TambahDenda(new DendaTerlambat(...))   ┐ keduanya disimpan
        ├─▶ jika rusak:     TambahDenda(new DendaKerusakan(...))   ┘ sebagai IDenda
        ├─▶ pengembalian.Proses()
        │     ├─ Penyewaan.Selesaikan()           → status sewa = Selesai
        │     └─ ada kerusakan? Alat.TandaiRusak() : Alat.Kembalikan()
        └─▶ PengembalianRepository.Simpan(pengembalian)   ── SATU TRANSAKSI ──
              1. INSERT pengembalian RETURNING id
              2. INSERT denda (untuk tiap IDenda; jenis Terlambat / Kerusakan)
              3. UPDATE penyewaan SET status
              4. UPDATE alat SET status
  └─▶ pesan berisi total denda = pengembalian.TotalDenda()  (POLYMORPHISM lewat IDenda)
```

### 5.5 Dashboard

```
formDashboard.MuatData()
  ├─▶ c_Dashboard.AmbilKartu()
  │     ├─▶ AlatRepository.HitungTersedia()                 → kartu "Alat Tersedia"
  │     ├─▶ PenyewaanRepository.HitungAktif()               → kartu "Sewa Aktif"
  │     ├─▶ PenyewaanRepository.HitungTerlambat(hari ini)   → kartu "Sewa Terlambat"
  │     └─▶ TotalPembayaranLunas(bulan ini) + PengembalianRepository.TotalDenda(bulan ini)
  │                                                          → kartu "Pendapatan Bulan Ini"
  │     return List<Kartu>
  └─▶ c_Dashboard.AmbilTransaksiTerakhir() → 10 penyewaan terbaru → tabel
```

`Kartu` tidak mengambil data sendiri. Nilainya disiapkan oleh Controller, sesuai rancangan.

---

## 6. Peta 4 Pilar OOP (letak di kode)

### 6.1 Abstraction

Abstraksi berarti menyembunyikan detail dan hanya menampilkan "apa yang bisa dilakukan".

| Letak | Bentuk | Fitur yang memakai |
|---|---|---|
| `model/Pengguna.cs` | `public abstract class Pengguna` dengan anggota abstrak `Peran` dan `MenuTersedia()` | Login, Kelola User |
| `model/AlatPertanian.cs` | `public abstract class AlatPertanian` dengan anggota abstrak `Jenis` dan `Spesifikasi()` | Kelola Alat, Pengembalian, Dashboard |
| `model/IDenda.cs` | `public interface IDenda` (`Keterangan`, `HitungDenda()`) | Pengembalian |
| `repository/I...Repository.cs` | Interface repository; controller bergantung pada kontrak, bukan pada class konkret | Semua fitur |

`Pengguna` dan `AlatPertanian` tidak bisa dibuat langsung dengan `new`. Yang dibuat selalu turunannya.

### 6.2 Inheritance

Inheritance berarti class turunan mewarisi atribut dan method induknya.

| Induk | Turunan | Letak | Yang diwarisi |
|---|---|---|---|
| `Pengguna` | `Admin`, `Petugas` | `model/Admin.cs`, `model/Petugas.cs` | Id, nama, username, password, `UbahData()`, `UbahPassword()`, `CekPassword()` |
| `AlatPertanian` | `Traktor`, `PompaAir` | `model/Traktor.cs`, `model/PompaAir.cs` | 8 atribut umum, validasi, `Sewakan()`, `Kembalikan()`, `TandaiRusak()`, `Perbaiki()` |

Constructor turunan memanggil constructor induk dengan `: base(...)`. Validasi umum ditulis **sekali saja** di induk.

Hierarki yang direncanakan untuk tahap berikutnya: `Pembayaran` → `PembayaranTunai` / `PembayaranTransfer`, dan `Laporan` → `LaporanPendapatan` / `LaporanAlat` / `LaporanDenda`.

### 6.3 Polymorphism

| Jenis | Letak deklarasi | Letak pemanggilan polimorfik |
|---|---|---|
| Override `MenuTersedia()` | `Admin.cs`, `Petugas.cs` | `view/Navigasi.cs` → `PasangSidebar()`: `pengguna.MenuTersedia()` |
| Override `Peran` | `Admin.cs`, `Petugas.cs` | `PenggunaRepository` (disimpan ke kolom `peran`), `FormKelolaUser` (tabel) |
| Override `Jenis` & `Spesifikasi()` | `Traktor.cs`, `PompaAir.cs` | `view/formKelolaAlat.cs` → `TampilkanDaftar()`: `alat.Jenis`, `alat.Spesifikasi()`; juga di `formDashboard` |
| Implementasi `HitungDenda()` lewat interface | `DendaTerlambat.cs`, `DendaKerusakan.cs` | `model/Pengembalian.cs` → `TotalDenda()`: `daftarDenda.Sum(denda => denda.HitungDenda())`; `PengembalianRepository.Simpan()` |
| **Overloading** `Cari()` | `controller/c_Alat.cs`: `Cari(string kode)` dan `Cari(string nama, string jenis)`; juga di `AlatRepository` | `view/formKelolaAlat.cs` → `btnCari_Click` |

Contoh kalimat untuk presentasi: "Di `Pengembalian.TotalDenda()` kami tidak menulis `if` per jenis denda. Setiap objek denda menghitung dirinya sendiri. Kalau nanti ada jenis denda baru, cukup buat class baru yang mengimplementasikan `IDenda`, tanpa mengubah `Pengembalian`."

### 6.4 Encapsulation

| Letak | Yang dilindungi | Cara aksesnya |
|---|---|---|
| `Pengguna.cs` | `private string password` | Hanya lewat `UbahPassword()` (ada validasi) dan `CekPassword()` (hanya mengembalikan true/false). Repository memakai `internal AmbilPasswordUntukDisimpan()`. |
| `Pengguna.cs` | `Id`, `NamaLengkap`, `Username` dengan `private set` | Lewat `UbahData()` |
| `AlatPertanian.cs` | `Status { get; private set; }` | **Hanya** lewat `Sewakan()`, `Kembalikan()`, `TandaiRusak()`, `Perbaiki()`, masing-masing mengecek status asal |
| `AlatPertanian.cs` | Nama, merek, tahun, kondisi, tarif dengan `private set` | Lewat `UbahData()` (validasi tarif > 0, tahun, merek) |
| `Traktor.cs`, `PompaAir.cs` | Atribut spesifikasi dengan `private set` | Lewat `UbahSpesifikasi()` dengan validasi |
| `Penyewaan.cs` | `private const BatasHariDiskon = 7`, `PersenDiskon = 0.10m`; `Status` dengan `private set` | Lewat `HitungDiskon()`, `Selesaikan()` |
| `DendaTerlambat.cs` | `private const PersenPerHari = 0.10m`, field `tarifPerHari` dan `totalBiayaSewa` private | Lewat `HitungDenda()` |
| `Pengembalian.cs` | `private readonly List<IDenda> daftarDenda` | Dibaca lewat `IReadOnlyList<IDenda> DaftarDenda`, ditambah lewat `TambahDenda()` |
| `c_Auth.cs` | `PenggunaAktif { get; private set; }` | Hanya diubah oleh `Login()` / `Logout()` |

Contoh di form: tidak ada kode seperti `alat.Status = StatusAlat.Rusak;`, karena compiler akan menolaknya. Status hanya berubah lewat method resmi.

### 6.5 Yang sengaja tidak dibuat OOP

- `HitungTotalBiaya()` **tidak di-override**, karena rumus tarif sama untuk semua alat.
- **Tidak ada abstract class `Denda`.** `IDenda` sudah cukup karena tidak ada data atau kode yang perlu diwariskan.
- **`Kartu` hanya satu class.** Keempat kartu bentuknya sama.
- Overloading hanya dipakai pada pencarian alat, karena di situ memang natural.

---

## 7. Aturan Bisnis dan Rumus

```
durasi         = tanggalRencanaKembali − tanggalMulai           (hari)
hariDiskon     = max(0, durasi − 7)
biayaDasar     = tarifPerHari × durasi
diskon         = hariDiskon × tarifPerHari × 10%
totalBiaya     = biayaDasar − diskon
hariTerlambat  = max(0, tanggalKembali − tanggalRencanaKembali)
dendaTerlambat = min(hariTerlambat × 10% × tarifPerHari, totalBiaya)
totalDenda     = dendaTerlambat + dendaKerusakan
```

**Contoh hitungan** (data contoh Ahmad, TR-002, tarif Rp250.000, sewa 10 hari, terlambat 2 hari):

| Komponen | Hitungan | Hasil |
|---|---|---|
| Biaya dasar | 10 × 250.000 | Rp2.500.000 |
| Diskon | (10 − 7) × 250.000 × 10% | Rp75.000 |
| Total biaya | 2.500.000 − 75.000 | **Rp2.425.000** |
| Denda terlambat | 2 × 10% × 250.000 = 50.000 (di bawah batas 2.425.000) | **Rp50.000** |

**Alur status alat:**

```
Tersedia ──Sewakan()──▶ Disewa ──Kembalikan()──▶ Tersedia
                           │
                           └──TandaiRusak()──▶ Rusak ──Perbaiki()──▶ Tersedia
```

**Aturan validasi lainnya:**

- **Alat:** tarif > 0; tahun keluaran tidak di masa depan; merek wajib diisi; kode maksimal 10 karakter dan tidak boleh kembar.
- **Penyewaan:** tanggal rencana kembali harus setelah tanggal mulai.
- **Pengembalian:** tanggal kembali tidak boleh sebelum tanggal mulai dan tidak boleh di masa depan; sewa harus masih Aktif.
- **Denda kerusakan:** nominal > 0 dan keterangan wajib diisi. Kalau ada kerusakan, alat menjadi Rusak.
- **Pengguna:** nama dan username wajib diisi; username tanpa spasi dan tidak kembar; password minimal 4 karakter.

---

## 8. Basis Data

PostgreSQL, database `agri-rent`, 7 tabel (dibuat otomatis oleh `databaseHelper.InisialisasiDatabase()`):

| Tabel | Kolom utama | Catatan |
|---|---|---|
| `pengguna` | id, username (UNIQUE), nama_lengkap, password, peran | `peran` ∈ {Admin, Petugas} |
| `alat` | kode (PK), nama, **jenis**, merek, deskripsi, tahun_keluaran, kondisi, tarif_per_hari, status, + kolom khusus Traktor & Pompa Air | Satu tabel untuk seluruh hierarki alat; kolom milik jenis lain bernilai NULL |
| `penyewa` | id, nama, no_telepon, alamat | |
| `penyewaan` | id, penyewa_id (FK), alat_kode (FK), tarif_per_hari (salinan), tanggal_mulai, tanggal_rencana_kembali, status | Tarif disalin agar perubahan tarif alat tidak mengubah sewa lama |
| `pembayaran` | id, penyewaan_id (FK), **metode**, nominal, tanggal, status, jumlah_diterima, bank_tujuan, no_referensi | Disiapkan untuk tahap Kelola Sewa |
| `pengembalian` | id, penyewaan_id (FK, UNIQUE), tanggal_kembali | Satu sewa hanya bisa dikembalikan sekali |
| `denda` | id, pengembalian_id (FK), **jenis**, keterangan, nominal, hari_terlambat | `jenis` ∈ {Terlambat, Kerusakan} |

**Pemetaan inheritance ke tabel (*single table inheritance*):** satu tabel per hierarki, dengan kolom pembeda (`alat.jenis`, `denda.jenis`, `pembayaran.metode`). Saat membaca data, repository melihat kolom pembeda itu untuk membuat objek subclass yang tepat.

**Akun awal:**

| Username | Password | Peran |
|---|---|---|
| admin | admin123 | Admin |
| petugas | petugas123 | Petugas |

**Data contoh:**

- 6 alat: TR-001, TR-002, TR-003, PA-001, PA-002, PA-003.
- 3 penyewa.
- 3 sewa aktif: Budi (tepat waktu), Siti (terlambat 3 hari), Ahmad (sewa 10 hari, terlambat 2 hari).

---

## 9. Skenario Demo

Urutan yang disarankan, sekitar 5–7 menit:

1. **Login sebagai `petugas`.** Tunjukkan sidebar hanya berisi 3 menu, lalu jelaskan `MenuTersedia()` (polymorphism). Kemudian Logout.
2. **Login sebagai `admin`.** Keenam menu muncul. Tunjukkan Dashboard: 4 kartu terisi dari database.
3. **Kelola Alat:**
   - Ganti jenis Traktor ↔ Pompa Air dan tunjukkan panel spesifikasi berganti.
   - Tambah alat dengan **tarif 0**. Muncul pesan error dari Model (enkapsulasi + validasi di class).
   - Perbaiki tarifnya lalu simpan. Kolom Spesifikasi di tabel berbeda untuk Traktor dan Pompa Air (override `Spesifikasi()`).
   - Coba hapus alat berstatus Disewa. Hapus ditolak.
   - Cari dengan kode `TR-001` (`Cari(kode)`), lalu dengan kata "Kubota" (`Cari(nama, jenis)`). Ini overloading.
4. **Kelola Pengembalian:**
   - Pilih sewa Ahmad. Hari terlambat dan denda langsung terhitung.
   - Centang "Ada kerusakan" dan isi Rp100.000 beserta keterangannya. Total denda bertambah.
   - Proses. Sewa hilang dari daftar, status alat menjadi Rusak (cek di Kelola Alat), dan pendapatan di Dashboard bertambah.
5. **Kelola User:**
   - Tambah pengguna baru.
   - Coba hapus akun sendiri. Hapus ditolak.
   - Ubah peran pengguna lain.

---

## 10. Kemungkinan Pertanyaan Dosen dan Jawabannya

### A. Tentang OOP

**1. Di mana abstraction di proyek ini?**
`Pengguna` dan `AlatPertanian` adalah abstract class, dan `IDenda` adalah interface. Contohnya, `AlatPertanian` menetapkan bahwa setiap alat *harus* punya `Jenis` dan `Spesifikasi()`, tapi isinya ditentukan oleh turunannya. Repository juga punya interface (`IAlatRepository`, dan lainnya), jadi controller bergantung pada kontrak, bukan pada class konkret.

**2. Kenapa `AlatPertanian` dibuat abstract, bukan class biasa?**
Karena di dunia nyata tidak ada "alat pertanian" yang jenisnya tidak jelas. Alatnya selalu traktor atau pompa air. Dengan `abstract`, compiler melarang `new AlatPertanian(...)`, dan setiap turunan dipaksa mengisi `Jenis` serta `Spesifikasi()`.

**3. Apa beda abstract class dan interface, dan kenapa denda memakai interface?**
Abstract class bisa berisi field, constructor, dan method yang sudah ada isinya untuk diwariskan. Interface hanya kontrak. `AlatPertanian` punya banyak atribut dan method yang sama (status, validasi), jadi cocok sebagai abstract class. Dua jenis denda **tidak berbagi data apa pun**: denda terlambat butuh hari dan tarif, denda kerusakan butuh nominal dan keterangan. Yang sama hanya "bisa dihitung" dan "punya keterangan", jadi cukup `IDenda`.

**4. Tunjukkan polymorphism-nya.**
- `Navigasi.PasangSidebar()` memanggil `pengguna.MenuTersedia()`. Variabelnya bertipe `Pengguna`, tapi hasilnya 6 menu untuk Admin dan 3 menu untuk Petugas.
- `formKelolaAlat.TampilkanDaftar()` memanggil `alat.Spesifikasi()` untuk daftar `AlatPertanian` yang isinya campuran Traktor dan PompaAir.
- `Pengembalian.TotalDenda()` menjumlahkan `HitungDenda()` dari daftar `IDenda`.

**5. Di mana overloading?**
`c_Alat.Cari(string kode)` mengembalikan satu alat, dan `c_Alat.Cari(string nama, string jenis)` mengembalikan daftar alat. Namanya sama, parameternya berbeda. Pasangan yang sama juga ada di `AlatRepository`.

**6. Apa beda overriding dan overloading?**
Overriding terjadi di class turunan yang mengganti isi method induk dengan signature yang sama, dan dipilih saat program berjalan (runtime). Overloading terjadi di class yang sama, dengan nama sama tapi parameter berbeda, dan dipilih saat kompilasi.

**7. Tunjukkan enkapsulasi. Kenapa status alat memakai `private set`?**
Supaya status tidak bisa diubah sembarangan dari luar, misalnya alat yang sedang disewa tiba-tiba diset Tersedia. Perubahan hanya lewat `Sewakan()`, `Kembalikan()`, `TandaiRusak()`, dan `Perbaiki()`, yang masing-masing mengecek status asal. Kalau form mencoba `alat.Status = ...`, program tidak bisa dikompilasi.

**8. Kenapa validasi ditaruh di Model, bukan di Form?**
Supaya aturannya berlaku di mana pun objek dipakai, dan tidak bisa dilewati. Contohnya, aturan "tarif > 0" cukup ditulis sekali di `AlatPertanian.UbahData()`, lalu otomatis berlaku saat tambah alat, ubah alat, maupun saat data dibaca dari database.

**9. Kenapa `HitungTotalBiaya()` tidak di-override per jenis alat?**
Karena rumus tarifnya sama untuk semua alat (tarif × durasi − diskon). Kami tidak memaksakan polymorphism di tempat yang tidak membutuhkannya.

**10. Kenapa tidak ada abstract class `Denda`?**
Tidak ada data atau kode bersama yang perlu diwariskan, jadi interface sudah cukup. Membuat abstract class kosong hanya menambah lapisan tanpa manfaat.

**11. Bagaimana mengganti peran Admin ↔ Petugas kalau peran ditentukan oleh class?**
Objek tidak bisa berganti class. Karena itu `Pengguna.GantiPeran()` membuat objek baru dari class peran yang baru, dengan id, nama, username, dan password yang sama. Password disalin di dalam class `Pengguna`, jadi tidak pernah keluar.

### B. Tentang MVC dan struktur kode

**12. Jelaskan alur MVC salah satu fitur.**
Lihat bagian 5. Contoh singkat untuk tambah alat:
1. Form mengumpulkan isian menjadi `InputAlat`, lalu memanggil `c_Alat.TambahAlat()`.
2. Controller membuat objek `Traktor` atau `PompaAir`. Model memvalidasi di constructornya.
3. Controller memanggil `AlatRepository.Tambah()`, yang menjalankan INSERT berparameter lewat `databaseHelper`.
4. Controller mengembalikan `Hasil`, dan form menampilkan pesannya.

**13. Kenapa ada lapisan Repository? Bukankah Controller bisa langsung query?**
Supaya tanggung jawabnya terpisah. Controller mengurus alur dan aturan, sedangkan Repository mengurus cara menyimpan dan mengambil data. Repository juga tempat pemetaan baris tabel menjadi subclass yang tepat (Traktor/PompaAir, Admin/Petugas). Kalau cara penyimpanan berubah, controller tidak ikut berubah.

**14. Kenapa Controller tidak memakai `MessageBox`?**
Supaya Controller tidak bergantung pada tampilan. Controller cukup mengembalikan `Hasil` (berhasil/gagal + pesan), dan View yang memutuskan cara menampilkannya.

**15. Apa fungsi class `Hasil` dan `Hasil.Coba()`?**
Menyeragamkan cara Controller membalas ke View. `Coba()` menjalankan aksi dan menangkap exception dari Model atau Repository (`ArgumentException`, `InvalidOperationException`, error database), lalu mengubahnya menjadi pesan. Dengan begitu, kode try-catch tidak perlu diulang di setiap method.

**16. Apa itu `InputAlat`?**
Wadah data (DTO) berisi teks dari form alat. Isian alat ada 15, jadi lebih rapi dikirim sebagai satu objek daripada 15 parameter. Pengubahan teks ke angka dan enum dilakukan di Controller.

**17. Kenapa nama controller memakai awalan `c_`?**
Mengikuti konvensi penamaan di laporan rancangan kami.

### C. Tentang database

**18. Bagaimana mencegah SQL injection?**
Semua query memakai parameter (`@kode`, `@nama`) lewat `databaseHelper.BuatCommand()`. Nilai dari pengguna tidak pernah digabung ke teks SQL.

**19. Bagaimana inheritance disimpan di database relasional?**
Dengan pola *single table inheritance*: satu tabel `alat` untuk Traktor dan Pompa Air, dengan kolom `jenis` sebagai pembeda. Kolom khusus jenis lain bernilai NULL. Saat membaca, `AlatRepository.Petakan()` melihat kolom `jenis` untuk membuat objek yang tepat.

**20. Kenapa pengembalian memakai transaksi?**
Karena satu pengembalian mengubah 4 tabel (pengembalian, denda, penyewaan, alat). Kalau salah satu gagal, misalnya listrik mati di tengah proses, semua perubahan dibatalkan (rollback). Dengan begitu data tidak setengah tersimpan, misalnya sewa sudah Selesai tapi alat masih berstatus Disewa.

**21. Kenapa tarif disalin ke tabel `penyewaan`?**
Supaya kalau tarif alat dinaikkan, biaya sewa yang sudah berjalan tidak ikut berubah.

**22. Kenapa password tidak di-hash?**
Hashing belum masuk materi perkuliahan sehingga belum kami terapkan. Tetapi password sudah dilindungi di level objek: field `password` di `Pengguna` bersifat private, tidak ada getter publik, dan pengecekan hanya lewat `CekPassword()`. Kalau nanti dibutuhkan, hashing cukup ditambahkan di `UbahPassword()` dan `CekPassword()` tanpa mengubah lapisan lain. Ini keuntungan dari enkapsulasi.

### D. Tentang aturan bisnis

**23. Bagaimana diskon dihitung?**
Diskon 10% hanya untuk hari yang melebihi 7 hari. Sewa 10 hari mendapat diskon untuk 3 hari. Batas 7 hari dan 10% disimpan sebagai konstanta private di `Penyewaan`.

**24. Kenapa denda keterlambatan dibatasi?**
Supaya denda tidak melebihi total biaya sewa. Maksimalnya 100% dari total biaya setelah diskon. Lihat `DendaTerlambat.HitungDenda()`.

**25. Apa beda kondisi dan status alat?**
Kondisi adalah keadaan fisik (Baik, Cukup, Perlu servis) dan diisi petugas. Status adalah ketersediaan (Tersedia, Disewa, Rusak) dan diubah otomatis oleh sistem lewat method resmi.

**26. Apa yang terjadi kalau alat dikembalikan rusak?**
Denda kerusakan ditambahkan (wajib > 0 dan ada keterangan), lalu `Pengembalian.Proses()` memanggil `Alat.TandaiRusak()` sehingga alat tidak bisa disewa lagi sampai `Perbaiki()` dipanggil.

**27. Apakah Petugas bisa mengakses Kelola User?**
Tidak, dan ini dicek di dua lapis:
1. Tombol menunya disembunyikan berdasarkan `MenuTersedia()`.
2. `c_Pengguna` tetap mengecek `PenggunaAktif is Admin`, jadi aturan ini tidak bisa dilewati walaupun form dibuka dengan cara lain.

**28. Bisakah alat yang sedang disewa dihapus?**
Tidak. `c_Alat.HapusAlat()` menolaknya. Alat yang sudah punya riwayat sewa juga ditolak oleh foreign key di database, dan errornya diubah menjadi pesan yang jelas.

### E. Tentang progres

**29. Apa yang belum selesai dan apa rencananya?**
- **Kelola Sewa:** `c_Penyewaan.BuatSewa()` (satu transaksi: simpan sewa, `alat.Sewakan()`, simpan pembayaran) dan hierarki `Pembayaran` → `PembayaranTunai` (langsung Lunas) / `PembayaranTransfer` (Menunggu Verifikasi sampai `Lunasi()`), dengan override `Proses()`.
- **Laporan:** hierarki `Laporan` → `LaporanPendapatan` / `LaporanAlat` / `LaporanDenda`, dengan override `BuatLaporan()`. Datanya diberikan oleh `c_Laporan`.

**30. Kenapa ada data sewa padahal fitur Kelola Sewa belum jadi?**
Data contoh sengaja diisi otomatis oleh `InisialisasiDatabase()` agar fitur Pengembalian dan Dashboard bisa diuji dan didemokan lebih dulu.

---

### Catatan sebelum presentasi

- Hapus 4 file kosong lama di `model/` (`kelolaDataAlat.cs`, `kelolaSewa.cs`, `kelolaPengembalian.cs`, `laporan.cs`) agar tidak ditanyakan.
- Pastikan PostgreSQL berjalan dan database `agri-rent` ada.
- Kalau data sudah berubah karena latihan demo, data contoh bisa diulang dengan mengosongkan tabel. Data contoh hanya dibuat saat tabel `alat` kosong.
