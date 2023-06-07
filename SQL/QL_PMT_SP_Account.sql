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
go

-- Thay đổi thông tin tài khoản cho người dùng (chỉ đổi được tên đăng nhâp hoặc mật khẩu)
CREATE PROC spChangeAccountByUser
@TenDangNhap varchar(40),
@MatKhauMoi varchar(40)
as
begin
	UPDATE NGUOIDUNG
	SET MatKhau = @MatKhauMoi
	WHERE TenDangNhap = @TenDangNhap
end
go

-- Thay đổi thông tin tài khoản cho admin (mật khẩu + loại tài khoản)
CREATE PROC spUpdateAccount
@TenDangNhap varchar(40),
@MatKhau varchar(40),
@MaNhom int
as
begin
	UPDATE NGUOIDUNG 
	SET MatKhau = @MatKhau , MaNhom = @MaNhom
	WHERE TenDangNhap = @TenDangNhap
end

-- Thêm một tài khoản mới (admin)
CREATE PROC spAddNewAccount
@TenDangNhap varchar(40),
@MatKhau varchar(40),
@MaNhom int
as 
begin
	insert into NGUOIDUNG(TenDangNhap, MatKhau , MaNhom) values(@TenDangNhap, @MatKhau, @MaNhom);
end

-- Xóa một tài khỏa (admin)
CREATE PROC spDeleteAccount
@TenDangNhap varchar(40)
as 
begin
	DELETE FROM NGUOIDUNG
	WHERE TenDangNhap = @TenDangNhap;
end

-- Lấy ra danh sách tất cả các tài khoản hiện tại có trong hệ thống 
CREATE PROC spGetAllAccount
as
begin
	SELECT nd.TenDangNhap as N'Tên Đăng Nhập' , nd.MatKhau N'Mật Khẩu', nnd.TenNhom N'Loại Tài Khoản'
	FROM NGUOIDUNG nd, NHOMNGUOIDUNG nnd
	WHERE nd.MaNhom = nnd.MaNhom
end
go

-- Kiểm tra tên đăng nhập đã tồn tại trong hệ thống hay chưa
CREATE PROC spCheckUserName
@TenDangNhap varchar(40)
as
begin
	if exists (select * from NGUOIDUNG where TenDangNhap = @TenDangNhap)
		select 1 as code
	else select 0 as code
end
go

-- Viết sp cho bảng tham số :
-- Thay đổi giá trị của tham số 

-- Thêm mới một tham số 

