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
    public partial class frmBaoCaoSuDungThuoc : Form
    {
        public frmBaoCaoSuDungThuoc()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain fMain = new frmMain();
            fMain.Show();
            this.Close();
        }

        private void btnLapBaoCao_Click(object sender, EventArgs e)
        {
            // load dữ liệu báo cáo trong tháng hiện tại vào
            SqlConnection con = Connection.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = con,
                CommandType = CommandType.StoredProcedure,
                CommandText = "spGetBaoCaoSuDungThuoc",
            };

            cmd.Parameters.AddWithValue("@Thang", Convert.ToInt32(dtpNgayLapBaoCao.Text.Trim().Substring(0, 2)));
            cmd.Parameters.AddWithValue("@Nam", Convert.ToInt32(dtpNgayLapBaoCao.Text.Trim().Substring(3, 4)));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Close();

            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);

           dgvBaoCaoSuDungThuoc.DataSource = dt;

        }

        // hàm để in đữ liệu từ datagrid view sang file excel 
        public void printToExcel(DataGridView dgv, string fileName)
        {
            if(dgvBaoCaoSuDungThuoc.Rows.Count == 0)
                  return;
            
            try
            {
                App excel = new App();
                excel.Visible = false;
                excel.DisplayAlerts = false;

               Microsoft.Office.Interop.Excel.Workbook workbook =  excel.Application.Workbooks.Add(Type.Missing);
               Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                worksheet.Name = "Báo cáo sử dụng thuốc";

                // in phần header vào
                for (int i = 1; i <= dgvBaoCaoSuDungThuoc.Columns.Count; i++)
                {
                    worksheet.Cells[1, i] = dgvBaoCaoSuDungThuoc.Columns[i - 1].HeaderText;
                    worksheet.Cells[1, i].Font.Bold = true;
                    worksheet.Cells[1, i].Font.Color = Color.Red;
                    worksheet.Cells[1, i].ColumnWidth = 10;
                }

                // đổ dữ liệu vào excel 
                for (int i = 0; i < dgvBaoCaoSuDungThuoc.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvBaoCaoSuDungThuoc.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvBaoCaoSuDungThuoc.Rows[i].Cells[j].Value.ToString();
                    }
                }

                // lưu lại file
                workbook.SaveAs(fileName);

                excel.Quit();
                MessageBox.Show("Xuất dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            // xuất báo cáo ra file excel
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // gọi hàm in ra file excel
                printToExcel(dgvBaoCaoSuDungThuoc, saveFileDialog1.FileName);
            }    
        }
    }
}
