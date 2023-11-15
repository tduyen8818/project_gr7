using System.Drawing;
using System.Windows.Forms;

namespace QLBenhVienDaLieu.GiaoDien.BenhNhanTrangUI.LichKhamUI.DatLichKhamUI
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
            this.imageCheck = new System.Windows.Forms.PictureBox();
            this.textErrorThanhToan = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.dataThanhToan = new System.Windows.Forms.ComboBox();
            this.titleDatLich = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // textThanhToan
            // 
            this.textThanhToan.AutoSize = true;
            this.textThanhToan.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.textThanhToan.Location = new System.Drawing.Point(44, 134);
            this.textThanhToan.Margin = new System.Windows.Forms.Padding(0, 8, 0, 4);
            this.textThanhToan.Name = "textThanhToan";
            this.textThanhToan.Size = new System.Drawing.Size(385, 48);
            this.textThanhToan.TabIndex = 5;
            this.textThanhToan.Text = "Hình thức thanh toán";
            // 
            // imageCheck
            // 
            this.imageCheck.Enabled = false;
            this.imageCheck.Location = new System.Drawing.Point(439, 219);
            this.imageCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imageCheck.Name = "imageCheck";
            this.imageCheck.Size = new System.Drawing.Size(40, 33);
            this.imageCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageCheck.TabIndex = 25;
            this.imageCheck.TabStop = false;
            // 
            // textErrorThanhToan
            // 
            this.textErrorThanhToan.AutoSize = true;
            this.textErrorThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textErrorThanhToan.ForeColor = System.Drawing.Color.Red;
            this.textErrorThanhToan.Location = new System.Drawing.Point(47, 186);
            this.textErrorThanhToan.Margin = new System.Windows.Forms.Padding(0);
            this.textErrorThanhToan.Name = "textErrorThanhToan";
            this.textErrorThanhToan.Size = new System.Drawing.Size(312, 25);
            this.textErrorThanhToan.TabIndex = 24;
            this.textErrorThanhToan.Text = "Vui lòng chọn hình thức thanh toán";
            this.textErrorThanhToan.Visible = false;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(188)))), ((int)(((byte)(66)))));
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(541, 866);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(9, 8, 9, 16);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(300, 100);
            this.btnThanhToan.TabIndex = 23;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // dataThanhToan
            // 
            this.dataThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataThanhToan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataThanhToan.FormattingEnabled = true;
            this.dataThanhToan.Location = new System.Drawing.Point(52, 219);
            this.dataThanhToan.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.dataThanhToan.Name = "dataThanhToan";
            this.dataThanhToan.Size = new System.Drawing.Size(368, 33);
            this.dataThanhToan.Sorted = true;
            this.dataThanhToan.TabIndex = 22;
            this.dataThanhToan.TextChanged += new System.EventHandler(this.dataThanhToan_TextChanged);
            // 
            // titleDatLich
            // 
            this.titleDatLich.BackColor = System.Drawing.Color.Transparent;
            this.titleDatLich.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.titleDatLich.ForeColor = System.Drawing.Color.SeaGreen;
            this.titleDatLich.Location = new System.Drawing.Point(47, 41);
            this.titleDatLich.Margin = new System.Windows.Forms.Padding(0, 32, 0, 40);
            this.titleDatLich.Name = "titleDatLich";
            this.titleDatLich.Size = new System.Drawing.Size(1273, 80);
            this.titleDatLich.TabIndex = 27;
            this.titleDatLich.Text = "ĐẶT LỊCH KHÁM";
            this.titleDatLich.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DatLichKhamThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1367, 991);
            this.Controls.Add(this.titleDatLich);
            this.Controls.Add(this.imageCheck);
            this.Controls.Add(this.textErrorThanhToan);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.dataThanhToan);
            this.Controls.Add(this.textThanhToan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DatLichKhamThanhToan";
            this.Text = "DatLichKhamThanhToan_cs";
            this.Resize += new System.EventHandler(this.DatLichKhamThanhToan_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.imageCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label textThanhToan;
        private PictureBox imageCheck;
        private Label textErrorThanhToan;
        private Button btnThanhToan;
        private ComboBox dataThanhToan;
        private Label titleDatLich;
    }
}