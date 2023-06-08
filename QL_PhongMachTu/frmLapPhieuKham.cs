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
    public partial class frmLapPhieuKham : Form
    {
        public frmLapPhieuKham()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        public frmLapPhieuKham(BenhNhan bn)
        {
            InitializeComponent();
            this.ControlBox = false;
            // Đổ thông tin của bệnh nhân vào ô thông tin bệnh nhân
            txtMaBenhNhan.Text = bn.maBenhNhan;
            txtHoTen.Text = bn.tenBenhNhan;
            txtGioiTinh.Text = bn.gioiTinh;
            txtNamSinh.Text = bn.namSinh.ToString();
            txtDiaChi.Text = bn.diaChi;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Close();
        }

    }
}
