CREATE DATABASE PHONGKHAMDALIEU
--//////////////////////////// dtb
USE PHONGKHAMDALIEU
--DROP DATABASE PHONGKHAMDALIEU
--////////////////////////////
-- TAO BANG --
CREATE TABLE DangKyUser
(
	SoDienThoai varchar(10) NOT NULL,
	MatKhau varchar(8),
)
ALTER TABLE DangKyUser ADD PRIMARY KEY (SoDienThoai)
CREATE FUNCTION GetDangKyUserByParam(@ParamName varchar(50)) RETURNS varchar(50)
AS
BEGIN
    DECLARE @Result varchar(50)
    IF @ParamName = 'SoDienThoai'
        SELECT @Result = SoDienThoai FROM DangKyUser
    ELSE IF @ParamName = 'MatKhau'
        SELECT @Result = MatKhau FROM DangKyUser
    ELSE
        SET @Result = 'Invalid Parameter'
    RETURN @Result
END
--/////////////////// Ho so benh nhan
CREATE TABLE HoSoBenhNhan
(
	HoVaTen nvarchar(30),
	MaHoSoBenhNhan varchar(8) NOT NULL,
	MaTaiKhoan varchar(10),
	NgaySinh date,
	GioiTinh nvarchar(3),
	CCCD varchar(12),
	MaBHYT varchar(15),
	NgheNghiep nvarchar(30),
	SoDienThoai varchar(10),
	Email varchar(30),
	DiaChi nvarchar(50)
)
ALTER TABLE HoSoBenhNhan ADD PRIMARY KEY (MaHoSoBenhNhan);
ALTER TABLE HoSoBenhNhan ADD CONSTRAINT FK_HoSoBenhNhanUser FOREIGN KEY (MaTaiKhoan) REFERENCES DangKyUser(SoDienThoai)
CREATE FUNCTION GetHoSoBenhNhanByParam(@MaHoSoBenhNhan varchar(8), @ParamName varchar(50)) RETURNS varchar(50)
AS
BEGIN
    DECLARE @Result varchar(50)
    IF @ParamName = 'HoVaTen'
        SELECT @Result = HoVaTen FROM HoSoBenhNhan WHERE MaHoSoBenhNhan = @MaHoSoBenhNhan
    ELSE IF @ParamName = 'MaTaiKhoan'
        SELECT @Result = MaTaiKhoan FROM HoSoBenhNhan WHERE MaHoSoBenhNhan = @MaHoSoBenhNhan
    ELSE IF @ParamName = 'NgaySinh'
        SELECT @Result = CONVERT(varchar(10), NgaySinh, 120) FROM HoSoBenhNhan WHERE MaHoSoBenhNhan = @MaHoSoBenhNhan
    ELSE IF @ParamName = 'GioiTinh'
        SELECT @Result = GioiTinh FROM HoSoBenhNhan WHERE MaHoSoBenhNhan = @MaHoSoBenhNhan
    ELSE IF @ParamName = 'CCCD'
        SELECT @Result = CCCD FROM HoSoBenhNhan WHERE MaHoSoBenhNhan = @MaHoSoBenhNhan
    ELSE IF @ParamName = 'MaBHYT'
        SELECT @Result = MaBHYT FROM HoSoBenhNhan WHERE MaHoSoBenhNhan = @MaHoSoBenhNhan
    ELSE IF @ParamName = 'NgheNghiep'
        SELECT @Result = NgheNghiep FROM HoSoBenhNhan WHERE MaHoSoBenhNhan = @MaHoSoBenhNhan
    ELSE IF @ParamName = 'SoDienThoai'
        SELECT @Result = SoDienThoai FROM HoSoBenhNhan WHERE MaHoSoBenhNhan = @MaHoSoBenhNhan
    ELSE IF @ParamName = 'Email'
        SELECT @Result = Email FROM HoSoBenhNhan WHERE MaHoSoBenhNhan = @MaHoSoBenhNhan
    ELSE IF @ParamName = 'DiaChi'
        SELECT @Result = DiaChi FROM HoSoBenhNhan WHERE MaHoSoBenhNhan = @MaHoSoBenhNhan
    ELSE
        SET @Result = 'Invalid Parameter'
    RETURN @Result
END
--**********************TRIGGER
CREATE TRIGGER trg_GenerateMaHoSoBenhNhan
ON HoSoBenhNhan
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE HoSoBenhNhan
    SET MaHoSoBenhNhan = 'HSBN' + RIGHT('00000000' + CAST(id AS VARCHAR(8)), 8)
    FROM HoSoBenhNhan
    INNER JOIN INSERTED ON HoSoBenhNhan.Id = INSERTED.Id
    WHERE HoSoBenhNhan.MaHoSoBenhNhan IS NULL
