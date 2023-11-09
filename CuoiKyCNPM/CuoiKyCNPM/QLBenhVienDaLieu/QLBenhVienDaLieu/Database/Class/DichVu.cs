namespace QLBenhVienDaLieu.Database.Class
{
    public class DichVu
    {
        private string maDichVu;
        private string tenDichVu;
        private string noiDungDichVu;
        private int giaDichVu;

        public DichVu()
        {
            this.maDichVu = "";
            this.tenDichVu = "";
            this.noiDungDichVu = "";
            this.giaDichVu = 0;
        }

        public DichVu(string maDichVu, string tenDichVu, string noiDungDichVu, int giaDichVu)
        {
            this.maDichVu = maDichVu;
            this.tenDichVu = tenDichVu;
            this.noiDungDichVu = noiDungDichVu;
            this.giaDichVu = giaDichVu;
        }

        public string MaDichVu
        {
            get { return this.maDichVu; }
            set { this.maDichVu = value; }
        }

        public string TenDichVu
        {
            get { return this.tenDichVu; }
            set { this.tenDichVu = value; }
        }

        public string NoiDungDichVu
        {
            get { return this.noiDungDichVu; }
            set { this.noiDungDichVu = value; }
        }

        public int GiaDichVu
        {
            get { return this.giaDichVu; }
            set { this.giaDichVu = value; }
        }

        public override string ToString()
        {
            return "Dịch vụ { mã dịch vụ: " + maDichVu +
                    ", tên dịch vụ: " + tenDichVu +
                    ", nội dung dịch vụ: " + noiDungDichVu +
                    ", giá dịch vụ: " + giaDichVu + " }";
        }
    }
}
