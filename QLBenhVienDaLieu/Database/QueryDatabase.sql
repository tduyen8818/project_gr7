use master
go

use PHONGKHAMDALIEU
go

select * from DangKyUser
select * from HoSoBenhNhan
select * from SoKhamBenh
select * from BenhAn
select * from ToaThuoc
select * from HoaDon
select * from KhuyenMai
select * from DichVu
select * from ChuyenKhoa
select * from LichKham
select * from ADMIN_Manager
select * from TaiKhoanThanhVien
select * from LichLamViec

EXEC DeleteToaThuoc @MaToaThuoc = 'TT000001'


