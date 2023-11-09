using System;

namespace QLBenhVienDaLieu.Database.Class
{
    public class HoSoBenhNhan
    {
        private string hoVaTen;
        private string maHoSoBenhNhan;
        private DateTime ngaySinh;
        private string maTaiKhoan;
        private string gioiTinh;
        private string maBHYT;
        private string cCCD;
        private string ngheNghiep;
        private string soDienThoai;
        private string email;
        private string diaChi;

        public HoSoBenhNhan()
        {
            this.hoVaTen = "";
            this.maHoSoBenhNhan = "";
            this.ngaySinh = new DateTime();
            this.maTaiKhoan = "";
            this.gioiTinh = "";
            this.maBHYT = "";
            this.cCCD = "";
            this.ngheNghiep = "";
            this.soDienThoai = "";
            this.email = "";
            this.diaChi = "";
        }

        public HoSoBenhNhan(string hoVaTen, string maHoSoBenhNhan, DateTime ngaySinh, string maTaiKhoan, string gioiTinh, string maBHYT, string cCCD, string ngheNghiep, string soDienThoai, string email, string diaChi)
        {
            this.hoVaTen = hoVaTen;
            this.maHoSoBenhNhan = maHoSoBenhNhan;
            this.ngaySinh = ngaySinh;
            this.maTaiKhoan = maTaiKhoan;
            this.gioiTinh = gioiTinh;
            this.maBHYT = maBHYT;
            this.cCCD = cCCD;
            this.ngheNghiep = ngheNghiep;
            this.soDienThoai = soDienThoai;
            this.email = email;
            this.diaChi = diaChi;
        }

        public string HoVaTen
        {
            get { return this.hoVaTen; }
            set { this.hoVaTen = value; }
        }

        public string MaHoSoBenhNhan
        {
            get { return this.maHoSoBenhNhan; }
            set { this.maHoSoBenhNhan = value; }
        }

        public DateTime NgaySinh
        {
            get { return this.ngaySinh; }
            set { this.ngaySinh = value; }
        }

        public string MaTaiKhoan
        {
            get { return this.maTaiKhoan; }
            set { this.maTaiKhoan = value; }
        }

        public string GioiTinh
        {
            get { return this.gioiTinh; }
            set { this.gioiTinh = value; }
        }

        public string MaBHYT
        {
            get { return this.maBHYT; }
            set { this.maBHYT = value; }
        }

        public string CCCD
        {
            get { return this.cCCD; }
            set { this.cCCD = value; }
        }

        public string NgheNghiep
        {
            get { return this.ngheNghiep; }
            set { this.ngheNghiep = value; }
        }

        public string SoDienThoai
        {
            get { return this.soDienThoai; }
            set { this.soDienThoai = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public string DiaChi
        {
            get { return this.diaChi; }
            set { this.diaChi = value; }
        }

        public override string ToString()
        {
            return "Hồ sơ bệnh nhân { họ và tên: " + hoVaTen +
                    ", mã hồ sơ bệnh nhân: " + maHoSoBenhNhan +
                    ", ngày sinh: " + ngaySinh +
                    ", mã tài khoản: " + maTaiKhoan +
                    ", giới tính: " + gioiTinh +
                    ", mã BHYT: " + maBHYT +
                    ", CCCD: " + cCCD +
                    ", nghề nghiệp: " + ngheNghiep +
                    ", số điện thoại: " + soDienThoai +
                    ", email: " + email +
                    ", địa chỉ: " + diaChi + " }";
        }
    }
}
