CREATE DATABASE QLPK
USE QLPK

CREATE TABLE User (
    SoDienThoai VARCHAR(20) PRIMARY KEY,
    MatKhau VARCHAR(255)
);

CREATE TABLE TaiKhoanAdmin (
    MaAdmin INT PRIMARY KEY,
    FOREIGN KEY (MaAdmin) REFERENCES User(SoDienThoai)
);

CREATE TABLE TaiKhoanThanhVien (
    MaThanhVien INT PRIMARY KEY,
    HoVaTen NVARCHAR(255),
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    CCCD_CMND VARCHAR(20),
    SoDienThoai VARCHAR(20),
    Email VARCHAR(255),
    DiaChi NVARCHAR(255),
    ChuyenKhoa NVARCHAR(255),
    ViTri NVARCHAR(255),
    LoaiTaiKhoan NVARCHAR(20),
    FOREIGN KEY (MaThanhVien) REFERENCES User(SoDienThoai)
);

CREATE TABLE LichLamViec (
    HovaTen NVARCHAR(255),
    MaThanhVien INT,
    Thang INT,
    Ngay DATE,
    Ca INT,
    FOREIGN KEY (MaThanhVien) REFERENCES TaiKhoanThanhVien(MaThanhVien)
);

CREATE TABLE HoSoBenhNhan (
    HoVaTen NVARCHAR(255),
    MaHoSoBenhNhan INT PRIMARY KEY,
    MaTaiKhoan INT,
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    CCCD_CMND VARCHAR(20),
    MaBHYT VARCHAR(20),
    NgheNghiep NVARCHAR(255),
    SoDienThoai VARCHAR(20),
    Email VARCHAR(255),
    DiaChi NVARCHAR(255),
    FOREIGN KEY (MaTaiKhoan) REFERENCES TaiKhoanThanhVien(MaThanhVien)
);

CREATE TABLE SoKhamBenh (
    MaHoSoBenhNhan INT,
    MaLichKham INT,
    Hovaten NVARCHAR(255),
    Tuoi INT,
    SoTheBHYT VARCHAR(20),
    DiaChi NVARCHAR(255),
    NgheNghiep NVARCHAR(255),
    DanToc NVARCHAR(255),
    TrieuChung NVARCHAR(255),
    ChanDoan NVARCHAR(255),
    PhuongPhapDieuTri NVARCHAR(255),
    BSKhambenh NVARCHAR(255),
    GhiChu NVARCHAR(255),
    FOREIGN KEY (MaHoSoBenhNhan) REFERENCES HoSoBenhNhan(MaHoSoBenhNhan)
);

CREATE TABLE ThongTInDKLichKham (
    MaLichKham INT PRIMARY KEY,
    MaHoSoBenhNhan INT,
    ChuyenKhoa NVARCHAR(255),
    DichVu NVARCHAR(255),
    NgayDangKy DATE,
    Ca INT,
    KhungGioKham NVARCHAR(255),
    FOREIGN KEY (MaHoSoBenhNhan) REFERENCES HoSoBenhNhan(MaHoSoBenhNhan)
);

CREATE TABLE ToaThuoc (
    SoThuTu INT PRIMARY KEY,
    MaToaThuoc INT,
    TenThuoc NVARCHAR(255),
    SoLuong INT,
    Dang NVARCHAR(50),
    GhiChu NVARCHAR(255)
);

CREATE TABLE HoaDon (
    MaHoaDon INT PRIMARY KEY,
    MaHoSoBenhNhan INT,
    MaLichKham INT,
    MaToaThuoc INT,
    TongTien DECIMAL(10, 2),
    HinhThucThanhToan NVARCHAR(255),
    FOREIGN KEY (MaHoSoBenhNhan) REFERENCES HoSoBenhNhan(MaHoSoBenhNhan),
    FOREIGN KEY (MaLichKham) REFERENCES ThongTInDKLichKham(MaLichKham),
    FOREIGN KEY (MaToaThuoc) REFERENCES ToaThuoc(MaToaThuoc)
);