END


--/////////////////////// So kham benh
CREATE TABLE SoKhamBenh
(
	MaHoSoBenhNhan varchar(8) NOT NULL,
	MaLichKham varchar(8) NOT NULL,
	HoVaTen nvarchar(30),
	Tuoi varchar(3),
	SoTheBHYT varchar(15),
	DiaChi nvarchar(50),
	NgheNghiep nvarchar(30),
	DanToc nvarchar(10),
	TrieuChung nvarchar(50),
	ChanDoan nvarchar(50),
	PhuongPhapDieuTri nvarchar(50),
	BSKhamBenh nvarchar(30),
	GhiChu nvarchar(50)
)
ALTER TABLE SoKhamBenh ADD CONSTRAINT PK_SoKhamBenh PRIMARY KEY (MaHoSoBenhNhan, MaLichKham)
ALTER TABLE SoKhamBenh ADD CONSTRAINT FK_SoKhamBenhHoSoBenhNhan FOREIGN KEY (MaHoSoBenhNhan) REFERENCES HoSoBenhNhan(MaHoSoBenhNhan);
CREATE FUNCTION GetSoKhamBenhByParam(@MaHoSoBenhNhan varchar(8), @MaLichKham varchar(8), @ParamName varchar(50)) RETURNS varchar(50)
AS
BEGIN
    DECLARE @Result varchar(50)
    IF @ParamName = 'HoVaTen'
        SELECT @Result = HoVaTen FROM SoKhamBenh WHERE MaHoSoBenhNhan = @MaHoSoBenhNhan AND MaLichKham = @MaLichKham
    ELSE IF @ParamName = 'Tuoi'
        SELECT @Result = Tuoi FROM SoKhamBenh WHERE MaHoSoBenhNhan = @MaHoSoBenhNhan AND MaLichKham = @MaLichKham
    ELSE IF @ParamName = 'SoTheBHYT'
        SELECT @Result = SoTheBHYT FROM SoKhamBenh WHERE MaHoSoBenhNhan = @MaHoSoBenhNhan AND MaLichKham = @MaLichKham
    ELSE IF @ParamName = 'DiaChi'
        SELECT @Result = DiaChi FROM SoKhamBenh WHERE MaHoSoBenhNhan = @MaHoSoBenhNhan AND MaLichKham = @MaLichKham
    ELSE IF @ParamName = 'NgheNghiep'
        SELECT @Result = NgheNghiep FROM SoKhamBenh WHERE MaHoSoBenhNhan = @MaHoSoBenhNhan AND MaLichKham = @MaLichKham
    ELSE IF @ParamName = 'DanToc'
        SELECT @Result = DanToc FROM SoKhamBenh WHERE MaHoSoBenhNhan = @MaHoSoBenhNhan AND MaLichKham = @MaLichKham
    ELSE IF @ParamName = 'TrieuChung'
        SELECT @Result = TrieuChung FROM SoKhamBenh WHERE MaHoSoBenhNhan = @MaHoSoBenhNhan AND MaLichKham = @MaLichKham
    ELSE IF @ParamName = 'ChanDoan'
        SELECT @Result = ChanDoan FROM SoKhamBenh WHERE MaHoSoBenhNhan = @MaHoSoBenhNhan AND MaLichKham = @MaLichKham
    ELSE IF @ParamName = 'PhuongPhapDieuTri'
        SELECT @Result = PhuongPhapDieuTri FROM SoKhamBenh WHERE MaHoSoBenhNhan = @MaHoSoBenhNhan AND MaLichKham = @MaLichKham
    ELSE IF @ParamName = 'BSKhamBenh'
        SELECT @Result = BSKhamBenh FROM SoKhamBenh WHERE MaHoSoBenhNhan = @MaHoSoBenhNhan AND MaLichKham = @MaLichKham
    ELSE IF @ParamName = 'GhiChu'
        SELECT @Result = GhiChu FROM SoKhamBenh WHERE MaHoSoBenhNhan = @MaHoSoBenhNhan AND MaLichKham = @MaLichKham
    ELSE
        SET @Result = 'Invalid Parameter'
    RETURN @Result
END
--**********************TRIGGER
CREATE TRIGGER trg_GenerateMaSoKhamBenh
ON SoKhamBenh
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE SoKhamBenh
    SET MaLichKham = 'SKB' + RIGHT('00000000' + CAST(id AS VARCHAR(8)), 8)
    FROM SoKhamBenh
    INNER JOIN INSERTED ON SoKhamBenh.Id = INSERTED.Id
    WHERE SoKhamBenh.MaLichKham IS NULL
