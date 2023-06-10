using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_PhongMachTu
{
    public partial class frmQuanLyDonVi : Form
    {
        public frmQuanLyDonVi()
        {
            InitializeComponent();
            this.ControlBox = false;
            getAllDonVi();
            txtMaDonVi.Focus();
        }
        public void getAllDonVi()
        {
            SqlConnection con = Connection.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spGetAllDonVi";
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            dvwDanhSachDonVi.DataSource = dt;
        }      

        private void btnThoat_Click(object sender, EventArgs e)
        {
              this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaDonVi.Text.Trim()) || String.IsNullOrEmpty(txtTenDonVi.Text.Trim()))
            {
                MessageBox.Show("Thông tin vừa nhập không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaDonVi.Text = "";
                txtTenDonVi.Text = "";
                return;
            }

            //Kiểm tra xem đơn vị đã tồn tại trong database chưa
            SqlConnection con = Connection.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.CommandText = "spCheckDonVi";
            cmd.Parameters.AddWithValue("@MaDonVi", txtMaDonVi.Text.Trim());
            cmd.Parameters.AddWithValue("@TenDonVi", txtTenDonVi.Text.Trim());
            object result = cmd.ExecuteScalar();

            int code = Convert.ToInt32(result);

            if (code == 1)
            {
                MessageBox.Show("Đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaDonVi.Text = "";
                txtTenDonVi.Text = "";
                txtMaDonVi.Focus();
            }
            else
            {
                cmd.CommandText = "spAddDonVi";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@MaDonVi", txtMaDonVi.Text.Trim());
                cmd.Parameters.AddWithValue("@TenDonVi", txtTenDonVi.Text.Trim());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm đơn vị thành công", "Thông báo", MessageBoxButtons.OK);
                //cập nhật lại list Đơn vị
                getAllDonVi();
                txtMaDonVi.Text = "";
                txtTenDonVi.Text = "";
                txtMaDonVi.Focus();
            }
            con.Close();
        }              

        private void btnXoa_Click(object sender, EventArgs e)
        {

            //Check xem người dùng có chọn đơn vị cần xóa chưa
            if (String.IsNullOrEmpty(txtMaDonVi.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn đơn vị để xóa!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                SqlConnection con = Connection.getConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                try
                {
                    DialogResult res = MessageBox.Show("Bạn có muốn xóa đơn vị này không", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandText = "spDeleteDonVi";
                        cmd.Parameters.AddWithValue("@MaDonVi", txtMaDonVi.Text.Trim());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getAllDonVi();
                        txtMaDonVi.Text = "";
                        txtTenDonVi.Text = "";
                        txtMaDonVi.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Đơn vị không thể xóa!", "Thông báo", MessageBoxButtons.OK);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void dvwDanhSachTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDonVi.Text = dvwDanhSachDonVi.CurrentRow.Cells[0].Value.ToString();
            txtTenDonVi.Text = dvwDanhSachDonVi.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Check xem người dùng có chọn đơn vị cần sửa chưa
            if (String.IsNullOrEmpty(txtMaDonVi.Text.Trim()) || String.IsNullOrEmpty(txtTenDonVi.Text.Trim()))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin để sửa đơn vị!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                SqlConnection con = Connection.getConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                try
                {
                    DialogResult res = MessageBox.Show("Bạn có muốn sửa đơn vị này không", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandText = "spSuaDonVi";
                        cmd.Parameters.AddWithValue("@MaDonVi", txtMaDonVi.Text.Trim());
                        cmd.Parameters.AddWithValue("@TenDonVi", txtTenDonVi.Text.Trim());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getAllDonVi();
                        txtMaDonVi.Text = "";
                        txtTenDonVi.Text = "";
                        txtMaDonVi.Focus();
                    }
                }
                catch (Exception ex)
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
}
