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
    public partial class frmQuanLyDonVi : Form
    {
        public frmQuanLyDonVi()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void frmQuanLyDonVi_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaDonVi.Text.Trim()) || String.IsNullOrEmpty(txtTenDonVi.Text.Trim())) 
            {
                MessageBox.Show("Thông tin vừa nhập không hợp lệ!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            object result = cmd.ExecuteScalar();

            int code = Convert.ToInt32(result);

            if(code == 1)
            {
                MessageBox.Show("Đã tồn tại!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtMaDonVi.Text = "";
                txtTenDonVi.Text = "";
                txtMaDonVi.Focus();
            }
            else
            {
                cmd.CommandText = "spAddDonVi";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@MaDonVi", txtMaDonVi.Text.Trim());
                cmd.Parameters.AddWithValue("@TenDonVi",txtTenDonVi.Text.Trim());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm đơn vị thành công","Thông báo",)
            }
        }
    }
}
