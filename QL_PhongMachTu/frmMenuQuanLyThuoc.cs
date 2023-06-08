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
    public partial class frmMenuQuanLyThuoc : Form
    {
        public frmMenuQuanLyThuoc()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void frmMenuQuanLyThuoc_Load(object sender, EventArgs e)
        {

        }

        private void frmMenuQuanLyThuoc_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmQuanLyThuoc QuanLyThuoc = new frmQuanLyThuoc();
            QuanLyThuoc.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmQuanLyDonVi QLDonVi = new frmQuanLyDonVi();
            QLDonVi.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmQuanLyCachDung QLCachDung = new frmQuanLyCachDung();
            QLCachDung.Show();
            this.Close();
        }
    }
}
