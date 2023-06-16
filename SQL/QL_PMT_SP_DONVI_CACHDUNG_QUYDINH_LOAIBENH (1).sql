use QLPHONGMACHTU
go

--Đơn vị
--xem đơn vị trong database 

CREATE PROC spGetAllDonVi
as
begin
	Select MaDV as N'Mã đơn vị', TenDV as N'Tên đơn vị'
	from DONVI
end
go

CREATE PROC spAddDonVi
@MaDonVi char(5),
@TenDonVi Nvarchar(40)
as
begin
	insert into DONVI(MaDV, TenDV) values (@MaDonVi, @TenDonVi);
end

go

CREATE PROC spCheckDonVi
@MaDonVi char(5),
@TenDonVi Nvarchar(40)
as
begin
	if exists(select * from DONVI where MaDV = @MaDonVi or TenDV = @TenDonVi)
		select 1 as code
	else select 0 as code
end
go
--button Xóa 

create proc spDeleteDonVi
@MaDonVi char(5)
as
begin
	DELETE FROM DONVI
	where MaDV = @MaDonVi;
end
go 

--button Sửa

create proc spSuaDonVi
@MaDonVi char(5),
@TenDonVi Nvarchar(40)
as
begin
	update DONVI
	set TenDV = @TenDonVi
	where MaDV = @MaDonVi
end
go
---Cách Dùng
--xem bảng cách dùng
CREATE PROC spGetAllCachDung
as
begin
	Select MaCD as N'Mã Cách Dùng', TenCD as N'Tên Cách Dùng'
	from CACHDUNG
end
go

--check cách dùng
create PROC spCheckCachDung
@MaCachDung char(5),
@TenCachDung Nvarchar(40)
as
begin
	if exists(select * from CACHDUNG where MaCD = @MaCachDung or TenCD = @TenCachDung)
		select 1 as code
	else select 0 as code
end
go

alter PROC spCheckCachDung_Sua
@TenCachDung Nvarchar(40)
as
begin
	if exists(select * from CACHDUNG where TenCD = @TenCachDung)
		select 1 as code
	else select 0 as code
end
go

--thêm cách dùng
CREATE PROC spAddCachDung
@MaCachDung char(5),
@TenCachDung Nvarchar(40)
as
begin
	insert into CACHDUNG(MaCD, TenCD) values (@MaCachDung, @TenCachDung);
end
go

--Xóa cách dùng
create proc spDeleteCachDung
@MaCachDung char(5)
as
begin
	DELETE FROM CACHDUNG
	where MaCD = @MaCachDung;
end
go

--Sửa cách Dùng
create proc spSuaCachDung
@MaCachDung char(5),
@TenCachDung Nvarchar(40)
as
begin
	update CACHDUNG
	set TenCD = @TenCachDung
	where MaCD = @MaCachDung
end
go

---Quy Định
-- show các tham số

create proc spGetAllThamSo
as
begin
	select TenThamSo as N'Tên Tham Số', GiaTri as N'Giá Trị'
	from THAMSO
end
go

create PROC spCheckThamSo
@TenThamSo Nvarchar(40),
@GiaTri int
as
begin
	if exists(select * from THAMSO where TenThamSo = @TenThamSo or GiaTri = @GiaTri)
		select 1 as code
	else select 0 as code
end
go

--Sửa Tham Số
ALTER proc spSuaThamSo
@TenThamSo nvarchar(40),
@GiaTri int
as
begin
	update THAMSO
	set GiaTri = @GiaTri
	where TenThamSo = @TenThamSo
end
go

--- Loại Bệnh
--in toàn bộ bảng loại bệnh
CREATE PROC spGetAllLoaiBenh
as
begin
	Select MaLB as N'Mã loại bệnh', TenLB as N'Tên loại bệnh'
	from LOAIBENH
end
go

--thêm loại bệnh
CREATE PROC spAddLoaiBenh
@MaLoaiBenh char(5),
@TenLoaiBenh Nvarchar(40)
as
begin
	insert into LOAIBENH(MaLB, TenLB) values (@MaLoaiBenh, @TenLoaiBenh);
end
go

--kiểm tra tồn tại loại bệnh đó chưa?
CREATE PROC spCheckLoaiBenh
@MaLoaiBenh char(5),
@TenLoaiBenh Nvarchar(40)
as
begin
	if exists(select * from LOAIBENH where MaLB = @MaLoaiBenh or TenLB = @TenLoaiBenh)
		select 1 as code
	else select 0 as code
end
go

-- xóa loại bệnh
create proc spDeleteLoaiBenh
@MaLoaiBenh char(5)
as
begin
	DELETE FROM LOAIBENH
	where MaLB = @MaLoaiBenh;
end
go

-- sửa loại bệnh
create proc spSuaLoaiBenh
@MaLoaiBenh char(5),
@TenLoaiBenh Nvarchar(40)
as
begin
	update LOAIBENH
	set TenLB = @TenLoaiBenh
	where MaLB = @MaLoaiBenh
end
go
