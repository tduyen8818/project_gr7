﻿using System.Drawing;
using System.Windows.Forms;

namespace QLBenhVienDaLieu.GiaoDien.Lich_Kham.DatLichKham
{
    partial class DatLichKhamThanhToan
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
            this.textThanhToan = new System.Windows.Forms.Label();
            this.titleDatLich = new System.Windows.Forms.Label();
            this.imageCheck = new System.Windows.Forms.PictureBox();
            this.textErrorThanhToan = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.dataThanhToan = new System.Windows.Forms.ComboBox();
            this.btnAccount = new System.Windows.Forms.Button();
            this.imageUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageUser)).BeginInit();
            this.SuspendLayout();
            // 
            // textThanhToan
            // 
            this.textThanhToan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.textThanhToan.Location = new System.Drawing.Point(44, 134);
            this.textThanhToan.Margin = new System.Windows.Forms.Padding(0, 8, 0, 4);
            this.textThanhToan.Name = "textThanhToan";
            this.textThanhToan.Size = new System.Drawing.Size(224, 33);
            this.textThanhToan.TabIndex = 5;
            this.textThanhToan.Text = "Hình thức thanh toán";
            // 
            // titleDatLich
            // 
            this.titleDatLich.BackColor = System.Drawing.Color.White;
            this.titleDatLich.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.titleDatLich.ForeColor = System.Drawing.Color.SeaGreen;
            this.titleDatLich.Location = new System.Drawing.Point(44, 39);
            this.titleDatLich.Margin = new System.Windows.Forms.Padding(36, 32, 36, 32);
            this.titleDatLich.Name = "titleDatLich";
            this.titleDatLich.Size = new System.Drawing.Size(840, 80);
            this.titleDatLich.TabIndex = 4;
            this.titleDatLich.Text = "Đặt lịch khám";
            this.titleDatLich.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageCheck
            // 
            this.imageCheck.Enabled = false;
            this.imageCheck.Location = new System.Drawing.Point(415, 194);
            this.imageCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imageCheck.Name = "imageCheck";
            this.imageCheck.Size = new System.Drawing.Size(40, 26);
            this.imageCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageCheck.TabIndex = 25;
            this.imageCheck.TabStop = false;
            // 
            // textErrorThanhToan
            // 
            this.textErrorThanhToan.AutoSize = true;
            this.textErrorThanhToan.ForeColor = System.Drawing.Color.Red;
            this.textErrorThanhToan.Location = new System.Drawing.Point(44, 166);
            this.textErrorThanhToan.Margin = new System.Windows.Forms.Padding(0);
            this.textErrorThanhToan.Name = "textErrorThanhToan";
            this.textErrorThanhToan.Size = new System.Drawing.Size(255, 20);
            this.textErrorThanhToan.TabIndex = 24;
            this.textErrorThanhToan.Text = "Vui lòng chọn hình thức thanh toán";
            this.textErrorThanhToan.Visible = false;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(188)))), ((int)(((byte)(66)))));
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(371, 592);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(9, 8, 9, 16);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(175, 47);
            this.btnThanhToan.TabIndex = 23;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // dataThanhToan
            // 
            this.dataThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataThanhToan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataThanhToan.FormattingEnabled = true;
            this.dataThanhToan.Location = new System.Drawing.Point(44, 194);
            this.dataThanhToan.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.dataThanhToan.Name = "dataThanhToan";
            this.dataThanhToan.Size = new System.Drawing.Size(368, 28);
            this.dataThanhToan.Sorted = true;
            this.dataThanhToan.TabIndex = 22;
            this.dataThanhToan.TextChanged += new System.EventHandler(this.dataThanhToan_TextChanged);
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
            this.btnAccount.Location = new System.Drawing.Point(742, 15);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(0, 8, 9, 0);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(175, 56);
            this.btnAccount.TabIndex = 26;
            this.btnAccount.Text = "0962214534";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccount.UseVisualStyleBackColor = false;
            // 
            // imageUser
            // 
            this.imageUser.Image = global::QLBenhVienDaLieu.Properties.Resources._9;
            this.imageUser.Location = new System.Drawing.Point(742, 15);
            this.imageUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imageUser.Name = "imageUser";
            this.imageUser.Size = new System.Drawing.Size(51, 56);
            this.imageUser.TabIndex = 27;
            this.imageUser.TabStop = false;
            // 
            // DatLichKhamThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 680);
            this.Controls.Add(this.imageUser);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.imageCheck);
            this.Controls.Add(this.textErrorThanhToan);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.dataThanhToan);
            this.Controls.Add(this.textThanhToan);
            this.Controls.Add(this.titleDatLich);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DatLichKhamThanhToan";
            this.Text = "DatLichKhamThanhToan_cs";
            this.Resize += new System.EventHandler(this.DatLichKhamThanhToan_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.imageCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label textThanhToan;
        private Label titleDatLich;
        private PictureBox imageCheck;
        private Label textErrorThanhToan;
        private Button btnThanhToan;
        private ComboBox dataThanhToan;
        private Button btnAccount;
        private PictureBox imageUser;
    }
}