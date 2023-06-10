use QLPHONGMACHTU
go

-- load data theo data base hiển thị của bảng thông tin thuốc
CREATE PROC spGetDataMedicine 
as
begin
	SELECT lt.MaLT , lt.TenLT , dv.TenDV, cd.TenCD, lt.DonGiaBan , lt.SoLuongTon
	FROM LOAITHUOC lt, DONVI dv, CACHDUNG cd
	WHERE lt.MaDV = dv.MaDV and lt.MaCD = cd.MaCD
end
go

-- thêm một loại thuốc mới vào database 
CREATE PROC spAddNewMedicine 
@MaLT char(5),
@TenLT nvarchar(40),
@MaDV char(5),
@MaCD char(5),
@DonGiaBan int
as 
begin
	insert into LOAITHUOC (MaLT, TenLT, MaDV, MaCD , SoLuongTon, DonGiaNhap, DonGiaBan)
	values (@MaLT, @TenLT, @MaDV, @MaCD, 0 , 0 , @DonGiaBan)
end
go

CREATE PROC spDeleteMedicine 
@MaLT char(5)
as
begin
	delete from LOAITHUOC 
	where MaLT = @MaLT
end
go

CREATE PROC spCheckMaLT
@MaLT char(5)
as
begin
	if exists (select * from LOAITHUOC where MaLT = @MaLT)
		select 1 as code
	else select 0 as code
end
go

CREATE PROC spUpdateMedicine 
@MaLT char(5),
@TenLT nvarchar(40),
@MaDV char(5),
@MaCD char(5),
@DonGiaBan int
as
begin 
	update LOAITHUOC 
	set TenLT = @TenLT, MaDV = @MaDV , MaCD = @MaCD , DonGiaBan = @DonGiaBan
	where MaLT = @MaLT
end

-- Hàm kiểm tra đơn giá nhập có nhỏ hơn hoặc bằng đơn giá bán hay không 
CREATE PROC spCheckDonGiaNhap
@DonGiaNhap int,
@MaLT char(5)
as
begin
	declare @DonGianBan int;
	SELECT @DonGianBan = DonGiaBan from LOAITHUOC where MaLT = @MaLT;
	if @DonGiaNhap <= @DonGianBan
		select 1 as code
	else
		select 0 as code
end

CREATE PROC spCheckDonGiaBan
@DonGiaBan int,
@MaLT char(5)
as
begin
	declare @DonGianNhap int;
	SELECT @DonGianNhap = DonGiaNhap from LOAITHUOC where MaLT = @MaLT;
	if @DonGiaBan >= @DonGianNhap
		select 1 as code
	else
		select 0 as code
end



