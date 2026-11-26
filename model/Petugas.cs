namespace projek_pbo.model
{
    public class Petugas : Pengguna
    {
        public Petugas(int id, string namaLengkap, string username, string password)
            : base(id, namaLengkap, username, password)
        {
        }

        public override string Peran => "Petugas";

        public override IReadOnlyList<MenuAplikasi> MenuTersedia()
        {
            return new[]
            {
                MenuAplikasi.Dashboard,
                MenuAplikasi.KelolaSewa,
                MenuAplikasi.KelolaPengembalian
            };
        }
    }
}
