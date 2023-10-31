using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBenhVienDaLieu.Class
{
    public class LichLamViec
    {
        private string maLichLamViec;
        private string hoVaTen;
        private string maThanhVien;
        private string chuyenKhoa;
        private DateTime ngayLamViec;
        private string ca;

        public LichLamViec()
        {
            this.maLichLamViec = "";
            this.hoVaTen = "";
            this.maThanhVien = "";
            this.chuyenKhoa = "";
            this.ngayLamViec = new DateTime();
            this.ca = "";
        }

        public LichLamViec(string maLichLamViec, string hoVaTen, string maThanhVien, string chuyenKhoa, DateTime ngayLamViec, string ca)
        {
            this.maLichLamViec = maLichLamViec;
            this.hoVaTen = hoVaTen;
            this.maThanhVien = maThanhVien;
            this.chuyenKhoa = chuyenKhoa;
            this.ngayLamViec = ngayLamViec;
            this.ca = ca;
        }

        public string MaLichLamViec
        {
            get {return this.maLichLamViec;}
            set {this.maLichLamViec = value;}
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

        public string ChuyenKhoa
        {
            get {return this.chuyenKhoa;}
            set {this.chuyenKhoa = value;}
        }

        public DateTime NgayLamViec
        {
            get {return this.ngayLamViec;}
            set {this.ngayLamViec = value;}
        }

        public string Ca
        {
            get {return this.ca;}
            set {this.ca = value;}
        }
        
        public override string ToString()
        {
            return "Lịch làm việc { mã lịch làm việc: " + maLichLamViec +
                    ", họ và tên: " + hoVaTen +
                    ", mã thành viên: " + maThanhVien +
                    ", chuyên khoa: " + chuyenKhoa +
                    ", ngày làm việc: " + ngayLamViec +
                    ", ca: " + ca + " }";
        }
    }
}
