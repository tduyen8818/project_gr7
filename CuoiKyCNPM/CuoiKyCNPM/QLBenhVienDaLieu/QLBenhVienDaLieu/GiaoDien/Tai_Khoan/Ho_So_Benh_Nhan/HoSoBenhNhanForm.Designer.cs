﻿using System.Windows.Forms;

namespace QLBenhVienDaLieu.GiaoDien.Ho_So_Benh_Nhan
{
    partial class HoSoBenhNhanForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleHoSoBenhNhan = new System.Windows.Forms.Label();
            this.textTongSoHoSo = new System.Windows.Forms.Label();
            this.dataTongSoHoSo = new System.Windows.Forms.Label();
            this.showHoSoBenhNhan = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataDiaChi = new System.Windows.Forms.TextBox();
            this.dataEmail = new System.Windows.Forms.TextBox();
            this.dataSoDienThoai = new System.Windows.Forms.TextBox();
            this.dataNgheNghiep = new System.Windows.Forms.TextBox();
            this.dataMaBHYT = new System.Windows.Forms.TextBox();
            this.dataCCCD = new System.Windows.Forms.TextBox();
            this.dataGioiTinh = new System.Windows.Forms.TextBox();
            this.dataNgaySinh = new System.Windows.Forms.TextBox();
            this.dataMaTaiKhoan = new System.Windows.Forms.TextBox();
            this.dataHoVaTen = new System.Windows.Forms.TextBox();
            this.dataMaHoSoBenhNhan = new System.Windows.Forms.TextBox();
            this.textDiaChi = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.Label();
            this.textSoDienThoai = new System.Windows.Forms.Label();
            this.textNgheNghiep = new System.Windows.Forms.Label();
            this.textMaBHYT = new System.Windows.Forms.Label();
            this.textCCCD = new System.Windows.Forms.Label();
            this.textGioiTinh = new System.Windows.Forms.Label();
            this.textNgaySinh = new System.Windows.Forms.Label();
            this.textMaTaiKhoan = new System.Windows.Forms.Label();
            this.textMaHoSoBenhNhan = new System.Windows.Forms.Label();
            this.textHoVaTen = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.imageProfile = new System.Windows.Forms.PictureBox();
            this.buttonArrowLeft = new System.Windows.Forms.Button();
            this.buttonArrowRight = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataNumberHoSoBenhNhan = new System.Windows.Forms.Label();
            this.showHoSoBenhNhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // titleHoSoBenhNhan
            // 
            this.titleHoSoBenhNhan.BackColor = System.Drawing.SystemColors.Control;
            this.titleHoSoBenhNhan.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.titleHoSoBenhNhan.ForeColor = System.Drawing.Color.SeaGreen;
            this.titleHoSoBenhNhan.Location = new System.Drawing.Point(44, 19);
            this.titleHoSoBenhNhan.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.titleHoSoBenhNhan.Name = "titleHoSoBenhNhan";
            this.titleHoSoBenhNhan.Size = new System.Drawing.Size(857, 60);
            this.titleHoSoBenhNhan.TabIndex = 2;
            this.titleHoSoBenhNhan.Text = "Hồ sơ bệnh nhân";
            this.titleHoSoBenhNhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textTongSoHoSo
            // 
            this.textTongSoHoSo.AutoSize = true;
            this.textTongSoHoSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTongSoHoSo.Location = new System.Drawing.Point(46, 93);
            this.textTongSoHoSo.Margin = new System.Windows.Forms.Padding(0);
            this.textTongSoHoSo.Name = "textTongSoHoSo";
            this.textTongSoHoSo.Size = new System.Drawing.Size(154, 26);
            this.textTongSoHoSo.TabIndex = 3;
            this.textTongSoHoSo.Text = "Tổng số hồ sơ:";
            // 
            // dataTongSoHoSo
            // 
            this.dataTongSoHoSo.AutoSize = true;
            this.dataTongSoHoSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTongSoHoSo.Location = new System.Drawing.Point(200, 93);
            this.dataTongSoHoSo.Margin = new System.Windows.Forms.Padding(0);
            this.dataTongSoHoSo.Name = "dataTongSoHoSo";
            this.dataTongSoHoSo.Size = new System.Drawing.Size(38, 26);
            this.dataTongSoHoSo.TabIndex = 4;
            this.dataTongSoHoSo.Text = "10";
            // 
            // showHoSoBenhNhan
            // 
            this.showHoSoBenhNhan.BackColor = System.Drawing.Color.White;
            this.showHoSoBenhNhan.Controls.Add(this.buttonSave);
            this.showHoSoBenhNhan.Controls.Add(this.dataDiaChi);
            this.showHoSoBenhNhan.Controls.Add(this.dataEmail);
            this.showHoSoBenhNhan.Controls.Add(this.dataSoDienThoai);
            this.showHoSoBenhNhan.Controls.Add(this.dataNgheNghiep);
            this.showHoSoBenhNhan.Controls.Add(this.dataMaBHYT);
            this.showHoSoBenhNhan.Controls.Add(this.dataCCCD);
            this.showHoSoBenhNhan.Controls.Add(this.dataGioiTinh);
            this.showHoSoBenhNhan.Controls.Add(this.dataNgaySinh);
            this.showHoSoBenhNhan.Controls.Add(this.dataMaTaiKhoan);
            this.showHoSoBenhNhan.Controls.Add(this.dataHoVaTen);
            this.showHoSoBenhNhan.Controls.Add(this.dataMaHoSoBenhNhan);
            this.showHoSoBenhNhan.Controls.Add(this.textDiaChi);
            this.showHoSoBenhNhan.Controls.Add(this.textEmail);
            this.showHoSoBenhNhan.Controls.Add(this.textSoDienThoai);
            this.showHoSoBenhNhan.Controls.Add(this.textNgheNghiep);
            this.showHoSoBenhNhan.Controls.Add(this.textMaBHYT);
            this.showHoSoBenhNhan.Controls.Add(this.textCCCD);
            this.showHoSoBenhNhan.Controls.Add(this.textGioiTinh);
            this.showHoSoBenhNhan.Controls.Add(this.textNgaySinh);
            this.showHoSoBenhNhan.Controls.Add(this.textMaTaiKhoan);
            this.showHoSoBenhNhan.Controls.Add(this.textMaHoSoBenhNhan);
            this.showHoSoBenhNhan.Controls.Add(this.textHoVaTen);
            this.showHoSoBenhNhan.Controls.Add(this.buttonDelete);
            this.showHoSoBenhNhan.Controls.Add(this.buttonEdit);
            this.showHoSoBenhNhan.Controls.Add(this.imageProfile);
            this.showHoSoBenhNhan.Location = new System.Drawing.Point(276, 116);
            this.showHoSoBenhNhan.Name = "showHoSoBenhNhan";
            this.showHoSoBenhNhan.Size = new System.Drawing.Size(405, 542);
            this.showHoSoBenhNhan.TabIndex = 5;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.White;
            this.buttonSave.BackgroundImage = global::QLBenhVienDaLieu.Properties.Resources.save;
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Location = new System.Drawing.Point(166, 10);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(10);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(60, 32);
            this.buttonSave.TabIndex = 33;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataDiaChi
            // 
            this.dataDiaChi.BackColor = System.Drawing.SystemColors.Control;
            this.dataDiaChi.Enabled = false;
            this.dataDiaChi.ForeColor = System.Drawing.Color.Black;
            this.dataDiaChi.Location = new System.Drawing.Point(84, 499);
            this.dataDiaChi.Name = "dataDiaChi";
            this.dataDiaChi.Size = new System.Drawing.Size(302, 26);
            this.dataDiaChi.TabIndex = 32;
            // 
            // dataEmail
            // 
            this.dataEmail.BackColor = System.Drawing.SystemColors.Control;
            this.dataEmail.Enabled = false;
            this.dataEmail.ForeColor = System.Drawing.Color.Black;
            this.dataEmail.Location = new System.Drawing.Point(75, 458);
            this.dataEmail.Name = "dataEmail";
            this.dataEmail.Size = new System.Drawing.Size(311, 26);
            this.dataEmail.TabIndex = 31;
            this.dataEmail.TextChanged += new System.EventHandler(this.dataEmail_TextChanged);
            // 
            // dataSoDienThoai
            // 
            this.dataSoDienThoai.BackColor = System.Drawing.SystemColors.Control;
            this.dataSoDienThoai.Enabled = false;
            this.dataSoDienThoai.ForeColor = System.Drawing.Color.Black;
            this.dataSoDienThoai.Location = new System.Drawing.Point(129, 419);
            this.dataSoDienThoai.Name = "dataSoDienThoai";
            this.dataSoDienThoai.Size = new System.Drawing.Size(257, 26);
            this.dataSoDienThoai.TabIndex = 30;
            this.dataSoDienThoai.TextChanged += new System.EventHandler(this.dataSoDienThoai_TextChanged);
            // 
            // dataNgheNghiep
            // 
            this.dataNgheNghiep.BackColor = System.Drawing.SystemColors.Control;
            this.dataNgheNghiep.Enabled = false;
            this.dataNgheNghiep.ForeColor = System.Drawing.Color.Black;
            this.dataNgheNghiep.Location = new System.Drawing.Point(125, 379);
            this.dataNgheNghiep.Name = "dataNgheNghiep";
            this.dataNgheNghiep.Size = new System.Drawing.Size(260, 26);
            this.dataNgheNghiep.TabIndex = 29;
            this.dataNgheNghiep.TextChanged += new System.EventHandler(this.dataNgheNghiep_TextChanged);
            // 
            // dataMaBHYT
            // 
            this.dataMaBHYT.BackColor = System.Drawing.SystemColors.Control;
            this.dataMaBHYT.Enabled = false;
            this.dataMaBHYT.ForeColor = System.Drawing.Color.Black;
            this.dataMaBHYT.Location = new System.Drawing.Point(104, 339);
            this.dataMaBHYT.MaxLength = 15;
            this.dataMaBHYT.Name = "dataMaBHYT";
            this.dataMaBHYT.Size = new System.Drawing.Size(281, 26);
            this.dataMaBHYT.TabIndex = 28;
            this.dataMaBHYT.TextChanged += new System.EventHandler(this.dataMaBHYT_TextChanged);
            // 
            // dataCCCD
            // 
            this.dataCCCD.BackColor = System.Drawing.SystemColors.Control;
            this.dataCCCD.Enabled = false;
            this.dataCCCD.ForeColor = System.Drawing.Color.Black;
            this.dataCCCD.Location = new System.Drawing.Point(81, 299);
            this.dataCCCD.MaxLength = 12;
            this.dataCCCD.Name = "dataCCCD";
            this.dataCCCD.Size = new System.Drawing.Size(305, 26);
            this.dataCCCD.TabIndex = 27;
            this.dataCCCD.TextChanged += new System.EventHandler(this.dataCCCD_TextChanged);
            // 
            // dataGioiTinh
            // 
            this.dataGioiTinh.BackColor = System.Drawing.SystemColors.Control;
            this.dataGioiTinh.Enabled = false;
            this.dataGioiTinh.ForeColor = System.Drawing.Color.Black;
            this.dataGioiTinh.Location = new System.Drawing.Point(94, 259);
            this.dataGioiTinh.MaxLength = 5;
            this.dataGioiTinh.Name = "dataGioiTinh";
            this.dataGioiTinh.Size = new System.Drawing.Size(292, 26);
            this.dataGioiTinh.TabIndex = 26;
            this.dataGioiTinh.TextChanged += new System.EventHandler(this.dataGioiTinh_TextChanged);
            // 
            // dataNgaySinh
            // 
            this.dataNgaySinh.BackColor = System.Drawing.SystemColors.Control;
            this.dataNgaySinh.Enabled = false;
            this.dataNgaySinh.ForeColor = System.Drawing.Color.Black;
            this.dataNgaySinh.Location = new System.Drawing.Point(105, 219);
            this.dataNgaySinh.MaxLength = 10;
            this.dataNgaySinh.Name = "dataNgaySinh";
            this.dataNgaySinh.Size = new System.Drawing.Size(281, 26);
            this.dataNgaySinh.TabIndex = 25;
            this.dataNgaySinh.TextChanged += new System.EventHandler(this.dataNgaySinh_TextChanged);
            // 
            // dataMaTaiKhoan
            // 
            this.dataMaTaiKhoan.BackColor = System.Drawing.SystemColors.Control;
            this.dataMaTaiKhoan.Enabled = false;
            this.dataMaTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.dataMaTaiKhoan.Location = new System.Drawing.Point(127, 179);
            this.dataMaTaiKhoan.Name = "dataMaTaiKhoan";
            this.dataMaTaiKhoan.Size = new System.Drawing.Size(259, 26);
            this.dataMaTaiKhoan.TabIndex = 24;
            // 
            // dataHoVaTen
            // 
            this.dataHoVaTen.BackColor = System.Drawing.SystemColors.Control;
            this.dataHoVaTen.Enabled = false;
            this.dataHoVaTen.ForeColor = System.Drawing.Color.Black;
            this.dataHoVaTen.Location = new System.Drawing.Point(104, 139);
            this.dataHoVaTen.Name = "dataHoVaTen";
            this.dataHoVaTen.Size = new System.Drawing.Size(282, 26);
            this.dataHoVaTen.TabIndex = 23;
            this.dataHoVaTen.TextChanged += new System.EventHandler(this.dataHoVaTen_TextChanged);
            // 
            // dataMaHoSoBenhNhan
            // 
            this.dataMaHoSoBenhNhan.BackColor = System.Drawing.SystemColors.Control;
            this.dataMaHoSoBenhNhan.Enabled = false;
            this.dataMaHoSoBenhNhan.ForeColor = System.Drawing.Color.Black;
            this.dataMaHoSoBenhNhan.Location = new System.Drawing.Point(181, 99);
            this.dataMaHoSoBenhNhan.Name = "dataMaHoSoBenhNhan";
            this.dataMaHoSoBenhNhan.Size = new System.Drawing.Size(205, 26);
            this.dataMaHoSoBenhNhan.TabIndex = 22;
            // 
            // textDiaChi
            // 
            this.textDiaChi.AutoSize = true;
            this.textDiaChi.BackColor = System.Drawing.Color.Transparent;
            this.textDiaChi.Location = new System.Drawing.Point(10, 505);
            this.textDiaChi.Margin = new System.Windows.Forms.Padding(10);
            this.textDiaChi.Name = "textDiaChi";
            this.textDiaChi.Size = new System.Drawing.Size(61, 20);
            this.textDiaChi.TabIndex = 21;
            this.textDiaChi.Text = "Địa chỉ:";
            // 
            // textEmail
            // 
            this.textEmail.AutoSize = true;
            this.textEmail.BackColor = System.Drawing.Color.Transparent;
            this.textEmail.Location = new System.Drawing.Point(10, 465);
            this.textEmail.Margin = new System.Windows.Forms.Padding(10);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(52, 20);
            this.textEmail.TabIndex = 20;
            this.textEmail.Text = "Email:";
            // 
            // textSoDienThoai
            // 
            this.textSoDienThoai.AutoSize = true;
            this.textSoDienThoai.BackColor = System.Drawing.Color.Transparent;
            this.textSoDienThoai.Location = new System.Drawing.Point(10, 425);
            this.textSoDienThoai.Margin = new System.Windows.Forms.Padding(10);
            this.textSoDienThoai.Name = "textSoDienThoai";
            this.textSoDienThoai.Size = new System.Drawing.Size(106, 20);
            this.textSoDienThoai.TabIndex = 19;
            this.textSoDienThoai.Text = "Số điện thoại:";
            // 
            // textNgheNghiep
            // 
            this.textNgheNghiep.AutoSize = true;
            this.textNgheNghiep.BackColor = System.Drawing.Color.Transparent;
            this.textNgheNghiep.Location = new System.Drawing.Point(10, 385);
            this.textNgheNghiep.Margin = new System.Windows.Forms.Padding(10);
            this.textNgheNghiep.Name = "textNgheNghiep";
            this.textNgheNghiep.Size = new System.Drawing.Size(103, 20);
            this.textNgheNghiep.TabIndex = 18;
            this.textNgheNghiep.Text = "Nghề nghiệp:";
            // 
            // textMaBHYT
            // 
            this.textMaBHYT.AutoSize = true;
            this.textMaBHYT.BackColor = System.Drawing.Color.Transparent;
            this.textMaBHYT.Location = new System.Drawing.Point(10, 345);
            this.textMaBHYT.Margin = new System.Windows.Forms.Padding(10);
            this.textMaBHYT.Name = "textMaBHYT";
            this.textMaBHYT.Size = new System.Drawing.Size(82, 20);
            this.textMaBHYT.TabIndex = 17;
            this.textMaBHYT.Text = "Mã BHYT:";
            // 
            // textCCCD
            // 
            this.textCCCD.AutoSize = true;
            this.textCCCD.BackColor = System.Drawing.Color.Transparent;
            this.textCCCD.Location = new System.Drawing.Point(10, 305);
            this.textCCCD.Margin = new System.Windows.Forms.Padding(10);
            this.textCCCD.Name = "textCCCD";
            this.textCCCD.Size = new System.Drawing.Size(58, 20);
            this.textCCCD.TabIndex = 16;
            this.textCCCD.Text = "CCCD:";
            // 
            // textGioiTinh
            // 
            this.textGioiTinh.AutoSize = true;
            this.textGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.textGioiTinh.Location = new System.Drawing.Point(10, 265);
            this.textGioiTinh.Margin = new System.Windows.Forms.Padding(10);
            this.textGioiTinh.Name = "textGioiTinh";
            this.textGioiTinh.Size = new System.Drawing.Size(71, 20);
            this.textGioiTinh.TabIndex = 15;
            this.textGioiTinh.Text = "Giới tính:";
            // 
            // textNgaySinh
            // 
            this.textNgaySinh.AutoSize = true;
            this.textNgaySinh.BackColor = System.Drawing.Color.Transparent;
            this.textNgaySinh.Location = new System.Drawing.Point(10, 225);
            this.textNgaySinh.Margin = new System.Windows.Forms.Padding(10);
            this.textNgaySinh.Name = "textNgaySinh";
            this.textNgaySinh.Size = new System.Drawing.Size(82, 20);
            this.textNgaySinh.TabIndex = 14;
            this.textNgaySinh.Text = "Ngày sinh:";
            // 
            // textMaTaiKhoan
            // 
            this.textMaTaiKhoan.AutoSize = true;
            this.textMaTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.textMaTaiKhoan.Location = new System.Drawing.Point(10, 185);
            this.textMaTaiKhoan.Margin = new System.Windows.Forms.Padding(10);
            this.textMaTaiKhoan.Name = "textMaTaiKhoan";
            this.textMaTaiKhoan.Size = new System.Drawing.Size(104, 20);
            this.textMaTaiKhoan.TabIndex = 13;
            this.textMaTaiKhoan.Text = "Mã tài khoản:";
            // 
            // textMaHoSoBenhNhan
            // 
            this.textMaHoSoBenhNhan.AutoSize = true;
            this.textMaHoSoBenhNhan.BackColor = System.Drawing.Color.Transparent;
            this.textMaHoSoBenhNhan.Location = new System.Drawing.Point(10, 105);
            this.textMaHoSoBenhNhan.Margin = new System.Windows.Forms.Padding(10);
            this.textMaHoSoBenhNhan.Name = "textMaHoSoBenhNhan";
            this.textMaHoSoBenhNhan.Size = new System.Drawing.Size(158, 20);
            this.textMaHoSoBenhNhan.TabIndex = 12;
            this.textMaHoSoBenhNhan.Text = "Mã hồ sơ bệnh nhân:";
            // 
            // textHoVaTen
            // 
            this.textHoVaTen.AutoSize = true;
            this.textHoVaTen.BackColor = System.Drawing.Color.Transparent;
            this.textHoVaTen.Location = new System.Drawing.Point(10, 145);
            this.textHoVaTen.Margin = new System.Windows.Forms.Padding(10);
            this.textHoVaTen.Name = "textHoVaTen";
            this.textHoVaTen.Size = new System.Drawing.Size(81, 20);
            this.textHoVaTen.TabIndex = 11;
            this.textHoVaTen.Text = "Họ và tên:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackgroundImage = global::QLBenhVienDaLieu.Properties.Resources.delete;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(326, 10);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(10);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(60, 32);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackgroundImage = global::QLBenhVienDaLieu.Properties.Resources.edit;
            this.buttonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Location = new System.Drawing.Point(246, 10);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(10);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(60, 32);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // imageProfile
            // 
            this.imageProfile.BackColor = System.Drawing.Color.WhiteSmoke;
            this.imageProfile.BackgroundImage = global::QLBenhVienDaLieu.Properties.Resources.man;
            this.imageProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageProfile.Location = new System.Drawing.Point(10, 10);
            this.imageProfile.Margin = new System.Windows.Forms.Padding(10);
            this.imageProfile.Name = "imageProfile";
            this.imageProfile.Size = new System.Drawing.Size(100, 75);
            this.imageProfile.TabIndex = 0;
            this.imageProfile.TabStop = false;
            // 
            // buttonArrowLeft
            // 
            this.buttonArrowLeft.BackColor = System.Drawing.SystemColors.Control;
            this.buttonArrowLeft.BackgroundImage = global::QLBenhVienDaLieu.Properties.Resources.arrow_left;
            this.buttonArrowLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonArrowLeft.FlatAppearance.BorderSize = 0;
            this.buttonArrowLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArrowLeft.Location = new System.Drawing.Point(184, 344);
            this.buttonArrowLeft.Margin = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.buttonArrowLeft.Name = "buttonArrowLeft";
            this.buttonArrowLeft.Size = new System.Drawing.Size(49, 64);
            this.buttonArrowLeft.TabIndex = 6;
            this.buttonArrowLeft.UseVisualStyleBackColor = false;
            this.buttonArrowLeft.Click += new System.EventHandler(this.buttonArrowLeft_Click);
            // 
            // buttonArrowRight
            // 
            this.buttonArrowRight.BackColor = System.Drawing.SystemColors.Control;
            this.buttonArrowRight.BackgroundImage = global::QLBenhVienDaLieu.Properties.Resources.arrow_right;
            this.buttonArrowRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonArrowRight.FlatAppearance.BorderSize = 0;
            this.buttonArrowRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArrowRight.Location = new System.Drawing.Point(724, 344);
            this.buttonArrowRight.Margin = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.buttonArrowRight.Name = "buttonArrowRight";
            this.buttonArrowRight.Size = new System.Drawing.Size(49, 64);
            this.buttonArrowRight.TabIndex = 7;
            this.buttonArrowRight.UseVisualStyleBackColor = false;
            this.buttonArrowRight.Click += new System.EventHandler(this.buttonArrowRight_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonAdd.BackgroundImage = global::QLBenhVienDaLieu.Properties.Resources.add;
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(808, 586);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(71, 42);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataNumberHoSoBenhNhan
            // 
            this.dataNumberHoSoBenhNhan.AutoSize = true;
            this.dataNumberHoSoBenhNhan.Location = new System.Drawing.Point(453, 93);
            this.dataNumberHoSoBenhNhan.Name = "dataNumberHoSoBenhNhan";
            this.dataNumberHoSoBenhNhan.Size = new System.Drawing.Size(18, 20);
            this.dataNumberHoSoBenhNhan.TabIndex = 9;
            this.dataNumberHoSoBenhNhan.Text = "1";
            // 
            // HoSoBenhNhanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(937, 670);
            this.Controls.Add(this.dataNumberHoSoBenhNhan);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonArrowRight);
            this.Controls.Add(this.buttonArrowLeft);
            this.Controls.Add(this.showHoSoBenhNhan);
            this.Controls.Add(this.dataTongSoHoSo);
            this.Controls.Add(this.textTongSoHoSo);
            this.Controls.Add(this.titleHoSoBenhNhan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HoSoBenhNhanForm";
            this.Text = "HoSoBenhNhan";
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.HoSoBenhNhanForm_MouseWheel);
            this.Resize += new System.EventHandler(this.HoSoBenhNhan_Resize);
            this.showHoSoBenhNhan.ResumeLayout(false);
            this.showHoSoBenhNhan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleHoSoBenhNhan;
        private System.Windows.Forms.Label textTongSoHoSo;
        private System.Windows.Forms.Label dataTongSoHoSo;
        private System.Windows.Forms.Panel showHoSoBenhNhan;
        private System.Windows.Forms.Button buttonArrowLeft;
        private System.Windows.Forms.Button buttonArrowRight;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.PictureBox imageProfile;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox dataMaHoSoBenhNhan;
        private System.Windows.Forms.Label textDiaChi;
        private System.Windows.Forms.Label textEmail;
        private System.Windows.Forms.Label textSoDienThoai;
        private System.Windows.Forms.Label textNgheNghiep;
        private System.Windows.Forms.Label textMaBHYT;
        private System.Windows.Forms.Label textCCCD;
        private System.Windows.Forms.Label textGioiTinh;
        private System.Windows.Forms.Label textNgaySinh;
        private System.Windows.Forms.Label textMaTaiKhoan;
        private System.Windows.Forms.Label textMaHoSoBenhNhan;
        private System.Windows.Forms.Label textHoVaTen;
        private System.Windows.Forms.TextBox dataEmail;
        private System.Windows.Forms.TextBox dataSoDienThoai;
        private System.Windows.Forms.TextBox dataNgheNghiep;
        private System.Windows.Forms.TextBox dataMaBHYT;
        private System.Windows.Forms.TextBox dataCCCD;
        private System.Windows.Forms.TextBox dataGioiTinh;
        private System.Windows.Forms.TextBox dataNgaySinh;
        private System.Windows.Forms.TextBox dataMaTaiKhoan;
        private System.Windows.Forms.TextBox dataHoVaTen;
        private System.Windows.Forms.Label dataNumberHoSoBenhNhan;
        private System.Windows.Forms.TextBox dataDiaChi;
        private System.Windows.Forms.Button buttonSave;
    }
}