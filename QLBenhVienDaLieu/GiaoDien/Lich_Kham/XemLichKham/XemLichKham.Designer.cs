using System.Drawing;
using System.Windows.Forms;

namespace QLBenhVienDaLieu.GiaoDien.Lich_Kham.XemLichKham
{
    partial class XemLichKham
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.titleXemLich = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.titleXemLich);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(32, 0, 32, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(36, 0, 36, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(937, 670);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // titleXemLich
            // 
            this.titleXemLich.BackColor = System.Drawing.Color.White;
            this.titleXemLich.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.titleXemLich.ForeColor = System.Drawing.Color.SeaGreen;
            this.titleXemLich.Location = new System.Drawing.Point(36, 32);
            this.titleXemLich.Margin = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.titleXemLich.Name = "titleXemLich";
            this.titleXemLich.Size = new System.Drawing.Size(857, 80);
            this.titleXemLich.TabIndex = 1;
            this.titleXemLich.Text = "DANH SÁCH LỊCH KHÁM";
            this.titleXemLich.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // XemLichKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 670);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "XemLichKham";
            this.Text = "XemLichKham";
            this.Resize += new System.EventHandler(this.XemLichKham_Resize);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label titleXemLich;
    }
}