END


--////////////////// Benh An
CREATE TABLE BenhAn
(
	MaBenhAn varchar(8) NOT NULL,
	MaHoSoBenhNhan varchar(8),
	DoiTuong nvarchar(8),
	GiaTriBHYT date,
	HoTenThanNhan nvarchar(30),
	ThoiGianVaoVien nvarchar(30),
	TrucTiepVao nvarchar(30),
	NoiGioiThieu nvarchar(30),
	VaoKhoa nvarchar(30),
	ChuyenKhoa nvarchar(30),
	TongSoNgayDieuTri varchar(3),
	NoiChuyenDen nvarchar(30),
	KKBorCapCuu nvarchar(30),
	KhiVaoKhoaDieuTri nvarchar(30),
	KetQuaDieuTri nvarchar(30),
	GiaiPhauBenh nvarchar(30),
	QuaTrinhBenhLy nvarchar(30),
	TienSuBenh nvarchar(30),
	ToaThan nvarchar(30),
	TrieuChungCoNang nvarchar(30),
	ThuongTonCanBan nvarchar(30),
	CacCoQuan nvarchar(30),
	TKetQuaTrinhBenhLy nvarchar(30),
	TomTatKQXN nvarchar(30),
	PhuongPhapDieuTri nvarchar(30),
	HoSoPhimAnh nvarchar(30)
)
ALTER TABLE BenhAn ADD CONSTRAINT PK_BenhAn PRIMARY KEY (MaBenhAn)
ALTER TABLE BenhAn ADD CONSTRAINT FK_BenhAnHoSoBenhNhan FOREIGN KEY (MaHoSoBenhNhan) REFERENCES HoSoBenhNhan(MaHoSoBenhNhan)
CREATE FUNCTION GetBenhAnByParam(@MaBenhAn varchar(8), @ParamName varchar(50)) RETURNS varchar(50)
AS
BEGIN
    DECLARE @Result varchar(50)
    IF @ParamName = 'MaHoSoBenhNhan'
        SELECT @Result = MaHoSoBenhNhan FROM BenhAn WHERE MaBenhAn = @MaBenhAn
    ELSE IF @ParamName = 'DoiTuong'
        SELECT @Result = DoiTuong FROM BenhAn WHERE MaBenhAn = @MaBenhAn
    ELSE IF @ParamName = 'GiaTriBHYT'
        SELECT @Result = CONVERT(varchar(10), GiaTriBHYT, 120) FROM BenhAn WHERE MaBenhAn = @MaBenhAn
    ELSE IF @ParamName = 'HoTenThanNhan'
        SELECT @Result = HoTenThanNhan FROM BenhAn WHERE MaBenhAn = @MaBenhAn
    ELSE IF @ParamName = 'ThoiGianVaoVien'
        SELECT @Result = ThoiGianVaoVien FROM BenhAn WHERE MaBenhAn = @MaBenhAn
    ELSE IF @ParamName = 'TrucTiepVao'
        SELECT @Result = TrucTiepVao FROM BenhAn WHERE MaBenhAn = @MaBenhAn
    ELSE IF @ParamName = 'NoiGioiThieu'
        SELECT @Result = NoiGioiThieu FROM BenhAn WHERE MaBenhAn = @MaBenhAn
    ELSE IF @ParamName = 'VaoKhoa'
        SELECT @Result = VaoKhoa FROM BenhAn WHERE MaBenhAn = @MaBenhAn
    ELSE IF @ParamName = 'ChuyenKhoa'
        SELECT @Result = ChuyenKhoa FROM BenhAn WHERE MaBenhAn = @MaBenhAn
    ELSE IF @ParamName = 'TongSoNgayDieuTri'
        SELECT @Result = TongSoNgayDieuTri FROM BenhAn WHERE MaBenhAn = @MaBenhAn
    ELSE IF @ParamName = 'NoiChuyenDen'
        SELECT @Result = NoiChuyenDen FROM BenhAn WHERE MaBenhAn = @MaBenhAn
    ELSE IF @ParamName = 'KKBorCapCuu'
        SELECT @Result = KKBorCapCuu FROM BenhAn WHERE MaBenhAn = @MaBenhAn
    ELSE IF @ParamName = 'KhiVaoKhoaDieuTri'
        SELECT @Result = KhiVaoKhoaDieuTri FROM BenhAn WHERE MaBenhAn = @MaBenhAn
    ELSE IF @ParamName = 'KetQuaDieuTri'
        SELECT @Result = KetQuaDieuTri FROM BenhAn WHERE MaBenhAn = @MaBenhAn
    ELSE IF @ParamName = 'GiaiPhauBenh'
        SELECT @Result = GiaiPhauBenh FROM BenhAn WHERE MaBenhAn = @MaBenhAn
    ELSE IF @ParamName = 'QuaTrinhBenhLy'
        SELECT @Result = QuaTrinhBenhLy FROM BenhAn WHERE MaBenhAn = @MaBenhAn
    ELSE IF @ParamName = 'TienSuBenh'
        SELECT @Result = TienSuBenh FROM BenhAn WHERE MaBenhAn = @MaBenhAn
    ELSE IF @ParamName = 'ToaThan'
        SELECT @Result = ToaThan FROM BenhAn WHERE MaBenhAn = @MaBenhAn
    ELSE IF @ParamName = 'TrieuChungCoNang'
        SELECT @Result = TrieuChungCoNang FROM BenhAn WHERE MaBenhAn = @MaBenhAn
    ELSE IF @ParamName = 'ThuongTonCanBan'
        SELECT @Result = ThuongTonCanBan FROM BenhAn WHERE MaBenhAn = @MaBenhAn
    ELSE IF @ParamName = 'CacCoQuan'
        SELECT @Result = CacCoQuan FROM BenhAn WHERE MaBenhAn = @MaBenhAn
    ELSE IF @ParamName = 'TKetQuaTrinhBenhLy'
        SELECT @Result = TKetQuaTrinhBenhLy FROM BenhAn WHERE MaBenhAn = @MaBenhAn
    ELSE IF @ParamName = 'TomTatKQXN'
        SELECT @Result = TomTatKQXN FROM BenhAn WHERE MaBenhAn = @MaBenhAn
    ELSE IF @ParamName = 'PhuongPhapDieuTri'
        SELECT @Result = PhuongPhapDieuTri FROM BenhAn WHERE MaBenhAn = @MaBenhAn
    ELSE IF @ParamName = 'HoSoPhimAnh'
        SELECT @Result = HoSoPhimAnh FROM BenhAn WHERE MaBenhAn = @MaBenhAn
    ELSE
        SET @Result = 'Invalid Parameter'
    RETURN @Result