CREATE TABLE BenhAn (
    MaBenhAn INT PRIMARY KEY,
    MaHoSoBenhNhan INT,
    DoiTuong NVARCHAR(255),
    GiaTriBHYT DECIMAL(10, 2),
    HoTenThanNhan NVARCHAR(255),
    ThoiGianVaoVien DATETIME,
    TrucTiepVao NVARCHAR(255),
    NoiGioiThieu NVARCHAR(255),
    VaoKhoa NVARCHAR(255),
    ChuyenKhoa NVARCHAR(255),
    ChuyenVien NVARCHAR(255),
    RaVien DATETIME,
    TongSoNgayDieuTri INT,
    NoiChuyenDen NVARCHAR(255),
    KKBorCapCuu NVARCHAR(255),
    KhiVaoKhoaDieuTri NVARCHAR(255),
    KetQuaDieuTri NVARCHAR(255),
    GiaiPhauBenh NVARCHAR(255),
    QuaTrinhBenhLy NVARCHAR(255),
    TienSuBenh NVARCHAR(255),
    ToaThan NVARCHAR(255),
    TrieuChungCoNang NVARCHAR(255),
    ThuongTonCanBan NVARCHAR(255),
    CacCoQuan NVARCHAR(255),
    TKetQuaTrinhBenhLy NVARCHAR(255),
    TomTatKQXN NVARCHAR(255),
    PhuongPhapDieuTri NVARCHAR(255),
    HoSoPhimAnh NVARCHAR(MAX),
    FOREIGN KEY (MaHoSoBenhNhan) REFERENCES HoSoBenhNhan(MaHoSoBenhNhan)
);

-- Hàm lấy mã tự động cho MaThanhVien
CREATE OR REPLACE FUNCTION GetNewMaThanhVien()
RETURNS INT AS $$
DECLARE
    new_id INT;
BEGIN
    SELECT COALESCE(MAX(MaThanhVien), 0) + 1 INTO new_id FROM TaiKhoanThanhVien;
    RETURN new_id;
END;
$$ LANGUAGE plpgsql;

-- Hàm lấy mã tự động cho MaHoSoBenhNhan
CREATE OR REPLACE FUNCTION GetNewMaHoSoBenhNhan()
RETURNS INT AS $$
DECLARE
    new_id INT;
BEGIN
    SELECT COALESCE(MAX(MaHoSoBenhNhan), 0) + 1 INTO new_id FROM HoSoBenhNhan;
    RETURN new_id;
END;
$$ LANGUAGE plpgsql;

-- Hàm lấy mã tự động cho MaLichKham
CREATE OR REPLACE FUNCTION GetNewMaLichKham()
RETURNS INT AS $$
DECLARE
    new_id INT;
BEGIN
    SELECT COALESCE(MAX(MaLichKham), 0) + 1 INTO new_id FROM ThongTInDKLichKham;
    RETURN new_id;
END;
$$ LANGUAGE plpgsql;

-- Hàm lấy mã tự động cho MaToaThuoc
CREATE OR REPLACE FUNCTION GetNewMaToaThuoc()
RETURNS INT AS $$
DECLARE
    new_id INT;
BEGIN
    SELECT COALESCE(MAX(MaToaThuoc), 0) + 1 INTO new_id FROM ToaThuoc;
    RETURN new_id;
END;
$$ LANGUAGE plpgsql;

-- Hàm lấy mã tự động cho MaHoaDon
CREATE OR REPLACE FUNCTION GetNewMaHoaDon()
RETURNS INT AS $$
DECLARE
    new_id INT;
BEGIN
    SELECT COALESCE(MAX(MaHoaDon), 0) + 1 INTO new_id FROM HoaDon;
    RETURN new_id;
END;
$$ LANGUAGE plpgsql;

-- Hàm lấy mã tự động cho MaBenhAn
CREATE OR REPLACE FUNCTION GetNewMaBenhAn()
RETURNS INT AS $$
DECLARE
    new_id INT;
BEGIN
    SELECT COALESCE(MAX(MaBenhAn), 0) + 1 INTO new_id FROM BenhAn;
    RETURN new_id;
