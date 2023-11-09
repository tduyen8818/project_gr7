namespace QLBenhVienDaLieu.Database.Class
{
    public class ChuyenKhoa
    {
        private string maChuyenKhoa;
        private string tenChuyenKhoa;
        private string maKhuyenMai;
        public ChuyenKhoa()
        {
            this.maChuyenKhoa = "";
            this.tenChuyenKhoa = "";
            this.maKhuyenMai = "";
        }

        public ChuyenKhoa(string maChuyenKhoa, string tenChuyenKhoa, string maKhuyenMai)
        {
            this.maChuyenKhoa = maChuyenKhoa;
            this.tenChuyenKhoa = tenChuyenKhoa;
            this.maKhuyenMai = maKhuyenMai;
        }

        public string MaChuyenKhoa
        {
            get { return this.maChuyenKhoa; }
            set { this.maChuyenKhoa = value; }
        }

        public string TenChuyenKhoa
        {
            get { return this.tenChuyenKhoa; }
            set { this.tenChuyenKhoa = value; }
        }

        public string MaKhuyenMai
        {
            get { return this.maKhuyenMai; }
            set { this.maKhuyenMai = value; }
        }

        public override string ToString()
        {
            return "Chuyên khoa { mã chuyên khoa: " + maChuyenKhoa +
                    ", tên chuyên khoa: " + tenChuyenKhoa +
                    ", mã khuyến mãi: " + maKhuyenMai + " }";
        }
    }
}
