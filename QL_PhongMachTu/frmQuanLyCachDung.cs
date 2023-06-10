using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
            getAllCachDung();
            txtMaCachDung.Focus();
        }

        public void getAllCachDung()
        {
            SqlConnection con = Connection.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spGetAllCachDung";
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            dvwDanhSachCachDung.DataSource = dt;
        }
        public bool CheckData_Nhap(int n)
        {
            if (n == 0 && (String.IsNullOrEmpty(txtMaCachDung.Text.Trim()) || String.IsNullOrEmpty(txtTenCachDung.Text.Trim())))
                return true;
            return false;

        }

        public void CheckData_SQL(SqlConnection con, SqlCommand cmd, int code)
        {

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.CommandText = "spCheckCachDung";
            cmd.Parameters.AddWithValue("@MaCachDung", txtMaCachDung.Text.Trim());
            cmd.Parameters.AddWithValue("@TenCachDung", txtTenCachDung.Text.Trim());
            object result = cmd.ExecuteScalar();
            code = Convert.ToInt32(result);

        }
     
        private void btnThoat_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckData_Nhap(0))
            {
                MessageBox.Show("Thông tin vừa nhập không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaCachDung.Text = "";
                txtTenCachDung.Text = "";
                txtMaCachDung.Focus();
                return;
            }
            else
            {
                SqlConnection con = Connection.getConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                int code = 0;
                CheckData_SQL(con, cmd, code);

                try
                {
                    cmd.CommandText = "spAddCachDung";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@MaCachDung", txtMaCachDung.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenCachDung", txtTenCachDung.Text.Trim());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm đơn vị thành công", "Thông báo", MessageBoxButtons.OK);
                    //cập nhật lại list Đơn vị
                    getAllCachDung();
                    txtMaCachDung.Text = "";
                    txtTenCachDung.Text = "";
                    txtMaCachDung.Focus();
                }
                catch
                {
                    MessageBox.Show("Đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaCachDung.Text = "";
                    txtTenCachDung.Text = "";
                    txtMaCachDung.Focus();
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckData_Nhap(0))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin để sửa cách dùng!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                SqlConnection con = Connection.getConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                int code = 0;
                CheckData_SQL(con, cmd, code);
                try
                {
                    DialogResult res = MessageBox.Show("Bạn có muốn sửa cách dùng này không", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandText = "spSuaCachDung";
                        cmd.Parameters.AddWithValue("@MaCachDung", txtMaCachDung.Text.Trim());
                        cmd.Parameters.AddWithValue("@TenCachDung", txtTenCachDung.Text.Trim());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getAllCachDung();
                        txtMaCachDung.Text = "";
                        txtTenCachDung.Text = "";
                        txtMaCachDung.Focus();
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


        private void dvwDanhSachCachDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCachDung.Text = dvwDanhSachCachDung.CurrentRow.Cells[0].Value.ToString();
            txtTenCachDung.Text = dvwDanhSachCachDung.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Check xem người dùng có chọn đơn vị cần xóa chưa
            if (String.IsNullOrEmpty(txtMaCachDung.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn cách dùng để xóa!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                SqlConnection con = Connection.getConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                int code = 0;
                CheckData_SQL(con, cmd, code);
                try
                {
                    DialogResult res = MessageBox.Show("Bạn có muốn xóa đơn vị này không", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandText = "spDeleteCachDung";
                        cmd.Parameters.AddWithValue("@MaCachDung", txtMaCachDung.Text.Trim());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getAllCachDung();
                        txtMaCachDung.Text = "";
                        txtTenCachDung.Text = "";
                        txtMaCachDung.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Cách Dùng không thể xóa!", "Thông báo", MessageBoxButtons.OK);
                }
                finally
                {
                    con.Close();
                }
            }
        }

    }
}