END;
$$ LANGUAGE plpgsql;

-- Trigger cho MaThanhVien
CREATE OR REPLACE FUNCTION MaThanhVien_BeforeInsert()
RETURNS TRIGGER AS $$
BEGIN
    NEW.MaThanhVien = GetNewMaThanhVien();
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER trig_MaThanhVien_BeforeInsert
BEFORE INSERT ON TaiKhoanThanhVien
FOR EACH ROW
EXECUTE FUNCTION MaThanhVien_BeforeInsert();

-- Trigger cho MaHoSoBenhNhan
CREATE OR REPLACE FUNCTION MaHoSoBenhNhan_BeforeInsert()
RETURNS TRIGGER AS $$
BEGIN
    NEW.MaHoSoBenhNhan = GetNewMaHoSoBenhNhan();
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER trig_MaHoSoBenhNhan_BeforeInsert
BEFORE INSERT ON HoSoBenhNhan
FOR EACH ROW
EXECUTE FUNCTION MaHoSoBenhNhan_BeforeInsert();

-- Trigger cho MaLichKham
CREATE OR REPLACE FUNCTION MaLichKham_BeforeInsert()
RETURNS TRIGGER AS $$
BEGIN
    NEW.MaLichKham = GetNewMaLichKham();
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER trig_MaLichKham_BeforeInsert
BEFORE INSERT ON ThongTInDKLichKham
FOR EACH ROW
EXECUTE FUNCTION MaLichKham_BeforeInsert();

-- Trigger cho MaToaThuoc
CREATE OR REPLACE FUNCTION MaToaThuoc_BeforeInsert()
RETURNS TRIGGER AS $$
BEGIN
    NEW.MaToaThuoc = GetNewMaToaThuoc();
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER trig_MaToaThuoc_BeforeInsert
BEFORE INSERT ON ToaThuoc
FOR EACH ROW
EXECUTE FUNCTION MaToaThuoc_BeforeInsert();

-- Trigger cho MaHoaDon
CREATE OR REPLACE FUNCTION MaHoaDon_BeforeInsert()
RETURNS TRIGGER AS $$
BEGIN
    NEW.MaHoaDon = GetNewMaHoaDon();
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER trig_MaHoaDon_BeforeInsert
BEFORE INSERT ON HoaDon
FOR EACH ROW
EXECUTE FUNCTION MaHoaDon_BeforeInsert();

-- Trigger cho MaBenhAn
CREATE OR REPLACE FUNCTION MaBenhAn_BeforeInsert()
RETURNS TRIGGER AS $$
BEGIN
    NEW.MaBenhAn = GetNewMaBenhAn();
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER trig_MaBenhAn_BeforeInsert
BEFORE INSERT ON BenhAn
FOR EACH ROW
EXECUTE FUNCTION MaBenhAn_BeforeInsert();

--- Cum Function Insert du lieu ---
-- User
CREATE OR REPLACE FUNCTION InsertUser(SoDienThoai VARCHAR(20), MatKhau VARCHAR(255))
RETURNS VOID AS $$
BEGIN
	INSERT INTO User(SoDienThoai, MatKhau) VALUES (SoDienThoai, MatKhau);
END;
$$ LANGUAGE plpgsql;

-- TaiKhoanAdmin
CREATE OR REPLACE FUNCTION InsertTaiKhoanAdmin(MaAdmin INT, SoDienThoai VARCHAR(20), MatKhau VARCHAR(255))
RETURNS VOID AS $$
BEGIN
    -- Trước tiên, thêm dữ liệu vào bảng User
    INSERT INTO User(SoDienThoai, MatKhau) VALUES (SoDienThoai, MatKhau);
    -- Sau đó, thêm dữ liệu vào bảng TaiKhoanAdmin
    INSERT INTO TaiKhoanAdmin(MaAdmin) VALUES (MaAdmin);
END;
$$ LANGUAGE plpgsql;

