use QLPHONGMACHTU
go

-- Sp load báo cáo sử dụng thuốc trong tháng 
CREATE PROC spGetBaoCaoSuDungThuoc
@Thang int,
@Nam int
as
begin
	SELECT lt.TenLT as N'Thuốc', dv.TenDV as N'Đơn vị tính', bc.SoLuongDung as N'Số lượng dùng', bc.SoLanDung as N'Số lần dùng'
	from LOAITHUOC lt join DONVI dv on lt.MaDV = dv.MaDV
	left join BAOCAOSUDUNGTHUOC bc on lt.MaLT = bc.MaLT
	WHERE bc.Thang = @Thang and bc.Nam = @Nam
	order by bc.SoLuongDung desc, bc.SoLanDung desc
end

-- sp load báo cáo doanh thu theo tháng 
create PROC spCreateBaoCaoDoanhThuThang
@Thang int, 
@Nam int
as
begin
	DECLARE @month char(2)
	if @Thang < 10
	begin
		set @month = '0'+CONVERT(char(1), @Thang)
	end
	SELECT CONVERT(char(2), Ngay)+'/'+@month+'/'+CONVERT(char(4), @Nam) as N'Ngày' , SoBenhNhan as N'Số bệnh nhân', DoanhThu as N'Doanh thu', TyLe*100 as N'Tỷ lệ(%)'
	FROM CT_BAOCAODOANHTHU 
	WHERE Thang = @Thang and Nam = @Nam
	order by Ngay ASC
end