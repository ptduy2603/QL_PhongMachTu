using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_PhongMachTu
{
    public partial class frmLapPhieuKham : Form
    {
        public frmLapPhieuKham()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        // sự kiện vừa load form
        private void frmLapPhieuKham_Load(object sender, EventArgs e)
        {
            loadDataLoaiBenh();
            loadDataPatient();
            loadDataLoaiThuoc();
            UpdateDonViCachDung();
            txtTrieuChung.Focus();
            txtMaPhieuKham.PlaceholderText = PhieuKham.getAutoId();
            txtMaPhieuKham.Text = PhieuKham.getAutoId();
        }

        // viết function lấy danh sách bệnh nhân đổ vào datagrid view 
        public void loadDataPatient()
        {
            SqlConnection con = Connection.getConnection();
            con.Open();

            SqlCommand cmd = new SqlCommand()
            {
                CommandType = CommandType.StoredProcedure,
                Connection = con,
                CommandText = "spGetPatientWithNgayKham",
            };

            cmd.Parameters.AddWithValue("@NgayKham", dtpNgayKham.Value);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvDanhSachBenhNhan.DataSource = dt;
            dgvDanhSachBenhNhan.Columns[0].HeaderText = "Mã Bệnh Nhân";
            dgvDanhSachBenhNhan.Columns[1].HeaderText = "Họ Tên";
            dgvDanhSachBenhNhan.Columns[1].Width = 150;
            dgvDanhSachBenhNhan.Columns[2].HeaderText = "Giới Tính";
            dgvDanhSachBenhNhan.Columns[2].Width = 50;
            dgvDanhSachBenhNhan.Columns[3].HeaderText = "Năm Sinh";
            dgvDanhSachBenhNhan.Columns[4].HeaderText = "Địa Chỉ";
            // xóa lựa chọn default mặc định
            dgvDanhSachBenhNhan.ClearSelection();
        }

        // Hàm lấy data loại bệnh để đổ vào loại bệnh
        public void loadDataLoaiBenh()
        {
            SqlConnection con = Connection.getConnection();
            con.Open();
            string sql = "select * from LOAIBENH";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboLoaiBenh.DataSource = dt;
            cboLoaiBenh.DisplayMember = "TenLB";
            cboLoaiBenh.ValueMember = "MaLB";
            con.Close();
        }

        // Hàm lấy data loại thuốc đổ vào cboLoaithuoc
        public void loadDataLoaiThuoc()
        {
            SqlConnection con = Connection.getConnection();
            con.Open();
            string sql = "select * from LOAITHUOC";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboTenThuoc.DataSource = dt;
            cboTenThuoc.DisplayMember = "TenLT";
            cboTenThuoc.ValueMember = "MaLT";
            con.Close();
        }

        // viết hàm reset lại data của bảng lập phiếu khám 
        public void resetData()
        {
            txtHoTen.Text = "";
            txtMaBenhNhan.Text = "";
            txtNamSinh.Text = "";
            txtGioiTinh.Text = "";
            txtDiaChi.Text = "";
            txtTrieuChung.Text = "";
            txtMaPhieuKham.Text = PhieuKham.getAutoId();
            txtMaPhieuKham.PlaceholderText = PhieuKham.getAutoId();
            cboLoaiBenh.SelectedIndex = 0;
            cboTenThuoc.SelectedIndex = 0;
            // cập nhật lại thời gian hiện tại
            DateTime dt = DateTime.Now;
            dtpNgayKham.Value = dt;

            //cboTenThuoc.SelectedIndex = 0;
            nudSoLuong.Value = 0;

            // xóa toàn bộ bảng kê thuốc cũ
            dgvToaThuoc.Rows.Clear();

        }

        // viết hàm cập nhật dữ liệu đơn vị và cách dùng khi ta thay đổi tên loại thuốc
        public void UpdateDonViCachDung()
        {
            SqlConnection con = Connection.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = con,
                CommandText = "spTimDonViCachDungTheoThuoc",
                CommandType = CommandType.StoredProcedure,
            };
            cmd.Parameters.AddWithValue("@MaLT", cboTenThuoc.SelectedValue.ToString());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                txtDonVi.Text = Convert.ToString(dt.Rows[0]["TenDV"]);
                txtCachDung.Text = Convert.ToString(dt.Rows[0]["TenCD"]);
            }
            con.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc muốn thoát không?", "Hỏi thoát", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                // chuyển hướng về from main
                frmMain fMain = new frmMain();
                fMain.Show();
                this.Close();
            }    
        }        

        private void dgvDanhSachBenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // khi nhấn vào một bệnh nhân thì thông tin của bệnh nhân được đổ vào vùng data bệnh nhân
            txtMaBenhNhan.Text = dgvDanhSachBenhNhan.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = dgvDanhSachBenhNhan.CurrentRow.Cells[1].Value.ToString();
            txtGioiTinh.Text = dgvDanhSachBenhNhan.CurrentRow.Cells[2].Value.ToString();
            txtNamSinh.Text = dgvDanhSachBenhNhan.CurrentRow.Cells[3].Value.ToString();
            txtDiaChi.Text = dgvDanhSachBenhNhan.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetData();
        }

        // Khi chọn một loại thuốc thì đơn vị và cách dùng của loại thuốc đó sẽ được tự động cập nhật
        private void cboTenThuoc_TextChanged(object sender, EventArgs e)
        {
            UpdateDonViCachDung();
        }

        private void dtpNgayKham_ValueChanged(object sender, EventArgs e)
        {
            // mỗi khi đổi sang ngày khám khác phải load lại danh sách bệnh nhân cần khám 
            loadDataPatient();
        }
    }
}
