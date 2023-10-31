using System.Drawing;
using System.Windows.Forms;

namespace QLBenhVienDaLieu.GiaoDien.Lich_Kham.XemLichKham
{
    partial class DataXemLichKham
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
            this.textMaPhieu = new System.Windows.Forms.Label();
            this.dataMaPhieu = new System.Windows.Forms.Label();
            this.dataName = new System.Windows.Forms.Label();
            this.textTrangThai = new System.Windows.Forms.Label();
            this.dataTrangThai = new System.Windows.Forms.Label();
            this.linkXemChiTiet = new System.Windows.Forms.LinkLabel();
            this.textDichVu = new System.Windows.Forms.Label();
            this.textChuyenKhoa = new System.Windows.Forms.Label();
            this.dataDichVu = new System.Windows.Forms.Label();
            this.dataChuyenKhoa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textMaPhieu
            // 
            this.textMaPhieu.AutoSize = true;
            this.textMaPhieu.Location = new System.Drawing.Point(26, 14);
            this.textMaPhieu.Name = "textMaPhieu";
            this.textMaPhieu.Size = new System.Drawing.Size(79, 20);
            this.textMaPhieu.TabIndex = 0;
            this.textMaPhieu.Text = "Mã Phiếu:";
            // 
            // dataMaPhieu
            // 
            this.dataMaPhieu.AutoEllipsis = true;
            this.dataMaPhieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dataMaPhieu.Location = new System.Drawing.Point(111, 9);
            this.dataMaPhieu.Name = "dataMaPhieu";
            this.dataMaPhieu.Size = new System.Drawing.Size(144, 34);
            this.dataMaPhieu.TabIndex = 1;
            this.dataMaPhieu.Text = "LKSAKGIAD";
            // 
            // dataName
            // 
            this.dataName.AutoEllipsis = true;
            this.dataName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dataName.Location = new System.Drawing.Point(26, 49);
            this.dataName.Name = "dataName";
            this.dataName.Size = new System.Drawing.Size(230, 34);
            this.dataName.TabIndex = 2;
            this.dataName.Text = "Hoàng Cao Phúc";
            // 
            // textTrangThai
            // 
            this.textTrangThai.AutoSize = true;
            this.textTrangThai.Location = new System.Drawing.Point(582, 14);
            this.textTrangThai.Name = "textTrangThai";
            this.textTrangThai.Size = new System.Drawing.Size(84, 20);
            this.textTrangThai.TabIndex = 5;
            this.textTrangThai.Text = "Trạng thái:";
            // 
            // dataTrangThai
            // 
            this.dataTrangThai.AutoEllipsis = true;
            this.dataTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dataTrangThai.ForeColor = System.Drawing.Color.MediumBlue;
            this.dataTrangThai.Location = new System.Drawing.Point(672, 9);
            this.dataTrangThai.Name = "dataTrangThai";
            this.dataTrangThai.Size = new System.Drawing.Size(86, 34);
            this.dataTrangThai.TabIndex = 6;
            this.dataTrangThai.Text = "Đã đặt";
            // 
            // linkXemChiTiet
            // 
            this.linkXemChiTiet.AutoSize = true;
            this.linkXemChiTiet.LinkColor = System.Drawing.Color.SeaGreen;
            this.linkXemChiTiet.Location = new System.Drawing.Point(582, 49);
            this.linkXemChiTiet.Name = "linkXemChiTiet";
            this.linkXemChiTiet.Size = new System.Drawing.Size(105, 20);
            this.linkXemChiTiet.TabIndex = 8;
            this.linkXemChiTiet.TabStop = true;
            this.linkXemChiTiet.Text = "Xem chi tiết >";
            this.linkXemChiTiet.Click += new System.EventHandler(this.linkXemChiTiet_Click);
            // 
            // textDichVu
            // 
            this.textDichVu.AutoSize = true;
            this.textDichVu.Location = new System.Drawing.Point(285, 14);
            this.textDichVu.Name = "textDichVu";
            this.textDichVu.Size = new System.Drawing.Size(65, 20);
            this.textDichVu.TabIndex = 9;
            this.textDichVu.Text = "Dịch vụ:";
            // 
            // textChuyenKhoa
            // 
            this.textChuyenKhoa.AutoSize = true;
            this.textChuyenKhoa.Location = new System.Drawing.Point(285, 49);
            this.textChuyenKhoa.Name = "textChuyenKhoa";
            this.textChuyenKhoa.Size = new System.Drawing.Size(106, 20);
            this.textChuyenKhoa.TabIndex = 10;
            this.textChuyenKhoa.Text = "Chuyên khoa:";
            // 
            // dataDichVu
            // 
            this.dataDichVu.AutoEllipsis = true;
            this.dataDichVu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dataDichVu.Location = new System.Drawing.Point(356, 9);
            this.dataDichVu.Name = "dataDichVu";
            this.dataDichVu.Size = new System.Drawing.Size(115, 30);
            this.dataDichVu.TabIndex = 11;
            this.dataDichVu.Text = "Khám dịch vụ";
            // 
            // dataChuyenKhoa
            // 
            this.dataChuyenKhoa.AutoEllipsis = true;
            this.dataChuyenKhoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dataChuyenKhoa.Location = new System.Drawing.Point(397, 45);
            this.dataChuyenKhoa.Name = "dataChuyenKhoa";
            this.dataChuyenKhoa.Size = new System.Drawing.Size(169, 34);
            this.dataChuyenKhoa.TabIndex = 12;
            this.dataChuyenKhoa.Text = "Khám bệnh ngoài da";
            // 
            // DataXemLichKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(770, 90);
            this.Controls.Add(this.dataChuyenKhoa);
            this.Controls.Add(this.dataDichVu);
            this.Controls.Add(this.textChuyenKhoa);
            this.Controls.Add(this.textDichVu);
            this.Controls.Add(this.linkXemChiTiet);
            this.Controls.Add(this.dataTrangThai);
            this.Controls.Add(this.textTrangThai);
            this.Controls.Add(this.dataName);
            this.Controls.Add(this.dataMaPhieu);
            this.Controls.Add(this.textMaPhieu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DataXemLichKham";
            this.Text = "XemLichKham";
            this.Resize += new System.EventHandler(this.DataXemLichKham_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label textMaPhieu;
        private Label dataMaPhieu;
        private Label dataName;
        private Label textTrangThai;
        private Label dataTrangThai;
        private LinkLabel linkXemChiTiet;
        private Label textDichVu;
        private Label textChuyenKhoa;
        private Label dataDichVu;
        private Label dataChuyenKhoa;
    }
}