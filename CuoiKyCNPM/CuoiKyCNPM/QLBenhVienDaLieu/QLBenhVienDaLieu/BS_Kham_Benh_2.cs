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
    public partial class BS_Kham_Benh_2 : Form
    {
        public BS_Kham_Benh_2()
        {
            InitializeComponent();
        }
        DataTable resultTable = new DataTable();
        public void SetMaHoSoBenhNhan(string maHoSoBenhNhan, FormWindowState state)
        {
            this.WindowState = state;
            SqlFunctionCaller funcCall = new SqlFunctionCaller();

            try
            {
                resultTable = funcCall.CallGetHoSoBenhNhan(maHoSoBenhNhan);
                //dgv_lichKham.DataSource = resultTable;
                ////Change column display size
                //dgv_lichKham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                //dgv_lichKham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void BS_Kham_Benh_2_Load(object sender, EventArgs e)
        {

        }

        private void dgv_lichKham_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_lichKham.Rows[e.RowIndex];
                string cellValue = selectedRow.Cells["ColumnName"].Value.ToString();

            }
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BS_Kham_Benh_2_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
