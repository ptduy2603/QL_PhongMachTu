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
    public partial class frmLapHoaDon : Form
    {
        //dùng delegate để khi đóng hóa đơn có thể load lại danh sách các phiếu khám
        
      
        public frmLapHoaDon()
        {
            InitializeComponent();
        }

        // hàm load danh sách tất cả các phiếu khám trong ngày chưa được lập hóa đơn
        public void loadDanhSachPhieuKham()
        {
            SqlConnection con = Connection.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = con,
                CommandType = CommandType.StoredProcedure,
                CommandText = "spGetPhieuKhamWithNgayLap"
            };
            cmd.Parameters.AddWithValue("@NgayLap", Convert.ToDateTime(dtpNgayLap.Value));
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            con.Close();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvDanhSachPhieuKham.DataSource = dt;
        }

        private void frmLapHoaDon_Load(object sender, EventArgs e)
        {
            loadDanhSachPhieuKham();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // về form main
            frmMain fMain = new frmMain();
            fMain.Show();
            this.Close();
        }

        private void dtpNgayLap_ValueChanged(object sender, EventArgs e)
        {
            // thay đổi giá trị ngày lập thì load lại danh sách phiếu khám 
            loadDanhSachPhieuKham();
        }

        private void btnXemHoaDon_Click(object sender, EventArgs e)
        {
            // nếu đã chọn phiếu khám thì hiện hóa đơn, không thì báo chọn phiếu khám
            if (dgvDanhSachPhieuKham.Rows.Count == 0)
            {
                // nếu chưa có phiếu khám nào trong hóa đơn
                MessageBox.Show("Chưa có phiếu khám nào trong ngày", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                frmHoaDon fHoaDon = new frmHoaDon(dgvDanhSachPhieuKham.CurrentRow.Cells[0].Value.ToString().Trim(), this);
                fHoaDon.ShowDialog();
            }      
        }
    }
}
