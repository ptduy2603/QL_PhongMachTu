use QLPHONGMACHTU
go

----tra cứu bệnh nhân
-- Tìm kiếm thông tin bệnh nhân theo các trường dữ liệu input 
ALTER proc spTraCuuBenhNhan
@HoTen nvarchar(40),
@GioiTinh char(3),
@NamSinh varchar(4),
@DiaChi nvarchar(40),
@MaBenhNhan char(5),
@NgayKham smalldatetime,
@LoaiBenh nvarchar(40),
@TrieuChung nvarchar(40)
as
begin
	if trim(@GioiTinh) = ''
	begin 
		set @GioiTinh = 'N%%'
	end

	select bn.MaBN as N'Mã Bệnh Nhân', bn.HoTen as N'Họ Tên',pkb.NgayKham as N'Ngày Khám', lb.TenLB as N'Loại Bệnh', pkb.TrieuChung as N'Triệu Chứng'
	from BENHNHAN bn, PHIEUKHAMBENH pkb,LOAIBENH lb
	where bn.MaBN = pkb.MaBN and pkb.MaLB = lb.MaLB
	and lower(HoTen) like N'%'+lower(trim(@HoTen))+'%'
	and CONVERT(varchar(10),NgayKham,103) like '%'+CONVERT(varchar(10),@NgayKham,103)+'%'
	and CONVERT(varchar(4), bn.NamSinh) like '%'+@NamSinh+'%'
	and lower(DiaChi) like N'%'+lower(trim(@DiaChi))+'%'
	and lower(TenLB) like N'%'+lower(trim(@LoaiBenh))+'%'
	and lower(TrieuChung) like N'%'+lower(trim(@TrieuChung))+'%'
	and bn.GioiTinh like @GioiTinh
	and LOWER(bn.MaBN) like '%'+lower(trim(@MaBenhNhan))+'%'
end

