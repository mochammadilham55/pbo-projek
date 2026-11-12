using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projek_pbo.view
{
    public partial class formKelolaSewa : Form
    {
        public formKelolaSewa()
        {
            InitializeComponent();
            Navigasi.PasangSidebar(this, btnDashboard, btnAlat, btnSewa, btnPengembaian,
                btnLaporan, btnUser, btnLogout, lblPengguna);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblPengguna_Click(object sender, EventArgs e)
        {

        }
    }
}
