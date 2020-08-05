	
--if DB_ID('QLSV') is not null
--drop database QLSV;
CREATE DATABASE QLcongtynoithat
GO
USE QLcongtynoithat
GO

CREATE TABLE TAIKHOAN
(	MANV char(5),
	MAPHANQUYEN INT,
	USERNAME VARCHAR(50),
	MATKHAU  VARCHAR(20),
	TENNV NVARCHAR(20),
)
CREATE TABLE NHANVIEN /* nhân viên*/
(	STT INT IDENTITY(1,1),
	MANV CHAR(5)  primary key,
	HOTENNV NVARCHAR(20),
	NGSINH DATETIME,
	PHAI NCHAR(3),
	DCHI NVARCHAR(100),
	PHG INT,
	LUONG FLOAT,
	CHUCVU NVARCHAR(100),
	THOIHANHOPDONG NVARCHAR(100),
	HINH IMAGE
	)
CREATE TABLE PHONGBAN  /*phòng ban*/
(
	MAPHG INT identity(1,1) ,
	TENPHG NVARCHAR(100),
	TRPHG CHAR(5),
	NG_NHANCHUCTRP DATETIME,	
	constraint PRK_PHONGBAN primary key(MAPHG)
)
CREATE TABLE DUAN /* đề án*/
(
	MADA  CHAR(5),
	TENDA nVARCHAR(100),
	DDIEM_DA NVARCHAR(100),
	PHONG NVARCHAR(100),
	TIENLOINHUAN INT
	constraint PRK_DEAN primary key(MADA)
)
CREATE TABLE PHANCONG /* phân công*/
(	ID int identity(1,1) primary key,
	  MAPHONG int ,
	 MADEAN CHAR(5),
	THOIGIANBATDAU DATE,
	THOIGIANKETTHUC DATE,
)
CREATE TABLE DSKHENTHUONGVAKILUAT
(	ID int identity(1,1) primary key,
	MANV CHAR(5)  ,
	LIDO NVARCHAR(100),
	PHANTHUONG NVARCHAR(100),
	HINHPHAT NVARCHAR(100),
	ngay date
)

CREATE TABLE TONGLUONG
(	TONGLUONG int ,
	NGAYCHAMCONG date,
	LUONGTAMUNG INT,--trigger kiem tra luong ung <= luong mac dinh
	LUONGTHUONG INT,
	MANV CHAR(5) ,
	ID int identity(1,1) primary key
)
CREATE TABLE TIENDODUAN
(	MADUAN CHAR(5)PRIMARY KEY ,
	GIAIDOAN1 int,
	GIAIDOAN2 int,
	GIAIDOAN3 int,

)
create table LUONGTAMUNG
(	ID int identity(1,1) primary key,
	MANV CHAR(5),
	LUONGTUNG int ,
	NGAYUNG date

)
create table LUONGTHEOTHANHTICH
(	ID int identity(1,1) primary key,
	MANV CHAR(5) ,
	LUONGTHEOTHANHTICH INT,
	THANHTICH Nvarchar(100),
	NGAYTHUONG DATE
)



--KHÓA NGOẠI

alter table PHANCONG add constraint FRK_PHONGBAN_PHANCONG foreign key (MAPHONG) references PHONGBAN(MAPHG);
ALTER TABLE PHANCONG ADD CONSTRAINT FRK_PHANCONG_DUAN FOREIGN KEY (MADEAN) REFERENCES DUAN(MADA)
	
ALTEr table NHANVIEN ADD constraint FK_NHANVIEN_PHONGBAN foreign key (PHG) references PHONGBAN(MAPHG);

ALTER TABLE PHONGBAN ADD CONSTRAINT FRK_PHONGBAN_NHANVIEN FOREIGN KEY (TRPHG) REFERENCES NHANVIEN(MANV);


ALTER TABLE DSKHENTHUONGVAKILUAT ADD CONSTRAINT FRK_DSKHENTHUONG_NHANVIEN  FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV);


ALTER TABLE TONGLUONG ADD CONSTRAINT FRK_TONGLUONG_NHANVIEN FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV);

ALTER TABLE LUONGTAMUNG ADD CONSTRAINT FRK_LUONGTAMUNG_NHANVIEN FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV);

