﻿using QLBenhVienDaLieu.Database.Function;
using QLBenhVienDaLieu.Graphic;
using System;
using System.Drawing;
using System.Linq;

using System.Windows.Forms;

namespace QLBenhVienDaLieu.GiaoDien.BenhNhanTrangUI.LichKhamUI.DatLichKhamUI
{
    public partial class DatLichKhamThanhToan : Form
    {
        SqlFunctionCaller sqlFunctionCaller;

        DatLichKham datLichKham;

        Rectangle originalForm;
        Rectangle originalImageCheck;
        Rectangle originalBtnThanhToan;
        Rectangle originalTitleDatLich;
        Rectangle originalTextThanhToan;
        Rectangle originalDataThanhToan;
        Rectangle originalTextErrorThanhToan;

        float textSizeInitialBtnAccount;
        float textSizeInitialBtnThanhToan;
        float textSizeInitialTitleDatLich;
        float textSizeInitialTextThanhToan;
        float textSizeInitialDataThanhToan;
        float textSizeInitialTextErrorThanhToan;

        public DatLichKhamThanhToan(SqlFunctionCaller sqlFunctionCaller, DatLichKham datLichKham)
        {
            this.sqlFunctionCaller = sqlFunctionCaller;
            this.datLichKham = datLichKham;

            InitializeComponent();

            originalForm = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
            originalImageCheck = new Rectangle(imageCheck.Location.X, imageCheck.Location.Y, imageCheck.Width, imageCheck.Height);
            originalBtnThanhToan = new Rectangle(btnThanhToan.Location.X, btnThanhToan.Location.Y, btnThanhToan.Width, btnThanhToan.Height);
            originalTitleDatLich = new Rectangle(titleDatLich.Location.X, titleDatLich.Location.Y, titleDatLich.Width, titleDatLich.Height);
            originalTextThanhToan = new Rectangle(textThanhToan.Location.X, textThanhToan.Location.Y, textThanhToan.Width, textThanhToan.Height);
            originalDataThanhToan = new Rectangle(dataThanhToan.Location.X, dataThanhToan.Location.Y, dataThanhToan.Width, dataThanhToan.Height);
            originalTextErrorThanhToan = new Rectangle(textErrorThanhToan.Location.X, textErrorThanhToan.Location.Y, textErrorThanhToan.Width, textErrorThanhToan.Height);

            btnThanhToan.Region = Draw.RoundedRectangle(0, 0, btnThanhToan.Width, btnThanhToan.Height, 50, 50);

            textSizeInitialBtnThanhToan = btnThanhToan.Font.Size;
            textSizeInitialTitleDatLich = titleDatLich.Font.Size;
            textSizeInitialTextThanhToan = textThanhToan.Font.Size;
            textSizeInitialDataThanhToan = dataThanhToan.Font.Size;
            textSizeInitialTextErrorThanhToan = textErrorThanhToan.Font.Size;

            dataThanhToan.Items.Add("Tiền mặt");
            dataThanhToan.Items.Add("Thẻ tín dụng");

        }


        private void dataThanhToan_TextChanged(object sender, EventArgs e)
        {
            textErrorThanhToan.Visible = false;
            imageCheck.Image = Image.FromFile("../../Image/check/true.jpg");
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dataThanhToan.SelectedItem == null)
            {
                textErrorThanhToan.Visible = true;
                imageCheck.Image = Image.FromFile("../../Image/check/error.jpg");
            }
            else
            {
                textErrorThanhToan.Visible = false;
                imageCheck.Image = Image.FromFile("../../Image/check/true.jpg");



                DataHoSoBenhNhan hoSoBenhNhanChoosed = this.datLichKham.HoSoBenhNhanChoosed;

                string maLichKham = sqlFunctionCaller.GetLichKhamByMaHoSoBenhNhan(hoSoBenhNhanChoosed.DataMaHoSoBenhNhan.Text).Last().MaLichKham;
                string maChuyenKhoa = sqlFunctionCaller.GetLichKhamByMaLichKham(maLichKham).MaChuyenKhoa;
                string maKhuyenMai = sqlFunctionCaller.GetChuyenKhoaByMaChuyenKhoa(maChuyenKhoa).MaKhuyenMai;
                string maHoSoBenhNhan = hoSoBenhNhanChoosed.DataMaHoSoBenhNhan.Text;
                double tyLeGiam = 0.0;

                if (!sqlFunctionCaller.GetKhuyenMaiByMaKhuyenMai(maKhuyenMai).GiaKhuyenMai.Equals(""))
                {
                    tyLeGiam = double.Parse(sqlFunctionCaller.GetKhuyenMaiByMaKhuyenMai(maKhuyenMai).GiaKhuyenMai.Split('%')[0]) / 100.0;
                }

                int tongTien = sqlFunctionCaller.GetDichVuByTenDichVu(this.datLichKham.DataDichVu.SelectedItem.ToString()).GiaDichVu;
                int thanhTien = (int)Math.Round(tongTien * (tyLeGiam == 0 ? 1 : tyLeGiam));

                sqlFunctionCaller.InsertHoaDon(maLichKham, thanhTien, dataThanhToan.SelectedItem.ToString());
                MessageBox.Show("Thanh toán thành công");
            }
        }

        private void DatLichKhamThanhToan_Resize(object sender, EventArgs e)
        {
           if (originalForm.Width != 0 && titleDatLich.Font.Size != 0)
            {
                ScaleSize.Resize(originalForm, originalImageCheck, imageCheck, this);
                ScaleSize.Resize(originalForm, originalBtnThanhToan, btnThanhToan, this, textSizeInitialBtnThanhToan);
                ScaleSize.Resize(originalForm, originalTitleDatLich, titleDatLich, this, textSizeInitialTitleDatLich);
                ScaleSize.Resize(originalForm, originalTextThanhToan, textThanhToan, this, textSizeInitialTextThanhToan);
                ScaleSize.Resize(originalForm, originalDataThanhToan, dataThanhToan, this, textSizeInitialDataThanhToan);
                ScaleSize.Resize(originalForm, originalTextErrorThanhToan, textErrorThanhToan, this, textSizeInitialTextErrorThanhToan);

                btnThanhToan.Region = Draw.RoundedRectangle(0, 0, btnThanhToan.Width, btnThanhToan.Height, 50, 50);
            }
        }
    }
}
