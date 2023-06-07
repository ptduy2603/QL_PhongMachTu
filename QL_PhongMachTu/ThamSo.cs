using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QL_PhongMachTu
{
    static public class ThamSo
    {
        public static int getTienKham()
        {
            SqlConnection con = Connection.getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select GiaTri from THAMSO where TenThamSo = 'TienKhamCoBan'";
            cmd.Connection = con;
            object tienKham = cmd.ExecuteScalar(); 
            con.Close();
            return Convert.ToInt32(tienKham);           
        }

        public static int getBenhNhanToiDa()
        {
            SqlConnection con = Connection.getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select GiaTri from THAMSO where TenThamSo = 'SoBenhNhanToiDa'";
            cmd.Connection = con;
            object benhNhanToiDa = cmd.ExecuteScalar();
            con.Close();
            return Convert.ToInt32(benhNhanToiDa);
        }
    }
}
