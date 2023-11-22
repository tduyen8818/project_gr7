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
--=================FUNCTION
CREATE FUNCTION SelectDangKyUser (@SoDienThoai varchar(10))
RETURNS TABLE
AS
RETURN (
    SELECT *
    FROM DangKyUser
    WHERE SoDienThoai = @SoDienThoai
);


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
--#####################PROCEDURE INSERT
CREATE PROCEDURE DangKyUser_Insert
    @SoDienThoai varchar(10),
    @MatKhau varchar(8)
AS
BEGIN
    INSERT INTO DangKyUser (SoDienThoai, MatKhau)
    VALUES (@SoDienThoai, @MatKhau)
END

CREATE PROCEDURE UpdateDangKyUser
    @SoDienThoai varchar(10),
    @MatKhau varchar(8)
AS
BEGIN
    UPDATE DangKyUser
    SET MatKhau = @MatKhau
    WHERE SoDienThoai = @SoDienThoai;
END

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
--=================FUNCTION
CREATE FUNCTION SelectHoSoBenhNhan (@MaHoSoBenhNhan varchar(8))
RETURNS TABLE
AS
RETURN (
    SELECT *
    FROM HoSoBenhNhan
    WHERE MaHoSoBenhNhan = @MaHoSoBenhNhan
);


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
ALTER TABLE SoKhamBenh ADD CONSTRAINT FK_SoKhamBenhHoSoBenhNhan FOREIGN KEY (MaHoSoBenhNhan) REFERENCES HoSoBenhNhan(MaHoSoBenhNhan);
--=================FUNCTION
CREATE FUNCTION SelectSoKhamBenh (@MaHoSoBenhNhan varchar(8), @MaLichKham varchar(8))
RETURNS TABLE
AS
RETURN (
    SELECT *
    FROM SoKhamBenh
    WHERE MaHoSoBenhNhan = @MaHoSoBenhNhan AND MaLichKham = @MaLichKham
);


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

--**********************TRIGGER



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
--=================FUNCTION
CREATE FUNCTION SelectBenhAn (@MaBenhAn varchar(8))
RETURNS TABLE
AS
RETURN (
    SELECT *
    FROM BenhAn
    WHERE MaBenhAn = @MaBenhAn
);


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

CREATE PROCEDURE UpdateBenhAn
    @MaBenhAn varchar(8),
    @MaHoSoBenhNhan varchar(8),
    @DoiTuong nvarchar(8),
    @GiaTriBHYT date,
    @HoTenThanNhan nvarchar(30),
    @ThoiGianVaoVien nvarchar(30),
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
    @ToaThan nvarchar(30),
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
        ToaThan = @ToaThan,
        TrieuChungCoNang = @TrieuChungCoNang,
        ThuongTonCanBan = @ThuongTonCanBan,
        CacCoQuan = @CacCoQuan,
        TKetQuaTrinhBenhLy = @TKetQuaTrinhBenhLy,
        TomTatKQXN = @TomTatKQXN,
        PhuongPhapDieuTri = @PhuongPhapDieuTri,
        HoSoPhimAnh = @HoSoPhimAnh
    WHERE MaBenhAn = @MaBenhAn;
END

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
ALTER TABLE ToaThuoc ADD CONSTRAINT FK_ToaThuocBenhAn FOREIGN KEY (MaBenhAn) REFERENCES BenhAn(MaBenhAn)
--=================FUNCTION
CREATE FUNCTION SelectToaThuoc (@MaToaThuoc varchar(8))
RETURNS TABLE
AS
RETURN (
    SELECT *
    FROM ToaThuoc
    WHERE MaToaThuoc = @MaToaThuoc
);


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

--**********************TRIGGER



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
--=================FUNCTION
CREATE FUNCTION SelectHoaDon (@MaHoaDon varchar(8))
RETURNS TABLE
AS
RETURN (
    SELECT *
    FROM HoaDon
    WHERE MaHoaDon = @MaHoaDon
);


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

CREATE PROCEDURE UpdateHoaDon
    @MaHoaDon varchar(8),
    @MaMaHoSoBenhNhan varchar(8),
    @MaLichKham varchar(8),
    @TongTien int,
    @HinhThucThanhToan nvarchar(30)
AS
BEGIN
    UPDATE HoaDon
    SET 
        MaMaHoSoBenhNhan = @MaMaHoSoBenhNhan,
        MaLichKham = @MaLichKham,
        TongTien = @TongTien,
        HinhThucThanhToan = @HinhThucThanhToan
    WHERE MaHoaDon = @MaHoaDon;
END

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

--**********************TRIGGER



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
--=================FUNCTION
CREATE FUNCTION SelectKhuyenMai (@MaKhuyenMai varchar(8))
RETURNS TABLE
AS
RETURN (
    SELECT *
    FROM KhuyenMai
    WHERE MaKhuyenMai = @MaKhuyenMai
);


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