-- TaiKhoanThanhVien
CREATE OR REPLACE FUNCTION InsertTaiKhoanThanhVien(MaThanhVien INT, HoVaTen NVARCHAR(255), NgaySinh DATE, GioiTinh NVARCHAR(10), CCCD_CMND VARCHAR(20), SoDienThoai VARCHAR(20), Email VARCHAR(255), DiaChi NVARCHAR(255), ChuyenKhoa NVARCHAR(255), ViTri NVARCHAR(255), LoaiTaiKhoan NVARCHAR(20), MatKhau VARCHAR(255))
RETURNS VOID AS $$
BEGIN
    -- Trước tiên, thêm dữ liệu vào bảng User
    INSERT INTO User(SoDienThoai, MatKhau) VALUES (SoDienThoai, MatKhau);
    
    -- Sau đó, thêm dữ liệu vào bảng TaiKhoanThanhVien
    INSERT INTO TaiKhoanThanhVien(MaThanhVien, HoVaTen, NgaySinh, GioiTinh, CCCD_CMND, SoDienThoai, Email, DiaChi, ChuyenKhoa, ViTri, LoaiTaiKhoan) 
    VALUES (MaThanhVien, HoVaTen, NgaySinh, GioiTinh, CCCD_CMND, SoDienThoai, Email, DiaChi, ChuyenKhoa, ViTri, LoaiTaiKhoan);
END;
$$ LANGUAGE plpgsql;

-- LichLamViec
CREATE OR REPLACE FUNCTION InsertLichLamViec(HovaTen NVARCHAR(255), MaThanhVien INT, Thang INT, Ngay DATE, Ca INT)
RETURNS VOID AS $$
BEGIN
    INSERT INTO LichLamViec(HovaTen, MaThanhVien, Thang, Ngay, Ca) VALUES (HovaTen, MaThanhVien, Thang, Ngay, Ca);
END;
$$ LANGUAGE plpgsql;

-- HoSoBenhNhan
CREATE OR REPLACE FUNCTION InsertHoSoBenhNhan(HoVaTen NVARCHAR(255), MaHoSoBenhNhan INT, MaTaiKhoan INT, NgaySinh DATE, GioiTinh NVARCHAR(10), CCCD_CMND VARCHAR(20), MaBHYT VARCHAR(20), NgheNghiep NVARCHAR(255), SoDienThoai VARCHAR(20), Email VARCHAR(255), DiaChi NVARCHAR(255))
RETURNS VOID AS $$
BEGIN
    INSERT INTO HoSoBenhNhan(HoVaTen, MaHoSoBenhNhan, MaTaiKhoan, NgaySinh, GioiTinh, CCCD_CMND, MaBHYT, NgheNghiep, SoDienThoai, Email, DiaChi)
    VALUES (HoVaTen, MaHoSoBenhNhan, MaTaiKhoan, NgaySinh, GioiTinh, CCCD_CMND, MaBHYT, NgheNghiep, SoDienThoai, Email, DiaChi);
END;
$$ LANGUAGE plpgsql;

-- SoKhamBenh
CREATE OR REPLACE FUNCTION InsertSoKhamBenh(MaHoSoBenhNhan INT, MaLichKham INT, Hovaten NVARCHAR(255), Tuoi INT, SoTheBHYT VARCHAR(20), DiaChi NVARCHAR(255), NgheNghiep NVARCHAR(255), DanToc NVARCHAR(255), TrieuChung NVARCHAR(255), ChanDoan NVARCHAR(255), PhuongPhapDieuTri NVARCHAR(255), BSKhambenh NVARCHAR(255), GhiChu NVARCHAR(255))
RETURNS VOID AS $$
BEGIN
    INSERT INTO SoKhamBenh(MaHoSoBenhNhan, MaLichKham, Hovaten, Tuoi, SoTheBHYT, DiaChi, NgheNghiep, DanToc, TrieuChung, ChanDoan, PhuongPhapDieuTri, BSKhambenh, GhiChu)
    VALUES (MaHoSoBenhNhan, MaLichKham, Hovaten, Tuoi, SoTheBHYT, DiaChi, NgheNghiep, DanToc, TrieuChung, ChanDoan, PhuongPhapDieuTri, BSKhambenh, GhiChu);
