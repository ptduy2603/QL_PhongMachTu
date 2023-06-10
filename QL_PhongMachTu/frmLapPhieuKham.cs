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
    public partial class frmLapPhieuKham : Form
    {
        public static List<ChiTietPhieuKham> chiTietPhieuKham = new List<ChiTietPhieuKham>();
        public frmLapPhieuKham()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        // sự kiện vừa load form
        private void frmLapPhieuKham_Load(object sender, EventArgs e)
        {
            loadDataLoaiBenh();
            loadDataPatient();
            updateSoLuotKhamBenh();
            loadDataLoaiThuoc();
            UpdateDonViCachDung();
            txtTrieuChung.Focus();
            txtMaPhieuKham.PlaceholderText = PhieuKham.getAutoId();
            txtMaPhieuKham.Text = PhieuKham.getAutoId();
        }

        // viết function lấy danh sách bệnh nhân trong ngày khám đổ vào datagrid view 
        public void loadDataPatient()
        {
            SqlConnection con = Connection.getConnection();
            con.Open();

            SqlCommand cmd = new SqlCommand()
            {
                CommandType = CommandType.StoredProcedure,
                Connection = con,
                CommandText = "spGetPatientWithNgayKham",
            };

            cmd.Parameters.AddWithValue("@NgayKham", dtpNgayKham.Value);

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
            // xóa lựa chọn default mặc định
            dgvDanhSachBenhNhan.ClearSelection();
        }

        // Hàm lấy data loại bệnh để đổ vào combobox loại bệnh
        public void loadDataLoaiBenh()
        {
            SqlConnection con = Connection.getConnection();
            con.Open();
            string sql = "select * from LOAIBENH";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboLoaiBenh.DataSource = dt;
            cboLoaiBenh.DisplayMember = "TenLB";
            cboLoaiBenh.ValueMember = "MaLB";
            con.Close();
        }

        // Hàm lấy data loại thuốc đổ vào cboLoaithuoc
        public void loadDataLoaiThuoc()
        {
            SqlConnection con = Connection.getConnection();
            con.Open();
            string sql = "select * from LOAITHUOC";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboTenThuoc.DataSource = dt;
            cboTenThuoc.DisplayMember = "TenLT";
            cboTenThuoc.ValueMember = "MaLT";
            con.Close();
        }

        // viết hàm reset lại data của bảng lập phiếu khám 
        public void resetData()
        {
            txtHoTen.Text = "";
            txtMaBenhNhan.Text = "";
            txtNamSinh.Text = "";
            txtGioiTinh.Text = "";
            txtDiaChi.Text = "";
            txtTrieuChung.Text = "";
            txtMaPhieuKham.Text = PhieuKham.getAutoId();
            txtMaPhieuKham.PlaceholderText = PhieuKham.getAutoId();
            cboLoaiBenh.SelectedIndex = 0;
            cboTenThuoc.SelectedIndex = 0;
            txtTrieuChung.Focus();
            // cập nhật lại thời gian hiện tại
            DateTime dt = DateTime.Now;
            dtpNgayKham.Value = dt;

            //cboTenThuoc.SelectedIndex = 0;
            nudSoLuong.Value = 0;

            // xóa toàn bộ bảng kê thuốc cũ
            dgvToaThuoc.Rows.Clear();

            //xóa list chi tiết phiếu khám
            chiTietPhieuKham.Clear();

        }

        // hàm kiểm tra login cho dữ liệu của các trường 
        public bool checkData()
        {
            if(String.IsNullOrEmpty(txtMaBenhNhan.Text))
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân để lập phiếu", "Thông báo", MessageBoxButtons.OK);
                return false;
            }    

            if(String.IsNullOrEmpty(txtTrieuChung.Text.Trim()))
            {
                errorProvider.SetError(txtTrieuChung, "Vui lòng nhập triệu chứng bệnh");
                return false;
            }

            if(nudSoLuong.Value == 0)
            {
                errorProvider.SetError(nudSoLuong, "Chọn số lượng thuốc");
                return false;
            }    
            else
            {
                // kiểm tra số lượng thuốc chọn có đủ trong kho hay không
                SqlConnection con = Connection.getConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand()
                {
                    CommandType = CommandType.StoredProcedure,
                    Connection = con,
                    CommandText = "spGetSoLuongTon"
                };
                cmd.Parameters.AddWithValue("@MaLT", cboTenThuoc.SelectedValue.ToString());
                object result = cmd.ExecuteScalar();
                con.Close();
                int soluong = Convert.ToInt32(result);
                if(nudSoLuong.Value > soluong)
                {
                    errorProvider.SetError(nudSoLuong, "Lượng thuốc không đủ, vui lòng nhập thêm thuốc!");
                    return false;
                }    
            }

            return true;
        }

        // viết hàm cập nhật dữ liệu đơn vị và cách dùng khi ta thay đổi tên loại thuốc
        public void UpdateDonViCachDung()
        {
            SqlConnection con = Connection.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = con,
                CommandText = "spTimDonViCachDungTheoThuoc",
                CommandType = CommandType.StoredProcedure,
            };
            cmd.Parameters.AddWithValue("@MaLT", cboTenThuoc.SelectedValue.ToString());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                txtDonVi.Text = Convert.ToString(dt.Rows[0]["TenDV"]);
                txtCachDung.Text = Convert.ToString(dt.Rows[0]["TenCD"]);
            }
            con.Close();
        }

        //hàm kiểm tra mã thuốc vừa chọn đã được kê chưa 
        public bool checkMaThuoc()
        {
            if (chiTietPhieuKham.Count == 0)
                return false;
            for(int i = 0; i < chiTietPhieuKham.Count; i++)
            {
                if (chiTietPhieuKham[i].maLoaiThuoc == cboTenThuoc.SelectedValue.ToString())
                    return true;   
            }    
            return false;
        }

        //hàm tính lại số lượt khám bệnh còn trong ngày theo đúng quy định
        public void updateSoLuotKhamBenh()
        {
            // lấy tổng số lượt khám bệnh trong ngày hiện tại
            SqlConnection con = Connection.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand()
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "spGetSoPhieuKham",
                Connection = con,
            };
            cmd.Parameters.AddWithValue("@NgayKham", Convert.ToDateTime(dtpNgayKham.Value));

            object result = cmd.ExecuteScalar();
            con.Close();
            int soLuotKham = Convert.ToInt32(result);
            txtSoLuongKhamBenh.Text = Convert.ToString(ThamSo.getBenhNhanToiDa() - soLuotKham);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc muốn thoát không?", "Hỏi thoát", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                // chuyển hướng về from main
                frmMain fMain = new frmMain();
                fMain.Show();
                this.Close();
            }    
        }        

        private void dgvDanhSachBenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // khi nhấn vào một bệnh nhân thì thông tin của bệnh nhân được đổ vào vùng data bệnh nhân
            txtMaBenhNhan.Text = dgvDanhSachBenhNhan.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = dgvDanhSachBenhNhan.CurrentRow.Cells[1].Value.ToString();
            txtGioiTinh.Text = dgvDanhSachBenhNhan.CurrentRow.Cells[2].Value.ToString();
            txtNamSinh.Text = dgvDanhSachBenhNhan.CurrentRow.Cells[3].Value.ToString();
            txtDiaChi.Text = dgvDanhSachBenhNhan.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetData();
        }

        // Khi chọn một loại thuốc thì đơn vị và cách dùng của loại thuốc đó sẽ được tự động cập nhật
        private void cboTenThuoc_TextChanged(object sender, EventArgs e)
        {
            UpdateDonViCachDung();
        }

        private void dtpNgayKham_ValueChanged(object sender, EventArgs e)
        {
            // mỗi khi đổi sang ngày khám khác phải load lại danh sách bệnh nhân cần khám 
            loadDataPatient();
            // cập nhật lại số lượt khám
            updateSoLuotKhamBenh();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(checkData())
            {
                for(int i = 0; i < chiTietPhieuKham.Count; i++)
                {
                    if (chiTietPhieuKham[i].maLoaiThuoc == cboTenThuoc.SelectedValue.ToString())
                    {
                        chiTietPhieuKham[i].SoLuong = Convert.ToInt32(nudSoLuong.Value);
                        dgvToaThuoc.Rows[i].Cells[2].Value = Convert.ToInt32(nudSoLuong.Value);
                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }    
                }

                MessageBox.Show("Không tìm thấy thuốc cần sửa", "Thông báo", MessageBoxButtons.OK);
            }    
        }

        private void txtTrieuChung_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtTrieuChung, null);
        }

        private void nudSoLuong_ValueChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(nudSoLuong, null);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // thêm một loại thuốc vào bảng kê thuốc
            if(checkData())
            {
                if(checkMaThuoc())
                {
                    // nếu mã thuốc đã được kê thì thông báo đã kê loại thuốc này
                    MessageBox.Show("Thuốc này đã được kê!", "Thông báo", MessageBoxButtons.OK);
                }    
                else
                {
                    // tạo ra một chi tiết khám bệnh mới 
                    ChiTietPhieuKham ct = new ChiTietPhieuKham(txtMaPhieuKham.Text.Trim(), Convert.ToString(cboTenThuoc.SelectedValue), Convert.ToInt32(nudSoLuong.Value));
                    chiTietPhieuKham.Add(ct);
                    dgvToaThuoc.Rows.Add(cboTenThuoc.Text, txtDonVi.Text, nudSoLuong.Value, txtCachDung.Text);
                    dgvToaThuoc.ClearSelection();

                    // reset lại data chọn thuốc
                    cboTenThuoc.SelectedIndex = 0;
                    nudSoLuong.Value = 0;
                }
            }    
        }

        private void dgvToaThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvToaThuoc.CurrentRow.Index != dgvToaThuoc.Rows.Count - 1)
            {
                // click vào thuốc thì đổ thông tin lên 
                cboTenThuoc.Text = dgvToaThuoc.CurrentRow.Cells[0].Value.ToString();
                nudSoLuong.Value = Convert.ToInt32(dgvToaThuoc.CurrentRow.Cells[2].Value);
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //xóa thuốc khỏi toan cần kê
            for(int i = 0; i < chiTietPhieuKham.Count; i++)
            {
                if (chiTietPhieuKham[i].maLoaiThuoc == cboTenThuoc.SelectedValue.ToString())
                {
                    chiTietPhieuKham.RemoveAt(i);
                    dgvToaThuoc.Rows.RemoveAt(i);
                    cboTenThuoc.SelectedIndex = 0;
                    nudSoLuong.Value = 0;
                    MessageBox.Show("Xóa thuốc thành công", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }    
            MessageBox.Show("Không tìm thấy thuốc cần xóa", "Thông báo", MessageBoxButtons.OK);
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtMaBenhNhan.Text.Trim()) || String.IsNullOrEmpty(txtTrieuChung.Text.Trim()))
            {
                MessageBox.Show("Lập phiếu không thành công", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if(Convert.ToInt32(txtSoLuongKhamBenh.Text.Trim()) == 0)
            {
                // quá số lượng khám bệnh trong ngày
                MessageBox.Show("Vượt quá số bệnh nhân được khám tối đa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            else
            {
                // sự kiện người dùng quyết định lập phiếu 
                DialogResult res = MessageBox.Show("Xác nhận lập phiếu", "Xác nhận", MessageBoxButtons.OKCancel);
                if (res == DialogResult.OK)
                {
                    SqlConnection con = Connection.getConnection();
                    con.Open();
                    SqlCommand cmd = new SqlCommand()
                    {
                        Connection = con,
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "spAddPhieuKhamBenh"
                    };
                    cmd.Parameters.AddWithValue("@MaPK", txtMaPhieuKham.Text.Trim());
                    cmd.Parameters.AddWithValue("@NgayKham", Convert.ToDateTime(dtpNgayKham.Value));
                    cmd.Parameters.AddWithValue("@MaBN", txtMaBenhNhan.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaLB", Convert.ToString(cboLoaiBenh.SelectedValue));
                    cmd.Parameters.AddWithValue("@TrieuChung", txtTrieuChung.Text.Trim());
                    int tienThuoc = 0;
                    for(int i = 0; i < chiTietPhieuKham.Count; i++)
                    {
                        tienThuoc += chiTietPhieuKham[i].SoLuong * chiTietPhieuKham[i].DonGia;
                    }
                    cmd.Parameters.AddWithValue("@TienThuoc", tienThuoc);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Lập phiếu không thành công", "Thông báo", MessageBoxButtons.OK);
                        con.Close();
                        return;
                    }

                    if(tienThuoc != 0) // có sử dụng thuốc thì lưu thêm thông tin thuốc
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandText = "AddChiTietPhieuKham";
                        SqlCommand cmd1 = new SqlCommand()
                        {
                            CommandText = "AddBaoCaoDungThuoc",
                            Connection = con,
                            CommandType = CommandType.StoredProcedure
                        };

                        SqlCommand cmd2 = new SqlCommand()
                        {
                            CommandText = "spUpdateSoLuongThuocKhiBan",
                            Connection = con,
                            CommandType = CommandType.StoredProcedure
                        };

                        for(int i = 0; i < chiTietPhieuKham.Count; i++)
                        {
                            cmd.Parameters.AddWithValue("@MaPK", chiTietPhieuKham[i].maPhieuKham);
                            cmd.Parameters.AddWithValue("@MaLT", chiTietPhieuKham[i].maLoaiThuoc);
                            cmd.Parameters.AddWithValue("@SoLuong", chiTietPhieuKham[i].SoLuong);
                            cmd.Parameters.AddWithValue("@DonGia", chiTietPhieuKham[i].DonGia);

                            cmd1.Parameters.AddWithValue("@Thang", Convert.ToInt32(dtpNgayKham.Value.ToString("dd/MM/yyyy").Substring(3, 2))); //MM là lấy ra tháng
                            cmd1.Parameters.AddWithValue("@Nam", Convert.ToInt32(dtpNgayKham.Value.ToString("dd/MM/yyyy").Substring(6, 4)));
                            cmd1.Parameters.AddWithValue("@MaLT", chiTietPhieuKham[i].maLoaiThuoc);
                            cmd1.Parameters.AddWithValue("@SoLuongDung", chiTietPhieuKham[i].SoLuong);

                            cmd2.Parameters.AddWithValue("@SoLuong", chiTietPhieuKham[i].SoLuong);
                            cmd2.Parameters.AddWithValue("@MaLT", chiTietPhieuKham[i].maLoaiThuoc);

                            cmd.ExecuteNonQuery();
                            cmd1.ExecuteNonQuery();
                            cmd2.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                            cmd1.Parameters.Clear();
                            cmd2.Parameters.Clear();
                        }    
                      
                    }

                    MessageBox.Show("Lập phiếu khám thành công!", "Thông báo", MessageBoxButtons.OK);
                    loadDataPatient();
                    updateSoLuotKhamBenh();
                    resetData();

                    con.Close();
                }
            }
                
        }
    }
}