END
--**********************TRIGGER
CREATE TRIGGER trg_GenerateMaBenhAn
ON BenhAn
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE BenhAn
    SET MaBenhAn = 'BA' + RIGHT('00000000' + CAST(id AS VARCHAR(8)), 8)
    FROM BenhAn
    INNER JOIN INSERTED ON BenhAn.Id = INSERTED.Id
    WHERE BenhAn.MaBenhAn IS NULL
END


--/////////////////// Toa Thuoc
CREATE TABLE ToaThuoc
(
	SoThuTu varchar(10),
	MaToaThuoc varchar(8) NOT NULL,
	MaThuoc varchar(8) NOT NULL,
	MaBenhAn varchar(8),
	TenThuoc nvarchar(30),
	SoLuong tinyint,
	Dang nvarchar(10),
	GhiChu nvarchar(50)
)
ALTER TABLE ToaThuoc ADD CONSTRAINT PK_ToaThuoc PRIMARY KEY (MaToaThuoc, MaThuoc)
ALTER TABLE ToaThuoc ADD CONSTRAINT FK_ToaThuocBenhAn FOREIGN KEY (MaBenhAn) REFERENCES BenhAn(MaBenhAn)
CREATE FUNCTION GetToaThuocByParam(@MaToaThuoc varchar(8), @ParamName varchar(50)) RETURNS nvarchar(50)
AS
BEGIN
    DECLARE @Result nvarchar(50)
    IF @ParamName = 'SoThuTu'
        SELECT @Result = SoThuTu FROM ToaThuoc WHERE MaToaThuoc = @MaToaThuoc
    ELSE IF @ParamName = 'MaThuoc'
        SELECT @Result = MaThuoc FROM ToaThuoc WHERE MaToaThuoc = @MaToaThuoc
    ELSE IF @ParamName = 'MaBenhAn'
        SELECT @Result = MaBenhAn FROM ToaThuoc WHERE MaToaThuoc = @MaToaThuoc
    ELSE IF @ParamName = 'TenThuoc'
        SELECT @Result = TenThuoc FROM ToaThuoc WHERE MaToaThuoc = @MaToaThuoc
    ELSE IF @ParamName = 'SoLuong'
        SELECT @Result = CONVERT(nvarchar(50), SoLuong) FROM ToaThuoc WHERE MaToaThuoc = @MaToaThuoc
    ELSE IF @ParamName = 'Dang'
        SELECT @Result = Dang FROM ToaThuoc WHERE MaToaThuoc = @MaToaThuoc
    ELSE IF @ParamName = 'GhiChu'
        SELECT @Result = GhiChu FROM ToaThuoc WHERE MaToaThuoc = @MaToaThuoc
    ELSE
        SET @Result = 'Invalid Parameter'
    RETURN @Result