END;
$$ LANGUAGE plpgsql;

-- ThongTInDKLichKham
CREATE OR REPLACE FUNCTION InsertThongTInDKLichKham(MaLichKham INT, MaHoSoBenhNhan INT, ChuyenKhoa NVARCHAR(255), DichVu NVARCHAR(255), NgayDangKy DATE, Ca INT, KhungGioKham NVARCHAR(255))
RETURNS VOID AS $$
BEGIN
    INSERT INTO ThongTInDKLichKham(MaLichKham, MaHoSoBenhNhan, ChuyenKhoa, DichVu, NgayDangKy, Ca, KhungGioKham)
    VALUES (MaLichKham, MaHoSoBenhNhan, ChuyenKhoa, DichVu, NgayDangKy, Ca, KhungGioKham);
END;
$$ LANGUAGE plpgsql;

-- ToaThuoc
CREATE OR REPLACE FUNCTION InsertToaThuoc(SoThuTu INT, MaToaThuoc INT, TenThuoc NVARCHAR(255), SoLuong INT, Dang NVARCHAR(50), GhiChu NVARCHAR(255))
RETURNS VOID AS $$
BEGIN
    INSERT INTO ToaThuoc(SoThuTu, MaToaThuoc, TenThuoc, SoLuong, Dang, GhiChu)
    VALUES (SoThuTu, MaToaThuoc, TenThuoc, SoLuong, Dang, GhiChu);
END;
$$ LANGUAGE plpgsql;

-- HoaDon
CREATE OR REPLACE FUNCTION InsertHoaDon(MaHoaDon INT, MaHoSoBenhNhan INT, MaLichKham INT, MaToaThuoc INT, TongTien DECIMAL(10, 2), HinhThucThanhToan NVARCHAR(255))
RETURNS VOID AS $$
BEGIN
    INSERT INTO HoaDon(MaHoaDon, MaHoSoBenhNhan, MaLichKham, MaToaThuoc, TongTien, HinhThucThanhToan)
    VALUES (MaHoaDon, MaHoSoBenhNhan, MaLichKham, MaToaThuoc, TongTien, HinhThucThanhToan);
END;
$$ LANGUAGE plpgsql;

-- BenhAn
CREATE OR REPLACE FUNCTION InsertBenhAn(MaBenhAn INT, MaHoSoBenhNhan INT, DoiTuong NVARCHAR(255), GiaTriBHYT DECIMAL(10, 2), HoTenThanNhan NVARCHAR(255), ThoiGianVaoVien DATETIME, TrucTiepVao NVARCHAR(255), NoiGioiThieu NVARCHAR(255), VaoKhoa NVARCHAR(255), ChuyenKhoa NVARCHAR(255), ChuyenVien NVARCHAR(255), RaVien DATETIME, TongSoNgayDieuTri INT, NoiChuyenDen NVARCHAR(255), KKBorCapCuu NVARCHAR(255), KhiVaoKhoaDieuTri NVARCHAR(255), KetQuaDieuTri NVARCHAR(255), GiaiPhauBenh NVARCHAR(255), QuaTrinhBenhLy NVARCHAR(255), TienSuBenh NVARCHAR(255), ToaThan NVARCHAR(255), TrieuChungCoNang NVARCHAR(255), ThuongTonCanBan NVARCHAR(255), CacCoQuan NVARCHAR(255), TKetQuaTrinhBenhLy NVARCHAR(255), TomTatKQXN NVARCHAR(255), PhuongPhapDieuTri NVARCHAR(255), HoSoPhimAnh NVARCHAR(MAX))
RETURNS VOID AS $$
BEGIN
    INSERT INTO BenhAn(MaBenhAn, MaHoSoBenhNhan, DoiTuong, GiaTriBHYT, HoTenThanNhan, ThoiGianVaoVien, TrucTiepVao, NoiGioiThieu, VaoKhoa, ChuyenKhoa, ChuyenVien, RaVien, TongSoNgayDieuTri, NoiChuyenDen, KKBorCapCuu, KhiVaoKhoaDieuTri, KetQuaDieuTri, GiaiPhauBenh, QuaTrinhBenhLy, TienSuBenh, ToaThan, TrieuChungCoNang, ThuongTonCanBan, CacCoQuan, TKetQuaTrinhBenhLy, TomTatKQXN, PhuongPhapDieuTri, HoSoPhimAnh)
    VALUES (MaBenhAn, MaHoSoBenhNhan, DoiTuong, GiaTriBHYT, HoTenThanNhan, ThoiGianVaoVien, TrucTiepVao, NoiGioiThieu, VaoKhoa, ChuyenKhoa, ChuyenVien, RaVien, TongSoNgayDieuTri, NoiChuyenDen, KKBorCapCuu, KhiVaoKhoaDieuTri, KetQuaDieuTri, GiaiPhauBenh, QuaTrinhBenhLy, TienSuBenh, ToaThan, TrieuChungCoNang, ThuongTonCanBan, CacCoQuan, TKetQuaTrinhBenhLy, TomTatKQXN, PhuongPhapDieuTri, HoSoPhimAnh);
