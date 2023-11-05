using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QLBenhVienDaLieu.Class
{
    public class TaiKhoanKeToan : TaiKhoanNhanVien
    {
        private string chuyenKhoa;
        private string viTri;

        public TaiKhoanKeToan() : base()
        {
            this.chuyenKhoa = "";
            this.viTri = "";
        }

        public TaiKhoanKeToan(string hoVaTen, string maThanhVien, string matKhau, DateTime ngaySinh, string gioiTinh, string CCCD, string soDienThoai, string email, string diaChi, string chuyenKhoa, string viTri, string loaiTaiKhoan)
            : base(hoVaTen, maThanhVien, matKhau, ngaySinh, gioiTinh, CCCD, soDienThoai, email, diaChi, loaiTaiKhoan)
        {
            this.chuyenKhoa = chuyenKhoa;
            this.viTri = viTri;
        }

        public string ChuyenKhoa
        {
            get {return this.chuyenKhoa;}
            set {this.chuyenKhoa = value;}
        }

        public string ViTri
        {
            get {return this.viTri;}
            set {this.viTri = value;}
        }

        public override string ToString()
        {
            return "Tài khoản kế toán { họ và tên: " + hoVaTen +
                    ", mã thành viên: " + maThanhVien +
                    ", ngày sinh: " + ngaySinh +
                    ", giới tính: " + gioiTinh +
                    ", CCCD: " + CCCD +
                    ", số điện thoại: " + soDienThoai +
                    ", email: " + email +
                    ", địa chỉ: " + diaChi +
                    ", mật khẩu: " + matKhau +
                    ", chuyên khoa: " + chuyenKhoa +
                    ", vị trí: " + viTri + " }";
        }
    }
}
