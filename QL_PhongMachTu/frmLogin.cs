using System.Data;
using System.Data.SqlClient;

namespace QL_PhongMachTu
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // đóng toàn bộ chương trình 
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //  sự kiện click vào button đăng nhập 
            SqlConnection con = Connection.getConnection();
            try
            {
                // mở kết nối đến database
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spCheckLogin";
                cmd.Parameters.AddWithValue("@TenDangNhap", txtUsername.Text);
                cmd.Parameters.AddWithValue("@MatKhau", txtPassword.Text);
                cmd.Connection = con;
                // lấy mã trả về từ server
                object result = cmd.ExecuteScalar();    
                int code = Convert.ToInt32(result); 
                // kiểm tra các điều kiện

                if(code == 0) //đăng nhập thành công với quyền admin
                {
                    TaiKhoan.tenDangNhap = txtUsername.Text;
                    TaiKhoan.matKhau = txtPassword.Text;
                    TaiKhoan.loaiTaiKhoan = 1;
                    MessageBox.Show("Đăng nhập thành công với quyền admin", "Thông báo", MessageBoxButtons.OK);
                    // load form main 
                    frmMain frmain = new frmMain();
                    frmain.Show();
                    this.Hide();
                }    
                else if (code == 1) // đăng nhập thành công với quyền user 
                {
                    TaiKhoan.tenDangNhap = txtUsername.Text;
                    TaiKhoan.matKhau = txtPassword.Text;
                    TaiKhoan.loaiTaiKhoan = 2;
                    MessageBox.Show("Đăng nhập thành công với quyền user", "Thông báo", MessageBoxButtons.OK);
                    // load form main giới hạn chức năng
                    frmMain frmain = new frmMain();
                    frmain.Show();
                    this.Hide();
                }    
                else if (code == 2) // sai mật khẩu 
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK);
                    txtPassword.Text = "";
                    txtUsername.Text = "";
                    chkShowPassword.Checked = false;
                    txtUsername.Focus();                   
                }    
                else if(code == 3)
                {
                    MessageBox.Show("Tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK);
                    txtPassword.Text = "";
                    txtUsername.Text = "";
                    chkShowPassword.Checked = false;
                    txtUsername.Focus();
                }               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                // đóng kết nối database
                con.Close();
            }
           

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // nếu trạng thái là checked thì password được show ra 
            if(chkShowPassword.Checked)
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '*';            
        }
    }

}