CREATE PROCEDURE UpdateKhuyenMai
    @MaKhuyenMai varchar(8),
    @TenChuongTrinhKM nvarchar(30),
    @NoiDungKM nvarchar(50),
    @ThoiGianBatDau datetime,
    @ThoiGianKetThuc datetime
AS
BEGIN
    UPDATE KhuyenMai
    SET 
        TenChuongTrinhKM = @TenChuongTrinhKM,
        NoiDungKM = @NoiDungKM,
        ThoiGianBatDau = @ThoiGianBatDau,
        ThoiGianKetThuc = @ThoiGianKetThuc
    WHERE MaKhuyenMai = @MaKhuyenMai;
END

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
--=================FUNCTION
CREATE FUNCTION SelectDichVu (@MaDichVu varchar(8))
RETURNS TABLE
AS
RETURN (
    SELECT *
    FROM DichVu
    WHERE MaDichVu = @MaDichVu
);


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
--=================FUNCTION
CREATE FUNCTION SelectChuyenKhoa (@MaChuyenKhoa varchar(8))
RETURNS TABLE
AS
RETURN (
    SELECT *
    FROM ChuyenKhoa
    WHERE MaChuyenKhoa = @MaChuyenKhoa
);


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
ALTER TABLE LichKham ADD CONSTRAINT FK_LichKhamHoSoBenhNhan FOREIGN KEY (MaHoSoBenhNhan) REFERENCES HoSoBenhNhan(MaHoSoBenhNhan)
ALTER TABLE LichKham ADD CONSTRAINT FK_LichKhamHoSoBenhNhan FOREIGN KEY (MaHoSoBenhNhan) REFERENCES HoSoBenhNhan(MaHoSoBenhNhan)
ALTER TABLE LichKham ADD CONSTRAINT FK_LichKhamChuyenKhoa FOREIGN KEY (MaChuyenKhoa) REFERENCES ChuyenKhoa(MaChuyenKhoa)
ALTER TABLE LichKham ADD CONSTRAINT FK_LichKhamDichVu FOREIGN KEY (MaDichVu) REFERENCES DichVu(MaDichVu)
--=================FUNCTION
CREATE FUNCTION SelectLichKham (@MaLichKham varchar(8))
RETURNS TABLE
AS
RETURN (
    SELECT *
    FROM LichKham
    WHERE MaLichKham = @MaLichKham
);


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

--**********************TRIGGER



--/////////////// ADMIN
CREATE TABLE ADMIN_Manager
(
	MaAdmin varchar(8) NOT NULL,
	MatKhau varchar(8),
)
ALTER TABLE ADMIN_Manager ADD CONSTRAINT PK_ADMINMananger PRIMARY KEY (MaAdmin)
--=================FUNCTION
CREATE FUNCTION SelectAdminManager (@MaAdmin varchar(8))
RETURNS TABLE
AS
RETURN (
    SELECT *
    FROM ADMIN_Manager
    WHERE MaAdmin = @MaAdmin
);


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
--=================FUNCTION
CREATE FUNCTION SelectTaiKhoanThanhVien (@MaThanhVien varchar(8))
RETURNS TABLE
AS
RETURN (
    SELECT *
    FROM TaiKhoanThanhVien
    WHERE MaThanhVien = @MaThanhVien
);


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
        LoaiTaiKhoan = @LoaiTaiKhoa
    WHERE MaThanhVien = @MaThanhVien;
END

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


--**********************TRIGGER


--//////////////////// Lich lam viec
CREATE TABLE LichLamViec
(
	MaLichLamViec varchar(8) NOT NULL,
	HoVaTen nvarchar(30),
	MaThanhVien varchar(8),
	Ngay date,
	Ca varchar(2)
)
ALTER TABLE LichLamViec ADD CONSTRAINT PK_LichLamViec PRIMARY KEY (MaLichLamViec)
ALTER TABLE LichLamViec ADD CONSTRAINT FK_LichViecTaiKhoanThanhVien FOREIGN KEY (MaThanhVien) REFERENCES TaiKhoanThanhVien(MaThanhVien)
--=================FUNCTION
CREATE FUNCTION SelectLichLamViec (@MaLichLamViec varchar(8))
RETURNS TABLE
AS
RETURN (
    SELECT *
    FROM LichLamViec
    WHERE MaLichLamViec = @MaLichLamViec
);