END
--**********************TRIGGER
CREATE TRIGGER trg_GenerateMaToaThuoc
ON ToaThuoc
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE ToaThuoc
    SET MaToaThuoc = 'TT' + RIGHT('00000000' + CAST(id AS VARCHAR(8)), 8)
    FROM ToaThuoc
    INNER JOIN INSERTED ON ToaThuoc.Id = INSERTED.Id
    WHERE ToaThuoc.MaToaThuoc IS NULL
END


--///////////////////// Hoa Don
CREATE TABLE HoaDon
(
	MaHoaDon varchar(8) NOT NULL,
	MaMaHoSoBenhNhan varchar(8),
	MaLichKham varchar(8),
	TongTien int,
	HinhThucThanhToan nvarchar(30)
)
ALTER TABLE HoaDon ADD CONSTRAINT PK_HoaDon PRIMARY KEY (MaHoaDon)
ALTER TABLE HoaDon ADD CONSTRAINT FK_HoaDonHoSoBenhNhan FOREIGN KEY (MaMaHoSoBenhNhan) REFERENCES HoSoBenhNhan(MaHoSoBenhNhan)
ALTER TABLE HoaDon ADD CONSTRAINT FK_HoaDonLichKham FOREIGN KEY (MaLichKham) REFERENCES LichKham(MaLichKham)
CREATE FUNCTION GetHoaDonByParam(@MaHoaDon varchar(8), @ParamName varchar(50)) RETURNS nvarchar(50)
AS
BEGIN
    DECLARE @Result nvarchar(50)
    IF @ParamName = 'MaMaHoSoBenhNhan'
        SELECT @Result = MaMaHoSoBenhNhan FROM HoaDon WHERE MaHoaDon = @MaHoaDon
    ELSE IF @ParamName = 'MaLichKham'
        SELECT @Result = MaLichKham FROM HoaDon WHERE MaHoaDon = @MaHoaDon
    ELSE IF @ParamName = 'TongTien'
        SELECT @Result = CONVERT(nvarchar(50), TongTien) FROM HoaDon WHERE MaHoaDon = @MaHoaDon
    ELSE IF @ParamName = 'HinhThucThanhToan'
        SELECT @Result = HinhThucThanhToan FROM HoaDon WHERE MaHoaDon = @MaHoaDon
    ELSE
        SET @Result = 'Invalid Parameter'
    RETURN @Result
END
--**********************TRIGGER
CREATE TRIGGER trg_GenerateMaHoaDon
ON HoaDon
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE HoaDon
    SET MaHoaDon = 'HD' + RIGHT('00000000' + CAST(id AS VARCHAR(8)), 8)
    FROM HoaDon
    INNER JOIN INSERTED ON HoaDon.Id = INSERTED.Id
    WHERE HoaDon.MaHoaDon IS NULL
END


--/////////////////////// Khuyen Mai
CREATE TABLE KhuyenMai
(
	MaKhuyenMai varchar(8) NOT NULL,
	TenChuongTrinhKM nvarchar(30),
	NoiDungKM nvarchar(50),
	ThoiGianBatDau datetime,
	ThoiGianKetThuc datetime
)
ALTER TABLE KhuyenMai ADD CONSTRAINT PK_KhuyenMai PRIMARY KEY (MaKhuyenMai)
CREATE FUNCTION GetKhuyenMaiByParam(@MaKhuyenMai varchar(8), @ParamName varchar(50)) RETURNS nvarchar(50)
AS
BEGIN
    DECLARE @Result nvarchar(50)
    IF @ParamName = 'TenChuongTrinhKM'
        SELECT @Result = TenChuongTrinhKM FROM KhuyenMai WHERE MaKhuyenMai = @MaKhuyenMai
    ELSE IF @ParamName = 'NoiDungKM'
        SELECT @Result = NoiDungKM FROM KhuyenMai WHERE MaKhuyenMai = @MaKhuyenMai
    ELSE IF @ParamName = 'ThoiGianBatDau'
        SELECT @Result = CONVERT(nvarchar(50), ThoiGianBatDau, 121) FROM KhuyenMai WHERE MaKhuyenMai = @MaKhuyenMai
    ELSE IF @ParamName = 'ThoiGianKetThuc'
        SELECT @Result = CONVERT(nvarchar(50), ThoiGianKetThuc, 121) FROM KhuyenMai WHERE MaKhuyenMai = @MaKhuyenMai
    ELSE
        SET @Result = 'Invalid Parameter'
    RETURN @Result
