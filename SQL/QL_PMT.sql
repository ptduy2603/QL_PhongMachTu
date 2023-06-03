-- Tạo database + bảng dữ liệu
create database QLPHONGMACHTU
GO
use QLPHONGMACHTU
GO
-- Tạo các bảng dữ liệu 
create table BENHNHAN (
	MaBN char(5) PRIMARY KEY,
	HoTen nvarchar(40),
	GioiTinh char(3),
	NamSinh int,
	DiaChi nvarchar(40),
)

create table PHIEUKHAMBENH (
	MaPK char(5) PRIMARY KEY,
	NgayKham smalldatetime,
	MaBN char(5),
	MaLB char(5),
	TrieuChung nvarchar(40),
	TienThuoc int CHECK(TienThuoc>=0) DEFAULT 0
)

create table CT_PHIEUKHAMBENH (
	MaPK char(5) NOT NULL,
	MaLT char(5) NOT NULL,
	SoLuong int CHECK(SoLuong>=0),
	DonGia int CHECK(DonGia>=0),
	PRIMARY KEY (MaPK,MaLT)
)

create table LOAITHUOC (
	MaLT char(5) PRIMARY KEY,
	TenLT nvarchar(40),
	MaDV char(5),
	MaCD char(5),
	SoLuongTon int,
	DonGiaNhap int CHECK(DonGiaNhap>=0),
	DonGiaBan int CHECK(DonGiaBan>=0)
)

create table LOAIBENH(
	MaLB char(5) PRIMARY KEY,
	TenLB nvarchar(40)
)

create table DONVI (
	MaDV char(5) PRIMARY KEY,
	TenDV nvarchar(40),
)

create table CACHDUNG (
	MaCD char(5) PRIMARY KEY,
	TenCD nvarchar(40),
)

create table HOADON (
	MaHD char(5) PRIMARY KEY,
	MaPK char(5),
	TienKham int CHECK(TienKham>=0),
	TongTien int CHECK(TongTien>=0)
)

create table BAOCAODOANHTHU (
	Thang int NOT NULL,
	Nam int NOT NULL,
	TongDoanhThu int CHECK(TongDoanhThu>=0),
	PRIMARY KEY (Thang, Nam)
)

create table CT_BAOCAODOANHTHU (
	Ngay int NOT NULL,
	Thang int NOT NULL,
	Nam int NOT NULL,
	SoBenhNhan int CHECK(SoBenhNhan>=0),
	DoanhThu int CHECK(DoanhThu>=0),
	TyLe float(5),
	PRIMARY KEY(Ngay, Thang, Nam)
)

create table BAOCAOSUDUNGTHUOC(
	Thang int NOT NULL,
	Nam int NOT NULL,
	MaLT char(5) NOT NULL,
	SoLuongDung int CHECK(SoLuongDung>=0) DEFAULT 0,
	SoLanDung int CHECK(SoLanDung>=0)  DEFAULT 0,
	PRIMARY KEY (Thang, Nam, MaLT) 
)

create table PHIEUNHAPTHUOC (
	MaPN char(5) PRIMARY KEY,
	NgayLap smalldatetime,
	TongTien int CHECK(TongTien>=0)

)

create table CT_PHIEUNHAPTHUOC (
	MaPN char(5) NOT NULL,
	MaLT char(5) NOT NULL,
	SoLuong int CHECK(SoLuong>=0),
	DonGiaNhap int CHECK(DonGiaNhap>=0)
	PRIMARY KEY(MaPN, MaLT)	
)

-- Tạo bảng tham số 
create table THAMSO (
	TenThamSo nvarchar(40) PRIMARY KEY,
	GiaTri int,
)

-- Bảng dữ liệu cho chức năng phân quyền 
create table CHUCNANG (
	MaCN char(5) PRIMARY KEY,
	TenCN nvarchar(40),
	TenManHinhDuocLoad nvarchar(40)
)

create table NHOMNGUOIDUNG (
	MaNhom char(5) PRIMARY KEY,
	TenNhom nvarchar(40)
)

