use master
go
CREATE DATABASE PHONGKHAMDALIEU
go
--//////////////////////////// dtb
USE PHONGKHAMDALIEU
go
--DROP DATABASE PHONGKHAMDALIEU
--////////////////////////////
-- TAO BANG --
CREATE TABLE DangKyUser
(
	SoDienThoai varchar(10) NOT NULL,
	MatKhau varchar(8),
)
ALTER TABLE DangKyUser ADD PRIMARY KEY (SoDienThoai)
go
--=================FUNCTION
CREATE FUNCTION SelectDangKyUser (@SoDienThoai varchar(10))
RETURNS TABLE
AS
RETURN (
    SELECT *
    FROM DangKyUser
    WHERE SoDienThoai = @SoDienThoai
);

go
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
go
--#####################PROCEDURE INSERT
CREATE PROCEDURE DangKyUser_Insert
    @SoDienThoai varchar(10),
    @MatKhau varchar(8)
AS
BEGIN
    INSERT INTO DangKyUser (SoDienThoai, MatKhau)
    VALUES (@SoDienThoai, @MatKhau)
END
go
CREATE PROCEDURE UpdateDangKyUser
    @SoDienThoai varchar(10),
    @MatKhau varchar(8)
AS
BEGIN
    UPDATE DangKyUser
    SET MatKhau = @MatKhau
    WHERE SoDienThoai = @SoDienThoai;
END
go
CREATE PROCEDURE DeleteDangKyUser
    @SoDienThoai varchar(10)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM DangKyUser WHERE SoDienThoai = @SoDienThoai)
    BEGIN
        DELETE FROM DangKyUser WHERE SoDienThoai = @SoDienThoai;
        PRINT 'Bản ghi đã được xóa thành công.';
    END
    ELSE
    BEGIN
        PRINT 'Không tìm thấy bản ghi với SoDienThoai = ' + @SoDienThoai;
    END
END
go
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
ALTER TABLE HoSoBenhNhan ADD CONSTRAINT FK_HoSoBenhNhanUser FOREIGN KEY (MaTaiKhoan) REFERENCES DangKyUser(SoDienThoai) ON DELETE CASCADE
go
--=================FUNCTION
CREATE FUNCTION SelectHoSoBenhNhan (@MaHoSoBenhNhan varchar(8))
RETURNS TABLE
AS
RETURN (
    SELECT *
    FROM HoSoBenhNhan
    WHERE MaHoSoBenhNhan = @MaHoSoBenhNhan
);

go
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
--#########INSERT
go
CREATE PROCEDURE UpdateHoSoBenhNhan
    @MaHoSoBenhNhan varchar(8),
    @HoVaTen nvarchar(30),
    @MaTaiKhoan varchar(10),
    @NgaySinh date,
    @GioiTinh nvarchar(3),
    @CCCD varchar(12),
    @MaBHYT varchar(15),
    @NgheNghiep nvarchar(30),
    @SoDienThoai varchar(10),
    @Email varchar(30),
    @DiaChi nvarchar(50)
AS
BEGIN
    UPDATE HoSoBenhNhan
    SET 
        HoVaTen = @HoVaTen,
        MaTaiKhoan = @MaTaiKhoan,
        NgaySinh = @NgaySinh,
        GioiTinh = @GioiTinh,
        CCCD = @CCCD,
        MaBHYT = @MaBHYT,
        NgheNghiep = @NgheNghiep,
        SoDienThoai = @SoDienThoai,
        Email = @Email,
        DiaChi = @DiaChi
    WHERE MaHoSoBenhNhan = @MaHoSoBenhNhan;
END
go
CREATE PROCEDURE DeleteHoSoBenhNhan
    @MaHoSoBenhNhan varchar(8)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM HoSoBenhNhan WHERE MaHoSoBenhNhan = @MaHoSoBenhNhan)
    BEGIN
        DELETE FROM HoSoBenhNhan WHERE MaHoSoBenhNhan = @MaHoSoBenhNhan;
        PRINT 'Bản ghi đã được xóa thành công.';
    END
    ELSE
    BEGIN
        PRINT 'Không tìm thấy bản ghi với MaHoSoBenhNhan = ' + @MaHoSoBenhNhan;
    END
END
go

--**********************TRIGGER



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
ALTER TABLE SoKhamBenh ADD CONSTRAINT FK_SoKhamBenhHoSoBenhNhan FOREIGN KEY (MaHoSoBenhNhan) REFERENCES HoSoBenhNhan(MaHoSoBenhNhan) ON DELETE CASCADE;
go
--=================FUNCTION
CREATE FUNCTION SelectSoKhamBenh (@MaHoSoBenhNhan varchar(8), @MaLichKham varchar(8))
RETURNS TABLE
AS
RETURN (
    SELECT *
    FROM SoKhamBenh
    WHERE MaHoSoBenhNhan = @MaHoSoBenhNhan AND MaLichKham = @MaLichKham
);
go

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
go

CREATE PROCEDURE UpdateSoKhamBenh
    @MaHoSoBenhNhan varchar(8),
    @MaLichKham varchar(8),
    @HoVaTen nvarchar(30),
    @Tuoi varchar(3),
    @SoTheBHYT varchar(15),
    @DiaChi nvarchar(50),
    @NgheNghiep nvarchar(30),
    @DanToc nvarchar(10),
    @TrieuChung nvarchar(50),
    @ChanDoan nvarchar(50),
    @PhuongPhapDieuTri nvarchar(50),
    @BSKhamBenh nvarchar(30),
    @GhiChu nvarchar(50)
AS
BEGIN
    UPDATE SoKhamBenh
    SET
        HoVaTen = @HoVaTen,
        Tuoi = @Tuoi,
        SoTheBHYT = @SoTheBHYT,
        DiaChi = @DiaChi,
        NgheNghiep = @NgheNghiep,
        DanToc = @DanToc,
        TrieuChung = @TrieuChung,
        ChanDoan = @ChanDoan,
        PhuongPhapDieuTri = @PhuongPhapDieuTri,
        BSKhamBenh = @BSKhamBenh,
        GhiChu = @GhiChu
    WHERE MaHoSoBenhNhan = @MaHoSoBenhNhan AND MaLichKham = @MaLichKham;
END
go
CREATE PROCEDURE DeleteSoKhamBenh
    @MaLichKham varchar(8)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM SoKhamBenh WHERE MaLichKham = @MaLichKham)
    BEGIN
        DELETE FROM SoKhamBenh WHERE MaLichKham = @MaLichKham;
        PRINT 'Bản ghi đã được xóa thành công.';
    END
    ELSE
    BEGIN
        PRINT 'Không tìm thấy bản ghi với MaLichKham = ' + @MaLichKham;
    END
END
go
--**********************TRIGGER



--////////////////// Benh An
CREATE TABLE BenhAn
(
	MaBenhAn varchar(8) NOT NULL,
	MaHoSoBenhNhan varchar(8),
	DoiTuong nvarchar(8),
	GiaTriBHYT date,
	HoTenThanNhan nvarchar(30),
	ThoiGianVaoVien date,
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
	ToanThan nvarchar(30),
	TrieuChungCoNang nvarchar(30),
	ThuongTonCanBan nvarchar(30),
	CacCoQuan nvarchar(30),
	TKetQuaTrinhBenhLy nvarchar(30),
	TomTatKQXN nvarchar(30),
	PhuongPhapDieuTri nvarchar(30),
	HoSoPhimAnh nvarchar(30)
)
ALTER TABLE BenhAn ADD CONSTRAINT PK_BenhAn PRIMARY KEY (MaBenhAn)
ALTER TABLE BenhAn ADD CONSTRAINT FK_BenhAnHoSoBenhNhan FOREIGN KEY (MaHoSoBenhNhan) REFERENCES HoSoBenhNhan(MaHoSoBenhNhan) ON DELETE CASCADE
go
--=================FUNCTION
CREATE FUNCTION SelectBenhAn (@MaBenhAn varchar(8))
RETURNS TABLE
AS
RETURN (
    SELECT *
    FROM BenhAn
    WHERE MaBenhAn = @MaBenhAn
);
go

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
    ELSE IF @ParamName = 'ToanThan'
        SELECT @Result = ToanThan FROM BenhAn WHERE MaBenhAn = @MaBenhAn
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
go
CREATE PROCEDURE UpdateBenhAn
    @MaBenhAn varchar(8),
    @MaHoSoBenhNhan varchar(8),
    @DoiTuong nvarchar(8),
    @GiaTriBHYT date,
    @HoTenThanNhan nvarchar(30),
    @ThoiGianVaoVien date,
    @TrucTiepVao nvarchar(30),
    @NoiGioiThieu nvarchar(30),
    @VaoKhoa nvarchar(30),
    @ChuyenKhoa nvarchar(30),
    @TongSoNgayDieuTri varchar(3),
    @NoiChuyenDen nvarchar(30),
    @KKBorCapCuu nvarchar(30),
    @KhiVaoKhoaDieuTri nvarchar(30),
    @KetQuaDieuTri nvarchar(30),
    @GiaiPhauBenh nvarchar(30),
    @QuaTrinhBenhLy nvarchar(30),
    @TienSuBenh nvarchar(30),
    @ToanThan nvarchar(30),
    @TrieuChungCoNang nvarchar(30),
    @ThuongTonCanBan nvarchar(30),
    @CacCoQuan nvarchar(30),
    @TKetQuaTrinhBenhLy nvarchar(30),
    @TomTatKQXN nvarchar(30),
    @PhuongPhapDieuTri nvarchar(30),
    @HoSoPhimAnh nvarchar(30)
AS
BEGIN
    UPDATE BenhAn
    SET
        MaHoSoBenhNhan = @MaHoSoBenhNhan,
        DoiTuong = @DoiTuong,
        GiaTriBHYT = @GiaTriBHYT,
        HoTenThanNhan = @HoTenThanNhan,
        ThoiGianVaoVien = @ThoiGianVaoVien,
        TrucTiepVao = @TrucTiepVao,
        NoiGioiThieu = @NoiGioiThieu,
        VaoKhoa = @VaoKhoa,
        ChuyenKhoa = @ChuyenKhoa,
        TongSoNgayDieuTri = @TongSoNgayDieuTri,
        NoiChuyenDen = @NoiChuyenDen,
        KKBorCapCuu = @KKBorCapCuu,
        KhiVaoKhoaDieuTri = @KhiVaoKhoaDieuTri,
        KetQuaDieuTri = @KetQuaDieuTri,
        GiaiPhauBenh = @GiaiPhauBenh,
        QuaTrinhBenhLy = @QuaTrinhBenhLy,
        TienSuBenh = @TienSuBenh,
        ToanThan = @ToanThan,
        TrieuChungCoNang = @TrieuChungCoNang,
        ThuongTonCanBan = @ThuongTonCanBan,
        CacCoQuan = @CacCoQuan,
        TKetQuaTrinhBenhLy = @TKetQuaTrinhBenhLy,
        TomTatKQXN = @TomTatKQXN,
        PhuongPhapDieuTri = @PhuongPhapDieuTri,
        HoSoPhimAnh = @HoSoPhimAnh
    WHERE MaBenhAn = @MaBenhAn;
END
go
CREATE PROCEDURE DeleteRecordByMaBenhAn
    @MaBenhAn varchar(8)
AS
BEGIN
    
    IF EXISTS (SELECT 1 FROM BenhAn WHERE MaBenhAn = @MaBenhAn)
    BEGIN
       
        DELETE FROM BenhAn WHERE MaBenhAn = @MaBenhAn;
        PRINT N'Bản ghi đã được xóa thành công.';
    END
    ELSE
    BEGIN
        

        PRINT N'Không tìm thấy bản ghi với MaBenhAn = ' + @MaBenhAn;
    END
