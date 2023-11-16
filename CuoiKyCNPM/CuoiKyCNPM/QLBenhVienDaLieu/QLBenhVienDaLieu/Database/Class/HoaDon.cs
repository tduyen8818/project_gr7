namespace QLBenhVienDaLieu.Database.Class
{
    public class HoaDon
    {
        private string maHoaDon;
        private string maLichKham;
        private int tongTien;
        private string hinhThucThanhToan;

        public HoaDon()
        {
            this.maHoaDon = "";
            this.maLichKham = "";
            this.tongTien = 0;
            this.hinhThucThanhToan = "";
        }

        public HoaDon(string maHoaDon, string maHoSoBenhNhan, string maLichKham, int tongTien, string hinhThucThanhToan)
        {
            this.maHoaDon = maHoaDon;
            this.maLichKham = maLichKham;
            this.tongTien = tongTien;
            this.hinhThucThanhToan = hinhThucThanhToan;
        }

        public string MaHoaDon
        {
            get { return this.maHoaDon; }
            set { this.maHoaDon = value; }
        }

        public string MaLichKham
        {
            get { return this.maLichKham; }
            set { this.maLichKham = value; }
        }

        public int TongTien
        {
            get { return this.tongTien; }
            set { this.tongTien = value; }
        }

        public string HinhThucThanhToan
        {
            get { return this.hinhThucThanhToan; }
            set { this.hinhThucThanhToan = value; }
        }

        public override string ToString()
        {
            return "Hóa đơn { mã hóa đơn: " + maHoaDon +
                    ", mã lịch khám: " + maLichKham +
                    ", tổng tiền: " + tongTien +
                    ", hình thức thanh toán: " + hinhThucThanhToan + " }";
        }
    }
}