create table PHANQUYEN(
	MaNhom char(5) NOT NULL,
	MaCN char(5) NOT NULL,
	PRIMARY KEY(MaNhom, MaCN)
)

create table NGUOIDUNG(
	TenDangNhap varchar(40) PRIMARY KEY,
	MatKhau varchar(40),
	MaNhom char(5) NOT NULL
)

-- set khóa ngoại cho các quan hệ 
alter table PHIEUKHAMBENH
add constraint fk_pkb_bn FOREIGN KEY(MaBn) references BENHNHAN(MaBN)

alter table PHIEUKHAMBENH
add constraint fk_pkb_lb FOREIGN KEY(MaLB) references LOAIBENH(MaLB)

alter table CT_PHIEUKHAMBENH
add constraint fk_ctpkb_pkb FOREIGN KEY(MaPK) references PHIEUKHAMBENH(MaPK)

alter table CT_PHIEUKHAMBENH
add constraint fk_ctpkb_lt FOREIGN KEY(MaLT) references LOAITHUOC(MaLT)

alter table LOAITHUOC 
add constraint fk_lt_dv FOREIGN KEY(MaDV) references DONVI(MaDV)

alter table LOAITHUOC 
add constraint fk_lt_cd FOREIGN KEY(MaCD) references CACHDUNG(MaCD)

alter table CT_BAOCAODOANHTHU 
add constraint fk_ctbcdt_bcdt_month FOREIGN KEY(Thang , Nam) references BAOCAODOANHTHU(Thang , Nam)

alter table BAOCAOSUDUNGTHUOC
add constraint fk_bcsdt_lt FOREIGN KEY(MaLT) references LOAITHUOC(MaLT)

alter table HOADON
add constraint fk_hd_pk FOREIGN KEY(MaPK) references PHIEUKHAMBENH(MaPK)

alter table CT_PHIEUNHAPTHUOC 
add constraint fk_ctpnt_pnt FOREIGN KEY(MaPN) references PHIEUNHAPTHUOC(MaPN)

alter table CT_PHIEUNHAPTHUOC 
add constraint fk_ctpnt_lt FOREIGN KEY(MaLT) references LOAITHUOC(MaLT)

alter table PHANQUYEN
add constraint fk_pq_mn FOREIGN KEY(MaNhom) references NHOMNGUOIDUNG(MaNhom)

alter table PHANQUYEN 
add constraint fk_pq_cn FOREIGN KEY(MaCN) references CHUCNANG(MaCN)

alter table NGUOIDUNG
add constraint fk_nd_mn FOREIGN KEY(MaNhom) references NHOMNGUOIDUNG(MaNhom)
go
-- chèn data vào các bảng
-- Có 5 loại bệnh cơ bản
insert into LOAIBENH(MaLB, TenLB) values('LB001', N'Loại bệnh A');
insert into LOAIBENH(MaLB, TenLB) values('LB002', N'Loại bệnh B');
insert into LOAIBENH(MaLB, TenLB) values('LB003', N'Loại bệnh C');
insert into LOAIBENH(MaLB, TenLB) values('LB004', N'Loại bệnh D');
insert into LOAIBENH(MaLB, TenLB) values('LB005', N'Loại bệnh E');
go

-- Có 2 loại đơn vị (viên , chai)
insert into DONVI(MaDV, TenDV) values ('DV001', N'viên');
insert into DONVI(MaDV, TenDV) values ('DV002', N'chai');
go

-- Có 4 loại cách dùng (1,2,3,4)
insert into CACHDUNG(MaCD, TenCD) values('CD001' , N'1');
insert into CACHDUNG(MaCD, TenCD) values('CD002' , N'2');
insert into CACHDUNG(MaCD, TenCD) values('CD003' , N'3');
insert into CACHDUNG(MaCD, TenCD) values('CD004' , N'4');
go

-- Có 30 loại thuốc
insert into LOAITHUOC(MaLT , TenLT , MaDV , MaCD , SoLuongTon, DonGiaNhap, DonGiaBan) 
values ('LT001', N'Levothyroxine', 'DV001', 'CD002' , 0 , 0 , 15000);

