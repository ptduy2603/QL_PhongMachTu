use QLPHONGMACHTU
go

-- viết các store procedure cho việc quản lí bệnh nhân 
-- lấy tất cả thông tin bênh nhân 
CREATE PROC spGetAllPatient
as
begin
	select * from BENHNHAN
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