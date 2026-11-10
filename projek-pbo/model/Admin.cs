namespace projek_pbo.model
{
    public class Admin : Pengguna
    {
        public Admin(int id, string namaLengkap, string username, string password)
            : base(id, namaLengkap, username, password)
        {
        }

        public override string Peran => "Admin";

        public override IReadOnlyList<MenuAplikasi> MenuTersedia()
        {
            return new[]
            {
                MenuAplikasi.Dashboard,
                MenuAplikasi.KelolaAlat,
                MenuAplikasi.KelolaSewa,
                MenuAplikasi.KelolaPengembalian,
                MenuAplikasi.Laporan,
                MenuAplikasi.KelolaUser
            };
        }
    }
}
