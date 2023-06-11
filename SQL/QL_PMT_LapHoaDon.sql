use QLPHONGMACHTU
go

-- viết SP cho thao tác lập hóa đơn 
-- load danh sách phiếu khám được lập theo ngày 
CREATE PROC spGetPhieuKhamWithNgay
@NgayLap smalldatetime
