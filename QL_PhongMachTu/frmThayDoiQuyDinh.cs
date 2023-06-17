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
    public partial class frmThayDoiQuyDinh : Form
    {
        public frmThayDoiQuyDinh()
        {
            InitializeComponent();
            getaAllThamSo();
        }

        public bool CheckData_Nhap()
        {
            if (String.IsNullOrEmpty(txtTenThamSo.Text.Trim()) || String.IsNullOrEmpty(txtGiaTri.Text.Trim()))
                return true;
            return false;
        }

        public void CheckData_SQL(SqlConnection con, SqlCommand cmd, int code)
        {

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.CommandText = "spCheckThamSo";
            cmd.Parameters.AddWithValue("@TenThamSo", txtTenThamSo.Text.Trim());
            cmd.Parameters.AddWithValue("@GiaTri", txtGiaTri.Text.Trim());
            object result = cmd.ExecuteScalar();
            code = Convert.ToInt32(result);

        }

        public bool checkValue()
        {
            int value;
            bool check = int.TryParse(txtGiaTri.Text.Trim(), out value);
            if (check == false || value <= 0)
            {
                errorProvider.SetError(txtGiaTri, "Giá trị không hợp lệ");
                return false;
            }

            return true;
        }

        public void getaAllThamSo()
        {
            SqlConnection con = Connection.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spGetAllThamSo";
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            dtvQuyDinh.DataSource = dt;
        }

        private void dtvQuyDinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenThamSo.Text = dtvQuyDinh.CurrentRow.Cells[0].Value.ToString();
            txtGiaTri.Text = dtvQuyDinh.CurrentRow.Cells[1].Value.ToString();
        }        
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!checkValue())
            {
                MessageBox.Show("Thông tin vừa nhập không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    DialogResult res = MessageBox.Show("Bạn có muốn sửa tham số này không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandText = "spSuaThamSo";
                        cmd.Parameters.AddWithValue("@TenThamSo", txtTenThamSo.Text.Trim());
                        cmd.Parameters.AddWithValue("@GiaTri", Convert.ToInt32(txtGiaTri.Text.Trim()));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getaAllThamSo();
                        txtTenThamSo.Text = "";
                        txtGiaTri.Text = "";
                        txtTenThamSo.Focus();
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGiaTri_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtGiaTri, null);
        }
    }
}
