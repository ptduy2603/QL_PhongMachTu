use QLPHONGMACHTU
go

-- viết các store procedure cho việc quản lí bệnh nhân 
-- Lấp ra tất cả các bệnh nhân
CREATE PROC spGetAllPatient
as
begin
	select * from BENHNHAN
end
go

-- Lấy ra các bệnh nhân chưa khám bệnh trong ngày khám truyền vào 
CREATE PROC spGetPatientWithNgayKham
@NgayKham smalldatetime
as
begin
	select * from BENHNHAN
	WHERE MaBN not in (SELECT MaBN from PHIEUKHAMBENH where NgayKham = @NgayKham)
end
go

-- Thêm một bệnh nhân mới vào data
CREATE PROC spAddPatient
@MaBN char(5),
@HoTen nvarchar(40),
@GioiTinh char(3),
@NamSinh int,
@DiaChi nvarchar(40)
as
begin
	insert into BENHNHAN(MaBN, HoTen, GioiTinh, NamSinh, DiaChi) 
	values (@MaBN, @HoTen, @GioiTinh, @NamSinh, @DiaChi)
end

-- Xóa một bệnh nhân 
CREATE PROC spDeletePatient
@MaBN char(5)
as
begin
	delete from BENHNHAN 
	where MaBN = @MaBN
end

-- Thay đổi thông tin bệnh nhân 
CREATE PROC spUpdatePatient 
@MaBN char(5),
@HoTen nvarchar(40),
@GioiTinh char(3),
@NamSinh int,
@DiaChi nvarchar(40)
as
begin
	UPDATE BENHNHAN 
	SET HoTen = @HoTen, GioiTinh = @GioiTinh , NamSinh = @NamSinh , DiaChi = @DiaChi
	WHERE MaBN = @MaBN
end