END
--**********************TRIGGER
CREATE TRIGGER trg_GenerateMaKhuyenMai
ON KhuyenMai
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE KhuyenMai
    SET MaKhuyenMai = 'KM' + RIGHT('00000000' + CAST(id AS VARCHAR(8)), 8)
    FROM KhuyenMai
    INNER JOIN INSERTED ON KhuyenMai.Id = INSERTED.Id
    WHERE KhuyenMai.MaKhuyenMai IS NULL
END


--/////////////// Dich Vu
CREATE TABLE DichVu
(
	MaDichVu varchar(8) NOT NULL,
	TenDichVu nvarchar(30),
	NoiDungDichVu nvarchar(50),
	GiaDichVu int
)
ALTER TABLE DichVu ADD CONSTRAINT PK_DichVu PRIMARY KEY (MaDichVu)
CREATE FUNCTION GetDichVuByParam(@MaDichVu varchar(8), @ParamName varchar(50)) RETURNS nvarchar(50)
AS
BEGIN
    DECLARE @Result nvarchar(50)
    IF @ParamName = 'TenDichVu'
        SELECT @Result = TenDichVu FROM DichVu WHERE MaDichVu = @MaDichVu
    ELSE IF @ParamName = 'NoiDungDichVu'
        SELECT @Result = NoiDungDichVu FROM DichVu WHERE MaDichVu = @MaDichVu
    ELSE IF @ParamName = 'GiaDichVu'
        SELECT @Result = CONVERT(nvarchar(50), GiaDichVu) FROM DichVu WHERE MaDichVu = @MaDichVu
    ELSE
        SET @Result = 'Invalid Parameter'
    RETURN @Result
END
--**********************TRIGGER
CREATE TRIGGER trg_GenerateMaDichVu
ON DichVu
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE DichVu
    SET MaDichVu = 'DV' + RIGHT('00000000' + CAST(id AS VARCHAR(8)), 8)
    FROM DichVu
    INNER JOIN INSERTED ON DichVu.Id = INSERTED.Id
    WHERE DichVu.MaDichVu IS NULL
END


--///////////////// Chuyen Khoa
CREATE TABLE ChuyenKhoa
(
	MaChuyenKhoa varchar(8) NOT NULL,
	TenChuyenKhoa nvarchar(30),
	MaKhuyenMai varchar(8)
)
ALTER TABLE ChuyenKhoa ADD CONSTRAINT PK_ChuyenKhoa PRIMARY KEY (MaChuyenKhoa)
CREATE FUNCTION GetChuyenKhoaByParam(@MaChuyenKhoa varchar(8), @ParamName varchar(50)) RETURNS nvarchar(50)
AS
BEGIN
    DECLARE @Result nvarchar(50)
    IF @ParamName = 'TenChuyenKhoa'
        SELECT @Result = TenChuyenKhoa FROM ChuyenKhoa WHERE MaChuyenKhoa = @MaChuyenKhoa
    ELSE IF @ParamName = 'MaKhuyenMai'
        SELECT @Result = MaKhuyenMai FROM ChuyenKhoa WHERE MaChuyenKhoa = @MaChuyenKhoa
    ELSE
        SET @Result = 'Invalid Parameter'
    RETURN @Result
END
--**********************TRIGGER
CREATE TRIGGER trg_GenerateMaChuyenKhoa
ON ChuyenKhoa
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE ChuyenKhoa
    SET MaChuyenKhoa = 'CK' + RIGHT('00000000' + CAST(id AS VARCHAR(8)), 8)
    FROM ChuyenKhoa
    INNER JOIN INSERTED ON ChuyenKhoa.Id = INSERTED.Id
    WHERE ChuyenKhoa.MaChuyenKhoa IS NULL
END


