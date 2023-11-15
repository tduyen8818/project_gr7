using System;
using System.Drawing;
using System.Windows.Forms;

namespace QLBenhVienDaLieu.GiaoDien.BenhNhanTrangUI.LichKhamUI.DatLichKhamUI
{
    public partial class DataHoSoBenhNhan : Form
    {
        public CheckBox CheckChoose
        {
            get { return this.checkChoose; }
            set { this.checkChoose = value; }
        }

        public Label DataMaHoSoBenhNhan { get { return this.dataMaHoSoBenhNhan; } set { this.dataMaHoSoBenhNhan = value; } }
        public Label DataHoVaTen { get { return this.dataHoVaTen; } set { this.dataHoVaTen = value; } }
        public Label DataMaTaiKhoan { get { return this.dataMaTaiKhoan; } set { this.dataMaTaiKhoan = value; } }
        public Label DataNgaySinh { get { return this.dataNgaySinh; } set { this.dataNgaySinh = value; } }
        public Label DataGioiTinh { get { return this.dataGioiTinh; } set { this.dataGioiTinh = value; } }
        public Label DataCCCD { get { return this.dataCCCD; } set { this.dataCCCD = value; } }
        public Label DataMaBHYT { get { return this.dataMaBHYT; } set { this.dataMaBHYT = value; } }
        public Label DataNgheNghiep { get { return this.dataNgheNghiep; } set { this.dataNgheNghiep = value; } }
        public Label DataSoDienThoai { get { return this.dataSoDienThoai; } set { this.dataSoDienThoai = value; } }
        public Label DataEmail { get { return this.dataEmail; } set { this.dataEmail = value; } }
        public Label DataDiaChi { get { return this.dataDiaChi; } set { this.dataDiaChi = value; } }

        private Rectangle originalForm;
        private Rectangle originalCheckChoose;
        private Rectangle originalTextMaHoSoBenhNhan;
        private Rectangle originalTextHoVaTen;
        private Rectangle originalTextMaTaiKhoan;
        private Rectangle originalTextNgaySinh;
        private Rectangle originalTextGioitinh;
        private Rectangle originalTextCCCD;
        private Rectangle originalTextMaBHYT;
        private Rectangle originalTextNgheNghiep;
        private Rectangle originalTextSoDienThoai;
        private Rectangle originalTextEmail;
        private Rectangle originalTextDiaChi;
        private Rectangle originalDataMaHoSoBenhNhan;
        private Rectangle originalDataHoVaTen;
        private Rectangle originalDataMaTaiKhoan;
        private Rectangle originalDataNgaySinh;
        private Rectangle originalDataGioitinh;
        private Rectangle originalDataCCCD;
        private Rectangle originalDataMaBHYT;
        private Rectangle originalDataNgheNghiep;
        private Rectangle originalDataSoDienThoai;
        private Rectangle originalDataEmail;
        private Rectangle originalDataDiaChi;

        float textSizeInitialTextMaHoSoBenhNhan;
        float textSizeInitialTextHoVaTen;
        float textSizeInitialTextMaTaiKhoan;
        float textSizeInitialTextNgaySinh;
        float textSizeInitialTextGioiTinh;
        float textSizeInitialTextCCCD;
        float textSizeInitialTextMaBHYT;
        float textSizeInitialTextNgheNghiep;
        float textSizeInitialTextSoDienThoai;
        float textSizeInitialTextEmail;
        float textSizeInitialTextDiaChi;
        float textSizeInitialDataMaHoSoBenhNhan;
        float textSizeInitialDataHoVaTen;
        float textSizeInitialDataMaTaiKhoan;
        float textSizeInitialDataNgaySinh;
        float textSizeInitialDataGioiTinh;
        float textSizeInitialDataCCCD;
        float textSizeInitialDataMaBHYT;
        float textSizeInitialDataNgheNghiep;
        float textSizeInitialDataSoDienThoai;
        float textSizeInitialDataEmail;
        float textSizeInitialDataDiaChi;






