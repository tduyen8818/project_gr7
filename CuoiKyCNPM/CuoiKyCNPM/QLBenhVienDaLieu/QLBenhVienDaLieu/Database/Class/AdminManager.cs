namespace QLBenhVienDaLieu.Database.Class
{
    public class AdminManager
    {
        private string maAdmin;
        private string matKhau;

        public AdminManager()
        {
            this.maAdmin = "";
            this.matKhau = "";
        }

        public AdminManager(string maAdmin, string matKhau)
        {
            this.maAdmin = maAdmin;
            this.matKhau = matKhau;
        }

        public string MaAdmin
        {
            get { return this.maAdmin; }
            set { this.maAdmin = value; }
        }
        public string MatKhau
        {
            get { return this.matKhau; }
            set { this.matKhau = value; }
        }
        public override string ToString()
        {
            return "Admin Manager { mã admin: " + maAdmin +
                    ", mật khẩu: " + matKhau + " }";
        }
    }
}