--/////////////// LichKham
CREATE TABLE LichKham
(
	MaLichKham varchar(8) NOT NULL,
	MaHoSoBenhNhan varchar(8),
	MaChuyenKhoa varchar(8),
	MaDichVu varchar(8),
	NgayDangKy date,
	Ca nvarchar(15),
	KhungGioKham datetime
)
ALTER TABLE LichKham ADD CONSTRAINT PK_LichKham PRIMARY KEY (MaLichKham)
ALTER TABLE LichKham ADD CONSTRAINT FK_LichKhamHoSoBenhNhan FOREIGN KEY (MaHoSoBenhNhan) REFERENCES HoSoBenhNhan(MaHoSoBenhNhan)
ALTER TABLE LichKham ADD CONSTRAINT FK_LichKhamHoSoBenhNhan FOREIGN KEY (MaHoSoBenhNhan) REFERENCES HoSoBenhNhan(MaHoSoBenhNhan)
ALTER TABLE LichKham ADD CONSTRAINT FK_LichKhamChuyenKhoa FOREIGN KEY (MaChuyenKhoa) REFERENCES ChuyenKhoa(MaChuyenKhoa)
ALTER TABLE LichKham ADD CONSTRAINT FK_LichKhamDichVu FOREIGN KEY (MaDichVu) REFERENCES DichVu(MaDichVu)
CREATE FUNCTION GetLichKhamByParam(@MaLichKham varchar(8), @ParamName varchar(50)) RETURNS nvarchar(50)
AS
BEGIN
    DECLARE @Result nvarchar(50)
    IF @ParamName = 'MaHoSoBenhNhan'
        SELECT @Result = MaHoSoBenhNhan FROM LichKham WHERE MaLichKham = @MaLichKham
    ELSE IF @ParamName = 'MaChuyenKhoa'
        SELECT @Result = MaChuyenKhoa FROM LichKham WHERE MaLichKham = @MaLichKham
    ELSE IF @ParamName = 'MaDichVu'
        SELECT @Result = MaDichVu FROM LichKham WHERE MaLichKham = @MaLichKham
    ELSE IF @ParamName = 'NgayDangKy'
        SELECT @Result = CONVERT(nvarchar(50), NgayDangKy, 121) FROM LichKham WHERE MaLichKham = @MaLichKham
    ELSE IF @ParamName = 'Ca'
        SELECT @Result = Ca FROM LichKham WHERE MaLichKham = @MaLichKham
    ELSE IF @ParamName = 'KhungGioKham'
        SELECT @Result = CONVERT(nvarchar(50), KhungGioKham, 121) FROM LichKham WHERE MaLichKham = @MaLichKham
    ELSE
        SET @Result = 'Invalid Parameter'
    RETURN @Result
END
--**********************TRIGGER
CREATE TRIGGER trg_GenerateMaLichKham
ON LichKham
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE LichKham
    SET MaLichKham = 'LK' + RIGHT('00000000' + CAST(id AS VARCHAR(8)), 8)
    FROM LichKham
    INNER JOIN INSERTED ON LichKham.Id = INSERTED.Id
    WHERE LichKham.MaLichKham IS NULL
END


--/////////////// ADMIN
CREATE TABLE ADMIN_Manager
(
	MaAdmin varchar(8) NOT NULL,
	MatKhau varchar(8),
)
ALTER TABLE ADMIN_Manager ADD CONSTRAINT PK_ADMINMananger PRIMARY KEY (MaAdmin)
CREATE FUNCTION GetAdminManagerByParam(@MaAdmin varchar(8), @ParamName varchar(50)) RETURNS nvarchar(50)
AS
BEGIN
    DECLARE @Result nvarchar(50)
    IF @ParamName = 'MatKhau'
        SELECT @Result = MatKhau FROM ADMIN_Manager WHERE MaAdmin = @MaAdmin
    ELSE
        SET @Result = 'Invalid Parameter'
    RETURN @Result
END
--**********************TRIGGER


