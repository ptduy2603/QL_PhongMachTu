using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_PhongMachTu
{
    public partial class frmLoaiBenh : Form
    {
        public frmLoaiBenh()
        {
            InitializeComponent();
            getAllLoaiBenh();
            txtMaLoaiBenh.Text = LoaiBenh.getAutoId();
            txtMaLoaiBenh.PlaceholderText = LoaiBenh.getAutoId();
            txtTenLoaiBenh.Focus();
        }

        public void getAllLoaiBenh()
        {
            SqlConnection con = Connection.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spGetAllLoaiBenh";
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            dtvLoaiBenh.DataSource = dt;
        }

        public bool CheckData_Nhap()
        {
            if (String.IsNullOrEmpty(txtMaLoaiBenh.Text.Trim()) || String.IsNullOrEmpty(txtTenLoaiBenh.Text.Trim()))
                return true;
            return false;
        }

        public void CheckData_SQL(SqlConnection con, SqlCommand cmd, int code)
        {

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.CommandText = "spCheckLoaiBenh";
            cmd.Parameters.AddWithValue("@MaLoaiBenh", txtMaLoaiBenh.Text.Trim());
            cmd.Parameters.AddWithValue("@TenLoaiBenh", txtTenLoaiBenh.Text.Trim());
            object result = cmd.ExecuteScalar();
            code = Convert.ToInt32(result);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckData_Nhap())
            {
                MessageBox.Show("Thông tin vừa nhập không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenLoaiBenh.Text = "";
                txtMaLoaiBenh.Text = LoaiBenh.getAutoId();
                txtMaLoaiBenh.PlaceholderText = LoaiBenh.getAutoId();
                txtTenLoaiBenh.Focus();
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
                    cmd.CommandText = "spAddLoaiBenh";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@MaLoaiBenh", txtMaLoaiBenh.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenLoaiBenh", txtTenLoaiBenh.Text.Trim());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm loại bệnh thành công", "Thông báo", MessageBoxButtons.OK);
                    //cập nhật lại list loại bệnh
                    getAllLoaiBenh();
                    txtMaLoaiBenh.Text = LoaiBenh.getAutoId();
                    txtMaLoaiBenh.PlaceholderText = LoaiBenh.getAutoId();
                    txtTenLoaiBenh.Text = "";
                    txtTenLoaiBenh.Focus();
                }
                catch
                {
                    MessageBox.Show("Đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaLoaiBenh.Text = LoaiBenh.getAutoId();
                    txtMaLoaiBenh.PlaceholderText = LoaiBenh.getAutoId();
                    txtTenLoaiBenh.Text = "";
                    txtTenLoaiBenh.Focus();
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void dtvLoaiBenh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLoaiBenh.Text = dtvLoaiBenh.CurrentRow.Cells[0].Value.ToString();
            txtTenLoaiBenh.Text = dtvLoaiBenh.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (CheckData_Nhap())
            {
                MessageBox.Show("Vui lòng chọn loại bệnh cần xóa!", "Thông báo", MessageBoxButtons.OK);
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
                    DialogResult res = MessageBox.Show("Bạn có muốn xóa loại bệnh này không", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandText = "spDeleteLoaiBenh";
                        cmd.Parameters.AddWithValue("@MaLoaiBenh", txtMaLoaiBenh.Text.Trim());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getAllLoaiBenh();
                        txtMaLoaiBenh.Text = LoaiBenh.getAutoId();
                        txtMaLoaiBenh.PlaceholderText = LoaiBenh.getAutoId();
                        txtTenLoaiBenh.Text = "";
                        txtTenLoaiBenh.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Loại bệnh này không thể xóa!", "Thông báo", MessageBoxButtons.OK);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckData_Nhap())
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin để sửa loại bệnh!", "Thông báo", MessageBoxButtons.OK);
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
                    DialogResult res = MessageBox.Show("Bạn có muốn sửa loại bệnh này không", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandText = "spSuaLoaiBenh";
                        cmd.Parameters.AddWithValue("@MaLoaiBenh", txtMaLoaiBenh.Text.Trim());
                        cmd.Parameters.AddWithValue("@TenLoaiBenh", txtTenLoaiBenh.Text.Trim());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getAllLoaiBenh();
                        txtMaLoaiBenh.Text = LoaiBenh.getAutoId();
                        txtMaLoaiBenh.PlaceholderText = LoaiBenh.getAutoId();
                        txtTenLoaiBenh.Text = "";
                        txtTenLoaiBenh.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tên loại bệnh đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTenLoaiBenh.Text = "";
            txtMaLoaiBenh.Text = LoaiBenh.getAutoId();
            txtTenLoaiBenh.Focus();
        }
    }
}