END
go
--**********************TRIGGER

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
ALTER TABLE ToaThuoc ADD CONSTRAINT FK_ToaThuocBenhAn FOREIGN KEY (MaBenhAn) REFERENCES BenhAn(MaBenhAn) ON DELETE CASCADE
go
--=================FUNCTION
CREATE FUNCTION SelectToaThuoc (@MaToaThuoc varchar(8))
RETURNS TABLE
AS
RETURN (
    SELECT *
    FROM ToaThuoc
    WHERE MaToaThuoc = @MaToaThuoc
);
go

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
go
CREATE PROCEDURE UpdateToaThuoc
    @MaToaThuoc varchar(8),
    @SoThuTu varchar(10),
    @MaThuoc varchar(8),
    @MaBenhAn varchar(8),
    @TenThuoc nvarchar(30),
    @SoLuong tinyint,
    @Dang nvarchar(10),
    @GhiChu nvarchar(50)
AS
BEGIN
    UPDATE ToaThuoc
    SET 
        SoThuTu = @SoThuTu,
        MaThuoc = @MaThuoc,
        MaBenhAn = @MaBenhAn,
        TenThuoc = @TenThuoc,
        SoLuong = @SoLuong,
        Dang = @Dang,
        GhiChu = @GhiChu
    WHERE MaToaThuoc = @MaToaThuoc;
END
go
CREATE PROCEDURE DeleteToaThuoc
    @MaToaThuoc varchar(8)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM ToaThuoc WHERE MaToaThuoc = @MaToaThuoc)
    BEGIN
        DELETE FROM ToaThuoc WHERE MaToaThuoc = @MaToaThuoc;
        PRINT 'Bản ghi đã được xóa thành công.';
    END
    ELSE
    BEGIN
        PRINT 'Không tìm thấy bản ghi với MaToaThuoc = ' + @MaToaThuoc;
    END
END
go
--**********************TRIGGER



--///////////////////// Hoa Don
CREATE TABLE HoaDon
(
	MaHoaDon varchar(8) NOT NULL,
	MaLichKham varchar(8),
	TongTien int,
	HinhThucThanhToan nvarchar(30)
)
ALTER TABLE HoaDon ADD CONSTRAINT PK_HoaDon PRIMARY KEY (MaHoaDon)


go
--=================FUNCTION
CREATE FUNCTION SelectHoaDon (@MaHoaDon varchar(8))
RETURNS TABLE
AS
RETURN (
    SELECT *
    FROM HoaDon
    WHERE MaHoaDon = @MaHoaDon
);
go

CREATE FUNCTION GetHoaDonByParam(@MaHoaDon varchar(8), @ParamName varchar(50)) RETURNS nvarchar(50)
AS
BEGIN
    DECLARE @Result nvarchar(50)
    IF @ParamName = 'MaLichKham'
        SELECT @Result = MaLichKham FROM HoaDon WHERE MaHoaDon = @MaHoaDon
    ELSE IF @ParamName = 'TongTien'
        SELECT @Result = CONVERT(nvarchar(50), TongTien) FROM HoaDon WHERE MaHoaDon = @MaHoaDon
    ELSE IF @ParamName = 'HinhThucThanhToan'
        SELECT @Result = HinhThucThanhToan FROM HoaDon WHERE MaHoaDon = @MaHoaDon
    ELSE
        SET @Result = 'Invalid Parameter'
    RETURN @Result
END
go
CREATE PROCEDURE UpdateHoaDon
    @MaHoaDon varchar(8),
    @MaLichKham varchar(8),
    @TongTien int,
    @HinhThucThanhToan nvarchar(30)
AS
BEGIN
    UPDATE HoaDon
    SET 
        MaLichKham = @MaLichKham,
        TongTien = @TongTien,
        HinhThucThanhToan = @HinhThucThanhToan
    WHERE MaHoaDon = @MaHoaDon;
END
go
CREATE PROCEDURE DeleteHoaDon
    @MaHoaDon varchar(8)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM HoaDon WHERE MaHoaDon = @MaHoaDon)
    BEGIN
        DELETE FROM HoaDon WHERE MaHoaDon = @MaHoaDon;
        PRINT 'Bản ghi đã được xóa thành công.';
    END
    ELSE
    BEGIN
        PRINT 'Không tìm thấy bản ghi với MaHoaDon = ' + @MaHoaDon;
    END
END
go
--**********************TRIGGER



--/////////////////////// Khuyen Mai
CREATE TABLE KhuyenMai
(
	MaKhuyenMai varchar(8) NOT NULL,
	TenChuongTrinhKM nvarchar(30),
    GiaKhuyenMai VARCHAR(10),
	NoiDungKM nvarchar(50),
	ThoiGianBatDau datetime,
	ThoiGianKetThuc datetime
)
ALTER TABLE KhuyenMai ADD CONSTRAINT PK_KhuyenMai PRIMARY KEY (MaKhuyenMai)
go
--=================FUNCTION
CREATE FUNCTION SelectKhuyenMai (@MaKhuyenMai varchar(8))
RETURNS TABLE
AS
RETURN (
    SELECT *
    FROM KhuyenMai
    WHERE MaKhuyenMai = @MaKhuyenMai
);
go

CREATE FUNCTION GetKhuyenMaiByParam(@MaKhuyenMai varchar(8), @ParamName varchar(50)) RETURNS nvarchar(50)
AS
BEGIN
    DECLARE @Result nvarchar(50)
    IF @ParamName = 'TenChuongTrinhKM'
        SELECT @Result = TenChuongTrinhKM FROM KhuyenMai WHERE MaKhuyenMai = @MaKhuyenMai
    ELSE IF @ParamName = 'GiaKhuyenMai'
        SELECT @Result = GiaKhuyenMai FROM KhuyenMai WHERE MaKhuyenMai = @MaKhuyenMai
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
go
CREATE PROCEDURE UpdateKhuyenMai
    @MaKhuyenMai varchar(8),
    @TenChuongTrinhKM nvarchar(30),
    @GiaKhuyenMai VARCHAR(10),
    @NoiDungKM nvarchar(50),
    @ThoiGianBatDau datetime,
    @ThoiGianKetThuc datetime
AS
BEGIN
    UPDATE KhuyenMai
    SET 
        TenChuongTrinhKM = @TenChuongTrinhKM,
        GiaKhuyenMai = @GiaKhuyenMai,
        NoiDungKM = @NoiDungKM,
        ThoiGianBatDau = @ThoiGianBatDau,
        ThoiGianKetThuc = @ThoiGianKetThuc
    WHERE MaKhuyenMai = @MaKhuyenMai;
END
go
CREATE PROCEDURE DeleteKhuyenMai
    @MaKhuyenMai varchar(8)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM KhuyenMai WHERE MaKhuyenMai = @MaKhuyenMai)
    BEGIN
        DELETE FROM KhuyenMai WHERE MaKhuyenMai = @MaKhuyenMai;
        PRINT 'Bản ghi đã được xóa thành công.';
    END
    ELSE
    BEGIN
        PRINT 'Không tìm thấy bản ghi với MaKhuyenMai = ' + @MaKhuyenMai;
    END
END

go
--**********************TRIGGER



--/////////////// Dich Vu
CREATE TABLE DichVu
(
	MaDichVu varchar(8) NOT NULL,
	TenDichVu nvarchar(30),
	NoiDungDichVu nvarchar(50),
	GiaDichVu int
)
ALTER TABLE DichVu ADD CONSTRAINT PK_DichVu PRIMARY KEY (MaDichVu)
go
--=================FUNCTION
CREATE FUNCTION SelectDichVu (@MaDichVu varchar(8))
RETURNS TABLE
AS
RETURN (
    SELECT *
    FROM DichVu
    WHERE MaDichVu = @MaDichVu
);
go

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

go

CREATE PROCEDURE UpdateDichVu
    @MaDichVu varchar(8),
    @TenDichVu nvarchar(30),
    @NoiDungDichVu nvarchar(50),
    @GiaDichVu int
AS
BEGIN
    UPDATE DichVu
    SET
        TenDichVu = @TenDichVu,
        NoiDungDichVu = @NoiDungDichVu,
        GiaDichVu = @GiaDichVu
    WHERE MaDichVu = @MaDichVu;
END
go
CREATE PROCEDURE DeleteDichVu
    @MaDichVu varchar(8)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM DichVu WHERE MaDichVu = @MaDichVu)
    BEGIN
        DELETE FROM DichVu WHERE MaDichVu = @MaDichVu;
        PRINT 'Bản ghi đã được xóa thành công.';
    END
    ELSE
    BEGIN
        PRINT 'Không tìm thấy bản ghi với MaDichVu = ' + @MaDichVu;
    END
END
go
--**********************TRIGGER



--///////////////// Chuyen Khoa
CREATE TABLE ChuyenKhoa
(
	MaChuyenKhoa varchar(8) NOT NULL,
	TenChuyenKhoa nvarchar(30),
	MaKhuyenMai varchar(8)
)
ALTER TABLE ChuyenKhoa ADD CONSTRAINT PK_ChuyenKhoa PRIMARY KEY (MaChuyenKhoa)
ALTER TABLE ChuyenKhoa ALTER COLUMN TenChuyenKhoa nvarchar(200)
go
--=================FUNCTION
CREATE FUNCTION SelectChuyenKhoa (@MaChuyenKhoa varchar(8))
RETURNS TABLE
AS
RETURN (
    SELECT *
    FROM ChuyenKhoa
    WHERE MaChuyenKhoa = @MaChuyenKhoa
);
go

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
go

CREATE PROCEDURE UpdateChuyenKhoa
    @MaChuyenKhoa varchar(8),
    @TenChuyenKhoa nvarchar(30),
    @MaKhuyenMai varchar(8)
AS
BEGIN
    UPDATE ChuyenKhoa
    SET
        TenChuyenKhoa = @TenChuyenKhoa,
        MaKhuyenMai = @MaKhuyenMai
    WHERE MaChuyenKhoa = @MaChuyenKhoa;
END
go
CREATE PROCEDURE DeleteChuyenKhoa
    @MaChuyenKhoa varchar(8)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM ChuyenKhoa WHERE MaChuyenKhoa = @MaChuyenKhoa)
    BEGIN
        DELETE FROM ChuyenKhoa WHERE MaChuyenKhoa = @MaChuyenKhoa;
        PRINT 'Bản ghi đã được xóa thành công.';
    END
    ELSE
    BEGIN
        PRINT 'Không tìm thấy bản ghi với MaChuyenKhoa = ' + @MaChuyenKhoa;
    END
END

go
--**********************TRIGGER



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
ALTER TABLE HoaDon ADD CONSTRAINT FK_HoaDonLichKham FOREIGN KEY (MaLichKham) REFERENCES LichKham(MaLichKham) ON DELETE CASCADE
ALTER TABLE LichKham ADD CONSTRAINT FK_LichKhamHoSoBenhNhan FOREIGN KEY (MaHoSoBenhNhan) REFERENCES HoSoBenhNhan(MaHoSoBenhNhan) ON DELETE CASCADE
ALTER TABLE LichKham ADD CONSTRAINT FK_LichKhamChuyenKhoa FOREIGN KEY (MaChuyenKhoa) REFERENCES ChuyenKhoa(MaChuyenKhoa) ON DELETE CASCADE
ALTER TABLE LichKham ADD CONSTRAINT FK_LichKhamDichVu FOREIGN KEY (MaDichVu) REFERENCES DichVu(MaDichVu) ON DELETE CASCADE
go
--=================FUNCTION
CREATE FUNCTION SelectLichKham (@MaLichKham varchar(8))
RETURNS TABLE
AS
RETURN (
    SELECT *
    FROM LichKham
    WHERE MaLichKham = @MaLichKham
);
go

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
go
CREATE PROCEDURE UpdateLichKham
    @MaLichKham varchar(8),
    @MaHoSoBenhNhan varchar(8),
    @MaChuyenKhoa varchar(8),
    @MaDichVu varchar(8),
    @NgayDangKy date,
    @Ca nvarchar(15),
    @KhungGioKham datetime
