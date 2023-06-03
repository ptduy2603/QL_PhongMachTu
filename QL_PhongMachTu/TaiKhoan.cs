using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QL_PhongMachTu
{
    // class này chứa tài khoản hiện tại đang login vào hệ thống phần mềm
     public class TaiKhoan
    {
        #region Properties
        public static string tenDangNhap { get; set; }
        public static string matKhau { get; set; }
        public static int loaiTaiKhoan { get; set; }
        // loại tài khoản 1 nếu là admin và 2 nếu là user
        #endregion
    }
}
