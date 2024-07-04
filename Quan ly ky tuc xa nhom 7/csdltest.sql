create database QuanLyKyTucXasql
use QuanLyKyTucXasql
--------------------------------------
create table Taikhoan
(
  ID int not null identity(1,1) primary key ,
  Username varchar(20) not null,
  Hotennguoidung nvarchar(20) ,  
  Sdt int,
  Gioitinh nvarchar(10),
  Pass nvarchar(50),
  Cpass nvarchar(50),
)

drop table Taikhoan

create view Quanlytaikhoan as
select ID,Username,Hotennguoidung,Sdt,Gioitinh,Pass
from Taikhoan

insert into Quanlytaikhoan values ('Admin','ABC',113,'Nam','admin')

----------------------------------------------------------

create table Sinhvien
(
  Masv int primary key not null,
  Tensv nvarchar(50),
  Sdt int,
  Ngaysinh datetime,
  Gioitinh nchar(20),
  Quequan nvarchar(50),
  Malop nvarchar(20),
  Maphong nvarchar(20),
  foreign key (Malop) references Lop,
  foreign key (Maphong) references Phong,
)

insert into Sinhvien values ( 2018603798 , 'Phạm Đức Trung' ,0981953791,'1/1/2000','Nam','Hải Dương','KTPM1','A100')
insert into Sinhvien values ( 2018603198 , 'Nguyễn Văn THuần ',0981953791,'2/2/2000','Nam','Hải Dương','KTPM2','A101')
insert into Sinhvien values ( 2018603728 , 'Ngô Đình Non' ,0981953791,'3/3/2000','Nam','Bắc Giang','OTO1','A102')

drop table Sinhvien
-----------------------------------------------------------------

create table Lop
(
  Malop nvarchar(20) primary key not null,
  Tenlop nvarchar(50),
  Makhoa nvarchar(20),
  foreign key (Makhoa) references Khoa
)

insert into Lop values ('KTPM1','KỸ THUẬT PHẦM MỀM 1','IT2020')
insert into Lop values ('KTPM2','KỸ THUẬT PHẦM MỀM 2','IT2020')
insert into Lop values ('TDH1','KỸ THUẬT TỰ ĐỘNG HÓA 1','DT2020')
insert into Lop values ('TDH2','KỸ THUẬT TỰ ĐỘNG HÓA 2','DT2020')
insert into Lop values ('OTO1','KỸ THUẬT Ô TÔ 1','CK2020')
insert into Lop values ('OTO2','KỸ THUẬT Ô TÔ 1','CK2020')

select*from Lop
drop table Lop
-----------------------------------------------------------------------
create table Khoa
(
  Makhoa nvarchar(20) primary key not null,
  Tenkhoa nvarchar(50),
)

	insert into Khoa values ('IT2020','Công nghệ thông tin')
	insert into Khoa values ('DT2020','Điện')
	insert into Khoa values ('CK2020','Cơ khí')

drop table Khoa
-----------------------------------------------------------------------------------

create table Hoadon 
(
  Mahd nvarchar(20) primary key not null,
  Ngaythu datetime,
  Maphong nvarchar(20),
  Sodien int,
  Sonuoc int,
  foreign key (Maphong) references Phong,
)

insert into Hoadon values ('HD1','6/6/2020','A100',50,10)

drop table Hoadon
---------------------------------------------------------------------------------

create table Phong
(
  Maphong nvarchar(20) primary key not null,
  Daynha nvarchar(10),
  Songuoi int,
  GioiHan int,
  Maloaiphong nvarchar(20),
 
  foreign key (Maloaiphong) references Loaiphong
)

insert into Phong values ('A100','A',0,4,'BD1')
insert into Phong values ('A101','A',0,4,'V1')
insert into Phong values ('A102','A',0,4,'HS1')

select * from Phong
drop table Phong
--------------------------------------------------------------------------------------

create table Loaiphong
( 
  Maloaiphong nvarchar(20) primary key not null,
  Tenloaiphong nvarchar(30),
  Giatien int,
)

insert into Loaiphong values ('BD1','Bình dân', 600000 )
insert into Loaiphong values ('V1','Vip', 1000000 )
insert into Loaiphong values ('HS1','Hạng sang', 2000000 )

select * from Loaiphong
drop table Loaiphong
-----------------------------------------------------------------------------------------

create view timkiemsv
as
select Masv,Tensv,Gioitinh,Sdt,Quequan,Tenlop,Tenkhoa,Sinhvien.Maphong 
from Sinhvien,Khoa,Lop
where Sinhvien.Malop = Lop.Malop and Khoa.Makhoa = Lop.Makhoa 

-------------------------------------------------------------------------------------------------

create view timkiemphong
as
select Phong.Maphong,Sodien,Sonuoc,Songuoi,Loaiphong.Maloaiphong,Tenloaiphong,Giatien,Tienphong = Sodien*3500 + Sonuoc*7000 + Giatien
from Phong,Hoadon,Loaiphong 
where Phong.Maphong = Hoadon.Maphong and Phong.Maloaiphong = Loaiphong.Maloaiphong 

------------------------------------------------------------------------------------------------------

CREATE TRIGGER add_person ON Sinhvien FOR INSERT
AS
BEGIN
	DECLARE @maPhong_new NVARCHAR(20)
	SELECT @maPhong_new = Maphong FROM inserted
	UPDATE Phong SET Songuoi = Songuoi+1 WHERE Maphong = @maPhong_new
END

------------------------------------------------------------------------------

CREATE TRIGGER delete_person ON Sinhvien FOR delete
AS
BEGIN
	DECLARE @maPhong_new NVARCHAR(20)
	SELECT @maPhong_new = Maphong FROM deleted
	UPDATE Phong SET Songuoi = Songuoi-1 WHERE Maphong = @maPhong_new
END

-----------------------------------------------------------------------------------

Create Trigger insert_hd On Hoadon For Insert
As
If (Select Count(a.Maphong)
     From Hoadon a Inner Join INSERTED b On a.Maphong = b.Maphong) > 1
Begin
   RollBack Tran
End
GO
ALTER TABLE Hoadon ENABLE TRIGGER insert_hd
GO

------------------------------------------------------------------------------------------

CREATE TRIGGER edit_person ON Sinhvien FOR UPDATE
AS
BEGIN
	DECLARE @maPhong_new NVARCHAR(20)
	DECLARE @maPhong_old NVARCHAR(20)
	SELECT @maPhong_old = Maphong FROM deleted
	SELECT @maPhong_new = Maphong FROM inserted
	UPDATE Phong SET Songuoi = Songuoi+1 WHERE Maphong = @maPhong_new
	UPDATE Phong SET Songuoi = Songuoi-1 WHERE Maphong = @maPhong_old
END
go

----------------------------------------------------------------------------------------------------

create view Phieuthu
as
select Phong.Maphong,phong.Maloaiphong,Tenloaiphong,Loaiphong.Giatien,Mahd,Ngaythu,Songuoi,Sodien,Sonuoc, tongienphong = Sodien*3500 + Sonuoc*20000 + Giatien
from   Phong,Hoadon,Loaiphong
where  Phong.Maphong = Hoadon.Maphong and Loaiphong.Maloaiphong = Phong.Maloaiphong

-----------------------------------------------------------------------------------------------------