ALTER TABLE TIENDUDEAN Add CONSTRAINT FRK_TIENDODEAN_DUAN FOREIGN KEY (MADEAN) REFERENCES DUAN(MADA)


ALTER TABLE LUONGTHEOTHANHTICH ADD CONSTRAINT FRK_LUONGTHEOTHANHTICH_NHANVIEN FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV);

alter table TAIKHOAN ADD CONSTRAINT TAIKHOAN_NHANVIEN FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV);

delete from TAIKHOAN
--INSERT DATA
INSERT into NHANVIEN (HOTENNV,MANV,NGSINH,DCHI,PHAI,LUONG,CHUCVU,PHG,THOIHANHOPDONG,hinh) VALUES	
(N'Đinh Bá Tiến','NV004','1955-01-09 00:00:00',N'731 Trần Hưng Đạo Q1 TP HCM',N'Nam',20000,N'Nhân viên kế toán',2,N'1 năm',null),
(N'Nguyễn Thanh Tùng','NV005','1945-12-08 00:00:00',N'638 Nguyễn Văn Cừ Q5 TP HCM',N'Nam' ,20000,N'Nhân viên kế toán',2,N'2 năm',null),
(N'Trần Thanh Tâm' ,'NV006','1962-07-31 00:00:00',N'543 Mai Thi Luu Ba Dinh Ha Noi',N'Nam' ,30000,N'Trưởng phòng kế toán',2,N'3 năm',null),
(N'Nguyễn Mạnh Hùng','NV007','1952-09-15 00:00:00',N'975 Lê Lai P3 Vũng Tàu', N'Nam',35000,N'Trưởng phòng thiết kế',5,N'1 năm',null),
(N'Vương Ngọc Quỳnh','NV008','1927-10-10 00:00:00','450 Trung Vuong My Tho TG',N'Nữ',28000,N'Nhân viên kinh doanh',3,N'1 năm',null),
(N'Lê Thị Nhàn','NV009','1931-06-20 00:00:00','291 Ho Van Hue Q.PN TP HCM', N'Nữ',28000,N'Nhân viên kinh doanh',3,N'2 năm',null),
(N'Trần Quang Huy','NV010','1959-03-29 00:00:00','980 Le Hong Phong Vung Tau',N'Nam',25000,N'Nhân viên thiết kế',5,N'3 năm',null),
(N'Bùi Thái Vũ','NV011','1958-07-30 00:00:00','332 Nguyen Thai Hoc Quy Nhon',N'Nam',25000,N'Nhân viên thiết kế', 5,N'1 năm',null),
(N'Nguyễn Ngọc Vinh','NV012','1956-07-21 00:00:00',N'332 Hoàng Hoa Thám TPHCM',N'Nam',25000,N'Nhân viên thiết kế', 5,N'1 năm',null),
(N'Nguyễn Thanh Sơn','NV013','1960-12-09 00:00:00',N'638 Nguyễn Văn Cừ Q2 TP HCM',N'Nam' ,28000,N'Nhân viên kinh doanh',3,N'2 tháng',null),
(N'Đinh Bá Long','NV014','1959-02-07 00:00:00',N'700 Huỳnh Văn Hoa Q1 TP HCM',N'Nam',28000,N'Nhân viên kinh doanh',3,N'2 năm',null),
(N'Huỳnh Bá Thành','NV015','1960-05-09 00:00:00',N'652 Trần Lục Hưng  Q6 TP HCM',N'Nam',36000,N'Trưởng phòng kinh doanh',3,N'9 tháng',null),
(N'Nguyễn Long Sơn','NV016','1953-03-09 00:00:00',N'523 Nguyễn Hưng Đạo Q3 TP HCM',N'Nam',18000,N'Nhân viên Thi công',4,N'3 năm',null),
(N'Nguyễn Thanh Quốc','NV017','1941-06-09 00:00:00',N'899 Trần Bá đạo Q10 TP HCM',N'Nam',18000,N'Nhân viên Thi công',4,N'1 năm',null),
(N'Nguyễn huỳnh Sang','NV018','1955-01-09 00:00:00',N'999 Trần Hưng Đạo Q1 TP HCM','Nam',18000,N'Nhân viên Thi công',4,N'2 năm',null),
(N'Bùi Mạnh Quốc','NV019','1954-01-02 00:00:00',N'655 Mai Văn Tiến Q12 TP HCM','Nam',32000,N' Trưởng phòng thi công',4,N'3 năm',null),
(N'Lã Thị Ngọc','NV020','1955-01-09 00:00:00',N'522 Trùng Vạn Đạo Cần Thơ',N'Nữ',18000,N'Nhân viên Thi công',4,N'1 năm',null),
(N'Huỳnh Văn Tá','NV001','1940-01-05 00:00:00',N'451 Nguyễn Thành Văn Phú Quốc','Nam',null,N' Tổng giám đốc',1,NULL,null),
(N'Nguyễn Anh Đại','NV002','1943-05-05 00:00:00',N'451 Nguyễn Thành Cà Mau',N'Nữ',65000,N' Phó giám đốc',1,N'5 năm',null),
(N'Lê Thị Linh','NV003','1965-05-05 00:00:00',N'430 Nguyễn Hoa Hoàng Q11 TPHCM',N'Nữ',25000,N' Thư ký',1,N'2 năm',null),
(N'Nguyễn Ngọc Thúy','NV021','1965-07-21 00:00:00',N'332 Hoàng Hoa Thám Nha Trang',N'Nữ',25000,'Nhân viên thiết kế', 7,N'3 năm',null),
(N'Bùi Thị Thi','NV022','1970-07-8 00:00:00',N'106 Trần Thái Tông, Dịch Vọng Hậu Hà Nội',N'Nam',25000,'Nhân viên thiết kế', 7,N'1 năm',null),
(N'Nguyễn Mạnh Thắng','NV023','1960-10-15 00:00:00',N'425 Kinh Dương Vươn,An Lạc, Bình Tân TPHCM ', N'Nam',35000,N'Trưởng phòng thiết kế',7,N'1 năm',null),
(N'Nguyễn Văn Long','NV024','1990-09-09 00:00:00',N'110 Đường Châu Văn Liêm, Phường 11, Quận 5 TP HCM',N'Nam',18000,N'Nhân viên Thi công',6,N'5 năm',null),
(N'Tạ Quốc Long','NV025','1992-01-02 00:00:00',N'274 Mễ Trì Thượng, Mễ Trì, Nam Từ Liêm Hà Nội',N'Nam',32000,N' Trưởng phòng thi công',6,N'4 năm',null),
(N'Nguyễn Thư Dịu','NV026','1996-01-26 00:00:00',N'69 đường Nguyễn Văn Thoại, quận Sơn Trà Đà Nẵng',N'Nữ',20000,N'Nhân viên kế toán',9,N'2 năm',null),
(N'Nguyễn Thư Dịu','NV027','1990-08-28 00:00:00',N'114 Nguyễn Văn Thoại, quận Sơn Trà Đà Nẵng',N'Nam',30000,N'Trưởng phòng kế toán',9,N'2 năm',null),
(N'Đinh Bá Thắng','NV028','1993-11-07 00:00:00',N'18 Bạch Đằng, Thạch Thang, Hải Châu Đà Nẵng',N'Nam',28000,N'Nhân viên kinh doanh',8,N'5 năm',null),
(N'Lữ Thị Nghi','NV029','1995-11-07 00:00:00',N'132 Quang Trung, Thạch Thang, Hải Châu Đà Nẵng',N'Nữ',36000,N'Trưởng phòng kinh doanh',8,N'3 năm',null)