END;
$$ LANGUAGE plpgsql;

--- Cum Function Select du lieu ---
-- Hàm lấy danh sách tất cả User
CREATE OR REPLACE FUNCTION GetAllUsers()
RETURNS TABLE (
    SoDienThoai VARCHAR(20),
    MatKhau VARCHAR(255)
) AS $$
BEGIN
    RETURN QUERY SELECT * FROM "User";
END;
$$ LANGUAGE plpgsql;

-- Hàm lấy danh sách tất cả TaiKhoanAdmin
CREATE OR REPLACE FUNCTION GetAllTaiKhoanAdmin()
RETURNS TABLE (
    MaAdmin INT
) AS $$
BEGIN
    RETURN QUERY SELECT * FROM TaiKhoanAdmin;
END;
$$ LANGUAGE plpgsql;

-- Hàm lấy danh sách tất cả TaiKhoanThanhVien
CREATE OR REPLACE FUNCTION GetAllTaiKhoanThanhVien()
RETURNS TABLE (
    MaThanhVien INT,
    HoVaTen NVARCHAR(255),
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    CCCD_CMND VARCHAR(20),
    SoDienThoai VARCHAR(20),
    Email VARCHAR(255),
    DiaChi NVARCHAR(255),
    ChuyenKhoa NVARCHAR(255),
    ViTri NVARCHAR(255),
    LoaiTaiKhoan NVARCHAR(20)
) AS $$
BEGIN
    RETURN QUERY SELECT * FROM TaiKhoanThanhVien;
END;
$$ LANGUAGE plpgsql;

-- Hàm lấy danh sách tất cả LichLamViec
CREATE OR REPLACE FUNCTION GetAllLichLamViec()
RETURNS TABLE (
    HovaTen NVARCHAR(255),
    MaThanhVien INT,
    Thang INT,
    Ngay DATE,
    Ca INT
) AS $$
BEGIN
    RETURN QUERY SELECT * FROM LichLamViec;
END;
$$ LANGUAGE plpgsql;

-- Hàm lấy danh sách tất cả HoSoBenhNhan
CREATE OR REPLACE FUNCTION GetAllHoSoBenhNhan()
RETURNS TABLE (
    HoVaTen NVARCHAR(255),
    MaHoSoBenhNhan INT,
    MaTaiKhoan INT,
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    CCCD_CMND VARCHAR(20),
    MaBHYT VARCHAR(20),
    NgheNghiep NVARCHAR(255),
    SoDienThoai VARCHAR(20),
    Email VARCHAR(255),
    DiaChi NVARCHAR(255)
) AS $$
BEGIN
    RETURN QUERY SELECT * FROM HoSoBenhNhan;
END;
$$ LANGUAGE plpgsql;

