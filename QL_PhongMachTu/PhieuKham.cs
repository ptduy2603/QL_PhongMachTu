using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QL_PhongMachTu
{
    public class PhieuKham
    {
        public PhieuKham()
        {

        }

        public PhieuKham(string maPhieuKham = "", DateTime ngayKham = new DateTime(), string maBenhNhan = "", string maLoaiBenh = "", string trieuChung = "", int tienThuoc = 0)
        {
            if (String.IsNullOrEmpty(maPhieuKham.Trim()))
            {
                // chưa nhập mã phiếu khám thì sinh mã tự động
                this.maPhieuKham = getAutoId();
            }
            else
            {
                this.maPhieuKham = maPhieuKham;
            }
            this.ngayKham = ngayKham;
            this.maBenhNhan = maBenhNhan;
            this.maLoaiBenh = maLoaiBenh;
            this.trieuChung = trieuChung;
            this.tienThuoc = tienThuoc;
        }

        // tạo function random mã phiếu khám tự động
        public static string getAutoId()
        {
            string sql = @"select * from PHIEUKHAMBENH";
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
                id = "PK001";
            }
            else
            {
                // nếu bảng đã có dữ liệu thì dùng một biến để lấy ra vị trí hiện tại và + lên 1
                int index;
                id = "PK";
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

        public string maPhieuKham { get; set; }
        public DateTime ngayKham { get; set; }
        public string maBenhNhan { get; set; }
        public string maLoaiBenh { get; set; }

        public string trieuChung { get; set; }
        public int tienThuoc { get; set; }
              
    }
}