insert into TAIKHOAN (MANV,MAPHANQUYEN,USERNAME,MATKHAU,TENNV) VALUES
('NV008',1,'nhanvien',456,N'Nguyễn Thanh Tùng'),
('NV004',0,'nguoiquanly',789,N'Đinh Bá Tiến');


insert into PHONGBAN (TENPHG,TRPHG,NG_NHANCHUCTRP) values
(N'Phòng ban giám đốc','NV001','2006-05-10 00:00:00'),
(N'Phòng kế toán 01','NV006','2014-01-02 00:00:00'),
(N'Phòng kinh doanh 01 ','NV015','2016-05-21 00:00:00'),
(N'Phòng thi công 01','NV019','2017-05-10 00:00:00'),
(N'Phòng thiết kế 01','NV007','2013-01-09 00:00:00'),
(N'Phòng thi công 02','NV025','2017-05-10 00:00:00'),
(N'Phòng thiết kế 02','NV023','2015-01-01 00:00:00'),
(N'Phòng kinh doanh 02','NV029','2016-10-09 00:00:00'),
(N'Phòng kế toán 02','NV027','2016-02-02 00:00:00');

INSERT INTO DUAN(TENDA,MADA,DDIEM_DA,PHONG,TIENLOINHUAN) VALUES 
(N'Thiết kế nội thất Villa nghỉ dưỡng Lương Sơn','DA001',N'Hòa Bình',N'Phòng thiết kế',800000),
(N'Thi công nội thất Vinhome Dragon Bay','DA002',N'Quảng Ninh',N'Phòng thi công',900000),
(N'Thi công nội thất Chung cư Park Hill 2','DA003',N'Hà Nội',N'Phòng thi công',600000),
(N'Thiết kế nội thất R5-Royal City','DA004',N'Hà Nội',N'Phòng thiết kế',950000),
(N'Thi công nội thất biệt thự Hoài Đức','DA005',N'Hà Nội',N'Phòng thi công',700000),
(N'Thi công nội thất biệt thự An Hưng','DA006',N'Hà Đông',N'Phòng thi công',650000);

