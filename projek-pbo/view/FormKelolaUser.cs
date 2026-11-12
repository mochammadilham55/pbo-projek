using projek_pbo.controller;
using projek_pbo.model;

namespace projek_pbo.view
{
    public partial class FormKelolaUser : Form
    {
        private readonly c_Pengguna controller = new c_Pengguna();
        private Pengguna? penggunaTerpilih;

        public FormKelolaUser()
        {
            InitializeComponent();
            Navigasi.PasangSidebar(this, btnDashboard, btnAlat, btnSewa, btnPengembaian,
                btnLaporan, btnUser, btnLogout, lblPengguna);
            Shown += (s, e) => dgvPengguna.ClearSelection();
            MuatData();
        }

        private void MuatData()
        {
            try
            {
                dgvPengguna.Rows.Clear();
                foreach (Pengguna pengguna in controller.AmbilSemuaPengguna())
                {
                    int baris = dgvPengguna.Rows.Add(pengguna.NamaLengkap, pengguna.Username, pengguna.Peran);
                    dgvPengguna.Rows[baris].Tag = pengguna;
                }
            }
            catch (Exception ex)
            {
                Tampilan.Error(ex);
            }
            Bersihkan();
        }

        private void Bersihkan()
        {
            penggunaTerpilih = null;
            txtNama.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtPassword.PlaceholderText = "";
            cmbPeran.SelectedItem = "Petugas";
            dgvPengguna.ClearSelection();
            btnSimpan.Enabled = true;
            btnUbah.Enabled = false;
            btnHapus.Enabled = false;
        }

        private void dgvPengguna_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvPengguna.Rows[e.RowIndex].Tag is not Pengguna pengguna)
                return;

            penggunaTerpilih = pengguna;
            txtNama.Text = pengguna.NamaLengkap;
            txtUsername.Text = pengguna.Username;
            txtPassword.Clear();
            txtPassword.PlaceholderText = "Kosongkan jika tidak diubah";
            cmbPeran.SelectedItem = pengguna.Peran;
            btnSimpan.Enabled = false;
            btnUbah.Enabled = true;
            btnHapus.Enabled = true;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            Hasil hasil = controller.TambahPengguna(txtNama.Text, txtUsername.Text, txtPassword.Text,
                cmbPeran.SelectedItem as string ?? "");
            Tampilan.TampilkanHasil(hasil);
            if (hasil.Berhasil)
                MuatData();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (penggunaTerpilih == null)
                return;

            Hasil hasil = controller.UbahPengguna(penggunaTerpilih.Id, txtNama.Text, txtUsername.Text,
                txtPassword.Text, cmbPeran.SelectedItem as string ?? "");
            Tampilan.TampilkanHasil(hasil);
            if (hasil.Berhasil)
                MuatData();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (penggunaTerpilih == null)
                return;
            if (!Tampilan.Konfirmasi($"Hapus pengguna \"{penggunaTerpilih.Username}\"?"))
                return;

            Hasil hasil = controller.HapusPengguna(penggunaTerpilih.Id);
            Tampilan.TampilkanHasil(hasil);
            if (hasil.Berhasil)
                MuatData();
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            Bersihkan();
        }
    }
}