AS
BEGIN
    UPDATE LichKham
    SET
        MaHoSoBenhNhan = @MaHoSoBenhNhan,
        MaChuyenKhoa = @MaChuyenKhoa,
        MaDichVu = @MaDichVu,
        NgayDangKy = @NgayDangKy,
        Ca = @Ca,
        KhungGioKham = @KhungGioKham
    WHERE MaLichKham = @MaLichKham;
END
go
CREATE PROCEDURE DeleteLichKham
    @MaLichKham varchar(8)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM LichKham WHERE MaLichKham = @MaLichKham)
    BEGIN
        DELETE FROM LichKham WHERE MaLichKham = @MaLichKham;
        PRINT 'Bản ghi đã được xóa thành công.';
    END
    ELSE
    BEGIN
        PRINT 'Không tìm thấy bản ghi với MaLichKham = ' + @MaLichKham;
    END
END
go
--**********************TRIGGER



--/////////////// ADMIN
CREATE TABLE ADMIN_Manager
(
	MaAdmin varchar(8) NOT NULL,
	MatKhau varchar(8),
)
ALTER TABLE ADMIN_Manager ADD CONSTRAINT PK_ADMINMananger PRIMARY KEY (MaAdmin)
go
--=================FUNCTION
CREATE FUNCTION SelectAdminManager (@MaAdmin varchar(8))
RETURNS TABLE
AS
RETURN (
    SELECT *
    FROM ADMIN_Manager
    WHERE MaAdmin = @MaAdmin
);
go

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
go

CREATE PROCEDURE UpdateAdminManager
    @MaAdmin varchar(8),
    @MatKhau varchar(8)
AS
BEGIN
    UPDATE ADMIN_Manager
    SET
        MatKhau = @MatKhau
    WHERE MaAdmin = @MaAdmin;
END
go

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
go
--=================FUNCTION
CREATE FUNCTION SelectTaiKhoanThanhVien (@MaThanhVien varchar(8))
RETURNS TABLE
AS
RETURN (
    SELECT *
    FROM TaiKhoanThanhVien
    WHERE MaThanhVien = @MaThanhVien
);
go

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
go

CREATE PROCEDURE UpdateTaiKhoanThanhVien
    @MaThanhVien varchar(8),
    @HoVaTen nvarchar(30),
    @MatKhau varchar(8),
    @NgaySinh date,
    @GioiTinh nvarchar(3),
    @CCCD varchar(12),
    @SoDienThoai varchar(10),
    @Email varchar(30),
    @DiaChi nvarchar(50),
    @ChuyenKhoa nvarchar(30),
    @ViTri nvarchar(30),
    @LoaiTaiKhoan varchar(10)
AS
BEGIN
    UPDATE TaiKhoanThanhVien
    SET
        HoVaTen = @HoVaTen,
        MatKhau = @MatKhau,
        NgaySinh = @NgaySinh,
        GioiTinh = @GioiTinh,
        CCCD = @CCCD,
        SoDienThoai = @SoDienThoai,
        Email = @Email,
        DiaChi = @DiaChi,
        ChuyenKhoa = @ChuyenKhoa,
        ViTri = @ViTri,
        LoaiTaiKhoan = @LoaiTaiKhoan
    WHERE MaThanhVien = @MaThanhVien;
END
go
CREATE PROCEDURE DeleteTaiKhoanThanhVien
    @MaThanhVien varchar(8)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM TaiKhoanThanhVien WHERE MaThanhVien = @MaThanhVien)
    BEGIN
        DELETE FROM TaiKhoanThanhVien WHERE MaThanhVien = @MaThanhVien;
        PRINT 'Bản ghi đã được xóa thành công.';
    END
    ELSE
    BEGIN
        PRINT 'Không tìm thấy bản ghi với MaThanhVien = ' + @MaThanhVien;
    END
END
go

--**********************TRIGGER


--//////////////////// Lich lam viec
CREATE TABLE LichLamViec
(
	MaLichLamViec varchar(8) NOT NULL,
	HoVaTen nvarchar(30),
	MaThanhVien varchar(8),
	NgayLamViec date,
	Ca varchar(2)
)
ALTER TABLE LichLamViec ADD CONSTRAINT PK_LichLamViec PRIMARY KEY (MaLichLamViec)
ALTER TABLE LichLamViec ADD CONSTRAINT FK_LichViecTaiKhoanThanhVien FOREIGN KEY (MaThanhVien) REFERENCES TaiKhoanThanhVien(MaThanhVien) ON DELETE CASCADE
go
--=================FUNCTION
CREATE FUNCTION SelectLichLamViec (@MaLichLamViec varchar(8))
RETURNS TABLE
AS
RETURN (
    SELECT *
    FROM LichLamViec
    WHERE MaLichLamViec = @MaLichLamViec
);

go
CREATE FUNCTION GetLichLamViecByParam(@MaLichLamViec varchar(8), @ParamName varchar(50)) RETURNS nvarchar(50)
AS
BEGIN
    DECLARE @Result nvarchar(50)
    IF @ParamName = 'HoVaTen'
        SELECT @Result = HoVaTen FROM LichLamViec WHERE MaLichLamViec = @MaLichLamViec
    ELSE IF @ParamName = 'MaThanhVien'
        SELECT @Result = MaThanhVien FROM LichLamViec WHERE MaLichLamViec = @MaLichLamViec
    ELSE IF @ParamName = 'NgayLamViec'
        SELECT @Result = CONVERT(nvarchar(50), NgayLamViec, 121) FROM LichLamViec WHERE MaLichLamViec = @MaLichLamViec
    ELSE IF @ParamName = 'Ca'
        SELECT @Result = Ca FROM LichLamViec WHERE MaLichLamViec = @MaLichLamViec
    ELSE
        SET @Result = 'Invalid Parameter'
    RETURN @Result
END
go
CREATE PROCEDURE UpdateLichLamViec
    @MaLichLamViec varchar(8),
    @HoVaTen nvarchar(30),
    @MaThanhVien varchar(8),
    @NgayLamViec date,
    @Ca varchar(2)
AS
BEGIN
    UPDATE LichLamViec
    SET
        HoVaTen = @HoVaTen,
        MaThanhVien = @MaThanhVien,
        NgayLamViec = @NgayLamViec,
        Ca = @Ca
    WHERE MaLichLamViec = @MaLichLamViec;
END
go
CREATE PROCEDURE DeleteLichLamViec
    @MaLichLamViec varchar(8)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM LichLamViec WHERE MaLichLamViec = @MaLichLamViec)
    BEGIN
        DELETE FROM LichLamViec WHERE MaLichLamViec = @MaLichLamViec;
        PRINT 'Bản ghi đã được xóa thành công.';
    END
    ELSE
    BEGIN
        PRINT 'Không tìm thấy bản ghi với MaLichLamViec = ' + @MaLichLamViec;
    END
END
go
--**********************TRIGGER


--#####################PROCEDURE INSERT

--FUNCTION PHAT SINH TU DONG MA SO
CREATE FUNCTION getNewMaBenhAn()
RETURNS varchar(8)
AS
BEGIN
	DECLARE @mabenhan varchar(8)
	SET @mabenhan = (SELECT TOP 1 MaBenhAn FROM BenhAn ORDER BY MaBenhAn DESC)
	DECLARE @STT int
	if @mabenhan is null
		return 'BA000001'
	SET @STT = CAST(RIGHT(@mabenhan, 6) as int) + 1
	if (@STT < 10)
		SET @mabenhan = 'BA' + '00000' + CAST(@STT AS varchar(1))
	else if(@STT < 100)
		SET @mabenhan = 'BA' + '0000' + CAST(@STT AS varchar(2))
	else if(@STT < 1000)
		SET @mabenhan = 'BA' + '000' + CAST(@STT AS varchar(3))
	else if(@STT < 10000)
		SET @mabenhan = 'BA' + '00' + CAST(@STT AS varchar(4))
	else if(@STT < 10000)
		SET @mabenhan = 'BA' + '0' + CAST(@STT AS varchar(5))
	else
		SET @mabenhan = 'BA' + CAST(@STT AS varchar(6))
	RETURN @mabenhan
END
go
CREATE FUNCTION getNewMaHoSoBenhNhan()
RETURNS varchar(8)
AS
BEGIN
	DECLARE @mahosobenhnhan varchar(8)
	SET @mahosobenhnhan = (SELECT TOP 1 MaHoSoBenhNhan FROM HoSoBenhNhan ORDER BY MaHoSoBenhNhan DESC)
	DECLARE @STT int
	if @mahosobenhnhan is null
		return 'BN000001'
	SET @STT = CAST(RIGHT(@mahosobenhnhan, 6) as int) + 1
	if (@STT < 10)
		SET @mahosobenhnhan = 'BN' + '00000' + CAST(@STT AS varchar(1))
	else if(@STT < 100)
		SET @mahosobenhnhan = 'BN' + '0000' + CAST(@STT AS varchar(2))
	else if(@STT < 1000)
		SET @mahosobenhnhan = 'BN' + '000' + CAST(@STT AS varchar(3))
	else if(@STT < 10000)
		SET @mahosobenhnhan = 'BN' + '00' + CAST(@STT AS varchar(4))
	else if(@STT < 100000)
		SET @mahosobenhnhan = 'BN' + '0' + CAST(@STT AS varchar(5))
	else
		SET @mahosobenhnhan = 'BN' + CAST(@STT AS varchar(6))
	RETURN @mahosobenhnhan
