-- Viết các store procedure cho data base phòng mạch tứ
use QLPHONGMACHTU
go

-- Tài khoản
-- check tài khoản và mật khẩu có thuộc database hay không
-- nếu có và là admin thì trả về 0 , nếu có và là user thì trả về 1 , sai mật khẩu thì trả về 2 và không tồn tại trả về 3
CREATE PROC spCheckLogin 
@TenDangNhap varchar(40),
@MatKhau varchar(40)
as
begin
	if exists (select * from NGUOIDUNG where TenDangNhap = @TenDangNhap and MatKhau = @MatKhau and MaNhom = 1)
        select 0 as code
    else if exists (select * from NGUOIDUNG where TenDangNhap = @TenDangNhap and MatKhau = @MatKhau and MaNhom = 2)
        select 1 as code
    else if exists(select * from NGUOIDUNG where TenDangNhap = @TenDangNhap and MatKhau != @MatKhau) 
        select 2 as code
    else select 3 as code
end

-- Thêm một tài khoản mới 
-- Thay đổi quyền và thông tin của tài khoản cũ