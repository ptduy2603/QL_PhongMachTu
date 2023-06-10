-- Tìm kiếm đơn vị và cách dùng dựa theo mã phiếu khám
CREATE PROC spTimDonViCachDungTheoThuoc
@MaLT char(5)
as
begin
	SELECT dv.TenDV, cd.TenCD 
	FROM LOAITHUOC lt, DONVI dv, CACHDUNG cd
	WHERE lt.MaDV = dv.MaDV and lt.MaCD = cd.MaCD and lt.MaLT = @MaLT
end
-- Viết hàm thêm một phiếu khám mới
-- Viết hàm lấy tổng số phiều khám đã được lập trong ngày

EXEC spTimDonViCachDungTheoThuoc LT002