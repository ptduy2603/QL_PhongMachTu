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
    public partial class frmQuanLyThuoc : Form
    {
        public frmQuanLyThuoc()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void frmQuanLyThuoc_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Close();
        }
    }
}
