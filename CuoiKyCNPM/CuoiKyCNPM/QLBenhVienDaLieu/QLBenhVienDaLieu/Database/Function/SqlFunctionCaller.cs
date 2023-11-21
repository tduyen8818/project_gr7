//PHẦN HÀM SHOW TẤT CẢ THÔNG TIN CỦA 1 BẢNG DỰA VÀO NHẬP MÃ SỐ
using Guna.UI2.WinForms;
using QLBenhVienDaLieu.Database.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace QLBenhVienDaLieu.Database.Function
{
    public class SqlFunctionCaller
    {
        private string connectionString;
        private SqlConnection connection;

        public SqlFunctionCaller()
        {
            const string serverName = "LAPTOP-4M06U5";
            const string databaseName = "PHONGKHAMDALIEU";
            //const string userName = "quang";
            //const string password = "123";

            this.connectionString = $"Data Source={serverName};" +
                $"Initial Catalog={databaseName};" + "Initial Catalog=PHONGKHAMDALIEU;Integrated Security=True";
                //$"User id={userName};" +
                //$"Password={password};";

            this.connection = new SqlConnection(connectionString);

        }

        public SqlFunctionCaller(string connectionString)
        {
            this.connectionString = connectionString;
            connection = new SqlConnection(connectionString);
        }

        public void Connect()
        {
            try
            {
                connection.Open();
                Debug.WriteLine("Connect Success");

            }
            catch (SqlException e)
            {
                Debug.WriteLine(e.Message);
            }

        }

        public void Close()
        {
            try
            {
                connection.Close();
                Debug.WriteLine("Closed");

            }
            catch (SqlException e)
            {
                Debug.WriteLine(e.Message);
            }

        }

        private DataTable GetResultTable(String query, SqlConnection sqlConnection)
        {
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable resultTable = new DataTable();
            adapter.Fill(resultTable);

            return resultTable;
        }

        private DataTable GetResultTable(String query, SqlConnection sqlConnection, string value)
        {
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@value", value);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable resultTable = new DataTable();
            adapter.Fill(resultTable);

            return resultTable;
        }

        private DataTable GetResultTable(String query, SqlConnection sqlConnection, int value)
        {
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@value", value);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable resultTable = new DataTable();
            adapter.Fill(resultTable);

            return resultTable;
        }

        private DataTable GetResultTable(String query, SqlConnection sqlConnection, DateTime value)
        {
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@value", value);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable resultTable = new DataTable();
            adapter.Fill(resultTable);

            return resultTable;
        }

        private List<DangKyUser> GetListDangKyUser(DataTable resultTable)
        {
            List<DangKyUser> listDangKyUser = new List<DangKyUser>();

            foreach (DataRow row in resultTable.Rows)
            {
                DangKyUser dangKyUser = new DangKyUser();

                dangKyUser.SoDienThoai = row["SoDienThoai"].ToString();
                dangKyUser.MatKhau = row["MatKhau"].ToString();

                listDangKyUser.Add(dangKyUser);
            }

            return listDangKyUser;
        }

        private DangKyUser GetDangKyUser(DataTable resultTable)
        {
            DangKyUser dangKyUser = new DangKyUser();

            foreach (DataRow row in resultTable.Rows)
            {
                dangKyUser.SoDienThoai = row["SoDienThoai"].ToString();
                dangKyUser.MatKhau = row["MatKhau"].ToString();
                return dangKyUser;
            }

            return dangKyUser;
        }

        private List<HoSoBenhNhan> GetListHoSoBenhNhan(DataTable resultTable)
        {
            List<HoSoBenhNhan> listHoSoBenhNhan = new List<HoSoBenhNhan>();

            foreach (DataRow row in resultTable.Rows)
            {
                HoSoBenhNhan hoSoBenhNhan = new HoSoBenhNhan();

                hoSoBenhNhan.HoVaTen = row["HoVaTen"].ToString();
                hoSoBenhNhan.MaHoSoBenhNhan = row["MaHoSoBenhNhan"].ToString();
                hoSoBenhNhan.MaTaiKhoan = row["MaTaiKhoan"].ToString();
                hoSoBenhNhan.NgaySinh = DateTime.Parse(row["NgaySinh"].ToString());
                hoSoBenhNhan.GioiTinh = row["GioiTinh"].ToString();
                hoSoBenhNhan.CCCD = row["CCCD"].ToString();
                hoSoBenhNhan.MaBHYT = row["MaBHYT"].ToString();
                hoSoBenhNhan.NgheNghiep = row["NgheNghiep"].ToString();
                hoSoBenhNhan.SoDienThoai = row["SoDienThoai"].ToString();
                hoSoBenhNhan.Email = row["Email"].ToString();
                hoSoBenhNhan.DiaChi = row["DiaChi"].ToString();

                listHoSoBenhNhan.Add(hoSoBenhNhan);
            }

            return listHoSoBenhNhan;
        }

        private HoSoBenhNhan GetHoSoBenhNhan(DataTable resultTable)
        {
            HoSoBenhNhan hoSoBenhNhan = new HoSoBenhNhan();

            foreach (DataRow row in resultTable.Rows)
            {
                hoSoBenhNhan.HoVaTen = row["HoVaTen"].ToString();
                hoSoBenhNhan.MaHoSoBenhNhan = row["MaHoSoBenhNhan"].ToString();
                hoSoBenhNhan.MaTaiKhoan = row["MaTaiKhoan"].ToString();
                hoSoBenhNhan.NgaySinh = DateTime.Parse(row["NgaySinh"].ToString());
                hoSoBenhNhan.GioiTinh = row["GioiTinh"].ToString();
                hoSoBenhNhan.CCCD = row["CCCD"].ToString();
                hoSoBenhNhan.MaBHYT = row["MaBHYT"].ToString();
                hoSoBenhNhan.NgheNghiep = row["NgheNghiep"].ToString();
                hoSoBenhNhan.SoDienThoai = row["SoDienThoai"].ToString();
                hoSoBenhNhan.Email = row["Email"].ToString();
                hoSoBenhNhan.DiaChi = row["DiaChi"].ToString();

                return hoSoBenhNhan;
            }

            return hoSoBenhNhan;
        }

        private List<SoKhamBenh> GetListSoKhamBenh(DataTable resultTable)
        {
            List<SoKhamBenh> listSoKhamBenh = new List<SoKhamBenh>();

            foreach (DataRow row in resultTable.Rows)
            {
                SoKhamBenh soKhamBenh = new SoKhamBenh();

                soKhamBenh.MaHoSoBenhNhan = row["MaHoSoBenhNhan"].ToString();
                soKhamBenh.MaLichKham = row["MaLichKham"].ToString();
                soKhamBenh.HoVaTen = row["HoVaTen"].ToString();
                soKhamBenh.Tuoi = row["Tuoi"].ToString();
                soKhamBenh.SoTheBHYT = row["SoTheBHYT"].ToString();
                soKhamBenh.DiaChi = row["DiaChi"].ToString();
                soKhamBenh.NgheNghiep = row["NgheNghiep"].ToString();
                soKhamBenh.DanToc = row["DanToc"].ToString();
                soKhamBenh.TrieuChung = row["TrieuChung"].ToString();
                soKhamBenh.ChanDoan = row["ChanDoan"].ToString();
                soKhamBenh.PhuongPhapDieuTri = row["PhuongPhapDieuTri"].ToString();
                soKhamBenh.BsKhamBenh = row["BSKhamBenh"].ToString();
                soKhamBenh.GhiChu = row["GhiChu"].ToString();

                listSoKhamBenh.Add(soKhamBenh);
            }

            return listSoKhamBenh;
        }

        private SoKhamBenh GetSoKhamBenh(DataTable resultTable)
        {
            SoKhamBenh soKhamBenh = new SoKhamBenh();

            foreach (DataRow row in resultTable.Rows)
            {
                soKhamBenh.MaHoSoBenhNhan = row["MaHoSoBenhNhan"].ToString();
                soKhamBenh.MaLichKham = row["MaLichKham"].ToString();
                soKhamBenh.HoVaTen = row["HoVaTen"].ToString();
                soKhamBenh.Tuoi = row["Tuoi"].ToString();
                soKhamBenh.SoTheBHYT = row["SoTheBHYT"].ToString();
                soKhamBenh.DiaChi = row["DiaChi"].ToString();
                soKhamBenh.NgheNghiep = row["NgheNghiep"].ToString();
                soKhamBenh.DanToc = row["DanToc"].ToString();
                soKhamBenh.TrieuChung = row["TrieuChung"].ToString();
                soKhamBenh.ChanDoan = row["ChanDoan"].ToString();
                soKhamBenh.PhuongPhapDieuTri = row["PhuongPhapDieuTri"].ToString();
                soKhamBenh.BsKhamBenh = row["BSKhamBenh"].ToString();
                soKhamBenh.GhiChu = row["GhiChu"].ToString();

                return soKhamBenh;
            }

            return soKhamBenh;
        }

        private List<BenhAn> GetListBenhAn(DataTable resultTable)
        {
            List<BenhAn> listBenhAn = new List<BenhAn>();

            foreach (DataRow row in resultTable.Rows)
            {
                BenhAn benhAn = new BenhAn();

                benhAn.MaBenhAn = row["MaBenhAn"].ToString();
                benhAn.MaHoSoBenhNhan = row["MaHoSoBenhNhan"].ToString();
                benhAn.DoiTuong = row["DoiTuong"].ToString();
                benhAn.GiaTriBHYT = DateTime.Parse(row["GiaTriBHYT"].ToString());
                benhAn.HoTenThanNhan = row["HoTenThanNhan"].ToString();
                benhAn.ThoiGianVaoVien = DateTime.Parse(row["ThoiGianVaoVien"].ToString());
                benhAn.TrucTiepVao = row["TrucTiepVao"].ToString();
                benhAn.NoiGioiThieu = row["NoiGioiThieu"].ToString();
                benhAn.VaoKhoa = row["VaoKhoa"].ToString();
                benhAn.ChuyenKhoa = row["ChuyenKhoa"].ToString();
                benhAn.TongSoNgayDieuTri = row["TongSoNgayDieuTri"].ToString();
                benhAn.NoiChuyenDen = row["NoiChuyenDen"].ToString();
                benhAn.KkBorCapCuu = row["KKBorCapCuu"].ToString();
                benhAn.KhiVaoKhoaDieuTri = row["KhiVaoKhoaDieuTri"].ToString();
                benhAn.KetQuaDieuTri = row["KetQuaDieuTri"].ToString();
                benhAn.GiaiPhauBenh = row["GiaiPhauBenh"].ToString();
                benhAn.QuaTrinhBenhLy = row["QuaTrinhBenhLy"].ToString();
                benhAn.TienSuBenh = row["TienSuBenh"].ToString();
                benhAn.ToanThan = row["ToanThan"].ToString();
                benhAn.TrieuChungCoNang = row["TrieuChungCoNang"].ToString();
                benhAn.ThuongTonCanBan = row["ThuongTonCanBan"].ToString();
                benhAn.CacCoQuan = row["CacCoQuan"].ToString();
                benhAn.TKetQuaTrinhBenhLy = row["TKetQuaTrinhBenhLy"].ToString();
                benhAn.TomTatKQXN = row["TomTatKQXN"].ToString();
                benhAn.PhuongPhapDieuTri = row["PhuongPhapDieuTri"].ToString();
                benhAn.HoSoPhimAnh = row["HoSoPhimAnh"].ToString();

                listBenhAn.Add(benhAn);
            }

            return listBenhAn;
        }

        private BenhAn GetBenhAn(DataTable resultTable)
        {
            BenhAn benhAn = new BenhAn();

            foreach (DataRow row in resultTable.Rows)
            {
                benhAn.MaBenhAn = row["MaBenhAn"].ToString();
                benhAn.MaHoSoBenhNhan = row["MaHoSoBenhNhan"].ToString();
                benhAn.DoiTuong = row["DoiTuong"].ToString();
                benhAn.GiaTriBHYT = DateTime.Parse(row["GiaTriBHYT"].ToString());
                benhAn.HoTenThanNhan = row["HoTenThanNhan"].ToString();
                benhAn.ThoiGianVaoVien = DateTime.Parse(row["ThoiGianVaoVien"].ToString());
                benhAn.TrucTiepVao = row["TrucTiepVao"].ToString();
                benhAn.NoiGioiThieu = row["NoiGioiThieu"].ToString();
                benhAn.VaoKhoa = row["VaoKhoa"].ToString();
                benhAn.ChuyenKhoa = row["ChuyenKhoa"].ToString();
                benhAn.TongSoNgayDieuTri = row["TongSoNgayDieuTri"].ToString();
                benhAn.NoiChuyenDen = row["NoiChuyenDen"].ToString();
                benhAn.KkBorCapCuu = row["KKBorCapCuu"].ToString();
                benhAn.KhiVaoKhoaDieuTri = row["KhiVaoKhoaDieuTri"].ToString();
                benhAn.KetQuaDieuTri = row["KetQuaDieuTri"].ToString();
                benhAn.GiaiPhauBenh = row["GiaiPhauBenh"].ToString();
                benhAn.QuaTrinhBenhLy = row["QuaTrinhBenhLy"].ToString();
                benhAn.TienSuBenh = row["TienSuBenh"].ToString();
                benhAn.ToanThan = row["ToanThan"].ToString();
                benhAn.TrieuChungCoNang = row["TrieuChungCoNang"].ToString();
                benhAn.ThuongTonCanBan = row["ThuongTonCanBan"].ToString();
                benhAn.CacCoQuan = row["CacCoQuan"].ToString();
                benhAn.TKetQuaTrinhBenhLy = row["TKetQuaTrinhBenhLy"].ToString();
                benhAn.TomTatKQXN = row["TomTatKQXN"].ToString();
                benhAn.PhuongPhapDieuTri = row["PhuongPhapDieuTri"].ToString();
                benhAn.HoSoPhimAnh = row["HoSoPhimAnh"].ToString();

                return benhAn;
            }

            return benhAn;
        }

        private List<ToaThuoc> GetListToaThuoc(DataTable resultTable)
        {
            List<ToaThuoc> listToaThuoc = new List<ToaThuoc>();

            foreach (DataRow row in resultTable.Rows)
            {
                ToaThuoc toaThuoc = new ToaThuoc();

                toaThuoc.SoThuTu = Int32.Parse(row["SoThuTu"].ToString());
                toaThuoc.MaToaThuoc = row["MaToaThuoc"].ToString();
                toaThuoc.MaThuoc = row["MaThuoc"].ToString();
                toaThuoc.MaBenhAn = row["MaBenhAn"].ToString();
                toaThuoc.TenThuoc = row["TenThuoc"].ToString();
                toaThuoc.SoLuong = Int32.Parse(row["SoLuong"].ToString());
                toaThuoc.Dang = row["Dang"].ToString();
                toaThuoc.GhiChu = row["GhiChu"].ToString();

                listToaThuoc.Add(toaThuoc);
            }

            return listToaThuoc;
        }

        private ToaThuoc GetToaThuoc(DataTable resultTable)
        {
            ToaThuoc toaThuoc = new ToaThuoc();

            foreach (DataRow row in resultTable.Rows)
            {
                toaThuoc.SoThuTu = Int32.Parse(row["SoThuTu"].ToString());
                toaThuoc.MaToaThuoc = row["MaToaThuoc"].ToString();
                toaThuoc.MaThuoc = row["MaThuoc"].ToString();
                toaThuoc.MaBenhAn = row["MaBenhAn"].ToString();
                toaThuoc.TenThuoc = row["TenThuoc"].ToString();
                toaThuoc.SoLuong = Int32.Parse(row["SoLuong"].ToString());
                toaThuoc.Dang = row["Dang"].ToString();
                toaThuoc.GhiChu = row["GhiChu"].ToString();

                return toaThuoc;
            }

            return toaThuoc;
        }

        private List<HoaDon> GetListHoaDon(DataTable resultTable)
        {
            List<HoaDon> listHoaDon = new List<HoaDon>();

            foreach (DataRow row in resultTable.Rows)
            {
                HoaDon hoaDon = new HoaDon();

                hoaDon.MaHoaDon = row["MaHoaDon"].ToString();
                hoaDon.MaLichKham = row["MaLichKham"].ToString();
                hoaDon.TongTien = Int32.Parse(row["TongTien"].ToString());
                hoaDon.HinhThucThanhToan = row["HinhThucThanhToan"].ToString();

                listHoaDon.Add(hoaDon);
            }

            return listHoaDon;
        }

        private HoaDon GetHoaDon(DataTable resultTable)
        {
            HoaDon hoaDon = new HoaDon();

            foreach (DataRow row in resultTable.Rows)
            {
                hoaDon.MaHoaDon = row["MaHoaDon"].ToString();
                hoaDon.MaLichKham = row["MaLichKham"].ToString();
                hoaDon.TongTien = Int32.Parse(row["TongTien"].ToString());
                hoaDon.HinhThucThanhToan = row["HinhThucThanhToan"].ToString();

                return hoaDon;
            }

            return hoaDon;
        }

        private List<KhuyenMai> GetListKhuyenMai(DataTable resultTable)
        {
            List<KhuyenMai> listKhuyenMai = new List<KhuyenMai>();

            foreach (DataRow row in resultTable.Rows)
            {
                KhuyenMai khuyenMai = new KhuyenMai();

                khuyenMai.MaKhuyenMai = row["MaKhuyenMai"].ToString();
                khuyenMai.TenChuongTrinhKM = row["TenChuongTrinhKM"].ToString();
                khuyenMai.GiaKhuyenMai = row["GiaKhuyenMai"].ToString();
                khuyenMai.NoiDungKM = row["NoiDungKM"].ToString();
                khuyenMai.ThoiGianBatDau = DateTime.Parse(row["ThoiGianBatDau"].ToString());
                khuyenMai.ThoiGianKetThuc = DateTime.Parse(row["ThoiGianKetThuc"].ToString());

                listKhuyenMai.Add(khuyenMai);
            }

            return listKhuyenMai;
        }

        private KhuyenMai GetKhuyenMai(DataTable resultTable)
        {
            KhuyenMai khuyenMai = new KhuyenMai();

            foreach (DataRow row in resultTable.Rows)
            {
                khuyenMai.MaKhuyenMai = row["MaKhuyenMai"].ToString();
                khuyenMai.TenChuongTrinhKM = row["TenChuongTrinhKM"].ToString();
                khuyenMai.GiaKhuyenMai = row["GiaKhuyenMai"].ToString();
                khuyenMai.NoiDungKM = row["NoiDungKM"].ToString();
                khuyenMai.ThoiGianBatDau = DateTime.Parse(row["ThoiGianBatDau"].ToString());
                khuyenMai.ThoiGianKetThuc = DateTime.Parse(row["ThoiGianKetThuc"].ToString());

                return khuyenMai;
            }

            return khuyenMai;
        }

        private List<DichVu> GetListDichVu(DataTable resultTable)
        {
            List<DichVu> listDichVu = new List<DichVu>();

            foreach (DataRow row in resultTable.Rows)
            {
                DichVu dichVu = new DichVu();

                dichVu.MaDichVu = row["MaDichVu"].ToString();
                dichVu.TenDichVu = row["TenDichVu"].ToString();
                dichVu.NoiDungDichVu = row["NoiDungDichVu"].ToString();
                dichVu.GiaDichVu = Int32.Parse(row["GiaDichVu"].ToString());

                listDichVu.Add(dichVu);
            }

            return listDichVu;
        }

        private DichVu GetDichVu(DataTable resultTable)
        {
            DichVu dichVu = new DichVu();

            foreach (DataRow row in resultTable.Rows)
            {
                dichVu.MaDichVu = row["MaDichVu"].ToString();
                dichVu.TenDichVu = row["TenDichVu"].ToString();
                dichVu.NoiDungDichVu = row["NoiDungDichVu"].ToString();
                dichVu.GiaDichVu = Int32.Parse(row["GiaDichVu"].ToString());

                return dichVu;
            }

            return dichVu;
        }

        private List<ChuyenKhoa> GetListChuyenKhoa(DataTable resultTable)
        {
            List<ChuyenKhoa> listChuyenKhoa = new List<ChuyenKhoa>();

            foreach (DataRow row in resultTable.Rows)
            {
                ChuyenKhoa chuyenKhoa = new ChuyenKhoa();

                chuyenKhoa.MaChuyenKhoa = row["MaChuyenKhoa"].ToString();
                chuyenKhoa.TenChuyenKhoa = row["TenChuyenKhoa"].ToString();
                chuyenKhoa.MaKhuyenMai = row["MaKhuyenMai"].ToString();

                listChuyenKhoa.Add(chuyenKhoa);
            }

            return listChuyenKhoa;
        }

        private ChuyenKhoa GetChuyenKhoa(DataTable resultTable)
        {
            ChuyenKhoa chuyenKhoa = new ChuyenKhoa();

            foreach (DataRow row in resultTable.Rows)
            {
                chuyenKhoa.MaChuyenKhoa = row["MaChuyenKhoa"].ToString();
                chuyenKhoa.TenChuyenKhoa = row["TenChuyenKhoa"].ToString();
                chuyenKhoa.MaKhuyenMai = row["MaKhuyenMai"].ToString();

                return chuyenKhoa;
            }

            return chuyenKhoa;
        }

        private List<LichKham> GetListLichKham(DataTable resultTable)
        {
            List<LichKham> listLichKham = new List<LichKham>();

            foreach (DataRow row in resultTable.Rows)
            {
                LichKham lichKham = new LichKham();

                lichKham.MaLichKham = row["MaLichKham"].ToString();
                lichKham.MaHoSoBenhNhan = row["MaHoSoBenhNhan"].ToString();
                lichKham.MaChuyenKhoa = row["MaChuyenKhoa"].ToString();
                lichKham.MaDichVu = row["MaDichVu"].ToString();
                lichKham.NgayDangKy = DateTime.Parse(row["NgayDangKy"].ToString());
                lichKham.Ca = row["Ca"].ToString();
                lichKham.KhungGioKham = DateTime.Parse(row["KhungGioKham"].ToString());

                listLichKham.Add(lichKham);
            }

            return listLichKham;
        }

        private LichKham GetLichKham(DataTable resultTable)
        {
            LichKham lichKham = new LichKham();

            foreach (DataRow row in resultTable.Rows)
            {
                lichKham.MaLichKham = row["MaLichKham"].ToString();
                lichKham.MaHoSoBenhNhan = row["MaHoSoBenhNhan"].ToString();
                lichKham.MaChuyenKhoa = row["MaChuyenKhoa"].ToString();
                lichKham.MaDichVu = row["MaDichVu"].ToString();
                lichKham.NgayDangKy = DateTime.Parse(row["NgayDangKy"].ToString());
                lichKham.Ca = row["Ca"].ToString();
                lichKham.KhungGioKham = DateTime.Parse(row["KhungGioKham"].ToString());

                return lichKham;
            }

            return lichKham;
        }

        private List<AdminManager> GetListAdminManager(DataTable resultTable)
        {
            List<AdminManager> listAdminManager = new List<AdminManager>();

            foreach (DataRow row in resultTable.Rows)
            {
                AdminManager adminManager = new AdminManager();

                adminManager.MaAdmin = row["MaAdmin"].ToString();
                adminManager.MatKhau = row["MatKhau"].ToString();

                listAdminManager.Add(adminManager);
            }

            return listAdminManager;
        }

        private AdminManager GetAdminManager(DataTable resultTable)
        {
            AdminManager adminManager = new AdminManager();

            foreach (DataRow row in resultTable.Rows)
            {
                adminManager.MaAdmin = row["MaAdmin"].ToString();
                adminManager.MatKhau = row["MatKhau"].ToString();

                return adminManager;
            }

            return adminManager;
        }

        private List<TaiKhoanNhanVien> GetListTaiKhoanNhanVien(DataTable resultTable)
        {
            List<TaiKhoanNhanVien> listTaiKhoanNhanVien = new List<TaiKhoanNhanVien>();

            foreach (DataRow row in resultTable.Rows)
            {
                if (row["LoaiTaiKhoan"].ToString().Equals("BS"))
                {
                    TaiKhoanBacSi taiKhoanBacSi = new TaiKhoanBacSi();
                    taiKhoanBacSi.HoVaTen = row["HoVaTen"].ToString();
                    taiKhoanBacSi.MaThanhVien = row["MaThanhVien"].ToString();
                    taiKhoanBacSi.MatKhau = row["MatKhau"].ToString();
                    taiKhoanBacSi.NgaySinh = DateTime.Parse(row["NgaySinh"].ToString());
                    taiKhoanBacSi.GioiTinh = row["GioiTinh"].ToString();
                    taiKhoanBacSi.CCCD = row["CCCD"].ToString();
                    taiKhoanBacSi.SoDienThoai = row["SoDienThoai"].ToString();
                    taiKhoanBacSi.Email = row["Email"].ToString();
                    taiKhoanBacSi.DiaChi = row["DiaChi"].ToString();
                    taiKhoanBacSi.ChuyenKhoa = row["ChuyenKhoa"].ToString();
                    taiKhoanBacSi.ViTri = row["ViTri"].ToString();
                    taiKhoanBacSi.LoaiTaiKhoan = row["LoaiTaiKhoan"].ToString();

                    listTaiKhoanNhanVien.Add(taiKhoanBacSi);

                }
                else if (row["LoaiTaiKhoan"].ToString().Equals("KT"))
                {
                    TaiKhoanKeToan taiKhoanKeToan = new TaiKhoanKeToan();
                    taiKhoanKeToan.HoVaTen = row["HoVaTen"].ToString();
                    taiKhoanKeToan.MaThanhVien = row["MaThanhVien"].ToString();
                    taiKhoanKeToan.MatKhau = row["MatKhau"].ToString();
                    taiKhoanKeToan.NgaySinh = DateTime.Parse(row["NgaySinh"].ToString());
                    taiKhoanKeToan.GioiTinh = row["GioiTinh"].ToString();
                    taiKhoanKeToan.CCCD = row["CCCD"].ToString();
                    taiKhoanKeToan.SoDienThoai = row["SoDienThoai"].ToString();
                    taiKhoanKeToan.Email = row["Email"].ToString();
                    taiKhoanKeToan.DiaChi = row["DiaChi"].ToString();
                    taiKhoanKeToan.ChuyenKhoa = row["ChuyenKhoa"].ToString();
                    taiKhoanKeToan.ViTri = row["ViTri"].ToString();
                    taiKhoanKeToan.LoaiTaiKhoan = row["LoaiTaiKhoan"].ToString();

                    listTaiKhoanNhanVien.Add(taiKhoanKeToan);

                }
                else
                {
                    TaiKhoanLeTan taiKhoanLeTan = new TaiKhoanLeTan();

                    taiKhoanLeTan.HoVaTen = row["HoVaTen"].ToString();
                    taiKhoanLeTan.MaThanhVien = row["MaThanhVien"].ToString();
                    taiKhoanLeTan.MatKhau = row["MatKhau"].ToString();
                    taiKhoanLeTan.NgaySinh = DateTime.Parse(row["NgaySinh"].ToString());
                    taiKhoanLeTan.GioiTinh = row["GioiTinh"].ToString();
                    taiKhoanLeTan.CCCD = row["CCCD"].ToString();
                    taiKhoanLeTan.SoDienThoai = row["SoDienThoai"].ToString();
                    taiKhoanLeTan.Email = row["Email"].ToString();
                    taiKhoanLeTan.DiaChi = row["DiaChi"].ToString();
                    taiKhoanLeTan.ViTri = row["ViTri"].ToString();
                    taiKhoanLeTan.LoaiTaiKhoan = row["LoaiTaiKhoan"].ToString();

                    listTaiKhoanNhanVien.Add(taiKhoanLeTan);
                }
            }

            return listTaiKhoanNhanVien;
        }

        private TaiKhoanNhanVien GetTaiKhoanNhanVien(DataTable resultTable)
        {
            foreach (DataRow row in resultTable.Rows)
            {
                if (row["LoaiTaiKhoan"].ToString().Equals("BS"))
                {
                    TaiKhoanBacSi taiKhoanBacSi = new TaiKhoanBacSi();
                    taiKhoanBacSi.HoVaTen = row["HoVaTen"].ToString();
                    taiKhoanBacSi.MaThanhVien = row["MaThanhVien"].ToString();
                    taiKhoanBacSi.MatKhau = row["MatKhau"].ToString();
                    taiKhoanBacSi.NgaySinh = DateTime.Parse(row["NgaySinh"].ToString());
                    taiKhoanBacSi.GioiTinh = row["GioiTinh"].ToString();
                    taiKhoanBacSi.CCCD = row["CCCD"].ToString();
                    taiKhoanBacSi.SoDienThoai = row["SoDienThoai"].ToString();
                    taiKhoanBacSi.Email = row["Email"].ToString();
                    taiKhoanBacSi.DiaChi = row["DiaChi"].ToString();
                    taiKhoanBacSi.ChuyenKhoa = row["ChuyenKhoa"].ToString();
                    taiKhoanBacSi.ViTri = row["ViTri"].ToString();
                    taiKhoanBacSi.LoaiTaiKhoan = row["LoaiTaiKhoan"].ToString();

                    return taiKhoanBacSi;

                }
                else if (row["LoaiTaiKhoan"].ToString().Equals("KT"))
                {
                    TaiKhoanKeToan taiKhoanKeToan = new TaiKhoanKeToan();
                    taiKhoanKeToan.HoVaTen = row["HoVaTen"].ToString();
                    taiKhoanKeToan.MaThanhVien = row["MaThanhVien"].ToString();
                    taiKhoanKeToan.MatKhau = row["MatKhau"].ToString();
                    taiKhoanKeToan.NgaySinh = DateTime.Parse(row["NgaySinh"].ToString());
                    taiKhoanKeToan.GioiTinh = row["GioiTinh"].ToString();
                    taiKhoanKeToan.CCCD = row["CCCD"].ToString();
                    taiKhoanKeToan.SoDienThoai = row["SoDienThoai"].ToString();
                    taiKhoanKeToan.Email = row["Email"].ToString();
                    taiKhoanKeToan.DiaChi = row["DiaChi"].ToString();
                    taiKhoanKeToan.ChuyenKhoa = row["ChuyenKhoa"].ToString();
                    taiKhoanKeToan.ViTri = row["ViTri"].ToString();
                    taiKhoanKeToan.LoaiTaiKhoan = row["LoaiTaiKhoan"].ToString();

                    return taiKhoanKeToan;

                }
                else
                {
                    TaiKhoanLeTan taiKhoanLeTan = new TaiKhoanLeTan();

                    taiKhoanLeTan.HoVaTen = row["HoVaTen"].ToString();
                    taiKhoanLeTan.MaThanhVien = row["MaThanhVien"].ToString();
                    taiKhoanLeTan.MatKhau = row["MatKhau"].ToString();
                    taiKhoanLeTan.NgaySinh = DateTime.Parse(row["NgaySinh"].ToString());
                    taiKhoanLeTan.GioiTinh = row["GioiTinh"].ToString();
                    taiKhoanLeTan.CCCD = row["CCCD"].ToString();
                    taiKhoanLeTan.SoDienThoai = row["SoDienThoai"].ToString();
                    taiKhoanLeTan.Email = row["Email"].ToString();
                    taiKhoanLeTan.DiaChi = row["DiaChi"].ToString();
                    taiKhoanLeTan.ViTri = row["ViTri"].ToString();
                    taiKhoanLeTan.LoaiTaiKhoan = row["LoaiTaiKhoan"].ToString();

                    return taiKhoanLeTan;
                }
            }

            return new TaiKhoanNhanVien();
        }

        private List<LichLamViec> GetListLichLamViec(DataTable resultTable)
        {
            List<LichLamViec> listLichLamViec = new List<LichLamViec>();

            foreach (DataRow row in resultTable.Rows)
            {
                LichLamViec lichLamViec = new LichLamViec();

                lichLamViec.MaLichLamViec = row["MaLichLamViec"].ToString();
                lichLamViec.HoVaTen = row["HoVaTen"].ToString();
                lichLamViec.MaThanhVien = row["MaThanhVien"].ToString();
                lichLamViec.NgayLamViec = DateTime.Parse(row["NgayLamViec"].ToString());
                lichLamViec.Ca = row["Ca"].ToString();

                listLichLamViec.Add(lichLamViec);
            }

            return listLichLamViec;
        }

        private LichLamViec GetLichLamViec(DataTable resultTable)
        {
            LichLamViec lichLamViec = new LichLamViec();

            foreach (DataRow row in resultTable.Rows)
            {
                lichLamViec.MaLichLamViec = row["MaLichLamViec"].ToString();
                lichLamViec.HoVaTen = row["HoVaTen"].ToString();
                lichLamViec.MaThanhVien = row["MaThanhVien"].ToString();
                lichLamViec.NgayLamViec = DateTime.Parse(row["NgayLamViec"].ToString());
                lichLamViec.Ca = row["Ca"].ToString();

                return lichLamViec;
            }

            return lichLamViec;
        }

        // ---------------------------------------------------------------------------------------------------------------

        // Đăng ký user

        public List<DangKyUser> GetDangKyUser()
        {
            string query = "SELECT * FROM DangKyUser";

            DataTable resultTable = GetResultTable(query, this.connection);

            return GetListDangKyUser(resultTable);
        }

        public DangKyUser GetDangKyUserBySoDienThoai(string soDienThoai)
        {
            string query = $"SELECT * FROM DangKyUser WHERE SoDienThoai = @value";

            DataTable resultTable = GetResultTable(query, this.connection, soDienThoai);

            return GetDangKyUser(resultTable);
        }

        public List<DangKyUser> GetDangKyUserByMatKhau(string matKhau)
        {
            string query = $"SELECT * FROM DangKyUser WHERE MatKhau = @value";

            DataTable resultTable = GetResultTable(query, this.connection, matKhau);

            return GetListDangKyUser(resultTable);
        }


        // Hồ sơ bệnh nhân

        public List<HoSoBenhNhan> GetHoSoBenhNhan()
        {
            string query = "SELECT * FROM HoSoBenhNhan";

            DataTable resultTable = GetResultTable(query, this.connection);

            return GetListHoSoBenhNhan(resultTable);
        }

        public List<HoSoBenhNhan> GetHoSoBenhNhanByHoVaTen(string hoVaTen)
        {
            string query = $"SELECT * FROM HoSoBenhNhan WHERE HoVaTen = @value";

            DataTable resultTable = GetResultTable(query, this.connection, hoVaTen);

            return GetListHoSoBenhNhan(resultTable);
        }

        public HoSoBenhNhan GetHoSoBenhNhanByMaHoSoBenhNhan(string maHoSoBenhNhan)
        {
            string query = $"SELECT * FROM HoSoBenhNhan WHERE MaHoSoBenhNhan = @value";

            DataTable resultTable = GetResultTable(query, this.connection, maHoSoBenhNhan);

            return GetHoSoBenhNhan(resultTable);
        }

        public List<HoSoBenhNhan> GetHoSoBenhNhanByMaTaiKhoan(string maTaiKhoan)
        {
            string query = $"SELECT * FROM HoSoBenhNhan WHERE MaTaiKhoan = @value";

            DataTable resultTable = GetResultTable(query, this.connection, maTaiKhoan);

            return GetListHoSoBenhNhan(resultTable);
        }

        public List<HoSoBenhNhan> GetHoSoBenhNhanBySoDienThoai(string soDienThoai)
        {
            string query = $"SELECT * FROM HoSoBenhNhan WHERE SoDienThoai = @value";

            DataTable resultTable = GetResultTable(query, this.connection, soDienThoai);

            return GetListHoSoBenhNhan(resultTable);
        }

        public List<HoSoBenhNhan> GetHoSoBenhNhanByNgaySinh(DateTime ngaySinh)
        {
            string query = $"SELECT * FROM HoSoBenhNhan WHERE NgaySinh = @value";

            DataTable resultTable = GetResultTable(query, this.connection, ngaySinh);

            return GetListHoSoBenhNhan(resultTable);
        }

        public List<HoSoBenhNhan> GetHoSoBenhNhanByGioiTinh(string gioiTinh)
        {
            string query = $"SELECT * FROM HoSoBenhNhan WHERE GioiTinh = @value";

            DataTable resultTable = GetResultTable(query, this.connection, gioiTinh);

            return GetListHoSoBenhNhan(resultTable);
        }

        public HoSoBenhNhan GetHoSoBenhNhanByCCCD(string CCCD)
        {
            string query = $"SELECT * FROM HoSoBenhNhan WHERE CCCD = @value";

            DataTable resultTable = GetResultTable(query, this.connection, CCCD);

            return GetHoSoBenhNhan(resultTable);
        }

        public HoSoBenhNhan GetHoSoBenhNhanByMaBHYT(string maBHYT)
        {
            string query = $"SELECT * FROM HoSoBenhNhan WHERE MaBHYT = @value";

            DataTable resultTable = GetResultTable(query, this.connection, maBHYT);

            return GetHoSoBenhNhan(resultTable);
        }

        public List<HoSoBenhNhan> GetHoSoBenhNhanByNgheNghiep(string ngheNghiep)
        {
            string query = $"SELECT * FROM HoSoBenhNhan WHERE NgheNghiep = @value";

            DataTable resultTable = GetResultTable(query, this.connection, ngheNghiep);

            return GetListHoSoBenhNhan(resultTable);
        }

        public List<HoSoBenhNhan> GetHoSoBenhNhanByEmail(string email)
        {
            string query = $"SELECT * FROM HoSoBenhNhan WHERE Email = @value";

            DataTable resultTable = GetResultTable(query, this.connection, email);

            return GetListHoSoBenhNhan(resultTable);
        }

        public List<HoSoBenhNhan> GetHoSoBenhNhanByDiaChi(string diaChi)
        {
            string query = $"SELECT * FROM HoSoBenhNhan WHERE DiaChi = @value";
            DataTable resultTable = GetResultTable(query, this.connection, diaChi);

            return GetListHoSoBenhNhan(resultTable);
        }

        // Sổ khám bệnh

        public List<SoKhamBenh> GetSoKhamBenh()
        {
            string query = "SELECT * FROM SoKhamBenh";

            DataTable resultTable = GetResultTable(query, this.connection);

            return GetListSoKhamBenh(resultTable);
        }

        public SoKhamBenh GetSoKhamBenhByMaHoSoBenhNhan(string maHoSoBenhNhan)
        {
            string query = $"SELECT * FROM SoKhamBenh WHERE MaHoSoBenhNhan = @value";

            DataTable resultTable = GetResultTable(query, this.connection, maHoSoBenhNhan);

            return GetSoKhamBenh(resultTable);
        }

        public SoKhamBenh GetSoKhamBenhByMaLichKham(string maLichKham)
        {
            string query = $"SELECT * FROM SoKhamBenh WHERE MaLichKham = @value";

            DataTable resultTable = GetResultTable(query, this.connection, maLichKham);

            return GetSoKhamBenh(resultTable);
        }

        public List<SoKhamBenh> GetSoKhamBenhByHoVaTen(string hoVaTen)
        {
            string query = $"SELECT * FROM SoKhamBenh WHERE HoVaTen = @value";

            DataTable resultTable = GetResultTable(query, this.connection, hoVaTen);

            return GetListSoKhamBenh(resultTable);
        }

        public List<SoKhamBenh> GetSoKhamBenhByTuoi(string tuoi)
        {
            string query = $"SELECT * FROM SoKhamBenh WHERE Tuoi = @value";

            DataTable resultTable = GetResultTable(query, this.connection, tuoi);

            return GetListSoKhamBenh(resultTable);
        }

        public List<SoKhamBenh> GetSoKhamBenhBySoTheBHYT(string soTheBHYT)
        {
            string query = $"SELECT * FROM SoKhamBenh WHERE SoTheBHYT = @value";

            DataTable resultTable = GetResultTable(query, this.connection, soTheBHYT);

            return GetListSoKhamBenh(resultTable);
        }

        public List<SoKhamBenh> GetSoKhamBenhByDiaChi(string diaChi)
        {
            string query = $"SELECT * FROM SoKhamBenh WHERE DiaChi = @value";

            DataTable resultTable = GetResultTable(query, this.connection, diaChi);

            return GetListSoKhamBenh(resultTable);
        }

        public List<SoKhamBenh> GetSoKhamBenhByNgheNghiep(string ngheNghiep)
        {
            string query = $"SELECT * FROM SoKhamBenh WHERE NgheNghiep = @value";

            DataTable resultTable = GetResultTable(query, this.connection, ngheNghiep);

            return GetListSoKhamBenh(resultTable);
        }

        public List<SoKhamBenh> GetSoKhamBenhByDanToc(string danToc)
        {
            string query = $"SELECT * FROM SoKhamBenh WHERE DanToc = @value";

            DataTable resultTable = GetResultTable(query, this.connection, danToc);

            return GetListSoKhamBenh(resultTable);
        }

        public List<SoKhamBenh> GetSoKhamBenhByTrieuChung(string trieuChung)
        {
            string query = $"SELECT * FROM SoKhamBenh WHERE TrieuChung = @value";

            DataTable resultTable = GetResultTable(query, this.connection, trieuChung);

            return GetListSoKhamBenh(resultTable);
        }

        public List<SoKhamBenh> GetSoKhamBenhByChanDoan(string chanDoan)
        {
            string query = $"SELECT * FROM SoKhamBenh WHERE ChanDoan = @value";

            DataTable resultTable = GetResultTable(query, this.connection, chanDoan);

            return GetListSoKhamBenh(resultTable);
        }

        public List<SoKhamBenh> GetSoKhamBenhByPhuongPhapDieuTri(string phuongPhapDieuTri)
        {
            string query = $"SELECT * FROM SoKhamBenh WHERE PhuongPhapDieuTri = @value";

            DataTable resultTable = GetResultTable(query, this.connection, phuongPhapDieuTri);

            return GetListSoKhamBenh(resultTable);
        }

        public List<SoKhamBenh> GetSoKhamBenhByBSKhamBenh(string bsKhamBenh)
        {
            string query = $"SELECT * FROM SoKhamBenh WHERE BSKhamBenh = @value";

            DataTable resultTable = GetResultTable(query, this.connection, bsKhamBenh);

            return GetListSoKhamBenh(resultTable);
        }

        public List<SoKhamBenh> GetSoKhamBenhByGhiChu(string ghiChu)
        {
            string query = $"SELECT * FROM SoKhamBenh WHERE GhiChu = @value";

            DataTable resultTable = GetResultTable(query, this.connection, ghiChu);

            return GetListSoKhamBenh(resultTable);
        }

        // Bệnh án

        public List<BenhAn> GetBenhAn()
        {
            string query = "SELECT * FROM BenhAn";

            DataTable resultTable = GetResultTable(query, this.connection);

            return GetListBenhAn(resultTable);
        }

        public BenhAn GetBenhAnByMaBenhAn(string maBenhAn)
        {
            string query = $"SELECT * FROM BenhAn WHERE MaBenhAn = @value";

            DataTable resultTable = GetResultTable(query, this.connection, maBenhAn);

            return GetBenhAn(resultTable);
        }

        public List<BenhAn> GetBenhAnByMaHoSoBenhNhan(string maHoSoBenhNhan)
        {
            string query = $"SELECT * FROM BenhAn WHERE MaHoSoBenhNhan = @value";

            DataTable resultTable = GetResultTable(query, this.connection, maHoSoBenhNhan);

            return GetListBenhAn(resultTable);
        }

        public List<BenhAn> GetBenhAnByDoiTuong(string doiTuong)
        {
            string query = $"SELECT * FROM BenhAn WHERE DoiTuong = @value";

            DataTable resultTable = GetResultTable(query, this.connection, doiTuong);

            return GetListBenhAn(resultTable);
        }

        public List<BenhAn> GetBenhAnByGiaTriBHYT(string giaTriBHYT)
        {
            string query = $"SELECT * FROM BenhAn WHERE GiaTriBHYT = @value";

            DataTable resultTable = GetResultTable(query, this.connection, giaTriBHYT);

            return GetListBenhAn(resultTable);
        }

        public List<BenhAn> GetBenhAnByHoTenThanNhan(string hoTenThanNhan)
        {
            string query = $"SELECT * FROM BenhAn WHERE HoTenThanNhan = @value";

            DataTable resultTable = GetResultTable(query, this.connection, hoTenThanNhan);

            return GetListBenhAn(resultTable);
        }

        public BenhAn GetBenhAnByThoiGianVaoVien(DateTime thoiGianVaoVien)
        {
            string query = $"SELECT * FROM BenhAn WHERE ThoiGianVaoVien = @value";

            DataTable resultTable = GetResultTable(query, this.connection, thoiGianVaoVien);

            return GetBenhAn(resultTable);
        }

        public List<BenhAn> GetBenhAnByTrucTiepVao(string trucTiepVao)
        {
            string query = $"SELECT * FROM BenhAn WHERE TrucTiepVao = @value";

            DataTable resultTable = GetResultTable(query, this.connection, trucTiepVao);

            return GetListBenhAn(resultTable);
        }

        public List<BenhAn> GetBenhAnByNoiGioiThieu(string noiGioiThieu)
        {
            string query = $"SELECT * FROM BenhAn WHERE NoiGioiThieu = @value";

            DataTable resultTable = GetResultTable(query, this.connection, noiGioiThieu);

            return GetListBenhAn(resultTable);
        }

        public List<BenhAn> GetBenhAnByVaoKhoa(string vaoKhoa)
        {
            string query = $"SELECT * FROM BenhAn WHERE VaoKhoa = @value";

            DataTable resultTable = GetResultTable(query, this.connection, vaoKhoa);

            return GetListBenhAn(resultTable);
        }

        public List<BenhAn> GetBenhAnByChuyenKhoa(string chuyenKhoa)
        {
            string query = $"SELECT * FROM BenhAn WHERE ChuyenKhoa = @value";

            DataTable resultTable = GetResultTable(query, this.connection, chuyenKhoa);

            return GetListBenhAn(resultTable);
        }

        public List<BenhAn> GetBenhAnByTongSoNgayDieuTri(string tongSoNgayDieuTri)
        {
            string query = $"SELECT * FROM BenhAn WHERE TongSoNgayDieuTri = @value";

            DataTable resultTable = GetResultTable(query, this.connection, tongSoNgayDieuTri);

            return GetListBenhAn(resultTable);
        }

        public List<BenhAn> GetBenhAnByNoiChuyenDen(string noiChuyenDen)
        {
            string query = $"SELECT * FROM BenhAn WHERE NoiChuyenDen = @value";

            DataTable resultTable = GetResultTable(query, this.connection, noiChuyenDen);

            return GetListBenhAn(resultTable);
        }

        public List<BenhAn> GetBenhAnByKKBorCapCuu(string kkBorCapCuu)
        {
            string query = $"SELECT * FROM BenhAn WHERE KKBorCapCuu = @value";

            DataTable resultTable = GetResultTable(query, this.connection, kkBorCapCuu);

            return GetListBenhAn(resultTable);
        }

        public List<BenhAn> GetBenhAnByKhiVaoKhoaDieuTri(string khiVaoKhoaDieuTri)
        {
            string query = $"SELECT * FROM BenhAn WHERE KhiVaoKhoaDieuTri = @value";

            DataTable resultTable = GetResultTable(query, this.connection, khiVaoKhoaDieuTri);

            return GetListBenhAn(resultTable);
        }

        public List<BenhAn> GetBenhAnByKetQuaDieuTri(string ketQuaDieuTri)
        {
            string query = $"SELECT * FROM BenhAn WHERE KetQuaDieuTri = @value";

            DataTable resultTable = GetResultTable(query, this.connection, ketQuaDieuTri);

            return GetListBenhAn(resultTable);
        }

        public List<BenhAn> GetBenhAnByGiaiPhauBenh(string giaiPhauBenh)
        {
            string query = $"SELECT * FROM BenhAn WHERE GiaiPhauBenh = @value";

            DataTable resultTable = GetResultTable(query, this.connection, giaiPhauBenh);

            return GetListBenhAn(resultTable);
        }

        public List<BenhAn> GetBenhAnByQuaTrinhBenhLy(string quaTrinhBenhLy)
        {
            string query = $"SELECT * FROM BenhAn WHERE QuaTrinhBenhLy = @value";

            DataTable resultTable = GetResultTable(query, this.connection, quaTrinhBenhLy);

            return GetListBenhAn(resultTable);
        }

        public List<BenhAn> GetBenhAnByTienSuBenh(string tienSuBenh)
        {
            string query = $"SELECT * FROM BenhAn WHERE TienSuBenh = @value";

            DataTable resultTable = GetResultTable(query, this.connection, tienSuBenh);

            return GetListBenhAn(resultTable);
        }

        public List<BenhAn> GetBenhAnByToanThan(string toanThan)
        {
            string query = $"SELECT * FROM BenhAn WHERE ToanThan = @value";

            DataTable resultTable = GetResultTable(query, this.connection, toanThan);

            return GetListBenhAn(resultTable);
        }

        public List<BenhAn> GetBenhAnByTrieuChungCoNang(string trieuChungCoNang)
        {
            string query = $"SELECT * FROM BenhAn WHERE TrieuChungCoNang = @value";

            DataTable resultTable = GetResultTable(query, this.connection, trieuChungCoNang);

            return GetListBenhAn(resultTable);
        }

        public List<BenhAn> GetBenhAnByThuongTonCanBan(string thuongTonCanBan)
        {
            string query = $"SELECT * FROM BenhAn WHERE ThuongTonCanBan = @value";

            DataTable resultTable = GetResultTable(query, this.connection, thuongTonCanBan);

            return GetListBenhAn(resultTable);
        }

        public List<BenhAn> GetBenhAnByCacCoQuan(string cacCoQuan)
        {
            string query = $"SELECT * FROM BenhAn WHERE CacCoQuan = @value";

            DataTable resultTable = GetResultTable(query, this.connection, cacCoQuan);

            return GetListBenhAn(resultTable);
        }

        public List<BenhAn> GetBenhAnByTKetQuaTrinhBenhLy(string tKetQuaTrinhBenhLy)
        {
            string query = $"SELECT * FROM BenhAn WHERE TKetQuaTrinhBenhLy = @value";

            DataTable resultTable = GetResultTable(query, this.connection, tKetQuaTrinhBenhLy);

            return GetListBenhAn(resultTable);
        }

        public List<BenhAn> GetBenhAnByTomTatKQXN(string tomTatKQXN)
        {
            string query = $"SELECT * FROM BenhAn WHERE TomTatKQXN = @value";

            DataTable resultTable = GetResultTable(query, this.connection, tomTatKQXN);

            return GetListBenhAn(resultTable);
        }

        public List<BenhAn> GetBenhAnByPhuongPhapDieuTri(string phuongPhapDieuTri)
        {
            string query = $"SELECT * FROM BenhAn WHERE PhuongPhapDieuTri = @value";

            DataTable resultTable = GetResultTable(query, this.connection, phuongPhapDieuTri);

            return GetListBenhAn(resultTable);
        }

        public List<BenhAn> GetBenhAnByHoSoPhimAnh(string hoSoPhimAnh)
        {
            string query = $"SELECT * FROM BenhAn WHERE HoSoPhimAnh = @value";

            DataTable resultTable = GetResultTable(query, this.connection, hoSoPhimAnh);

            return GetListBenhAn(resultTable);
        }

        // Toa thuốc

        public List<ToaThuoc> GetToaThuoc()
        {
            string query = "SELECT * FROM ToaThuoc";

            DataTable resultTable = GetResultTable(query, this.connection);

            return GetListToaThuoc(resultTable);
        }

        public ToaThuoc GetToaThuocBySoThuTu(string soThuTu)
        {
            string query = $"SELECT * FROM ToaThuoc WHERE SoThuTu = @value";

            DataTable resultTable = GetResultTable(query, this.connection, soThuTu);

            return GetToaThuoc(resultTable);
        }

        public ToaThuoc GetToaThuocByMaToaThuoc(string maToaThuoc)
        {
            string query = $"SELECT * FROM ToaThuoc WHERE MaToaThuoc = @value";

            DataTable resultTable = GetResultTable(query, this.connection, maToaThuoc);

            return GetToaThuoc(resultTable);
        }

        public ToaThuoc GetToaThuocByMaThuoc(string maThuoc)
        {
            string query = $"SELECT * FROM ToaThuoc WHERE MaThuoc = @value";

            DataTable resultTable = GetResultTable(query, this.connection, maThuoc);

            return GetToaThuoc(resultTable);
        }

        public List<ToaThuoc> GetToaThuocByMaBenhAn(string maBenhAn)
        {
            string query = $"SELECT * FROM ToaThuoc WHERE MaBenhAn = @value";

            DataTable resultTable = GetResultTable(query, this.connection, maBenhAn);

            return GetListToaThuoc(resultTable);
        }

        public List<ToaThuoc> GetToaThuocByTenThuoc(string tenThuoc)
        {
            string query = $"SELECT * FROM ToaThuoc WHERE TenThuoc = @value";

            DataTable resultTable = GetResultTable(query, this.connection, tenThuoc);

            return GetListToaThuoc(resultTable);
        }

        public List<ToaThuoc> GetToaThuocBySoLuong(int soLuong)
        {
            string query = $"SELECT * FROM ToaThuoc WHERE SoLuong = @value";

            DataTable resultTable = GetResultTable(query, this.connection, soLuong);

            return GetListToaThuoc(resultTable);
        }

        public List<ToaThuoc> GetToaThuocByDang(string dang)
        {
            string query = $"SELECT * FROM ToaThuoc WHERE Dang = @value";

            DataTable resultTable = GetResultTable(query, this.connection, dang);

            return GetListToaThuoc(resultTable);
        }

        public List<ToaThuoc> GetToaThuocByGhiChu(string ghiChu)
        {
            string query = $"SELECT * FROM ToaThuoc WHERE GhiChu = @value";

            DataTable resultTable = GetResultTable(query, this.connection, ghiChu);

            return GetListToaThuoc(resultTable);
        }

        // Hóa đơn

        public List<HoaDon> GetHoaDon()
        {
            string query = "SELECT * FROM HoaDon";

            DataTable resultTable = GetResultTable(query, this.connection);

            return GetListHoaDon(resultTable);
        }

        public HoaDon GetHoaDonByMaHoaDon(string maHoaDon)
        {
            string query = $"SELECT * FROM HoaDon WHERE MaHoaDon = @value";

            DataTable resultTable = GetResultTable(query, this.connection, maHoaDon);

            return GetHoaDon(resultTable);
        }

        public HoaDon GetHoaDonByMaLichKham(string maLichKham)
        {
            string query = $"SELECT * FROM HoaDon WHERE MaLichKham = @value";

            DataTable resultTable = GetResultTable(query, this.connection, maLichKham);

            return GetHoaDon(resultTable);
        }

        public List<HoaDon> GetHoaDonByTongTien(int tongTien)
        {
            string query = $"SELECT * FROM HoaDon WHERE TongTien = @value";

            DataTable resultTable = GetResultTable(query, this.connection, tongTien);

            return GetListHoaDon(resultTable);
        }

        public List<HoaDon> GetHoaDonByHinhThucThanhToan(string hinhThucThanhToan)
        {
            string query = $"SELECT * FROM HoaDon WHERE HinhThucThanhToan = @value";

            DataTable resultTable = GetResultTable(query, this.connection, hinhThucThanhToan);

            return GetListHoaDon(resultTable);
        }

        // Khuyến mãi

        public List<KhuyenMai> GetKhuyenMai()
        {
            string query = "SELECT * FROM KhuyenMai";

            DataTable resultTable = GetResultTable(query, this.connection);

            return GetListKhuyenMai(resultTable);
        }

        public KhuyenMai GetKhuyenMaiByMaKhuyenMai(string maKhuyenMai)
        {
            string query = $"SELECT * FROM KhuyenMai WHERE MaKhuyenMai = @value";

            DataTable resultTable = GetResultTable(query, this.connection, maKhuyenMai);

            return GetKhuyenMai(resultTable);
        }

        public List<KhuyenMai> GetKhuyenMaiByTenChuongTrinhKM(string tenChuongTrinhKM)
        {
            string query = $"SELECT * FROM KhuyenMai WHERE TenChuongTrinhKM = @value";

            DataTable resultTable = GetResultTable(query, this.connection, tenChuongTrinhKM);

            return GetListKhuyenMai(resultTable);
        }

        public List<KhuyenMai> GetKhuyenMaiByGiaKhuyenMai(string giaKhuyenMai)
        {
            string query = $"SELECT * FROM KhuyenMai WHERE GiaKhuyenMai = @value";

            DataTable resultTable = GetResultTable(query, this.connection, giaKhuyenMai);

            return GetListKhuyenMai(resultTable);
        }

        public List<KhuyenMai> GetKhuyenMaiByThoiGianBatDau(DateTime thoiGianBatDau)
        {
            string query = $"SELECT * FROM KhuyenMai WHERE ThoiGianBatDau = @value";

            DataTable resultTable = GetResultTable(query, this.connection, thoiGianBatDau);

            return GetListKhuyenMai(resultTable);
        }

        public List<KhuyenMai> GetKhuyenMaiByThoiGianKetThuc(DateTime thoiGianKetThuc)
        {
            string query = $"SELECT * FROM KhuyenMai WHERE ThoiGianKetThuc = @value";

            DataTable resultTable = GetResultTable(query, this.connection, thoiGianKetThuc);

            return GetListKhuyenMai(resultTable);
        }

        // Dịch vụ

        public List<DichVu> GetDichVu()
        {
            string query = "SELECT * FROM DichVu";

            DataTable resultTable = GetResultTable(query, this.connection);

            return GetListDichVu(resultTable);
        }

        public DichVu GetDichVuByMaDichVu(string maDichVu)
        {
            string query = $"SELECT * FROM DichVu WHERE MaDichVu = @value";

            DataTable resultTable = GetResultTable(query, this.connection, maDichVu);

            return GetDichVu(resultTable);
        }

        public DichVu GetDichVuByTenDichVu(string tenDichVu)
        {
            string query = $"SELECT * FROM DichVu WHERE TenDichVu = @value";

            DataTable resultTable = GetResultTable(query, this.connection, tenDichVu);

            return GetDichVu(resultTable);
        }

        public List<DichVu> GetDichVuByNoiDungDichVu(string noiDungDichVu)
        {
            string query = $"SELECT * FROM DichVu WHERE NoiDungDichVu = @value";

            DataTable resultTable = GetResultTable(query, this.connection, noiDungDichVu);

            return GetListDichVu(resultTable);
        }

        public List<DichVu> GetDichVuByGiaDichVu(int giaDichVu)
        {
            string query = $"SELECT * FROM DichVu WHERE GiaDichVu = @value";

            DataTable resultTable = GetResultTable(query, this.connection, giaDichVu);

            return GetListDichVu(resultTable);
        }

        // CHuyên khoa

        public List<ChuyenKhoa> GetChuyenKhoa()
        {
            string query = "SELECT * FROM ChuyenKhoa";

            DataTable resultTable = GetResultTable(query, this.connection);

            return GetListChuyenKhoa(resultTable);
        }

        public ChuyenKhoa GetChuyenKhoaByMaChuyenKhoa(string maChuyenKhoa)
        {
            string query = $"SELECT * FROM ChuyenKhoa WHERE MaChuyenKhoa = @value";

            DataTable resultTable = GetResultTable(query, this.connection, maChuyenKhoa);

            return GetChuyenKhoa(resultTable);
        }

        public ChuyenKhoa GetChuyenKhoaByTenChuyenKhoa(string tenChuyenKhoa)
        {
            string query = $"SELECT * FROM ChuyenKhoa WHERE TenChuyenKhoa = @value";

            DataTable resultTable = GetResultTable(query, this.connection, tenChuyenKhoa);

            return GetChuyenKhoa(resultTable);
        }

        public List<ChuyenKhoa> GetChuyenKhoaByMaKhuyenMai(string maKhuyenMai)
        {
            string query = $"SELECT * FROM ChuyenKhoa WHERE MaKhuyenMai = @value";

            DataTable resultTable = GetResultTable(query, this.connection, maKhuyenMai);

            return GetListChuyenKhoa(resultTable);
        }

        // Lịch khám

        public List<LichKham> GetLichKham()
        {
            string query = "SELECT * FROM LichKham";

            DataTable resultTable = GetResultTable(query, this.connection);

            return GetListLichKham(resultTable);
        }

        public LichKham GetLichKhamByMaLichKham(string maLichKham)
        {
            string query = $"SELECT * FROM LichKham WHERE MaLichKham = @value";

            DataTable resultTable = GetResultTable(query, this.connection, maLichKham);

            return GetLichKham(resultTable);
        }

        public List<LichKham> GetLichKhamByMaHoSoBenhNhan(string maHoSoBenhNhan)
        {
            string query = $"SELECT * FROM LichKham WHERE MaHoSoBenhNhan = @value";

            DataTable resultTable = GetResultTable(query, this.connection, maHoSoBenhNhan);

            return GetListLichKham(resultTable);
        }

        public List<LichKham> GetLichKhamByMaChuyenKhoa(string maChuyenKhoa)
        {
            string query = $"SELECT * FROM LichKham WHERE MaChuyenKhoa = @value";

            DataTable resultTable = GetResultTable(query, this.connection, maChuyenKhoa);

            return GetListLichKham(resultTable);
        }

        public List<LichKham> GetLichKhamByMaDichVu(string maDichVu)
        {
            string query = $"SELECT * FROM LichKham WHERE MaDichVu = @value";

            DataTable resultTable = GetResultTable(query, this.connection, maDichVu);

            return GetListLichKham(resultTable);
        }

        public List<LichKham> GetLichKhamByNgayDangKy(DateTime ngayDangKy)
        {
            string query = $"SELECT * FROM LichKham WHERE NgayDangKy = @value";

            DataTable resultTable = GetResultTable(query, this.connection, ngayDangKy);

            return GetListLichKham(resultTable);
        }

        public List<LichKham> GetLichKhamByCa(string ca)
        {
            string query = $"SELECT * FROM LichKham WHERE Ca = @value";

            DataTable resultTable = GetResultTable(query, this.connection, ca);

            return GetListLichKham(resultTable);
        }

        public LichKham GetLichKhamByKhungGioKham(DateTime khungGioKham)
        {
            string query = $"SELECT * FROM LichKham WHERE KhungGioKham = @value";

            DataTable resultTable = GetResultTable(query, this.connection, khungGioKham);

            return GetLichKham(resultTable);
        }

        // Admin manager

        public List<AdminManager> GetAdminManager()
        {
            string query = "SELECT * FROM ADMIN_Manager";

            DataTable resultTable = GetResultTable(query, this.connection);

            return GetListAdminManager(resultTable);
        }

        public AdminManager GetAdminManagerByMaAdmin(string maAdmin)
        {
            string query = $"SELECT * FROM ADMIN_Manager WHERE MaAdmin = @value";

            DataTable resultTable = GetResultTable(query, this.connection, maAdmin);

            return GetAdminManager(resultTable);
        }

        public List<AdminManager> GetAdminManagerByMatKhau(string matKhau)
        {
            string query = $"SELECT * FROM ADMIN_Manager WHERE MatKhau = @value";

            DataTable resultTable = GetResultTable(query, this.connection, matKhau);

            return GetListAdminManager(resultTable);
        }

        // Tài khoản thành viên

        public List<TaiKhoanNhanVien> GetTaiKhoanThanhVien()
        {
            string query = "SELECT * FROM TaiKhoanThanhVien";

            DataTable resultTable = GetResultTable(query, this.connection);

            return GetListTaiKhoanNhanVien(resultTable);
        }

        public List<TaiKhoanNhanVien> GetTaiKhoanThanhVienByHoVaTen(string hoVaTen)
        {
            string query = $"SELECT * FROM TaiKhoanThanhVien WHERE HoVaTen = @value";

            DataTable resultTable = GetResultTable(query, this.connection, hoVaTen);

            return GetListTaiKhoanNhanVien(resultTable);
        }

        public TaiKhoanNhanVien GetTaiKhoanThanhVienByThanhVien(string maThanhVien)
        {
            string query = $"SELECT * FROM TaiKhoanThanhVien WHERE MaThanhVien = @value";

            DataTable resultTable = GetResultTable(query, this.connection, maThanhVien);

            return GetTaiKhoanNhanVien(resultTable);
        }

        public List<TaiKhoanNhanVien> GetTaiKhoanThanhVienByMatKhau(string matKhau)
        {
            string query = $"SELECT * FROM TaiKhoanThanhVien WHERE MatKhau = @value";

            DataTable resultTable = GetResultTable(query, this.connection, matKhau);

            return GetListTaiKhoanNhanVien(resultTable);
        }

        public List<TaiKhoanNhanVien> GetTaiKhoanThanhVienByNgaySinh(DateTime ngaySinh)
        {
            string query = $"SELECT * FROM TaiKhoanThanhVien WHERE NgaySinh = @value";

            DataTable resultTable = GetResultTable(query, this.connection, ngaySinh);

            return GetListTaiKhoanNhanVien(resultTable);
        }

        public List<TaiKhoanNhanVien> GetTaiKhoanThanhVienByGioiTinh(string gioiTinh)
        {
            string query = $"SELECT * FROM TaiKhoanThanhVien WHERE GioiTinh = @value";

            DataTable resultTable = GetResultTable(query, this.connection, gioiTinh);

            return GetListTaiKhoanNhanVien(resultTable);
        }

        public List<TaiKhoanNhanVien> GetTaiKhoanThanhVienByCCCD(string CCCD)
        {
            string query = $"SELECT * FROM TaiKhoanThanhVien WHERE CCCD = @value";

            DataTable resultTable = GetResultTable(query, this.connection, CCCD);

            return GetListTaiKhoanNhanVien(resultTable);
        }

        public List<TaiKhoanNhanVien> GetTaiKhoanThanhVienBySoDienThoai(string soDienThoai)
        {
            string query = $"SELECT * FROM TaiKhoanThanhVien WHERE SoDienThoai = @value";

            DataTable resultTable = GetResultTable(query, this.connection, soDienThoai);

            return GetListTaiKhoanNhanVien(resultTable);
        }

        public List<TaiKhoanNhanVien> GetTaiKhoanThanhVienByEmail(string email)
        {
            string query = $"SELECT * FROM TaiKhoanThanhVien WHERE Email = @value";

            DataTable resultTable = GetResultTable(query, this.connection, email);

            return GetListTaiKhoanNhanVien(resultTable);
        }

        public List<TaiKhoanNhanVien> GetTaiKhoanThanhVienByDiaChi(string diaChi)
        {
            string query = $"SELECT * FROM TaiKhoanThanhVien WHERE DiaChi = @value";

            DataTable resultTable = GetResultTable(query, this.connection, diaChi);

            return GetListTaiKhoanNhanVien(resultTable);
        }

        public List<TaiKhoanNhanVien> GetTaiKhoanThanhVienByChuyenKhoa(string chuyenKhoa)
        {
            string query = $"SELECT * FROM TaiKhoanThanhVien WHERE ChuyenKhoa = @value";

            DataTable resultTable = GetResultTable(query, this.connection, chuyenKhoa);

            return GetListTaiKhoanNhanVien(resultTable);
        }

        public List<TaiKhoanNhanVien> GetTaiKhoanThanhVienByViTri(string viTri)
        {
            string query = $"SELECT * FROM TaiKhoanThanhVien WHERE ViTri = @value";

            DataTable resultTable = GetResultTable(query, this.connection, viTri);

            return GetListTaiKhoanNhanVien(resultTable);
        }

        public List<TaiKhoanNhanVien> GetTaiKhoanThanhVienByLoaiTaiKhoan(string loaiTaiKhoan)
        {
            string query = $"SELECT * FROM TaiKhoanThanhVien WHERE LoaiTaiKhoan = @value";

            DataTable resultTable = GetResultTable(query, this.connection, loaiTaiKhoan);

            return GetListTaiKhoanNhanVien(resultTable);
        }

        // Lịch làm việc
        public List<LichLamViec> GetLichLamViec()
        {
            string query = "SELECT * FROM LichLamViec";

            DataTable resultTable = GetResultTable(query, this.connection);

            return GetListLichLamViec(resultTable);
        }

        public LichLamViec GetLichLamViecByMaLichLamViec(string maLichLamViec)
        {
            string query = $"SELECT * FROM LichLamViec WHERE MaLichLamViec = @value";

            DataTable resultTable = GetResultTable(query, this.connection, maLichLamViec);

            return GetLichLamViec(resultTable);
        }

        public List<LichLamViec> GetLichLamViecByHoVaTen(string hoVaTen)
        {
            string query = $"SELECT * FROM LichLamViec WHERE HoVaTen = @value";

            DataTable resultTable = GetResultTable(query, this.connection, hoVaTen);

            return GetListLichLamViec(resultTable);
        }

        public List<LichLamViec> GetLichLamViecByMaThanhVien(string maThanhVien)
        {
            string query = $"SELECT * FROM LichLamViec WHERE MaThanhVien = @value";

            DataTable resultTable = GetResultTable(query, this.connection, maThanhVien);

            return GetListLichLamViec(resultTable);
        }

        public List<LichLamViec> GetLichLamViecByNgayLamViec(DateTime ngayLamViec)
        {
            string query = $"SELECT * FROM LichLamViec WHERE NgayLamViec = @value";

            DataTable resultTable = GetResultTable(query, this.connection, ngayLamViec);

            return GetListLichLamViec(resultTable);
        }

        public List<LichLamViec> GetLichLamViecByCa(string ca)
        {
            string query = $"SELECT * FROM LichLamViec WHERE Ca = @value";

            DataTable resultTable = GetResultTable(query, this.connection, ca);

            return GetListLichLamViec(resultTable);
        }

        public DataTable SelectFunction(string functionName, string parameterValue)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = $"SELECT * FROM {functionName}(@parameter)";
            command.Parameters.AddWithValue("@parameter", parameterValue);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable resultTable = new DataTable();
            adapter.Fill(resultTable);

            return resultTable;

        }

        public string GetPararamFunction(string functionName, string maSo, string paramName)
        {

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = $"SELECT dbo.{functionName}(@maHoaDon, @paramName)";
            command.Parameters.AddWithValue("@maHoaDon", maSo);
            command.Parameters.AddWithValue("@paramName", paramName);

            object result = command.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                return result.ToString();
            }

            return "Invalid Parameter";


        }

        //CAC HAM C# GOI PROCEDURE DELETE TRONG SQL
        public void DeleteDichVu(string maDichVu)
        {


            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DeleteDichVu";

            command.Parameters.AddWithValue("@MaDichVu", maDichVu);

            command.ExecuteNonQuery();


        }

        public void DeleteHoSoBenhNhan(string maHoSoBenhNhan)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DeleteHoSoBenhNhan";

            command.Parameters.AddWithValue("@MaHoSoBenhNhan", maHoSoBenhNhan);

            command.ExecuteNonQuery();


        }

        public void DeleteTaiKhoanThanhVien(string maThanhVien)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DeleteTaiKhoanThanhVien";

            command.Parameters.AddWithValue("@MaThanhVien", maThanhVien);

            command.ExecuteNonQuery();


        }

        public void DeleteDangKyUser(string soDienThoai)
        {


            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DeleteDangKyUser";

            command.Parameters.AddWithValue("@SoDienThoai", soDienThoai);

            command.ExecuteNonQuery();


        }

        public void DeleteLichLamViec(string maLichLamViec)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DeleteLichLamViec";

            command.Parameters.AddWithValue("@MaLichLamViec", maLichLamViec);

            command.ExecuteNonQuery();


        }

        public void DeleteLichKham(string maLichKham)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DeleteLichKham";

            command.Parameters.AddWithValue("@MaLichKham", maLichKham);

            command.ExecuteNonQuery();


        }

        public void DeleteChuyenKhoa(string maChuyenKhoa)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DeleteChuyenKhoa";

            command.Parameters.AddWithValue("@MaChuyenKhoa", maChuyenKhoa);

            command.ExecuteNonQuery();


        }

        public void DeleteSoKhamBenh(string maLichKham)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DeleteSoKhamBenh";

            command.Parameters.AddWithValue("@MaLichKham", maLichKham);

            command.ExecuteNonQuery();


        }

        public void DeleteRecordByMaBenhAn(string maBenhAn)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DeleteRecordByMaBenhAn";

            command.Parameters.AddWithValue("@MaBenhAn", maBenhAn);

            command.ExecuteNonQuery();


        }

        public void DeleteToaThuoc(string maToaThuoc)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DeleteToaThuoc";

            command.Parameters.AddWithValue("@MaToaThuoc", maToaThuoc);

            command.ExecuteNonQuery();


        }

        public void DeleteHoaDon(string maHoaDon)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DeleteHoaDon";

            command.Parameters.AddWithValue("@MaHoaDon", maHoaDon);

            command.ExecuteNonQuery();


        }

        public void DeleteKhuyenMai(string maKhuyenMai)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DeleteKhuyenMai";

            command.Parameters.AddWithValue("@MaKhuyenMai", maKhuyenMai);

            command.ExecuteNonQuery();


        }
        // PHAN HAM GỌI PROCEDURE UPDATE
        public void UpdateChuyenKhoa(string maChuyenKhoa, string tenChuyenKhoa, string maKhuyenMai)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "UpdateChuyenKhoa";

            command.Parameters.AddWithValue("@MaChuyenKhoa", maChuyenKhoa);
            command.Parameters.AddWithValue("@TenChuyenKhoa", tenChuyenKhoa);
            command.Parameters.AddWithValue("@MaKhuyenMai", maKhuyenMai);

            command.ExecuteNonQuery();


        }

        public void UpdateLichKham(string maLichKham, string maHoSoBenhNhan, string maChuyenKhoa, string maDichVu, DateTime ngayDangKy, string ca, DateTime khungGioKham)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "UpdateLichKham";

            command.Parameters.AddWithValue("@MaLichKham", maLichKham);
            command.Parameters.AddWithValue("@MaHoSoBenhNhan", maHoSoBenhNhan);
            command.Parameters.AddWithValue("@MaChuyenKhoa", maChuyenKhoa);
            command.Parameters.AddWithValue("@MaDichVu", maDichVu);
            command.Parameters.AddWithValue("@NgayDangKy", ngayDangKy);
            command.Parameters.AddWithValue("@Ca", ca);
            command.Parameters.AddWithValue("@KhungGioKham", khungGioKham);

            command.ExecuteNonQuery();


        }

        public void UpdateLichLamViec(string maLichLamViec, string hoVaTen, string maThanhVien, DateTime thang, DateTime ngay, string ca)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "UpdateLichLamViec";

            command.Parameters.AddWithValue("@MaLichLamViec", maLichLamViec);
            command.Parameters.AddWithValue("@HoVaTen", hoVaTen);
            command.Parameters.AddWithValue("@MaThanhVien", maThanhVien);
            command.Parameters.AddWithValue("@Thang", thang);
            command.Parameters.AddWithValue("@Ngay", ngay);
            command.Parameters.AddWithValue("@Ca", ca);

            command.ExecuteNonQuery();


        }

        public void UpdateDangKyUser(string soDienThoai, string matKhau)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "UpdateDangKyUser";

            command.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
            command.Parameters.AddWithValue("@MatKhau", matKhau);

            command.ExecuteNonQuery();


        }

        public void UpdateHoSoBenhNhan(string maHoSoBenhNhan, string hoVaTen, string maTaiKhoan, DateTime ngaySinh, string gioiTinh, string cccd, string maBHYT, string ngheNghiep, string soDienThoai, string email, string diaChi)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "UpdateHoSoBenhNhan";

            command.Parameters.AddWithValue("@MaHoSoBenhNhan", maHoSoBenhNhan);
            command.Parameters.AddWithValue("@HoVaTen", hoVaTen);
            command.Parameters.AddWithValue("@MaTaiKhoan", maTaiKhoan);
            command.Parameters.AddWithValue("@NgaySinh", ngaySinh);
            command.Parameters.AddWithValue("@GioiTinh", gioiTinh);
            command.Parameters.AddWithValue("@CCCD", cccd);
            command.Parameters.AddWithValue("@MaBHYT", maBHYT);
            command.Parameters.AddWithValue("@NgheNghiep", ngheNghiep);
            command.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@DiaChi", diaChi);

            command.ExecuteNonQuery();


        }
        public void UpdateTaiKhoanThanhVien(string maThanhVien, string hoVaTen, string matKhau, DateTime ngaySinh, string gioiTinh, string cccd, string soDienThoai, string email, string diaChi, string chuyenKhoa, string viTri, string loaiTaiKhoan)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "UpdateTaiKhoanThanhVien";

            command.Parameters.AddWithValue("@MaThanhVien", maThanhVien);
            command.Parameters.AddWithValue("@HoVaTen", hoVaTen);
            command.Parameters.AddWithValue("@MatKhau", matKhau);
            command.Parameters.AddWithValue("@NgaySinh", ngaySinh);
            command.Parameters.AddWithValue("@GioiTinh", gioiTinh);
            command.Parameters.AddWithValue("@CCCD", cccd);
            command.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@DiaChi", diaChi);
            command.Parameters.AddWithValue("@ChuyenKhoa", chuyenKhoa);
            command.Parameters.AddWithValue("@ViTri", viTri);
            command.Parameters.AddWithValue("@LoaiTaiKhoan", loaiTaiKhoan);

            command.ExecuteNonQuery();


        }
        public void UpdateSoKhamBenh(string maHoSoBenhNhan, string maLichKham, string hoVaTen, string tuoi, string soTheBHYT, string diaChi, string ngheNghiep, string danToc, string trieuChung, string chanDoan, string phuongPhapDieuTri, string bsKhamBenh, string ghiChu)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "UpdateSoKhamBenh";

            command.Parameters.AddWithValue("@MaHoSoBenhNhan", maHoSoBenhNhan);
            command.Parameters.AddWithValue("@MaLichKham", maLichKham);
            command.Parameters.AddWithValue("@HoVaTen", hoVaTen);
            command.Parameters.AddWithValue("@Tuoi", tuoi);
            command.Parameters.AddWithValue("@SoTheBHYT", soTheBHYT);
            command.Parameters.AddWithValue("@DiaChi", diaChi);
            command.Parameters.AddWithValue("@NgheNghiep", ngheNghiep);
            command.Parameters.AddWithValue("@DanToc", danToc);
            command.Parameters.AddWithValue("@TrieuChung", trieuChung);
            command.Parameters.AddWithValue("@ChanDoan", chanDoan);
            command.Parameters.AddWithValue("@PhuongPhapDieuTri", phuongPhapDieuTri);
            command.Parameters.AddWithValue("@BSKhamBenh", bsKhamBenh);
            command.Parameters.AddWithValue("@GhiChu", ghiChu);

            command.ExecuteNonQuery();


        }

        public void UpdateBenhAn(string maBenhAn, string maHoSoBenhNhan, string doiTuong, DateTime giaTriBHYT, string hoTenThanNhan, string thoiGianVaoVien, string trucTiepVao, string noiGioiThieu, string vaoKhoa, string chuyenKhoa, string tongSoNgayDieuTri, string noiChuyenDen, string kkBorCapCuu, string khiVaoKhoaDieuTri, string ketQuaDieuTri, string giaiPhauBenh, string quaTrinhBenhLy, string tienSuBenh, string toaThan, string trieuChungCoNang, string thuongTonCanBan, string cacCoQuan, string tKetQuaTrinhBenhLy, string tomTatKQXN, string phuongPhapDieuTri, string hoSoPhimAnh)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "UpdateBenhAn";

            command.Parameters.AddWithValue("@MaBenhAn", maBenhAn);
            command.Parameters.AddWithValue("@MaHoSoBenhNhan", maHoSoBenhNhan);
            command.Parameters.AddWithValue("@DoiTuong", doiTuong);
            command.Parameters.AddWithValue("@GiaTriBHYT", giaTriBHYT);
            command.Parameters.AddWithValue("@HoTenThanNhan", hoTenThanNhan);
            command.Parameters.AddWithValue("@ThoiGianVaoVien", thoiGianVaoVien);
            command.Parameters.AddWithValue("@TrucTiepVao", trucTiepVao);
            command.Parameters.AddWithValue("@NoiGioiThieu", noiGioiThieu);
            command.Parameters.AddWithValue("@VaoKhoa", vaoKhoa);
            command.Parameters.AddWithValue("@ChuyenKhoa", chuyenKhoa);
            command.Parameters.AddWithValue("@TongSoNgayDieuTri", tongSoNgayDieuTri);
            command.Parameters.AddWithValue("@NoiChuyenDen", noiChuyenDen);
            command.Parameters.AddWithValue("@KKBorCapCuu", kkBorCapCuu);
            command.Parameters.AddWithValue("@KhiVaoKhoaDieuTri", khiVaoKhoaDieuTri);
            command.Parameters.AddWithValue("@KetQuaDieuTri", ketQuaDieuTri);
            command.Parameters.AddWithValue("@GiaiPhauBenh", giaiPhauBenh);
            command.Parameters.AddWithValue("@QuaTrinhBenhLy", quaTrinhBenhLy);
            command.Parameters.AddWithValue("@TienSuBenh", tienSuBenh);
            command.Parameters.AddWithValue("@ToaThan", toaThan);
            command.Parameters.AddWithValue("@TrieuChungCoNang", trieuChungCoNang);
            command.Parameters.AddWithValue("@ThuongTonCanBan", thuongTonCanBan);
            command.Parameters.AddWithValue("@CacCoQuan", cacCoQuan);
            command.Parameters.AddWithValue("@TKetQuaTrinhBenhLy", tKetQuaTrinhBenhLy);
            command.Parameters.AddWithValue("@TomTatKQXN", tomTatKQXN);
            command.Parameters.AddWithValue("@PhuongPhapDieuTri", phuongPhapDieuTri);
            command.Parameters.AddWithValue("@HoSoPhimAnh", hoSoPhimAnh);

            command.ExecuteNonQuery();


        }

        public void UpdateToaThuoc(string maToaThuoc, string soThuTu, string maThuoc, string maBenhAn, string tenThuoc, byte soLuong, string dang, string ghiChu)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "UpdateToaThuoc";

            command.Parameters.AddWithValue("@MaToaThuoc", maToaThuoc);
            command.Parameters.AddWithValue("@SoThuTu", soThuTu);
            command.Parameters.AddWithValue("@MaThuoc", maThuoc);
            command.Parameters.AddWithValue("@MaBenhAn", maBenhAn);
            command.Parameters.AddWithValue("@TenThuoc", tenThuoc);
            command.Parameters.AddWithValue("@SoLuong", soLuong);
            command.Parameters.AddWithValue("@Dang", dang);
            command.Parameters.AddWithValue("@GhiChu", ghiChu);

            command.ExecuteNonQuery();


        }
        public void UpdateHoaDon(string maHoaDon, string maLichKham, int tongTien, string hinhThucThanhToan)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "UpdateHoaDon";

            command.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
            command.Parameters.AddWithValue("@MaLichKham", maLichKham);
            command.Parameters.AddWithValue("@TongTien", tongTien);
            command.Parameters.AddWithValue("@HinhThucThanhToan", hinhThucThanhToan);

            command.ExecuteNonQuery();


        }

        public void UpdateKhuyenMai(string maKhuyenMai, string giaKhuyenMai, string tenChuongTrinhKM, string noiDungKM, DateTime thoiGianBatDau, DateTime thoiGianKetThuc)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "UpdateKhuyenMai";

            command.Parameters.AddWithValue("@MaKhuyenMai", maKhuyenMai);
            command.Parameters.AddWithValue("@TenChuongTrinhKM", tenChuongTrinhKM);
            command.Parameters.AddWithValue("@GiaKhuyenMai", giaKhuyenMai);
            command.Parameters.AddWithValue("@NoiDungKM", noiDungKM);
            command.Parameters.AddWithValue("@ThoiGianBatDau", thoiGianBatDau);
            command.Parameters.AddWithValue("@ThoiGianKetThuc", thoiGianKetThuc);

            command.ExecuteNonQuery();


        }

        public void UpdateDichVu(string maDichVu, string tenDichVu, string noiDungDichVu, int giaDichVu)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "UpdateDichVu";

            command.Parameters.AddWithValue("@MaDichVu", maDichVu);
            command.Parameters.AddWithValue("@TenDichVu", tenDichVu);
            command.Parameters.AddWithValue("@NoiDungDichVu", noiDungDichVu);
            command.Parameters.AddWithValue("@GiaDichVu", giaDichVu);

            command.ExecuteNonQuery();


        }
        public void UpdateAdminManager(string maAdmin, string matKhau)
        {

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "UpdateAdminManager";

            command.Parameters.AddWithValue("@MaAdmin", maAdmin);
            command.Parameters.AddWithValue("@MatKhau", matKhau);

            command.ExecuteNonQuery();


        }
        // PHAN GOI PROCEDURE INSERT
        public void InsertAdminManager(string maAdmin, string matKhau)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "InsertADMIN_Manager";

            command.Parameters.AddWithValue("@MaAdmin", maAdmin);
            command.Parameters.AddWithValue("@MatKhau", matKhau);

            command.ExecuteNonQuery();


        }
        public void InsertHoSoBenhNhan(string hoVaTen, string maTaiKhoan, DateTime ngaySinh, string gioiTinh, string cccd, string maBHYT, string ngheNghiep, string soDienThoai, string email, string diaChi)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "HoSoBenhNhan_Insert";

            command.Parameters.AddWithValue("@HoVaTen", hoVaTen);
            command.Parameters.AddWithValue("@MaTaiKhoan", maTaiKhoan);
            command.Parameters.AddWithValue("@NgaySinh", ngaySinh);
            command.Parameters.AddWithValue("@GioiTinh", gioiTinh);
            command.Parameters.AddWithValue("@CCCD", cccd);
            command.Parameters.AddWithValue("@MaBHYT", maBHYT);
            command.Parameters.AddWithValue("@NgheNghiep", ngheNghiep);
            command.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@DiaChi", diaChi);

            command.ExecuteNonQuery();


        }
        public void InsertLichLamViec(string hoVaTen, string maThanhVien, DateTime thang, DateTime ngay, string ca)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "InsertLichLamViec";

            command.Parameters.AddWithValue("@HoVaTen", hoVaTen);
            command.Parameters.AddWithValue("@MaThanhVien", maThanhVien);
            command.Parameters.AddWithValue("@Thang", thang);
            command.Parameters.AddWithValue("@Ngay", ngay);
            command.Parameters.AddWithValue("@Ca", ca);

            command.ExecuteNonQuery();


        }
        public void InsertSoKhamBenh(string maHoSoBenhNhan, string maLichKham, string hoVaTen, string tuoi, string soTheBHYT, string diaChi, string ngheNghiep, string danToc, string trieuChung, string chanDoan, string phuongPhapDieuTri, string bsKhamBenh, string ghiChu)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SoKhamBenh_Insert";

            command.Parameters.AddWithValue("@MaHoSoBenhNhan", maHoSoBenhNhan);
            command.Parameters.AddWithValue("@MaLichKham", maLichKham);
            command.Parameters.AddWithValue("@HoVaTen", hoVaTen);
            command.Parameters.AddWithValue("@Tuoi", tuoi);
            command.Parameters.AddWithValue("@SoTheBHYT", soTheBHYT);
            command.Parameters.AddWithValue("@DiaChi", diaChi);
            command.Parameters.AddWithValue("@NgheNghiep", ngheNghiep);
            command.Parameters.AddWithValue("@DanToc", danToc);
            command.Parameters.AddWithValue("@TrieuChung", trieuChung);
            command.Parameters.AddWithValue("@ChanDoan", chanDoan);
            command.Parameters.AddWithValue("@PhuongPhapDieuTri", phuongPhapDieuTri);
            command.Parameters.AddWithValue("@BSKhamBenh", bsKhamBenh);
            command.Parameters.AddWithValue("@GhiChu", ghiChu);

            command.ExecuteNonQuery();


        }

        public void InsertBenhAn(string maHoSoBenhNhan, string doiTuong, DateTime giaTriBHYT, string hoTenThanNhan, string thoiGianVaoVien, string trucTiepVao, string noiGioiThieu, string vaoKhoa, string chuyenKhoa, string tongSoNgayDieuTri, string noiChuyenDen, string kKBorCapCuu, string khiVaoKhoaDieuTri, string ketQuaDieuTri, string giaiPhauBenh, string quaTrinhBenhLy, string tienSuBenh, string toaThan, string trieuChungCoNang, string thuongTonCanBan, string cacCoQuan, string tKetQuaTrinhBenhLy, string tomTatKQXN, string phuongPhapDieuTri, string hoSoPhimAnh)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "BenhAn_Insert";

            command.Parameters.AddWithValue("@MaHoSoBenhNhan", maHoSoBenhNhan);
            command.Parameters.AddWithValue("@DoiTuong", doiTuong);
            command.Parameters.AddWithValue("@GiaTriBHYT", giaTriBHYT);
            command.Parameters.AddWithValue("@HoTenThanNhan", hoTenThanNhan);
            command.Parameters.AddWithValue("@ThoiGianVaoVien", thoiGianVaoVien);
            command.Parameters.AddWithValue("@TrucTiepVao", trucTiepVao);
            command.Parameters.AddWithValue("@NoiGioiThieu", noiGioiThieu);
            command.Parameters.AddWithValue("@VaoKhoa", vaoKhoa);
            command.Parameters.AddWithValue("@ChuyenKhoa", chuyenKhoa);
            command.Parameters.AddWithValue("@TongSoNgayDieuTri", tongSoNgayDieuTri);
            command.Parameters.AddWithValue("@NoiChuyenDen", noiChuyenDen);
            command.Parameters.AddWithValue("@KKBorCapCuu", kKBorCapCuu);
            command.Parameters.AddWithValue("@KhiVaoKhoaDieuTri", khiVaoKhoaDieuTri);
            command.Parameters.AddWithValue("@KetQuaDieuTri", ketQuaDieuTri);
            command.Parameters.AddWithValue("@GiaiPhauBenh", giaiPhauBenh);
            command.Parameters.AddWithValue("@QuaTrinhBenhLy", quaTrinhBenhLy);
            command.Parameters.AddWithValue("@TienSuBenh", tienSuBenh);
            command.Parameters.AddWithValue("@ToaThan", toaThan);
            command.Parameters.AddWithValue("@TrieuChungCoNang", trieuChungCoNang);
            command.Parameters.AddWithValue("@ThuongTonCanBan", thuongTonCanBan);
            command.Parameters.AddWithValue("@CacCoQuan", cacCoQuan);
            command.Parameters.AddWithValue("@TKetQuaTrinhBenhLy", tKetQuaTrinhBenhLy);
            command.Parameters.AddWithValue("@TomTatKQXN", tomTatKQXN);
            command.Parameters.AddWithValue("@PhuongPhapDieuTri", phuongPhapDieuTri);
            command.Parameters.AddWithValue("@HoSoPhimAnh", hoSoPhimAnh);

            command.ExecuteNonQuery();


        }
        public void InsertToaThuoc(string soThuTu, string maThuoc, string maBenhAn, string tenThuoc, int soLuong, string dang, string ghiChu)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "InsertToaThuoc";

            command.Parameters.AddWithValue("@SoThuTu", soThuTu);
            command.Parameters.AddWithValue("@MaThuoc", maThuoc);
            command.Parameters.AddWithValue("@MaBenhAn", maBenhAn);
            command.Parameters.AddWithValue("@TenThuoc", tenThuoc);
            command.Parameters.AddWithValue("@SoLuong", soLuong);
            command.Parameters.AddWithValue("@Dang", dang);
            command.Parameters.AddWithValue("@GhiChu", ghiChu);

            command.ExecuteNonQuery();


        }

        public void InsertHoaDon(string maLichKham, int tongTien, string hinhThucThanhToan)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "InsertHoaDon";

            command.Parameters.AddWithValue("@MaLichKham", maLichKham);
            command.Parameters.AddWithValue("@TongTien", tongTien);
            command.Parameters.AddWithValue("@HinhThucThanhToan", hinhThucThanhToan);

            command.ExecuteNonQuery();


        }

        public void InsertKhuyenMai(string tenChuongTrinhKM, string giaKhuyenMai, string noiDungKM, DateTime thoiGianBatDau, DateTime thoiGianKetThuc)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "InsertKhuyenMai";

            command.Parameters.AddWithValue("@TenChuongTrinhKM", tenChuongTrinhKM);
            command.Parameters.AddWithValue("@GiaKhuyenMai", giaKhuyenMai);
            command.Parameters.AddWithValue("@NoiDungKM", noiDungKM);
            command.Parameters.AddWithValue("@ThoiGianBatDau", thoiGianBatDau);
            command.Parameters.AddWithValue("@ThoiGianKetThuc", thoiGianKetThuc);

            command.ExecuteNonQuery();


        }

        public void InsertDichVu(string tenDichVu, string noiDungDichVu, int giaDichVu)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "InsertDichVu";

            command.Parameters.AddWithValue("@TenDichVu", tenDichVu);
            command.Parameters.AddWithValue("@NoiDungDichVu", noiDungDichVu);
            command.Parameters.AddWithValue("@GiaDichVu", giaDichVu);

            command.ExecuteNonQuery();


        }

        public void InsertChuyenKhoa(string tenChuyenKhoa, string maKhuyenMai)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "InsertChuyenKhoa";

            command.Parameters.AddWithValue("@TenChuyenKhoa", tenChuyenKhoa);
            command.Parameters.AddWithValue("@MaKhuyenMai", maKhuyenMai);

            command.ExecuteNonQuery();


        }

        public void InsertLichKham(string maHoSoBenhNhan, string maChuyenKhoa, string maDichVu, DateTime ngayDangKy, string ca, DateTime khungGioKham)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "InsertLichKham";

            command.Parameters.AddWithValue("@MaHoSoBenhNhan", maHoSoBenhNhan);
            command.Parameters.AddWithValue("@MaChuyenKhoa", maChuyenKhoa);
            command.Parameters.AddWithValue("@MaDichVu", maDichVu);
            command.Parameters.AddWithValue("@NgayDangKy", ngayDangKy);
            command.Parameters.AddWithValue("@Ca", ca);
            command.Parameters.AddWithValue("@KhungGioKham", khungGioKham);

            command.ExecuteNonQuery();


        }

        public void InsertTaiKhoanThanhVien(string hoVaTen, string matKhau, DateTime ngaySinh, string gioiTinh, string cccd, string soDienThoai, string email, string diaChi, string chuyenKhoa, string viTri, string loaiTaiKhoan)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "InsertTaiKhoanThanhVien";

            command.Parameters.AddWithValue("@HoVaTen", hoVaTen);
            command.Parameters.AddWithValue("@MatKhau", matKhau);
            command.Parameters.AddWithValue("@NgaySinh", ngaySinh);
            command.Parameters.AddWithValue("@GioiTinh", gioiTinh);
            command.Parameters.AddWithValue("@CCCD", cccd);
            command.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@DiaChi", diaChi);
            command.Parameters.AddWithValue("@ChuyenKhoa", chuyenKhoa);
            command.Parameters.AddWithValue("@ViTri", viTri);
            command.Parameters.AddWithValue("@LoaiTaiKhoan", loaiTaiKhoan);

            command.ExecuteNonQuery();


        }

        public DataTable RetrieveMemberData(string sDT)
        {
            DataTable memberData = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM TaiKhoanThanhVien WHERE SoDienThoai = @sDT", connection))
                {
                    command.Parameters.AddWithValue("@sDT", sDT);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(memberData);
                    }
                }
            }

            return memberData;
        }

        public DataTable CallSearchLichLamViec(string searchKeyword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("searchLichLamViec", connection)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    command.Parameters.AddWithValue("@SearchKeyword", searchKeyword);

                    DataTable dataTable = new DataTable();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }

                    return dataTable;
                }
            }
        }

        public bool IsDuplicateLichLamViec(string maThanhVien, DateTime ngay, string ca)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "CheckDuplicateLichLamViec";
                    command.Parameters.AddWithValue("@MaThanhVien", maThanhVien);
                    command.Parameters.AddWithValue("@Ngay", ngay);
                    command.Parameters.AddWithValue("@Ca", ca);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public string CheckUser(string soDienThoai, string matKhau)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT LoaiTaiKhoan FROM TaiKhoanThanhVien WHERE SoDienThoai = @sDT AND MatKhau = @matKhau", connection))
                    {
                        command.Parameters.AddWithValue("@sDT", soDienThoai);
                        command.Parameters.AddWithValue("@matKhau", matKhau);

                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            if (dataReader.Read())
                            {
                                string loaiTaiKhoan = dataReader["LoaiTaiKhoan"].ToString();
                                if (loaiTaiKhoan == "BS")
                                    return "BacSi";
                                else if (loaiTaiKhoan == "KT")
                                    return "ThuKy";
                                else if (loaiTaiKhoan == "TV")
                                    return "ThanhVien";
                            }
                        }
                    }
                    using (SqlCommand command = new SqlCommand("SELECT * FROM ADMIN_Manager WHERE MaAdmin = @MaAdmin AND MatKhau = @matKhau", connection))
                    {
                        command.Parameters.AddWithValue("@MaAdmin", soDienThoai);
                        command.Parameters.AddWithValue("@matKhau", matKhau);

                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            if (dataReader.HasRows)
                                return "Admin";
                        }
                    }

                    using (SqlCommand command = new SqlCommand("SELECT * FROM DangKyUser WHERE SoDienThoai = @sDT AND MatKhau = @matKhau", connection))
                    {
                        command.Parameters.AddWithValue("@sDT", soDienThoai);
                        command.Parameters.AddWithValue("@matKhau", matKhau);

                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            if (dataReader.HasRows)
                                return "User";
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khác: " + ex.Message);
            }

            return null; // Trả về null nếu không tìm thấy tài khoản hoặc có lỗi
        }

        public DataTable CallSearchTaiKhoanThanhVien(string searchKeyword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("searchTaiKhoanThanhVien", connection)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    command.Parameters.AddWithValue("@SearchKeyword", searchKeyword);

                    DataTable dataTable = new DataTable();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }

                    return dataTable;
                }
            }
        }
        public void SuaTaiKhoanThanhVien(string mathanhvien, string hoVaTen, string matKhau, DateTime ngaySinh, string gioiTinh, string cccd, string soDienThoai, string email, string diaChi, string chuyenKhoa, string viTri, string loaiTaiKhoan)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UpdateTaiKhoanThanhVien", connection)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    command.Parameters.AddWithValue("@MaThanhVien", mathanhvien);
                    command.Parameters.AddWithValue("@HoVaTen", hoVaTen);
                    command.Parameters.AddWithValue("@MatKhau", matKhau);
                    command.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    command.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    command.Parameters.AddWithValue("@CCCD", cccd);
                    command.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@DiaChi", diaChi);
                    command.Parameters.AddWithValue("@ChuyenKhoa", chuyenKhoa);
                    command.Parameters.AddWithValue("@ViTri", viTri);
                    command.Parameters.AddWithValue("@LoaiTaiKhoan", loaiTaiKhoan);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void CallInsertUser(string soDienThoai, string matKhau)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "DangKyUser_Insert";

                        // Thêm các tham số
                        command.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                        command.Parameters.AddWithValue("@MatKhau", matKhau);

                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Đăng ký thành công.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khác: " + ex.Message);
            }
        }

        public void CallUpdateDangKyUser(string soDienThoai, string matKhau)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("UpdateDangKyUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@SoDienThoai", soDienThoai));
                        command.Parameters.Add(new SqlParameter("@MatKhau", matKhau));

                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Đổi mật khẩu thành công.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khác: " + ex.Message);
            }
        }

        public void LoadDataFromDatabase(Guna2DataGridView dataGridView)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                string query = "SELECT * FROM TaiKhoanThanhVien";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView.DataSource = dataTable;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        
        public void LoadDataFromDatabaseLichLamViec(Guna2DataGridView dataGridView)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                string query = "SELECT * FROM LichLamViec ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView.DataSource = dataTable;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void InsertLichLamViec(string hoVaTen, string maThanhVien, DateTime ngay, string ca)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "InsertLichLamViec";
                    command.Parameters.AddWithValue("@HoVaTen", hoVaTen); // Add @HoVaTen parameter
                    command.Parameters.AddWithValue("@MaThanhVien", maThanhVien);
                    command.Parameters.AddWithValue("@Ngay", ngay);
                    command.Parameters.AddWithValue("@Ca", ca);
                    command.ExecuteNonQuery();
                }
            }
        }

        public string GetMaThanhVien(string hoVaTen)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "GetMaThanhVien"; // Replace with the actual stored procedure name

                    command.Parameters.AddWithValue("@HoVaTen", hoVaTen);

                    string maThanhVien = (string)command.ExecuteScalar();

                    return maThanhVien;
                }
            }
        }

        public void UpdateLichLamViec(string maLichLamViec, string hoVaTen, string mathanhvien, DateTime ngay, string ca)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UpdateLichLamViec", connection)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    command.Parameters.AddWithValue("@MaLichLamViec", maLichLamViec);
                    command.Parameters.AddWithValue("@HoVaTen", hoVaTen);
                    command.Parameters.AddWithValue("@MaThanhVien", mathanhvien);
                    command.Parameters.AddWithValue("@Ngay", ngay);
                    command.Parameters.AddWithValue("@Ca", ca);

                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable CallGetLichKhamByNgayAndCa(string ngay, string ca)
        {
            DataTable result = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT * FROM dbo.GetLichKhamByCaAndNgay(@Ca, @Ngay)";

                    command.Parameters.AddWithValue("@Ca", ca);
                    command.Parameters.AddWithValue("@Ngay", ngay);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        result.Load(reader);
                    }
                }
            }

            return result;
        }

        public DataTable CallGetHoSoBenhNhan(string maHSBN)
        {
            DataTable result = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT * FROM dbo.SelectHoSoBenhNhan (@MaHoSoBenhNhan varchar(8))";

                    command.Parameters.AddWithValue("@MaHoSoBenhNhan", maHSBN);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        result.Load(reader);
                    }
                }
            }

            return result;
        }
    }
}
