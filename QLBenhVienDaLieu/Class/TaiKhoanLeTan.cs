using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBenhVienDaLieu.Class
{
    public class TaiKhoanLeTan : TaiKhoanNhanVien
    {
        private string viTri;

        public TaiKhoanLeTan() : base()
        {
            this.viTri = "";
        }

        public TaiKhoanLeTan(string hoVaTen, string maThanhVien, DateTime ngaySinh, string gioiTinh, string CCCD, string soDienThoai, string email, string diaChi, string matKhau, string viTri, string loaiTaiKhoan)
            : base(hoVaTen, maThanhVien, matKhau, ngaySinh, gioiTinh, CCCD, soDienThoai, email, diaChi, loaiTaiKhoan)
        {
            this.viTri = viTri;
        }

        public string ViTri
        {
            get {return this.viTri;}
            set {this.viTri = value;}
        }

        public override string ToString()
        {
            return "Tài khoản lễ tân { họ và tên: " + hoVaTen +
                    ", mã thành viên: " + maThanhVien +
                    ", ngày sinh: " + ngaySinh +
                    ", giới tính: " + gioiTinh +
                    ", CCCD: " + CCCD +
                    ", số điện thoại: " + soDienThoai +
                    ", email: " + email +
                    ", địa chỉ: " + diaChi +
                    ", mật khẩu: " + matKhau +
                    ", vị trí: " + viTri + " }";
        }

    }
}
