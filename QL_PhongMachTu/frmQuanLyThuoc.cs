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
    public partial class frmQuanLyThuoc : Form
    {
        DataTable dtDonVi = new DataTable();
        DataTable dtCachDung = new DataTable();
        public frmQuanLyThuoc()
        {
            InitializeComponent();
            this.ControlBox = false;
        }      

        // viết hàm load các loại đơn vị từ database đổ vào cboDonVi
        public void loadDonVi()
        {
            SqlConnection con = Connection.getConnection();
            con.Open();
            string sql = "select * from DONVI";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dtDonVi);
            cboDonVi.DataSource = dtDonVi;
            cboDonVi.ValueMember = "MaDV";
            cboDonVi.DisplayMember = "TenDV";
            con.Close();
        }

        // viết hàm load các cách dùng từ database đổ vào cbo
        public void loadCachDung()
        {
            SqlConnection con = Connection.getConnection();
            con.Open();
            string sql = "select * from CACHDUNG";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dtCachDung);
            cboCachDung.DataSource = dtCachDung;
            con.Close();
            cboCachDung.DisplayMember = "TenCD";
            cboCachDung.ValueMember = "MaCD";
        }

        // viết hàm load data cho Danh sách thuốc
       public void loadDanhSachThuoc()
       {
            SqlConnection con = Connection.getConnection();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = con,
                CommandText = "spGetDataMedicine",
                CommandType = CommandType.StoredProcedure,
            };

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvDanhSachLoaiThuoc.DataSource = dt;
            dgvDanhSachLoaiThuoc.Columns[0].HeaderText = "Mã loại thuốc";
            dgvDanhSachLoaiThuoc.Columns[1].HeaderText = "Tên loại thuốc";
            dgvDanhSachLoaiThuoc.Columns[1].Width = 150;
            dgvDanhSachLoaiThuoc.Columns[2].HeaderText = "Đơn vị";
            dgvDanhSachLoaiThuoc.Columns[3].HeaderText = "Cách dùng";
            dgvDanhSachLoaiThuoc.Columns[4].HeaderText = "Giá bán";
            dgvDanhSachLoaiThuoc.Columns[5].HeaderText = "Số lượng còn lại";
       }

        // hàm kiểm tra điều kiện dữ liệu 
        public bool checkData()
        {
            if(String.IsNullOrEmpty(txtTenThuoc.Text.Trim()))
            {
                errorProvider.SetError(txtTenThuoc, "Vui lòng nhập tên thuốc");
                return false;
            }    

            if(String.IsNullOrEmpty(txtGiaBan.Text.Trim()))
            {
                errorProvider.SetError(txtGiaBan, "Vui lòng nhập giá bán");
                return false;
            }

            int giaBan;
            bool check = int.TryParse(txtGiaBan.Text.Trim(), out giaBan);
            if(check == false || giaBan <= 0)
            {
                errorProvider.SetError(txtGiaBan, "Giá bán không hợp lệ");
                return false;
            }  
      
            return true;
        }

        public bool checkDonGiaBan()
        {
            // check xem giá bán thay đổi có lớn hơn hoặc bằng giá nhập hay không
            SqlConnection con = Connection.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand()
            {
                CommandType = CommandType.StoredProcedure,
                Connection = con,
                CommandText = "spCheckDonGiaBan"
            };
            cmd.Parameters.AddWithValue("@DonGiaBan", Convert.ToInt32(txtGiaBan.Text.Trim()));
            cmd.Parameters.AddWithValue("@MaLT", txtMaThuoc.Text.Trim());
            object result = cmd.ExecuteScalar();
            con.Close();
            int code = Convert.ToInt32(result);
            if (code == 0)
            {
                errorProvider.SetError(txtGiaBan, "Giá bán nhỏ hơn giá nhập thuốc hiện tại!");
                return false;
            }

            return true;
        }

        // viết hàm reset data cho toàn bảng 
        public void resetData()
        {
            txtMaThuoc.Text = Thuoc.getAutoId();
            txtMaThuoc.PlaceholderText = Thuoc.getAutoId();
            txtTenThuoc.Text = "";
            cboDonVi.SelectedIndex = 0;
            cboCachDung.SelectedIndex = 0;
            txtGiaBan.Text = "";
            cboCachDung.Text = "";
            cboDonVi.Text = "";
            txtTenThuoc.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc muốn thoát không?", "Hỏi thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                frmMain fMain = new frmMain();
                fMain.Show();
                this.Close();
            }    
        }

        private void frmQuanLyThuoc_Load(object sender, EventArgs e)
        {
            loadDonVi();
            loadCachDung();
            loadDanhSachThuoc();
            txtMaThuoc.Text = Thuoc.getAutoId();
            txtMaThuoc.PlaceholderText = Thuoc.getAutoId();
            txtTenThuoc.Focus();
        }

        private void dgvDanhSachLoaiThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // đổ data của selected row và các box 
            txtMaThuoc.Text = dgvDanhSachLoaiThuoc.CurrentRow.Cells[0].Value.ToString();
            txtTenThuoc.Text = dgvDanhSachLoaiThuoc.CurrentRow.Cells[1].Value.ToString();
            cboDonVi.Text = dgvDanhSachLoaiThuoc.CurrentRow.Cells[2].Value.ToString();
            cboCachDung.Text = dgvDanhSachLoaiThuoc.CurrentRow.Cells[3].Value.ToString();
            txtGiaBan.Text = dgvDanhSachLoaiThuoc.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetData();
        }

        private void txtTenThuoc_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtTenThuoc, null);
        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtGiaBan, null);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // xử lí thêm một loại thuốc mới
            if(checkData())
            {
                SqlConnection con = Connection.getConnection();
                Thuoc t = new Thuoc(txtMaThuoc.Text.Trim(), txtTenThuoc.Text.Trim(), cboDonVi.SelectedValue.ToString(), cboCachDung.SelectedValue.ToString(), 0, Convert.ToInt32(txtGiaBan.Text.Trim()));
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand()
                    {
                        Connection = con,
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "spAddNewMedicine",
                    };

                    cmd.Parameters.AddWithValue("@MaLT", t.maThuoc);
                    cmd.Parameters.AddWithValue("@TenLT", t.tenThuoc);
                    cmd.Parameters.AddWithValue("@MaDV", t.donVi);
                    cmd.Parameters.AddWithValue("@MaCD", t.cachDung);
                    cmd.Parameters.AddWithValue("@DonGiaBan", t.giaBan);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thuốc mới thành công", "Thông báo", MessageBoxButtons.OK);
                    resetData();
                    loadDanhSachThuoc();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Mã thuốc đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection con = Connection.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = con,
                CommandText = "spCheckMaLT",
                CommandType = CommandType.StoredProcedure,
            };
            cmd.Parameters.AddWithValue("@MaLT", txtMaThuoc.Text.Trim());
            object result = cmd.ExecuteScalar();
            int check = Convert.ToInt32(result);
            // xóa một loại thuốc khỏi database
            if(check == 0)
            {
                MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK);
            }    
            else
            {
                    cmd.CommandText = "spDeleteMedicine";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    loadDanhSachThuoc();
                    resetData();                          
            }

            con.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            if(checkData() && checkDonGiaBan())
            {
                SqlConnection con = Connection.getConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand()
                {
                    Connection = con,
                    CommandText = "spCheckMaLT",
                    CommandType = CommandType.StoredProcedure,
                };

                cmd.Parameters.AddWithValue("@MaLT", txtMaThuoc.Text.Trim());
                object result = cmd.ExecuteScalar();
                int code = Convert.ToInt32(result);
                if(code == 0)
                {
                    MessageBox.Show("Cập nhật không thành công", "Thông báo", MessageBoxButtons.OK);
                }    
                else
                {
                    cmd.CommandText = "spUpdateMedicine";
                    cmd.Parameters.AddWithValue("@TenLT", txtTenThuoc.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaDV", cboDonVi.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@MaCD", cboCachDung.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@DonGiaBan", Convert.ToInt32(txtGiaBan.Text.Trim()));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thuốc thành công", "Thông báo", MessageBoxButtons.OK);
                    loadDanhSachThuoc();
                    resetData();
                }
            }    
        }

        private void btnNhapThuoc_Click(object sender, EventArgs e)
        {
            frmLapPhieuNhapThuoc fLapPhieuNhapThuoc = new frmLapPhieuNhapThuoc();
            fLapPhieuNhapThuoc.Show();
            this.Close();
        }
    }
}
