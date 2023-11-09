namespace QLBenhVienDaLieu.Database.Class
{
    public class ToaThuoc
    {
        private int soThuTu;
        private string maToaThuoc;
        private string maThuoc;
        private string maBenhAn;
        private string tenThuoc;
        private int soLuong;
        private string dang;
        private string ghiChu;

        public ToaThuoc()
        {
            this.soThuTu = 0;
            this.maToaThuoc = "";
            this.maThuoc = "";
            this.maThuoc = "";
            this.maBenhAn = "";
            this.tenThuoc = "";
            this.soLuong = 0;
            this.dang = "";
            this.ghiChu = "";
        }

        public ToaThuoc(int soThuTu, string maToaThuoc, string maThuoc, string maBenhAn, string tenThuoc, int soLuong, string dang, string ghiChu)
        {
            this.soThuTu = soThuTu;
            this.maToaThuoc = maToaThuoc;
            this.maThuoc = maThuoc;
            this.maBenhAn = maBenhAn;
            this.tenThuoc = tenThuoc;
            this.soLuong = soLuong;
            this.dang = dang;
            this.ghiChu = ghiChu;
        }

        public int SoThuTu
        {
            get { return this.soThuTu; }
            set { this.soThuTu = value; }
        }

        public string MaToaThuoc
        {
            get { return this.maThuoc; }
            set { this.maToaThuoc = value; }
        }

        public string MaThuoc
        {
            get { return this.maThuoc; }
            set { this.maThuoc = value; }
        }

        public string MaBenhAn
        {
            get { return this.maBenhAn; }
            set { this.maBenhAn = value; }
        }

        public string TenThuoc
        {
            get { return this.tenThuoc; }
            set { this.tenThuoc = value; }
        }

        public int SoLuong
        {
            get { return this.soLuong; }
            set { this.soLuong = value; }
        }

        public string Dang
        {
            get { return this.dang; }
            set { this.dang = value; }
        }

        public string GhiChu
        {
            get { return this.ghiChu; }
            set { this.ghiChu = value; }
        }

        public override string ToString()
        {
            return "Toa thuốc { số thứ tự: " + soThuTu +
                    ", mã toa thuốc: " + maToaThuoc +
                    ", mã thuốc: " + maThuoc +
                    ", mã bệnh án: " + maBenhAn +
                    ", tên thuốc: " + tenThuoc +
                    ", số lượng: " + soLuong +
                    ", dạng: " + dang +
                    ", ghi chú: " + ghiChu + " }";
        }
    }
}
