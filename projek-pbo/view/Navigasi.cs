using projek_pbo.controller;
using projek_pbo.model;

namespace projek_pbo.view
{
    // Perpindahan antarhalaman lewat sidebar. Setiap halaman adalah Form tersendiri;
    // halaman lama ditutup saat halaman baru dibuka, dan FormLogin disembunyikan selama login.
    internal static class Navigasi
    {
        private static Form? formLogin;
        private static bool sedangPindah;

        public static void SetelahLogin(Form login)
        {
            formLogin = login;
            Tampilkan(new formDashboard());
            login.Hide();
        }

        public static void PasangSidebar(Form halaman,
            Button btnDashboard, Button btnAlat, Button btnSewa, Button btnPengembalian,
            Button btnLaporan, Button btnUser, Button btnLogout, Label? lblPengguna = null)
        {
            Pengguna? pengguna = c_Auth.PenggunaAktif;
            if (pengguna == null)
                return;

            // Menu yang tidak berhak diakses disembunyikan berdasarkan MenuTersedia() (polymorphism).
            IReadOnlyList<MenuAplikasi> menu = pengguna.MenuTersedia();

            Pasang<formDashboard>(btnDashboard, MenuAplikasi.Dashboard);
            Pasang<formKelolaAlat>(btnAlat, MenuAplikasi.KelolaAlat);
            Pasang<formKelolaSewa>(btnSewa, MenuAplikasi.KelolaSewa);
            Pasang<formKelolaPengembalian>(btnPengembalian, MenuAplikasi.KelolaPengembalian);
            Pasang<formLaporan>(btnLaporan, MenuAplikasi.Laporan);
            Pasang<FormKelolaUser>(btnUser, MenuAplikasi.KelolaUser);

            btnLogout.Click += (s, e) => Logout(halaman);

            if (lblPengguna != null)
                lblPengguna.Text = $"Masuk sebagai: {pengguna.NamaLengkap} ({pengguna.Peran})";

            void Pasang<T>(Button tombol, MenuAplikasi menuTombol) where T : Form, new()
            {
                tombol.Visible = menu.Contains(menuTombol);
                tombol.Click += (s, e) =>
                {
                    if (halaman is T)
                        return;
                    Tampilkan(new T());
                    Tutup(halaman);
                };
            }
        }

        private static void Tampilkan(Form tujuan)
        {
            tujuan.StartPosition = FormStartPosition.CenterScreen;
            tujuan.FormClosed += (s, e) =>
            {
                // Ditutup lewat tombol X (bukan pindah halaman) berarti keluar dari aplikasi.
                if (!sedangPindah)
                    Application.Exit();
            };
            tujuan.Show();
        }

        private static void Tutup(Form halaman)
        {
            sedangPindah = true;
            halaman.Close();
            sedangPindah = false;
        }

        private static void Logout(Form halaman)
        {
            new c_Auth().Logout();
            Tutup(halaman);
            formLogin?.Show();
        }
    }
}
