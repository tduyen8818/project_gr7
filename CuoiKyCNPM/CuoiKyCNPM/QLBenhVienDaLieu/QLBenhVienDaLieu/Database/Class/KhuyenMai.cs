using System;

namespace QLBenhVienDaLieu.Database.Class
{
    public class KhuyenMai
    {
        private string maKhuyenMai;
        private string tenChuongTrinhKM;
        private string giaKhuyenMai;
        private string noiDungKM;
        private DateTime thoiGianBatDau;
        private DateTime thoiGianKetThuc;

        public KhuyenMai()
        {
            this.maKhuyenMai = "";
            this.tenChuongTrinhKM = "";
            this.giaKhuyenMai = "";
            this.noiDungKM = "";
            this.thoiGianBatDau = new DateTime();
            this.thoiGianKetThuc = new DateTime();
        }

        public KhuyenMai(string maKhuyenMai, string tenChuongTrinhKM, string giaKhuyenMai, string noiDungKM, DateTime thoiGianBatDau, DateTime thoiGianKetThuc)
        {
            this.maKhuyenMai = maKhuyenMai;
            this.tenChuongTrinhKM = tenChuongTrinhKM;
            this.giaKhuyenMai = giaKhuyenMai;
            this.noiDungKM = noiDungKM;
            this.thoiGianBatDau = thoiGianBatDau;
            this.thoiGianKetThuc = thoiGianKetThuc;
        }

        public string MaKhuyenMai
        {
            get { return this.maKhuyenMai; }
            set { this.maKhuyenMai = value; }
        }

        public string TenChuongTrinhKM
        {
            get { return this.tenChuongTrinhKM; }
            set { this.tenChuongTrinhKM = value; }
        }

        public string GiaKhuyenMai
        {
            get { return this.giaKhuyenMai; }
            set { this.giaKhuyenMai = value; }
        }

        public string NoiDungKM
        {
            get { return this.noiDungKM; }
            set { this.noiDungKM = value; }
        }

        public DateTime ThoiGianBatDau
        {
            get { return this.thoiGianBatDau; }
            set { this.thoiGianBatDau = value; }
        }

        public DateTime ThoiGianKetThuc
        {
            get { return this.thoiGianKetThuc; }
            set { this.thoiGianKetThuc = value; }
        }

        public override string ToString()
        {
            return "Khuyến mãi { mã khuyến mãi: " + maKhuyenMai +
                    ", tên chương trình KM: " + tenChuongTrinhKM +
                    ", giá khuyến mãi: " + giaKhuyenMai +
                    ", nội dung KM: " + noiDungKM +
                    ", thời gian bắt đầu: " + thoiGianBatDau +
                    ", thời gian kết thúc: " + thoiGianKetThuc + " }";
        }
    }
}
