using QLBenhVienDaLieu.Database.Class;
using QLBenhVienDaLieu.Database.Function;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QLBenhVienDaLieu.GiaoDien.KeToanTrangUI.HoaDonUI
{
    public partial class DanhSachHoaDon : Form
    {
        private SqlFunctionCaller sqlFunctionCaller;
        private List<DataHoaDon> listDataHoaDon = new List<DataHoaDon>();

        private Rectangle originalForm;
        private static DataHoaDon dataHoaDon = new DataHoaDon();
        private static Rectangle originalDataHoaDon = new Rectangle(dataHoaDon.Location.X, dataHoaDon.Location.Y, dataHoaDon.Width, dataHoaDon.Height);
        private Rectangle originalTitleDanhSachHoaDon;
        private Rectangle originalCheckBoxHomNay;
        private Rectangle originalTextNgay;
        private Rectangle originalTextThang;
        private Rectangle originalTextNam;
        private Rectangle originalComboBoxNgay;
        private Rectangle originalComboxBoxThang;
        private Rectangle originalComboxBoxNam;
        private Rectangle originalFlowLayoutPanel1;
        private Rectangle originalTextTemp;

        private float textSizeInitialTitleDanhSachHoaDon;
        private float textSizeInitialCheckBoxHomNay;
        private float textSizeInitialTextNgay;
        private float textSizeInitialTextThang;
        private float textSizeInitialTextNam;
        private float textSizeInitialComboBoxNgay;
        private float textSizeInitialComboBoxThang;
        private float textSizeInitialComboBoxNam;

        private void getListHoaDon()
        {
            foreach(DataHoaDon dataHoaDon in listDataHoaDon)
            {
                flowLayoutPanel1.Controls.Remove(dataHoaDon);
            }

            listDataHoaDon.Clear();

            try
            {
                DateTime time = new DateTime(int.Parse(comboBoxNam.Text), int.Parse(comboBoxThang.Text), int.Parse(comboBoxNgay.Text));

                List<LichKham> listLichKham = sqlFunctionCaller.GetLichKhamByNgayDangKy(time);

                foreach (LichKham lichKham in listLichKham)
                {
                    HoaDon hoaDon = sqlFunctionCaller.GetHoaDonByMaLichKham(lichKham.MaLichKham);

                    if (!hoaDon.MaHoaDon.Equals(""))
                    {
                        DataHoaDon dataHoaDon = new DataHoaDon();

                        dataHoaDon.MaHoaDon.Text = hoaDon.MaHoaDon;
                        dataHoaDon.MaLichKham.Text = hoaDon.MaLichKham;
                        dataHoaDon.TongTien.Text = hoaDon.TongTien.ToString();
                        dataHoaDon.HinhThucThanhToan.Text = hoaDon.HinhThucThanhToan;

                        dataHoaDon.TopLevel = false;
                        dataHoaDon.Dock = DockStyle.Top;

                        Graphic.ScaleSize.Resize(originalForm, originalDataHoaDon, dataHoaDon, this);
                        dataHoaDon.Region = Graphic.Draw.RoundedRectangle(0, 0, dataHoaDon.Width, dataHoaDon.Height, 30, 30);

                        listDataHoaDon.Add(dataHoaDon);

                        flowLayoutPanel1.Controls.Add(dataHoaDon);
                        flowLayoutPanel1.Tag = dataHoaDon;

                        dataHoaDon.Show();
                        
                    }
                }


            }
            catch (ArgumentOutOfRangeException e)
            {
                
            }
        }

        public DanhSachHoaDon(SqlFunctionCaller sqlFunctionCaller)
        {
            this.sqlFunctionCaller = sqlFunctionCaller;

            InitializeComponent();

            originalForm = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
            originalTitleDanhSachHoaDon = new Rectangle(titleDanhSachHoaDon.Location.X, titleDanhSachHoaDon.Location.Y, titleDanhSachHoaDon.Width, titleDanhSachHoaDon.Height);
            originalCheckBoxHomNay = new Rectangle(checkBoxHomNay.Location.X, checkBoxHomNay.Location.Y, checkBoxHomNay.Width, checkBoxHomNay.Height);
            originalTextNgay = new Rectangle(textNgay.Location.X, textNgay.Location.Y, textNgay.Width, textNgay.Height);
            originalTextThang = new Rectangle(textThang.Location.X, textThang.Location.Y, textThang.Width, textThang.Height);
            originalTextNam = new Rectangle(textNam.Location.X, textNam.Location.Y, textNam.Width, textNam.Height);
            originalComboBoxNgay = new Rectangle(comboBoxNgay.Location.X, comboBoxNgay.Location.Y, comboBoxNgay.Width, comboBoxNgay.Height);
            originalComboxBoxThang = new Rectangle(comboBoxThang.Location.X, comboBoxThang.Location.Y, comboBoxThang.Width, comboBoxThang.Height);
            originalComboxBoxNam = new Rectangle(comboBoxNam.Location.X, comboBoxNam.Location.Y, comboBoxNam.Width, comboBoxNam.Height);
            originalFlowLayoutPanel1 = new Rectangle(flowLayoutPanel1.Location.X, flowLayoutPanel1.Location.Y, flowLayoutPanel1.Width, flowLayoutPanel1.Height);
            originalTextTemp = new Rectangle(textTemp.Location.X, textTemp.Location.Y, textTemp.Width, textTemp.Height);

            textSizeInitialTitleDanhSachHoaDon = titleDanhSachHoaDon.Font.Size;
            textSizeInitialCheckBoxHomNay = checkBoxHomNay.Font.Size;
            textSizeInitialTextNgay = textNgay.Font.Size;
            textSizeInitialTextThang = textThang.Font.Size;
            textSizeInitialTextNam = textNam.Font.Size;
            textSizeInitialComboBoxNgay = comboBoxNgay.Font.Size;
            textSizeInitialComboBoxThang = comboBoxThang.Font.Size;
            textSizeInitialComboBoxNam = comboBoxNam.Font.Size;
        }

        private void DanhSachHoaDon_Resize(object sender, EventArgs e)
        {
            Graphic.ScaleSize.Resize(originalForm, originalTitleDanhSachHoaDon, titleDanhSachHoaDon, this, textSizeInitialTitleDanhSachHoaDon);
            Graphic.ScaleSize.Resize(originalForm, originalCheckBoxHomNay, checkBoxHomNay, this, textSizeInitialCheckBoxHomNay);
            Graphic.ScaleSize.Resize(originalForm, originalTextNgay, textNgay, this, textSizeInitialTextNgay);
            Graphic.ScaleSize.Resize(originalForm, originalTextThang, textThang, this, textSizeInitialTextThang);
            Graphic.ScaleSize.Resize(originalForm, originalTextNam, textNam, this, textSizeInitialTextNam);
            Graphic.ScaleSize.Resize(originalForm, originalComboBoxNgay, comboBoxNgay, this, textSizeInitialComboBoxNgay);
            Graphic.ScaleSize.Resize(originalForm, originalComboxBoxThang, comboBoxThang, this, textSizeInitialComboBoxThang);
            Graphic.ScaleSize.Resize(originalForm, originalComboxBoxNam, comboBoxNam, this, textSizeInitialComboBoxNam);
            Graphic.ScaleSize.Resize(originalForm, originalFlowLayoutPanel1, flowLayoutPanel1, this);
            Graphic.ScaleSize.ResizeX(originalForm, originalTextTemp, textTemp, this);

            foreach(DataHoaDon dataHoaDon in flowLayoutPanel1.Controls.OfType<DataHoaDon>().ToList())
            {
                Graphic.ScaleSize.Resize(originalForm, originalDataHoaDon, dataHoaDon, this);
                dataHoaDon.Region = Graphic.Draw.RoundedRectangle(0, 0, dataHoaDon.Width, dataHoaDon.Height, 30, 30);
            }

        }

        private void comboBoxNgay_TextChanged(object sender, EventArgs e)
        {
            if (!comboBoxNgay.Text.Equals("") && !comboBoxThang.Text.Equals("") && !comboBoxNam.Text.Equals(""))
            {
                getListHoaDon();
            }
            else
            {
                foreach (DataHoaDon dataHoaDon in listDataHoaDon)
                {
                    flowLayoutPanel1.Controls.Remove(dataHoaDon);
                }

                listDataHoaDon.Clear();
            }
        }

        private void comboBoxThang_TextChanged(object sender, EventArgs e)
        {
            if (!comboBoxNgay.Text.Equals("") && !comboBoxThang.Text.Equals("") && !comboBoxNam.Text.Equals(""))
            {
                getListHoaDon();
            }
            else
            {
                foreach (DataHoaDon dataHoaDon in listDataHoaDon)
                {
                    flowLayoutPanel1.Controls.Remove(dataHoaDon);
                }

                listDataHoaDon.Clear();
            }
        }

        private void comboBoxNam_TextChanged(object sender, EventArgs e)
        {
            if (!comboBoxNgay.Text.Equals("") && !comboBoxThang.Text.Equals("") && !comboBoxNam.Text.Equals(""))
            {
                getListHoaDon();
            }
            else
            {
                foreach (DataHoaDon dataHoaDon in listDataHoaDon)
                {
                    flowLayoutPanel1.Controls.Remove(dataHoaDon);
                }

                listDataHoaDon.Clear();
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

                getListHoaDon();
            }
            else
            {
                comboBoxNgay.Text = "";
                comboBoxThang.Text = "";
                comboBoxNam.Text = "";
            }
        }
    }
}
