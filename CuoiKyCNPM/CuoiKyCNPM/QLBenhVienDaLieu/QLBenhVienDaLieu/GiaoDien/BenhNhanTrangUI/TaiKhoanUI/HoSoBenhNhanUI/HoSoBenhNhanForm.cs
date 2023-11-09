using QLBenhVienDaLieu.Database.Check;
using QLBenhVienDaLieu.Database.Class;
using QLBenhVienDaLieu.Database.Function;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace QLBenhVienDaLieu.GiaoDien.BenhNhanTrangUI.TaiKhoanUI.HoSoBenhNhanUI
{
    public partial class HoSoBenhNhanForm : Form
    {
        private SqlFunctionCaller sqlFunctionCaller;

        private BenhNhan_Trang benhNhan_Trang;

        private List<HoSoBenhNhan> listHoSoBenhNhan;

        private int count = 0;

        private Rectangle originalForm;
        private Rectangle originalShowHoSoBenhNhan;
        private Rectangle originalTitleHoSoBenhNhan;
        private Rectangle originalTextTongSoHoSo;
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
        private Rectangle originalDataTongSoHoSo;
        private Rectangle originalDataNumberHoSoBenhNhan;
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
        private Rectangle originalButtonArrowLeft;
        private Rectangle originalButtonArrowRight;
        private Rectangle originalButtonEdit;
        private Rectangle originalButtonSave;
        private Rectangle originalButtonDelete;
        private Rectangle originalButtonAdd;
        private Rectangle originalImageProfile;

        float textSizeInitialTitleHoSoBenhNhan;
        float textSizeInitialTextTongSoHoSo;
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
        float textSizeInitialDataTongSoHoSo;
        float textSizeInitialDataNumberHoSoBenhNhan;
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

        public Label DataTongSoHoSo
        {
            get { return dataTongSoHoSo; }
            set { dataTongSoHoSo = value; }
        }

        public Label DataNumberHoSoBenhNhan
        {
            get { return dataNumberHoSoBenhNhan; }
            set { dataNumberHoSoBenhNhan = value; }
        }

        public TextBox DataMaHoSoBenhNhan
        {
            get { return dataMaHoSoBenhNhan; }
            set { dataMaHoSoBenhNhan = value; }
        }

        public TextBox DataHoVaTen
        {
            get { return dataHoVaTen; }
            set { dataHoVaTen = value; }
        }

        public TextBox DataMaTaiKhoan
        {
            get { return dataMaTaiKhoan; }
            set { dataMaTaiKhoan = value; }
        }

        public TextBox DataNgaySinh
        {
            get { return dataNgaySinh; }
            set { dataNgaySinh = value; }
        }

        public TextBox DataGioiTinh
        {
            get { return dataGioiTinh; }
            set { dataGioiTinh = value; }
        }

        public TextBox DataCCCD
        {
            get { return dataCCCD; }
            set { dataCCCD = value; }
        }

        public TextBox DataMaBHYT
        {
            get { return dataMaBHYT; }
            set { dataMaBHYT = value; }
        }

        public TextBox DataNgheNghiep
        {
            get { return dataNgheNghiep; }
            set { dataNgheNghiep = value; }
        }

        public TextBox DataSoDienThoai
        {
            get { return dataSoDienThoai; }
            set { dataSoDienThoai = value; }
        }

        public TextBox DataEmail
        {
            get { return dataEmail; }
            set { dataEmail = value; }
        }

        public TextBox DataDiaChi
        {
            get { return dataDiaChi; }
            set { dataDiaChi = value; }
        }

        private void setBackgroundImageForAgeAndSex(int namSinh, string gioiTinh)
        {

            int tuoi = DateTime.Now.Year - namSinh;

            if (tuoi < 5)
            {
                imageProfile.BackgroundImage = Image.FromFile("../../Image/profile/baby.png");
            }
            else if (tuoi < 60)
            {
                if (dataGioiTinh.Text.ToLower().Equals("nam"))
                {
                    imageProfile.BackgroundImage = Image.FromFile("../../Image/profile/man.png");
                }
                else if (dataGioiTinh.Text.ToLower().Equals("nữ"))
                {
                    imageProfile.BackgroundImage = Image.FromFile("../../Image/profile/woman.png");
                }
                else
                {

                }
            }
            else
            {
                if (dataGioiTinh.Text.ToLower().Equals("nam"))
                {
                    imageProfile.BackgroundImage = Image.FromFile("../../Image/profile/grandfather.png");
                }
                else if (dataGioiTinh.Text.ToLower().Equals("nữ"))
                {
                    imageProfile.BackgroundImage = Image.FromFile("../../Image/profile/grandmother.png");
                }
                else
                {

                }
            }
        }

        private bool AllDataValid()
        {

            if (dataHoVaTen.ForeColor == Color.Black && dataNgaySinh.ForeColor == Color.Black &&
                dataGioiTinh.ForeColor == Color.Black && dataCCCD.ForeColor == Color.Black &&
                dataMaBHYT.ForeColor == Color.Black && dataNgheNghiep.ForeColor == Color.Black &&
                dataSoDienThoai.ForeColor == Color.Black && dataEmail.ForeColor == Color.Black &&
                dataDiaChi.ForeColor == Color.Black)
            {
                buttonSave.Enabled = true;
                buttonSave.BackColor = Color.White;
                return true;
            }
            buttonSave.Enabled = false;
            buttonSave.BackColor = SystemColors.ControlDark;
            return false;
        }

        private void InputError(TextBox textBox)
        {
            textBox.ForeColor = Color.Red;
            textBox.BackColor = Color.LightCoral;
        }

        private void InputValid(TextBox textBox)
        {
            textBox.ForeColor = Color.Black;
            textBox.BackColor = SystemColors.Control;
        }

        public HoSoBenhNhanForm(SqlFunctionCaller sqlFunctionCaller, BenhNhan_Trang benhNhan_Trang)
        {
            InitializeComponent();

            this.sqlFunctionCaller = sqlFunctionCaller;
            this.benhNhan_Trang = benhNhan_Trang;

            listHoSoBenhNhan = sqlFunctionCaller.GetHoSoBenhNhanByMaTaiKhoanOrSoDienThoai(benhNhan_Trang.SoDienThoai);

            originalForm = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
            originalShowHoSoBenhNhan = new Rectangle(showHoSoBenhNhan.Location.X, showHoSoBenhNhan.Location.Y, showHoSoBenhNhan.Width, showHoSoBenhNhan.Height);
            originalTitleHoSoBenhNhan = new Rectangle(titleHoSoBenhNhan.Location.X, titleHoSoBenhNhan.Location.Y, titleHoSoBenhNhan.Width, titleHoSoBenhNhan.Height);
            originalTextTongSoHoSo = new Rectangle(textTongSoHoSo.Location.X, textTongSoHoSo.Location.Y, textTongSoHoSo.Width, textTongSoHoSo.Height);
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
            originalDataTongSoHoSo = new Rectangle(dataTongSoHoSo.Location.X, dataTongSoHoSo.Location.Y, dataTongSoHoSo.Width, dataTongSoHoSo.Height);
            originalDataNumberHoSoBenhNhan = new Rectangle(dataNumberHoSoBenhNhan.Location.X, dataNumberHoSoBenhNhan.Location.Y, dataNumberHoSoBenhNhan.Width, dataNumberHoSoBenhNhan.Height);
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
            originalButtonArrowLeft = new Rectangle(buttonArrowLeft.Location.X, buttonArrowLeft.Location.Y, buttonArrowLeft.Width, buttonArrowLeft.Height);
            originalButtonArrowRight = new Rectangle(buttonArrowRight.Location.X, buttonArrowRight.Location.Y, buttonArrowRight.Width, buttonArrowRight.Height);
            originalButtonEdit = new Rectangle(buttonEdit.Location.X, buttonEdit.Location.Y, buttonEdit.Width, buttonEdit.Height);
            originalButtonSave = new Rectangle(buttonSave.Location.X, buttonSave.Location.Y, buttonSave.Width, buttonSave.Height);
            originalButtonDelete = new Rectangle(buttonDelete.Location.X, buttonDelete.Location.Y, buttonDelete.Width, buttonDelete.Height);
            originalButtonAdd = new Rectangle(buttonAdd.Location.X, buttonAdd.Location.Y, buttonAdd.Width, buttonAdd.Height);
            originalImageProfile = new Rectangle(imageProfile.Location.X, imageProfile.Location.Y, imageProfile.Width, imageProfile.Height);

            textSizeInitialTitleHoSoBenhNhan = titleHoSoBenhNhan.Font.Size;
            textSizeInitialTextTongSoHoSo = textTongSoHoSo.Font.Size;
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
            textSizeInitialDataTongSoHoSo = dataTongSoHoSo.Font.Size;
            textSizeInitialDataNumberHoSoBenhNhan = dataNumberHoSoBenhNhan.Font.Size;
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

            showHoSoBenhNhan.Region = Graphic.Draw.RoundedRectangle(0, 0, showHoSoBenhNhan.Width, showHoSoBenhNhan.Height, 20, 20);
            buttonAdd.Region = Graphic.Draw.RoundedRectangle(0, 0, buttonAdd.Width, buttonAdd.Height, 20, 20);

            HoSoBenhNhan hoSoBenhNhan = listHoSoBenhNhan[0];

            dataMaHoSoBenhNhan.Text = hoSoBenhNhan.MaHoSoBenhNhan;
            dataHoVaTen.Text = hoSoBenhNhan.HoVaTen;
            dataMaTaiKhoan.Text = hoSoBenhNhan.MaTaiKhoan;
            dataNgaySinh.Text = hoSoBenhNhan.NgaySinh.ToShortDateString();
            dataGioiTinh.Text = hoSoBenhNhan.GioiTinh;
            dataCCCD.Text = hoSoBenhNhan.CCCD;
            dataMaBHYT.Text = hoSoBenhNhan.MaBHYT;
            dataNgheNghiep.Text = hoSoBenhNhan.NgheNghiep;
            dataSoDienThoai.Text = hoSoBenhNhan.SoDienThoai;
            dataEmail.Text = hoSoBenhNhan.Email;
            dataDiaChi.Text = hoSoBenhNhan.DiaChi;

            dataNumberHoSoBenhNhan.Text = (count + 1).ToString();

            dataTongSoHoSo.Text = listHoSoBenhNhan.Count.ToString();

            setBackgroundImageForAgeAndSex(hoSoBenhNhan.NgaySinh.Year, hoSoBenhNhan.GioiTinh);

        }

        private void HoSoBenhNhan_Resize(object sender, EventArgs e)
        {
            Graphic.ScaleSize.Resize(originalForm, originalShowHoSoBenhNhan, showHoSoBenhNhan, this);
            Graphic.ScaleSize.Resize(originalForm, originalTitleHoSoBenhNhan, titleHoSoBenhNhan, this, textSizeInitialTitleHoSoBenhNhan);
            Graphic.ScaleSize.Resize(originalForm, originalTextTongSoHoSo, textTongSoHoSo, this, textSizeInitialTextTongSoHoSo);
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
            Graphic.ScaleSize.Resize(originalForm, originalDataTongSoHoSo, dataTongSoHoSo, this, textSizeInitialDataTongSoHoSo);
            Graphic.ScaleSize.Resize(originalForm, originalDataNumberHoSoBenhNhan, dataNumberHoSoBenhNhan, this, textSizeInitialDataNumberHoSoBenhNhan);
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
            Graphic.ScaleSize.Resize(originalForm, originalButtonArrowLeft, buttonArrowLeft, this);
            Graphic.ScaleSize.Resize(originalForm, originalButtonArrowRight, buttonArrowRight, this);
            Graphic.ScaleSize.Resize(originalForm, originalButtonEdit, buttonEdit, this);
            Graphic.ScaleSize.Resize(originalForm, originalButtonSave, buttonSave, this);
            Graphic.ScaleSize.Resize(originalForm, originalButtonDelete, buttonDelete, this);
            Graphic.ScaleSize.Resize(originalForm, originalButtonAdd, buttonAdd, this);
            Graphic.ScaleSize.Resize(originalForm, originalImageProfile, imageProfile, this);

            showHoSoBenhNhan.Region = Graphic.Draw.RoundedRectangle(0, 0, showHoSoBenhNhan.Width, showHoSoBenhNhan.Height, 20, 20);
            buttonAdd.Region = Graphic.Draw.RoundedRectangle(0, 0, buttonAdd.Width, buttonAdd.Height, 20, 20);


        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            dataHoVaTen.Enabled = true;
            dataNgaySinh.Enabled = true;
            dataGioiTinh.Enabled = true;
            dataCCCD.Enabled = true;
            dataMaBHYT.Enabled = true;
            dataNgheNghiep.Enabled = true;
            dataSoDienThoai.Enabled = true;
            dataEmail.Enabled = true;
            dataDiaChi.Enabled = true;

            buttonSave.Visible = true;

            dataHoVaTen_TextChanged(null, null);
            dataNgaySinh_TextChanged(null, null);
            dataGioiTinh_TextChanged(null, null);
            dataCCCD_TextChanged(null, null);
            dataMaBHYT_TextChanged(null, null);
            dataNgheNghiep_TextChanged(null, null);
            dataSoDienThoai_TextChanged(null, null);
            dataEmail_TextChanged(null, null);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Nếu bạn xóa hồ sơ nó sẽ không thể khôi phục",
                            "Bạn có chắc muốn xóa hồ sơ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                sqlFunctionCaller.DeleteHoSoBenhNhan(dataMaHoSoBenhNhan.Text);

                benhNhan_Trang.buttonHoSoBenhNhan_Click(sender, e);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Panel mainPanelRight = benhNhan_Trang.MainPanelRight;

            mainPanelRight.Controls.Clear();

            DangKyHoSoBenhNhan dangKyHoSoBenhNhan = new DangKyHoSoBenhNhan(sqlFunctionCaller, benhNhan_Trang.SoDienThoai);

            dangKyHoSoBenhNhan.TopLevel = false;
            dangKyHoSoBenhNhan.Dock = DockStyle.Fill;

            mainPanelRight.Controls.Add(dangKyHoSoBenhNhan);
            mainPanelRight.Tag = dangKyHoSoBenhNhan;

            dangKyHoSoBenhNhan.Show();
        }

        private void buttonArrowLeft_Click(object sender, EventArgs e)
        {
            if (listHoSoBenhNhan.Count != 1)
            {
                count--;

                if (count < 0)
                {
                    count = listHoSoBenhNhan.Count - 1;
                }

                HoSoBenhNhan hoSoBenhNhan = listHoSoBenhNhan[count];

                dataMaHoSoBenhNhan.Text = hoSoBenhNhan.MaHoSoBenhNhan;
                dataHoVaTen.Text = hoSoBenhNhan.HoVaTen;
                dataMaTaiKhoan.Text = hoSoBenhNhan.MaTaiKhoan;
                dataNgaySinh.Text = hoSoBenhNhan.NgaySinh.ToShortDateString();
                dataGioiTinh.Text = hoSoBenhNhan.GioiTinh;
                dataCCCD.Text = hoSoBenhNhan.CCCD;
                dataMaBHYT.Text = hoSoBenhNhan.MaBHYT;
                dataNgheNghiep.Text = hoSoBenhNhan.NgheNghiep;
                dataSoDienThoai.Text = hoSoBenhNhan.SoDienThoai;
                dataEmail.Text = hoSoBenhNhan.Email;
                dataDiaChi.Text = hoSoBenhNhan.DiaChi;

                dataNumberHoSoBenhNhan.Text = (count + 1).ToString();

                setBackgroundImageForAgeAndSex(hoSoBenhNhan.NgaySinh.Year, dataGioiTinh.Text);
            }
        }

        private void buttonArrowRight_Click(object sender, EventArgs e)
        {
            if (listHoSoBenhNhan.Count != 1)
            {
                count++;

                if (count > listHoSoBenhNhan.Count - 1)
                {
                    count = 0;
                }

                HoSoBenhNhan hoSoBenhNhan = listHoSoBenhNhan[count];

                dataMaHoSoBenhNhan.Text = hoSoBenhNhan.MaHoSoBenhNhan;
                dataHoVaTen.Text = hoSoBenhNhan.HoVaTen;
                dataMaTaiKhoan.Text = hoSoBenhNhan.MaTaiKhoan;
                dataNgaySinh.Text = hoSoBenhNhan.NgaySinh.ToShortDateString();
                dataGioiTinh.Text = hoSoBenhNhan.GioiTinh;
                dataCCCD.Text = hoSoBenhNhan.CCCD;
                dataMaBHYT.Text = hoSoBenhNhan.MaBHYT;
                dataNgheNghiep.Text = hoSoBenhNhan.NgheNghiep;
                dataSoDienThoai.Text = hoSoBenhNhan.SoDienThoai;
                dataEmail.Text = hoSoBenhNhan.Email;
                dataDiaChi.Text = hoSoBenhNhan.DiaChi;

                dataNumberHoSoBenhNhan.Text = (count + 1).ToString();

                setBackgroundImageForAgeAndSex(hoSoBenhNhan.NgaySinh.Year, dataGioiTinh.Text);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            sqlFunctionCaller.UpdateHoSoBenhNhan(dataMaHoSoBenhNhan.Text, dataHoVaTen.Text, benhNhan_Trang.SoDienThoai,
                                                 DateTime.Parse(dataNgaySinh.Text), dataGioiTinh.Text, dataCCCD.Text,
                                                 dataMaBHYT.Text, dataNgheNghiep.Text, dataSoDienThoai.Text, dataEmail.Text, dataDiaChi.Text);

            MessageBox.Show("Thành công");
        }

        private void dataHoVaTen_TextChanged(object sender, EventArgs e)
        {
            if (Available.CheckHoVaTen(dataHoVaTen.Text))
            {
                InputValid(dataHoVaTen);
            }
            else
            {
                InputError(dataHoVaTen);
            }

            AllDataValid();
        }

        private void dataNgaySinh_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Available.CheckNgaySinh(DateTime.ParseExact(dataNgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture)))
                {
                    InputValid(dataNgaySinh);
                }
                else
                {
                    InputError(dataNgaySinh);

                }

                AllDataValid();

            }
            catch (FormatException)
            {
                InputError(dataNgaySinh);
                AllDataValid();
            }

        }

        private void dataGioiTinh_TextChanged(object sender, EventArgs e)
        {
            if (Available.CheckGioiTinh(dataGioiTinh.Text))
            {
                InputValid(dataGioiTinh);
            }
            else
            {
                InputError(dataGioiTinh);
            }

            AllDataValid();
        }

        private void dataCCCD_TextChanged(object sender, EventArgs e)
        {
            if (Available.CheckCCCD(dataCCCD.Text))
            {
                InputValid(dataCCCD);

            }
            else
            {
                InputError(dataCCCD);
            }

            AllDataValid();
        }

        private void dataMaBHYT_TextChanged(object sender, EventArgs e)
        {

            if (Available.CheckMaBHYT(dataMaBHYT.Text) || dataMaBHYT.Text.Equals(""))
            {
                InputValid(dataMaBHYT);

            }
            else
            {
                InputError(dataMaBHYT);

            }

            AllDataValid();
        }

        private void dataNgheNghiep_TextChanged(object sender, EventArgs e)
        {
            if (Available.CheckNgheNghiep(dataNgheNghiep.Text) || dataNgheNghiep.Text.Equals(""))
            {
                InputValid(dataNgheNghiep);
            }
            else
            {
                InputError(dataNgheNghiep);
            }

            AllDataValid();
        }

        private void dataSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (Available.CheckSoDienThoai(dataSoDienThoai.Text))
            {
                InputValid(dataSoDienThoai);
            }
            else
            {
                InputError(dataSoDienThoai);
            }

            AllDataValid();
        }

        private void dataEmail_TextChanged(object sender, EventArgs e)
        {
            if (Available.CheckEmail(dataEmail.Text) || dataEmail.Text.Equals(""))
            {
                InputValid(dataEmail);
            }
            else
            {
                InputError(dataEmail);

            }

            AllDataValid();
        }

        private void HoSoBenhNhanForm_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                buttonArrowRight_Click(null, null);
            }
            else
            {
                buttonArrowLeft_Click(null, null);
            }

        }

    }
}