CREATE FUNCTION GetLichLamViecByParam(@MaLichLamViec varchar(8), @ParamName varchar(50)) RETURNS nvarchar(50)
AS
BEGIN
    DECLARE @Result nvarchar(50)
    IF @ParamName = 'HoVaTen'
        SELECT @Result = HoVaTen FROM LichLamViec WHERE MaLichLamViec = @MaLichLamViec
    ELSE IF @ParamName = 'MaThanhVien'
        SELECT @Result = MaThanhVien FROM LichLamViec WHERE MaLichLamViec = @MaLichLamViec
    --ELSE IF @ParamName = 'Thang'
        --SELECT @Result = CONVERT(nvarchar(50), Thang, 121) FROM LichLamViec WHERE MaLichLamViec = @MaLichLamViec
    ELSE IF @ParamName = 'Ngay'
        SELECT @Result = CONVERT(nvarchar(50), Ngay, 121) FROM LichLamViec WHERE MaLichLamViec = @MaLichLamViec
    ELSE IF @ParamName = 'Ca'
        SELECT @Result = Ca FROM LichLamViec WHERE MaLichLamViec = @MaLichLamViec
    ELSE
        SET @Result = 'Invalid Parameter'
    RETURN @Result
END

CREATE PROCEDURE UpdateLichLamViec
    @MaLichLamViec varchar(8),
    @HoVaTen nvarchar(30),
    @MaThanhVien varchar(8),
    --@Thang date,
    @Ngay date,
    @Ca varchar(2)
AS
BEGIN
    UPDATE LichLamViec
    SET
        HoVaTen = @HoVaTen,
        MaThanhVien = @MaThanhVien,
        --Thang = @Thang,
        Ngay = @Ngay,
        Ca = @Ca
    WHERE MaLichLamViec = @MaLichLamViec;
END

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
	else if(@STT < 10000)
		SET @mahosobenhnhan = 'BN' + '0' + CAST(@STT AS varchar(5))
	else
		SET @mahosobenhnhan = 'BN' + CAST(@STT AS varchar(6))
	RETURN @mahosobenhnhan
END
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
	else if(@STT < 10000)
		SET @madichvu = 'DV' + '0' + CAST(@STT AS varchar(5))
	else
		SET @madichvu = 'DV' + CAST(@STT AS varchar(6))
	RETURN @madichvu
