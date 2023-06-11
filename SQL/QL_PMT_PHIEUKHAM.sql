-- Tìm kiếm đơn vị và cách dùng dựa theo mã phiếu khám
CREATE PROC spTimDonViCachDungTheoThuoc
@MaLT char(5)
as
begin
	SELECT dv.TenDV, cd.TenCD 
	FROM LOAITHUOC lt, DONVI dv, CACHDUNG cd
	WHERE lt.MaDV = dv.MaDV and lt.MaCD = cd.MaCD and lt.MaLT = @MaLT
end
go

-- Lấy số lượng tồn theo mã loại thuốc
CREATE PROC spGetSoLuongTon
@MaLT char(5)
as
begin
	SELECT SoLuongTon from LOAITHUOC
	WHERE MaLT = @MaLT
end
go

-- Lấy giá bán theo mã loại thuốc 
CREATE PROC spGetDonGiaBan
@MaLT char(5)
as
begin
	select DonGiaBan from LOAITHUOC where MaLT = @MaLT
end
go

-- Lấy ra số lượt phiếu khám đã lập trong ngày hiện tại
CREATE PROC spGetSoPhieuKham
@NgayKham smalldatetime
as
begin
	SELECT COUNT(*) FROM PHIEUKHAMBENH
	WHERE DAY(NgayKham) = DAY(@NgayKham) and MONTH(NgayKham) = MONTH(@NgayKham) and YEAR(NgayKham) = YEAR(@NgayKham)
end
go

-- sp Thêm phiếu khám bệnh mới 
CREATE PROC spAddPhieuKhamBenh
@MaPK char(5),
@NgayKham smalldatetime,
@MaBN char(5),
@MaLB char(5),
@TrieuChung nvarchar(40),
@TienThuoc int
as
begin
	insert into PHIEUKHAMBENH(MaPK, NgayKham, MaBN , MaLB , TrieuChung , TienThuoc)
	values (@MaPK, @NgayKham , @MaBN , @MaLB ,@TrieuChung , @TienThuoc)
end
go

-- sp Thêm chi tiết phiếu khám bệnh
CREATE PROC AddChiTietPhieuKham
@MaPK char(5),
@MaLT char(5),
@SoLuong int,
@DonGia int
as
begin
	insert into CT_PHIEUKHAMBENH(MaPK, MaLT ,SoLuong , DonGia)
	values (@MaPK, @MaLT , @SoLuong ,@DonGia)
end
go

-- sp Thêm dữ liệu vào bảng báo cáo sử dụng thuốc
CREATE PROC AddBaoCaoDungThuoc
@Thang int,
@Nam int,
@MaLT char(5),
@SoLuongDung int
as 
begin
	-- kiểm tra nếu trong tháng/ năm đó thuốc đã có dùng rồi thì cập nhật , không thì thêm mới
	if exists(select * from BAOCAOSUDUNGTHUOC where Thang = @Thang and Nam = @Nam and MaLT = @MaLT)
	begin
		UPDATE BAOCAOSUDUNGTHUOC 
		SET SoLanDung = SoLanDung + 1, SoLuongDung = SoLuongDung + @SoLuongDung
		WHERE Thang = @Thang and Nam = @Nam and MaLT = @MaLT
	end
	else
	begin
		insert into BAOCAOSUDUNGTHUOC(Thang, Nam, MaLT ,SoLuongDung ,SoLanDung)
		values (@Thang ,@Nam ,@MaLT,  @SoLuongDung ,1)
	end
end
go

DROP TRIGGER trg_ctpk_pk_insert
go

-- SP Cập nhật lại số lượng thuốc trong kho 
CREATE PROC spUpdateSoLuongThuocKhiBan
@SoLuong int,
@MaLT char(5)
as
begin
	update LOAITHUOC set SoLuongTon = SoLuongTon - @SoLuong
	WHERE MaLT = @MaLT
end
go
