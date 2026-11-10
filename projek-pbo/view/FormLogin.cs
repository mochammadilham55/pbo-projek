using projek_pbo.controller;

namespace projek_pbo.view
{
    public partial class FormLogin : Form
    {
        private readonly c_Auth auth = new c_Auth();

        public FormLogin()
        {
            InitializeComponent();
            VisibleChanged += (s, e) =>
            {
                // Saat kembali dari logout, kolom password dikosongkan.
                if (Visible)
                {
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            };
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Hasil hasil = auth.Login(txtUsername.Text, txtPassword.Text);
            if (!hasil.Berhasil)
            {
                Tampilan.Peringatan(hasil.Pesan);
                txtPassword.Clear();
                txtPassword.Focus();
                return;
            }

            Navigasi.SetelahLogin(this);
        }
    }
}