INSERT INTO PHANCONG(MAPHONG, MADEAN, THOIGIANBATDAU,THOIGIANKETTHUC) VALUES 
(5,'DA001','2020-01-10','2020-06-10'),
(6,'DA002','2020-03-10','2020-08-10'),
(4,'DA003', '2020-09-10','2021-04-10'),
(7,'DA004', '2021-04-15','2022-09-10'),
(4,'DA005', '2022-09-15','2023-04-10'),
(6,'DA006', '2020-11-7','2021-04-7');
insert into TIENDODUAN values
('DA001',0,0,0);
insert into TIENDODUAN values
('DA002',1,1,0),
('DA005',1,0,0),
('DA003',1,0,0),
('DA004',0,0,0),
('DA006',0,0,0);
update TIENDODUAN set GIAIDOAN2=1
where TIENDODUAN.MADUAN='DA006'
insert into luongtamung values
('NV004',10000,'2020-07-10') ;
insert into luongtamung values
('NV004',10000,'2020-08-02')
insert into luongtamung values
('NV004',10000,'2020-08-01')

insert into DSKHENTHUONGVAKILUAT values 
('NV006',N'Không chấp hành đúng nội quy',null,'Trừ một tháng lương','2017-05-06');
go
create function fu_CreateMaNV()
returns char(5)
begin
	
		declare @MaNVold varchar(5)
		select Top 1 @MaNVold=MANV from NHANVIEN order by MANV Desc
		Return 'NV' + format(right(@MaNVold,3)+1,'00#')

end
go
select dbo.fu_CreateMaNV()
go
create function fu_CreateMaDA()
returns char(5)
begin
	
		declare @MaDAold varchar(5)
		select Top 1 @MaDAold=MADA from DUAN order by MADA Desc
		Return 'DA' + format(right(@MaDAold,3)+1,'00#')

end
go
select dbo.fu_CreateMaDA()
-- xây dựng mã nhân viên
go
Create procedure pro_CreateMaNV
	@MaNVNew nvarchar(5) output
as		
		declare @MaNVold varchar(5)
		select Top 1 @MaNVold=MANV from NHANVIEN order by MANV Desc
		set @MaNVNew = 'NV' + format(right(@MaNVold,3)+1,'00#')

Go

Declare @MaNV nvarchar(5) 
Exec dbo.pro_CreateMaNV @MaNV output
print @MaNV
go
Create procedure pro_CreateMaDA
	@MaDANew nvarchar(5) output
as		
		declare @MaDAold varchar(5)
		select Top 1 @MaDAold=MADA from DUAN order by MADA Desc
		set @MaDANew = 'NV' + format(right(@MaDAold,3)+1,'00#')

Go

Declare @MaDA nvarchar(5) 
Exec dbo.pro_CreateMaNV @MaDA output
print @MaDA
go
--trigger luong tam ứng nhỏ hơn lương mặc định
create trigger ltamung on luongtamung
for insert,update,delete
as
begin transaction
if exists( select * from inserted i inner join NHANVIEN nv on i.MANV=nv.MANV where i.LUONGTUNG > nv.LUONG)
	begin
		raiserror ('Lương tạm ứng phải nhỏ hơn lương mặc định',0,1)
		rollback transaction
	end
