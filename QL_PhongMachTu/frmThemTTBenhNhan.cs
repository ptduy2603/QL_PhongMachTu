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
    public partial class frmThemTTBenhNhan : Form
    {
        public frmThemTTBenhNhan()
        {
            InitializeComponent();
            this.ControlBox = false;         
        }

        // hàm lấy data từ database đổ vào danh sách bệnh nhân 
        public void loadDataPatient()
        {
            SqlConnection con = Connection.getConnection();
            con.Open();

            SqlCommand cmd = new SqlCommand()
            {
                CommandType = CommandType.StoredProcedure,
                Connection = con,
                CommandText = "spGetAllPatient",
            };
            
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
            dgvDanhSachBenhNhan.ClearSelection();
        }

        // hàm dùng để reset lại data
        public void resetData()
        {
            txtMaBenhNhan.Text = "";
            txtTenBenhNhan.Text = "";
            txtNamSinh.Text = "";
            txtDiaChi.Text = "";
            chkNam.Checked = false;
            chkNu.Checked = false;
            txtMaBenhNhan.PlaceholderText = BenhNhan.getAutoId();
            txtMaBenhNhan.Text = BenhNhan.getAutoId();
        }

        //hàm kiểm tra validate dữ liệu của các trường dữ liệu
        public bool checkData()
        {
            if(String.IsNullOrEmpty(txtTenBenhNhan.Text.Trim()))
            {
                errorProvider.SetError(txtTenBenhNhan, "Vui lòng nhập tên bệnh nhân");
                return false;
            }

            // nếu nhập số âm + nhập chữ + không nhập gì vào ôn năm sinh
            int namSinh;
            bool check = int.TryParse(txtNamSinh.Text.Trim(), out namSinh);
            if (check == false || namSinh <= 0)
            {
                errorProvider.SetError(txtNamSinh, "Năm sinh không hợp lệ");
                return false;
            }    

            if(String.IsNullOrEmpty(txtDiaChi.Text.Trim()))
            {
                errorProvider.SetError(txtDiaChi, "Vui lòng nhập địa chỉ");
                return false;
            }                
          
            return true;
        }

        private void frmThemTTBenhNhan_Load(object sender, EventArgs e)
        {
            txtMaBenhNhan.PlaceholderText = BenhNhan.getAutoId();
            txtMaBenhNhan.Text = BenhNhan.getAutoId();
            chkNam.Checked = true;
            txtTenBenhNhan.Focus();
            loadDataPatient();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc muốn thoát không?", "Hỏi thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                  frmMain fMain = new frmMain();
                   fMain.Show();
                   this.Hide();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // làm trắng tất cả thông tin 
            resetData();
        }

        private void chkNam_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNam.Checked)
                chkNu.Checked = false;
            else
                chkNu.Checked = true;
        }

        private void chkNu_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNu.Checked)
                chkNam.Checked = false;
            else
                chkNam.Checked = true;
        }

        private void txtTenBenhNhan_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtTenBenhNhan, null);
        }

        private void txtNamSinh_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtNamSinh, null);
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtDiaChi, null);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // sự kiện thêm mới một bệnh nhân
            if(checkData())
            {
                // mọi điều kiện oke tiến hành connect database để thêm bệnh nhân mới 
                SqlConnection con = Connection.getConnection();
                BenhNhan bn = new BenhNhan(txtMaBenhNhan.Text.Trim(), txtTenBenhNhan.Text.Trim(), chkNam.Checked ? "Nam" : "Nu", Convert.ToInt32(txtNamSinh.Text.Trim()), txtDiaChi.Text.Trim());
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand()
                    {
                        Connection = con,
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "spAddPatient",
                    };
                    // gắn các tham số
                    cmd.Parameters.AddWithValue("@MaBN", bn.maBenhNhan);
                    cmd.Parameters.AddWithValue("@HoTen", bn.tenBenhNhan);
                    cmd.Parameters.AddWithValue("@GioiTinh", bn.gioiTinh);
                    cmd.Parameters.AddWithValue("@NamSinh", bn.namSinh);
                    cmd.Parameters.AddWithValue("@DiaChi", bn.diaChi);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm bệnh nhân thành công", "Thông báo", MessageBoxButtons.OK);
                    loadDataPatient();
                    resetData();

                    // sinh mã tự động mới
                    txtMaBenhNhan.PlaceholderText = BenhNhan.getAutoId();
                    txtMaBenhNhan.Text = BenhNhan.getAutoId();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Mã bệnh nhân đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }    
        }

        private void dgvDanhSachBenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // khi nhấn chuột chọn 1 cell thì dữ liệu của nó phải được đổ lên thông tin
            txtMaBenhNhan.Text = dgvDanhSachBenhNhan.CurrentRow.Cells[0].Value.ToString();
            txtTenBenhNhan.Text = dgvDanhSachBenhNhan.CurrentRow.Cells[1].Value.ToString();
            txtNamSinh.Text = dgvDanhSachBenhNhan.CurrentRow.Cells[3].Value.ToString();
            txtDiaChi.Text = dgvDanhSachBenhNhan.CurrentRow.Cells[4].Value.ToString();
            if (dgvDanhSachBenhNhan.CurrentRow.Cells[2].Value.ToString() == "Nam")
                chkNam.Checked = true;
            else
                chkNu.Checked = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // sự kiện xóa bệnh nhân 
            if(String.IsNullOrEmpty(txtMaBenhNhan.Text.Trim()) || txtMaBenhNhan.Text == BenhNhan.getAutoId())
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            else
            {
                SqlConnection con = Connection.getConnection();
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand()
                    {
                        Connection = con,
                        CommandText = "spDeletePatient",
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@MaBN", txtMaBenhNhan.Text.Trim());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa bệnh nhân thành công", "Thông báo", MessageBoxButtons.OK);
                    resetData();
                    txtMaBenhNhan.Text = BenhNhan.getAutoId();
                    loadDataPatient();
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            // sự kiện chỉnh sử thông tin bệnh nhân
            if(checkData())
            {
                // mọi điều kiện oke tiến hành connect database để thêm bệnh nhân mới 
                SqlConnection con = Connection.getConnection();
                BenhNhan bn = new BenhNhan(txtMaBenhNhan.Text.Trim(), txtTenBenhNhan.Text.Trim(), chkNam.Checked ? "Nam" : "Nu", Convert.ToInt32(txtNamSinh.Text.Trim()), txtDiaChi.Text.Trim());
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand()
                    {
                        Connection = con,
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "spUpdatePatient",
                    };
                    // gắn các tham số
                    cmd.Parameters.AddWithValue("@MaBN", bn.maBenhNhan);
                    cmd.Parameters.AddWithValue("@HoTen", bn.tenBenhNhan);
                    cmd.Parameters.AddWithValue("@GioiTinh", bn.gioiTinh);
                    cmd.Parameters.AddWithValue("@NamSinh", bn.namSinh);
                    cmd.Parameters.AddWithValue("@DiaChi", bn.diaChi);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                    loadDataPatient();
                    resetData();

                    // sinh mã tự động mới
                    txtMaBenhNhan.PlaceholderText = BenhNhan.getAutoId();
                    txtMaBenhNhan.Text = BenhNhan.getAutoId();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }    
        }

        private void btnLapPhieuKham_Click(object sender, EventArgs e)
        {
            frmLapPhieuKham fLapPhieuKham = new frmLapPhieuKham();
            fLapPhieuKham.Show();
            this.Close();
        }
    }
}
