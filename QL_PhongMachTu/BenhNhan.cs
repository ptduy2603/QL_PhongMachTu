using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QL_PhongMachTu
{
     public class BenhNhan
    {
        public static string getAutoId()
        {
            string sql = @"select * from BENHNHAN";
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
                id = "BN001";
            }    
            else
            {
                // nếu bảng đã có dữ liệu thì dùng một biến để lấy ra vị trí hiện tại và + lên 1
                int index;
                id = "BN";
                index = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2,3));
                index++;
                if(index < 10)
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
        public BenhNhan()
        {

        }
        public BenhNhan(string maBenhNhan = "", string tenBenhNhan = "", string gioiTinh = "", int namSinh = 0, string diaChi = "")
        {
            if (String.IsNullOrEmpty(maBenhNhan))
                this.maBenhNhan = getAutoId();
            else
                this.maBenhNhan = maBenhNhan;
            this.tenBenhNhan = tenBenhNhan;
            this.gioiTinh = gioiTinh;
            this.namSinh = namSinh;
            this.diaChi = diaChi;
        }

        public string maBenhNhan { get; set; }
        public string tenBenhNhan { get; set; }
        public string gioiTinh { get; set; }  
        public int namSinh { get; set; }          
        public string diaChi { get; set; }  
        

    }
}
