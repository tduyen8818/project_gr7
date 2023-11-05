using System;

namespace QLBenhVienDaLieu
{
    partial class DangNhap
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
            this.linkLabel_DangKy = new Guna.UI2.WinForms.Guna2Button();
            this.checkBox_HienMatKhau = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.textBox_SDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox_MatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.button1 = new Guna.UI2.WinForms.Guna2Button();
            this.linkLabel_QMK = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel_DangKy
            // 
            this.linkLabel_DangKy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel_DangKy.BackColor = System.Drawing.Color.White;
            this.linkLabel_DangKy.BorderRadius = 20;
            this.linkLabel_DangKy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.linkLabel_DangKy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.linkLabel_DangKy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.linkLabel_DangKy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.linkLabel_DangKy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkLabel_DangKy.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold);
            this.linkLabel_DangKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.linkLabel_DangKy.Location = new System.Drawing.Point(1079, 629);
            this.linkLabel_DangKy.Name = "linkLabel_DangKy";
            this.linkLabel_DangKy.Size = new System.Drawing.Size(227, 53);
            this.linkLabel_DangKy.TabIndex = 32;
            this.linkLabel_DangKy.Text = "Đăng Ký ";
            this.linkLabel_DangKy.Click += new System.EventHandler(this.linkLabel_DangKy_Click);
            // 
            // checkBox_HienMatKhau
            // 
            this.checkBox_HienMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_HienMatKhau.AutoSize = true;
            this.checkBox_HienMatKhau.BackColor = System.Drawing.Color.White;
            this.checkBox_HienMatKhau.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_HienMatKhau.Location = new System.Drawing.Point(732, 481);
            this.checkBox_HienMatKhau.Name = "checkBox_HienMatKhau";
            this.checkBox_HienMatKhau.Size = new System.Drawing.Size(156, 27);
            this.checkBox_HienMatKhau.TabIndex = 30;
            this.checkBox_HienMatKhau.Text = "Hiện mật khẩu";
            this.checkBox_HienMatKhau.UseVisualStyleBackColor = false;
            this.checkBox_HienMatKhau.CheckedChanged += new System.EventHandler(this.checkBox_HienMatKhau_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(727, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 27);
            this.label3.TabIndex = 27;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(727, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 27);
            this.label2.TabIndex = 25;
            this.label2.Text = "Số điện thoại";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(887, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 62);
            this.label1.TabIndex = 24;
            this.label1.Text = "Đăng Nhập";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseCompatibleTextRendering = true;
            this.label1.UseWaitCursor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.BorderRadius = 10;
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.FillColor = System.Drawing.Color.SkyBlue;
            this.pictureBox3.Image = global::QLBenhVienDaLieu.Properties.Resources.image_doctor;
            this.pictureBox3.ImageRotate = 0F;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(-3, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(687, 782);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::QLBenhVienDaLieu.Properties.Resources.Logo;
            this.pictureBox2.Location = new System.Drawing.Point(917, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(208, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBox1.BorderRadius = 30;
            this.pictureBox1.ImageRotate = 0F;
            this.pictureBox1.Location = new System.Drawing.Point(114, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1237, 782);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_SDT
            // 
            this.textBox_SDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_SDT.BackColor = System.Drawing.Color.White;
            this.textBox_SDT.BorderRadius = 10;
            this.textBox_SDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_SDT.DefaultText = "";
            this.textBox_SDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_SDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_SDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_SDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_SDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_SDT.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_SDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_SDT.Location = new System.Drawing.Point(732, 267);
            this.textBox_SDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_SDT.Name = "textBox_SDT";
            this.textBox_SDT.PasswordChar = '\0';
            this.textBox_SDT.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_SDT.PlaceholderText = "";
            this.textBox_SDT.SelectedText = "";
            this.textBox_SDT.Size = new System.Drawing.Size(574, 43);
            this.textBox_SDT.TabIndex = 34;
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_MatKhau.BackColor = System.Drawing.Color.White;
            this.textBox_MatKhau.BorderRadius = 10;
            this.textBox_MatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_MatKhau.DefaultText = "";
            this.textBox_MatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_MatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_MatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_MatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_MatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_MatKhau.Font = new System.Drawing.Font("Arial", 13.8F);
            this.textBox_MatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_MatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_MatKhau.Location = new System.Drawing.Point(732, 393);
            this.textBox_MatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.PasswordChar = '*';
            this.textBox_MatKhau.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_MatKhau.PlaceholderText = "";
            this.textBox_MatKhau.SelectedText = "";
            this.textBox_MatKhau.Size = new System.Drawing.Size(574, 43);
            this.textBox_MatKhau.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BorderRadius = 20;
            this.button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(732, 629);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 53);
            this.button1.TabIndex = 36;
            this.button1.Text = "Đăng Nhập";
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // linkLabel_QMK
            // 
            this.linkLabel_QMK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel_QMK.AutoSize = true;
            this.linkLabel_QMK.BackColor = System.Drawing.Color.White;
            this.linkLabel_QMK.Font = new System.Drawing.Font("Arial", 12F);
            this.linkLabel_QMK.ForeColor = System.Drawing.Color.Red;
            this.linkLabel_QMK.Location = new System.Drawing.Point(1152, 485);
            this.linkLabel_QMK.Name = "linkLabel_QMK";
            this.linkLabel_QMK.Size = new System.Drawing.Size(154, 23);
            this.linkLabel_QMK.TabIndex = 37;
            this.linkLabel_QMK.Text = "Quên mật khẩu?";
            this.linkLabel_QMK.Click += new System.EventHandler(this.linkLabel_QMK_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1332, 753);
            this.Controls.Add(this.linkLabel_QMK);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_MatKhau);
            this.Controls.Add(this.textBox_SDT);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.linkLabel_DangKy);
            this.Controls.Add(this.checkBox_HienMatKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhap";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button linkLabel_DangKy;
        private Guna.UI2.WinForms.Guna2Button button_DangNhap;
        private System.Windows.Forms.CheckBox checkBox_HienMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2TextBox textBox_SDT;
        private Guna.UI2.WinForms.Guna2TextBox textBox_MatKhau;
        private Guna.UI2.WinForms.Guna2Button button1;
        private System.Windows.Forms.Label linkLabel_QMK;
    }
}

