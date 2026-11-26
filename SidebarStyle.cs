using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

public static class SidebarStyle
{
    static readonly Color Normal = Color.FromArgb(190, 210, 190);
    static readonly Color Hover = Color.FromArgb(235, 245, 235);
    static readonly Color BackNormal = Color.FromArgb(47, 93, 58);
    static readonly Color BackActive = Color.FromArgb(62, 122, 60);

    public static void Apply(Control Sidebar, Button aktif)
    {
        foreach (Button b in Sidebar.Controls.OfType<Button>())
        {
            if (b.Name == "btnLogout") continue;

            bool isAktif = (b == aktif);
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.BackColor = isAktif ? BackActive : BackNormal;
            b.ForeColor = isAktif ? Color.White : Normal;
            b.Font = new Font("Segoe UI", 10.5f, isAktif ? FontStyle.Bold : FontStyle.Regular);

            if (isAktif) continue;
            b.MouseEnter += (s, e) => b.ForeColor = Hover;
            b.MouseLeave += (s, e) => b.ForeColor = Normal;
        }
    }
}