        public DataHoSoBenhNhan()
        {
            InitializeComponent();

            originalForm = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
            originalCheckChoose = new Rectangle(checkChoose.Location.X, checkChoose.Location.Y, checkChoose.Width, checkChoose.Height);
            originalTextMaHoSoBenhNhan = new Rectangle(textMaHoSoBenhNhan.Location.X, textMaHoSoBenhNhan.Location.Y, textMaHoSoBenhNhan.Width, textMaHoSoBenhNhan.Height);
            originalTextHoVaTen = new Rectangle(textHoVaTen.Location.X, textHoVaTen.Location.Y, textHoVaTen.Width, textHoVaTen.Height);
            originalTextMaTaiKhoan = new Rectangle(textMaTaiKhoan.Location.X, textMaTaiKhoan.Location.Y, textMaTaiKhoan.Width, textMaTaiKhoan.Height);
            originalTextNgaySinh = new Rectangle(textNgaySinh.Location.X, textNgaySinh.Location.Y, textNgaySinh.Width, textNgaySinh.Height);
            originalTextGioitinh = new Rectangle(textGioiTinh.Location.X, textGioiTinh.Location.Y, textGioiTinh.Width, textGioiTinh.Height);
            originalTextCCCD = new Rectangle(textCCCD.Location.X, textCCCD.Location.Y, textCCCD.Width, textCCCD.Height);
            originalTextMaBHYT = new Rectangle(textMaBHYT.Location.X, textMaBHYT.Location.Y, textMaBHYT.Width, textMaBHYT.Height);
            originalTextNgheNghiep = new Rectangle(textNgheNghiep.Location.X, textNgheNghiep.Location.Y, textNgheNghiep.Width, textNgheNghiep.Height);
            originalTextSoDienThoai = new Rectangle(textSoDienThoai.Location.X, textSoDienThoai.Location.Y, textSoDienThoai.Width, textSoDienThoai.Height);
            originalTextEmail = new Rectangle(textEmail.Location.X, textEmail.Location.Y, textEmail.Width, textEmail.Height);
            originalTextDiaChi = new Rectangle(textDiaChi.Location.X, textDiaChi.Location.Y, textDiaChi.Width, textDiaChi.Height);
            originalDataMaHoSoBenhNhan = new Rectangle(dataMaHoSoBenhNhan.Location.X, dataMaHoSoBenhNhan.Location.Y, dataMaHoSoBenhNhan.Width, dataMaHoSoBenhNhan.Height);
            originalDataHoVaTen = new Rectangle(dataHoVaTen.Location.X, dataHoVaTen.Location.Y, dataHoVaTen.Width, dataHoVaTen.Height);
            originalDataMaTaiKhoan = new Rectangle(dataMaTaiKhoan.Location.X, dataMaTaiKhoan.Location.Y, dataMaTaiKhoan.Width, dataMaTaiKhoan.Height);
            originalDataNgaySinh = new Rectangle(dataNgaySinh.Location.X, dataNgaySinh.Location.Y, dataNgaySinh.Width, dataNgaySinh.Height);
            originalDataGioitinh = new Rectangle(dataGioiTinh.Location.X, dataGioiTinh.Location.Y, dataGioiTinh.Width, dataGioiTinh.Height);
            originalDataCCCD = new Rectangle(dataCCCD.Location.X, dataCCCD.Location.Y, dataCCCD.Width, dataCCCD.Height);
            originalDataMaBHYT = new Rectangle(dataMaBHYT.Location.X, dataMaBHYT.Location.Y, dataMaBHYT.Width, dataMaBHYT.Height);
            originalDataNgheNghiep = new Rectangle(dataNgheNghiep.Location.X, dataNgheNghiep.Location.Y, dataNgheNghiep.Width, dataNgheNghiep.Height);
            originalDataSoDienThoai = new Rectangle(dataSoDienThoai.Location.X, dataSoDienThoai.Location.Y, dataSoDienThoai.Width, dataSoDienThoai.Height);
            originalDataEmail = new Rectangle(dataEmail.Location.X, dataEmail.Location.Y, dataEmail.Width, dataEmail.Height);
            originalDataDiaChi = new Rectangle(dataDiaChi.Location.X, dataDiaChi.Location.Y, dataDiaChi.Width, dataDiaChi.Height);


            textSizeInitialTextMaHoSoBenhNhan = textMaHoSoBenhNhan.Font.Size;
            textSizeInitialTextHoVaTen = textHoVaTen.Font.Size;
            textSizeInitialTextMaTaiKhoan = textMaTaiKhoan.Font.Size;
            textSizeInitialTextNgaySinh = textNgaySinh.Font.Size;
            textSizeInitialTextGioiTinh = textGioiTinh.Font.Size;
            textSizeInitialTextCCCD = textCCCD.Font.Size;
            textSizeInitialTextMaBHYT = textMaBHYT.Font.Size;
            textSizeInitialTextNgheNghiep = textNgheNghiep.Font.Size;
            textSizeInitialTextSoDienThoai = textSoDienThoai.Font.Size;
            textSizeInitialTextEmail = textEmail.Font.Size;
            textSizeInitialTextDiaChi = textDiaChi.Font.Size;
            textSizeInitialDataMaHoSoBenhNhan = dataMaHoSoBenhNhan.Font.Size;
            textSizeInitialDataHoVaTen = dataHoVaTen.Font.Size;
            textSizeInitialDataMaTaiKhoan = dataMaTaiKhoan.Font.Size;
            textSizeInitialDataNgaySinh = dataNgaySinh.Font.Size;
            textSizeInitialDataGioiTinh = dataGioiTinh.Font.Size;
            textSizeInitialDataCCCD = dataCCCD.Font.Size;
            textSizeInitialDataMaBHYT = dataMaBHYT.Font.Size;
            textSizeInitialDataNgheNghiep = dataNgheNghiep.Font.Size;
            textSizeInitialDataSoDienThoai = dataSoDienThoai.Font.Size;
            textSizeInitialDataEmail = dataEmail.Font.Size;
            textSizeInitialDataDiaChi = dataDiaChi.Font.Size;
        }


