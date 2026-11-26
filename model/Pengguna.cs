namespace projek_pbo.model
{
    public abstract class Pengguna
    {
        private string password = "";

        public int Id { get; private set; }
        public string NamaLengkap { get; private set; } = "";
        public string Username { get; private set; } = "";

        public abstract string Peran { get; }

        protected Pengguna(int id, string namaLengkap, string username, string password)
        {
            Id = id;
            UbahData(namaLengkap, username);
            UbahPassword(password);
        }

        // Membuat objek turunan yang tepat (Admin atau Petugas) dari nama peran.
        public static Pengguna Buat(string peran, int id, string namaLengkap, string username, string password)
        {
            return peran switch
            {
                "Admin" => new Admin(id, namaLengkap, username, password),
                "Petugas" => new Petugas(id, namaLengkap, username, password),
                _ => throw new ArgumentException("Peran wajib dipilih (Admin atau Petugas).")
            };
        }

        public void UbahData(string namaLengkap, string username)
        {
            if (string.IsNullOrWhiteSpace(namaLengkap))
                throw new ArgumentException("Nama lengkap wajib diisi.");
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Username wajib diisi.");
            if (username.Trim().Contains(' '))
                throw new ArgumentException("Username tidak boleh mengandung spasi.");

            NamaLengkap = namaLengkap.Trim();
            Username = username.Trim();
        }

        public void UbahPassword(string passwordBaru)
        {
            if (string.IsNullOrWhiteSpace(passwordBaru) || passwordBaru.Length < 4)
                throw new ArgumentException("Password minimal 4 karakter.");

            password = passwordBaru;
        }

        public bool CekPassword(string input)
        {
            return password == input;
        }

        // Peran ditentukan oleh class turunan, jadi mengganti peran berarti membuat objek baru.
        // Password lama ikut disalin tanpa pernah keluar dari class ini.
        public Pengguna GantiPeran(string peranBaru)
        {
            return Buat(peranBaru, Id, NamaLengkap, Username, password);
        }

        // Hanya untuk repository saat menyimpan ke database.
        internal string AmbilPasswordUntukDisimpan()
        {
            return password;
        }

        public abstract IReadOnlyList<MenuAplikasi> MenuTersedia();
    }
}
