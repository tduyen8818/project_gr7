namespace QLBenhVienDaLieu.Database.Class
{
    public class DangKyUser
    {
        private string soDienThoai;
        private string matKhau;

        public DangKyUser()
        {
            this.soDienThoai = "";
            this.matKhau = "";
        }

        public DangKyUser(string soDienThoai, string matKhau)
        {
            this.soDienThoai = soDienThoai;
            this.matKhau = matKhau;
        }

        public string SoDienThoai
        {
            get { return this.soDienThoai; }
            set { this.soDienThoai = value; }
        }

        public string MatKhau
        {
            get { return this.matKhau; }
            set { this.matKhau = value; }
        }

        public override string ToString()
        {
            return "Đăng ký user { số điện thoại: " + soDienThoai +
                    ", mật khẩu: " + matKhau + " }";
        }

    }
}
