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
    public partial class frmTraCuuBenhNhan : Form
    {
        public frmTraCuuBenhNhan()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            // tìm kiếm kết quả và đổ vào datagridview   
                SqlConnection con = Connection.getConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spTraCuuBenhNhan";
                cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text.Trim());
                cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text.Trim());
                cmd.Parameters.AddWithValue("@NamSinh", txtNamSinh.Text.Trim());
                cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim());
                cmd.Parameters.AddWithValue("@MaBenhNhan", txtMaBenhNhan.Text.Trim());
                cmd.Parameters.AddWithValue("@NgayKham", Convert.ToDateTime(dtpNgayKham.Value));
                cmd.Parameters.AddWithValue("@LoaiBenh", cboLoaiBenh.Text.Trim());
                cmd.Parameters.AddWithValue("@TrieuChung", txtTrieuChung.Text.Trim());
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();

                dtvTraCuuBN.DataSource = dt;           

        }

        //hàm lấy data loại bệnh đổ vào combobox 
        public void loadLoaiBenh()
        {
            SqlConnection con = Connection.getConnection();
            con.Open();
            string sql = "select * from LOAIBENH";
            SqlDataAdapter da = new SqlDataAdapter(sql,con);

            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            cboLoaiBenh.DataSource = dt;
            cboLoaiBenh.DisplayMember = "TenLB";
            cboLoaiBenh.ValueMember = "MaLB";
        }

        // hàm reset lại data để tìm kiếm tiếp tục 
        public void resetData()
        {
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtMaBenhNhan.Text = "";
            txtNamSinh.Text = "";
            txtTrieuChung.Text = "";
            cboGioiTinh.Text = "";
            cboLoaiBenh.Text = "";
        }


        private void frmTraCuuBenhNhan_Load(object sender, EventArgs e)
        {
            loadLoaiBenh();
            cboGioiTinh.Text = "";
            cboLoaiBenh.Text = "";
            txtHoTen.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain fMain = new frmMain();
            fMain.Show();
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetData();
        }

        private void btnThemBenhNhan_Click(object sender, EventArgs e)
        {
            frmThemTTBenhNhan fThongTinBenhNhan = new frmThemTTBenhNhan();
            fThongTinBenhNhan.Show();
            this.Hide();
        }

        private void btnLapPhieuKham_Click(object sender, EventArgs e)
        {
            frmLapPhieuKham fLapPhieuKham = new frmLapPhieuKham();
            fLapPhieuKham.Show();
            this.Close();
        }
    }
}
