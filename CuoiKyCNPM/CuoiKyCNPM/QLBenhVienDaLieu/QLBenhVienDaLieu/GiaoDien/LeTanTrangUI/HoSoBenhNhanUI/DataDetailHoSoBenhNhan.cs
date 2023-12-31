﻿using Guna.UI2.WinForms;
using QLBenhVienDaLieu.Database.Check;
using QLBenhVienDaLieu.Database.Class;
using QLBenhVienDaLieu.Database.Function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBenhVienDaLieu.GiaoDien.LeTanTrangUI.HoSoBenhNhanUI
{
    public partial class DataDetailHoSoBenhNhan : Form
    {
        private SqlFunctionCaller sqlFunctionCaller;
        private string maHoSoBenhNhan;
        private Panel panel;

        HoSoBenhNhan hoSoBenhNhan;

        private Rectangle originalForm;
        private Rectangle originalTitleSuaHoSoBenhNhan;
        private Rectangle originalTextMaHoSoBenhNhan;
        private Rectangle originalTextHoVaTen;
        private Rectangle originalTextSoDienThoai;
        private Rectangle originalTextSoCCCD;
        private Rectangle originalTextMaBHYT;
        private Rectangle originalTextNgheNghiep;
        private Rectangle originalTextNgaySinh;
        private Rectangle originalTextGioiTinh;
        private Rectangle originalTextEmail;
        private Rectangle originalTextDiaChi;
        private Rectangle originalDataMaHoSoBenhNhan;
        private Rectangle originalDataHoVaTen;
        private Rectangle originalDataSoDienThoai;
        private Rectangle originalDataSoCCCD;
        private Rectangle originalDataMaBHYT;
        private Rectangle originalDataNgheNghiep;
        private Rectangle originalDataNgaySinh;
        private Rectangle originalDataGioiTinh;
        private Rectangle originalDataEmail;
        private Rectangle originalDataDiaChi;
        private Rectangle originalButtonReturn;
        private Rectangle originalButtonLuuHoSo;
        private Rectangle originalTextDotMaHoSoBenhNhan;
        private Rectangle originalTextDotHoVaTen;
        private Rectangle originalTextDotSoDienThoai;
        private Rectangle originalTextDotSoCCCD;
        private Rectangle originalTextDotNgaySinh;
        private Rectangle originalTextDotGioiTinh;
        private Rectangle originalTextErrorHoVaTen;
        private Rectangle originalTextErrorSoDienThoai;
        private Rectangle originalTextErrorSoCCCD;
        private Rectangle originalTextErrorNgaySinh;
        private Rectangle originalTextErrorGioiTinh;
        private Rectangle originalTextErrorMaBHYT;
        private Rectangle originalTextErrorNgheNghiep;
        private Rectangle originalTextErrorEmail;
        private Rectangle originalTextErrorDiaChi;
        private Rectangle originalImageCheckHoVaTen;
        private Rectangle originalImageCheckSoDienThoai;
        private Rectangle originalImageCheckSoCCCD;
        private Rectangle originalImageCheckNgaySinh;
        private Rectangle originalImageCheckGioiTinh;
        private Rectangle originalImageCheckMaBHYT;
        private Rectangle originalImageCheckNgheNghiep;
        private Rectangle originalImageCheckEmail;
        private Rectangle originalImageCheckDiaChi;

        private float textSizeInitialTitleSuaHoSoBenhNhan;
        private float textSizeInitialTextMaHoSoBenhNhan;
        private float textSizeInitialTextHoVaTen;
        private float textSizeInitialTextSoDienThoai;
        private float textSizeInitialTextSoCCCD;
        private float textSizeInitialTextMaBHYT;
        private float textSizeInitialTextNgheNghiep;
        private float textSizeInitialTextNgaySinh;
        private float textSizeInitialTextGioiTinh;
        private float textSizeInitialTextEmail;
        private float textSizeInitialTextDiaChi;
        private float textSizeInitialDataMaHoSoBenhNhan;
        private float textSizeInitialDataHoVaTen;
        private float textSizeInitialDataSoDienThoai;
        private float textSizeInitialDataSoCCCD;
        private float textSizeInitialDataMaBHYT;
        private float textSizeInitialDataNgheNghiep;
        private float textSizeInitialDataNgaySinh;
        private float textSizeInitialDataGioiTinh;
        private float textSizeInitialDataEmail;
        private float textSizeInitialDataDiaChi;
        private float textSizeInitalButtonLuuHoSo;
        private float textSizeInitialTextErrorHoVaTen;
        private float textSizeInitialTextErrorSoDienThoai;
        private float textSizeInitialTextErrorSoCCCD;
        private float textSizeInitialTextErrorNgaySinh;
        private float textSizeInitialTextErrorGioiTinh;
        private float textSizeInitialTextErrorMaBHYT;
        private float textSizeInitialTextErrorNgheNghiep;
        private float textSizeInitialTextErrorEmail;
        private float textSizeInitialTextErrorDiaChi;
        private float textSizeInitialTextDotMaHoSoBenhNhan;
        private float textSizeInitialTextDotHoVaTen;
        private float textSizeInitialTextDotSoDienThoai;
        private float textSizeInitialTextDotSoCCCD;
        private float textSizeInitialTextDotNgaySinh;
        private float textSizeInitialTextDotGioiTinh;

        public DataDetailHoSoBenhNhan(string maHoSoBenhNhan, Panel panel, SqlFunctionCaller sqlFunctionCaller)
        {
            this.sqlFunctionCaller = sqlFunctionCaller;
            this.maHoSoBenhNhan = maHoSoBenhNhan;
            this.panel = panel;

            InitializeComponent();

            originalForm = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
            originalTitleSuaHoSoBenhNhan = new Rectangle(titleSuaHoSoBenhNhan.Location.X, titleSuaHoSoBenhNhan.Location.Y, titleSuaHoSoBenhNhan.Width, titleSuaHoSoBenhNhan.Height);
            originalTextMaHoSoBenhNhan = new Rectangle(textMaHoSoBenhNhan.Location.X, textMaHoSoBenhNhan.Location.Y, textMaHoSoBenhNhan.Width, textMaHoSoBenhNhan.Height);
            originalTextHoVaTen = new Rectangle(textHoVaTen.Location.X, textHoVaTen.Location.Y, textHoVaTen.Width, textHoVaTen.Height);
            originalTextSoDienThoai = new Rectangle(textSoDienThoai.Location.X, textSoDienThoai.Location.Y, textSoDienThoai.Width, textSoDienThoai.Height);
            originalTextSoCCCD = new Rectangle(textSoCCCD.Location.X, textSoCCCD.Location.Y, textSoCCCD.Width, textSoCCCD.Height);
            originalTextMaBHYT = new Rectangle(textMaBHYT.Location.X, textMaBHYT.Location.Y, textMaBHYT.Width, textMaBHYT.Height);
            originalTextNgheNghiep = new Rectangle(textNgheNghiep.Location.X, textNgheNghiep.Location.Y, textNgheNghiep.Width, textNgheNghiep.Height);
            originalTextNgaySinh = new Rectangle(textNgaySinh.Location.X, textNgaySinh.Location.Y, textNgaySinh.Width, textNgaySinh.Height);
            originalTextGioiTinh = new Rectangle(textGioiTinh.Location.X, textGioiTinh.Location.Y, textGioiTinh.Width, textGioiTinh.Height);
            originalTextEmail = new Rectangle(textEmail.Location.X, textEmail.Location.Y, textEmail.Width, textEmail.Height);
            originalTextDiaChi = new Rectangle(textDiaChi.Location.X, textDiaChi.Location.Y, textDiaChi.Width, textDiaChi.Height);
            originalDataMaHoSoBenhNhan = new Rectangle(dataMaHoSoBenhNhan.Location.X, dataMaHoSoBenhNhan.Location.Y, dataMaHoSoBenhNhan.Width, dataMaHoSoBenhNhan.Height);
            originalDataHoVaTen = new Rectangle(dataHoVaTen.Location.X, dataHoVaTen.Location.Y, dataHoVaTen.Width, dataHoVaTen.Height);
            originalDataSoDienThoai = new Rectangle(dataSoDienThoai.Location.X, dataSoDienThoai.Location.Y, dataSoDienThoai.Width, dataSoDienThoai.Height);
            originalDataSoCCCD = new Rectangle(dataSoCCCD.Location.X, dataSoCCCD.Location.Y, dataSoCCCD.Width, dataSoCCCD.Height);
            originalDataMaBHYT = new Rectangle(dataMaBHYT.Location.X, dataMaBHYT.Location.Y, dataMaBHYT.Width, dataMaBHYT.Height);
            originalDataNgheNghiep = new Rectangle(dataNgheNghiep.Location.X, dataNgheNghiep.Location.Y, dataNgheNghiep.Width, dataNgheNghiep.Height);
            originalDataNgaySinh = new Rectangle(dataNgaySinh.Location.X, dataNgaySinh.Location.Y, dataNgaySinh.Width, dataNgaySinh.Height);
            originalDataGioiTinh = new Rectangle(dataGioiTinh.Location.X, dataGioiTinh.Location.Y, dataGioiTinh.Width, dataGioiTinh.Height);
            originalDataEmail = new Rectangle(dataEmail.Location.X, dataEmail.Location.Y, dataEmail.Width, dataEmail.Height);
            originalDataDiaChi = new Rectangle(dataDiaChi.Location.X, dataDiaChi.Location.Y, dataDiaChi.Width, dataDiaChi.Height);
            originalButtonReturn = new Rectangle(buttonReturn.Location.X, buttonReturn.Location.Y, buttonReturn.Width, buttonReturn.Height);
            originalButtonLuuHoSo = new Rectangle(buttonLuuHoSo.Location.X, buttonLuuHoSo.Location.Y, buttonLuuHoSo.Width, buttonLuuHoSo.Height);
            originalTextDotMaHoSoBenhNhan = new Rectangle(textDotMaHoSoBenhNhan.Location.X, textDotMaHoSoBenhNhan.Location.Y, textDotMaHoSoBenhNhan.Width, textDotMaHoSoBenhNhan.Height);
            originalTextDotHoVaTen = new Rectangle(textDotHoVaTen.Location.X, textDotHoVaTen.Location.Y, textDotHoVaTen.Width, textDotHoVaTen.Height);
            originalTextDotSoDienThoai = new Rectangle(textDotSoDienThoai.Location.X, textDotSoDienThoai.Location.Y, textDotSoDienThoai.Width, textDotSoDienThoai.Height);
            originalTextDotSoCCCD = new Rectangle(textDotSoCCCD.Location.X, textDotSoCCCD.Location.Y, textDotSoCCCD.Width, textDotSoCCCD.Height);
            originalTextDotNgaySinh = new Rectangle(textDotNgaySinh.Location.X, textDotNgaySinh.Location.Y, textDotNgaySinh.Width, textDotNgaySinh.Height);
            originalTextDotGioiTinh = new Rectangle(textDotGioiTinh.Location.X, textDotGioiTinh.Location.Y, textDotGioiTinh.Width, textDotGioiTinh.Height);
            originalTextErrorHoVaTen = new Rectangle(textErrorHoVaTen.Location.X, textErrorHoVaTen.Location.Y, textErrorHoVaTen.Width, textErrorHoVaTen.Height);
            originalTextErrorSoDienThoai = new Rectangle(textErrorSoDienThoai.Location.X, textErrorSoDienThoai.Location.Y, textErrorSoDienThoai.Width, textErrorSoDienThoai.Height);
            originalTextErrorSoCCCD = new Rectangle(textErrorSoCCCD.Location.X, textErrorSoCCCD.Location.Y, textErrorSoCCCD.Width, textErrorSoCCCD.Height);
            originalTextErrorNgaySinh = new Rectangle(textErrorNgaySinh.Location.X, textErrorNgaySinh.Location.Y, textErrorNgaySinh.Width, textErrorNgaySinh.Height);
            originalTextErrorGioiTinh = new Rectangle(textErrorGioiTinh.Location.X, textErrorGioiTinh.Location.Y, textErrorGioiTinh.Width, textErrorGioiTinh.Height);
            originalTextErrorMaBHYT = new Rectangle(textErrorMaBHYT.Location.X, textErrorMaBHYT.Location.Y, textErrorMaBHYT.Width, textErrorMaBHYT.Height);
            originalTextErrorNgheNghiep = new Rectangle(textErrorNgheNghiep.Location.X, textErrorNgheNghiep.Location.Y, textErrorNgheNghiep.Width, textErrorNgheNghiep.Height);
            originalTextErrorEmail = new Rectangle(textErrorEmail.Location.X, textErrorEmail.Location.Y, textErrorEmail.Width, textErrorEmail.Height);
            originalTextErrorDiaChi = new Rectangle(textErrorDiaChi.Location.X, textErrorDiaChi.Location.Y, textErrorDiaChi.Width, textErrorDiaChi.Height);
            originalImageCheckHoVaTen = new Rectangle(imageCheckHoVaTen.Location.X, imageCheckHoVaTen.Location.Y, imageCheckHoVaTen.Width, imageCheckHoVaTen.Height);
            originalImageCheckSoDienThoai = new Rectangle(imageCheckSoDienThoai.Location.X, imageCheckSoDienThoai.Location.Y, imageCheckSoDienThoai.Width, imageCheckSoDienThoai.Height);
            originalImageCheckSoCCCD = new Rectangle(imageCheckSoCCCD.Location.X, imageCheckSoCCCD.Location.Y, imageCheckSoCCCD.Width, imageCheckSoCCCD.Height);
            originalImageCheckNgaySinh = new Rectangle(imageCheckNgaySinh.Location.X, imageCheckNgaySinh.Location.Y, imageCheckNgaySinh.Width, imageCheckNgaySinh.Height);
            originalImageCheckGioiTinh = new Rectangle(imageCheckGioiTinh.Location.X, imageCheckGioiTinh.Location.Y, imageCheckGioiTinh.Width, imageCheckGioiTinh.Height);

            textSizeInitialTitleSuaHoSoBenhNhan = titleSuaHoSoBenhNhan.Font.Size;
            textSizeInitialTextMaHoSoBenhNhan = textMaHoSoBenhNhan.Font.Size;
            textSizeInitialTextDotMaHoSoBenhNhan = textMaHoSoBenhNhan.Font.Size;
            textSizeInitialTextHoVaTen = textHoVaTen.Font.Size;
            textSizeInitialTextSoDienThoai = textSoDienThoai.Font.Size;
            textSizeInitialTextSoCCCD = textSoCCCD.Font.Size;
            textSizeInitialTextMaBHYT = textMaBHYT.Font.Size;
            textSizeInitialTextNgheNghiep = textNgheNghiep.Font.Size;
            textSizeInitialTextNgaySinh = textNgaySinh.Font.Size;
            textSizeInitialTextGioiTinh = textGioiTinh.Font.Size;
            textSizeInitialTextEmail = textEmail.Font.Size;
            textSizeInitialTextDiaChi = textDiaChi.Font.Size;
            textSizeInitialDataMaHoSoBenhNhan = dataMaHoSoBenhNhan.Font.Size;
            textSizeInitialDataHoVaTen = dataHoVaTen.Font.Size;
            textSizeInitialDataSoDienThoai = dataSoDienThoai.Font.Size;
            textSizeInitialDataSoCCCD = dataSoCCCD.Font.Size;
            textSizeInitialDataMaBHYT = dataMaBHYT.Font.Size;
            textSizeInitialDataNgheNghiep = dataNgheNghiep.Font.Size;
            textSizeInitialDataNgaySinh = dataNgaySinh.Font.Size;
            textSizeInitialDataGioiTinh = dataGioiTinh.Font.Size;
            textSizeInitialDataEmail = dataEmail.Font.Size;
            textSizeInitialDataDiaChi = dataDiaChi.Font.Size;
            textSizeInitalButtonLuuHoSo = buttonLuuHoSo.Font.Size;
            textSizeInitialTextErrorHoVaTen = textErrorHoVaTen.Font.Size;
            textSizeInitialTextErrorSoDienThoai = textErrorSoDienThoai.Font.Size;
            textSizeInitialTextErrorSoCCCD = textErrorSoCCCD.Font.Size;
            textSizeInitialTextErrorNgaySinh = textErrorNgaySinh.Font.Size;
            textSizeInitialTextErrorGioiTinh = textErrorGioiTinh.Font.Size;
            textSizeInitialTextErrorMaBHYT = textErrorMaBHYT.Font.Size;
            textSizeInitialTextErrorNgheNghiep = textErrorNgheNghiep.Font.Size;
            textSizeInitialTextErrorEmail = textErrorEmail.Font.Size;
            textSizeInitialTextErrorDiaChi = textErrorDiaChi.Font.Size;
            textSizeInitialTextDotMaHoSoBenhNhan = textDotMaHoSoBenhNhan.Font.Size;
            textSizeInitialTextDotHoVaTen = textDotHoVaTen.Font.Size;
            textSizeInitialTextDotSoDienThoai = textDotSoDienThoai.Font.Size;
            textSizeInitialTextDotSoCCCD = textDotSoCCCD.Font.Size;
            textSizeInitialTextDotNgaySinh = textDotNgaySinh.Font.Size;
            textSizeInitialTextDotGioiTinh = textDotGioiTinh.Font.Size;

            buttonLuuHoSo.Region = Graphic.Draw.RoundedRectangle(0, 0, buttonLuuHoSo.Width, buttonLuuHoSo.Height, 30, 30);

            this.hoSoBenhNhan =  sqlFunctionCaller.GetHoSoBenhNhanByMaHoSoBenhNhan(this.maHoSoBenhNhan);

            dataMaHoSoBenhNhan.Text = hoSoBenhNhan.MaHoSoBenhNhan;
            dataHoVaTen.Text = hoSoBenhNhan.HoVaTen;
            dataSoDienThoai.Text = hoSoBenhNhan.SoDienThoai;
            dataSoCCCD.Text = hoSoBenhNhan.CCCD;
            dataMaBHYT.Text = hoSoBenhNhan.MaBHYT;
            dataNgheNghiep.Text = hoSoBenhNhan.NgheNghiep;
            dataNgaySinh.Text = hoSoBenhNhan.NgaySinh.ToShortDateString();
            dataGioiTinh.Text = hoSoBenhNhan.GioiTinh;
            dataEmail.Text = hoSoBenhNhan.Email;
            dataDiaChi.Text = hoSoBenhNhan.DiaChi;
            
        }

        private void DataDetailHoSoBenhNhan_Resize(object sender, EventArgs e)
        {
            if (originalForm.Width != 0 && textDiaChi.Font.Size != 0)
            {
                Graphic.ScaleSize.Resize(originalForm, originalTitleSuaHoSoBenhNhan, titleSuaHoSoBenhNhan, this, textSizeInitialTitleSuaHoSoBenhNhan);
                Graphic.ScaleSize.Resize(originalForm, originalTextMaHoSoBenhNhan, textMaHoSoBenhNhan, this, textSizeInitialTextMaHoSoBenhNhan);
                Graphic.ScaleSize.Resize(originalForm, originalTextHoVaTen, textHoVaTen, this, textSizeInitialTextHoVaTen);
                Graphic.ScaleSize.Resize(originalForm, originalTextSoDienThoai, textSoDienThoai, this, textSizeInitialTextSoDienThoai);
                Graphic.ScaleSize.Resize(originalForm, originalTextSoCCCD, textSoCCCD, this, textSizeInitialTextSoCCCD);
                Graphic.ScaleSize.Resize(originalForm, originalTextMaBHYT, textMaBHYT, this, textSizeInitialTextMaBHYT);
                Graphic.ScaleSize.Resize(originalForm, originalTextNgheNghiep, textNgheNghiep, this, textSizeInitialTextNgheNghiep);
                Graphic.ScaleSize.Resize(originalForm, originalTextNgaySinh, textNgaySinh, this, textSizeInitialTextNgaySinh);
                Graphic.ScaleSize.Resize(originalForm, originalTextGioiTinh, textGioiTinh, this, textSizeInitialTextGioiTinh);
                Graphic.ScaleSize.Resize(originalForm, originalTextEmail, textEmail, this, textSizeInitialTextEmail);
                Graphic.ScaleSize.Resize(originalForm, originalTextDiaChi, textDiaChi, this, textSizeInitialTextDiaChi);
                Graphic.ScaleSize.Resize(originalForm, originalDataMaHoSoBenhNhan, dataMaHoSoBenhNhan, this, textSizeInitialDataMaHoSoBenhNhan);
                Graphic.ScaleSize.Resize(originalForm, originalDataHoVaTen, dataHoVaTen, this, textSizeInitialDataHoVaTen);
                Graphic.ScaleSize.Resize(originalForm, originalDataSoDienThoai, dataSoDienThoai, this, textSizeInitialDataSoDienThoai);
                Graphic.ScaleSize.Resize(originalForm, originalDataSoCCCD, dataSoCCCD, this, textSizeInitialDataSoCCCD);
                Graphic.ScaleSize.Resize(originalForm, originalDataMaBHYT, dataMaBHYT, this, textSizeInitialDataMaBHYT);
                Graphic.ScaleSize.Resize(originalForm, originalDataNgheNghiep, dataNgheNghiep, this, textSizeInitialDataNgheNghiep);
                Graphic.ScaleSize.Resize(originalForm, originalDataNgaySinh, dataNgaySinh, this, textSizeInitialDataNgaySinh);
                Graphic.ScaleSize.Resize(originalForm, originalDataGioiTinh, dataGioiTinh, this, textSizeInitialDataGioiTinh);
                Graphic.ScaleSize.Resize(originalForm, originalDataEmail, dataEmail, this, textSizeInitialDataEmail);
                Graphic.ScaleSize.Resize(originalForm, originalDataDiaChi, dataDiaChi, this, textSizeInitialDataDiaChi);
                Graphic.ScaleSize.Resize(originalForm, originalButtonReturn, buttonReturn, this);
                Graphic.ScaleSize.Resize(originalForm, originalButtonLuuHoSo, buttonLuuHoSo, this, textSizeInitalButtonLuuHoSo);
                Graphic.ScaleSize.Resize(originalForm, originalTextDotMaHoSoBenhNhan, textDotMaHoSoBenhNhan, this, textSizeInitialTextDotMaHoSoBenhNhan);
                Graphic.ScaleSize.Resize(originalForm, originalTextDotHoVaTen, textDotHoVaTen, this, textSizeInitialTextDotHoVaTen);
                Graphic.ScaleSize.Resize(originalForm, originalTextDotSoDienThoai, textDotSoDienThoai, this, textSizeInitialTextDotSoDienThoai);
                Graphic.ScaleSize.Resize(originalForm, originalTextDotSoCCCD, textDotSoCCCD, this, textSizeInitialTextDotSoCCCD);
                Graphic.ScaleSize.Resize(originalForm, originalTextDotNgaySinh, textDotNgaySinh, this, textSizeInitialTextDotNgaySinh);
                Graphic.ScaleSize.Resize(originalForm, originalTextDotGioiTinh, textDotGioiTinh, this, textSizeInitialTextDotGioiTinh);
                Graphic.ScaleSize.Resize(originalForm, originalTextErrorHoVaTen, textErrorHoVaTen, this, textSizeInitialTextErrorHoVaTen);
                Graphic.ScaleSize.Resize(originalForm, originalTextErrorSoDienThoai, textErrorSoDienThoai, this, textSizeInitialTextErrorSoDienThoai);
                Graphic.ScaleSize.Resize(originalForm, originalTextErrorSoCCCD, textErrorSoCCCD, this, textSizeInitialTextErrorSoCCCD);
                Graphic.ScaleSize.Resize(originalForm, originalTextErrorNgaySinh, textErrorNgaySinh, this, textSizeInitialTextErrorNgaySinh);
                Graphic.ScaleSize.Resize(originalForm, originalTextErrorGioiTinh, textErrorGioiTinh, this, textSizeInitialTextErrorGioiTinh);
                Graphic.ScaleSize.Resize(originalForm, originalTextErrorMaBHYT, textErrorMaBHYT, this, textSizeInitialTextErrorMaBHYT);
                Graphic.ScaleSize.Resize(originalForm, originalTextErrorNgheNghiep, textErrorNgheNghiep, this, textSizeInitialTextErrorNgheNghiep);
                Graphic.ScaleSize.Resize(originalForm, originalTextErrorEmail, textErrorEmail, this, textSizeInitialTextErrorEmail);
                Graphic.ScaleSize.Resize(originalForm, originalTextErrorDiaChi, textErrorDiaChi, this, textSizeInitialTextErrorDiaChi);
                Graphic.ScaleSize.Resize(originalForm, originalImageCheckHoVaTen, imageCheckHoVaTen, this);
                Graphic.ScaleSize.Resize(originalForm, originalImageCheckSoDienThoai, imageCheckSoDienThoai, this);
                Graphic.ScaleSize.Resize(originalForm, originalImageCheckSoCCCD, imageCheckSoCCCD, this);
                Graphic.ScaleSize.Resize(originalForm, originalImageCheckNgaySinh, imageCheckNgaySinh, this);
                Graphic.ScaleSize.Resize(originalForm, originalImageCheckGioiTinh, imageCheckGioiTinh, this);
                Graphic.ScaleSize.Resize(originalForm, originalImageCheckMaBHYT, imageCheckMaBHYT, this);
                Graphic.ScaleSize.Resize(originalForm, originalImageCheckNgheNghiep, imageCheckNgheNghiep, this);
                Graphic.ScaleSize.Resize(originalForm, originalImageCheckEmail, imageCheckEmail, this);
                Graphic.ScaleSize.Resize(originalForm, originalImageCheckDiaChi, imageCheckDiaChi, this);

                buttonLuuHoSo.Region = Graphic.Draw.RoundedRectangle(0, 0, buttonLuuHoSo.Width, buttonLuuHoSo.Height, 30, 30);
            }
        }

        private void dataHoVaTen_TextChanged(object sender, EventArgs e)
        {
            if (!dataHoVaTen.Text.Equals(""))
            {
                textErrorHoVaTen.Visible = false;
                imageCheckHoVaTen.BackgroundImage = Image.FromFile("../../Image/check/true.jpg");
            }
            else
            {
                textErrorHoVaTen.Visible = true;
                imageCheckHoVaTen.BackgroundImage = Image.FromFile("../../Image/check/error.jpg");
            }
        }

        private void dataSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (Available.CheckSoDienThoai(dataSoDienThoai.Text))
            {
                textErrorSoDienThoai.Visible = false;
                imageCheckSoDienThoai.BackgroundImage = Image.FromFile("../../Image/check/true.jpg");
            }
            else
            {
                textErrorSoDienThoai.Visible = true;
                imageCheckSoDienThoai.BackgroundImage = Image.FromFile("../../Image/check/error.jpg");
            }
        }

        private void dataSoCCCD_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Available.CheckCCCD(dataSoCCCD.Text, DateTime.ParseExact(dataNgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture), dataGioiTinh.Text))
                {
                    textErrorSoCCCD.Visible = false;
                    imageCheckSoCCCD.BackgroundImage = Image.FromFile("../../Image/check/true.jpg");
                }
                else
                {
                    textErrorSoCCCD.Visible = true;
                    imageCheckSoCCCD.BackgroundImage = Image.FromFile("../../Image/check/error.jpg");
                }
            } catch(FormatException)
            {
                textErrorSoCCCD.Visible = true;
                imageCheckSoCCCD.BackgroundImage = Image.FromFile("../../Image/check/error.jpg");
            }
        }

        private void dataMaBHYT_TextChanged(object sender, EventArgs e)
        {
            if (Available.CheckMaBHYT(dataMaBHYT.Text) || dataMaBHYT.Text.Equals(""))
            {
                textErrorMaBHYT.Visible = false;
                imageCheckMaBHYT.BackgroundImage = Image.FromFile("../../Image/check/true.jpg");
            }
            else
            {
                textErrorMaBHYT.Visible = true;
                imageCheckMaBHYT.BackgroundImage = Image.FromFile("../../Image/check/error.jpg");
            }

        }

        private void dataNgheNghiep_TextChanged(object sender, EventArgs e)
        {
            if (Available.CheckNgheNghiep(dataNgheNghiep.Text) || dataNgheNghiep.Text.Equals(""))
            {
                textErrorNgheNghiep.Visible = false;
                imageCheckNgheNghiep.BackgroundImage = Image.FromFile("../../Image/check/true.jpg");
            }
            else
            {
                textErrorNgheNghiep.Visible = true;
                imageCheckNgheNghiep.BackgroundImage = Image.FromFile("../../Image/check/error.jpg");
            }
        }

        private void dataNgaySinh_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime ngaySinh = DateTime.ParseExact(dataNgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                if (Available.CheckNgaySinh(ngaySinh))
                {
                    textErrorNgaySinh.Visible = false;
                    imageCheckNgaySinh.BackgroundImage = Image.FromFile("../../Image/check/true.jpg");

                    dataSoCCCD_TextChanged(null, null);
                }
                else
                {
                    textErrorNgaySinh.Visible = true;
                    imageCheckNgaySinh.BackgroundImage = Image.FromFile("../../Image/check/error.jpg");
                }
            }
            catch (FormatException)
            {
                textErrorNgaySinh.Visible = true;
                imageCheckNgaySinh.BackgroundImage = Image.FromFile("../../Image/check/error.jpg");
            }
        }

        private void dataGioiTinh_TextChanged(object sender, EventArgs e)
        {
            if (Available.CheckGioiTinh(dataGioiTinh.Text))
            {
                textErrorGioiTinh.Visible = false;
                imageCheckGioiTinh.BackgroundImage = Image.FromFile("../../Image/check/true.jpg");

                dataSoCCCD_TextChanged(null, null);
            }
            else
            {
                textErrorGioiTinh.Visible = true;
                imageCheckGioiTinh.BackgroundImage = Image.FromFile("../../Image/check/error.jpg");
            }
        }

        private void dataEmail_TextChanged(object sender, EventArgs e)
        {
            if (Available.CheckEmail(dataEmail.Text) || dataEmail.Text.Equals(""))
            {
                textErrorEmail.Visible = false;
                imageCheckEmail.BackgroundImage = Image.FromFile("../../Image/check/true.jpg");
            }
            else
            {
                textErrorEmail.Visible = true;
                imageCheckEmail.BackgroundImage = Image.FromFile("../../Image/check/error.jpg");
            }
        }

        private void dataDiaChi_TextChanged(object sender, EventArgs e)
        {
            imageCheckDiaChi.BackgroundImage = Image.FromFile("../../Image/check/true.jpg");
        }

        private void buttonLuuHoSo_Click(object sender, EventArgs e)
        {
            if (!dataHoVaTen.Text.Equals(""))
            {
                textErrorHoVaTen.Visible = false;
                imageCheckHoVaTen.BackgroundImage = Image.FromFile("../../Image/check/true.jpg");
            }
            else
            {
                textErrorHoVaTen.Visible = true;
                imageCheckHoVaTen.BackgroundImage = Image.FromFile("../../Image/check/error.jpg");
            }

            if (Available.CheckSoDienThoai(dataSoDienThoai.Text))
            {
                textErrorSoDienThoai.Visible = false;
                imageCheckSoDienThoai.BackgroundImage = Image.FromFile("../../Image/check/true.jpg");
            }
            else
            {
                textErrorSoDienThoai.Visible = true;
                imageCheckSoDienThoai.BackgroundImage = Image.FromFile("../../Image/check/error.jpg");
            }

            try
            {
                if (Available.CheckCCCD(dataSoCCCD.Text, DateTime.ParseExact(dataNgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture), dataGioiTinh.Text))
                {
                    textErrorSoCCCD.Visible = false;
                    imageCheckSoCCCD.BackgroundImage = Image.FromFile("../../Image/check/true.jpg");
                }
                else
                {
                    textErrorSoCCCD.Visible = true;
                    imageCheckSoCCCD.BackgroundImage = Image.FromFile("../../Image/check/error.jpg");
                }
            }
            catch (FormatException)
            {
                textErrorSoCCCD.Visible = true;
                imageCheckSoCCCD.BackgroundImage = Image.FromFile("../../Image/check/error.jpg");
            }

            try
            {
                DateTime ngaySinh = DateTime.ParseExact(dataNgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                if (Available.CheckNgaySinh(ngaySinh))
                {
                    textErrorNgaySinh.Visible = false;
                    imageCheckNgaySinh.BackgroundImage = Image.FromFile("../../Image/check/true.jpg");
                }
                else
                {
                    textErrorNgaySinh.Visible = true;
                    imageCheckNgaySinh.BackgroundImage = Image.FromFile("../../Image/check/error.jpg");
                }

            }
            catch (FormatException)
            {
                textErrorNgaySinh.Visible = true;
                imageCheckNgaySinh.BackgroundImage = Image.FromFile("../../Image/check/error.jpg");
            }

            if (Available.CheckGioiTinh(dataGioiTinh.Text))
            {
                textErrorGioiTinh.Visible = false;
                imageCheckGioiTinh.BackgroundImage = Image.FromFile("../../Image/check/true.jpg");
            }
            else
            {
                textErrorGioiTinh.Visible = true;
                imageCheckGioiTinh.BackgroundImage = Image.FromFile("../../Image/check/error.jpg");
            }

            if (textErrorHoVaTen.Visible == false && textErrorSoDienThoai.Visible == false
                && textErrorSoCCCD.Visible == false && textErrorNgaySinh.Visible == false
                && textErrorGioiTinh.Visible == false
                )
            {
                sqlFunctionCaller.UpdateHoSoBenhNhan(dataMaHoSoBenhNhan.Text, dataHoVaTen.Text, this.hoSoBenhNhan.MaTaiKhoan,
                    DateTime.Parse(dataNgaySinh.Text), dataGioiTinh.Text, dataSoCCCD.Text, dataMaBHYT.Text, dataNgheNghiep.Text,
                    dataSoDienThoai.Text, dataEmail.Text, dataDiaChi.Text);

                MessageBox.Show("Đã sửa hồ sơ");
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {

           panel.Controls.Clear();

            HoSoBenhNhanForm hoSoBenhNhanForm = new HoSoBenhNhanForm(panel, sqlFunctionCaller);

            hoSoBenhNhanForm.TopLevel = false;
            hoSoBenhNhanForm.Dock = DockStyle.Fill;

            hoSoBenhNhanForm.TextBoxSearchMaTaiKhoan.Text = this.hoSoBenhNhan.MaTaiKhoan;

            hoSoBenhNhanForm.buttonSearch_Click(null, null);

           panel.Controls.Add(hoSoBenhNhanForm);
           panel.Tag = hoSoBenhNhanForm;

            hoSoBenhNhanForm.Show();
        }
    }
}
