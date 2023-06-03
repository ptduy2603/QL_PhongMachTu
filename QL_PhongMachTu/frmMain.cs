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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // khi load form tùy loại người dùng để ẩn hiện các chức năng 
            // user thường không được dùng chức năng admin + Lập các báo cáo + Thay đổi quy định
            if(TaiKhoan.loaiTaiKhoan == 2)
            {
                tipAdmin.Enabled = false;
                tipLapBaoCao.Enabled = false;
                btnLapBaoCao.Enabled = false;
                btnLapBaoCao.ForeColor = Color.Black;
                btnLapBaoCao.BackColor = Color.LightSlateGray;
            }
            tipTaiKhoan.Text = "Tài Khoản (" + TaiKhoan.tenDangNhap + ")";

        }

        private void tipItemDangXuat_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }
    }
}
