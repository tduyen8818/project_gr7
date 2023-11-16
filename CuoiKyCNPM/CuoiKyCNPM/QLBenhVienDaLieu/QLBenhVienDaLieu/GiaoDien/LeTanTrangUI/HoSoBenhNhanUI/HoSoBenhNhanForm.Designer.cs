namespace QLBenhVienDaLieu.GiaoDien.LeTanTrangUI.HoSoBenhNhanUI
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
            this.textBoxSearchMaTaiKhoan = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textTemp = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textErrorMaTaiKhoan = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleHoSoBenhNhan
            // 
            this.titleHoSoBenhNhan.BackColor = System.Drawing.Color.Transparent;
            this.titleHoSoBenhNhan.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.titleHoSoBenhNhan.ForeColor = System.Drawing.Color.SeaGreen;
            this.titleHoSoBenhNhan.Location = new System.Drawing.Point(27, 41);
            this.titleHoSoBenhNhan.Margin = new System.Windows.Forms.Padding(0, 32, 0, 40);
            this.titleHoSoBenhNhan.Name = "titleHoSoBenhNhan";
            this.titleHoSoBenhNhan.Size = new System.Drawing.Size(1278, 92);
            this.titleHoSoBenhNhan.TabIndex = 49;
            this.titleHoSoBenhNhan.Text = "HỒ SƠ BỆNH NHÂN";
            this.titleHoSoBenhNhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSearchMaTaiKhoan
            // 
            this.textBoxSearchMaTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearchMaTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchMaTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.textBoxSearchMaTaiKhoan.Location = new System.Drawing.Point(186, 150);
            this.textBoxSearchMaTaiKhoan.Margin = new System.Windows.Forms.Padding(40, 0, 0, 40);
            this.textBoxSearchMaTaiKhoan.MaxLength = 10;
            this.textBoxSearchMaTaiKhoan.Name = "textBoxSearchMaTaiKhoan";
            this.textBoxSearchMaTaiKhoan.Size = new System.Drawing.Size(889, 48);
            this.textBoxSearchMaTaiKhoan.TabIndex = 50;
            this.textBoxSearchMaTaiKhoan.TextChanged += new System.EventHandler(this.textBoxSearchSoDienThoai_TextChanged);
            this.textBoxSearchMaTaiKhoan.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxSearchSoDienThoai_KeyUp);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Gray;
            this.buttonSearch.BackgroundImage = global::QLBenhVienDaLieu.Properties.Resources.search;
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSearch.Enabled = false;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Location = new System.Drawing.Point(1064, 150);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(119, 48);
            this.buttonSearch.TabIndex = 51;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.textTemp);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(38, 271);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1267, 588);
            this.flowLayoutPanel1.TabIndex = 52;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // textTemp
            // 
            this.textTemp.Location = new System.Drawing.Point(0, 0);
            this.textTemp.Margin = new System.Windows.Forms.Padding(0);
            this.textTemp.Name = "textTemp";
            this.textTemp.Size = new System.Drawing.Size(1267, 1);
            this.textTemp.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Gray;
            this.buttonAdd.BackgroundImage = global::QLBenhVienDaLieu.Properties.Resources.add;
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAdd.Enabled = false;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(1205, 872);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 80);
            this.buttonAdd.TabIndex = 53;
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textErrorMaTaiKhoan
            // 
            this.textErrorMaTaiKhoan.AutoSize = true;
            this.textErrorMaTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textErrorMaTaiKhoan.ForeColor = System.Drawing.Color.Red;
            this.textErrorMaTaiKhoan.Location = new System.Drawing.Point(551, 226);
            this.textErrorMaTaiKhoan.Margin = new System.Windows.Forms.Padding(10);
            this.textErrorMaTaiKhoan.Name = "textErrorMaTaiKhoan";
            this.textErrorMaTaiKhoan.Size = new System.Drawing.Size(240, 25);
            this.textErrorMaTaiKhoan.TabIndex = 54;
            this.textErrorMaTaiKhoan.Text = "Mã tài khoản không tồn tại";
            this.textErrorMaTaiKhoan.Visible = false;
            // 
            // HoSoBenhNhanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1367, 991);
            this.Controls.Add(this.textErrorMaTaiKhoan);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearchMaTaiKhoan);
            this.Controls.Add(this.titleHoSoBenhNhan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HoSoBenhNhanForm";
            this.Text = "HoSoBenhNhanForm";
            this.Resize += new System.EventHandler(this.HoSoBenhNhanForm_Resize);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleHoSoBenhNhan;
        private System.Windows.Forms.TextBox textBoxSearchMaTaiKhoan;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label textTemp;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label textErrorMaTaiKhoan;
    }
}