-- Hàm lấy danh sách tất cả SoKhamBenh
CREATE OR REPLACE FUNCTION GetAllSoKhamBenh()
RETURNS TABLE (
    MaHoSoBenhNhan INT,
    MaLichKham INT,
    Hovaten NVARCHAR(255),
    Tuoi INT,
    SoTheBHYT VARCHAR(20),
    DiaChi NVARCHAR(255),
    NgheNghiep NVARCHAR(255),
    DanToc NVARCHAR(255),
    TrieuChung NVARCHAR(255),
    ChanDoan NVARCHAR(255),
    PhuongPhapDieuTri NVARCHAR(255),
    BSKhambenh NVARCHAR(255),
    GhiChu NVARCHAR(255)
) AS $$
BEGIN
    RETURN QUERY SELECT * FROM SoKhamBenh;
END;
$$ LANGUAGE plpgsql;

-- Hàm lấy danh sách tất cả ThongTInDKLichKham
CREATE OR REPLACE FUNCTION GetAllThongTInDKLichKham()
RETURNS TABLE (
    MaLichKham INT,
    MaHoSoBenhNhan INT,
    ChuyenKhoa NVARCHAR(255),
    DichVu NVARCHAR(255),
    NgayDangKy DATE,
    Ca INT,
    KhungGioKham NVARCHAR(255)
) AS $$
BEGIN
    RETURN QUERY SELECT * FROM ThongTInDKLichKham;
END;
$$ LANGUAGE plpgsql;

-- Hàm lấy danh sách tất cả ToaThuoc
CREATE OR REPLACE FUNCTION GetAllToaThuoc()
RETURNS TABLE (
    SoThuTu INT,
    MaToaThuoc INT,
    TenThuoc NVARCHAR(255),
    SoLuong INT,
    Dang NVARCHAR(50),
    GhiChu NVARCHAR(255)
) AS $$
BEGIN
    RETURN QUERY SELECT * FROM ToaThuoc;
END;
$$ LANGUAGE plpgsql;

-- Hàm lấy danh sách tất cả HoaDon
CREATE OR REPLACE FUNCTION GetAllHoaDon()
RETURNS TABLE (
    MaHoaDon INT,
    MaHoSoBenhNhan INT,
    MaLichKham INT,
    MaToaThuoc INT,
    TongTien DECIMAL(10, 2),
    HinhThucThanhToan NVARCHAR(255)
) AS $$
BEGIN
    RETURN QUERY SELECT * FROM HoaDon;
END;
$$ LANGUAGE plpgsql;

-- Hàm lấy danh sách tất cả BenhAn
CREATE OR REPLACE FUNCTION GetAllBenhAn()
RETURNS TABLE (
    MaBenhAn INT, MaHoSoBenhNhan INT,
    DoiTuong NVARCHAR(255),
    GiaTriBHYT DECIMAL(10, 2),
    HoTenThanNhan NVARCHAR(255),
    ThoiGianVaoVien DATETIME,
    TrucTiepVao NVARCHAR(255),
    NoiGioiThieu NVARCHAR(255),
    VaoKhoa NVARCHAR(255),
    ChuyenKhoa NVARCHAR(255),
    ChuyenVien NVARCHAR(255),
    RaVien DATETIME,
    TongSoNgayDieuTri INT,
    NoiChuyenDen NVARCHAR(255),
    KKBorCapCuu NVARCHAR(255),
    KhiVaoKhoaDieuTri NVARCHAR(255),
    KetQuaDieuTri NVARCHAR(255),
    GiaiPhauBenh NVARCHAR(255),
    QuaTrinhBenhLy NVARCHAR(255),
    TienSuBenh NVARCHAR(255),
    ToaThan NVARCHAR(255),
    TrieuChungCoNang NVARCHAR(255),
    ThuongTonCanBan NVARCHAR(255),
    CacCoQuan NVARCHAR(255),
    TKetQuaTrinhBenhLy NVARCHAR(255),
    TomTatKQXN NVARCHAR(255),
    PhuongPhapDieuTri NVARCHAR(255),
    HoSoPhimAnh NVARCHAR(MAX)
) AS $$
BEGIN
    RETURN QUERY SELECT * FROM BenhAn;
END;
$$ LANGUAGE plpgsql;