END
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
--[[[[[[[[[[[[[[[[[

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

--################ PROCEDURE INSERT
CREATE PROCEDURE InsertADMIN_Manager
    @MaAdmin varchar(8),
    @MatKhau varchar(8)
AS
BEGIN
    INSERT INTO ADMIN_Manager (MaAdmin, MatKhau)
    VALUES (@MaAdmin, @MatKhau)
END

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
--################### PROCEDURE INSERT
CREATE PROCEDURE BenhAn_Insert
    @MaHoSoBenhNhan varchar(8),
    @DoiTuong nvarchar(8),
    @GiaTriBHYT date,
    @HoTenThanNhan nvarchar(30),
    @ThoiGianVaoVien nvarchar(30),
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
    @ToaThan nvarchar(30),
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
    INSERT INTO BenhAn (MaBenhAn, MaHoSoBenhNhan, DoiTuong, GiaTriBHYT, HoTenThanNhan, ThoiGianVaoVien, TrucTiepVao, NoiGioiThieu, VaoKhoa, ChuyenKhoa, TongSoNgayDieuTri, NoiChuyenDen, KKBorCapCuu, KhiVaoKhoaDieuTri, KetQuaDieuTri, GiaiPhauBenh, QuaTrinhBenhLy, TienSuBenh, ToaThan, TrieuChungCoNang, ThuongTonCanBan, CacCoQuan, TKetQuaTrinhBenhLy, TomTatKQXN, PhuongPhapDieuTri, HoSoPhimAnh)
    VALUES (@mabenhan, @MaHoSoBenhNhan, @DoiTuong, @GiaTriBHYT, @HoTenThanNhan, @ThoiGianVaoVien, @TrucTiepVao, @NoiGioiThieu, @VaoKhoa, @ChuyenKhoa, @TongSoNgayDieuTri, @NoiChuyenDen, @KKBorCapCuu, @KhiVaoKhoaDieuTri, @KetQuaDieuTri, @GiaiPhauBenh, @QuaTrinhBenhLy, @TienSuBenh, @ToaThan, @TrieuChungCoNang, @ThuongTonCanBan, @CacCoQuan, @TKetQuaTrinhBenhLy, @TomTatKQXN, @PhuongPhapDieuTri, @HoSoPhimAnh)
END

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
--################ PROCEDURE INSERT
CREATE PROCEDURE InsertHoaDon
    @MaMaHoSoBenhNhan varchar(8),
    @MaLichKham varchar(8),
    @TongTien int,
    @HinhThucThanhToan nvarchar(30)
AS
BEGIN
	DECLARE @mahoadon varchar(8)
	SET @mahoadon = dbo.GetNewMaHoaDon()
    INSERT INTO HoaDon (MaHoaDon, MaMaHoSoBenhNhan, MaLichKham, TongTien, HinhThucThanhToan)
    VALUES (@mahoadon, @MaMaHoSoBenhNhan, @MaLichKham, @TongTien, @HinhThucThanhToan)
END

--################ PROCEDURE INSERT
CREATE PROCEDURE InsertKhuyenMai
    @TenChuongTrinhKM nvarchar(30),
    @NoiDungKM nvarchar(50),
    @ThoiGianBatDau datetime,
    @ThoiGianKetThuc datetime
AS
BEGIN
	DECLARE @makhuyenmai varchar(8)
	SET @makhuyenmai = dbo.GetNewMaKhuyenMai()
    INSERT INTO KhuyenMai (MaKhuyenMai, TenChuongTrinhKM, NoiDungKM, ThoiGianBatDau, ThoiGianKetThuc)
    VALUES (@makhuyenmai, @TenChuongTrinhKM, @NoiDungKM, @ThoiGianBatDau, @ThoiGianKetThuc)
END


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

--################ PROCEDURE INSERT


--################ PROCEDURE INSERT
CREATE PROCEDURE InsertLichLamViec
    @HoVaTen nvarchar(30),
    @MaThanhVien varchar(8),
    @Ngay date,
    @Ca varchar(2)
AS
BEGIN
	DECLARE @malichlamviec varchar(8)
	SET @malichlamviec = dbo.GetNewMaLichLamViec()
    INSERT INTO LichLamViec (MaLichLamViec, HoVaTen, MaThanhVien, Ngay, Ca)
    VALUES (@malichlamviec, @HoVaTen, @MaThanhVien, @Ngay, @Ca)
END

--THEM DU LIEU CHO CAC TABLE 
-- TABLE DangKyUer
EXEC DangKyUser_Insert '0123456789', 'Abcd@123'
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
EXEC HoSoBenhNhan_Insert N'Nguyễn Văn A', '0123456789', '1990-05-15', N'Nam', '123456789012', 'BHYT123456789', N'Kỹ sư', '0123456789', 'nguyenvana@example.com', N'123 Đường ABC'
EXEC HoSoBenhNhan_Insert N'Trần Thị B', '0987654321', '1985-10-20', N'Nữ', '234567890123', 'BHYT234567890', N'Giáo viên', '0987654321', 'tranthib@example.com', N'456 Đường XYZ'
EXEC HoSoBenhNhan_Insert N'Lê Văn C', '0369852147', '1992-03-25', N'Nam', '345678901234', 'BHYT345678901', N'Bác sĩ', '0369852147', 'levanc@example.com', N'789 Đường DEF'
EXEC HoSoBenhNhan_Insert N'Phạm Thị D', '0765432198', '1988-12-10', N'Nữ', '456789012345', 'BHYT456789012', N'Y tá', '0765432198', 'phamthid@example.com', N'101 Đường GHI'-- Ví dụ 5
EXEC HoSoBenhNhan_Insert N'Hoàng Văn E', '0932145678', '1995-07-05', N'Nam', '567890123456', 'BHYT567890123', N'Kỹ sư', '0932145678', 'hoangvane@example.com', N'202 Đường JKL'
EXEC HoSoBenhNhan_Insert N'Võ Thị F', '0846512379', '1983-04-30', N'Nữ', '678901234567', 'BHYT678901234', N'Chuyên viên kinh doanh', '0846512379', 'vothif@example.com', N'303 Đường MNO'
EXEC HoSoBenhNhan_Insert N'Đặng Văn G', '0654321890', '1993-11-18', N'Nam', '789012345678', 'BHYT789012345', N'Nhân viên văn phòng', '0654321890', 'dangvang@example.com', N'404 Đường PQR'
EXEC HoSoBenhNhan_Insert N'Mai Thị H', '0312456879', '1991-09-22', N'Nữ', '890123456789', 'BHYT890123456', N'Luật sư', '0312456879', 'maithih@example.com', N'505 Đường STU'
EXEC HoSoBenhNhan_Insert N'Lý Văn I', '0975318642', '1987-08-12', N'Nam', '901234567890', 'BHYT901234567', N'Kỹ sư xây dựng', '0975318642', 'lyvani@example.com', N'606 Đường VWX'
EXEC HoSoBenhNhan_Insert N'Nguyễn Thị K', '0624875139', '1996-06-08', N'Nữ', '012345678912', 'BHYT012345678', N'Bác sĩ', '0624875139', 'nguyenthik@example.com', N'707 Đường YZ'
EXEC HoSoBenhNhan_Insert N'Trần Văn L', '0392187456', '1994-02-14', N'Nam', '123456789123', 'BHYT123456789', N'Giáo viên', '0392187456', 'tranvanl@example.com', N'808 Đường ABC'
EXEC HoSoBenhNhan_Insert N'Đinh Thị M', '0856123497', '1986-03-03', N'Nữ', '234567890234', 'BHYT234567890', N'Y tá', '0856123497', 'dinhthim@example.com', N'909 Đường XYZ'
EXEC HoSoBenhNhan_Insert N'Lê Văn N', '0912345678', '1989-07-19', N'Nam', '345678901345', 'BHYT345678901', N'Kỹ sư', '0912345678', 'levann@example.com', N'1010 Đường DEF'
EXEC HoSoBenhNhan_Insert N'Võ Thị O', '0765432981', '1997-09-28', N'Nữ', '456789012456', 'BHYT456789012', N'Chuyên viên kinh doanh', '0765432981', 'vothio@example.com', N'1111 Đường GHI'
EXEC HoSoBenhNhan_Insert N'Phan Văn P', '0987654320', '1998-12-01', N'Nam', '567890123567', 'BHYT567890123', N'Sinh viên', '0987654320', 'phanvanp@example.com', N'1212 Đường JKL'
-- KHUYEN MAI
EXEC InsertKhuyenMai N'Giảm giá dịch vụ da liễu', N'Giảm 20% cho các dịch vụ điều trị da liễu', '2023-11-01 08:00:00', '2023-11-15 17:00:00'
EXEC InsertKhuyenMai N'Combo chăm sóc da', N'Mua bất kỳ sản phẩm nào và nhận 1 lần spa da miễn phí', '2023-12-05 10:00:00', '2023-12-20 19:00:00'
EXEC InsertKhuyenMai N'Đánh giá da miễn phí', N'Nhận đánh giá da miễn phí từ các chuyên gia da liễu', '2023-09-10 09:30:00', '2023-09-30 18:00:00'
EXEC InsertKhuyenMai N'Phòng ngừa mụn', N'Hướng dẫn cách chăm sóc da để ngừa mụn miễn phí', '2023-10-15 14:00:00', '2023-10-31 20:00:00'
EXEC InsertKhuyenMai N'Giảm giá các sản phẩm da liễu', N'Giảm 15% cho tất cả các sản phẩm chăm sóc da liễu', '2023-11-20 11:30:00', '2023-12-05 22:00:00'
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
EXEC BenhAn_Insert 'BN000001', N'BHYT', '2023-12-31', N'Nguyễn Văn A', '2023-10-25 09:00:00', N'Cấp cứu', N'Phòng khám đa khoa A', N'Da liễu', N'Chăm sóc da trẻ em', '7', N'Không chuyển', N'Không có', N'Nguyên trạng', N'Đã hồi phục', N'Không có', N'Mụn trứng cá', N'Không có', N'Bình thường', N'Ngứa', N'Không có', N'Không có', N'Không có', N'Không có', N'Thuốc và kem chăm sóc da', N'Không có'
EXEC BenhAn_Insert 'BN000002', N'BHYT', '2023-12-31', N'Trần Thị B', '2023-11-03 14:30:00', N'Khám thường xuyên', N'Phòng khám đa khoa B', N'Da liễu', N'Chăm sóc da người già', '10', N'Không chuyển', N'Không có', N'Nguyên trạng', N'Đã hồi phục', N'Không có', N'Nổi mụn', N'Không có', N'Bình thường', N'Đỏ và ngứa', N'Không có', N'Không có', N'Không có', N'Không có', N'Thuốc chống dị ứng và kem chăm sóc da', N'Không có'
EXEC BenhAn_Insert 'BN000003', N'BHYT', '2023-12-31', N'Lê Văn C', '2023-10-29 11:15:00', N'Cấp cứu', N'Phòng khám đa khoa C', N'Da liễu', N'Chăm sóc da người già', '5', N'Không chuyển', N'Không có', N'Nguyên trạng', N'Đã hồi phục', N'Không có', N'Dị ứng da', N'Không có', N'Bình thường', N'Ngứa và đỏ', N'Không có', N'Không có', N'Không có', N'Không có', N'Thuốc chống dị ứng và kem chăm sóc da', N'Không có'
EXEC BenhAn_Insert 'BN000004', N'BHYT', '2023-12-31', N'Phạm Thị D', '2023-11-12 08:45:00', N'Khám thường xuyên', N'Phòng khám đa khoa D', N'Da liễu', N'Chăm sóc da trẻ em', '8', N'Không chuyển', N'Không có', N'Nguyên trạng', N'Đã hồi phục', N'Không có', N'Nổi mụn nước', N'Không có', N'Bình thường', N'Ngứa và đỏ', N'Không có', N'Không có', N'Không có', N'Không có', N'Không có', N'Không có'
EXEC BenhAn_Insert 'BN000005', N'BHYT', '2023-12-31', N'Hoàng Văn E', '2023-11-18 10:20:00', N'Cấp cứu', N'Phòng khám đa khoa E', N'Da liễu', N'Chăm sóc da người già', '6', N'Không chuyển', N'Không có', N'Nguyên trạng', N'Đã hồi phục', N'Không có', N'Nổi mụn nước và đỏ', N'Không có', N'Bình thường', N'Ngứa và đỏ', N'Không có', N'Không có', N'Không có', N'Không có', N'Không có', N'Không có'
EXEC BenhAn_Insert 'BN000006', N'BHYT', '2023-12-31', N'Võ Thị F', '2023-10-30 15:10:00', N'Khám thường xuyên', N'Phòng khám đa khoa F', N'Da liễu', N'Chăm sóc da trẻ em', '4', N'Không chuyển', N'Không có', N'Nguyên trạng', N'Đã hồi phục', N'Không có', N'Dị ứng da', N'Không có', N'Bình thường', N'Ngứa và đỏ', N'Không có', N'Không có', N'Không có', N'Không có', N'Không có', N'Không có'
EXEC BenhAn_Insert 'BN000007', N'BHYT', '2023-12-31', N'Đặng Văn G', '2023-11-20 11:45:00', N'Cấp cứu', N'Phòng khám đa khoa G', N'Da liễu', N'Chăm sóc da người già', '9', N'Không chuyển', N'Không có', N'Nguyên trạng', N'Đã hồi phục', N'Không có', N'Nổi mụn và đỏ', N'Không có', N'Bình thường', N'Ngứa và đỏ', N'Không có', N'Không có', N'Không có', N'Không có', N'Không có', N'Không có'
EXEC BenhAn_Insert 'BN000008', N'BHYT', '2023-12-31', N'Mai Thị H', '2023-11-25 13:30:00', N'Cấp cứu', N'Phòng khám đa khoa H', N'Da liễu', N'Chăm sóc da trẻ em', '3', N'Không chuyển', N'Không có', N'Nguyên trạng', N'Đã hồi phục', N'Không có', N'Dị ứng da', N'Không có', N'Bình thường', N'Ngứa và đỏ', N'Không có', N'Không có', N'Không có', N'Không có', N'Không có', N'Không có'
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
EXEC InsertHoaDon 'BN000001', 'LK000001', 200000, N'Tiền mặt'
EXEC InsertHoaDon 'BN000002', 'LK000002', 150000, N'Thẻ tín dụng'
EXEC InsertHoaDon 'BN000003', 'LK000003', 180000, N'Tiền mặt'
EXEC InsertHoaDon 'BN000004', 'LK000004', 220000, N'Thẻ tín dụng'
EXEC InsertHoaDon 'BN000005', 'LK000005', 250000, N'Tiền mặt'
EXEC InsertHoaDon 'BN000006', 'LK000006', 280000, N'Thẻ tín dụng'
EXEC InsertHoaDon 'BN000007', 'LK000007', 200000, N'Tiền mặt'
EXEC InsertHoaDon 'BN000008', 'LK000008', 300000, N'Thẻ tín dụng'
EXEC InsertHoaDon 'BN000001', 'LK000009', 270000, N'Tiền mặt'
EXEC InsertHoaDon 'BN000002', 'LK000010', 190000, N'Thẻ tín dụng'
EXEC InsertHoaDon 'BN000003', 'LK000011', 210000, N'Tiền mặt'
EXEC InsertHoaDon 'BN000004', 'LK000012', 240000, N'Thẻ tín dụng'
EXEC InsertHoaDon 'BN000005', 'LK000013', 260000, N'Tiền mặt'
EXEC InsertHoaDon 'BN000006', 'LK000014', 290000, N'Thẻ tín dụng'
EXEC InsertHoaDon 'BN000007', 'LK000015', 220000, N'Tiền mặt'
-- TOA THUOC
EXEC InsertToaThuoc '1', 'TH000001', 'BA000001', N'Thuốc A', 3, N'Viên', N'Uống sau ăn'
EXEC InsertToaThuoc '2', 'TH000002', 'BA000002', N'Thuốc B', 2, N'Thuốc lỏng', N'Uống trước khi đi ngủ'
EXEC InsertToaThuoc '3', 'TH000003', 'BA000003', N'Thuốc C', 1, N'Viên', N'Uống vào buổi sáng'
EXEC InsertToaThuoc '1', 'TH000004', 'BA000004', N'Thuốc D', 4, N'Thuốc lỏng', N'Uống trước khi ăn'
EXEC InsertToaThuoc '2', 'TH000005', 'BA000005', N'Thuốc E', 3, N'Viên', N'Uống sau khi ăn'
EXEC InsertToaThuoc '1', 'TH000006', 'BA000006', N'Thuốc F', 2, N'Viên', N'Uống vào buổi sáng'
EXEC InsertToaThuoc '2', 'TH000007', 'BA000007', N'Thuốc G', 1, N'Thuốc lỏng', N'Uống trước khi đi ngủ'
EXEC InsertToaThuoc '1', 'TH000008', 'BA000008', N'Thuốc H', 3, N'Viên', N'Uống sau khi ăn'
-- TAI KHOAN THANH VIEN
EXEC InsertTaiKhoanThanhVien N'Nguyễn Văn A', 'Abc@1234', '1990-05-15', N'Nam', '123456789012', '0987654321', 'nguyenvana@gmail.com', N'Số 1, Đường ABC, Quận XYZ, Thành phố HCM', N'Da liễu', N'Bác sĩ', 'BS'
EXEC InsertTaiKhoanThanhVien N'Trần Thị B', 'Bcd@5678', '1985-07-20', N'Nữ', '234567890123', '0987123456', 'tranthib@gmail.com', N'Số 2, Đường XYZ, Quận ABC, Thành phố HCM', N'Da liễu', N'Bác sĩ', 'BS'
EXEC InsertTaiKhoanThanhVien N'Lê Văn C', 'Cde@9012', '1988-03-10', N'Nam', '345678901234', '0909123456', 'levanc@gmail.com', N'Số 3, Đường XYZ, Quận ABC, Thành phố HCM', N'Da liễu', N'Bác sĩ', 'BS'
EXEC InsertTaiKhoanThanhVien N'Phạm Thị D', 'Def@3456', '1992-09-05', N'Nữ', '456789012345', '0908456123', 'phamthid@gmail.com', N'Số 4, Đường XYZ, Quận ABC, Thành phố HCM', N'Da liễu', N'Bác sĩ', 'BS'
EXEC InsertTaiKhoanThanhVien N'Hoàng Văn E', 'Efg@6789', '1995-01-25', N'Nam', '567890123456', '0908123456', 'hoangvane@gmail.com', N'Số 5, Đường XYZ, Quận ABC, Thành phố HCM', N'Da liễu', N'Kế toán', 'KT'
EXEC InsertTaiKhoanThanhVien N'Võ Thị F', 'Fgh@7890', '1989-08-15', N'Nữ', '678901234567', '0908789123', 'vothif@gmail.com', N'Số 6, Đường XYZ, Quận ABC, Thành phố HCM', N'Da liễu', N'Kế toán', 'KT'
EXEC InsertTaiKhoanThanhVien N'Đặng Văn G', 'Ghi@1234', '1987-03-02', N'Nam', '789012345678', '0908789456', 'dangvang@gmail.com', N'Số 7, Đường XYZ, Quận ABC, Thành phố HCM', N'Da liễu', N'Kế toán', 'KT'
EXEC InsertTaiKhoanThanhVien N'Mai Thị H', 'Hik@5678', '1986-11-12', N'Nữ', '890123456789', '0908456123', 'maithih@gmail.com', N'Số 8, Đường XYZ, Quận ABC, Thành phố HCM', N'Không', N'Lễ tân', 'TV'
EXEC InsertTaiKhoanThanhVien N'Nguyễn Thị I', 'Ijk@7890', '1984-10-05', N'Nữ', '901234567890', '0908567123', 'nguyenthii@gmail.com', N'Số 9, Đường XYZ, Quận ABC, Thành phố HCM', N'Da liễu', N'Thư ký', 'KT'
EXEC InsertTaiKhoanThanhVien N'Trần Văn J', 'Jlm@1234', '1983-12-30', N'Nam', '012345678901', '0908123789', 'tranvanj@gmail.com', N'Số 10, Đường XYZ, Quận ABC, Thành phố HCM', N'Da liễu', N'Thư ký', 'KT'
EXEC InsertTaiKhoanThanhVien N'Trần Văn U', 'Jlm@1234', '1983-12-30', N'Nam', '012345678901', '0908123789', 'tranvanj@gmail.com', N'Số 10, Đường XYZ, Quận ABC, Thành phố HCM', N'Da liễu', N'Thư ký', 'KT'

-- SO KHAM BENH
EXEC SoKhamBenh_Insert 'BN000001', 'LK000001', N'Nguyễn Văn A', '33', 'BHYT123456789', N'Số 1, Đường ABC, Quận XYZ, Thành phố HCM', N'Kỹ sư', N'Kinh', N'Nổi mụn đỏ và ngứa da', N'Bị dị ứng da', N'Sử dụng thuốc chống dị ứng và tránh tiếp xúc với chất kích thích', N'Lê Văn C', NULL
EXEC SoKhamBenh_Insert 'BN000002', 'LK000002', N'Trần Thị B', '38', 'BHYT234567890', N'Số 2, Đường XYZ, Quận ABC, Thành phố HCM', N'Giáo viên', N'Kinh', N'Da sưng, đỏ và ngứa', N'Bị viêm da cơ địa', N'Sử dụng thuốc chống viêm và tránh tiếp xúc với chất kích thích', N'Lê Văn C', NULL
EXEC SoKhamBenh_Insert 'BN000003', 'LK000003', N'Lê Văn C', '35', 'BHYT345678901', N'Số 3, Đường XYZ, Quận ABC, Thành phố HCM', N'Bác sĩ', N'Kinh', N'Mụn nước và đau rát', N'Bị nấm da', N'Sử dụng thuốc chống nấm và tuân thủ vệ sinh cá nhân', N'Lê Văn C', NULL
EXEC SoKhamBenh_Insert 'BN000004', 'LK000004', N'Phạm Thị D', '29', 'BHYT456789012', N'Số 4, Đường XYZ, Quận ABC, Thành phố HCM', N'Y tá', N'Kinh', N'Sưng và đỏ da', N'Bị viêm da dị ứng', N'Sử dụng thuốc chống viêm và tránh tiếp xúc với chất kích thích', N'Lê Văn C', NULL
EXEC SoKhamBenh_Insert 'BN000005', 'LK000005', N'Hoàng Văn E', '28', 'BHYT567890123', N'Số 5, Đường XYZ, Quận ABC, Thành phố HCM', N'Kỹ sư', N'Kinh', N'Đau và khó chịu da', N'Bị viêm da', N'Sử dụng thuốc chống viêm và tuân thủ vệ sinh cá nhân', N'Lê Văn C', NULL
EXEC SoKhamBenh_Insert 'BN000006', 'LK000006', N'Võ Thị F', '31', 'BHYT678901234', N'Số 6, Đường XYZ, Quận ABC, Thành phố HCM', N'Chuyên viên kinh doanh', N'Kinh', N'Da khô và ngứa', N'Bị viêm da khô', N'Sử dụng thuốc chống viêm và giữ ẩm da', N'Lê Văn C', NULL
EXEC SoKhamBenh_Insert 'BN000007', 'LK000007', N'Đặng Văn G', '34', 'BHYT789012345', N'Số 7, Đường XYZ, Quận ABC, Thành phố HCM', N'Nhân viên văn phòng', N'Kinh', N'Da nổi mụn và đau', N'Bị mụn trứng cá', N'Sử dụng thuốc chống viêm và tránh tiếp xúc với chất kích thích', N'Lê Văn C', NULL
EXEC SoKhamBenh_Insert 'BN000008', 'LK000008', N'Mai Thị H', '39', 'BHYT890123456', N'Số 8, Đường XYZ, Quận ABC, Thành phố HCM', N'Luật sư', N'Kinh', N'Da bị nổi mụn và đỏ', N'Bị viêm da dị ứng', N'Sử dụng thuốc chống viêm và tránh tiếp xúc với chất kích thích', N'Lê Văn C', NULL
-- LICH LAM VIEC
EXEC InsertLichLamViec N'Nguyễn Văn A', 'BS000001', '2023-10-01', 'S'
EXEC InsertLichLamViec N'Trần Thị B', 'BS000002', '2023-10-02', 'C'
EXEC InsertLichLamViec N'Lê Văn C', 'BS000003', '2023-10-03', 'S'
EXEC InsertLichLamViec N'Phạm Thị D', 'BS000004', '2023-10-04', 'C'
EXEC InsertLichLamViec N'Nguyễn Văn A', 'BS000001', '2023-10-01', 'S'
EXEC InsertLichLamViec N'Trần Thị B', 'BS000002', '2023-10-02', 'C'
EXEC InsertLichLamViec N'Lê Văn C', 'BS000003', '2023-10-03', 'S'
EXEC InsertLichLamViec N'Phạm Thị D', 'BS000004', '2023-10-04', 'C'
DROP FUNCTION GetNewMaThanhVien
DROP FUNCTION GetNewMaThanhVienBacSi
DROP FUNCTION GetNewMaThanhVienKeToan
---SUA LOI
DROP FUNCTION GetNewMaThanhVien
DROP FUNCTION GetNewMaThanhVienBacSi
DROP FUNCTION GetNewMaThanhVienKeToan
DELETE FROM TaiKhoanThanhVien WHERE MaThanhVien = 'KT000005'
DELETE FROM TaiKhoanThanhVien WHERE MaThanhVien = 'KT000006'
DELETE FROM TaiKhoanThanhVien WHERE MaThanhVien = 'KT000007'
DELETE FROM TaiKhoanThanhVien WHERE MaThanhVien = 'TV000008'
DELETE FROM TaiKhoanThanhVien WHERE MaThanhVien = 'KT000009'

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

CREATE FUNCTION SelectBenhAnByMaHSBN (@MaHoSoBenhNhan varchar(8))
RETURNS TABLE
AS
RETURN (
    SELECT *
    FROM BenhAn
    WHERE MaHoSoBenhNhan = @MaHoSoBenhNhan
);

drop function SelectBenhAnByMaHSBN