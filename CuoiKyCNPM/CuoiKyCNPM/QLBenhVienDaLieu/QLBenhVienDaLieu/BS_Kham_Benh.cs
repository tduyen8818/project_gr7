﻿using QLBenhVienDaLieu.Database.Function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBenhVienDaLieu
{
    public partial class BS_Kham_Benh : Form
    {
        private string sDT;

        public BS_Kham_Benh(string sDT)
        {
            InitializeComponent();
            this.sDT = sDT;
            dt_ngayKham.Value = DateTime.Now;
            dt_ngayKham.MaxDate = dt_ngayKham.Value;
        }

        private void BS_Kham_Benh_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            TaiKhoan_BS taiKhoanForm = new TaiKhoan_BS(sDT);
            this.Hide();
            taiKhoanForm.ShowDialog();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LichLamViec_BS lichLamViec = new LichLamViec_BS(sDT);
            this.Hide();
            lichLamViec.ShowDialog();
            this.Close();
        }
        DataTable resultTable = new DataTable();
        private void SelectedValue(object sender, EventArgs e)
        {
            if (cb_caKham.SelectedIndex != -1)
            {
                string ngay = dt_ngayKham.Value.Date.ToString("yyyy-MM-dd");
                string ca = cb_caKham.SelectedItem.ToString();
                SqlFunctionCaller lichKham = new SqlFunctionCaller();

                try
                {
                    resultTable = lichKham.CallGetLichKhamByNgayAndCa(ngay, ca);
                    dgv_lichKham.DataSource = resultTable;
                    //Change column display size
                    dgv_lichKham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    dgv_lichKham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void BS_Kham_Benh_Resize(object sender, EventArgs e)
        {
            //Change column display size
            int lastCol = resultTable.Columns.Count;
            if (this.WindowState == FormWindowState.Maximized)
            {
                dgv_lichKham.Columns[lastCol - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
            {
                dgv_lichKham.Columns[lastCol - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }

        private void dgv_lichKham_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_lichKham.Rows[e.RowIndex];
                string maHoSoBenhNhan = selectedRow.Cells["MaHoSoBenhNhan"].Value.ToString();

                // Open the second form and call the method to pass the data
                BS_Kham_Benh_2 hsbn = new BS_Kham_Benh_2();
                hsbn.SetMaHoSoBenhNhan(maHoSoBenhNhan, this.WindowState);
                hsbn.Show();
            }

        }
    }
}
