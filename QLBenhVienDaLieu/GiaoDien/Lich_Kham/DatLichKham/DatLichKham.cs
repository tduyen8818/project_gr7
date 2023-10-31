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
        SqlFunctionCaller sqlFunctionCaller;
        BenhNhan_Trang benhNhan_Trang;

        Rectangle originalForm;
        Rectangle originalTextTemp;
        Rectangle originalImageUser;
        Rectangle originalBtnAccount;
        Rectangle originalBtnDatLich;
        Rectangle originalTitleDatLich;
        Rectangle originalTextChuyenKhoa;
        Rectangle originalDataChuyenKhoa;
        Rectangle originalTextDichVu;
        Rectangle originalDataDichVu;
        Rectangle originalTextNgayKham;
        Rectangle originalDataNgayKham;
        Rectangle originalTextCaKham;
        Rectangle originalDataCaKham;
        Rectangle originalTextHoSoBenhNhan;
        Rectangle originalShowHoSoBenhNhan;
        Rectangle originalTextErrorChuyenKhoa;
        Rectangle originalTextErrorDichVu;
        Rectangle originalTextErrorCaKham;
        Rectangle originalImageCheck;
        Rectangle originalImageCheck1;
        Rectangle originalImageCheck2;

        float textSizeInitialBtnAccount;
        float textSizeInitialBtnDatLich;
        float textSizeInitialTitleDatLich;
        float textSizeInitialTextChuyenKhoa;
        float textSizeInitialDataChuyenKhoa;
        float textSizeInitialTextDichVu;
        float textSizeInitialDataDichVu;
        float textSizeInitialTextNgayKham;
        float textSizeInitialDataNgayKham;
        float textSizeInitialTextCaKham;
        float textSizeInitialDataCaKham;
        float textSizeInitialTextHoSoBenhNhan;
        float textSizeInitialTextErrorChuyenKhoa;
        float textSizeInitialTextErrorDichVu;
        float textSizeInitialTextErrorCaKham;

        int day;
        int month;
        int year;
        int hour;
        int minute;

        public DatLichKham(SqlFunctionCaller sqlFunctionCaller, BenhNhan_Trang benhNhan_Trang)
        {
            this.sqlFunctionCaller = sqlFunctionCaller;
            this.benhNhan_Trang = benhNhan_Trang;

            InitializeComponent();

            originalForm = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
            originalTextTemp = new Rectangle(textTemp.Location.X, textTemp.Location.Y, textTemp.Width, textTemp.Height);
            originalImageUser = new Rectangle(imageUser.Location.X, imageUser.Location.Y, imageUser.Width, imageUser.Width);
            originalBtnAccount = new Rectangle(btnAccount.Location.X, btnAccount.Location.Y, btnAccount.Width, btnAccount.Height);
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
            originalImageCheck = new Rectangle(imageCheck.Location.X, imageCheck.Location.Y, imageCheck.Width, imageCheck.Height);
            originalImageCheck1 = new Rectangle(imageCheck1.Location.X, imageCheck1.Location.Y, imageCheck1.Width, imageCheck1.Height);
            originalImageCheck2 = new Rectangle(imageCheck2.Location.X, imageCheck2.Location.Y, imageCheck2.Width, imageCheck2.Height);

            imageUser.Region = Draw.RoundedRectangle(0, 0, imageUser.Width, imageUser.Height, 57, 70);
            btnAccount.Region = Draw.RoundedRectangle(0, 0, btnAccount.Width, btnAccount.Height, 35, 35);
            btnDatLich.Region = Draw.RoundedRectangle(0, 0, btnDatLich.Width, btnDatLich.Height, 50, 50);
            showHoSoBenhNhan.Region = Draw.RoundedRectangle(0, 0, showHoSoBenhNhan.Width, showHoSoBenhNhan.Height, 20, 20);

            textSizeInitialBtnAccount = btnAccount.Font.Size;
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

            
            foreach(HoSoBenhNhan hoSoBenhNhan in sqlFunctionCaller.GetHoSoBenhNhanByMaTaiKhoanOrSoDienThoai("0123456789"))
            {
                DataHoSoBenhNhan dataHoSoBenhNhan = new DataHoSoBenhNhan();

                dataHoSoBenhNhan.TopLevel = false;
                dataHoSoBenhNhan.Dock = DockStyle.Top;

                dataHoSoBenhNhan.DataMaHoSoBenhNhan.Text = hoSoBenhNhan.MaHoSoBenhNhan;
                dataHoSoBenhNhan.DataHoVaTen.Text = hoSoBenhNhan.HoVaTen;
                dataHoSoBenhNhan.DataMaTaiKhoan.Text = hoSoBenhNhan.MaTaiKhoan;
                dataHoSoBenhNhan.DataNgaySinh.Text = hoSoBenhNhan.NgaySinh.ToString();
                dataHoSoBenhNhan.DataGioiTinh.Text = hoSoBenhNhan.GioiTinh;
                dataHoSoBenhNhan.DataCCCD.Text = hoSoBenhNhan.CCCD;
                dataHoSoBenhNhan.DataMaBHYT.Text = hoSoBenhNhan.MaBHYT;
                dataHoSoBenhNhan.DataNgheNghiep.Text = hoSoBenhNhan.NgheNghiep;
                dataHoSoBenhNhan.DataSoDienThoai.Text = hoSoBenhNhan.SoDienThoai;
                dataHoSoBenhNhan.DataEmail.Text = hoSoBenhNhan.Email;
                dataHoSoBenhNhan.DataDiaChi.Text = hoSoBenhNhan.DiaChi;

                showHoSoBenhNhan.Controls.Add(dataHoSoBenhNhan);
                showHoSoBenhNhan.Tag = dataHoSoBenhNhan;

                dataHoSoBenhNhan.Show();
            }

            

        }

        private void DatLichKham_Resize(object sender, EventArgs e)
        {
            ScaleSize.Resize(originalForm, originalImageUser, imageUser, this);
            ScaleSize.Resize(originalForm, originalTextTemp, textTemp, this);
            ScaleSize.Resize(originalForm, originalBtnAccount, btnAccount, this, textSizeInitialBtnAccount);
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
            ScaleSize.Resize(originalForm, originalImageCheck, imageCheck, this);
            ScaleSize.Resize(originalForm, originalImageCheck1, imageCheck1, this);
            ScaleSize.Resize(originalForm, originalImageCheck2, imageCheck2, this);


            imageUser.Region = Draw.RoundedRectangle(0, 0, imageUser.Width, imageUser.Height, 57, 70);
            btnAccount.Region = Draw.RoundedRectangle(0, 0, btnAccount.Width, btnAccount.Height, 35, 35);
            btnDatLich.Region = Draw.RoundedRectangle(0, 0, btnDatLich.Width, btnDatLich.Height, 50, 50);
            showHoSoBenhNhan.Region = Draw.RoundedRectangle(0, 0, showHoSoBenhNhan.Width, showHoSoBenhNhan.Height, 20, 20);
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
                string[] time = dataNgayKham.Value.ToString().Split(' ');
                string[] dayMonthYear = time[0].Split('/');
                string[] hourMinute = time[1].Split(':');
                day = int.Parse(dayMonthYear[0]);
                month = int.Parse(dayMonthYear[1]);
                year = int.Parse(dayMonthYear[2]);
                hour = int.Parse(hourMinute[0]);
                minute = int.Parse(hourMinute[1]);

                DateTime ngayDangKy = new DateTime(year, month, day);
                DateTime khungGioKham = new DateTime(year, month, day, hour, minute, 0);

                if (DateTime.Compare(ngayDangKy, DateTime.Now) < 0) {
                    MessageBox.Show("Thời gian không hợp lệ");
                    return;
                }

                string maHoSoBenhNhan = "";
                string maChuyenKhoa = "";
                string maDichVu = "";

                string ca = dataCaKham.SelectedItem.ToString();

                maHoSoBenhNhan = sqlFunctionCaller.GetHoSoBenhNhanByMaTaiKhoanOrSoDienThoai("0123456789").Last().MaHoSoBenhNhan;

                maChuyenKhoa = sqlFunctionCaller.GetChuyenKhoaByTenChuyenKhoa(dataChuyenKhoa.SelectedItem.ToString()).MaChuyenKhoa;

                maDichVu = sqlFunctionCaller.GetDichVuByTenDichVu(dataDichVu.SelectedItem.ToString()).MaDichVu;

                sqlFunctionCaller.InsertLichKham(maHoSoBenhNhan, maChuyenKhoa, maDichVu, ngayDangKy, ca, khungGioKham);


                benhNhan_Trang.MainPanelRight.Controls.Clear();
                DatLichKhamThanhToan datLichKhamThanhToan = new DatLichKhamThanhToan(sqlFunctionCaller);
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
