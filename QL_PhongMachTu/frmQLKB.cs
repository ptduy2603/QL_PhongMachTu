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
    public partial class frmQLKB : Form
    {
        public frmQLKB()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmThemTTBenhNhan themTTBenhNhan = new frmThemTTBenhNhan();
            themTTBenhNhan.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLapPhieuKham lapPhieuKham = new frmLapPhieuKham();
            lapPhieuKham.Show();
            this.Close();
        }

        private void btnXemLoaiBenh_Click(object sender, EventArgs e)
        {
            frmLoaiBenh fLoaiBenh = new frmLoaiBenh();
            fLoaiBenh.ShowDialog();            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmTraCuuBenhNhan fTraCuu = new frmTraCuuBenhNhan();
            fTraCuu.Show();
            this.Close();
        }
    }
}
