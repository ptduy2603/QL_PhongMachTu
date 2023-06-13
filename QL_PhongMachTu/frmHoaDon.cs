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
    public partial class frmHoaDon : Form
    {
        public frmLapHoaDon parrentFrom;
        public frmHoaDon(string maPhieuKham, frmLapHoaDon parentForm)
        {
            // hàm dựng nhận vào mã phiếu khám để đi tìm giá trị hiển thị lên text box
            InitializeComponent();
            txtMaHoaDon.Text = HoaDon.getAutoId();
            txtMaHoaDon.PlaceholderText = HoaDon.getAutoId();
            txtMaPhieuKham.Text = maPhieuKham;
            txtTienKham.Text = ThamSo.getTienKham().ToString();
            createDataHoaDon(maPhieuKham);
            loadDonThuoc(maPhieuKham);
            lblHienTongTien.Text = (Convert.ToInt32(txtTienKham.Text) + Convert.ToInt32(txtTienThuoc.Text)).ToString() + " đồng";
            this.parrentFrom = parentForm;
        }

        public void createDataHoaDon(string maPhieuKham)
        {
            SqlConnection con = Connection.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = con,
                CommandText = "spGetDataWithMaPK",
                CommandType = CommandType.StoredProcedure,
            };

            cmd.Parameters.AddWithValue("@MaPK", maPhieuKham);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            txtHoTen.Text = dt.Rows[0]["HoTen"].ToString();
            txtNgayKham.Text = Convert.ToDateTime(dt.Rows[0]["NgayKham"]).ToString("dd/MM/yyyy");
            txtTienThuoc.Text = dt.Rows[0]["TienThuoc"].ToString();
        }

        // load danh sách các thuốc dùng trong hóa đơn tương ứng 
        public void loadDonThuoc(string maPhieuKham)
        {
            SqlConnection con = Connection.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = con,
                CommandText = "spGetDonThuocWithMaPK",
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@MaPK", maPhieuKham);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dgvDonThuoc.DataSource = dt;
            con.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {           
            this.Close();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // sự kiện thanh toán hóa đơn và xử lí lưu dữ liệu vào database 
            DialogResult res = MessageBox.Show("Xác nhận thanh toán", "Xác nhận", MessageBoxButtons.OKCancel);
            if(res == DialogResult.OK)
            {
                // lưu dữ liệu xuống database 
                SqlConnection con = Connection.getConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand()
                {
                    Connection = con,
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "spAddNewHoaDon"
                };

                cmd.Parameters.AddWithValue("@MaHD", txtMaHoaDon.Text.Trim());
                cmd.Parameters.AddWithValue("@MaPK", txtMaPhieuKham.Text.Trim());
                cmd.Parameters.AddWithValue("@TienKham", Convert.ToInt32(txtTienKham.Text.Trim()));
                cmd.Parameters.AddWithValue("@TongTien", Convert.ToInt32(lblHienTongTien.Text.Trim().Remove(lblHienTongTien.Text.Length - 5)));

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Thanh toán không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                    return;
                }

                cmd.Parameters.Clear();
                cmd.CommandText = "AddNewBaoCaoDoanhThu";
                cmd.Parameters.AddWithValue("@Thang", Convert.ToInt32(txtNgayKham.Text.Trim().Substring(3, 2))); //dd/MM/yyyy
                cmd.Parameters.AddWithValue("@Nam", Convert.ToInt32(txtNgayKham.Text.Trim().Substring(6, 4))); //yyyy
                cmd.Parameters.AddWithValue("@DoanhThu", Convert.ToInt32(lblHienTongTien.Text.Trim().Remove(lblHienTongTien.Text.Length - 5)));

                cmd.ExecuteNonQuery();

                cmd.CommandText = "AddNewChiTietBaoCaoDoanhThu";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Ngay", Convert.ToInt32(txtNgayKham.Text.Trim().Substring(0, 2)));
                cmd.Parameters.AddWithValue("@Thang", Convert.ToInt32(txtNgayKham.Text.Trim().Substring(3, 2))); //dd/MM/yyyy
                cmd.Parameters.AddWithValue("@Nam", Convert.ToInt32(txtNgayKham.Text.Trim().Substring(6, 4))); //yyyy
                cmd.Parameters.AddWithValue("@DoanhThu", Convert.ToInt32(lblHienTongTien.Text.Trim().Remove(lblHienTongTien.Text.Length - 5)));

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.parrentFrom.loadDanhSachPhieuKham();
                this.Close();
            }    
        }
    }
}
