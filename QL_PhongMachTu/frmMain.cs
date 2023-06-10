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
            this.ControlBox = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // khi load form tùy loại người dùng để ẩn hiện các chức năng 
            // user thường không được dùng chức năng admin + Lập các báo cáo + Thay đổi quy định
            if (TaiKhoan.loaiTaiKhoan == 2)
            {
                tipAdmin.Enabled = false;
                tipLapBaoCao.Enabled = false;
                btnLapBaoCao.Enabled = false;
                btnLapBaoCao.ForeColor = Color.Black;
                btnLapBaoCao.BackColor = Color.LightSlateGray;
            }
            tipTaiKhoan.Text = "Tài Khoản (" + TaiKhoan.tenDangNhap.Trim() + ")";
        }

        private void tipItemDangXuat_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }

        private void tipItemThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thật sự muốn thoát không?", "Hỏi thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
                Application.Exit();
            }
        }

        private void thayĐổiThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThayDoiThongTin fThayDoiThongTin = new frmThayDoiThongTin();
            fThayDoiThongTin.ShowDialog();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyTaiKhoan fQuanLyTaiKhoan = new frmQuanLyTaiKhoan();
            fQuanLyTaiKhoan.ShowDialog();
        }

        private void btnQLKhamBenh_Click(object sender, EventArgs e)
        {
            frmQLKB QLKB = new frmQLKB();
            QLKB.Show();
            this.Hide();
        }

        private void btnQLThuoc_Click(object sender, EventArgs e)
        {
            frmMenuQuanLyThuoc MenuQLT = new frmMenuQuanLyThuoc();
            MenuQLT.Show();
            this.Hide();
        }

        private void xemThôngTinThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyThuoc QLThuoc = new frmQuanLyThuoc();
            QLThuoc.Show();
            this.Close();
        }

        private void xemThôngTinĐơnVịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyDonVi QLDonVi = new frmQuanLyDonVi();
            QLDonVi.ShowDialog();           
        }

        private void xemThôngTinCáchDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyCachDung QLCachDung = new frmQuanLyCachDung();
            QLCachDung.ShowDialog();
        }

        private void lậpPhiếuKhámBệnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLapPhieuKham lapPhieuKham = new frmLapPhieuKham();
            lapPhieuKham.Show();
            this.Close();
        }

        private void thêmBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThemTTBenhNhan ThemBenhNhan = new frmThemTTBenhNhan();
            ThemBenhNhan.Show();
            this.Close();
        }

        private void thayĐổiQuyĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThayDoiQuyDinh frmThayDoiQuyDinh = new frmThayDoiQuyDinh();
            frmThayDoiQuyDinh.ShowDialog();
            
        }

        private void thôngTinLoạiBệnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoaiBenh fLoaiBenh = new frmLoaiBenh();
            fLoaiBenh.ShowDialog();
        }

        private void lậpPhiếuNhậpThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLapPhieuNhapThuoc fLapPhieuNhapThuoc = new frmLapPhieuNhapThuoc();
            fLapPhieuNhapThuoc.Show();
            this.Close();
        }
    }
}