--/////////////////// Tai khoan thanh vien
CREATE TABLE TaiKhoanThanhVien
(
	HoVaTen nvarchar(30),
	MaThanhVien varchar(8) NOT NULL,
	MatKhau varchar(8),
	NgaySinh date,
	GioiTinh nvarchar(3),
	CCCD varchar(12),
	SoDienThoai varchar(10),
	Email varchar(30),
	DiaChi nvarchar(50),
	ChuyenKhoa nvarchar(30),
	ViTri nvarchar(30),
	LoaiTaiKhoan varchar(10)
)
ALTER TABLE TaiKhoanThanhVien ADD CONSTRAINT PK_TaiKhoanThanhVien PRIMARY KEY (MaThanhVien)
CREATE FUNCTION GetTaiKhoanThanhVienByParam(@MaThanhVien varchar(8), @ParamName varchar(50)) RETURNS nvarchar(50)
AS
BEGIN
    DECLARE @Result nvarchar(50)
    IF @ParamName = 'HoVaTen'
        SELECT @Result = HoVaTen FROM TaiKhoanThanhVien WHERE MaThanhVien = @MaThanhVien
    ELSE IF @ParamName = 'MatKhau'
        SELECT @Result = MatKhau FROM TaiKhoanThanhVien WHERE MaThanhVien = @MaThanhVien
    ELSE IF @ParamName = 'NgaySinh'
        SELECT @Result = CONVERT(nvarchar(50), NgaySinh, 121) FROM TaiKhoanThanhVien WHERE MaThanhVien = @MaThanhVien
    ELSE IF @ParamName = 'GioiTinh'
        SELECT @Result = GioiTinh FROM TaiKhoanThanhVien WHERE MaThanhVien = @MaThanhVien
    ELSE IF @ParamName = 'CCCD'
        SELECT @Result = CCCD FROM TaiKhoanThanhVien WHERE MaThanhVien = @MaThanhVien
    ELSE IF @ParamName = 'SoDienThoai'
        SELECT @Result = SoDienThoai FROM TaiKhoanThanhVien WHERE MaThanhVien = @MaThanhVien
    ELSE IF @ParamName = 'Email'
        SELECT @Result = Email FROM TaiKhoanThanhVien WHERE MaThanhVien = @MaThanhVien
    ELSE IF @ParamName = 'DiaChi'
        SELECT @Result = DiaChi FROM TaiKhoanThanhVien WHERE MaThanhVien = @MaThanhVien
    ELSE IF @ParamName = 'ChuyenKhoa'
        SELECT @Result = ChuyenKhoa FROM TaiKhoanThanhVien WHERE MaThanhVien = @MaThanhVien
    ELSE IF @ParamName = 'ViTri'
        SELECT @Result = ViTri FROM TaiKhoanThanhVien WHERE MaThanhVien = @MaThanhVien
    ELSE IF @ParamName = 'LoaiTaiKhoan'
        SELECT @Result = LoaiTaiKhoan FROM TaiKhoanThanhVien WHERE MaThanhVien = @MaThanhVien
    ELSE
        SET @Result = 'Invalid Parameter'
    RETURN @Result
END
--**********************TRIGGER
CREATE TRIGGER trg_GenerateMaThanhVien
ON TaiKhoanThanhVien
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE TaiKhoanThanhVien
    SET MaThanhVien = 'TV' + RIGHT('00000000' + CAST(id AS VARCHAR(8)), 8)
    FROM TaiKhoanThanhVien
    INNER JOIN INSERTED ON TaiKhoanThanhVien.Id = INSERTED.Id
    WHERE TaiKhoanThanhVien.MaThanhVien IS NULL
END


--//////////////////// Lich lam viec
CREATE TABLE LichLamViec
(
	MaLichLamViec varchar(8) NOT NULL,
	HoVaTen nvarchar(30),
	MaThanhVien varchar(8),
	Thang date,
	Ngay date,
	Ca varchar(2)
)
ALTER TABLE LichLamViec ADD CONSTRAINT PK_LichLamViec PRIMARY KEY (MaLichLamViec)
ALTER TABLE LichLamViec ADD CONSTRAINT FK_LichViecTaiKhoanThanhVien FOREIGN KEY (MaThanhVien) REFERENCES TaiKhoanThanhVien(MaThanhVien)
CREATE FUNCTION GetLichLamViecByParam(@MaLichLamViec varchar(8), @ParamName varchar(50)) RETURNS nvarchar(50)
AS
BEGIN
    DECLARE @Result nvarchar(50)
    IF @ParamName = 'HoVaTen'
        SELECT @Result = HoVaTen FROM LichLamViec WHERE MaLichLamViec = @MaLichLamViec
    ELSE IF @ParamName = 'MaThanhVien'
        SELECT @Result = MaThanhVien FROM LichLamViec WHERE MaLichLamViec = @MaLichLamViec
    ELSE IF @ParamName = 'Thang'
        SELECT @Result = CONVERT(nvarchar(50), Thang, 121) FROM LichLamViec WHERE MaLichLamViec = @MaLichLamViec
    ELSE IF @ParamName = 'Ngay'
        SELECT @Result = CONVERT(nvarchar(50), Ngay, 121) FROM LichLamViec WHERE MaLichLamViec = @MaLichLamViec
    ELSE IF @ParamName = 'Ca'
        SELECT @Result = Ca FROM LichLamViec WHERE MaLichLamViec = @MaLichLamViec
    ELSE
        SET @Result = 'Invalid Parameter'
    RETURN @Result
END
--**********************TRIGGER
CREATE TRIGGER trg_GenerateMaLichLamViec
ON LichLamViec
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE LichLamViec
    SET MaLichLamViec = 'LLV' + RIGHT('00000000' + CAST(id AS VARCHAR(8)), 8)
    FROM LichLamViec
    INNER JOIN INSERTED ON LichLamViec.Id = INSERTED.Id
    WHERE LichLamViec.MaLichLamViec IS NULL
END

