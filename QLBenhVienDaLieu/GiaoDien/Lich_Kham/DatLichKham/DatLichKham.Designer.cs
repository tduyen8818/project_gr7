using System.Drawing;
using System.Windows.Forms;

namespace QLBenhVienDaLieu.GiaoDien.Lich_Kham.DatLichKham
{
    partial class DatLichKham
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
            this.titleDatLich = new System.Windows.Forms.Label();
            this.textChuyenKhoa = new System.Windows.Forms.Label();
            this.dataChuyenKhoa = new System.Windows.Forms.ComboBox();
            this.dataDichVu = new System.Windows.Forms.ComboBox();
            this.textDichVu = new System.Windows.Forms.Label();
            this.textNgayKham = new System.Windows.Forms.Label();
            this.dataNgayKham = new System.Windows.Forms.DateTimePicker();
            this.dataCaKham = new System.Windows.Forms.ComboBox();
            this.textCaKham = new System.Windows.Forms.Label();
            this.textHoSoBenhNhan = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textTemp = new System.Windows.Forms.Label();
            this.btnDatLich = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.imageUser = new System.Windows.Forms.PictureBox();
            this.showHoSoBenhNhan = new System.Windows.Forms.Panel();
            this.textErrorChuyenKhoa = new System.Windows.Forms.Label();
            this.textErrorDichVu = new System.Windows.Forms.Label();
            this.textErrorCaKham = new System.Windows.Forms.Label();
            this.imageCheck = new System.Windows.Forms.PictureBox();
            this.imageCheck1 = new System.Windows.Forms.PictureBox();
            this.imageCheck2 = new System.Windows.Forms.PictureBox();
            this.textErrorHoSoBenhNhan = new System.Windows.Forms.Label();
            this.imageCheck3 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageUser)).BeginInit();
            this.showHoSoBenhNhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCheck1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCheck2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCheck3)).BeginInit();
            this.SuspendLayout();
            // 
            // titleDatLich
            // 
            this.titleDatLich.BackColor = System.Drawing.Color.White;
            this.titleDatLich.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.titleDatLich.ForeColor = System.Drawing.Color.SeaGreen;
            this.titleDatLich.Location = new System.Drawing.Point(50, 50);
            this.titleDatLich.Margin = new System.Windows.Forms.Padding(40);
            this.titleDatLich.Name = "titleDatLich";
            this.titleDatLich.Size = new System.Drawing.Size(933, 100);
            this.titleDatLich.TabIndex = 2;
            this.titleDatLich.Text = "Đặt lịch khám";
            this.titleDatLich.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textChuyenKhoa
            // 
            this.textChuyenKhoa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.textChuyenKhoa.Location = new System.Drawing.Point(50, 168);
            this.textChuyenKhoa.Margin = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.textChuyenKhoa.Name = "textChuyenKhoa";
            this.textChuyenKhoa.Size = new System.Drawing.Size(162, 44);
            this.textChuyenKhoa.TabIndex = 3;
            this.textChuyenKhoa.Text = "Chuyên khoa";
            // 
            // dataChuyenKhoa
            // 
            this.dataChuyenKhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataChuyenKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataChuyenKhoa.FormattingEnabled = true;
            this.dataChuyenKhoa.Location = new System.Drawing.Point(50, 252);
            this.dataChuyenKhoa.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.dataChuyenKhoa.Name = "dataChuyenKhoa";
            this.dataChuyenKhoa.Size = new System.Drawing.Size(409, 28);
            this.dataChuyenKhoa.Sorted = true;
            this.dataChuyenKhoa.TabIndex = 4;
            this.dataChuyenKhoa.TextChanged += new System.EventHandler(this.dataChuyenKhoa_TextChanged);
            // 
            // dataDichVu
            // 
            this.dataDichVu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataDichVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataDichVu.FormattingEnabled = true;
            this.dataDichVu.Location = new System.Drawing.Point(50, 389);
            this.dataDichVu.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.dataDichVu.Name = "dataDichVu";
            this.dataDichVu.Size = new System.Drawing.Size(409, 28);
            this.dataDichVu.Sorted = true;
            this.dataDichVu.TabIndex = 6;
            this.dataDichVu.TextChanged += new System.EventHandler(this.dataDichVu_TextChanged);
            // 
            // textDichVu
            // 
            this.textDichVu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.textDichVu.Location = new System.Drawing.Point(50, 305);
            this.textDichVu.Margin = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.textDichVu.Name = "textDichVu";
            this.textDichVu.Size = new System.Drawing.Size(117, 44);
            this.textDichVu.TabIndex = 5;
            this.textDichVu.Text = "Dịch vụ";
            // 
            // textNgayKham
            // 
            this.textNgayKham.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.textNgayKham.Location = new System.Drawing.Point(50, 442);
            this.textNgayKham.Margin = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.textNgayKham.Name = "textNgayKham";
            this.textNgayKham.Size = new System.Drawing.Size(162, 44);
            this.textNgayKham.TabIndex = 7;
            this.textNgayKham.Text = "Ngày khám";
            // 
            // dataNgayKham
            // 
            this.dataNgayKham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataNgayKham.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dataNgayKham.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataNgayKham.Location = new System.Drawing.Point(50, 501);
            this.dataNgayKham.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.dataNgayKham.Name = "dataNgayKham";
            this.dataNgayKham.Size = new System.Drawing.Size(409, 26);
            this.dataNgayKham.TabIndex = 8;
            this.dataNgayKham.Value = new System.DateTime(2023, 11, 1, 9, 50, 0, 0);
            // 
            // dataCaKham
            // 
            this.dataCaKham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataCaKham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataCaKham.FormattingEnabled = true;
            this.dataCaKham.Location = new System.Drawing.Point(50, 641);
            this.dataCaKham.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.dataCaKham.Name = "dataCaKham";
            this.dataCaKham.Size = new System.Drawing.Size(409, 28);
            this.dataCaKham.Sorted = true;
            this.dataCaKham.TabIndex = 10;
            this.dataCaKham.TextChanged += new System.EventHandler(this.dataCaKham_TextChanged);
            // 
            // textCaKham
            // 
            this.textCaKham.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.textCaKham.Location = new System.Drawing.Point(50, 552);
            this.textCaKham.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.textCaKham.Name = "textCaKham";
            this.textCaKham.Size = new System.Drawing.Size(127, 44);
            this.textCaKham.TabIndex = 9;
            this.textCaKham.Text = "Ca khám";
            // 
            // textHoSoBenhNhan
            // 
            this.textHoSoBenhNhan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.textHoSoBenhNhan.Location = new System.Drawing.Point(512, 200);
            this.textHoSoBenhNhan.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.textHoSoBenhNhan.Name = "textHoSoBenhNhan";
            this.textHoSoBenhNhan.Size = new System.Drawing.Size(188, 44);
            this.textHoSoBenhNhan.TabIndex = 11;
            this.textHoSoBenhNhan.Text = "Hồ sơ bệnh nhân";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Controls.Add(this.textTemp);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(471, 481);
            this.flowLayoutPanel1.TabIndex = 12;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // textTemp
            // 
            this.textTemp.Location = new System.Drawing.Point(0, 0);
            this.textTemp.Margin = new System.Windows.Forms.Padding(0);
            this.textTemp.Name = "textTemp";
            this.textTemp.Size = new System.Drawing.Size(471, 1);
            this.textTemp.TabIndex = 0;
            // 
            // btnDatLich
            // 
            this.btnDatLich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(188)))), ((int)(((byte)(66)))));
            this.btnDatLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatLich.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDatLich.ForeColor = System.Drawing.Color.White;
            this.btnDatLich.Location = new System.Drawing.Point(413, 749);
            this.btnDatLich.Margin = new System.Windows.Forms.Padding(10, 10, 10, 20);
            this.btnDatLich.Name = "btnDatLich";
            this.btnDatLich.Size = new System.Drawing.Size(194, 59);
            this.btnDatLich.TabIndex = 13;
            this.btnDatLich.Text = "Đặt lịch";
            this.btnDatLich.UseVisualStyleBackColor = false;
            this.btnDatLich.Click += new System.EventHandler(this.btnDatLich_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.White;
            this.btnAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(139)))), ((int)(((byte)(68)))));
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(827, 20);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(194, 70);
            this.btnAccount.TabIndex = 14;
            this.btnAccount.Text = "0962214534";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Visible = false;
            // 
            // imageUser
            // 
            this.imageUser.Image = global::QLBenhVienDaLieu.Properties.Resources._9;
            this.imageUser.Location = new System.Drawing.Point(827, 20);
            this.imageUser.Name = "imageUser";
            this.imageUser.Size = new System.Drawing.Size(57, 70);
            this.imageUser.TabIndex = 15;
            this.imageUser.TabStop = false;
            this.imageUser.Visible = false;
            // 
            // showHoSoBenhNhan
            // 
            this.showHoSoBenhNhan.BackColor = System.Drawing.SystemColors.Control;
            this.showHoSoBenhNhan.Controls.Add(this.flowLayoutPanel1);
            this.showHoSoBenhNhan.Location = new System.Drawing.Point(512, 258);
            this.showHoSoBenhNhan.Margin = new System.Windows.Forms.Padding(0);
            this.showHoSoBenhNhan.Name = "showHoSoBenhNhan";
            this.showHoSoBenhNhan.Size = new System.Drawing.Size(471, 481);
            this.showHoSoBenhNhan.TabIndex = 16;
            // 
            // textErrorChuyenKhoa
            // 
            this.textErrorChuyenKhoa.AutoSize = true;
            this.textErrorChuyenKhoa.ForeColor = System.Drawing.Color.Red;
            this.textErrorChuyenKhoa.Location = new System.Drawing.Point(50, 217);
            this.textErrorChuyenKhoa.Margin = new System.Windows.Forms.Padding(0);
            this.textErrorChuyenKhoa.Name = "textErrorChuyenKhoa";
            this.textErrorChuyenKhoa.Size = new System.Drawing.Size(199, 20);
            this.textErrorChuyenKhoa.TabIndex = 17;
            this.textErrorChuyenKhoa.Text = "Vui lòng chọn chuyên khoa";
            this.textErrorChuyenKhoa.Visible = false;
            // 
            // textErrorDichVu
            // 
            this.textErrorDichVu.AutoSize = true;
            this.textErrorDichVu.ForeColor = System.Drawing.Color.Red;
            this.textErrorDichVu.Location = new System.Drawing.Point(50, 354);
            this.textErrorDichVu.Margin = new System.Windows.Forms.Padding(0);
            this.textErrorDichVu.Name = "textErrorDichVu";
            this.textErrorDichVu.Size = new System.Drawing.Size(158, 20);
            this.textErrorDichVu.TabIndex = 18;
            this.textErrorDichVu.Text = "Vui lòng chọn dịch vụ";
            this.textErrorDichVu.Visible = false;
            // 
            // textErrorCaKham
            // 
            this.textErrorCaKham.AutoSize = true;
            this.textErrorCaKham.ForeColor = System.Drawing.Color.Red;
            this.textErrorCaKham.Location = new System.Drawing.Point(50, 606);
            this.textErrorCaKham.Margin = new System.Windows.Forms.Padding(0);
            this.textErrorCaKham.Name = "textErrorCaKham";
            this.textErrorCaKham.Size = new System.Drawing.Size(169, 20);
            this.textErrorCaKham.TabIndex = 20;
            this.textErrorCaKham.Text = "Vui lòng chọn ca khám";
            this.textErrorCaKham.Visible = false;
            // 
            // imageCheck
            // 
            this.imageCheck.Enabled = false;
            this.imageCheck.Location = new System.Drawing.Point(462, 252);
            this.imageCheck.Name = "imageCheck";
            this.imageCheck.Size = new System.Drawing.Size(44, 33);
            this.imageCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageCheck.TabIndex = 21;
            this.imageCheck.TabStop = false;
            // 
            // imageCheck1
            // 
            this.imageCheck1.Enabled = false;
            this.imageCheck1.Location = new System.Drawing.Point(462, 389);
            this.imageCheck1.Name = "imageCheck1";
            this.imageCheck1.Size = new System.Drawing.Size(44, 33);
            this.imageCheck1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageCheck1.TabIndex = 22;
            this.imageCheck1.TabStop = false;
            // 
            // imageCheck2
            // 
            this.imageCheck2.Enabled = false;
            this.imageCheck2.Location = new System.Drawing.Point(462, 641);
            this.imageCheck2.Name = "imageCheck2";
            this.imageCheck2.Size = new System.Drawing.Size(44, 33);
            this.imageCheck2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageCheck2.TabIndex = 23;
            this.imageCheck2.TabStop = false;
            // 
            // textErrorHoSoBenhNhan
            // 
            this.textErrorHoSoBenhNhan.AutoSize = true;
            this.textErrorHoSoBenhNhan.ForeColor = System.Drawing.Color.Red;
            this.textErrorHoSoBenhNhan.Location = new System.Drawing.Point(513, 233);
            this.textErrorHoSoBenhNhan.Margin = new System.Windows.Forms.Padding(5);
            this.textErrorHoSoBenhNhan.Name = "textErrorHoSoBenhNhan";
            this.textErrorHoSoBenhNhan.Size = new System.Drawing.Size(283, 20);
            this.textErrorHoSoBenhNhan.TabIndex = 24;
            this.textErrorHoSoBenhNhan.Text = "Vui lòng chỉ chọn một hồ sơ bệnh nhân";
            this.textErrorHoSoBenhNhan.Visible = false;
            // 
            // imageCheck3
            // 
            this.imageCheck3.Enabled = false;
            this.imageCheck3.Location = new System.Drawing.Point(804, 222);
            this.imageCheck3.Name = "imageCheck3";
            this.imageCheck3.Size = new System.Drawing.Size(44, 33);
            this.imageCheck3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageCheck3.TabIndex = 25;
            this.imageCheck3.TabStop = false;
            // 
            // DatLichKham
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1037, 850);
            this.Controls.Add(this.imageCheck3);
            this.Controls.Add(this.textErrorHoSoBenhNhan);
            this.Controls.Add(this.imageCheck2);
            this.Controls.Add(this.imageCheck1);
            this.Controls.Add(this.imageCheck);
            this.Controls.Add(this.textErrorCaKham);
            this.Controls.Add(this.textErrorDichVu);
            this.Controls.Add(this.textErrorChuyenKhoa);
            this.Controls.Add(this.showHoSoBenhNhan);
            this.Controls.Add(this.imageUser);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.btnDatLich);
            this.Controls.Add(this.textHoSoBenhNhan);
            this.Controls.Add(this.dataCaKham);
            this.Controls.Add(this.textCaKham);
            this.Controls.Add(this.dataNgayKham);
            this.Controls.Add(this.textNgayKham);
            this.Controls.Add(this.dataDichVu);
            this.Controls.Add(this.textDichVu);
            this.Controls.Add(this.dataChuyenKhoa);
            this.Controls.Add(this.textChuyenKhoa);
            this.Controls.Add(this.titleDatLich);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DatLichKham";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "DatLichKham";
            this.Resize += new System.EventHandler(this.DatLichKham_Resize);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageUser)).EndInit();
            this.showHoSoBenhNhan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCheck1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCheck2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCheck3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label titleDatLich;
        private Label textChuyenKhoa;
        private ComboBox dataChuyenKhoa;
        private ComboBox dataDichVu;
        private Label textDichVu;
        private Label textNgayKham;
        private DateTimePicker dataNgayKham;
        private ComboBox dataCaKham;
        private Label textCaKham;
        private Label textHoSoBenhNhan;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnDatLich;
        private Button btnAccount;
        private PictureBox imageUser;
        private Panel showHoSoBenhNhan;
        private Label textErrorChuyenKhoa;
        private Label textErrorDichVu;
        private Label textErrorCaKham;
        private PictureBox imageCheck;
        private PictureBox imageCheck1;
        private PictureBox imageCheck2;
        private Label textTemp;
        private Label textErrorHoSoBenhNhan;
        private PictureBox imageCheck3;
    }
}