namespace QLBenhVienDaLieu.Database.Class
{
    public class TaiKhoanBenhNhan
    {
        private string maTaiKhoan;
        private string soDienThoai;
        private string matKhau;

        public TaiKhoanBenhNhan()
        {
            this.maTaiKhoan = "";
            this.soDienThoai = "";
            this.matKhau = "";
        }

        public TaiKhoanBenhNhan(string maTaiKhoan, string soDienThoai, string matKhau)
        {
            this.maTaiKhoan = maTaiKhoan;
            this.soDienThoai = soDienThoai;
            this.matKhau = matKhau;
        }

        public string MaTaiKhoan
        {
            get { return this.maTaiKhoan; }
            set { this.maTaiKhoan = value; }
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
            return "Tài khoản bệnh nhân { mã tài khoản: " + maTaiKhoan +
                    ", số điện thoại: " + soDienThoai +
                    ", mật khẩu: " + matKhau + " }";
        }
    }
}
