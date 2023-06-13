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
using Microsoft.Office.Interop.Excel;
using App = Microsoft.Office.Interop.Excel.Application;

namespace QL_PhongMachTu
{
    public partial class frmBaoCaoDoanhThuThang : Form
    {
        public frmBaoCaoDoanhThuThang()
        {
            InitializeComponent();
        }

        private void btnLapBaoCao_Click(object sender, EventArgs e)
        {
            SqlConnection con = Connection.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = con,
                CommandText = "spCreateBaoCaoDoanhThuThang",
                CommandType = CommandType.StoredProcedure,
            };

            cmd.Parameters.AddWithValue("@Thang", Convert.ToInt32(dtpNgayLapBaoCao.Text.Trim().Substring(0, 2)));
            cmd.Parameters.AddWithValue("@Nam", Convert.ToInt32(dtpNgayLapBaoCao.Text.Trim().Substring(3, 4)));

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);

            dgvBaoCaoDoanhThu.DataSource = dt;
            con.Close();
        }

        public void printToExcel(DataGridView dgv, string fileName)
        {
            if (dgvBaoCaoDoanhThu.Rows.Count == 0)
                return;

            try
            {
                App excel = new App();
                excel.Visible = false;
                excel.DisplayAlerts = false;

                Microsoft.Office.Interop.Excel.Workbook workbook = excel.Application.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                worksheet.Name = "Báo cáo doanh thu tháng";

                // in phần header vào
                for (int i = 1; i <= dgvBaoCaoDoanhThu.Columns.Count; i++)
                {
                    worksheet.Cells[1, i] = dgvBaoCaoDoanhThu.Columns[i - 1].HeaderText;
                    worksheet.Cells[1, i].Font.Bold = true;
                    worksheet.Cells[1, i].Font.Color = Color.Red;
                    worksheet.Cells[1, i].ColumnWidth = 10;
                }

                // đổ dữ liệu vào excel 
                for (int i = 0; i < dgvBaoCaoDoanhThu.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvBaoCaoDoanhThu.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvBaoCaoDoanhThu.Rows[i].Cells[j].Value.ToString();
                    }
                }

                // lưu lại file
                workbook.SaveAs(fileName);

                excel.Quit();
                MessageBox.Show("Xuất dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain fMain = new frmMain();
            fMain.Show();
            this.Close();
        }

        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            // xuất báo cáo ra file excel
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // gọi hàm in ra file excel
                printToExcel(dgvBaoCaoDoanhThu, saveFileDialog1.FileName);
            }
        }
    }
}
