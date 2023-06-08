use QLPHONGMACHTU
go

--Đơn vị
--check xem đã tồn tại đơn vị trong database chưa

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

