using System.Drawing;
using System.Windows.Forms;

namespace QLBenhVienDaLieu.GiaoDien.BenhNhanTrangUI.LichKhamUI.XemLichKhamUI
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
            this.textMaPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMaPhieu.Location = new System.Drawing.Point(28, 27);
            this.textMaPhieu.Name = "textMaPhieu";
            this.textMaPhieu.Size = new System.Drawing.Size(190, 44);
            this.textMaPhieu.TabIndex = 0;
            this.textMaPhieu.Text = "Mã Phiếu:";
            // 
            // dataMaPhieu
            // 
            this.dataMaPhieu.AutoEllipsis = true;
            this.dataMaPhieu.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.dataMaPhieu.Location = new System.Drawing.Point(224, 22);
            this.dataMaPhieu.Name = "dataMaPhieu";
            this.dataMaPhieu.Size = new System.Drawing.Size(324, 62);
            this.dataMaPhieu.TabIndex = 1;
            this.dataMaPhieu.Text = "LKSAKGIAD";
            // 
            // dataName
            // 
            this.dataName.AutoEllipsis = true;
            this.dataName.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.dataName.Location = new System.Drawing.Point(27, 98);
            this.dataName.Name = "dataName";
            this.dataName.Size = new System.Drawing.Size(407, 61);
            this.dataName.TabIndex = 2;
            this.dataName.Text = "Hoàng Cao Phúc";
            // 
            // textTrangThai
            // 
            this.textTrangThai.AutoSize = true;
            this.textTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTrangThai.Location = new System.Drawing.Point(922, 27);
            this.textTrangThai.Name = "textTrangThai";
            this.textTrangThai.Size = new System.Drawing.Size(201, 44);
            this.textTrangThai.TabIndex = 5;
            this.textTrangThai.Text = "Trạng thái:";
            this.textTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataTrangThai
            // 
            this.dataTrangThai.AutoEllipsis = true;
            this.dataTrangThai.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.dataTrangThai.ForeColor = System.Drawing.Color.MediumBlue;
            this.dataTrangThai.Location = new System.Drawing.Point(1129, 22);
            this.dataTrangThai.Name = "dataTrangThai";
            this.dataTrangThai.Size = new System.Drawing.Size(152, 62);
            this.dataTrangThai.TabIndex = 6;
            this.dataTrangThai.Text = "Đã đặt";
            // 
            // linkXemChiTiet
            // 
            this.linkXemChiTiet.AutoSize = true;
            this.linkXemChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkXemChiTiet.LinkColor = System.Drawing.Color.SeaGreen;
            this.linkXemChiTiet.Location = new System.Drawing.Point(1030, 103);
            this.linkXemChiTiet.Name = "linkXemChiTiet";
            this.linkXemChiTiet.Size = new System.Drawing.Size(251, 44);
            this.linkXemChiTiet.TabIndex = 8;
            this.linkXemChiTiet.TabStop = true;
            this.linkXemChiTiet.Text = "Xem chi tiết >";
            this.linkXemChiTiet.Click += new System.EventHandler(this.linkXemChiTiet_Click);
            // 
            // textDichVu
            // 
            this.textDichVu.AutoSize = true;
            this.textDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDichVu.Location = new System.Drawing.Point(482, 27);
            this.textDichVu.Name = "textDichVu";
            this.textDichVu.Size = new System.Drawing.Size(156, 44);
            this.textDichVu.TabIndex = 9;
            this.textDichVu.Text = "Dịch vụ:";
            // 
            // textChuyenKhoa
            // 
            this.textChuyenKhoa.AutoSize = true;
            this.textChuyenKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textChuyenKhoa.Location = new System.Drawing.Point(397, 103);
            this.textChuyenKhoa.Name = "textChuyenKhoa";
            this.textChuyenKhoa.Size = new System.Drawing.Size(252, 44);
            this.textChuyenKhoa.TabIndex = 10;
            this.textChuyenKhoa.Text = "Chuyên khoa:";
            // 
            // dataDichVu
            // 
            this.dataDichVu.AutoEllipsis = true;
            this.dataDichVu.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.dataDichVu.Location = new System.Drawing.Point(644, 22);
            this.dataDichVu.Name = "dataDichVu";
            this.dataDichVu.Size = new System.Drawing.Size(272, 67);
            this.dataDichVu.TabIndex = 11;
            this.dataDichVu.Text = "Khám dịch vụ";
            // 
            // dataChuyenKhoa
            // 
            this.dataChuyenKhoa.AutoEllipsis = true;
            this.dataChuyenKhoa.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.dataChuyenKhoa.Location = new System.Drawing.Point(655, 98);
            this.dataChuyenKhoa.Name = "dataChuyenKhoa";
            this.dataChuyenKhoa.Size = new System.Drawing.Size(369, 69);
            this.dataChuyenKhoa.TabIndex = 12;
            this.dataChuyenKhoa.Text = "Khám bệnh ngoài da";
            // 
            // DataXemLichKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1289, 203);
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