use QLPHONGMACHTU
go

-- viết SP cho thao tác lập hóa đơn 
-- load danh sách phiếu khám được lập theo ngày và sắp xếp tăng dần theo thời gian lập phiếu khám
create PROC spGetPhieuKhamWithNgayLap
@NgayLap smalldatetime
as
begin
	SELECT MaPK as N'Mã phiếu khám', MaBN as N'Mã bệnh nhân' , MaLB as N'Mã loại bệnh', TrieuChung as N'Triệu chứng' , TienThuoc as N'Tiền thuốc'
	from PHIEUKHAMBENH
	where DAY(NgayKham) = DAY(@NgayLap) and MONTH(NgayKham) = MONTH(@NgayLap) and YEAR(NgayKham) = YEAR(@NgayLap)
	and MaPK not in (select MaPK from HOADON)
	order by NgayKham asc
end
go

-- Lấy ra các thông tin trên hóa đơn dựa vào mã phiếu khám
CREATE PROC spGetDataWithMaPK
@MaPK char(5)
as
begin
	SELECT bn.HoTen , pk.NgayKham , pk.TienThuoc
	FROM PHIEUKHAMBENH pk, BENHNHAN bn
	WHERE pk.MaBN = bn.MaBN and pk.MaPK = @MaPK
end
go

-- load chi tiết tất cả thuốc dùng trong phiếu khám đổ vào bảng đơn thuốc
CREATE PROC spGetDonThuocWithMaPK
@MaPK char(5)
as
begin
	select lt.TenLT as N'Tên thuốc', dv.TenDV as 'Đơn vị' , cd.TenCD as 'Cách dùng' ,ct.SoLuong as N'Số lượng' , ct.DonGia as 'Đơn giá' , ct.SoLuong*ct.DonGia as 'Thành tiền'
	from CT_PHIEUKHAMBENH ct , LOAITHUOC lt , DONVI dv , CACHDUNG cd
	WHERE ct.MaPK = @MaPK and ct.MaLT = lt.MaLT and lt.MaDV = dv.MaDV and lt.MaCD = cd.MaCD
end
go

-- Thêm một thông tin hóa đơn mới vào database 
CREATE PROC spAddNewHoaDon
@MaHD char(5),
@MaPK char(5),
@TienKham int,
@TongTien int
as
begin
	insert into HOADON(MaHD, MaPK, TienKham , TongTien)
	values (@MaHD, @MaPK, @TienKham , @TongTien)
end
go

-- Sp lưu trữ báo cáo doanh thu
CREATE PROC AddNewBaoCaoDoanhThu
@Thang int,
@Nam int,
@DoanhThu int
as
begin
	-- Nếu chưa có dữ liệu tháng + năm trong database thì thêm mới , không thì chỉ cập nhật lại tổng doanh thu
	if exists (select * from BAOCAODOANHTHU where Thang = @Thang and Nam = @Nam)
	begin
		UPDATE BAOCAODOANHTHU SET TongDoanhThu = TongDoanhThu + @DoanhThu
		WHERE Thang = @Thang and Nam = @Nam
	end
	else
	begin
		insert into BAOCAODOANHTHU(Thang, Nam, TongDoanhThu)
		values (@Thang , @Nam, @DoanhThu)
	end
end
go

-- sp thêm một chi tiết báo cáo doanh thu vào bảng chi tiết
CREATE PROC AddNewChiTietBaoCaoDoanhThu
@Ngay int,
@Thang int,
@Nam int,
@DoanhThu int
as
begin
	-- Nếu chưa có ngày , tháng năm này thì thêm mới nếu có thì cập nhật lại các thông số
	if exists (select * from CT_BAOCAODOANHTHU where Ngay = @Ngay and Thang = @Thang and Nam = @Nam)
	begin
		UPDATE CT_BAOCAODOANHTHU 
		SET SoBenhNhan = SoBenhNhan + 1, DoanhThu = DoanhThu + @DoanhThu
		WHERE Ngay = @Ngay and Thang = @Thang and Nam = @Nam
	end
	else
	begin
		insert into CT_BAOCAODOANHTHU (Ngay, Thang , Nam , SoBenhNhan, DoanhThu)
		values (@Ngay, @Thang, @Nam , 1 , @DoanhThu)
	end

	-- Cập nhật lại tỷ lệ cho toàn bộ các ngày khác trong bảng thông qua con trỏ
	DECLARE @TongDoanhThu int
	DECLARE @ngaydoanhthu int
	DECLARE @doanhthungay int
	SELECT @TongDoanhThu = TongDoanhThu from BAOCAODOANHTHU where Thang = @Thang and Nam = @Nam;
	DECLARE cursorChiTietDoanhThu CURSOR FOR SELECT Ngay, DoanhThu from CT_BAOCAODOANHTHU where Thang = @Thang and Nam = @Nam

	open cursorChiTietDoanhThu
	FETCH NEXT FROM cursorChiTietDoanhThu INTO @ngaydoanhthu , @doanhthungay

	WHILE @@FETCH_STATUS = 0
	BEGIN
		UPDATE CT_BAOCAODOANHTHU 
		SET TyLe = @doanhthungay*1.00/@TongDoanhThu
		WHERE Ngay = @ngaydoanhthu and Thang = @Thang and Nam = @Nam

		FETCH NEXT FROM cursorChiTietDoanhThu INTO @ngaydoanhthu, @doanhthungay
	END

	CLOSE cursorChiTietDoanhThu --đóng con trỏ
	DEALLOCATE cursorChiTietDoanhThu  --giải phóng tài nguyên cho con trỏ
end
go


