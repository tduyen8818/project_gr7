using QLBenhVienDaLieu.Database.Class;
using QLBenhVienDaLieu.Database.Function;
using QLBenhVienDaLieu.GiaoDien.BenhNhanTrangUI.LichKhamUI.DatLichKhamUI;
using QLBenhVienDaLieu.Graphic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBenhVienDaLieu.GiaoDien.LeTanTrangUI.HoSoBenhNhanUI
{
    public partial class DatLichKhamFormLeTan : Form
    {
        private SqlFunctionCaller sqlFunctionCaller;
        private string maTaiKhoan;
        private string maHoSoBenhNhan;
        private LeTan_Trang leTan_Trang;

        private Rectangle originalForm;
        private Rectangle originalBtnDatLich;
        private Rectangle originalTitleDatLich;
        private Rectangle originalTextMaHoSoBenhNhan;
        private Rectangle originalDataMaHoSoBenhNhan;
        private Rectangle originalTextDotMaHoSoBenhNhan;
        private Rectangle originalTextChuyenKhoa;
        private Rectangle originalDataChuyenKhoa;
        private Rectangle originalTextDichVu;
        private Rectangle originalDataDichVu;
        private Rectangle originalTextNgayKham;
        private Rectangle originalDataNgayKham;
        private Rectangle originalTextCaKham;
        private Rectangle originalDataCaKham;
        private Rectangle originalTextErrorChuyenKhoa;
        private Rectangle originalTextErrorDichVu;
        private Rectangle originalTextErrorCaKham;
        private Rectangle originalImageCheck;
        private Rectangle originalImageCheck1;
        private Rectangle originalImageCheck2;

        private float textSizeInitialBtnDatLich;
        private float textSizeInitialTitleDatLich;
        private float textSizeInitialTextMaHoSoBenhNhan;
        private float textSizeInitialDataMaHoSoBenhNhan;
        private float textSizeInitialTextDotMaHoSoBenhNhan;
        private float textSizeInitialTextChuyenKhoa;
        private float textSizeInitialDataChuyenKhoa;
        private float textSizeInitialTextDichVu;
        private float textSizeInitialDataDichVu;
        private float textSizeInitialTextNgayKham;
        private float textSizeInitialDataNgayKham;
        private float textSizeInitialTextCaKham;
        private float textSizeInitialDataCaKham;
        private float textSizeInitialTextErrorChuyenKhoa;
        private float textSizeInitialTextErrorDichVu;
        private float textSizeInitialTextErrorCaKham;


        public ComboBox DataChuyenKhoa
        {
            get { return this.dataChuyenKhoa; }
            set { this.dataChuyenKhoa = value; }
        }

        public ComboBox DataDichVu
        {
            get { return this.dataDichVu; }
            set { this.dataDichVu = value; }
        }

        public DateTimePicker DataNgayKham
        {
            get { return this.dataNgayKham; }
            set { this.dataNgayKham = value; }
        }

        public ComboBox DataCaKham
        {
            get { return this.dataCaKham; }
            set { this.dataCaKham = value; }
        }

        public TextBox DataMaHoSoBenhNhan
        {
            get
            {
                return dataMaHoSoBenhNhan;
            }
            set
            {
                dataMaHoSoBenhNhan = value;
            }
        }


        public DatLichKhamFormLeTan(string maTaiKhoan, string maHoSoBenhNhan, LeTan_Trang leTan_Trang, SqlFunctionCaller sqlFunctionCaller)
        {
            this.sqlFunctionCaller = sqlFunctionCaller;
            this.maTaiKhoan = maTaiKhoan;
            this.maHoSoBenhNhan= maHoSoBenhNhan;
            this.leTan_Trang = leTan_Trang;

            InitializeComponent();

            originalForm = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
            originalBtnDatLich = new Rectangle(btnDatLich.Location.X, btnDatLich.Location.Y, btnDatLich.Width, btnDatLich.Height);
            originalTitleDatLich = new Rectangle(titleDatLich.Location.X, titleDatLich.Location.Y, titleDatLich.Width, titleDatLich.Height);
            originalTextMaHoSoBenhNhan = new Rectangle(textMaHoSoBenhNhan.Location.X, textMaHoSoBenhNhan.Location.Y, textMaHoSoBenhNhan.Width, textMaHoSoBenhNhan.Height);
            originalDataMaHoSoBenhNhan = new Rectangle(dataMaHoSoBenhNhan.Location.X, dataMaHoSoBenhNhan.Location.Y, dataMaHoSoBenhNhan.Width, dataMaHoSoBenhNhan.Height);
            originalTextDotMaHoSoBenhNhan = new Rectangle(textDotMaHoSoBenhNhan.Location.X, textDotMaHoSoBenhNhan.Location.Y, textDotMaHoSoBenhNhan.Width, textDotMaHoSoBenhNhan.Height);
            originalTextChuyenKhoa = new Rectangle(textChuyenKhoa.Location.X, textChuyenKhoa.Location.Y, textChuyenKhoa.Width, textChuyenKhoa.Height);
            originalDataChuyenKhoa = new Rectangle(dataChuyenKhoa.Location.X, dataChuyenKhoa.Location.Y, dataChuyenKhoa.Width, dataChuyenKhoa.Height);
            originalTextDichVu = new Rectangle(textDichVu.Location.X, textDichVu.Location.Y, textDichVu.Width, textDichVu.Height);
            originalDataDichVu = new Rectangle(dataDichVu.Location.X, dataDichVu.Location.Y, dataDichVu.Width, dataDichVu.Height);
            originalTextNgayKham = new Rectangle(textNgayKham.Location.X, textNgayKham.Location.Y, textNgayKham.Width, textNgayKham.Height);
            originalDataNgayKham = new Rectangle(dataNgayKham.Location.X, dataNgayKham.Location.Y, dataNgayKham.Width, dataNgayKham.Height);
            originalTextCaKham = new Rectangle(textCaKham.Location.X, textCaKham.Location.Y, textCaKham.Width, textCaKham.Height);
            originalDataCaKham = new Rectangle(dataCaKham.Location.X, dataCaKham.Location.Y, dataCaKham.Width, dataCaKham.Height);
            originalTextErrorChuyenKhoa = new Rectangle(textErrorChuyenKhoa.Location.X, textErrorChuyenKhoa.Location.Y, textErrorChuyenKhoa.Width, textErrorChuyenKhoa.Height);
            originalTextErrorDichVu = new Rectangle(textErrorDichVu.Location.X, textErrorDichVu.Location.Y, textErrorDichVu.Width, textErrorDichVu.Height);
            originalTextErrorCaKham = new Rectangle(textErrorCaKham.Location.X, textErrorCaKham.Location.Y, textErrorCaKham.Width, textErrorCaKham.Height);
            originalImageCheck = new Rectangle(imageCheck.Location.X, imageCheck.Location.Y, imageCheck.Width, imageCheck.Height);
            originalImageCheck1 = new Rectangle(imageCheck1.Location.X, imageCheck1.Location.Y, imageCheck1.Width, imageCheck1.Height);
            originalImageCheck2 = new Rectangle(imageCheck2.Location.X, imageCheck2.Location.Y, imageCheck2.Width, imageCheck2.Height);

            btnDatLich.Region = Draw.RoundedRectangle(0, 0, btnDatLich.Width, btnDatLich.Height, 50, 50);

            textSizeInitialBtnDatLich = btnDatLich.Font.Size;
            textSizeInitialTitleDatLich = titleDatLich.Font.Size;
            textSizeInitialTextMaHoSoBenhNhan = textMaHoSoBenhNhan.Font.Size;
            textSizeInitialDataMaHoSoBenhNhan = dataMaHoSoBenhNhan.Font.Size;
            textSizeInitialTextDotMaHoSoBenhNhan = textDotMaHoSoBenhNhan.Font.Size;
            textSizeInitialTextChuyenKhoa = textChuyenKhoa.Font.Size;
            textSizeInitialDataChuyenKhoa = dataChuyenKhoa.Font.Size;
            textSizeInitialTextDichVu = textDichVu.Font.Size;
            textSizeInitialDataDichVu = dataDichVu.Font.Size;
            textSizeInitialTextNgayKham = textNgayKham.Font.Size;
            textSizeInitialDataNgayKham = dataNgayKham.Font.Size;
            textSizeInitialTextCaKham = textCaKham.Font.Size;
            textSizeInitialDataCaKham = dataCaKham.Font.Size;
            textSizeInitialTextErrorChuyenKhoa = textErrorChuyenKhoa.Font.Size;
            textSizeInitialTextErrorDichVu = textErrorDichVu.Font.Size;
            textSizeInitialTextErrorCaKham = textErrorCaKham.Font.Size;

            dataMaHoSoBenhNhan.Text = this.maHoSoBenhNhan;

            foreach (ChuyenKhoa chuyenKhoa in sqlFunctionCaller.GetChuyenKhoa())
            {
                dataChuyenKhoa.Items.Add(chuyenKhoa.TenChuyenKhoa);
            }

            foreach (DichVu dichVu in sqlFunctionCaller.GetDichVu())
            {
                dataDichVu.Items.Add(dichVu.TenDichVu);
            }

        }

        private void DatLichKhamFormLeTan_Resize(object sender, EventArgs e)
        {
            ScaleSize.Resize(originalForm, originalBtnDatLich, btnDatLich, this, textSizeInitialBtnDatLich);
            ScaleSize.Resize(originalForm, originalTitleDatLich, titleDatLich, this, textSizeInitialTitleDatLich);
            ScaleSize.Resize(originalForm, originalTextMaHoSoBenhNhan, textMaHoSoBenhNhan, this, textSizeInitialTextMaHoSoBenhNhan);
            ScaleSize.Resize(originalForm, originalDataMaHoSoBenhNhan, dataMaHoSoBenhNhan, this, textSizeInitialDataMaHoSoBenhNhan);
            ScaleSize.Resize(originalForm, originalTextDotMaHoSoBenhNhan, textDotMaHoSoBenhNhan, this, textSizeInitialTextDotMaHoSoBenhNhan);
            ScaleSize.Resize(originalForm, originalTextChuyenKhoa, textChuyenKhoa, this, textSizeInitialTextChuyenKhoa);
            ScaleSize.Resize(originalForm, originalDataChuyenKhoa, dataChuyenKhoa, this, textSizeInitialDataChuyenKhoa);
            ScaleSize.Resize(originalForm, originalTextDichVu, textDichVu, this, textSizeInitialTextDichVu);
            ScaleSize.Resize(originalForm, originalDataDichVu, dataDichVu, this, textSizeInitialDataDichVu);
            ScaleSize.Resize(originalForm, originalTextNgayKham, textNgayKham, this, textSizeInitialTextNgayKham);
            ScaleSize.Resize(originalForm, originalDataNgayKham, dataNgayKham, this, textSizeInitialDataNgayKham);
            ScaleSize.Resize(originalForm, originalTextCaKham, textCaKham, this, textSizeInitialTextCaKham);
            ScaleSize.Resize(originalForm, originalDataCaKham, dataCaKham, this, textSizeInitialDataCaKham);
            ScaleSize.Resize(originalForm, originalTextErrorChuyenKhoa, textErrorChuyenKhoa, this, textSizeInitialTextErrorChuyenKhoa);
            ScaleSize.Resize(originalForm, originalTextErrorDichVu, textErrorDichVu, this, textSizeInitialTextErrorDichVu);
            ScaleSize.Resize(originalForm, originalTextErrorCaKham, textErrorCaKham, this, textSizeInitialTextErrorCaKham);
            ScaleSize.Resize(originalForm, originalImageCheck, imageCheck, this);
            ScaleSize.Resize(originalForm, originalImageCheck1, imageCheck1, this);
            ScaleSize.Resize(originalForm, originalImageCheck2, imageCheck2, this);

            btnDatLich.Region = Draw.RoundedRectangle(0, 0, btnDatLich.Width, btnDatLich.Height, 50, 50);
        }

        private void btnDatLich_Click(object sender, EventArgs e)
        {
            if (dataChuyenKhoa.SelectedItem == null)
            {
                textErrorChuyenKhoa.Visible = true;
                imageCheck.Image = Image.FromFile("../../Image/check/error.jpg");
            }
            else
            {
                textErrorChuyenKhoa.Visible = false;
                imageCheck.Image = Image.FromFile("../../Image/check/true.jpg");
            }

            if (dataDichVu.SelectedItem == null)
            {
                textErrorDichVu.Visible = true;
                imageCheck1.Image = Image.FromFile("../../Image/check/error.jpg");
            }
            else
            {
                textErrorDichVu.Visible = false;
                imageCheck1.Image = Image.FromFile("../../Image/check/true.jpg");
            }

            if (dataCaKham.SelectedItem == null)
            {
                textErrorCaKham.Visible = true;
                imageCheck2.Image = Image.FromFile("../../Image/check/error.jpg");
            }
            else
            {
                textErrorCaKham.Visible = false;
                imageCheck2.Image = Image.FromFile("../../Image/check/true.jpg");
            }

            if (dataChuyenKhoa.SelectedItem != null && dataDichVu.SelectedItem != null && dataCaKham.SelectedItem != null)
            {
                DateTime ngayDangKy = DateTime.Parse(dataNgayKham.Value.ToShortDateString());
                DateTime khungGioKham = DateTime.Parse(dataNgayKham.Value.ToLongTimeString());

                if (DateTime.Compare(ngayDangKy, DateTime.Now) < 0)
                {
                    MessageBox.Show("Thời gian không hợp lệ");
                    return;
                }

                string maChuyenKhoa = sqlFunctionCaller.GetChuyenKhoaByTenChuyenKhoa(dataChuyenKhoa.SelectedItem.ToString()).MaChuyenKhoa;
                string maDichVu = sqlFunctionCaller.GetDichVuByTenDichVu(dataDichVu.SelectedItem.ToString()).MaDichVu;
                string ca = dataCaKham.SelectedItem.ToString();

                sqlFunctionCaller.InsertLichKham(maHoSoBenhNhan, maChuyenKhoa, maDichVu, ngayDangKy, ca, khungGioKham);

                MessageBox.Show("Đặt lịch khám thành công");
                
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Panel guna2CustomGradientPanel2 = this.leTan_Trang.Guna2CustomGradientPanel2;

            guna2CustomGradientPanel2.Controls.Clear();

            HoSoBenhNhanForm hoSoBenhNhanForm = new HoSoBenhNhanForm(this.leTan_Trang, sqlFunctionCaller);

            hoSoBenhNhanForm.TopLevel = false;
            hoSoBenhNhanForm.Dock = DockStyle.Fill;

            hoSoBenhNhanForm.TextBoxSearchMaTaiKhoan.Text = this.maTaiKhoan;

            hoSoBenhNhanForm.buttonSearch_Click(null, null);

            guna2CustomGradientPanel2.Controls.Add(hoSoBenhNhanForm);
            guna2CustomGradientPanel2.Tag = hoSoBenhNhanForm;

            hoSoBenhNhanForm.Show();
        }

        private void dataChuyenKhoa_TextChanged(object sender, EventArgs e)
        {
            textErrorChuyenKhoa.Visible = false;
            imageCheck.Image = Image.FromFile("../../Image/check/true.jpg");
        }

        private void dataDichVu_TextChanged(object sender, EventArgs e)
        {
            textErrorDichVu.Visible = false;
            imageCheck1.Image = Image.FromFile("../../Image/check/true.jpg");
        }

        private void dataCaKham_TextChanged(object sender, EventArgs e)
        {
            textErrorCaKham.Visible = false;
            imageCheck2.Image = Image.FromFile("../../Image/check/true.jpg");
        }
    }
}
