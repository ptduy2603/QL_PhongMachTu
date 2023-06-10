use QLPHONGMACHTU
go

-- Thêm một phiếu nhập mới vào bảng phiếu nhập
CREATE PROC spAddPhieuNhapThuoc
@MaPN char(5),
@NgayLap smalldatetime,
@TongTien int
as
begin
	insert into PHIEUNHAPTHUOC(MaPN, NgayLap, TongTien)
	values (@MaPN ,@NgayLap ,@TongTien)
end

-- Thêm chi tiết phiếu nhập vào bảng chi tiết 
CREATE PROC spAddChiTietPhieuNhapThuoc
@MaPN char(5),
@MaLT char(5),
@SoLuong int,
@DonGiaNhap int
as
begin
	insert into CT_PHIEUNHAPTHUOC(MaPN ,MaLT, SoLuong ,DonGiaNhap)
	values (@MaPN, @MaLT ,@SoLuong, @DonGiaNhap);
end

-- Cập nhật lại số lượng tồn cho loại thuốc khi nhập và đơn giá nhập
CREATE PROC spUpdateLoaiThuocKhiNhap
@MaLT char(5),
@SoLuongNhap int,
@DonGiaNhap int
as
begin
	UPDATE LOAITHUOC
	SET DonGiaNhap = @DonGiaNhap,
	SoLuongTon = SoLuongTon + @SoLuongNhap
	WHERE MaLT = @MaLT
end