        private void checkChoose_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkChoose.Checked)
            {
                this.BackColor = Color.Lavender;
            }
            else
            {
                this.BackColor = SystemColors.Control;
            }
        }

        private void DataHoSoBenhNhan_Resize(object sender, EventArgs e)
        {
            if (originalForm.Width != 0)
            {
                Graphic.ScaleSize.Resize(originalForm, originalCheckChoose, checkChoose, this);
                Graphic.ScaleSize.Resize(originalForm, originalTextMaHoSoBenhNhan, textMaHoSoBenhNhan, this, textSizeInitialTextMaHoSoBenhNhan);
                Graphic.ScaleSize.Resize(originalForm, originalTextHoVaTen, textHoVaTen, this, textSizeInitialTextHoVaTen);
                Graphic.ScaleSize.Resize(originalForm, originalTextMaTaiKhoan, textMaTaiKhoan, this, textSizeInitialTextMaTaiKhoan);
                Graphic.ScaleSize.Resize(originalForm, originalTextNgaySinh, textNgaySinh, this, textSizeInitialTextNgaySinh);
                Graphic.ScaleSize.Resize(originalForm, originalTextGioitinh, textGioiTinh, this, textSizeInitialTextGioiTinh);
                Graphic.ScaleSize.Resize(originalForm, originalTextCCCD, textCCCD, this, textSizeInitialTextCCCD);
                Graphic.ScaleSize.Resize(originalForm, originalTextMaBHYT, textMaBHYT, this, textSizeInitialTextMaBHYT);
                Graphic.ScaleSize.Resize(originalForm, originalTextNgheNghiep, textNgheNghiep, this, textSizeInitialTextNgheNghiep);
                Graphic.ScaleSize.Resize(originalForm, originalTextSoDienThoai, textSoDienThoai, this, textSizeInitialTextSoDienThoai);
                Graphic.ScaleSize.Resize(originalForm, originalTextEmail, textEmail, this, textSizeInitialTextEmail);
                Graphic.ScaleSize.Resize(originalForm, originalTextDiaChi, textDiaChi, this, textSizeInitialTextDiaChi);
                Graphic.ScaleSize.Resize(originalForm, originalDataMaHoSoBenhNhan, dataMaHoSoBenhNhan, this, textSizeInitialDataMaHoSoBenhNhan);
                Graphic.ScaleSize.Resize(originalForm, originalDataHoVaTen, dataHoVaTen, this, textSizeInitialDataHoVaTen);
                Graphic.ScaleSize.Resize(originalForm, originalDataMaTaiKhoan, dataMaTaiKhoan, this, textSizeInitialDataMaTaiKhoan);
                Graphic.ScaleSize.Resize(originalForm, originalDataNgaySinh, dataNgaySinh, this, textSizeInitialDataNgaySinh);
                Graphic.ScaleSize.Resize(originalForm, originalDataGioitinh, dataGioiTinh, this, textSizeInitialDataGioiTinh);
                Graphic.ScaleSize.Resize(originalForm, originalDataCCCD, dataCCCD, this, textSizeInitialDataCCCD);
                Graphic.ScaleSize.Resize(originalForm, originalDataMaBHYT, dataMaBHYT, this, textSizeInitialDataMaBHYT);
                Graphic.ScaleSize.Resize(originalForm, originalDataNgheNghiep, dataNgheNghiep, this, textSizeInitialDataNgheNghiep);
                Graphic.ScaleSize.Resize(originalForm, originalDataSoDienThoai, dataSoDienThoai, this, textSizeInitialDataSoDienThoai);
                Graphic.ScaleSize.Resize(originalForm, originalDataEmail, dataEmail, this, textSizeInitialDataEmail);
                Graphic.ScaleSize.Resize(originalForm, originalDataDiaChi, dataDiaChi, this, textSizeInitialDataDiaChi);
            }

        }
    }
}
