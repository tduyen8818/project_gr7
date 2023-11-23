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
    public partial class BS_Xoa : Form
    {
        public BS_Xoa()
        {
            InitializeComponent();
        }

        private void BS_Xoa_Load(object sender, EventArgs e)
        {

        }

        public void SetForm(string type)
        {
            switch (type)
            {
                case "skb":

                    break;
                case "ba":

                    break;
            }
        }
    }
}
