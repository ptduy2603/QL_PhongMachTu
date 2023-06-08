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
    public partial class frmThayDoiThongTin : Form
    {
        public frmThayDoiThongTin()
        {
            InitializeComponent();
        }
        private void frmThayDoiThongTin_Load(object sender, EventArgs e)
        {
             txtTenDangNhap.Text = TaiKhoan.tenDangNhap;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Hỏi thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }
        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtMatKhau, null);
        }
        private void txtMatKhauMoi_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtMatKhauMoi, null);
        }
        private void txtXacNhanMatKhau_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtXacNhanMatKhau, null);
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            // code các logic cho việc thay đổi tên đăng nhập và mật khẩu của tài khoản hiện tại
            if(String.IsNullOrEmpty(txtMatKhau.Text.Trim()))
            {
                txtMatKhau.Focus();
                errorProvider.SetError(txtMatKhau, "Vui lòng nhập mật khẩu cũ");
            } 
            else
            {
                string matKhauMoi = "";
                if(txtMatKhau.Text.Trim() == TaiKhoan.matKhau) // nhập chính xác mật khẩu cũ
                {                                        
                    //  kiểm tra việc xác nhận mật khẩu và thay đổi biến mật khẩu
                    if(String.IsNullOrEmpty(txtMatKhauMoi.Text.Trim()))
                        matKhauMoi = TaiKhoan.matKhau; 
                    else
                    {
                        // có nhập mật khẩu mới
                        if(txtXacNhanMatKhau.Text.Trim() != txtMatKhauMoi.Text.Trim())
                        {
                            errorProvider.SetError(txtXacNhanMatKhau, "Vui lòng nhập đúng mật khẩu mới");
                            return;
                        }  
                        else
                        {
                            matKhauMoi = txtXacNhanMatKhau.Text.Trim();
                        }
                    }

                    // kiểm tra điều mọi điều kiện xong tiến hành kết nối để cập nhật tài khoản vào database
                    SqlConnection con = Connection.getConnection();
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "spChangeAccountByUser";
                        cmd.Parameters.AddWithValue("@TenDangNhap", TaiKhoan.tenDangNhap);
                        cmd.Parameters.AddWithValue("@MatKhauMoi", matKhauMoi);
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();
                        // cập nhật mật khẩu mới
                        TaiKhoan.matKhau = matKhauMoi;
                        MessageBox.Show("Cập nhật thay đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Refresh lại các trường dữ liệu
                        txtMatKhau.Text = "";
                        txtMatKhauMoi.Text = "";
                        txtXacNhanMatKhau.Text = "";
                        txtMatKhau.Focus();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Báo lỗi", MessageBoxButtons.OK , MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                    
                }    
                else
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhau.Text = "";
                    txtMatKhauMoi.Text = "";
                    txtXacNhanMatKhau.Text = "";
                    txtMatKhau.Focus();
                }
            }
        }

    }
}
