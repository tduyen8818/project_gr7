using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBenhVienDaLieu.Database.Class
{
    public class TaiKhoanNhanVien
    {
        protected string hoVaTen;
        protected string maThanhVien;
        protected string matKhau;
        protected DateTime ngaySinh;
        protected string gioiTinh;
        protected string cCCD;
        protected string soDienThoai;
        protected string email;
        protected string diaChi;
        private string loaiTaiKhoan;

        public TaiKhoanNhanVien()
        {
            this.hoVaTen = "";
            this.maThanhVien = "";
            this.matKhau = "";
            this.ngaySinh = new DateTime();
            this.gioiTinh = "";
            this.cCCD = "";
            this.soDienThoai = "";
            this.email = "";
            this.diaChi = "";
            this.loaiTaiKhoan = "";
        }

        public TaiKhoanNhanVien(string hoVaTen, string maThanhVien, string matKhau, DateTime ngaySinh, string gioiTinh, string cCCD, string soDienThoai, string email, string diaChi, string loaiTaiKhoan)
        {
            this.hoVaTen = hoVaTen;
            this.maThanhVien = maThanhVien;
            this.matKhau = matKhau;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.cCCD = cCCD;
            this.soDienThoai = soDienThoai;
            this.email = email;
            this.diaChi = diaChi;
            this.loaiTaiKhoan = loaiTaiKhoan;
        }

        public string HoVaTen
        {
            get {return this.hoVaTen;}
            set {this.hoVaTen = value;}
        }

        public string MaThanhVien
        {
            get {return this.maThanhVien;}
            set {this.maThanhVien = value;}
        }

        public string MatKhau
        {
            get {return this.matKhau;}
            set {this.matKhau = value;}
        }

        public DateTime NgaySinh
        {
            get {return this.ngaySinh;}
            set {this.ngaySinh = value;}
        }

        public string GioiTinh
        {
            get {return this.gioiTinh;}
            set {this.gioiTinh = value;}
        }

        public string CCCD
        {
            get {return this.cCCD;}
            set {this.cCCD = value;}
        }

        public string SoDienThoai
        {
            get {return this.soDienThoai;}
            set {this.soDienThoai = value;}
        }

        public string Email
        {
            get {return this.email;}
            set {this.email = value;}
        }

        public string DiaChi
        {
            get {return this.diaChi;}
            set {this.diaChi = value;}
        }

        public string LoaiTaiKhoan
        {
            get {return this.loaiTaiKhoan;}
            set {this.loaiTaiKhoan = value;}
        }

        public override string ToString()
        {
            return "Tài khoản thành viên { họ và tên: " + hoVaTen +
                    ", mã thành viên: " + maThanhVien +
                    ", mật khẩu: " + matKhau +
                    ", ngày sinh: " + ngaySinh +
                    ", giới tính: " + gioiTinh +
                    ", CCCD: " + CCCD +
                    ", số điện thoại: " + soDienThoai +
                    ", email: " + email +
                    ", địa chỉ: " + diaChi +
                    ", loại tài khoản: " + loaiTaiKhoan + " }";
        }
    }
}