insert into LOAITHUOC(MaLT , TenLT , MaDV , MaCD , SoLuongTon, DonGiaNhap, DonGiaBan) 
values ('LT002', N'Memantine', 'DV001', 'CD003' , 0 , 0 , 20000);

insert into LOAITHUOC(MaLT , TenLT , MaDV , MaCD , SoLuongTon, DonGiaNhap, DonGiaBan) 
values ('LT003', N'Eszopiclone', 'DV002', 'CD004' , 0 , 0 , 50000);

insert into LOAITHUOC(MaLT , TenLT , MaDV , MaCD , SoLuongTon, DonGiaNhap, DonGiaBan) 
values ('LT004', N'Varenicline', 'DV002', 'CD001' , 0 , 0 , 20000);

insert into LOAITHUOC(MaLT , TenLT , MaDV , MaCD , SoLuongTon, DonGiaNhap, DonGiaBan) 
values ('LT005', N'Amlodipine', 'DV001', 'CD003' , 0 , 0 , 100000);

insert into LOAITHUOC(MaLT , TenLT , MaDV , MaCD , SoLuongTon, DonGiaNhap, DonGiaBan) 
values ('LT006', N'Oxybutynin', 'DV001', 'CD002' , 0 , 0 , 60000);

insert into LOAITHUOC(MaLT , TenLT , MaDV , MaCD , SoLuongTon, DonGiaNhap, DonGiaBan) 
values ('LT007', N'Ondansetron', 'DV002', 'CD004' , 0 , 0 , 50000);

insert into LOAITHUOC(MaLT , TenLT , MaDV , MaCD , SoLuongTon, DonGiaNhap, DonGiaBan) 
values ('LT008', N'Fluconazole', 'DV002', 'CD001' , 0 , 0 , 20000);

insert into LOAITHUOC(MaLT , TenLT , MaDV , MaCD , SoLuongTon, DonGiaNhap, DonGiaBan) 
values ('LT009', N'Trazodone', 'DV001', 'CD002' , 0 , 0 , 30000);

insert into LOAITHUOC(MaLT , TenLT , MaDV , MaCD , SoLuongTon, DonGiaNhap, DonGiaBan) 
values ('LT010', N'Omeprazole', 'DV002', 'CD003' , 0 , 0 , 40000);

insert into LOAITHUOC(MaLT , TenLT , MaDV , MaCD , SoLuongTon, DonGiaNhap, DonGiaBan) 
values ('LT011', N'Potassium', 'DV002', 'CD004' , 0 , 0 , 40000);

insert into LOAITHUOC(MaLT , TenLT , MaDV , MaCD , SoLuongTon, DonGiaNhap, DonGiaBan) 
values ('LT012', N'Metformin', 'DV001', 'CD003' , 0 , 0 , 20000);

insert into LOAITHUOC(MaLT , TenLT , MaDV , MaCD , SoLuongTon, DonGiaNhap, DonGiaBan) 
values ('LT013', N'Insulin', 'DV002', 'CD001' , 0 , 0 , 80000);

insert into LOAITHUOC(MaLT , TenLT , MaDV , MaCD , SoLuongTon, DonGiaNhap, DonGiaBan) 
values ('LT014', N'Montelukast', 'DV002', 'CD002' , 0 , 0 , 50000);

insert into LOAITHUOC(MaLT , TenLT , MaDV , MaCD , SoLuongTon, DonGiaNhap, DonGiaBan) 
values ('LT015', N'Losartan', 'DV001', 'CD003' , 0 , 0 , 30000);

insert into LOAITHUOC(MaLT , TenLT , MaDV , MaCD , SoLuongTon, DonGiaNhap, DonGiaBan) 
values ('LT016', N'Hydralazine', 'DV002', 'CD004' , 0 , 0 , 40000);

insert into LOAITHUOC(MaLT , TenLT , MaDV , MaCD , SoLuongTon, DonGiaNhap, DonGiaBan) 
values ('LT017', N'Propranolol', 'DV002', 'CD002' , 0 , 0 , 70000);