else 
commit transaction
go
--trigger them nhân viên không được có chức vụ là giám đốc
create trigger chucvu on nhanvien
for insert,update,delete
as
begin transaction
if exists( select * from inserted i where i.CHUCVU='Tổng giám đốc')
	begin
		raiserror ('Một công ty chỉ có một tổng giám đốc',0,1)
		rollback transaction
	end
else 
commit transaction
go
-- trigger thêm tiến độ dự án phải check gd1 thi mói dc check giai đoạn 2 
create trigger tiendoduancheck on tiendoduan
for insert,update,delete
as
begin transaction
if exists( select * from inserted i where (i.GIAIDOAN1=0 and i.GIAIDOAN2=1)or(i.GIAIDOAN2=0 and i.GIAIDOAN3=1))
	begin
		raiserror ('Giai đoạn phải được check theo thứ tự',0,1)
		rollback transaction
	end
else 
commit transaction										


go
create trigger kiemtramanhanvien on taikhoan
for insert,update,delete
as
begin transaction
if not exists (select * from inserted i inner join NHANVIEN nv on i.MANV=nv.MANV where i.TENNV=nv.HOTENNV)
begin
raiserror ('Mã nhân viên hoặc họ tên không tồn tại',0,1)
		rollback transaction
end
else 
commit transaction
go
create trigger kiemtratrung on taikhoan
for insert,update,delete
as
begin transaction
if exists (select * from inserted i inner join TAIKHOAN TK on i.MANV=TK.MANV where i.TENNV=TK.TENNV )
begin
raiserror ('Mã nhân viên hoặc họ tên đã được đăng ký',0,1)
		rollback transaction
end
else 
commit transaction
go
create trigger kiemusename on taikhoan
for insert,update,delete
as
begin transaction
if exists (select * from inserted i inner join TAIKHOAN TK on i.USERNAME=TK.USERNAME)
begin
raiserror ('Tên đăng nhập đã tồn tại vui lòng nhập tên khác',0,1)
		rollback transaction
end
else 
commit transaction

go
--trigger quanlytienluongtamung
create trigger kiemtraluongtamung on luongtamung
after insert,update,delete
as
begin transaction
if exists(select * from inserted i inner join LUONGTAMUNG on i.MANV=LUONGTAMUNG.MANV where month(i.NGAYUNG)=month(LUONGTAMUNG.NGAYUNG) and i.NGAYUNG<LUONGTAMUNG.NGAYUNG)
begin
	raiserror('Lương tạm ứng chỉ ứng 1 tháng 1 lần',0,1)
	rollback transaction
end
else
 commit transaction
 drop trigger kiemtraluongtamung
 select month(
 from luongtamung
 go
 create proc luongtamungngay (@ngay date,@MANV char(5))
 as
 select*
 from LUONGTAMUNG
 where month(NGAYUNG)=MONTH(@ngay) and MANV=@MANV
 go
 create proc luongtheothanhtichgngay (@ngay date,@MANV char(5))
 as
 select*
 from LUONGTHEOTHANHTICH
 where month(NGAYTHUONG)=MONTH(@ngay)and MANV=@MANV
 go
 exec dbo.luongtamungngay()
 go
 create trigger kiemtraphancong on phancong
 after insert,update,delete
 as
 begin transaction
 if exists( select * from inserted  where inserted.THOIGIANBATDAU>= inserted.THOIGIANKETTHUC)
 begin
 raiserror ('Thời gian kết thúc phải lớn hơn thời gian bắt đầu',0,1)
 rollback transaction
 end
 else
 commit transaction
 go
 create trigger kiemtraphancong1 on phancong
 after insert,update,delete
 as
 begin transaction
 if exists( select * from inserted i inner join PHANCONG pc on i.MADEAN=pc.MADEAN  where i.MAPHONG= pc.MAPHONG)
 begin
 raiserror ('Dự án đã được phân công cho phòng này rồi',0,1)
 rollback transaction
 end
 else
 commit transaction
 