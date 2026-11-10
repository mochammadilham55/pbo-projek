using System;
using System.Windows.Forms;
using projek_pbo.view;

namespace projek_pbo
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            try
            {
                databaseHelper.InisialisasiDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tidak dapat terhubung ke database.\n\n" + ex.Message, "Agri-Rent",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.Run(new FormLogin());
        }
    }
}