use QLPHONGMACHTU
go

-- viết các store procedure cho việc quản lí bệnh nhân 
-- lấy tất cả thông tin bênh nhân 
CREATE PROC spGetAllPatient
as
begin
	select * from BENHNHAN
end