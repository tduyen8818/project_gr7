using System;

namespace QLBenhVienDaLieu.Database.Class
{
    public class BenhAn
    {
        private string maBenhAn;
        private string maHoSoBenhNhan;
        private string doiTuong;
        private DateTime giaTriBHYT;
        private string hoTenThanNhan;
        private DateTime thoiGianVaoVien;
        private string trucTiepVao;
        private string noiGioiThieu;
        private string vaoKhoa;
        private string chuyenKhoa;
        private string tongSoNgayDieuTri;
        private string noiChuyenDen;
        private string kkBorCapCuu;
        private string khiVaoKhoaDieuTri;
        private string ketQuaDieuTri;
        private string giaiPhauBenh;
        private string quaTrinhBenhLy;
        private string tienSuBenh;
        private string toanThan;
        private string trieuChungCoNang;
        private string thuongTonCanBan;
        private string cacCoQuan;
        private string tKetQuaTrinhBenhLy;
        private string tomTatKQXN;
        private string phuongPhapDieuTri;
        private string hoSoPhimAnh;

        public BenhAn()
        {
            this.maBenhAn = "";
            this.maHoSoBenhNhan = "";
            this.doiTuong = "";
            this.giaTriBHYT = new DateTime();
            this.hoTenThanNhan = "";
            this.thoiGianVaoVien = new DateTime();
            this.trucTiepVao = "";
            this.noiGioiThieu = "";
            this.vaoKhoa = "";
            this.chuyenKhoa = "";
            this.tongSoNgayDieuTri = "";
            this.noiChuyenDen = "";
            this.kkBorCapCuu = "";
            this.khiVaoKhoaDieuTri = "";
            this.ketQuaDieuTri = "";
            this.giaiPhauBenh = "";
            this.quaTrinhBenhLy = "";
            this.tienSuBenh = "";
            this.toanThan = "";
            this.trieuChungCoNang = "";
            this.thuongTonCanBan = "";
            this.cacCoQuan = "";
            this.tKetQuaTrinhBenhLy = "";
            this.tomTatKQXN = "";
            this.phuongPhapDieuTri = "";
            this.hoSoPhimAnh = "";
        }

        public BenhAn(string maBenhAn, string maHoSoBenhNhan, string doiTuong, DateTime giaTriBHYT, string hoTenThanNhan,
                        DateTime thoiGianVaoVien, string trucTiepVao, string noiGioiThieu, string vaoKhoa, string chuyenKhoa,
                        string tongSoNgayDieuTri, string noiChuyenDen, string kkBorCapCuu, string khiVaoKhoaDieuTri, string ketQuaDieuTri,
                        string giaiPhauBenh, string quaTrinhBenhLy, string tienSuBenh, string toanThan,
                        string trieuChungCoNang, string thuongTonCanBan, string cacCoQuan, string tKetQuaTrinhBenhLy,
                        string tomTatKQXN, string phuongPhapDieuTri, string hoSoPhimAnh)
        {
            this.maBenhAn = maBenhAn;
            this.maHoSoBenhNhan = maHoSoBenhNhan;
            this.doiTuong = doiTuong;
            this.giaTriBHYT = giaTriBHYT;
            this.hoTenThanNhan = hoTenThanNhan;
            this.thoiGianVaoVien = thoiGianVaoVien;
            this.trucTiepVao = trucTiepVao;
            this.noiGioiThieu = noiGioiThieu;
            this.vaoKhoa = vaoKhoa;
            this.chuyenKhoa = chuyenKhoa;
            this.tongSoNgayDieuTri = tongSoNgayDieuTri;
            this.noiChuyenDen = noiChuyenDen;
            this.kkBorCapCuu = kkBorCapCuu;
            this.khiVaoKhoaDieuTri = khiVaoKhoaDieuTri;
            this.ketQuaDieuTri = ketQuaDieuTri;
            this.giaiPhauBenh = giaiPhauBenh;
            this.quaTrinhBenhLy = quaTrinhBenhLy;
            this.tienSuBenh = tienSuBenh;
            this.toanThan = toanThan;
            this.trieuChungCoNang = trieuChungCoNang;
            this.thuongTonCanBan = thuongTonCanBan;
            this.cacCoQuan = cacCoQuan;
            this.tKetQuaTrinhBenhLy = tKetQuaTrinhBenhLy;
            this.tomTatKQXN = tomTatKQXN;
            this.phuongPhapDieuTri = phuongPhapDieuTri;
            this.hoSoPhimAnh = hoSoPhimAnh;
        }

        public string MaBenhAn
        {
            get { return this.maBenhAn; }
            set { this.maBenhAn = value; }
        }

        public string MaHoSoBenhNhan
        {
            get { return this.maHoSoBenhNhan; }
            set { this.maHoSoBenhNhan = value; }
        }

        public string DoiTuong
        {
            get { return this.doiTuong; }
            set { this.doiTuong = value; }
        }

        public DateTime GiaTriBHYT
        {
            get { return this.giaTriBHYT; }
            set { this.giaTriBHYT = value; }
        }

