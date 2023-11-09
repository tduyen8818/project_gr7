namespace QLBenhVienDaLieu.Database.Function
{
    internal class Table
    {
        public static (string NameTable, string SoDienThoai, string MatKhau) DangKyUser = ("DangKyUser", "SoDienThoai", "MatKhau");
        public static (string NameTable, string HoVaTen,
                        string MaHoSoBenhNhan, string MaTaiKhoan,
                        string NgaySinh, string GioiTinh,
                        string CCCD, string MaBHYT,
                        string NgheNghiep, string SoDienThoai,
                        string Email, string DiaChi) HoSoBenhNhan = ("HoSoBenhNhan", "HoVaTen",
                                                                        "MaHoSoBenhNhan", "MaTaiKhoan",
                                                                        "NgaySinh", "GioiTinh",
                                                                        "CCCD", "MaBHYT",
                                                                        "NgheNghiep", "SoDienThoai",
                                                                        "Email", "DiaChi");
        public static (string NameTable, string MaHoSoBenhNhan,
                        string MaLichKham, string HoVaTen,
                        string Tuoi, string SoTheBHYT,
                        string DiaChi, string NgheNghiep,
                        string DanToc, string TrieuChung,
                        string ChanDoan, string PhuongPhapDieuTri,
                        string BSKhamBenh, string GhiChu) SoKhamBenh = ("SoKhamBenh", "MaHoSoBenhNhan",
                                                                        "MaLichKham", "HoVaTen",
                                                                        "Tuoi", "SoTheBHYT",
                                                                        "DiaChi", "NgheNghiep",
                                                                        "DanToc", "TrieuChung",
                                                                        "ChanDoan", "PhuongPhapDieuTri",
                                                                        "BSKhamBenh", "GhiChu");

        public static (string NameTable, string MaBenhAn,
                        string MaHoSoBenhNhan, string DoiTuong,
                        string GiaTriBHYT, string HoTenThanNhan,
                        string ThoiGianVaoVien, string TrucTiepVao,
                        string NoiGioiThieu, string VaoKhoa,
                        string ChuyenKhoa, string TongSoNgayDieuTri,
                        string NoiChuyenDen, string KKBorCapCuu,
                        string KhiVaoKhoaDieuTri, string KetQuaDieuTri,
                        string GiaiPhauBenh, string QuaTrinhBenhLy,
                        string TienSuBenh, string ToaThan,
                        string TrieuChungCoNang, string ThuongTonCanBan,
                        string CacCoQuan, string TKetQuaTrinhBenhLy,
                        string TomTatKQXN, string PhuongPhapDieuTri, string HoSoPhimAnh) BenhAn = ("BenhAn", "MaBenhAn",
                                                                                                    "MaHoSoBenhNhan", "DoiTuong",
                                                                                                    "GiaTriBHYT", "HoTenThanNhan",
                                                                                                    "ThoiGianVaoVien", "TrucTiepVao",
                                                                                                    "NoiGioiThieu", "VaoKhoa",
                                                                                                    "ChuyenKhoa", "TongSoNgayDieuTri",
                                                                                                    "NoiChuyenDen", "KKBorCapCuu",
                                                                                                    "KhiVaoKhoaDieuTri", "KetQuaDieuTri",
                                                                                                    "GiaiPhauBenh", "QuaTrinhBenhLy",
                                                                                                    "TienSuBenh", "ToaThan",
                                                                                                    "TrieuChungCoNang", "ThuongTonCanBan",
                                                                                                    "CacCoQuan", "TKetQuaTrinhBenhLy",
                                                                                                    "TomTatKQXN", "PhuongPhapDieuTri", "HoSoPhimAnh");
        public static (string NameTable, string SoThuTu,
                        string MaToaThuoc, string MaThuoc,
                        string MaBenhAn, string TenThuoc,
                        string SoLuong, string Dang, string GhiChu) ToaThuoc = ("ToaThuoc", "SoThuTu",
                                                                                "MaToaThuoc", "MaThuoc",
                                                                                "MaBenhAn", "TenThuoc",
                                                                                "SoLuong", "Dang", "GhiChu");

        public static (string NameTable, string MaHoaDon,
                        string MaMaHoSoBenhNhan, string MaLichKham,
                        string TongTien, string HinhThucThanhToan) HoaDon = ("HoaDon", "MaHoaDon",
                                                                                "MaMaHoSoBenhNhan", "MaLichKham",
                                                                                "TongTien", "HinhThucThanhToan");

        public static (string NameTable, string MaKhuyenMai,
                        string TenChuongTrinhKM, string NoiDungKM,
                        string ThoiGianBatDau, string ThoiGianKetThuc) KhuyenMai = ("KhuyenMai", "MaKhuyenMai",
                                                                                    "TenChuongTrinhKM", "NoiDungKM",
                                                                                    "ThoiGianBatDau", "ThoiGianKetThuc");


        public static (string NameTable, string MaDichVu,
                        string TenDichVu, string NoiDungDichVu, string GiaDichVu) DichVu = ("DichVu", "MaDichVu",
                                                                                            "TenDichVu", "NoiDungDichVu", "GiaDichVu");

        public static (string NameTable, string MaChuyenKhoa,
                        string TenChuyenKhoa, string MaKhuyenMai) ChuyenKhoa = ("ChuyenKhoa", "MaChuyenKhoa",
                                                                                "TenChuyenKhoa", "MaKhuyenMai");

        public static (string NameTable, string MaLichKham,
                        string MaHoSoBenhNhan, string MaChuyenKhoa,
                        string MaDichVu, string NgayDangKy,
                        string Ca, string KhungGioKham) LichKham = ("LichKham", "MaLichKham",
                                                                    "MaHoSoBenhNhan", "MaChuyenKhoa",
                                                                    "MaDichVu", "NgayDangKy",
                                                                    "Ca", "KhungGioKham");

        public static (string NameTable, string MaAdmin, string MatKhau) ADMIN_Manager = ("ADMIN_Manager", "MaAdmin", "MatKhau");

        public static (string NameTable, string HoVaTen,
                        string MaThanhVien, string MatKhau,
                        string NgaySinh, string GioiTinh,
                        string CCCD, string SoDienThoai,
                        string Email, string DiaChi,
                        string ChuyenKhoa, string ViTri, string LoaiTaiKhoan) TaiKhoanThanhVien = ("TaiKhoanThanhVien", "HoVaTen",
                                                                                                    "MaThanhVien", "MatKhau",
                                                                                                    "NgaySinh", "GioiTinh",
                                                                                                    "CCCD", "SoDienThoai",
                                                                                                    "Email", "DiaChi",
                                                                                                    "ChuyenKhoa", "ViTri", "LoaiTaiKhoan");

        public static (string NameTable, string MaLichLamViec,
                        string HoVaTen, string MaThanhVien,
                        string Thang, string Ngay, string Ca) LichLamViec = ("LichLamViec", "MaLichLamViec",
                                                                                "HoVaTen", "MaThanhVien",
                                                                                "Thang", "Ngay", "Ca");
    }
}