END
go
--[[[[[[[[[[[[[[
CREATE FUNCTION GetNewMaToaThuoc()
RETURNS varchar(8)
AS
BEGIN
    DECLARE @maToaThuoc varchar(8)
    SET @maToaThuoc = (SELECT TOP 1 MaToaThuoc FROM ToaThuoc ORDER BY MaToaThuoc DESC)
    DECLARE @STT int
    if @maToaThuoc is null
        return 'TT000001'
    SET @STT = CAST(RIGHT(@maToaThuoc, 6) as int) + 1
    if (@STT < 10)
        SET @maToaThuoc = 'TT' + '00000' + CAST(@STT AS varchar(1))
    else if(@STT < 100)
        SET @maToaThuoc = 'TT' + '0000' + CAST(@STT AS varchar(2))
    else if(@STT < 1000)
        SET @maToaThuoc = 'TT' + '000' + CAST(@STT AS varchar(3))
    else if(@STT < 10000)
        SET @maToaThuoc = 'TT' + '00' + CAST(@STT AS varchar(4))
    else if(@STT < 100000)
        SET @maToaThuoc = 'TT' + '0' + CAST(@STT AS varchar(5))
    else
        SET @maToaThuoc = 'TT' + CAST(@STT AS varchar(6))
    RETURN @maToaThuoc
END
go
--[[[[[[[[[[[[[
CREATE FUNCTION GetNewMaHoaDon()
RETURNS varchar(8)
AS
BEGIN
    DECLARE @maHoaDon varchar(8)
    SET @maHoaDon = (SELECT TOP 1 MaHoaDon FROM HoaDon ORDER BY MaHoaDon DESC)
    DECLARE @STT int
    if @maHoaDon is null
        return 'HD000001'
    SET @STT = CAST(RIGHT(@maHoaDon, 6) as int) + 1
    if (@STT < 10)
        SET @maHoaDon = 'HD' + '00000' + CAST(@STT AS varchar(1))
    else if(@STT < 100)
        SET @maHoaDon = 'HD' + '0000' + CAST(@STT AS varchar(2))
    else if(@STT < 1000)
        SET @maHoaDon = 'HD' + '000' + CAST(@STT AS varchar(3))
    else if(@STT < 10000)
        SET @maHoaDon = 'HD' + '00' + CAST(@STT AS varchar(4))
    else if(@STT < 100000)
        SET @maHoaDon = 'HD' + '0' + CAST(@STT AS varchar(5))
    else
        SET @maHoaDon = 'HD' + CAST(@STT AS varchar(6))
    RETURN @maHoaDon
END
go
--[[[[[[[[[[[[[[[
CREATE FUNCTION GetNewMaKhuyenMai()
RETURNS varchar(8)
AS
BEGIN
    DECLARE @maKhuyenMai varchar(8)
    SET @maKhuyenMai = (SELECT TOP 1 MaKhuyenMai FROM KhuyenMai ORDER BY MaKhuyenMai DESC)
    DECLARE @STT int
    if @maKhuyenMai is null
        return 'KM000001'
    SET @STT = CAST(RIGHT(@maKhuyenMai, 6) as int) + 1
    if (@STT < 10)
        SET @maKhuyenMai = 'KM' + '00000' + CAST(@STT AS varchar(1))
    else if(@STT < 100)
        SET @maKhuyenMai = 'KM' + '0000' + CAST(@STT AS varchar(2))
    else if(@STT < 1000)
        SET @maKhuyenMai = 'KM' + '000' + CAST(@STT AS varchar(3))
    else if(@STT < 10000)
        SET @maKhuyenMai = 'KM' + '00' + CAST(@STT AS varchar(4))
    else if(@STT < 100000)
        SET @maKhuyenMai = 'KM' + '0' + CAST(@STT AS varchar(5))
    else
        SET @maKhuyenMai = 'KM' + CAST(@STT AS varchar(6))
    RETURN @maKhuyenMai
END
go
--[[[[[[[[[[[[[[
CREATE FUNCTION getNewMaDichVu()
RETURNS varchar(8)
AS
BEGIN
	DECLARE @madichvu varchar(8)
	SET @madichvu = (SELECT TOP 1 MaDichVu FROM DichVu ORDER BY MaDichVu DESC)
	DECLARE @STT int
	if @madichvu is null
		return 'DV000001'
	SET @STT = CAST(RIGHT(@madichvu, 6) as int) + 1
	if (@STT < 10)
		SET @madichvu = 'DV' + '00000' + CAST(@STT AS varchar(1))
	else if(@STT < 100)
		SET @madichvu = 'DV' + '0000' + CAST(@STT AS varchar(2))
	else if(@STT < 1000)
		SET @madichvu = 'DV' + '000' + CAST(@STT AS varchar(3))
	else if(@STT < 10000)
		SET @madichvu = 'DV' + '00' + CAST(@STT AS varchar(4))
	else if(@STT < 100000)
		SET @madichvu = 'DV' + '0' + CAST(@STT AS varchar(5))
	else
		SET @madichvu = 'DV' + CAST(@STT AS varchar(6))
	RETURN @madichvu
END
go
--[[[[[[[[[[[[[[
CREATE FUNCTION GetNewMaChuyenKhoa()
RETURNS varchar(8)
AS
BEGIN
    DECLARE @maChuyenKhoa varchar(8)
    SET @maChuyenKhoa = (SELECT TOP 1 MaChuyenKhoa FROM ChuyenKhoa ORDER BY MaChuyenKhoa DESC)
    DECLARE @STT int
    if @maChuyenKhoa is null
        return 'CK000001'
    SET @STT = CAST(RIGHT(@maChuyenKhoa, 6) as int) + 1
    if (@STT < 10)
        SET @maChuyenKhoa = 'CK' + '00000' + CAST(@STT AS varchar(1))
    else if(@STT < 100)
        SET @maChuyenKhoa = 'CK' + '0000' + CAST(@STT AS varchar(2))
    else if(@STT < 1000)
        SET @maChuyenKhoa = 'CK' + '000' + CAST(@STT AS varchar(3))
    else if(@STT < 10000)
        SET @maChuyenKhoa = 'CK' + '00' + CAST(@STT AS varchar(4))
    else if(@STT < 100000)
        SET @maChuyenKhoa = 'CK' + '0' + CAST(@STT AS varchar(5))
    else
        SET @maChuyenKhoa = 'CK' + CAST(@STT AS varchar(6))
    RETURN @maChuyenKhoa
END
go
--[[[[[[[[[[[[[
CREATE FUNCTION GetNewMaLichKham()
RETURNS varchar(8)
AS
BEGIN
    DECLARE @maLichKham varchar(8)
    SET @maLichKham = (SELECT TOP 1 MaLichKham FROM LichKham ORDER BY MaLichKham DESC)
    DECLARE @STT int
    if @maLichKham is null
        return 'LK000001'
    SET @STT = CAST(RIGHT(@maLichKham, 6) as int) + 1
    if (@STT < 10)
        SET @maLichKham = 'LK' + '00000' + CAST(@STT AS varchar(1))
    else if(@STT < 100)
        SET @maLichKham = 'LK' + '0000' + CAST(@STT AS varchar(2))
    else if(@STT < 1000)
        SET @maLichKham = 'LK' + '000' + CAST(@STT AS varchar(3))
    else if(@STT < 10000)
        SET @maLichKham = 'LK' + '00' + CAST(@STT AS varchar(4))
    else if(@STT < 100000)
        SET @maLichKham = 'LK' + '0' + CAST(@STT AS varchar(5))
    else
        SET @maLichKham = 'LK' + CAST(@STT AS varchar(6))
    RETURN @maLichKham
END
go
--[[[[[[[[[[[[[[[[[
CREATE FUNCTION GetNewMaThanhVien()
RETURNS varchar(8)
AS
BEGIN
    DECLARE @maThanhVien varchar(8)
    SET @maThanhVien = (SELECT TOP 1 MaThanhVien FROM TaiKhoanThanhVien ORDER BY  CAST(SUBSTRING(MaThanhVien, PATINDEX('%[0-9]%', MaThanhVien), LEN(MaThanhVien)) AS INT) DESC, SUBSTRING(MaThanhVien, 1, PATINDEX('%[0-9]%', MaThanhVien) - 1) DESC)
    DECLARE @STT int
    if @maThanhVien is null
        return 'TV000001'
    SET @STT = CAST(RIGHT(@maThanhVien, 6) as int) + 1
    if (@STT < 10)
        SET @maThanhVien = 'TV' + '00000' + CAST(@STT AS varchar(1))
    else if(@STT < 100)
        SET @maThanhVien = 'TV' + '0000' + CAST(@STT AS varchar(2))
    else if(@STT < 1000)
        SET @maThanhVien = 'TV' + '000' + CAST(@STT AS varchar(3))
    else if(@STT < 10000)
        SET @maThanhVien = 'TV' + '00' + CAST(@STT AS varchar(4))
    else if(@STT < 100000)
        SET @maThanhVien = 'TV' + '0' + CAST(@STT AS varchar(5))
    else
        SET @maThanhVien = 'TV' + CAST(@STT AS varchar(6))
    RETURN @maThanhVien
END
go
CREATE FUNCTION GetNewMaThanhVienBacSi()
RETURNS varchar(8)
AS
BEGIN
    DECLARE @maThanhVien varchar(8)
    SET @maThanhVien = (SELECT TOP 1 MaThanhVien FROM TaiKhoanThanhVien ORDER BY  CAST(SUBSTRING(MaThanhVien, PATINDEX('%[0-9]%', MaThanhVien), LEN(MaThanhVien)) AS INT) DESC, SUBSTRING(MaThanhVien, 1, PATINDEX('%[0-9]%', MaThanhVien) - 1) DESC)
    DECLARE @STT int
    if @maThanhVien is null
        return 'BS000001'
    SET @STT = CAST(RIGHT(@maThanhVien, 6) as int) + 1
    if (@STT < 10)
        SET @maThanhVien = 'BS' + '00000' + CAST(@STT AS varchar(1))
    else if(@STT < 100)
        SET @maThanhVien = 'BS' + '0000' + CAST(@STT AS varchar(2))
    else if(@STT < 1000)
        SET @maThanhVien = 'BS' + '000' + CAST(@STT AS varchar(3))
    else if(@STT < 10000)
        SET @maThanhVien = 'BS' + '00' + CAST(@STT AS varchar(4))
    else if(@STT < 100000)
        SET @maThanhVien = 'BS' + '0' + CAST(@STT AS varchar(5))
    else
        SET @maThanhVien = 'BS' + CAST(@STT AS varchar(6))
    RETURN @maThanhVien
END
go
CREATE FUNCTION GetNewMaThanhVienKeToan()
RETURNS varchar(8)
AS
BEGIN
    DECLARE @maThanhVien varchar(8)
    SET @maThanhVien = (SELECT TOP 1 MaThanhVien FROM TaiKhoanThanhVien ORDER BY  CAST(SUBSTRING(MaThanhVien, PATINDEX('%[0-9]%', MaThanhVien), LEN(MaThanhVien)) AS INT) DESC, SUBSTRING(MaThanhVien, 1, PATINDEX('%[0-9]%', MaThanhVien) - 1) DESC)
    DECLARE @STT int
    if @maThanhVien is null
        return 'KT000001'
    SET @STT = CAST(RIGHT(@maThanhVien, 6) as int) + 1
    if (@STT < 10)
        SET @maThanhVien = 'KT' + '00000' + CAST(@STT AS varchar(1))
    else if(@STT < 100)
        SET @maThanhVien = 'KT' + '0000' + CAST(@STT AS varchar(2))
    else if(@STT < 1000)
        SET @maThanhVien = 'KT' + '000' + CAST(@STT AS varchar(3))
    else if(@STT < 10000)
        SET @maThanhVien = 'KT' + '00' + CAST(@STT AS varchar(4))
    else if(@STT < 100000)
        SET @maThanhVien = 'KT' + '0' + CAST(@STT AS varchar(5))
    else
        SET @maThanhVien = 'KT' + CAST(@STT AS varchar(6))
    RETURN @maThanhVien
END
go
--[[[[[[[[[[[[[[[[[
CREATE FUNCTION GetNewMaLichLamViec()
RETURNS varchar(8)
AS
BEGIN
    DECLARE @maLichLamViec varchar(8)
    SET @maLichLamViec = (SELECT TOP 1 MaLichLamViec FROM LichLamViec ORDER BY MaLichLamViec DESC)
    DECLARE @STT int
    if @maLichLamViec is null
        return 'LLV00001'
    SET @STT = CAST(RIGHT(@maLichLamViec, 5) as int) + 1
    if (@STT < 10)
        SET @maLichLamViec = 'LLV' + '0000' + CAST(@STT AS varchar(1))
    else if(@STT < 100)
        SET @maLichLamViec = 'LLV' + '000' + CAST(@STT AS varchar(2))
    else if(@STT < 1000)
        SET @maLichLamViec = 'LLV' + '00' + CAST(@STT AS varchar(3))
    else if(@STT < 10000)
        SET @maLichLamViec = 'LLV' + '0' + CAST(@STT AS varchar(4))
    else
        SET @maLichLamViec = 'LLV' + CAST(@STT AS varchar(6))
    RETURN @maLichLamViec
END
go
--################ PROCEDURE INSERT
CREATE PROCEDURE InsertADMIN_Manager
    @MaAdmin varchar(8),
    @MatKhau varchar(8)
AS
BEGIN
    INSERT INTO ADMIN_Manager (MaAdmin, MatKhau)
    VALUES (@MaAdmin, @MatKhau)
END
go
CREATE PROCEDURE HoSoBenhNhan_Insert
    @HoVaTen nvarchar(30),
    @MaTaiKhoan varchar(10),
    @NgaySinh date,
    @GioiTinh nvarchar(3),
    @CCCD varchar(12),
    @MaBHYT varchar(15),
    @NgheNghiep nvarchar(30),
    @SoDienThoai varchar(10),
    @Email varchar(30),
    @DiaChi nvarchar(50)
AS
BEGIN
	DECLARE @mahosobenhnhan varchar(8)
	SET @mahosobenhnhan = dbo.getNewMaHoSoBenhNhan()
    INSERT INTO HoSoBenhNhan (HoVaTen, MaHoSoBenhNhan, MaTaiKhoan, NgaySinh, GioiTinh, CCCD, MaBHYT, NgheNghiep, SoDienThoai, Email, DiaChi)
    VALUES (@HoVaTen, @mahosobenhnhan, @MaTaiKhoan, @NgaySinh, @GioiTinh, @CCCD, @MaBHYT, @NgheNghiep, @SoDienThoai, @Email, @DiaChi)
END
go
--################ PROCEDURE INSERT
CREATE PROCEDURE SoKhamBenh_Insert
    @MaHoSoBenhNhan varchar(8),
    @MaLichKham varchar(8),
    @HoVaTen nvarchar(30),
    @Tuoi varchar(3),
    @SoTheBHYT varchar(15),
    @DiaChi nvarchar(50),
    @NgheNghiep nvarchar(30),
    @DanToc nvarchar(10),
    @TrieuChung nvarchar(50),
    @ChanDoan nvarchar(50),
    @PhuongPhapDieuTri nvarchar(50),
    @BSKhamBenh nvarchar(30),
    @GhiChu nvarchar(50)
AS
BEGIN
    INSERT INTO SoKhamBenh (MaHoSoBenhNhan, MaLichKham, HoVaTen, Tuoi, SoTheBHYT, DiaChi, NgheNghiep, DanToc, TrieuChung, ChanDoan, PhuongPhapDieuTri, BSKhamBenh, GhiChu)
    VALUES (@MaHoSoBenhNhan, @MaLichKham, @HoVaTen, @Tuoi, @SoTheBHYT, @DiaChi, @NgheNghiep, @DanToc, @TrieuChung, @ChanDoan, @PhuongPhapDieuTri, @BSKhamBenh, @GhiChu)
END
go
--################### PROCEDURE INSERT
CREATE PROCEDURE BenhAn_Insert
    @MaHoSoBenhNhan varchar(8),
    @DoiTuong nvarchar(8),
    @GiaTriBHYT date,
    @HoTenThanNhan nvarchar(30),
    @ThoiGianVaoVien date,
    @TrucTiepVao nvarchar(30),
    @NoiGioiThieu nvarchar(30),
    @VaoKhoa nvarchar(30),
    @ChuyenKhoa nvarchar(30),
    @TongSoNgayDieuTri varchar(3),
    @NoiChuyenDen nvarchar(30),
    @KKBorCapCuu nvarchar(30),
    @KhiVaoKhoaDieuTri nvarchar(30),
    @KetQuaDieuTri nvarchar(30),
    @GiaiPhauBenh nvarchar(30),
    @QuaTrinhBenhLy nvarchar(30),
    @TienSuBenh nvarchar(30),
    @ToanThan nvarchar(30),
    @TrieuChungCoNang nvarchar(30),
    @ThuongTonCanBan nvarchar(30),
    @CacCoQuan nvarchar(30),
    @TKetQuaTrinhBenhLy nvarchar(30),
    @TomTatKQXN nvarchar(30),
    @PhuongPhapDieuTri nvarchar(30),
    @HoSoPhimAnh nvarchar(30)
AS
BEGIN
	DECLARE @mabenhan varchar(8)
	SET @mabenhan = dbo.getNewMaBenhAn()
    INSERT INTO BenhAn (MaBenhAn, MaHoSoBenhNhan, DoiTuong, GiaTriBHYT, HoTenThanNhan, ThoiGianVaoVien, TrucTiepVao, NoiGioiThieu, VaoKhoa, ChuyenKhoa, TongSoNgayDieuTri, NoiChuyenDen, KKBorCapCuu, KhiVaoKhoaDieuTri, KetQuaDieuTri, GiaiPhauBenh, QuaTrinhBenhLy, TienSuBenh, ToanThan, TrieuChungCoNang, ThuongTonCanBan, CacCoQuan, TKetQuaTrinhBenhLy, TomTatKQXN, PhuongPhapDieuTri, HoSoPhimAnh)
    VALUES (@mabenhan, @MaHoSoBenhNhan, @DoiTuong, @GiaTriBHYT, @HoTenThanNhan, @ThoiGianVaoVien, @TrucTiepVao, @NoiGioiThieu, @VaoKhoa, @ChuyenKhoa, @TongSoNgayDieuTri, @NoiChuyenDen, @KKBorCapCuu, @KhiVaoKhoaDieuTri, @KetQuaDieuTri, @GiaiPhauBenh, @QuaTrinhBenhLy, @TienSuBenh, @ToanThan, @TrieuChungCoNang, @ThuongTonCanBan, @CacCoQuan, @TKetQuaTrinhBenhLy, @TomTatKQXN, @PhuongPhapDieuTri, @HoSoPhimAnh)
END
go
--################ PROCEDURE INSERT
CREATE PROCEDURE InsertToaThuoc
    @SoThuTu varchar(10),
    @MaThuoc varchar(8),
    @MaBenhAn varchar(8),
    @TenThuoc nvarchar(30),
    @SoLuong tinyint,
    @Dang nvarchar(10),
    @GhiChu nvarchar(50)
AS
BEGIN
	DECLARE @matoathuoc varchar(8)
	SET @matoathuoc = dbo.GetNewMaToaThuoc()
    INSERT INTO ToaThuoc (SoThuTu, MaToaThuoc, MaThuoc, MaBenhAn, TenThuoc, SoLuong, Dang, GhiChu)
    VALUES (@SoThuTu, @matoathuoc, @MaThuoc, @MaBenhAn, @TenThuoc, @SoLuong, @Dang, @GhiChu)
END
go
--################ PROCEDURE INSERT
CREATE PROCEDURE InsertHoaDon
    @MaLichKham varchar(8),
    @TongTien int,
    @HinhThucThanhToan nvarchar(30)
AS
BEGIN
	DECLARE @mahoadon varchar(8)
	SET @mahoadon = dbo.GetNewMaHoaDon()
    INSERT INTO HoaDon (MaHoaDon, MaLichKham, TongTien, HinhThucThanhToan)
    VALUES (@mahoadon, @MaLichKham, @TongTien, @HinhThucThanhToan)
END
go
--################ PROCEDURE INSERT
CREATE PROCEDURE InsertKhuyenMai
    @TenChuongTrinhKM nvarchar(30),
    @GiaKhuyenMai VARCHAR(10),
    @NoiDungKM nvarchar(50),
    @ThoiGianBatDau datetime,
    @ThoiGianKetThuc datetime
AS
BEGIN
	DECLARE @makhuyenmai varchar(8)
	SET @makhuyenmai = dbo.GetNewMaKhuyenMai()
    INSERT INTO KhuyenMai (MaKhuyenMai, TenChuongTrinhKM, GiaKhuyenMai, NoiDungKM, ThoiGianBatDau, ThoiGianKetThuc)
    VALUES (@makhuyenmai, @TenChuongTrinhKM, @GiaKhuyenMai , @NoiDungKM, @ThoiGianBatDau, @ThoiGianKetThuc)
END

go
--################ PROCEDURE INSERT
CREATE PROCEDURE InsertDichVu
    @TenDichVu nvarchar(30),
    @NoiDungDichVu nvarchar(50),
    @GiaDichVu int
AS
BEGIN
	DECLARE @madichvu varchar(8)
	SET @madichvu = dbo.GetNewMaDichVu()
    INSERT INTO DichVu (MaDichVu, TenDichVu, NoiDungDichVu, GiaDichVu)
    VALUES (@madichvu, @TenDichVu, @NoiDungDichVu, @GiaDichVu)
END
go
--################ PROCEDURE INSERT
CREATE PROCEDURE InsertChuyenKhoa
    @TenChuyenKhoa nvarchar(30),
    @MaKhuyenMai varchar(8)
AS
BEGIN
	DECLARE @machuyenkhoa varchar(8)
	SET @machuyenkhoa = dbo.GetNewMaChuyenKhoa()
    INSERT INTO ChuyenKhoa (MaChuyenKhoa, TenChuyenKhoa, MaKhuyenMai)
    VALUES (@machuyenkhoa, @TenChuyenKhoa, @MaKhuyenMai)
END
go
--################ PROCEDURE INSERT
CREATE PROCEDURE InsertLichKham
    @MaHoSoBenhNhan varchar(8),
    @MaChuyenKhoa varchar(8),
    @MaDichVu varchar(8),
    @NgayDangKy date,
    @Ca nvarchar(15),
    @KhungGioKham datetime
AS
BEGIN
	DECLARE @malichkham varchar(8)
	SET @malichkham = dbo.GetNewMaLichKham()
    INSERT INTO LichKham (MaLichKham, MaHoSoBenhNhan, MaChuyenKhoa, MaDichVu, NgayDangKy, Ca, KhungGioKham)
    VALUES (@malichkham, @MaHoSoBenhNhan, @MaChuyenKhoa, @MaDichVu, @NgayDangKy, @Ca, @KhungGioKham)
END
go
--################ PROCEDURE INSERT
CREATE PROCEDURE InsertTaiKhoanThanhVien
    @HoVaTen nvarchar(30),
    @MatKhau varchar(8),
    @NgaySinh date,
    @GioiTinh nvarchar(3),
    @CCCD varchar(12),
    @SoDienThoai varchar(10),
    @Email varchar(30),
    @DiaChi nvarchar(50),
    @ChuyenKhoa nvarchar(30),
    @ViTri nvarchar(30),
    @LoaiTaiKhoan varchar(10)
AS
BEGIN
	DECLARE @mathanhvien varchar(8)
	IF @LoaiTaiKhoan = 'BS'
	BEGIN
		SET @mathanhvien = dbo.GetNewMaThanhVienBacSi()
	END
	ELSE IF @LoaiTaiKhoan = 'TV'
	BEGIN
		SET @mathanhvien = dbo.GetNewMaThanhVien()
	END
	ELSE
	BEGIN
		SET @mathanhvien = dbo.GetNewMaThanhVienKeToan()
	END
    INSERT INTO TaiKhoanThanhVien (HoVaTen, MaThanhVien, MatKhau, NgaySinh, GioiTinh, CCCD, SoDienThoai, Email, DiaChi, ChuyenKhoa, ViTri, LoaiTaiKhoan)
    VALUES (@HoVaTen, @mathanhvien, @MatKhau, @NgaySinh, @GioiTinh, @CCCD, @SoDienThoai, @Email, @DiaChi, @ChuyenKhoa, @ViTri, @LoaiTaiKhoan)
END

go
--################ PROCEDURE INSERT
CREATE PROCEDURE InsertLichLamViec
    @HoVaTen nvarchar(30),
    @MaThanhVien varchar(8),
    @NgayLamViec date,
    @Ca varchar(2)
AS
BEGIN
	DECLARE @malichlamviec varchar(8)
	SET @malichlamviec = dbo.GetNewMaLichLamViec()
    INSERT INTO LichLamViec (MaLichLamViec, HoVaTen, MaThanhVien, NgayLamViec, Ca)
    VALUES (@malichlamviec, @HoVaTen, @MaThanhVien, @NgayLamViec, @Ca)
END
go

CREATE PROCEDURE searchTaiKhoanThanhVien
    @SearchKeyword nvarchar(255)
AS
BEGIN
    SELECT *
    FROM TaiKhoanThanhVien
    WHERE
        HoVaTen LIKE '%' + @SearchKeyword + '%' OR       
		MaThanhVien LIKE '%' + @SearchKeyword + '%' OR
        MatKhau LIKE '%' + @SearchKeyword + '%' OR
        GioiTinh LIKE '%' + @SearchKeyword + '%' OR
        CCCD LIKE '%' + @SearchKeyword + '%' OR
        SoDienThoai LIKE '%' + @SearchKeyword + '%' OR
        Email LIKE '%' + @SearchKeyword + '%' OR
        DiaChi LIKE '%' + @SearchKeyword + '%' OR
        ChuyenKhoa LIKE '%' + @SearchKeyword + '%' OR
        ViTri LIKE '%' + @SearchKeyword + '%' OR
        LoaiTaiKhoan LIKE '%' + @SearchKeyword + '%'
END
go
CREATE PROCEDURE CheckDuplicateLichLamViec
    @MaThanhVien varchar(8),
    @NgayLamViec date,
    @Ca nvarchar(8)
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM LichLamViec
        WHERE MaThanhVien = @MaThanhVien
        AND NgayLamViec = @NgayLamViec
        AND Ca = @Ca
    )
    BEGIN
        -- Nếu có bản ghi trùng lặp, trả về 1
        SELECT 1;
    END
    ELSE
    BEGIN
        -- Nếu không tìm thấy bản ghi trùng lặp, trả về 0
        SELECT 0;
    END
END
go

CREATE PROCEDURE searchLichLamViec
    @SearchKeyword NVARCHAR(255)
AS
BEGIN
    SELECT *
    FROM LichLamViec
    WHERE HoVaTen LIKE '%' + @SearchKeyword + '%'
	OR MaLichLamViec LIKE '%' + @SearchKeyword + '%'
	OR MaThanhVien LIKE '%' + @SearchKeyword + '%'
    OR NgayLamViec LIKE '%' + @SearchKeyword + '%'
    OR Ca LIKE '%' + @SearchKeyword + '%'
END
go

CREATE FUNCTION GetLichKhamByCaAndNgay
(
    @Ca nvarchar(15),
    @Date date
)
RETURNS TABLE
AS
RETURN
(
    SELECT
        *
    FROM
        LichKham
    WHERE
        Ca = @Ca
        AND CONVERT(date, KhungGioKham) = @Date
);
go

CREATE FUNCTION SelectBenhAnByMaHSBN (@MaHoSoBenhNhan varchar(8))
RETURNS TABLE
AS
RETURN (
    SELECT *
    FROM BenhAn
    WHERE MaHoSoBenhNhan = @MaHoSoBenhNhan
);

go

--THEM DU LIEU CHO CAC TABLE 
-- TABLE DangKyUer
EXEC DangKyUser_Insert '0182831345', 'Abcd@123'
EXEC DangKyUser_Insert '0987654321', 'P@ssw0rd'
EXEC DangKyUser_Insert '0369852147', 'Secure!12'
EXEC DangKyUser_Insert '0765432198', 'Qwerty@1'
EXEC DangKyUser_Insert '0932145678', 'Mypass!23'
EXEC DangKyUser_Insert '0846512379', 'Abcdef@9'
EXEC DangKyUser_Insert '0654321890', 'Passw0rd!'
EXEC DangKyUser_Insert '0312456879', 'Ch@ngeMe'
EXEC DangKyUser_Insert '0975318642', 'S3cur1ty@'
EXEC DangKyUser_Insert '0624875139', 'MyP@ss'
EXEC DangKyUser_Insert '0392187456', 'Pa$$w0rd'
EXEC DangKyUser_Insert '0856123497', 'SecureP@ss'
EXEC DangKyUser_Insert '0912345678', 'P@ssw0rd!'
EXEC DangKyUser_Insert '0765432981', 'Qwerty@123'
EXEC DangKyUser_Insert '0987654320', 'Abcde!12'

-- TABLE HoSoBenhNhan
EXEC HoSoBenhNhan_Insert N'Nguyễn Văn An', '0182831345', '1990-05-15', N'Nam', '053137827346', 'BHYT0321344414', N'Kỹ sư', '0182831345', 'nguyenvanan123@gmail.com', N'Bình Hưng, Bình Chánh, Thành phố HCM'
EXEC HoSoBenhNhan_Insert N'Trần Mỹ Nữ', '0987654321', '1985-10-20', N'Nữ', '056263748129', 'BHYT0827281342', N'Giáo viên', '0987654321', 'mynu9823@gmail.com', N'Bình Hưng, Bình Chánh, Thành phố HCM'
EXEC HoSoBenhNhan_Insert N'Lê Văn Luyện', '0369852147', '1992-03-25', N'Nam', '056182342383', 'BHYT0192781634', N'Bác sĩ', '0369852147', 'vanluyen192@gamil.com', N'Boulevard, Quận 1, Thành phố HCM'
EXEC HoSoBenhNhan_Insert N'Phạm Thị Kim Tiến', '0765432198', '1988-12-10', N'Nữ', '052983674513', 'BHYT0454372749', N'Y tá', '0765432198', 'phamthikimtien123@gmail.com', N'Phường 12, Quận 10, Thành phố HCM'
EXEC HoSoBenhNhan_Insert N'Hoàng Ngọc Quý', '0932145678', '1995-07-05', N'Nam', '058716293874', 'BHYT0817321244', N'Kỹ sư', '0932145678', 'hoangquy95@gmail.com', N'Bình Trị Đông B, Bình Tân, Thành phố HCM'
EXEC HoSoBenhNhan_Insert N'Võ Duyên Trúc', '0846512379', '1983-04-30', N'Nữ', '054712481844', 'BHYT0318321845', N'Chuyên viên kinh doanh', '0846512379', 'voduyentruc1983@gamil.com', N'KCN Đức Hoà 1, ấp 5, Đức Hòa, Long An'
EXEC HoSoBenhNhan_Insert N'Đặng Minh Thắng', '0654321890', '1993-11-18', N'Nam', '053281836111', 'BHYT0192814245', N'Nhân viên văn phòng', '0654321890', 'dangthang@gmail.com', N'Thống Nhất, Thành phố Biên Hòa, Đồng Nai'
EXEC HoSoBenhNhan_Insert N'Mai Thị Thuỷ', '0312456879', '1991-09-22', N'Nữ', '057172718322', 'BHYT0239421445', N'Luật sư', '0312456879', 'maithithuy2312@gmail.com', N'Đa Kao, Quận 1, Thành phố HCM'
EXEC HoSoBenhNhan_Insert N'Lý Văn Nguyên', '0975318642', '1987-08-12', N'Nam', '056173281324', 'BHYT0987371633', N'Kỹ sư xây dựng', '0975318642', 'lyvannguyen342@gmail.com', N'P. Bình An, Quận 2, Thành phố HCM'
EXEC HoSoBenhNhan_Insert N'Nguyễn Thị Thuý', '0624875139', '1996-06-08', N'Nữ', '056981887816', 'BHYT0918274124', N'Bác sĩ', '0624875139', 'nguyenthithuy0213482@gmail.com', N'Phú Mỹ Hưng, Quận 7, Thành phố HCM'
EXEC HoSoBenhNhan_Insert N'Trần Nhân Tâm', '0392187456', '1994-02-14', N'Nam', '056813920132', 'BHYT0127471562', N'Giáo viên', '0392187456', 'trannhantam2222@gmail.com', N'Tân Phú, Quận 7, Thành phố HCM'
EXEC HoSoBenhNhan_Insert N'Đinh Thị Mai Đinh', '0856123497', '1986-03-03', N'Nữ', '053727183388', 'BHYT0918271413', N'Y tá', '0856123497', 'dinhthimaidinh@gmail.com', N'Tân Hưng, Quận 7, Thành phố HCM'
EXEC HoSoBenhNhan_Insert N'Lê Hoàng Ngọc', '0912345678', '1989-07-19', N'Nam', '056727277713', 'BHYT0234141246', N'Kỹ sư', '0912345678', 'hoangngoc1323@gmail.com', N'Phường 12, Quận 4, Thành phố HCM'
EXEC HoSoBenhNhan_Insert N'Võ Mỹ Kim Thoa', '0765432981', '1997-09-28', N'Nữ', '052128318445', 'BHYT0918274123', N'Chuyên viên kinh doanh', '0765432981', 'vokimthoaw23@gmail.com', N'Phường 22, Bình Thạnh, Thành phố HCM'
EXEC HoSoBenhNhan_Insert N'Phan Văn Hội', '0987654320', '1998-12-01', N'Nam', '058172563721', 'BHYT0362783945', N'Sinh viên', '0987654320', 'phanvanhoi@gmail.com', N'Hiệp Bình Chánh, Thủ Đức, Thành phố HCM'
-- KHUYEN MAI
EXEC InsertKhuyenMai N'Giảm giá dịch vụ da liễu', '100000',N'Giảm 20% cho các dịch vụ điều trị da liễu', '2023-11-01 08:00:00', '2023-11-15 17:00:00'
EXEC InsertKhuyenMai N'Combo chăm sóc da', '300000', N'Mua bất kỳ combo nào và nhận 1 lần spa da miễn phí', '2023-12-05 10:00:00', '2023-12-20 19:00:00'
EXEC InsertKhuyenMai N'Đánh giá da miễn phí', '100000', N'Nhận đánh giá da miễn phí từ các chuyên gia da liễu', '2023-09-10 09:30:00', '2023-09-30 18:00:00'
EXEC InsertKhuyenMai N'Phòng ngừa mụn', '100000', N'Hướng dẫn cách chăm sóc da để ngừa mụn', '2023-10-15 14:00:00', '2023-10-31 20:00:00'
EXEC InsertKhuyenMai N'Giảm giá các sản phẩm da liễu', '200000', N'Giảm 15% cho tất cả các sản phẩm chăm sóc da liễu', '2023-11-20 11:30:00', '2023-12-05 22:00:00'
EXEC InsertKhuyenMai N'Ưu đãi mùa lễ hội', '300000', N'Giảm giá 25% cho tất cả các dịch vụ và sản phẩm cao cấp chuyên dùng', '2023-12-21 09:00:00', '2023-12-30 18:00:00'

-- CHUYEN KHOA
EXEC InsertChuyenKhoa N'Chăm sóc da trẻ em', 'KM00001'
EXEC InsertChuyenKhoa N'Chăm sóc da người già', NULL
EXEC InsertChuyenKhoa N'Điều trị mụn', 'KM00004'
EXEC InsertChuyenKhoa N'Laser điều trị da', 'KM00002'
EXEC InsertChuyenKhoa N'Chăm sóc da sau phẫu thuật', NULL
EXEC InsertChuyenKhoa N'Chăm sóc da tự nhiên', 'KM00005'
EXEC InsertChuyenKhoa N'Chăm sóc da mặt', NULL
EXEC InsertChuyenKhoa N'Chăm sóc da cơ bản', 'KM00003'
EXEC InsertChuyenKhoa N'Chăm sóc da chuyên sâu', NULL
EXEC InsertChuyenKhoa N'Chăm sóc da từ trong ra ngoài', 'KM00001'
-- BENH AN
EXEC BenhAn_Insert 'BN000001', N'BHYT', '2023-12-31', N'Nguyễn Văn An', '2023-10-25 09:00:00', N'Cấp cứu', N'Phòng khám đa khoa A', N'Da liễu', N'Chăm sóc da trẻ em', '7', N'Không chuyển', N'Không có', N'Nguyên trạng', N'Đã hồi phục', N'Không có', N'Mụn trứng cá', N'Không có', N'Bình thường', N'Ngứa', N'Không có', N'Không có', N'Không có', N'Không có', N'Thuốc và kem chăm sóc da', N'Không có'
EXEC BenhAn_Insert 'BN000002', N'BHYT', '2023-12-31', N'Trần Mỹ Nữ', '2023-11-03 14:30:00', N'Khám thường xuyên', N'Phòng khám đa khoa B', N'Da liễu', N'Chăm sóc da người già', '10', N'Không chuyển', N'Không có', N'Nguyên trạng', N'Đã hồi phục', N'Không có', N'Nổi mụn', N'Không có', N'Bình thường', N'Đỏ và ngứa', N'Không có', N'Không có', N'Không có', N'Không có', N'Thuốc chống dị ứng và kem chăm sóc da', N'Không có'
EXEC BenhAn_Insert 'BN000003', N'BHYT', '2023-12-31', N'Lê Văn Luyện', '2023-10-29 11:15:00', N'Cấp cứu', N'Phòng khám đa khoa C', N'Da liễu', N'Chăm sóc da người già', '5', N'Không chuyển', N'Không có', N'Nguyên trạng', N'Đã hồi phục', N'Không có', N'Dị ứng da', N'Không có', N'Bình thường', N'Ngứa và đỏ', N'Không có', N'Không có', N'Không có', N'Không có', N'Thuốc chống dị ứng và kem chăm sóc da', N'Không có'
EXEC BenhAn_Insert 'BN000004', N'BHYT', '2023-12-31', N'Phạm Thị Kim Tiến', '2023-11-12 08:45:00', N'Khám thường xuyên', N'Phòng khám đa khoa D', N'Da liễu', N'Chăm sóc da trẻ em', '8', N'Không chuyển', N'Không có', N'Nguyên trạng', N'Đã hồi phục', N'Không có', N'Nổi mụn nước', N'Không có', N'Bình thường', N'Ngứa và đỏ', N'Không có', N'Không có', N'Không có', N'Không có', N'Không có', N'Không có'
EXEC BenhAn_Insert 'BN000005', N'BHYT', '2023-12-31', N'Hoàng Ngọc Quý', '2023-11-18 10:20:00', N'Cấp cứu', N'Phòng khám đa khoa E', N'Da liễu', N'Chăm sóc da người già', '6', N'Không chuyển', N'Không có', N'Nguyên trạng', N'Đã hồi phục', N'Không có', N'Nổi mụn nước và đỏ', N'Không có', N'Bình thường', N'Ngứa và đỏ', N'Không có', N'Không có', N'Không có', N'Không có', N'Không có', N'Không có'
EXEC BenhAn_Insert 'BN000006', N'BHYT', '2023-12-31', N'Võ Duyên Trúc', '2023-10-30 15:10:00', N'Khám thường xuyên', N'Phòng khám đa khoa F', N'Da liễu', N'Chăm sóc da trẻ em', '4', N'Không chuyển', N'Không có', N'Nguyên trạng', N'Đã hồi phục', N'Không có', N'Dị ứng da', N'Không có', N'Bình thường', N'Ngứa và đỏ', N'Không có', N'Không có', N'Không có', N'Không có', N'Không có', N'Không có'
EXEC BenhAn_Insert 'BN000007', N'BHYT', '2023-12-31', N'Đặng Minh Thắng', '2023-11-20 11:45:00', N'Cấp cứu', N'Phòng khám đa khoa G', N'Da liễu', N'Chăm sóc da người già', '9', N'Không chuyển', N'Không có', N'Nguyên trạng', N'Đã hồi phục', N'Không có', N'Nổi mụn và đỏ', N'Không có', N'Bình thường', N'Ngứa và đỏ', N'Không có', N'Không có', N'Không có', N'Không có', N'Không có', N'Không có'
EXEC BenhAn_Insert 'BN000008', N'BHYT', '2023-12-31', N'Mai Thị Thuỷ', '2023-11-25 13:30:00', N'Cấp cứu', N'Phòng khám đa khoa H', N'Da liễu', N'Chăm sóc da trẻ em', '3', N'Không chuyển', N'Không có', N'Nguyên trạng', N'Đã hồi phục', N'Không có', N'Dị ứng da', N'Không có', N'Bình thường', N'Ngứa và đỏ', N'Không có', N'Không có', N'Không có', N'Không có', N'Không có', N'Không có'
-- ADMIN 
EXEC InsertADMIN_Manager 'ADMINPKDL', 'P@ssW0rd123'
--DICH VU
EXEC InsertDichVu N'Kiểm tra da thường xuyên', N'Kiểm tra tình trạng da và tư vấn chăm sóc da', 100000
EXEC InsertDichVu N'Chăm sóc da mặt', N'Rửa mặt, tẩy trang, và áp dụng mặt nạ chăm sóc da', 150000
EXEC InsertDichVu N'Điều trị mụn trứng cá', N'Điều trị và loại bỏ mụn trứng cá', 200000
EXEC InsertDichVu N'Peeling da', N'Áp dụng kỹ thuật peeling để loại bỏ tế bào chết', 180000
EXEC InsertDichVu N'Chăm sóc da toàn diện', N'Rửa mặt, tẩy trang, điều trị mụn và áp dụng mặt nạ chăm sóc da', 250000
EXEC InsertDichVu N'Điều trị nám và tàn nhang', N'Điều trị và giảm thiểu vết nám và tàn nhang trên da', 300000
EXEC InsertDichVu N'Chăm sóc da mặt cho trẻ em', N'Chăm sóc và bảo vệ làn da của trẻ em', 120000
EXEC InsertDichVu N'Điều trị viêm da cơ địa', N'Điều trị các triệu chứng viêm và kích ứng trên da', 220000
EXEC InsertDichVu N'Chăm sóc da mắt', N'Đặt liệu pháp chăm sóc da vùng mắt, giảm quầng thâm và nếp nhăn', 120000
EXEC InsertDichVu N'Tẩy tế bào chết', N'Áp dụng phương pháp tẩy tế bào chết nhẹ nhàng cho làn da mềm mại', 160000
EXEC InsertDichVu N'Chăm sóc da cơ bản', N'Rửa mặt, tẩy trang và dùng kem chăm sóc da hàng ngày', 80000
EXEC InsertDichVu N'Làm sáng da', N'Điều trị và làm sáng da, giảm tình trạng da tối màu', 180000
EXEC InsertDichVu N'Chăm sóc da toàn diện VIP', N'Rửa mặt, tẩy trang, điều trị mụn, áp dụng mặt nạ và masage chăm sóc da', 350000

-- LICH KHAM
EXEC InsertLichKham 'BN000001', 'CK000001', 'DV000001', '2023-10-01', N'Sáng', '2023-10-01 09:00:00'
EXEC InsertLichKham 'BN000002', 'CK000002', 'DV000002', '2023-10-02', N'Chiều', '2023-10-02 15:00:00'
EXEC InsertLichKham 'BN000003', 'CK000001', 'DV000003', '2023-10-03', N'Sáng', '2023-10-03 10:30:00'
EXEC InsertLichKham 'BN000004', 'CK000003', 'DV000004', '2023-10-04', N'Chiều', '2023-10-04 16:00:00'
EXEC InsertLichKham 'BN000005', 'CK000001', 'DV000005', '2023-10-05', N'Sáng', '2023-10-05 11:30:00'
EXEC InsertLichKham 'BN000006', 'CK000002', 'DV000006', '2023-10-06', N'Chiều', '2023-10-06 14:30:00'
EXEC InsertLichKham 'BN000007', 'CK000003', 'DV000007', '2023-10-07', N'Sáng', '2023-10-07 10:00:00'
EXEC InsertLichKham 'BN000008', 'CK000001', 'DV000008', '2023-10-08', N'Chiều', '2023-10-08 15:30:00'
EXEC InsertLichKham 'BN000001', 'CK000002', 'DV000006', '2023-10-09', N'Sáng', '2023-10-09 11:00:00'
EXEC InsertLichKham 'BN000005', 'CK000001', 'DV000007', '2023-10-10', N'Chiều', '2023-10-10 14:00:00'
EXEC InsertLichKham 'BN000003', 'CK000001', 'DV000004', '2023-10-11', N'Sáng', '2023-10-11 09:30:00'
EXEC InsertLichKham 'BN000004', 'CK000002', 'DV000005', '2023-10-12', N'Chiều', '2023-10-12 16:30:00'
EXEC InsertLichKham 'BN000002', 'CK000003', 'DV000003', '2023-10-13', N'Sáng', '2023-10-13 10:00:00'
EXEC InsertLichKham 'BN000007', 'CK000001', 'DV000002', '2023-10-14', N'Chiều', '2023-10-14 14:30:00'
EXEC InsertLichKham 'BN000008', 'CK000003', 'DV000001', '2023-10-15', N'Sáng', '2023-10-15 11:30:00'
-- HOA DON
EXEC InsertHoaDon 'LK000001', 200000, N'Tiền mặt'
EXEC InsertHoaDon  'LK000002', 150000, N'Thẻ tín dụng'
EXEC InsertHoaDon  'LK000003', 180000, N'Tiền mặt'
EXEC InsertHoaDon  'LK000004', 220000, N'Thẻ tín dụng'
EXEC InsertHoaDon 'LK000005', 250000, N'Tiền mặt'
EXEC InsertHoaDon  'LK000006', 280000, N'Thẻ tín dụng'
EXEC InsertHoaDon 'LK000007', 200000, N'Tiền mặt'
EXEC InsertHoaDon  'LK000008', 300000, N'Thẻ tín dụng'
EXEC InsertHoaDon  'LK000009', 270000, N'Tiền mặt'
EXEC InsertHoaDon  'LK000010', 190000, N'Thẻ tín dụng'
EXEC InsertHoaDon  'LK000011', 210000, N'Tiền mặt'
EXEC InsertHoaDon  'LK000012', 240000, N'Thẻ tín dụng'
EXEC InsertHoaDon 'LK000013', 260000, N'Tiền mặt'
EXEC InsertHoaDon 'LK000014', 290000, N'Thẻ tín dụng'
EXEC InsertHoaDon  'LK000015', 220000, N'Tiền mặt'
-- TOA THUOC
EXEC InsertToaThuoc '1', 'TH000001', 'BA000001', N'Thuốc Innerb Aqua Rich', 3, N'Viên', N'Uống sau ăn'
EXEC InsertToaThuoc '2', 'TH000002', 'BA000002', N'Thuốc Puritan’s Pride', 2, N'Thuốc lỏng', N'Uống trước khi đi ngủ'
EXEC InsertToaThuoc '3', 'TH000003', 'BA000003', N'Thuốc Bounty', 1, N'Viên', N'Uống vào buổi sáng'
EXEC InsertToaThuoc '4', 'TH000004', 'BA000004', N'Thuốc Royal Jelly', 4, N'Thuốc lỏng', N'Uống trước khi ăn'
EXEC InsertToaThuoc '5', 'TH000005', 'BA000005', N'Thuốc L Glutathione', 3, N'Viên', N'Uống sau khi ăn'
EXEC InsertToaThuoc '6', 'TH000006', 'BA000006', N'Thuốc Blackmores Insolar', 2, N'Viên', N'Uống vào buổi sáng'
EXEC InsertToaThuoc '7', 'TH000007', 'BA000007', N'Thuốc Shiseid White', 1, N'Thuốc lỏng', N'Uống trước khi đi ngủ'
EXEC InsertToaThuoc '8', 'TH000008', 'BA000008', N'Thuốc Perles de Peau', 3, N'Viên', N'Uống sau khi ăn'
EXEC InsertToaThuoc '9', 'TH000009', 'BA000001', N'Thuốc Collagen DHC', 2, N'Thuốc lỏng', N'Uống trước khi đi ngủ'
EXEC InsertToaThuoc '10', 'TH000010', 'BA000002', N'Thuốc Vitamin E Nipro', 3, N'Viên', N'Uống sau khi ăn'
EXEC InsertToaThuoc '11', 'TH000011', 'BA000008', N'Thuốc Murad Age Reform', 1, N'Thuốc lỏng', N'Uống trước khi đi ngủ'
EXEC InsertToaThuoc '12', 'TH000012', 'BA000003', N'Thuốc Glutathione', 4, N'Viên', N'Uống sau khi ăn'
EXEC InsertToaThuoc '13', 'TH000013', 'BA000005', N'Thuốc Peau Radieuse', 2, N'Viên', N'Uống vào buổi sáng'
EXEC InsertToaThuoc '14', 'TH000014', 'BA000006', N'Thuốc L-Glutathione', 3, N'Thuốc lỏng', N'Uống trước khi đi ngủ'
EXEC InsertToaThuoc '15', 'TH000015', 'BA000007', N'Thuốc Bounty', 1, N'Viên', N'Uống vào buổi sáng'
EXEC InsertToaThuoc '16', 'TH000016', 'BA000004', N'Thuốc Royal Jelly', 2, N'Viên', N'Uống vào buổi sáng'

-- TAI KHOAN THANH VIEN
EXEC InsertTaiKhoanThanhVien N'Nguyễn Hoàng Nam', 'Abc@1234', '1990-05-15', N'Nam', '056162641224', '0987654132', 'namnguyen@gmail.com', N'Phường 13, Bình Thạnh, Thành phố HCM', N'Da liễu', N'Bác sĩ', 'BS'
EXEC InsertTaiKhoanThanhVien N'Trần Diễm Quỳnh', 'Bcd@5678', '1985-07-20', N'Nữ', '056727182433', '0987123415', 'quynhdiem@gmail.com', N'Phường 14, Bình Thạnh, Thành phố HCM', N'Da liễu', N'Bác sĩ', 'BS'
EXEC InsertTaiKhoanThanhVien N'Lê Nguyễn Nam', 'Cde@9012', '1988-03-10', N'Nam', '052827361224', '0909988219', 'lenam@gmail.com', N'Phường 10, Phú Nhuận, Thành phố HCM', N'Da liễu', N'Bác sĩ', 'BS'
EXEC InsertTaiKhoanThanhVien N'Phạm Thị Duyên', 'Def@3456', '1992-09-05', N'Nữ', '051272841255', '0871656243', 'phamthiduyen@gmail.com', N'Phường 2, Tân Bình, Thành phố HCM', N'Da liễu', N'Bác sĩ', 'BS'
EXEC InsertTaiKhoanThanhVien N'Hoàng Văn Thụ', 'Efg@6789', '1995-01-25', N'Nam', '056909182742', '0172614217', 'hoangvanthu@gmail.com', N'Phường 13, Tân Bình, Thành phố HCM', N'Da liễu', N'Kế toán', 'KT'
EXEC InsertTaiKhoanThanhVien N'Võ Mai', 'Fgh@7890', '1989-08-15', N'Nữ', '054712719322', '0817262478', 'vomai@gmail.com', N'Tây Thạnh, Tân Phú, Thành phố HCM', N'Da liễu', N'Kế toán', 'KT'
EXEC InsertTaiKhoanThanhVien N'Đặng Văn Lâm', 'Ghi@1234', '1987-03-02', N'Nam', '051832622432', '08176535237', 'dangvanlam@gmail.com', N'Tân Quý, Tân Phú, Thành phố HCM', N'Da liễu', N'Kế toán', 'KT'
EXEC InsertTaiKhoanThanhVien N'Mai Nguyễn Trà', 'Hik@5678', '1986-11-12', N'Nữ', '056187264125', '0987274128', 'maitra@gmail.com', N'Phú Thạnh, Tân Phú,Thành phố HCM', N'Không', N'Lễ tân', 'TV'
EXEC InsertTaiKhoanThanhVien N'Nguyễn Nữ', 'Ijk@7890', '1984-10-05', N'Nữ', '056717827429', '0898716244', 'nguyennu@gmail.com', N'Bình Hưng Hoà, Bình Tân, Thành phố HCM', N'Da liễu', N'Thư ký', 'KT'
EXEC InsertTaiKhoanThanhVien N'Trần Đình Nhân', 'Jlm@1234', '1983-12-30', N'Nam', '056718721488', '0891872425', 'trandinhnhan@gmail.com', N'Tân Tạo A, Bình Tân, Thành phố HCM', N'Da liễu', N'Thư ký', 'KT'
EXEC InsertTaiKhoanThanhVien N'Trần Hưng', 'Thung@1234', '1983-12-30', N'Nam', '301884688123', '0898134671', 'tranhung@gmail.com', N'Tân Tạo B, Bình Tân, Thành phố HCM', N'Da liễu', N'Bác sĩ', 'BS'


-- SO KHAM BENH
EXEC SoKhamBenh_Insert 'BN000001', 'LK000001', N'Nguyễn Văn An', '33', 'BHYT0321344414', N'Bình Hưng, Bình Chánh, Thành phố HCM', N'Kỹ sư', N'Kinh', N'Nổi mụn đỏ và ngứa da', N'Bị dị ứng da', N'Sử dụng thuốc chống dị ứng và tránh tiếp xúc với chất kích thích', N'Nguyễn Hoàng Nam', NULL
EXEC SoKhamBenh_Insert 'BN000002', 'LK000002', N'Trần Mỹ Nữ', '38', 'BHYT0827281342', N'Bình Hưng, Bình Chánh, Thành phố HCM', N'Giáo viên', N'Kinh', N'Da sưng, đỏ và ngứa', N'Bị viêm da cơ địa', N'Sử dụng thuốc chống viêm và tránh tiếp xúc với chất kích thích', N'Phạm Thị Duyên', NULL
EXEC SoKhamBenh_Insert 'BN000003', 'LK000003', N'Lê Văn Luyện', '35', 'BHYT0192781634', N'Boulevard, Quận 1, Thành phố HCM', N'Bác sĩ', N'Kinh', N'Mụn nước và đau rát', N'Bị nấm da', N'Sử dụng thuốc chống nấm và tuân thủ vệ sinh cá nhân', N'Trần Diễm Quỳnh', NULL
EXEC SoKhamBenh_Insert 'BN000004', 'LK000004', N'Phạm Thị Kim Tiến', '29', 'BHYT0454372749', N'Phường 12, Quận 10, Thành phố HCM', N'Y tá', N'Kinh', N'Sưng và đỏ da', N'Bị viêm da dị ứng', N'Sử dụng thuốc chống viêm và tránh tiếp xúc với chất kích thích', N'Trần Diễm Quỳnh', NULL
EXEC SoKhamBenh_Insert 'BN000005', 'LK000005', N'Hoàng Ngọc Quý', '28', 'BHYT0817321244', N'Bình Trị Đông B, Bình Tân, Thành phố HCM', N'Kỹ sư', N'Kinh', N'Đau và khó chịu da', N'Bị viêm da', N'Sử dụng thuốc chống viêm và tuân thủ vệ sinh cá nhân', N'Trần Diễm Quỳnh', NULL
EXEC SoKhamBenh_Insert 'BN000006', 'LK000006', N'Võ Duyên Trúc', '31', 'BHYT0318321845', N'KCN Đức Hoà 1, ấp 5, Đức Hòa, Long An', N'Chuyên viên kinh doanh', N'Kinh', N'Da khô và ngứa', N'Bị viêm da khô', N'Sử dụng thuốc chống viêm và giữ ẩm da', N'Trần Diễm Quỳnh', NULL
EXEC SoKhamBenh_Insert 'BN000007', 'LK000007', N'Đặng Minh Thắng', '34', 'BHYT0192814245', N'Thống Nhất, Thành phố Biên Hòa, Đồng Nai', N'Nhân viên văn phòng', N'Kinh', N'Da nổi mụn và đau', N'Bị mụn trứng cá', N'Sử dụng thuốc chống viêm và tránh tiếp xúc với chất kích thích', N'Phạm Thị Duyên', NULL
EXEC SoKhamBenh_Insert 'BN000008', 'LK000008', N'Mai Thị Thuỷ', '39', 'BHYT0239421445', N'Đa Kao, Quận 1, Thành phố HCM', N'Luật sư', N'Kinh', N'Da bị nổi mụn và đỏ', N'Bị viêm da dị ứng', N'Sử dụng thuốc chống viêm và tránh tiếp xúc với chất kích thích', N'Lê Nguyễn Nam', NULL
EXEC SoKhamBenh_Insert 'BN000009', 'LK000009', N'Lý Văn Nguyên', '45', 'BHYT0987371633', N'Bình An, Quận 2, Thành phố HCM', N'Kỹ sư', N'Kinh', N'Da bị đau và ngứa', N'Bị nấm da', N'Sử dụng thuốc chống nấm và tuân thủ vệ sinh cá nhân', N'Nguyễn Hoàng Nam', NULL
EXEC SoKhamBenh_Insert 'BN000010', 'LK000010', N'Nguyễn Thị Thuý', '32', 'BHYT0918274124', N'Phú Mỹ Hưng, Quận 7, Thành phố HCM', N'Giáo viên', N'Kinh', N'Nổi mụn và đau rát da', N'Bị viêm da', N'Sử dụng thuốc chống viêm và tránh tiếp xúc với chất kích thích', N'Nguyễn Hoàng Nam', NULL
EXEC SoKhamBenh_Insert 'BN000011', 'LK000011', N'Trần Nhân Tâm', '29', 'BHYT0127471562', N'Tân Phú, Quận 7, Thành phố HCM', N'Trình dược viên', N'Kinh', N'Da khô và ngứa', N'Bị viêm da khô', N'Sử dụng thuốc chống viêm và giữ ẩm da', N'Trần Diễm Quỳnh', NULL
EXEC SoKhamBenh_Insert 'BN000012', 'LK000012', N'Đinh Thị Mai Đinh', '38', 'BHYT0918271413', N'Tân Hưng, Quận 7, Thành phố HCM', N'Kỹ sư', N'Kinh', N'Da nổi mụn và đau', N'Bị mụn trứng cá', N'Sử dụng thuốc chống viêm và tránh tiếp xúc với chất kích thích', N'TPhạm Thị Duyên', NULL
EXEC SoKhamBenh_Insert 'BN000013', 'LK000013', N'Lê Hoàng Ngọc', '27', 'BHYT0234141246', N'Phường 12, Quận 4, Thành phố HCM', N'Thợ may', N'Kinh', N'Da bị nổi mụn và đỏ', N'Bị viêm da dị ứng', N'Sử dụng thuốc chống viêm và tránh tiếp xúc với chất kích thích', N'Trần Diễm Quỳnh', NULL
EXEC SoKhamBenh_Insert 'BN000014', 'LK000014', N'Võ Mỹ Kim Thoa', '35', 'BHYT0918274123', N'Phường 22, Bình Thạnh, Thành phố HCM', N'Nhân viên kinh doanh', N'Kinh', N'Da nổi mụn và đau', N'Bị mụn trứng cá', N'Sử dụng thuốc chống viêm và tránh tiếp xúc với chất kích thích', N'Trần Diễm Quỳnh', NULL
EXEC SoKhamBenh_Insert 'BN000015', 'LK000015', N'Phan Văn Hội', '41', 'BHYT0362783945', N'Hiệp Bình Chánh, Thủ Đức, Thành phố HCM', N'Nhân viên bảo vệ', N'Kinh', N'Da bị đau và ngứa', N'Bị nấm da', N'Sử dụng thuốc chống nấm và tuân thủ vệ sinh cá nhân', N'Lê Nguyễn Nam', NULL


-- LICH LAM VIEC
EXEC InsertLichLamViec N'Nguyễn Hoàng Nam', 'BS000001', '2023-10-01', 'S'
EXEC InsertLichLamViec N'Trần Diễm Quỳnh', 'BS000002', '2023-10-02', 'C'
EXEC InsertLichLamViec N'Lê Nguyễn Nam', 'BS000003', '2023-10-03', 'S'
EXEC InsertLichLamViec N'Phạm Thị Duyên', 'BS000004', '2023-10-04', 'C'
EXEC InsertLichLamViec N'Nguyễn Hoàng Nam', 'BS000001', '2023-10-01', 'S'
EXEC InsertLichLamViec N'Trần Diễm Quỳnh', 'BS000002', '2023-10-02', 'C'
EXEC InsertLichLamViec N'Lê Nguyễn Nam', 'BS000003', '2023-10-03', 'S'
EXEC InsertLichLamViec N'Phạm Thị Duyên', 'BS000004', '2023-10-04', 'C'