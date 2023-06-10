using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QL_PhongMachTu
{
    public class Thuoc
    {

        public Thuoc()
        {

        }

        public Thuoc(string maThuoc = "", string tenThuoc = "", string donVi = "", string cachDung = "", int giaNhap = 0, int giaBan = 0)
        {
            if(String.IsNullOrEmpty(maThuoc.Trim()))
            {
                this.maThuoc = getAutoId();
            }
            else
                this.maThuoc = maThuoc;
            this.tenThuoc = tenThuoc;
            this.donVi = donVi;
            this.cachDung = cachDung;
            this.giaNhap = giaNhap;
            this.giaBan = giaBan;
        }

        //viết hàm sinh mã tự động
        public static string getAutoId()
        {
            string sql = @"select * from LOAITHUOC";
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
                id = "LT001";
            }
            else
            {
                // nếu bảng đã có dữ liệu thì dùng một biến để lấy ra vị trí hiện tại và + lên 1
                int index;
                id = "LT";
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

        public string maThuoc { get; set; }
        public string tenThuoc { get; set;}
        public string donVi { get; set; }   
        public string cachDung { get; set; }
        public int giaNhap { get; set; }    
        public int giaBan { get; set; }

        
    }
}