        public string HoTenThanNhan
        {
            get { return this.hoTenThanNhan; }
            set { this.hoTenThanNhan = value; }
        }

        public DateTime ThoiGianVaoVien
        {
            get { return this.thoiGianVaoVien; }
            set { this.thoiGianVaoVien = value; }
        }

        public string TrucTiepVao
        {
            get { return this.trucTiepVao; }
            set { this.trucTiepVao = value; }
        }

        public string NoiGioiThieu
        {
            get { return this.noiGioiThieu; }
            set { this.noiGioiThieu = value; }
        }

        public string VaoKhoa
        {
            get { return this.vaoKhoa; }
            set { this.vaoKhoa = value; }
        }

        public string ChuyenKhoa
        {
            get { return this.chuyenKhoa; }
            set { this.chuyenKhoa = value; }
        }

        public string TongSoNgayDieuTri
        {
            get { return this.tongSoNgayDieuTri; }
            set { this.tongSoNgayDieuTri = value; }
        }

        public string NoiChuyenDen
        {
            get { return this.noiChuyenDen; }
            set { this.noiChuyenDen = value; }
        }

        public string KkBorCapCuu
        {
            get { return this.kkBorCapCuu; }
            set { this.kkBorCapCuu = value; }
        }

        public string KhiVaoKhoaDieuTri
        {
            get { return this.khiVaoKhoaDieuTri; }
            set { this.khiVaoKhoaDieuTri = value; }
        }

        public string KetQuaDieuTri
        {
            get { return this.ketQuaDieuTri; }
            set { this.ketQuaDieuTri = value; }
        }

        public string GiaiPhauBenh
        {
            get { return this.giaiPhauBenh; }
            set { this.giaiPhauBenh = value; }
        }

        public string QuaTrinhBenhLy
        {
            get { return this.quaTrinhBenhLy; }
            set { this.quaTrinhBenhLy = value; }
        }

        public string TienSuBenh
        {
            get { return this.tienSuBenh; }
            set { this.tienSuBenh = value; }
        }

        public string ToanThan
        {
            get { return this.toanThan; }
            set { this.toanThan = value; }
        }

        public string TrieuChungCoNang
        {
            get { return this.trieuChungCoNang; }
            set { this.trieuChungCoNang = value; }
        }

        public string ThuongTonCanBan
        {
            get { return this.thuongTonCanBan; }
            set { this.thuongTonCanBan = value; }
        }

        public string CacCoQuan
        {
            get { return this.cacCoQuan; }
            set { this.cacCoQuan = value; }
        }

        public string TKetQuaTrinhBenhLy
        {
            get { return this.tKetQuaTrinhBenhLy; }
            set { this.tKetQuaTrinhBenhLy = value; }
        }

        public string TomTatKQXN
        {
            get { return this.tomTatKQXN; }
            set { this.tomTatKQXN = value; }
        }

        public string PhuongPhapDieuTri
        {
            get { return this.phuongPhapDieuTri; }
            set { this.phuongPhapDieuTri = value; }
        }

        public string HoSoPhimAnh
        {
            get { return this.hoSoPhimAnh; }
            set { this.hoSoPhimAnh = value; }
        }

        public override string ToString()
        {
            return "Bệnh án { mã bệnh án: " + maBenhAn +
                    ", mã bệnh nhân: '" + maHoSoBenhNhan +
                    ", đối tượng: " + doiTuong +
                    ", giá trị BHYT: " + giaTriBHYT +
                    ", họ tên thân nhân: '" + hoTenThanNhan +
                    ", thời gian vào viện: " + thoiGianVaoVien +
                    ", trực tiếp vào: " + trucTiepVao +
                    ", nơi giới thiệu: " + noiGioiThieu +
                    ", vào khoa: " + vaoKhoa +
                    ", chuyên khoa: " + chuyenKhoa +
                    ", tổng số ngày điều trị: " + tongSoNgayDieuTri +
                    ", nơi chuyển đến: " + noiChuyenDen +
                    ", khoa khám bệnh hoặc cấp cứu: " + kkBorCapCuu +
                    ", kết quả điều trị: " + ketQuaDieuTri +
                    ", giải phẩu bệnh: " + giaiPhauBenh +
                    ", quá trình bệnh lý: " + quaTrinhBenhLy +
                    ", tiểu sử bệnh: " + tienSuBenh +
                    ", toàn thân: " + toanThan +
                    ", triệu chứng cơ năng: " + trieuChungCoNang +
                    ", thương tổn căn bản: " + thuongTonCanBan +
                    ", các cơ quan: " + cacCoQuan +
                    ", tổng kết quá trình bệnh lý: " + tKetQuaTrinhBenhLy +
                    ", tóm tắt KQXN: " + tomTatKQXN +
                    ", phương pháp điều trị: " + phuongPhapDieuTri +
                    ", hồ sơ phim ảnh: " + hoSoPhimAnh + " }";
        }

    }
}
