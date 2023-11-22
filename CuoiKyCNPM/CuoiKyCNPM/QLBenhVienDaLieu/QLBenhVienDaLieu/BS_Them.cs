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
    public partial class BS_Them : Form
    {
        public BS_Them()
        {
            InitializeComponent();
        }

        private void BS_Them_Load(object sender, EventArgs e)
        {

        }

        public void SetForm(string type, string maHSBN)
        {
            switch (type)
            {
                case "skb":
                    tb_skb_maHSBN.Text = maHSBN;
                    break;
                case "ba":

                    break;
            }
        }

        private void guna2DataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
