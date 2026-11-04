using System;
using System.Windows.Forms;
using projek_pbo.form;

namespace projek_pbo
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Application.Run(new formUtama("Administrator"));
        }
    }
}