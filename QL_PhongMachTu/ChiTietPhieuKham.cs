using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QL_PhongMachTu
{
    public class ChiTietPhieuKham 
    {
        public ChiTietPhieuKham(string maPhieuKham = "", string maLoaiThuoc = "", int soLuong = 0)
        {
            if (String.IsNullOrEmpty(maPhieuKham.Trim()))
                this.maPhieuKham = PhieuKham.getAutoId();
            else
                this.maPhieuKham = maPhieuKham;            
            
            this.maLoaiThuoc = maLoaiThuoc;

            this.SoLuong = soLuong;

            // tự cập nhật đơn giá bằng giá bán hiện tại của loại thuốc
            SqlConnection con = Connection.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = con,
                CommandType = CommandType.StoredProcedure,
                CommandText = "spGetDonGiaBan",
            };
            cmd.Parameters.AddWithValue("@MaLT", this.maLoaiThuoc);
            object price = cmd.ExecuteScalar();
            con.Close();
            this.DonGia = Convert.ToInt32(price);
        }

        public string maPhieuKham { get; set; }
        public string maLoaiThuoc { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
    }
}