insert into LOAITHUOC(MaLT , TenLT , MaDV , MaCD , SoLuongTon, DonGiaNhap, DonGiaBan) 
values ('LT018', N'Estrogen', 'DV001', 'CD003' , 0 , 0 , 50000);

insert into LOAITHUOC(MaLT , TenLT , MaDV , MaCD , SoLuongTon, DonGiaNhap, DonGiaBan) 
values ('LT019', N'Lorcaserin', 'DV002', 'CD001' , 0 , 0 , 30000);

insert into LOAITHUOC(MaLT , TenLT , MaDV , MaCD , SoLuongTon, DonGiaNhap, DonGiaBan) 
values ('LT020', N'Phentermine', 'DV001', 'CD002' , 0 , 0 , 150000);

insert into LOAITHUOC(MaLT , TenLT , MaDV , MaCD , SoLuongTon, DonGiaNhap, DonGiaBan) 
values ('LT021', N'Tramadol', 'DV002', 'CD004' , 0 , 0 , 90000);

insert into LOAITHUOC(MaLT , TenLT , MaDV , MaCD , SoLuongTon, DonGiaNhap, DonGiaBan) 
values ('LT022', N'Phentermine', 'DV001', 'CD003' , 0 , 0 , 25000);

insert into LOAITHUOC(MaLT , TenLT , MaDV , MaCD , SoLuongTon, DonGiaNhap, DonGiaBan) 
values ('LT023', N'Benzonatate', 'DV002', 'CD001' , 0 , 0 , 36000);

insert into LOAITHUOC(MaLT , TenLT , MaDV , MaCD , SoLuongTon, DonGiaNhap, DonGiaBan) 
values ('LT024', N'Baclofen', 'DV001', 'CD004' , 0 , 0 , 45000);

insert into LOAITHUOC(MaLT , TenLT , MaDV , MaCD , SoLuongTon, DonGiaNhap, DonGiaBan) 
values ('LT025', N'Tizanidine', 'DV002', 'CD002' , 0 , 0 , 80000);

insert into LOAITHUOC(MaLT , TenLT , MaDV , MaCD , SoLuongTon, DonGiaNhap, DonGiaBan) 
values ('LT026', N'Dicyclomine', 'DV002', 'CD001' , 0 , 0 , 60000);

insert into LOAITHUOC(MaLT , TenLT , MaDV , MaCD , SoLuongTon, DonGiaNhap, DonGiaBan) 
values ('LT027', N'Linaclotide', 'DV001', 'CD001' , 0 , 0 , 32000);

insert into LOAITHUOC(MaLT , TenLT , MaDV , MaCD , SoLuongTon, DonGiaNhap, DonGiaBan) 
values ('LT028', N'Allopurinol', 'DV001', 'CD001' , 0 , 0 , 18000);

insert into LOAITHUOC(MaLT , TenLT , MaDV , MaCD , SoLuongTon, DonGiaNhap, DonGiaBan) 
values ('LT029', N'Simvastatin', 'DV002', 'CD003' , 0 , 0 , 90000);

insert into LOAITHUOC(MaLT , TenLT , MaDV , MaCD , SoLuongTon, DonGiaNhap, DonGiaBan) 
values ('LT030', N'Ezetimibe', 'DV001', 'CD004' , 0 , 0 , 60000);

-- Thêm các tham số
insert into THAMSO(TenThamSo , GiaTri) values (N'SoBenhNhanToiDa' , 40);
insert into THAMSO(TenThamSo , GiaTri) values (N'TienKhamCoBan' , 30000);

-- Tạo account cho user và admin
insert into NHOMNGUOIDUNG (MaNhom , TenNhom) values ('1' , 'admin');
insert into NHOMNGUOIDUNG (MaNhom , TenNhom) values ('2' , 'user');

insert into NGUOIDUNG (TenDangNhap , MatKhau , MaNhom) values ('admin' , '123' , '1');
insert into NGUOIDUNG (TenDangNhap , MatKhau , MaNhom) values ('user' , '456' , '2');
