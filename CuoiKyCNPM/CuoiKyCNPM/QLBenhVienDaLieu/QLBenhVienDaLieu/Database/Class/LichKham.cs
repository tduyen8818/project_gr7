using System;

namespace QLBenhVienDaLieu.Database.Class
{
    public class LichKham
    {
        private string maLichKham;
        private string maHoSoBenhNhan;
        private string maDichVu;
        private string maChuyenKhoa;
        private DateTime ngayDangKy;
        private string ca;
        private DateTime khungGioKham;

        public LichKham()
        {
            this.maLichKham = "";
            this.maHoSoBenhNhan = "";
            this.maDichVu = "";
            this.maChuyenKhoa = "";
            this.ngayDangKy = new DateTime();
            this.ca = "";
            this.khungGioKham = new DateTime();
        }

        public LichKham(string maLichKham, string maHoSoBenhNhan, string maDichVu,
                        string maChuyenKhoa, DateTime ngayDangKy, string ca, DateTime khungGioKham)
        {
            this.maLichKham = maLichKham;
            this.maHoSoBenhNhan = maHoSoBenhNhan;
            this.maDichVu = maDichVu;
            this.maChuyenKhoa = maChuyenKhoa;
            this.ngayDangKy = ngayDangKy;
            this.ca = ca;
            this.khungGioKham = khungGioKham;
        }

        public string MaLichKham
        {
            get { return this.maLichKham; }
            set { this.maLichKham = value; }
        }

        public string MaHoSoBenhNhan
        {
            get { return this.maHoSoBenhNhan; }
            set { this.maHoSoBenhNhan = value; }
        }

        public string MaDichVu
        {
            get { return this.maDichVu; }
            set { this.maDichVu = value; }
        }

        public string MaChuyenKhoa
        {
            get { return this.maChuyenKhoa; }
            set { this.maChuyenKhoa = value; }
        }

        public DateTime NgayDangKy
        {
            get { return this.ngayDangKy; }
            set { this.ngayDangKy = value; }
        }

        public string Ca
        {
            get { return this.ca; }
            set { this.ca = value; }
        }

        public DateTime KhungGioKham
        {
            get { return this.khungGioKham; }
            set { this.khungGioKham = value; }
        }

        public override string ToString()
        {
            return "Lịch khám { mã lịch khám: " + maLichKham +
                    ", mã hồ sơ bệnh nhân: " + maHoSoBenhNhan +
                    ", mã dịch vụ: " + maDichVu +
                    ", mã chuyên khoa: " + maChuyenKhoa +
                    ", ngày đăng ký: " + ngayDangKy +
                    ", ca: " + ca +
                    ", khung giờ khám: " + khungGioKham + " }";
        }
    }
}
