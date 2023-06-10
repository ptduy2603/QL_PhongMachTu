using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QL_PhongMachTu
{
    public class PhieuNhapThuoc
    {
        // hàm tạo mã tự động cho phiếu nhập thuốc
        public static string getAutoId()
        {
            string sql = @"select * from PHIEUNHAPTHUOC";
            // tăng mã tự động cho đối tượng bệnh nhân 
            SqlConnection con = Connection.getConnection();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            string id = "";

            // nếu data chưa có dữ liệu thì khởi tạo mã bằng 1
            if (dt.Rows.Count <= 0)
            {
                id = "PN001";
            }
            else
            {
                // nếu bảng đã có dữ liệu thì dùng một biến để lấy ra vị trí hiện tại và + lên 1
                int index;
                id = "PN";
                index = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 3));
                index++;
                if (index < 10)
                {
                    id = id + "00";
                }
                else if (index < 100)
                {
                    id = id + "0";
                }

                id = id + index.ToString();
            }

            return id;
        }

        public PhieuNhapThuoc()
        {

        }
         public PhieuNhapThuoc(string maPhieuNhapThuoc = "", string maLoaiThuoc = "", int soLuong = 0, int donGiaNhap = 0)
         {
            if (String.IsNullOrEmpty(maPhieuNhapThuoc.Trim()))
                this.maPhieuNhapThuoc = getAutoId();            
            else
                this.maPhieuNhapThuoc = maPhieuNhapThuoc;

            this.maLoaiThuoc = maLoaiThuoc;
            this.soLuong = soLuong;
            this.donGiaNhap = donGiaNhap;
         }

        public string maPhieuNhapThuoc { get; set; }    
        public string maLoaiThuoc { get; set; }
        public int soLuong { get; set; }
        public int donGiaNhap { get; set; }
    }
}
