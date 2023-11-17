using QLBenhVienDaLieu.Database.Class;
using QLBenhVienDaLieu.Database.Function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBenhVienDaLieu.GiaoDien.KeToanTrangUI.ThongKeUI
{
    public partial class ThongKeDoanhThu : Form
    {
        private SqlFunctionCaller sqlFunctionCaller;

        private Rectangle originalForm;
        private Rectangle originalTitleThongKeDoanhThu;
        private Rectangle originalCheckBoxHomNay;
        private Rectangle originalTextNgay;
        private Rectangle originalTextThang;
        private Rectangle originalTextNam;
        private Rectangle originalTextTongDoanhThu;
        private Rectangle originalTextTongHoaDon;
        private Rectangle originalComboBoxNgay;
        private Rectangle originalComboxBoxThang;
        private Rectangle originalComboxBoxNam;
        private Rectangle originalDataTongDoanhThu;
        private Rectangle originalDataTongHoaDon;

        private float textSizeInitialTitleThongKeDoanhThu;
        private float textSizeInitialCheckBoxHomNay;
        private float textSizeInitialTextNgay;
        private float textSizeInitialTextThang;
        private float textSizeInitialTextNam;
        private float textSizeInitialTextTongDoanhThu;
        private float textSizeInitialTextTongHoaDon;
        private float textSizeInitialComboBoxNgay;
        private float textSizeInitialComboBoxThang;
        private float textSizeInitialComboBoxNam;
        private float textSizeInitialDataTongHoaDon;
        private float textSizeInitialDataTongDoanhThu;

        private void getTongDoanhThuVaTongHoaDon()
        {
            try
            {
                DateTime time = new DateTime(int.Parse(comboBoxNam.Text), int.Parse(comboBoxThang.Text), int.Parse(comboBoxNgay.Text));

                List<LichKham> listLichKham = sqlFunctionCaller.GetLichKhamByNgayDangKy(time);

                int tongDoanhThu = 0;
                int tongHoaDon = 0;

                foreach (LichKham lichKham in listLichKham)
                {
                    HoaDon hoaDon = sqlFunctionCaller.GetHoaDonByMaLichKham(lichKham.MaLichKham);

                    if (!hoaDon.MaHoaDon.Equals(""))
                    {
                        tongDoanhThu += hoaDon.TongTien;
                        tongHoaDon++;
                    }
                }

                dataTongDoanhThu.Text = tongDoanhThu.ToString();
                dataTongHoaDon.Text = tongHoaDon.ToString();
            } catch(ArgumentOutOfRangeException e)
            {
                dataTongDoanhThu.Text = "";
                dataTongHoaDon.Text = "";
            }
        }


        public ThongKeDoanhThu(SqlFunctionCaller sqlFunctionCaller)
        {
            this.sqlFunctionCaller = sqlFunctionCaller;

            InitializeComponent();

            originalForm = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
            originalTitleThongKeDoanhThu = new Rectangle(titleThongKeDoanhThu.Location.X, titleThongKeDoanhThu.Location.Y, titleThongKeDoanhThu.Width, titleThongKeDoanhThu.Height);
            originalCheckBoxHomNay = new Rectangle(checkBoxHomNay.Location.X, checkBoxHomNay.Location.Y, checkBoxHomNay.Width, checkBoxHomNay.Height);
            originalTextNgay = new Rectangle(textNgay.Location.X, textNgay.Location.Y, textNgay.Width, textNgay.Height);
            originalTextThang = new Rectangle(textThang.Location.X, textThang.Location.Y, textThang.Width, textThang.Height);
            originalTextNam = new Rectangle(textNam.Location.X, textNam.Location.Y, textNam.Width, textNam.Height);
            originalTextTongDoanhThu = new Rectangle(textTongDoanhThu.Location.X, textTongDoanhThu.Location.Y, textTongDoanhThu.Width, textTongDoanhThu.Height);
            originalTextTongHoaDon = new Rectangle(textTongHoaDon.Location.X, textTongHoaDon.Location.Y, textTongHoaDon.Width, textTongHoaDon.Height);
            originalComboBoxNgay = new Rectangle(comboBoxNgay.Location.X, comboBoxNgay.Location.Y, comboBoxNgay.Width, comboBoxNgay.Height);
            originalComboxBoxThang = new Rectangle(comboBoxThang.Location.X, comboBoxThang.Location.Y, comboBoxThang.Width, comboBoxThang.Height);
            originalComboxBoxNam = new Rectangle(comboBoxNam.Location.X, comboBoxNam.Location.Y, comboBoxNam.Width, comboBoxNam.Height);
            originalDataTongDoanhThu = new Rectangle(dataTongDoanhThu.Location.X, dataTongDoanhThu.Location.Y, dataTongDoanhThu.Width, dataTongDoanhThu.Height);
            originalDataTongHoaDon = new Rectangle(dataTongHoaDon.Location.X, dataTongHoaDon.Location.Y, dataTongHoaDon.Width, dataTongHoaDon.Height);

            textSizeInitialTitleThongKeDoanhThu = titleThongKeDoanhThu.Font.Size;
            textSizeInitialCheckBoxHomNay = checkBoxHomNay.Font.Size;
            textSizeInitialTextNgay = textNgay.Font.Size;
            textSizeInitialTextThang = textThang.Font.Size;
            textSizeInitialTextNam = textNam.Font.Size;
            textSizeInitialTextTongDoanhThu = textTongDoanhThu.Font.Size;
            textSizeInitialTextTongHoaDon = textTongHoaDon.Font.Size;
            textSizeInitialComboBoxNgay = comboBoxNgay.Font.Size;
            textSizeInitialComboBoxThang = comboBoxThang.Font.Size;
            textSizeInitialComboBoxNam = comboBoxNam.Font.Size;
            textSizeInitialDataTongDoanhThu = dataTongDoanhThu.Font.Size;
            textSizeInitialDataTongHoaDon = dataTongHoaDon.Font.Size;
        }

        private void comboBoxNgay_TextChanged(object sender, EventArgs e)
        {
            if (!comboBoxNgay.Text.Equals("") && !comboBoxThang.Text.Equals("") && !comboBoxNam.Text.Equals(""))
            {
                getTongDoanhThuVaTongHoaDon();
            } else
            {
                dataTongDoanhThu.Text = "";
                dataTongHoaDon.Text = "";
            }
        }

        private void comboBoxThang_TextChanged(object sender, EventArgs e)
        {
            if (!comboBoxNgay.Text.Equals("") && !comboBoxThang.Text.Equals("") && !comboBoxNam.Text.Equals(""))
            {
                getTongDoanhThuVaTongHoaDon();
            } else
            {
                dataTongDoanhThu.Text = "";
                dataTongHoaDon.Text = "";
            }
        }

        private void comboBoxNam_TextChanged(object sender, EventArgs e)
        {
            if (!comboBoxNgay.Text.Equals("") && !comboBoxThang.Text.Equals("") && !comboBoxNam.Text.Equals(""))
            {
                getTongDoanhThuVaTongHoaDon();
            } else
            {
                dataTongDoanhThu.Text = "";
                dataTongHoaDon.Text = "";
            }
        }

        private void checkBoxHomNay_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHomNay.Checked == true)
            {
                DateTime now = DateTime.Now;

                comboBoxNgay.Text = now.Day.ToString();
                comboBoxThang.Text = now.Month.ToString();
                comboBoxNam.Text = now.Year.ToString();

                getTongDoanhThuVaTongHoaDon();
            }
            else
            {
                comboBoxNgay.Text = "";
                comboBoxThang.Text = "";
                comboBoxNam.Text = "";
            }
        }

        private void ThongKeDoanhThu_Resize(object sender, EventArgs e)
        {
            Graphic.ScaleSize.Resize(originalForm, originalTitleThongKeDoanhThu, titleThongKeDoanhThu, this, textSizeInitialTitleThongKeDoanhThu);
            Graphic.ScaleSize.Resize(originalForm, originalCheckBoxHomNay, checkBoxHomNay, this, textSizeInitialCheckBoxHomNay);
            Graphic.ScaleSize.Resize(originalForm, originalTextNgay, textNgay, this, textSizeInitialTextNgay);
            Graphic.ScaleSize.Resize(originalForm, originalTextThang, textThang, this, textSizeInitialTextThang);
            Graphic.ScaleSize.Resize(originalForm, originalTextNam, textNam, this, textSizeInitialTextNam);
            Graphic.ScaleSize.Resize(originalForm, originalTextTongDoanhThu, textTongDoanhThu, this, textSizeInitialTextTongDoanhThu);
            Graphic.ScaleSize.Resize(originalForm, originalTextTongHoaDon, textTongHoaDon, this, textSizeInitialTextTongHoaDon);
            Graphic.ScaleSize.Resize(originalForm, originalComboBoxNgay, comboBoxNgay, this, textSizeInitialComboBoxNgay);
            Graphic.ScaleSize.Resize(originalForm, originalComboxBoxThang, comboBoxThang, this, textSizeInitialComboBoxThang);
            Graphic.ScaleSize.Resize(originalForm, originalComboxBoxNam, comboBoxNam, this, textSizeInitialComboBoxNam);
            Graphic.ScaleSize.Resize(originalForm, originalDataTongDoanhThu, dataTongDoanhThu, this, textSizeInitialDataTongDoanhThu);
            Graphic.ScaleSize.Resize(originalForm, originalDataTongHoaDon, dataTongHoaDon, this, textSizeInitialDataTongHoaDon);
        }
    }
}
