namespace QLBenhVienDaLieu.GiaoDien.KeToanTrangUI.HoaDonUI
{
    partial class DanhSachHoaDon
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
            this.titleDanhSachHoaDon = new System.Windows.Forms.Label();
            this.comboBoxNam = new System.Windows.Forms.ComboBox();
            this.textNam = new System.Windows.Forms.Label();
            this.comboBoxThang = new System.Windows.Forms.ComboBox();
            this.textThang = new System.Windows.Forms.Label();
            this.comboBoxNgay = new System.Windows.Forms.ComboBox();
            this.textNgay = new System.Windows.Forms.Label();
            this.checkBoxHomNay = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textTemp = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleDanhSachHoaDon
            // 
            this.titleDanhSachHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.titleDanhSachHoaDon.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.titleDanhSachHoaDon.ForeColor = System.Drawing.Color.SeaGreen;
            this.titleDanhSachHoaDon.Location = new System.Drawing.Point(43, 41);
            this.titleDanhSachHoaDon.Margin = new System.Windows.Forms.Padding(0, 32, 0, 40);
            this.titleDanhSachHoaDon.Name = "titleDanhSachHoaDon";
            this.titleDanhSachHoaDon.Size = new System.Drawing.Size(1289, 80);
            this.titleDanhSachHoaDon.TabIndex = 2;
            this.titleDanhSachHoaDon.Text = "DANH SÁCH HÓA ĐƠN";
            this.titleDanhSachHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxNam
            // 
            this.comboBoxNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNam.FormattingEnabled = true;
            this.comboBoxNam.Items.AddRange(new object[] {
            "",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.comboBoxNam.Location = new System.Drawing.Point(1139, 175);
            this.comboBoxNam.Margin = new System.Windows.Forms.Padding(10);
            this.comboBoxNam.Name = "comboBoxNam";
            this.comboBoxNam.Size = new System.Drawing.Size(121, 33);
            this.comboBoxNam.TabIndex = 16;
            this.comboBoxNam.TextChanged += new System.EventHandler(this.comboBoxNam_TextChanged);
            // 
            // textNam
            // 
            this.textNam.AutoSize = true;
            this.textNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNam.Location = new System.Drawing.Point(1016, 172);
            this.textNam.Margin = new System.Windows.Forms.Padding(10);
            this.textNam.Name = "textNam";
            this.textNam.Size = new System.Drawing.Size(103, 40);
            this.textNam.TabIndex = 15;
            this.textNam.Text = "Năm:";
            // 
            // comboBoxThang
            // 
            this.comboBoxThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxThang.FormattingEnabled = true;
            this.comboBoxThang.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxThang.Location = new System.Drawing.Point(875, 175);
            this.comboBoxThang.Margin = new System.Windows.Forms.Padding(10);
            this.comboBoxThang.Name = "comboBoxThang";
            this.comboBoxThang.Size = new System.Drawing.Size(121, 33);
            this.comboBoxThang.TabIndex = 14;
            this.comboBoxThang.TextChanged += new System.EventHandler(this.comboBoxThang_TextChanged);
            // 
            // textThang
            // 
            this.textThang.AutoSize = true;
            this.textThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textThang.Location = new System.Drawing.Point(726, 168);
            this.textThang.Margin = new System.Windows.Forms.Padding(10);
            this.textThang.Name = "textThang";
            this.textThang.Size = new System.Drawing.Size(129, 40);
            this.textThang.TabIndex = 13;
            this.textThang.Text = "Tháng:";
            // 
            // comboBoxNgay
            // 
            this.comboBoxNgay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNgay.FormattingEnabled = true;
            this.comboBoxNgay.ItemHeight = 25;
            this.comboBoxNgay.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBoxNgay.Location = new System.Drawing.Point(585, 175);
            this.comboBoxNgay.Margin = new System.Windows.Forms.Padding(10);
            this.comboBoxNgay.MaxLength = 8;
            this.comboBoxNgay.Name = "comboBoxNgay";
            this.comboBoxNgay.Size = new System.Drawing.Size(121, 33);
            this.comboBoxNgay.TabIndex = 12;
            this.comboBoxNgay.TextChanged += new System.EventHandler(this.comboBoxNgay_TextChanged);
            // 
            // textNgay
            // 
            this.textNgay.AutoSize = true;
            this.textNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNgay.Location = new System.Drawing.Point(454, 168);
            this.textNgay.Margin = new System.Windows.Forms.Padding(10);
            this.textNgay.Name = "textNgay";
            this.textNgay.Size = new System.Drawing.Size(111, 40);
            this.textNgay.TabIndex = 11;
            this.textNgay.Text = "Ngày:";
            // 
            // checkBoxHomNay
            // 
            this.checkBoxHomNay.AutoSize = true;
            this.checkBoxHomNay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHomNay.Location = new System.Drawing.Point(86, 171);
            this.checkBoxHomNay.Margin = new System.Windows.Forms.Padding(10);
            this.checkBoxHomNay.Name = "checkBoxHomNay";
            this.checkBoxHomNay.Size = new System.Drawing.Size(187, 44);
            this.checkBoxHomNay.TabIndex = 10;
            this.checkBoxHomNay.Text = "Hôm nay";
            this.checkBoxHomNay.UseVisualStyleBackColor = true;
            this.checkBoxHomNay.CheckedChanged += new System.EventHandler(this.checkBoxHomNay_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.textTemp);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 241);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1349, 741);
            this.flowLayoutPanel1.TabIndex = 17;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // textTemp
            // 
            this.textTemp.BackColor = System.Drawing.Color.Transparent;
            this.textTemp.Location = new System.Drawing.Point(0, 0);
            this.textTemp.Margin = new System.Windows.Forms.Padding(0);
            this.textTemp.Name = "textTemp";
            this.textTemp.Size = new System.Drawing.Size(1349, 1);
            this.textTemp.TabIndex = 0;
            this.textTemp.Text = "label1";
            // 
            // DanhSachHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1367, 991);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.comboBoxNam);
            this.Controls.Add(this.textNam);
            this.Controls.Add(this.comboBoxThang);
            this.Controls.Add(this.textThang);
            this.Controls.Add(this.comboBoxNgay);
            this.Controls.Add(this.textNgay);
            this.Controls.Add(this.checkBoxHomNay);
            this.Controls.Add(this.titleDanhSachHoaDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DanhSachHoaDon";
            this.Text = "DataHoaDon";
            this.Resize += new System.EventHandler(this.DanhSachHoaDon_Resize);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleDanhSachHoaDon;
        private System.Windows.Forms.ComboBox comboBoxNam;
        private System.Windows.Forms.Label textNam;
        private System.Windows.Forms.ComboBox comboBoxThang;
        private System.Windows.Forms.Label textThang;
        private System.Windows.Forms.ComboBox comboBoxNgay;
        private System.Windows.Forms.Label textNgay;
        private System.Windows.Forms.CheckBox checkBoxHomNay;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label textTemp;
    }
}