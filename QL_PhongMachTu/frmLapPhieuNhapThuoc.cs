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
    public partial class frmLapPhieuNhapThuoc : Form
    {
        public List<PhieuNhapThuoc> chiTietPN = new List<PhieuNhapThuoc>();
        public frmLapPhieuNhapThuoc()
        {
            InitializeComponent();
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

        private void frmLapPhieuNhapThuoc_Load(object sender, EventArgs e)
        {
            txtMaPhieuNhapThuoc.Text = PhieuNhapThuoc.getAutoId();
            txtMaPhieuNhapThuoc.PlaceholderText = PhieuNhapThuoc.getAutoId();
            txtTongTien.Text = "0";
            loadDanhSachPhieuNhapThuoc();
            loadDataThuoc();
            nudSoLuongNhap.Focus();
        }

        //Hàm load danh sách các phiếu nhập thuốc từ database
        public void loadDanhSachPhieuNhapThuoc()
        {
            SqlConnection con = Connection.getConnection();
            string sql = "select * from PHIEUNHAPTHUOC";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvDanhSachPhieuNhapThuoc.DataSource = dt;
            dgvDanhSachPhieuNhapThuoc.Columns[0].HeaderText = "Mã phiếu";
            dgvDanhSachPhieuNhapThuoc.Columns[0].Width = 100;
            dgvDanhSachPhieuNhapThuoc.Columns[1].HeaderText = "Ngày lập";
            dgvDanhSachPhieuNhapThuoc.Columns[1].Width = 150;
            dgvDanhSachPhieuNhapThuoc.Columns[2].HeaderText = "Tổng tiền";
            dgvDanhSachPhieuNhapThuoc.ClearSelection();
        }

        // hàm load data loại thuốc đưa vào comboBox 
        public void loadDataThuoc()
        {
            SqlConnection con = Connection.getConnection();
            string sql = "select * from LOAITHUOC";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboTenThuoc.DataSource = dt;
            cboTenThuoc.DisplayMember = "TenLT";
            cboTenThuoc.ValueMember = "MaLT";
        }

        // hàm reset data của form 
        public void resetData()
        {
            txtMaPhieuNhapThuoc.Text = PhieuNhapThuoc.getAutoId();
            txtMaPhieuNhapThuoc.PlaceholderText = PhieuNhapThuoc.getAutoId();
            dtpNgayLapPhieu.Text = Convert.ToString(DateTime.Now);
            txtTongTien.Text = "0";
            cboTenThuoc.SelectedIndex = 0;
            nudSoLuongNhap.Value = 0;
            txtDonGiaNhap.Text = "";
            nudSoLuongNhap.Focus();

            // xóa hết data trong data grid view và danh sách phiếu nhập tạm thời 
            dgvDanhSachThuoc.Rows.Clear();

            chiTietPN.Clear();
            
        }

        // hàm checkData của form 
        public bool checkData()
        {
            if(nudSoLuongNhap.Value == 0)
            {
                errorProvider.SetError(nudSoLuongNhap, "Vui lòng nhập số lượng thuốc");
                return false;
            }

            int giaNhap = 0;
            bool check = int.TryParse(txtDonGiaNhap.Text.Trim(), out giaNhap);

            if(giaNhap <= 0 || check == false)
            {
                errorProvider.SetError(txtDonGiaNhap, "Đơn giá nhập không hợp lệ");
                return false;
            }
            else
            {
                // check đơn giá nhập có lớn hơn giá bán hiện tại không
                SqlConnection con = Connection.getConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand()
                {
                    Connection = con,
                    CommandText = "spCheckDonGiaNhap",
                    CommandType = CommandType.StoredProcedure,                    
                };

                cmd.Parameters.AddWithValue("@DonGiaNhap", giaNhap);
                cmd.Parameters.AddWithValue("@MaLT", cboTenThuoc.SelectedValue.ToString());

                object result = cmd.ExecuteScalar();
                int code = Convert.ToInt32(result); 
                if(code == 0)
                {
                    errorProvider.SetError(txtDonGiaNhap, "Đơn giá nhập lớn hơn đơn giá bán hiện tại!");
                    return false;
                }
            }
            return true;
        }

        // hàm kiểm tra xem mã thuốc định nhập có trong danh sách nhập đợt này hay chưa 
        public bool checkMaThuoc(string maThuoc)
        {
            if (chiTietPN.Count == 0)
                return false;

            for(int i = 0; i < chiTietPN.Count; i++)
            {
                if (chiTietPN[i].maLoaiThuoc == maThuoc)
                    return true;
            }    
            return false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetData();
        }

        private void nudSoLuongNhap_ValueChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(nudSoLuongNhap, null);
        }

        private void txtDonGiaNhap_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtDonGiaNhap, null);
        }

        // Hàm tự động tính toán giá trị cho ô tổng tiền 
        public void tinhTongTien()
        {
            int sum = 0;
            for( int i = 0; i < chiTietPN.Count; i++)
            {
                int temp = chiTietPN[i].soLuong * chiTietPN[i].donGiaNhap;
                sum += temp;
            }   

            txtTongTien.Text = sum.ToString();  
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // đẩy một chi tiết nhập thuốc vào danh sách tạm 
            if(checkData())
            {
                if(checkMaThuoc(Convert.ToString(cboTenThuoc.SelectedValue)))
                {
                    // nếu mã thuốc đã có thì thông báo đã thêm loại thuốc này
                    MessageBox.Show("Đã thêm loại thuốc này", "Thông báo", MessageBoxButtons.OK);
                   
                }    
                else
                {
                    PhieuNhapThuoc pn = new PhieuNhapThuoc(txtMaPhieuNhapThuoc.Text.Trim(), cboTenThuoc.SelectedValue.ToString(), Convert.ToInt32(nudSoLuongNhap.Value), int.Parse((txtDonGiaNhap.Text.Trim())));
                    chiTietPN.Add(pn);
                    dgvDanhSachThuoc.Rows.Add(cboTenThuoc.Text, nudSoLuongNhap.Value, txtDonGiaNhap.Text.Trim());
                    cboTenThuoc.SelectedIndex = 0;
                    txtDonGiaNhap.Text = "";
                    nudSoLuongNhap.Value = 0;
                    dgvDanhSachThuoc.ClearSelection();
                    // cập nhật lại tổng tiền nhập thuốc
                    tinhTongTien();
                }
            }    
        }
        private void dgvDanhSachThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // click chuột vào danh sách thuốc thì thông tin đổ lên 
            cboTenThuoc.Text = Convert.ToString(dgvDanhSachThuoc.CurrentRow.Cells[0].Value);
            nudSoLuongNhap.Value = Convert.ToInt32(dgvDanhSachThuoc.CurrentRow.Cells[1].Value);
            txtDonGiaNhap.Text = Convert.ToString(dgvDanhSachThuoc.CurrentRow.Cells[2].Value);
        }

      
        private void btnSua_Click(object sender, EventArgs e)
        {
            if(checkData())
            {
                for(int i = 0; i < chiTietPN.Count; i++)
                {
                    if (chiTietPN[i].maLoaiThuoc == cboTenThuoc.SelectedValue)
                    {
                        chiTietPN[i].soLuong = Convert.ToInt32(nudSoLuongNhap.Value);
                        chiTietPN[i].donGiaNhap = Convert.ToInt32(txtDonGiaNhap.Text.Trim());
                        dgvDanhSachThuoc.Rows[i].Cells[1].Value = Convert.ToInt32(nudSoLuongNhap.Value);
                        dgvDanhSachThuoc.Rows[i].Cells[2].Value = Convert.ToInt32(txtDonGiaNhap.Text.Trim());
                        tinhTongTien();
                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }   
                }

                MessageBox.Show("Không tìm thấy thuốc cần sửa", "Thông báo", MessageBoxButtons.OK);
            }    
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            // sự kiện user quyết định lập phiếu nhập thuốc
            if(chiTietPN.Count > 0) // khi có phần tử trong datagrid view thì mới lập thuốc
            {
                DialogResult res = MessageBox.Show("Xác nhận nhập thuốc", "Xác nhận", MessageBoxButtons.OKCancel);
                if(res == DialogResult.OK)
                {
                    SqlConnection con = Connection.getConnection();
                    con.Open();
                    SqlCommand cmd = new SqlCommand()
                    {
                        Connection = con,
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "spAddPhieuNhapThuoc",
                    };
                    try
                    {          
                        
                        cmd.Parameters.AddWithValue("@MaPN", txtMaPhieuNhapThuoc.Text.Trim());
                        cmd.Parameters.AddWithValue("@NgayLap", Convert.ToDateTime(dtpNgayLapPhieu.Text));
                        cmd.Parameters.AddWithValue("@TongTien", Convert.ToInt32(txtTongTien.Text));
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lập phiếu không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // nếu phiếu hợp lệ thì thêm thông tin các chi tiết nhập thuốc vào bảng chi tiết
                    cmd.Parameters.Clear();
                    cmd.CommandText = "spAddChiTietPhieuNhapThuoc";
                    SqlCommand cmd1 = new SqlCommand()
                    {
                        Connection = con,
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "spUpdateLoaiThuocKhiNhap",
                    };

                    for(int i = 0; i < chiTietPN.Count; i++)
                    {
                        cmd.Parameters.AddWithValue("@MaPN", chiTietPN[i].maPhieuNhapThuoc);
                        cmd.Parameters.AddWithValue("@MaLT", chiTietPN[i].maLoaiThuoc);
                        cmd.Parameters.AddWithValue("@SoLuong", chiTietPN[i].soLuong);
                        cmd.Parameters.AddWithValue("@DonGiaNhap", chiTietPN[i].donGiaNhap);
                        cmd1.Parameters.AddWithValue("@MaLT", chiTietPN[i].maLoaiThuoc);
                        cmd1.Parameters.AddWithValue("@SoLuongNhap", chiTietPN[i].soLuong);
                        cmd1.Parameters.AddWithValue("@DonGiaNhap", chiTietPN[i].donGiaNhap);
                        cmd.ExecuteNonQuery();
                        cmd1.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        cmd1.Parameters.Clear();
                    }

                    con.Close();
                    MessageBox.Show("Lập phiếu nhập thuốc thành công", "Thông báo", MessageBoxButtons.OK);
                    loadDanhSachPhieuNhapThuoc();
                    resetData();                    
                }    
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thuốc để nhập", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnXemThongTinThuoc_Click(object sender, EventArgs e)
        {
            // chuyển sang form hiển thị thông tin thuốc
            frmQuanLyThuoc fQuanLyThuoc = new frmQuanLyThuoc();
            fQuanLyThuoc.Show();
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvDanhSachPhieuNhapThuoc.Rows.Count == 0)
            {
                MessageBox.Show("Chưa chọn thuốc", "Thông báo", MessageBoxButtons.OK);
            }    
            else
            {
                for(int i = 0; i < chiTietPN.Count; i++)
                {
                    if (chiTietPN[i].maLoaiThuoc == cboTenThuoc.SelectedValue.ToString())
                    {
                        chiTietPN.RemoveAt(i);
                        dgvDanhSachThuoc.Rows.RemoveAt(i);
                        tinhTongTien();
                        cboTenThuoc.SelectedIndex = 0;
                        nudSoLuongNhap.Value = 0;
                        txtDonGiaNhap.Text = "";
                        MessageBox.Show("Xóa thuốc thành công", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }    
                }

                MessageBox.Show("Không tìm thấy thuốc cần xóa", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
