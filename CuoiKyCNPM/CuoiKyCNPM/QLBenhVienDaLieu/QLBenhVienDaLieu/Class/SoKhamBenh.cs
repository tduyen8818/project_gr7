using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBenhVienDaLieu.Class
{
    public class SoKhamBenh
    {
        private string maHoSoBenhNhan;
        private string maLichKham;
        private string hoVaTen;
        private string tuoi;
        private string soTheBHYT;
        private string diaChi;
        private string ngheNghiep;
        private string danToc;
        private string trieuChung;
        private string chanDoan;
        private string phuongPhapDieuTri;
        private string bsKhamBenh;
        private string ghiChu;

        public SoKhamBenh()
        {
            this.maHoSoBenhNhan = "";
            this.maLichKham = "";
            this.hoVaTen = "";
            this.tuoi = "";
            this.soTheBHYT = "";
            this.diaChi = "";
            this.ngheNghiep = "";
            this.danToc = "";
            this.trieuChung = "";
            this.chanDoan = "";
            this.phuongPhapDieuTri = "";
            this.bsKhamBenh = "";
            this.ghiChu = "";
        }

        public SoKhamBenh(string maHoSoBenhNhan, string maLichKham, string hoVaTen, string tuoi, string soTheBHYT, string diaChi, string ngheNghiep, string danToc, string trieuChung, string chanDoan, string phuongPhapDieuTri, string bsKhamBenh, string ghiChu)
        {
            this.maHoSoBenhNhan = maHoSoBenhNhan;
            this.maLichKham = maLichKham;
            this.hoVaTen = hoVaTen;
            this.tuoi = tuoi;
            this.soTheBHYT = soTheBHYT;
            this.diaChi = diaChi;
            this.ngheNghiep = ngheNghiep;
            this.danToc = danToc;
            this.trieuChung = trieuChung;
            this.chanDoan = chanDoan;
            this.phuongPhapDieuTri = phuongPhapDieuTri;
            this.bsKhamBenh = bsKhamBenh;
            this.ghiChu = ghiChu;
        }

        public string MaHoSoBenhNhan
        {
            get {return this.maHoSoBenhNhan;}
            set {this.maHoSoBenhNhan = value;}
        }

        public string MaLichKham
        {
            get {return this.maLichKham;}
            set {this.maLichKham = value;}
        }

        public string HoVaTen
        {
            get {return this.hoVaTen;}
            set {this.hoVaTen = value;}
        }

        public string Tuoi
        {
            get {return this.tuoi;}
            set {this.tuoi = value;}
        }

        public string SoTheBHYT
        {
            get {return this.soTheBHYT;}
            set {this.soTheBHYT = value;}
        }

        public string DiaChi
        {
            get {return this.diaChi;}
            set {this.diaChi = value;}
        }

        public string NgheNghiep
        {
            get {return this.ngheNghiep;}
            set {this.ngheNghiep = value;}
        }

        public string DanToc
        {
            get {return this.danToc;}
            set {this.danToc = value;}
        }

        public string TrieuChung
        {
            get {return this.trieuChung;}
            set {this.trieuChung = value;}
        }

        public string ChanDoan
        {
            get {return this.chanDoan;}
            set {this.chanDoan = value;}
        }

        public string PhuongPhapDieuTri
        {
            get {return this.phuongPhapDieuTri;}
            set {this.phuongPhapDieuTri = value;}
        }

        public string BsKhamBenh
        {
            get {return this.bsKhamBenh;}
            set {this.bsKhamBenh = value;}
        }

        public string GhiChu
        {
            get {return this.ghiChu;}
            set {this.ghiChu = value;}
        }
        
        public override string ToString()
        {
            return  "Sổ khám bệnh { mã hồ sơ bệnh nhân: " + maHoSoBenhNhan +
                    ", mã lịch khám: " + maLichKham +
                    ", họ và tên: " + hoVaTen +
                    ", tuổi: " + tuoi +
                    ", số thẻ BHYT: " + soTheBHYT +
                    ", địa chỉ: " + diaChi +
                    ", nghề nghiệp: " + ngheNghiep +
                    ", dân tộc: " + danToc +
                    ", triệu chứng: " + trieuChung +
                    ", chẩn đoán: " + chanDoan +
                    ", phương pháp điều trị: " + phuongPhapDieuTri +
                    ", bác sĩ khám bệnh: " + bsKhamBenh +
                    ", ghi chú: " + ghiChu + " }";
        }
    }
}
