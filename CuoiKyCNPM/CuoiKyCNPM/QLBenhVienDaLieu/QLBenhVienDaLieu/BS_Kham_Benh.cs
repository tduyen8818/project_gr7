using QLBenhVienDaLieu.Database.Function;
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

        private void SelectedValue(object sender, EventArgs e)
        {
            if(cb_caKham.SelectedIndex != -1)
            {
                string ngay = dt_ngayKham.Value.Date.ToString("yyyy-MM-dd");
                string ca = cb_caKham.SelectedItem.ToString();
                SqlFunctionCaller lichKham = new SqlFunctionCaller();

                try
                {
                    DataTable resultTable = lichKham.CallGetLichKhamByNgayAndCa(ngay, ca);
                    dgv_lichKham.DataSource = resultTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
