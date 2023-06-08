using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QL_PhongMachTu
{
    public partial class frmQuanLyTaiKhoan : Form
    {
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        //hàm đọc danh sách các tài khoản từ database và đổ vào grid view
        public void getAllAccount()
        {
            SqlConnection con = Connection.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spGetAllAccount";
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            dvwDanhSachTaiKhoan.DataSource = dt;
        }

        // hàm lấy các loại tài khoản đổ vào combobox tài khoản tài khoản
        public void getAllAccountType()
        {
            SqlConnection con = Connection.getConnection();
            con.Open();
            string sql = "select TenNhom from NHOMNGUOIDUNG";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            var dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cboLoaiTaiKhoan.DisplayMember = "TenNhom";
            cboLoaiTaiKhoan.DataSource = dt;
            con.Close();
        }

        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            getAllAccountType();
            getAllAccount();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Hỏi thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void dvwDanhSachTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // lấy trường tên đăng nhập của dòng được người dùng lựa chọn
            txtTenDangNhap.Text = dvwDanhSachTaiKhoan.CurrentRow.Cells[0].Value.ToString();
            txtMatKhau.Text = dvwDanhSachTaiKhoan.CurrentRow.Cells[1].Value.ToString();
            cboLoaiTaiKhoan.Text = dvwDanhSachTaiKhoan.CurrentRow.Cells[2].Value.ToString();
        }

        private void dvwDanhSachTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // lấy trường tên đăng nhập của dòng được người dùng lựa chọn
            txtTenDangNhap.Text = dvwDanhSachTaiKhoan.CurrentRow.Cells[0].Value.ToString();
            txtMatKhau.Text = dvwDanhSachTaiKhoan.CurrentRow.Cells[1].Value.ToString();
            cboLoaiTaiKhoan.Text = dvwDanhSachTaiKhoan.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtTenDangNhap.Text.Trim()) || String.IsNullOrEmpty(txtMatKhau.Text.Trim()))
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDangNhap.Text = "";
                txtMatKhau.Text = "";
                return;
            }   
            
            // kiểm tra xem tên đăng nhập đã tồn tại trong database chưa
            SqlConnection con = Connection.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.CommandText = "spCheckUserName";
            cmd.Parameters.AddWithValue("@TenDangNhap", txtTenDangNhap.Text.Trim());

            object result = cmd.ExecuteScalar();

            int code = Convert.ToInt32(result);
            if (code == 1) // tên đăng nhập đã tồn tại
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDangNhap.Text = "";
                txtMatKhau.Text = "";
                txtTenDangNhap.Focus();
                cboLoaiTaiKhoan.Text = "admin";                
            }
            else // trường hợp tạo mới tài khoản thành công
            {
                cmd.CommandText = "spAddNewAccount";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@TenDangNhap", txtTenDangNhap.Text.Trim());
                cmd.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text.Trim());
                cmd.Parameters.AddWithValue("@MaNhom", cboLoaiTaiKhoan.SelectedIndex + 1);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công tài khoản \"" + txtTenDangNhap.Text.Trim() + "\"", "Thông báo", MessageBoxButtons.OK);
                // cập nhật lại list tài khoản
                getAllAccount();
                txtTenDangNhap.Text = "";
                txtMatKhau.Text = "";
                txtTenDangNhap.Focus();
                cboLoaiTaiKhoan.Text = "admin";
            }
            con.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // check xem người dùng có chọn tài khoản cần xóa chưa
            if(String.IsNullOrEmpty(txtTenDangNhap.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa!", "Thông báo", MessageBoxButtons.OK);
            }    
            else
            {
                // kiểm tra xem tên đăng nhập đã tồn tại trong database chưa
                SqlConnection con = Connection.getConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.CommandText = "spCheckUserName";
                cmd.Parameters.AddWithValue("@TenDangNhap", txtTenDangNhap.Text.Trim());

                object result = cmd.ExecuteScalar();

                int code = Convert.ToInt32(result);
                if (code == 1) // tên đăng nhập đã tồn tại
                {
                    DialogResult res = MessageBox.Show("Bạn có chắc muốn xóa tài khoản này không?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(res == DialogResult.Yes)
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandText = "spDeleteAccount";
                        cmd.Parameters.AddWithValue("@TenDangNhap", txtTenDangNhap.Text.Trim());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getAllAccount();
                        txtTenDangNhap.Text = "";
                        txtMatKhau.Text = "";
                        txtTenDangNhap.Focus();
                        cboLoaiTaiKhoan.Text = "admin";
                    }    
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK);
                }

                con.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtTenDangNhap.Text.Trim()) || String.IsNullOrEmpty(txtMatKhau.Text.Trim()))
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDangNhap.Text = "";
                txtMatKhau.Text = "";
                return;
            }    

            SqlConnection con = Connection.getConnection();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spUpdateAccount";
                cmd.Parameters.AddWithValue("@TenDangNhap", txtTenDangNhap.Text.Trim());
                cmd.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text.Trim());
                cmd.Parameters.AddWithValue("@MaNhom", cboLoaiTaiKhoan.SelectedIndex + 1);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật tài khoản thành công", "Thông báo", MessageBoxButtons.OK);
                getAllAccount();
                txtTenDangNhap.Text = "";
                txtMatKhau.Text = "";
                txtTenDangNhap.Focus();
                cboLoaiTaiKhoan.Text = "admin";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }    
}
