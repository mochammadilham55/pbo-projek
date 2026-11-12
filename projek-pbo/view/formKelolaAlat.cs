using projek_pbo.controller;
using projek_pbo.model;

namespace projek_pbo.view
{
    public partial class formKelolaAlat : Form
    {
        private readonly c_Alat controller = new c_Alat();
        private AlatPertanian? alatTerpilih;

        public formKelolaAlat()
        {
            InitializeComponent();
            Navigasi.PasangSidebar(this, btnDashboard, btnAlat, btnSewa, btnPengembaian,
                btnLaporan, btnUser, btnLogout, lblPengguna);
            cmbFilterJenis.SelectedItem = c_Alat.NamaSemuaJenis;
            Shown += (s, e) => dgvAlat.ClearSelection();
            TampilkanDaftar(AmbilAman(controller.AmbilSemuaAlat));
            Bersihkan();
        }

        private static List<AlatPertanian> AmbilAman(Func<List<AlatPertanian>> ambil)
        {
            try
            {
                return ambil();
            }
            catch (Exception ex)
            {
                Tampilan.Error(ex);
                return new List<AlatPertanian>();
            }
        }

        private void TampilkanDaftar(IEnumerable<AlatPertanian> daftar)
        {
            dgvAlat.Rows.Clear();
            foreach (AlatPertanian alat in daftar)
            {
                // Jenis dan Spesifikasi() dipanggil lewat AlatPertanian, isinya mengikuti subclass (polymorphism).
                int baris = dgvAlat.Rows.Add(alat.Kode, $"{alat.Merek} / {alat.Nama}", alat.Jenis,
                    alat.TahunKeluaran, alat.Spesifikasi(), Tampilan.Rupiah(alat.TarifPerHari), alat.Status);
                dgvAlat.Rows[baris].Tag = alat;
            }
            dgvAlat.ClearSelection();
        }

        private void MuatUlang()
        {
            TampilkanDaftar(AmbilAman(controller.AmbilSemuaAlat));
            Bersihkan();
        }

        private void Bersihkan()
        {
            alatTerpilih = null;
            foreach (TextBox kotak in new[] { txtKode, txtNama, txtMerek, txtTahun, txtTarif, txtStatus, txtDeskripsi,
                         txtTenaga, txtKapasitasTangki, txtDebit, txtBerat, txtDiameterPipa })
                kotak.Clear();

            txtKode.ReadOnly = false;
            cmbJenis.Enabled = true;
            cmbJenis.SelectedItem = c_Alat.NamaTraktor;
            cmbKondisi.SelectedItem = KondisiAlat.Baik.KeTeks();
            cmbJenisTraktor.SelectedIndex = -1;
            cmbBahanBakar.SelectedIndex = -1;
            txtStatus.Text = StatusAlat.Tersedia.ToString();

            btnTambah.Enabled = true;
            btnUbah.Enabled = false;
            btnHapus.Enabled = false;
            dgvAlat.ClearSelection();
        }

        private void cmbJenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool traktor = cmbJenis.SelectedItem as string == c_Alat.NamaTraktor;
            pnlTraktor.Visible = traktor;
            pnlPompaAir.Visible = !traktor;
        }

        private void dgvAlat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvAlat.Rows[e.RowIndex].Tag is not AlatPertanian alat)
                return;

            alatTerpilih = alat;
            txtKode.Text = alat.Kode;
            txtNama.Text = alat.Nama;
            txtMerek.Text = alat.Merek;
            txtTahun.Text = alat.TahunKeluaran.ToString();
            txtTarif.Text = Tampilan.Angka(alat.TarifPerHari);
            txtStatus.Text = alat.Status.ToString();
            txtDeskripsi.Text = alat.Deskripsi;
            cmbKondisi.SelectedItem = alat.Kondisi.KeTeks();
            cmbJenis.SelectedItem = alat.Jenis;

            if (alat is Traktor traktor)
            {
                txtTenaga.Text = traktor.TenagaHp.ToString();
                txtKapasitasTangki.Text = Tampilan.Angka(traktor.KapasitasTangki);
                cmbJenisTraktor.SelectedItem = traktor.JenisTraktor.KeTeks();
            }
            else if (alat is PompaAir pompa)
            {
                txtDebit.Text = Tampilan.Angka(pompa.DebitLiterPerMenit);
                txtBerat.Text = Tampilan.Angka(pompa.BeratKg);
                cmbBahanBakar.SelectedItem = pompa.BahanBakar;
                txtDiameterPipa.Text = Tampilan.Angka(pompa.DiameterPipaInci);
            }

            // Kode dan jenis menentukan identitas alat, jadi dikunci saat mengubah.
            txtKode.ReadOnly = true;
            cmbJenis.Enabled = false;
            btnTambah.Enabled = false;
            btnUbah.Enabled = true;
            btnHapus.Enabled = true;
        }

        private InputAlat AmbilIsian()
        {
            return new InputAlat
            {
                Kode = txtKode.Text,
                Nama = txtNama.Text,
                Jenis = cmbJenis.SelectedItem as string ?? "",
                Merek = txtMerek.Text,
                Deskripsi = txtDeskripsi.Text,
                TahunKeluaran = txtTahun.Text,
                Kondisi = cmbKondisi.SelectedItem as string ?? "",
                TarifPerHari = txtTarif.Text,
                TenagaHp = txtTenaga.Text,
                KapasitasTangki = txtKapasitasTangki.Text,
                JenisTraktor = cmbJenisTraktor.SelectedItem as string ?? "",
                DebitLiterPerMenit = txtDebit.Text,
                BeratKg = txtBerat.Text,
                BahanBakar = cmbBahanBakar.SelectedItem as string ?? "",
                DiameterPipaInci = txtDiameterPipa.Text
            };
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            Hasil hasil = controller.TambahAlat(AmbilIsian());
            Tampilan.TampilkanHasil(hasil);
            if (hasil.Berhasil)
                MuatUlang();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (alatTerpilih == null)
                return;

            Hasil hasil = controller.UbahAlat(AmbilIsian());
            Tampilan.TampilkanHasil(hasil);
            if (hasil.Berhasil)
                MuatUlang();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (alatTerpilih == null)
                return;
            if (!Tampilan.Konfirmasi($"Hapus alat {alatTerpilih.Kode} - {alatTerpilih.Nama}?"))
                return;

            Hasil hasil = controller.HapusAlat(alatTerpilih.Kode);
            Tampilan.TampilkanHasil(hasil);
            if (hasil.Berhasil)
                MuatUlang();
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            Bersihkan();
        }

        // Kata kunci yang persis sama dengan kode alat memakai Cari(kode);
        // selain itu memakai Cari(nama, jenis). Keduanya overloading di c_Alat.
        private void btnCari_Click(object sender, EventArgs e)
        {
            string kataKunci = txtCari.Text.Trim();
            string jenis = cmbFilterJenis.SelectedItem as string ?? c_Alat.NamaSemuaJenis;

            List<AlatPertanian> hasil = AmbilAman(() =>
            {
                AlatPertanian? satu = kataKunci.Length > 0 ? controller.Cari(kataKunci) : null;
                if (satu != null && (jenis == c_Alat.NamaSemuaJenis || satu.Jenis == jenis))
                    return new List<AlatPertanian> { satu };
                return controller.Cari(kataKunci, jenis);
            });

            TampilkanDaftar(hasil);
            Bersihkan();
            if (hasil.Count == 0)
                Tampilan.Info("Alat tidak ditemukan.");
        }
    }
}
