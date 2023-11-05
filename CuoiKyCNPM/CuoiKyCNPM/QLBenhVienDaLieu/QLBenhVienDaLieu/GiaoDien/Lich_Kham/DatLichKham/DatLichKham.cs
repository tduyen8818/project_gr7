using QLBenhVienDaLieu.Class;
using QLBenhVienDaLieu.Database;
using QLBenhVienDaLieu.Graphic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBenhVienDaLieu.GiaoDien.Lich_Kham.DatLichKham
{
    public partial class DatLichKham : Form
    {
        private SqlFunctionCaller sqlFunctionCaller;
        private BenhNhan_Trang benhNhan_Trang;

        private string soDienThoai;
        private int countChecked = 0;
        private DataHoSoBenhNhan hoSoBenhNhanChoosed;

        private List<DataHoSoBenhNhan> listDataHoSoBenhNhan = new List<DataHoSoBenhNhan>();

        private Rectangle originalForm;
        private Rectangle originalBtnDatLich;
        private Rectangle originalTitleDatLich;
        private Rectangle originalTextChuyenKhoa;
        private Rectangle originalDataChuyenKhoa;
        private Rectangle originalTextDichVu;
        private Rectangle originalDataDichVu;
        private Rectangle originalTextNgayKham;
        private Rectangle originalDataNgayKham;
        private Rectangle originalTextCaKham;
        private Rectangle originalDataCaKham;
        private Rectangle originalTextHoSoBenhNhan;
        private Rectangle originalShowHoSoBenhNhan;
        private Rectangle originalTextErrorChuyenKhoa;
        private Rectangle originalTextErrorDichVu;
        private Rectangle originalTextErrorCaKham;
        private Rectangle originalTextErrorHoSoBenhNhan;
        private Rectangle originalImageCheck;
        private Rectangle originalImageCheck1;
        private Rectangle originalImageCheck2;
        private Rectangle originalImageCheck3;
        private Rectangle originalTextTemp;

        private float textSizeInitialBtnAccount;
        private float textSizeInitialBtnDatLich;
        private float textSizeInitialTitleDatLich;
        private float textSizeInitialTextChuyenKhoa;
        private float textSizeInitialDataChuyenKhoa;
        private float textSizeInitialTextDichVu;
        private float textSizeInitialDataDichVu;
        private float textSizeInitialTextNgayKham;
        private float textSizeInitialDataNgayKham;
        private float textSizeInitialTextCaKham;
        private float textSizeInitialDataCaKham;
        private float textSizeInitialTextHoSoBenhNhan;
        private float textSizeInitialTextErrorChuyenKhoa;
        private float textSizeInitialTextErrorDichVu;
        private float textSizeInitialTextErrorCaKham;
        private float textSizeInitialTextErrorHoSoBenhNhan;

        private string SoDienThoai
        {
            get { return this.soDienThoai; }
            set {this.soDienThoai = value; } 
        }

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

        public DataHoSoBenhNhan HoSoBenhNhanChoosed
        {
            get { return this.hoSoBenhNhanChoosed; }
            set { this.hoSoBenhNhanChoosed = value; }
        }

        public DatLichKham(SqlFunctionCaller sqlFunctionCaller, BenhNhan_Trang benhNhan_Trang, string soDienThoai)
        {
            this.sqlFunctionCaller = sqlFunctionCaller;
            this.benhNhan_Trang = benhNhan_Trang;
            this.soDienThoai = soDienThoai;

            InitializeComponent();

            originalForm = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
            originalBtnDatLich = new Rectangle(btnDatLich.Location.X, btnDatLich.Location.Y, btnDatLich.Width, btnDatLich.Height);
            originalTitleDatLich = new Rectangle(titleDatLich.Location.X, titleDatLich.Location.Y, titleDatLich.Width, titleDatLich.Height);
            originalTextChuyenKhoa = new Rectangle(textChuyenKhoa.Location.X, textChuyenKhoa.Location.Y, textChuyenKhoa.Width, textChuyenKhoa.Height);
            originalDataChuyenKhoa = new Rectangle(dataChuyenKhoa.Location.X, dataChuyenKhoa.Location.Y, dataChuyenKhoa.Width, dataChuyenKhoa.Height);
            originalTextDichVu = new Rectangle(textDichVu.Location.X, textDichVu.Location.Y, textDichVu.Width, textDichVu.Height);
            originalDataDichVu = new Rectangle(dataDichVu.Location.X, dataDichVu.Location.Y, dataDichVu.Width, dataDichVu.Height);
            originalTextNgayKham = new Rectangle(textNgayKham.Location.X, textNgayKham.Location.Y, textNgayKham.Width, textNgayKham.Height);
            originalDataNgayKham = new Rectangle(dataNgayKham.Location.X, dataNgayKham.Location.Y, dataNgayKham.Width, dataNgayKham.Height);
            originalTextCaKham = new Rectangle(textCaKham.Location.X, textCaKham.Location.Y, textCaKham.Width, textCaKham.Height);
            originalDataCaKham = new Rectangle(dataCaKham.Location.X, dataCaKham.Location.Y, dataCaKham.Width, dataCaKham.Height);
            originalTextHoSoBenhNhan = new Rectangle(textHoSoBenhNhan.Location.X, textHoSoBenhNhan.Location.Y, textHoSoBenhNhan.Width, textHoSoBenhNhan.Height);
            originalShowHoSoBenhNhan = new Rectangle(showHoSoBenhNhan.Location.X, showHoSoBenhNhan.Location.Y, showHoSoBenhNhan.Width, showHoSoBenhNhan.Height);
            originalTextErrorChuyenKhoa = new Rectangle(textErrorChuyenKhoa.Location.X, textErrorChuyenKhoa.Location.Y, textErrorChuyenKhoa.Width, textErrorChuyenKhoa.Height);
            originalTextErrorDichVu = new Rectangle(textErrorDichVu.Location.X, textErrorDichVu.Location.Y, textErrorDichVu.Width, textErrorDichVu.Height);
            originalTextErrorCaKham = new Rectangle(textErrorCaKham.Location.X, textErrorCaKham.Location.Y, textErrorCaKham.Width, textErrorCaKham.Height);
            originalTextErrorHoSoBenhNhan = new Rectangle(textErrorHoSoBenhNhan.Location.X, textErrorHoSoBenhNhan.Location.Y, textErrorHoSoBenhNhan.Width, textErrorHoSoBenhNhan.Height);
            originalImageCheck = new Rectangle(imageCheck.Location.X, imageCheck.Location.Y, imageCheck.Width, imageCheck.Height);
            originalImageCheck1 = new Rectangle(imageCheck1.Location.X, imageCheck1.Location.Y, imageCheck1.Width, imageCheck1.Height);
            originalImageCheck2 = new Rectangle(imageCheck2.Location.X, imageCheck2.Location.Y, imageCheck2.Width, imageCheck2.Height);
            originalImageCheck3 = new Rectangle(imageCheck3.Location.X, imageCheck3.Location.Y, imageCheck3.Width, imageCheck3.Height);
            originalTextTemp = new Rectangle(textTemp.Location.X, textTemp.Location.Y, textTemp.Width, textTemp.Height);

            btnDatLich.Region = Draw.RoundedRectangle(0, 0, btnDatLich.Width, btnDatLich.Height, 50, 50);

            textSizeInitialBtnDatLich = btnDatLich.Font.Size;
            textSizeInitialTitleDatLich = titleDatLich.Font.Size;
            textSizeInitialTextChuyenKhoa = textChuyenKhoa.Font.Size;
            textSizeInitialDataChuyenKhoa = dataChuyenKhoa.Font.Size;
            textSizeInitialTextDichVu = textDichVu.Font.Size;
            textSizeInitialDataDichVu = dataDichVu.Font.Size;
            textSizeInitialTextNgayKham = textNgayKham.Font.Size;
            textSizeInitialDataNgayKham = dataNgayKham.Font.Size;
            textSizeInitialTextCaKham = textCaKham.Font.Size;
            textSizeInitialDataCaKham = dataCaKham.Font.Size;
            textSizeInitialTextHoSoBenhNhan = textHoSoBenhNhan.Font.Size;
            textSizeInitialTextErrorChuyenKhoa = textErrorChuyenKhoa.Font.Size;
            textSizeInitialTextErrorDichVu = textErrorDichVu.Font.Size;
            textSizeInitialTextErrorCaKham = textErrorCaKham.Font.Size;
            textSizeInitialTextErrorHoSoBenhNhan = textErrorHoSoBenhNhan.Font.Size;

            foreach (ChuyenKhoa chuyenKhoa in sqlFunctionCaller.GetChuyenKhoa())
            {
                dataChuyenKhoa.Items.Add(chuyenKhoa.TenChuyenKhoa);
            }

            foreach (DichVu dichVu in sqlFunctionCaller.GetDichVu())
            {
                dataDichVu.Items.Add(dichVu.TenDichVu);
            }

            dataCaKham.Items.Add("Sáng");
            dataCaKham.Items.Add("Chiều");

            List<HoSoBenhNhan> listHoSoBenhNhan = sqlFunctionCaller.GetHoSoBenhNhanByMaTaiKhoanOrSoDienThoai(this.soDienThoai);

            if (listHoSoBenhNhan.Count == 1)
            {
                showHoSoBenhNhan.Controls.Clear();
                HoSoBenhNhan hoSoBenhNhan = listHoSoBenhNhan.Last();

                DataHoSoBenhNhan dataHoSoBenhNhan = new DataHoSoBenhNhan();

                dataHoSoBenhNhan.TopLevel = false;
                dataHoSoBenhNhan.Dock = DockStyle.Fill;

                dataHoSoBenhNhan.DataMaHoSoBenhNhan.Text = hoSoBenhNhan.MaHoSoBenhNhan;
                dataHoSoBenhNhan.DataHoVaTen.Text = hoSoBenhNhan.HoVaTen;
                dataHoSoBenhNhan.DataMaTaiKhoan.Text = hoSoBenhNhan.MaTaiKhoan;
                dataHoSoBenhNhan.DataNgaySinh.Text = hoSoBenhNhan.NgaySinh.ToShortDateString();
                dataHoSoBenhNhan.DataGioiTinh.Text = hoSoBenhNhan.GioiTinh;
                dataHoSoBenhNhan.DataCCCD.Text = hoSoBenhNhan.CCCD;
                dataHoSoBenhNhan.DataMaBHYT.Text = hoSoBenhNhan.MaBHYT;
                dataHoSoBenhNhan.DataNgheNghiep.Text = hoSoBenhNhan.NgheNghiep;
                dataHoSoBenhNhan.DataSoDienThoai.Text = hoSoBenhNhan.SoDienThoai;
                dataHoSoBenhNhan.DataEmail.Text = hoSoBenhNhan.Email;
                dataHoSoBenhNhan.DataDiaChi.Text = hoSoBenhNhan.DiaChi;

                listDataHoSoBenhNhan.Add(dataHoSoBenhNhan);

                showHoSoBenhNhan.Controls.Add(dataHoSoBenhNhan);
                showHoSoBenhNhan.Tag = dataHoSoBenhNhan;

                dataHoSoBenhNhan.Show();
            } else
            {
                foreach (HoSoBenhNhan hoSoBenhNhan in listHoSoBenhNhan)
                {
                    DataHoSoBenhNhan dataHoSoBenhNhan = new DataHoSoBenhNhan();

                    dataHoSoBenhNhan.TopLevel = false;
                    dataHoSoBenhNhan.Dock = DockStyle.Top;

                    dataHoSoBenhNhan.DataMaHoSoBenhNhan.Text = hoSoBenhNhan.MaHoSoBenhNhan;
                    dataHoSoBenhNhan.DataHoVaTen.Text = hoSoBenhNhan.HoVaTen;
                    dataHoSoBenhNhan.DataMaTaiKhoan.Text = hoSoBenhNhan.MaTaiKhoan;
                    dataHoSoBenhNhan.DataNgaySinh.Text = hoSoBenhNhan.NgaySinh.ToShortDateString();
                    dataHoSoBenhNhan.DataGioiTinh.Text = hoSoBenhNhan.GioiTinh;
                    dataHoSoBenhNhan.DataCCCD.Text = hoSoBenhNhan.CCCD;
                    dataHoSoBenhNhan.DataMaBHYT.Text = hoSoBenhNhan.MaBHYT;
                    dataHoSoBenhNhan.DataNgheNghiep.Text = hoSoBenhNhan.NgheNghiep;
                    dataHoSoBenhNhan.DataSoDienThoai.Text = hoSoBenhNhan.SoDienThoai;
                    dataHoSoBenhNhan.DataEmail.Text = hoSoBenhNhan.Email;
                    dataHoSoBenhNhan.DataDiaChi.Text = hoSoBenhNhan.DiaChi;

                    listDataHoSoBenhNhan.Add(dataHoSoBenhNhan);

                    flowLayoutPanel1.Controls.Add(dataHoSoBenhNhan);
                    flowLayoutPanel1.Tag = dataHoSoBenhNhan;

                    dataHoSoBenhNhan.Show();
                }
            }
        }

        private void DatLichKham_Resize(object sender, EventArgs e)
        {
            ScaleSize.Resize(originalForm, originalBtnDatLich, btnDatLich, this, textSizeInitialBtnDatLich);
            ScaleSize.Resize(originalForm, originalTitleDatLich, titleDatLich, this, textSizeInitialTitleDatLich);
            ScaleSize.Resize(originalForm, originalTextChuyenKhoa, textChuyenKhoa, this, textSizeInitialTextChuyenKhoa);
            ScaleSize.Resize(originalForm, originalDataChuyenKhoa, dataChuyenKhoa, this, textSizeInitialDataChuyenKhoa);
            ScaleSize.Resize(originalForm, originalTextDichVu, textDichVu, this, textSizeInitialTextDichVu);
            ScaleSize.Resize(originalForm, originalDataDichVu, dataDichVu, this, textSizeInitialDataDichVu);
            ScaleSize.Resize(originalForm, originalTextNgayKham, textNgayKham, this, textSizeInitialTextNgayKham);
            ScaleSize.Resize(originalForm, originalDataNgayKham, dataNgayKham, this, textSizeInitialDataNgayKham);
            ScaleSize.Resize(originalForm, originalTextCaKham, textCaKham, this, textSizeInitialTextCaKham);
            ScaleSize.Resize(originalForm, originalDataCaKham, dataCaKham, this, textSizeInitialDataCaKham);
            ScaleSize.Resize(originalForm, originalTextHoSoBenhNhan, textHoSoBenhNhan, this, textSizeInitialTextHoSoBenhNhan);
            ScaleSize.Resize(originalForm, originalShowHoSoBenhNhan, showHoSoBenhNhan, this);
            ScaleSize.Resize(originalForm, originalTextErrorChuyenKhoa, textErrorChuyenKhoa, this, textSizeInitialTextErrorChuyenKhoa);
            ScaleSize.Resize(originalForm, originalTextErrorDichVu, textErrorDichVu, this, textSizeInitialTextErrorDichVu);
            ScaleSize.Resize(originalForm, originalTextErrorCaKham, textErrorCaKham, this, textSizeInitialTextErrorCaKham);
            ScaleSize.Resize(originalForm, originalTextErrorHoSoBenhNhan, textErrorHoSoBenhNhan, this, textSizeInitialTextErrorHoSoBenhNhan);
            ScaleSize.Resize(originalForm, originalImageCheck, imageCheck, this);
            ScaleSize.Resize(originalForm, originalImageCheck1, imageCheck1, this);
            ScaleSize.Resize(originalForm, originalImageCheck2, imageCheck2, this);
            ScaleSize.Resize(originalForm, originalImageCheck3, imageCheck3, this);
            ScaleSize.Resize(originalForm, originalTextTemp, textTemp, this);

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

            foreach (DataHoSoBenhNhan data in listDataHoSoBenhNhan)
            {
                if (data.CheckChoose.Checked)
                {
                    this.countChecked++;
                    this.hoSoBenhNhanChoosed = data;
                }
            }

            if (countChecked != 1)
            {
                textErrorHoSoBenhNhan.Visible = true;
                imageCheck3.Image = Image.FromFile("../../Image/check/error.jpg");
            } else
            {
                textErrorHoSoBenhNhan.Visible = false;
                imageCheck3.Image = Image.FromFile("../../Image/check/true.jpg");
            }

            if (dataChuyenKhoa.SelectedItem != null && dataDichVu.SelectedItem != null && dataCaKham.SelectedItem != null &&  countChecked == 1)
            {
                this.countChecked = 0;

                DateTime ngayDangKy = DateTime.Parse(dataNgayKham.Value.ToShortDateString());
                DateTime khungGioKham = DateTime.Parse(dataNgayKham.Value.ToLongTimeString());

                if (DateTime.Compare(ngayDangKy, DateTime.Now) < 0) {
                    MessageBox.Show("Thời gian không hợp lệ");
                    return;
                }

                string maHoSoBenhNhan = hoSoBenhNhanChoosed.DataMaHoSoBenhNhan.Text;
                string maChuyenKhoa = sqlFunctionCaller.GetChuyenKhoaByTenChuyenKhoa(dataChuyenKhoa.SelectedItem.ToString()).MaChuyenKhoa;
                string maDichVu = sqlFunctionCaller.GetDichVuByTenDichVu(dataDichVu.SelectedItem.ToString()).MaDichVu;
                string ca = dataCaKham.SelectedItem.ToString();

                sqlFunctionCaller.InsertLichKham(maHoSoBenhNhan, maChuyenKhoa, maDichVu, ngayDangKy, ca, khungGioKham);


                benhNhan_Trang.MainPanelRight.Controls.Clear();
                DatLichKhamThanhToan datLichKhamThanhToan = new DatLichKhamThanhToan(sqlFunctionCaller, this);
                datLichKhamThanhToan.TopLevel = false;
                datLichKhamThanhToan.Dock = DockStyle.Fill;
                benhNhan_Trang.MainPanelRight.Controls.Add(datLichKhamThanhToan);
                benhNhan_Trang.MainPanelRight.Tag = datLichKhamThanhToan;
                datLichKhamThanhToan.Show();
            }
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
