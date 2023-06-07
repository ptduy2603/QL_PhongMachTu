using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            dgvDanhSachBenhNhan.Columns[2].HeaderText = "Giới Tính";
            dgvDanhSachBenhNhan.Columns[3].HeaderText = "Năm Sinh";
            dgvDanhSachBenhNhan.Columns[4].HeaderText = "Địa Chỉ";
        }

        private void frmThemTTBenhNhan_Load(object sender, EventArgs e)
        {
            txtMaBenhNhan.PlaceholderText = BenhNhan.getAutoId();
            txtTenBenhNhan.Focus();
            loadDataPatient();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmQLKB QLKB = new frmQLKB();
            QLKB.Show();
            this.Hide();
        }

        private void chkNam_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNam.Checked)
            {
                chkNu.Checked = false;
            }
            else
            {
                chkNu.Checked = true;
            }
        }

        private void chkNu_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkNu.Checked)
            {
                chkNam.Checked = false;
            }
            else
            {
                chkNam.Checked = true;
            }
        }

       
    }
}
