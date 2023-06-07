using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_PhongMachTu
{
    public partial class frmQuanLyCachDung : Form
    {
        public frmQuanLyCachDung()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Close();
        }
    }
}
