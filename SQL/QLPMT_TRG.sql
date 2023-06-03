-- Viết các trigger ràng buộc dữ liệu
use QLPHONGMACHTU
go
-- Viết các trigger ràng buộc dữ liệu 
-- Năm sinh của bệnh nhân phải <= năm hiện tại
create trigger trg_bn_namsinh ON BENHNHAN
for INSERT,UPDATE
as
begin
	SET NOCOUNT ON;
	declare @namsinh int;
	SELECT @namsinh = NamSinh from inserted;
	if @namsinh > YEAR(GETDATE())
	begin	
		print N'Năm sinh phải nhỏ hơn hoặc bằng năm hiện tại'
		rollback transaction
	end
end
go

-- năm khám bệnh phải >= năm sinh của bệnh nhân (bảng phiếu khám bệnh)
CREATE TRIGGER trg_pk_bn_ngaykham ON PHIEUKHAMBENH 
for insert, update 
as 
begin
	declare @namkhambenh int;
	declare @namsinh int;
	SELECT @namkhambenh = YEAR(NgayKham) from inserted;
	SELECT @namsinh = NamSinh FROM BENHNHAN bn, inserted i
	WHERE bn.MaBN = i.MaBN;
	if @namkhambenh < @namsinh
	begin
		print N'Năm khám bệnh phải lớn hơn hoặc bằng năm sinh'
		rollback transaction
	end
end
go

-- năm khám bệnh phải >= năm sinh của bệnh nhân (bảng bệnh nhân)
CREATE TRIGGER trg_nb_pk_ngaykham ON BENHNHAN 
for update 
as 
begin
	declare @namsinh int
	declare @namkhambenh int;
	SELECT @namsinh = NamSinh from inserted;
	SELECT @namkhambenh = YEAR(NgayKham) FROM PHIEUKHAMBENH pk, inserted i WHERE pk.MaBN = i.MaBN;

	if @namkhambenh < @namsinh
	begin
		print N'Năm khám bệnh phải lớn hơn hoặc bằng năm sinh'
		rollback transaction
	end
end
go

-- Đơn giá nhập thuốc phải <= đơn giá bán thuốc (CT_Phiếu nhập)
CREATE TRIGGER trg_ctpnt_dongianhap ON CT_PHIEUNHAPTHUOC
for insert, update
as
begin
	declare @dongianhap int;
	declare @mathuoc char(5);
	declare @soluongnhap int;

	SELECT @dongianhap = DonGiaNhap from inserted;
	SELECT @soluongnhap
	SELECT @mathuoc = MaLT from inserted;

	UPDATE LOAITHUOC 
	SET DonGiaNhap = @dongianhap
	WHERE LOAITHUOC.MaLT = @mathuoc;
end
go

-- Thay đổi số lượng tồn sau mỗi lần thêm xóa sửa một loại thuốc
CREATE TRIGGER trg_ctpnt_lt_insert_soluongton ON CT_PHIEUNHAPTHUOC
for insert , update 
as 
begin
	declare @soluongton int;
	declare @maloaithuoc char(5);
	declare @soluong int;
	SELECT @soluongton = SoLuongTon FROM LOAITHUOC lt , inserted i WHERE lt.MaLT = i.MaLT;
	SELECT @maloaithuoc = MaLT from inserted;
	SELECT @soluong = SoLuong from inserted;

	SELECT @soluongton = @soluongton + @soluong;

	 UPDATE LOAITHUOC SET SoLuongTon = @soluongton
	 WHERE LOAITHUOC.MaLT = @maloaithuoc;
end
go

CREATE TRIGGER trg_ctpnt_lt_del_soluongton ON CT_PHIEUNHAPTHUOC
for delete
as 
begin
	declare @soluongton int;
	declare @maloaithuoc char(5);
	declare @soluong int;
	SELECT @soluongton = SoLuongTon FROM LOAITHUOC lt , deleted d WHERE lt.MaLT = d.MaLT;
	SELECT @maloaithuoc = MaLT from deleted;
	SELECT @soluong = SoLuong from deleted;

	SELECT @soluongton = @soluongton - @soluong;

	 UPDATE LOAITHUOC SET SoLuongTon = @soluongton
	 WHERE LOAITHUOC.MaLT = @maloaithuoc;
end
go

CREATE TRIGGER trg_lt_dongianhap ON LOAITHUOC
for insert, update 
as 
begin
	declare @dongianhap int;
	declare @dongiaban int;
	SELECT @dongiaban = DonGiaBan from inserted;
	SELECT @dongianhap = DonGiaNhap from inserted;

	if @dongiaban < @dongianhap
	begin
		print N'Đơn giá bán phải lớn hơn hoặc bằng đơn giá nhâp'
		rollback transaction
	end	
end
go

-- Thuộc tính “TienThuoc” của phiếu khám bệnh phải bằng SUM(SoLuong*DonGia) của tất cả các loại thuốc có trong phiếu khám đó
CREATE TRIGGER trg_pk_tienthuoc ON PHIEUKHAMBENH
FOR UPDATE 
as
begin
	if UPDATE(TienThuoc)
	begin
		declare @tienthuoc int;
		declare @tongtienthuoc int;

		SELECT @tongtienthuoc = SUM(SoLuong*DonGia) FROM inserted i , CT_PHIEUKHAMBENH ct
								WHERE i.MaPK = ct.MaPK;
		SELECT @tienthuoc = TienThuoc from inserted;

		if @tienthuoc != @tongtienthuoc 
		begin
			print N'Tính sai tiền thuốc'
			rollback transaction
		end
	end
end
go

-- Thuộc tính “TienThuoc” của phiếu khám bệnh phải bằng SUM(SoLuong*DonGia) của tất cả các loại thuốc có trong phiếu khám đó (bảng ct_phiếu khám)
CREATE TRIGGER trg_ctpk_pk_insert ON CT_PHIEUKHAMBENH
for insert 
as 
begin
	declare @tienthuoc int;
	declare @maphieukham int;
	SELECT @maphieukham = MaPK from inserted;
	SELECT @tienthuoc = SoLuong*DonGia FROM inserted;

	UPDATE PHIEUKHAMBENH SET TienThuoc = TienThuoc + @tienthuoc
	WHERE PHIEUKHAMBENH.MaPK = @maphieukham
end
go

CREATE TRIGGER trg_ctpk_pk_del ON CT_PHIEUKHAMBENH
for delete 
as
begin
	declare @tienthuoc int;
	declare @maphieukham int;
	SELECT @maphieukham = MaPK from deleted;
	SELECT @tienthuoc = SoLuong*DonGia FROM deleted;

	UPDATE PHIEUKHAMBENH SET TienThuoc = TienThuoc - @tienthuoc
	WHERE PHIEUKHAMBENH.MaPK = @maphieukham
end


