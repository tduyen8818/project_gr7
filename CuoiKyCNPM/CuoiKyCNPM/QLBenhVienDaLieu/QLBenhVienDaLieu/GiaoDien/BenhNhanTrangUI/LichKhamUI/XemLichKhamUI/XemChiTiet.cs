using QLBenhVienDaLieu.Database.Class;
using QLBenhVienDaLieu.Database.Function;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QLBenhVienDaLieu.GiaoDien.BenhNhanTrangUI.LichKhamUI.XemLichKhamUI
{
    public partial class XemChiTiet : Form
    {
        private BenhNhan_Trang benhNhan_Trang;

        private SqlFunctionCaller sqlFunctionCaller;

        private DataXemLichKham dataXemLichKham;

        private string soDienThoai;

        private Rectangle originalForm;
        private Rectangle originalTextMaLichKham;
        private Rectangle originalTextMaHoSoBenhNhan;
        private Rectangle originalTextMaChuyenKhoa;
        private Rectangle originalTextMaDichVu;
        private Rectangle originalTextNgayDangKy;
        private Rectangle originalTextCa;
        private Rectangle originalTextKhungGioKham;
        private Rectangle originalTextTenChuyenKhoa;
        private Rectangle originalTextTenDichVu;
        private Rectangle originalTextTongTien;
        private Rectangle originalTextHinhThucThanhToan;
        private Rectangle originalDataMaLichKham;
        private Rectangle originalDataMaHoSoBenhNhan;
        private Rectangle originalDataMaChuyenKhoa;
        private Rectangle originalDataMaDichVu;
        private Rectangle originalDataNgayDangKy;
        private Rectangle originalDataCa;
        private Rectangle originalDataKhungGioKham;
        private Rectangle originalDataTenChuyenKhoa;
        private Rectangle originalDataTenDichVu;
        private Rectangle originalDataTongTien;
        private Rectangle originalDataHinhThucThanhToan;
        private Rectangle originalButtonReturn;

        float textSizeInitialTextMaLichKham;
        float textSizeInitialTextMaHoSoBenhNhan;
        float textSizeInitialTextMaChuyenKhoa;
        float textSizeInitialTextMaDichVu;
        float textSizeInitialTextNgayDangKy;
        float textSizeInitialTextCa;
        float textSizeInitialTextKhungGioKham;
        float textSizeInitialTextTenChuyenKhoa;
        float textSizeInitialTextTenDichVu;
        float textSizeInitialTextTongTien;
        float textSizeInitialTextHinhThucThanhToan;
        float textSizeInitialDataMaLichKham;
        float textSizeInitialDataMaHoSoBenhNhan;
        float textSizeInitialDataMaChuyenKhoa;
        float textSizeInitialDataMaDichVu;
        float textSizeInitialDataNgayDangKy;
        float textSizeInitialDataCa;
        float textSizeInitialDataKhungGioKham;
        float textSizeInitialDataTenChuyenKhoa;
        float textSizeInitialDataTenDichVu;
        float textSizeInitialDataTongTien;
        float textSizeInitialDataHinhThucThanhToan;

        public XemChiTiet(BenhNhan_Trang benhNhan_Trang, SqlFunctionCaller sqlFunctionCaller, DataXemLichKham dataXemLichKham, string soDienThoai)
        {

            this.benhNhan_Trang = benhNhan_Trang;
            this.sqlFunctionCaller = sqlFunctionCaller;
            this.dataXemLichKham = dataXemLichKham;
            this.soDienThoai = soDienThoai;

            InitializeComponent();

            

            originalForm = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
            originalTextMaLichKham = new Rectangle(textMaLichKham.Location.X, textMaLichKham.Location.Y, textMaLichKham.Width, textMaLichKham.Height);
            originalTextMaHoSoBenhNhan = new Rectangle(textMaHoSoBenhNhan.Location.X, textMaHoSoBenhNhan.Location.Y, textMaHoSoBenhNhan.Width, textMaHoSoBenhNhan.Height);
            originalTextMaChuyenKhoa = new Rectangle(textMaChuyenKhoa.Location.X, textMaChuyenKhoa.Location.Y, textMaChuyenKhoa.Width, textMaChuyenKhoa.Height);
            originalTextMaDichVu = new Rectangle(textMaDichVu.Location.X, textMaDichVu.Location.Y, textMaDichVu.Width, textMaDichVu.Height);
            originalTextNgayDangKy = new Rectangle(textNgayDangKy.Location.X, textNgayDangKy.Location.Y, textNgayDangKy.Width, textNgayDangKy.Height);
            originalTextCa = new Rectangle(textCa.Location.X, textCa.Location.Y, textCa.Width, textCa.Height);
            originalTextKhungGioKham = new Rectangle(textKhungGioKham.Location.X, textKhungGioKham.Location.Y, textKhungGioKham.Width, textKhungGioKham.Height);
            originalTextTenChuyenKhoa = new Rectangle(textTenChuyenKhoa.Location.X, textTenChuyenKhoa.Location.Y, textTenChuyenKhoa.Width, textTenChuyenKhoa.Height);
            originalTextTenDichVu = new Rectangle(textTenDichVu.Location.X, textTenDichVu.Location.Y, textTenDichVu.Width, textTenDichVu.Height);
            originalTextTongTien = new Rectangle(textTongTien.Location.X, textTongTien.Location.Y, textTongTien.Width, textTongTien.Height);
            originalTextHinhThucThanhToan = new Rectangle(textHinhThucThanhToan.Location.X, textHinhThucThanhToan.Location.Y, textHinhThucThanhToan.Width, textHinhThucThanhToan.Height);
            originalDataMaLichKham = new Rectangle(dataMaLichKham.Location.X, dataMaLichKham.Location.Y, dataMaLichKham.Width, dataMaLichKham.Height);
            originalDataMaHoSoBenhNhan = new Rectangle(dataMaHoSoBenhNhan.Location.X, dataMaHoSoBenhNhan.Location.Y, dataMaHoSoBenhNhan.Width, dataMaHoSoBenhNhan.Height);
            originalDataMaChuyenKhoa = new Rectangle(dataMaChuyenKhoa.Location.X, dataMaChuyenKhoa.Location.Y, dataMaChuyenKhoa.Width, dataMaChuyenKhoa.Height);
            originalDataMaDichVu = new Rectangle(dataMaDichVu.Location.X, dataMaDichVu.Location.Y, dataMaDichVu.Width, dataMaDichVu.Height);
            originalDataNgayDangKy = new Rectangle(dataNgayDangKy.Location.X, dataNgayDangKy.Location.Y, dataNgayDangKy.Width, dataNgayDangKy.Height);
            originalDataCa = new Rectangle(dataCa.Location.X, dataCa.Location.Y, dataCa.Width, dataCa.Height);
            originalDataKhungGioKham = new Rectangle(dataKhungGioKham.Location.X, dataKhungGioKham.Location.Y, dataKhungGioKham.Width, dataKhungGioKham.Height);
            originalDataTenChuyenKhoa = new Rectangle(dataTenChuyenKhoa.Location.X, dataTenChuyenKhoa.Location.Y, dataTenChuyenKhoa.Width, dataTenChuyenKhoa.Height);
            originalDataTenDichVu = new Rectangle(dataTenDichVu.Location.X, dataTenDichVu.Location.Y, dataTenDichVu.Width, dataTenDichVu.Height);
            originalDataTongTien = new Rectangle(dataTongTien.Location.X, dataTongTien.Location.Y, dataTongTien.Width, dataTongTien.Height);
            originalDataHinhThucThanhToan = new Rectangle(dataHinhThucThanhToan.Location.X, dataHinhThucThanhToan.Location.Y, dataHinhThucThanhToan.Width, dataHinhThucThanhToan.Height);
            originalButtonReturn = new Rectangle(buttonReturn.Location.X, buttonReturn.Location.Y, buttonReturn.Width, buttonReturn.Height);


            textSizeInitialTextMaLichKham = textMaLichKham.Font.Size;
            textSizeInitialTextMaHoSoBenhNhan = textMaHoSoBenhNhan.Font.Size;
            textSizeInitialTextMaChuyenKhoa = textMaChuyenKhoa.Font.Size;
            textSizeInitialTextMaDichVu = textMaDichVu.Font.Size;
            textSizeInitialTextNgayDangKy = textNgayDangKy.Font.Size;
            textSizeInitialTextCa = textCa.Font.Size;
            textSizeInitialTextKhungGioKham = textKhungGioKham.Font.Size;
            textSizeInitialTextTenChuyenKhoa = textTenChuyenKhoa.Font.Size;
            textSizeInitialTextTenDichVu = textTenDichVu.Font.Size;
            textSizeInitialTextTongTien = textTongTien.Font.Size;
            textSizeInitialTextHinhThucThanhToan = textHinhThucThanhToan.Font.Size;
            textSizeInitialDataMaLichKham = dataMaLichKham.Font.Size;
            textSizeInitialDataMaHoSoBenhNhan = dataMaHoSoBenhNhan.Font.Size;
            textSizeInitialDataMaChuyenKhoa = dataMaChuyenKhoa.Font.Size;
            textSizeInitialDataMaDichVu = dataMaDichVu.Font.Size;
            textSizeInitialDataNgayDangKy = dataNgayDangKy.Font.Size;
            textSizeInitialDataCa = dataCa.Font.Size;
            textSizeInitialDataKhungGioKham = dataKhungGioKham.Font.Size;
            textSizeInitialDataTenChuyenKhoa = dataTenChuyenKhoa.Font.Size;
            textSizeInitialDataTenDichVu = dataTenDichVu.Font.Size;
            textSizeInitialDataTongTien = dataTongTien.Font.Size;
            textSizeInitialDataHinhThucThanhToan = dataHinhThucThanhToan.Font.Size;


            LichKham lichKham = sqlFunctionCaller.GetLichKhamByMaLichKham(dataXemLichKham.DataMaPhieu.Text);
            dataMaLichKham.Text = lichKham.MaLichKham;
            dataMaHoSoBenhNhan.Text = lichKham.MaHoSoBenhNhan;
            dataMaChuyenKhoa.Text = lichKham.MaChuyenKhoa;
            dataMaDichVu.Text = lichKham.MaDichVu;
            dataNgayDangKy.Text = lichKham.NgayDangKy.ToShortDateString();
            dataCa.Text = lichKham.Ca;
            dataKhungGioKham.Text = lichKham.KhungGioKham.ToLongTimeString();

            ChuyenKhoa chuyenKhoa = sqlFunctionCaller.GetChuyenKhoaByMaChuyenKhoa(lichKham.MaChuyenKhoa);

            dataTenChuyenKhoa.Text = chuyenKhoa.TenChuyenKhoa;

            DichVu dichVu = sqlFunctionCaller.GetDichVuByMaDichVu(lichKham.MaDichVu);

            dataTenDichVu.Text = dichVu.TenDichVu;

            HoaDon hoaDon = sqlFunctionCaller.GetHoaDonByMaLichKham(lichKham.MaLichKham);

            dataTongTien.Text = hoaDon.TongTien.ToString();
            dataHinhThucThanhToan.Text = hoaDon.HinhThucThanhToan.Equals("") ? "Chưa thanh toán" : hoaDon.HinhThucThanhToan;

        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Panel mainPanelRight = this.benhNhan_Trang.MainPanelRight;

            mainPanelRight.Controls.Clear();

            XemLichKham xemLichKham = new XemLichKham(sqlFunctionCaller, benhNhan_Trang, soDienThoai);

            xemLichKham.TopLevel = false;
            xemLichKham.Dock = DockStyle.Fill;

            mainPanelRight.Controls.Add(xemLichKham);
            mainPanelRight.Tag = xemLichKham;

            xemLichKham.Show();
        }

        private void XemChiTiet_Resize(object sender, EventArgs e)
        {
            if (originalForm.Width != 0 && textMaLichKham.Font.Size != 0)
            {
                Graphic.ScaleSize.Resize(originalForm, originalTextMaLichKham, textMaLichKham, this, textSizeInitialTextMaLichKham);
                Graphic.ScaleSize.Resize(originalForm, originalTextMaHoSoBenhNhan, textMaHoSoBenhNhan, this, textSizeInitialTextMaHoSoBenhNhan);
                Graphic.ScaleSize.Resize(originalForm, originalTextMaChuyenKhoa, textMaChuyenKhoa, this, textSizeInitialTextMaChuyenKhoa);
                Graphic.ScaleSize.Resize(originalForm, originalTextMaDichVu, textMaDichVu, this, textSizeInitialTextMaDichVu);
                Graphic.ScaleSize.Resize(originalForm, originalTextNgayDangKy, textNgayDangKy, this, textSizeInitialTextNgayDangKy);
                Graphic.ScaleSize.Resize(originalForm, originalTextCa, textCa, this, textSizeInitialTextCa);
                Graphic.ScaleSize.Resize(originalForm, originalTextKhungGioKham, textKhungGioKham, this, textSizeInitialTextKhungGioKham);
                Graphic.ScaleSize.Resize(originalForm, originalTextTenChuyenKhoa, textTenChuyenKhoa, this, textSizeInitialTextTenChuyenKhoa);
                Graphic.ScaleSize.Resize(originalForm, originalTextTenDichVu, textTenDichVu, this, textSizeInitialTextTenDichVu);
                Graphic.ScaleSize.Resize(originalForm, originalTextTongTien, textTongTien, this, textSizeInitialTextTongTien);
                Graphic.ScaleSize.Resize(originalForm, originalTextHinhThucThanhToan, textHinhThucThanhToan, this, textSizeInitialTextHinhThucThanhToan);
                Graphic.ScaleSize.Resize(originalForm, originalDataMaLichKham, dataMaLichKham, this, textSizeInitialDataMaLichKham);
                Graphic.ScaleSize.Resize(originalForm, originalDataMaHoSoBenhNhan, dataMaHoSoBenhNhan, this, textSizeInitialDataMaHoSoBenhNhan);
                Graphic.ScaleSize.Resize(originalForm, originalDataMaChuyenKhoa, dataMaChuyenKhoa, this, textSizeInitialDataMaChuyenKhoa);
                Graphic.ScaleSize.Resize(originalForm, originalDataMaDichVu, dataMaDichVu, this, textSizeInitialDataMaDichVu);
                Graphic.ScaleSize.Resize(originalForm, originalDataNgayDangKy, dataNgayDangKy, this, textSizeInitialDataNgayDangKy);
                Graphic.ScaleSize.Resize(originalForm, originalDataCa, dataCa, this, textSizeInitialDataCa);
                Graphic.ScaleSize.Resize(originalForm, originalDataKhungGioKham, dataKhungGioKham, this, textSizeInitialDataKhungGioKham);
                Graphic.ScaleSize.Resize(originalForm, originalDataTenChuyenKhoa, dataTenChuyenKhoa, this, textSizeInitialDataTenChuyenKhoa);
                Graphic.ScaleSize.Resize(originalForm, originalDataTenDichVu, dataTenDichVu, this, textSizeInitialDataTenDichVu);
                Graphic.ScaleSize.Resize(originalForm, originalDataTongTien, dataTongTien, this, textSizeInitialDataTongTien);
                Graphic.ScaleSize.Resize(originalForm, originalDataHinhThucThanhToan, dataHinhThucThanhToan, this, textSizeInitialDataHinhThucThanhToan);
                Graphic.ScaleSize.Resize(originalForm, originalButtonReturn, buttonReturn, this);
            }
        }
    }
}
