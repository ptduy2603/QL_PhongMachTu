using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

// class xây dựng để hỗ trợ việc kết nối xuống database
namespace QL_PhongMachTu
{
   
    public class Connection
    {
        private static string connectionString = @"Data Source=DESKTOP-M15KQ9A\SQLEXPRESS;Initial Catalog=QLPHONGMACHTU;Integrated Security=True";
        
        // gọi phương thức để tạo ra một đối tượng mở kết nối đến database
        public static SqlConnection getConnection()
        {
            return new SqlConnection(connectionString);
        }
        
    }
}
