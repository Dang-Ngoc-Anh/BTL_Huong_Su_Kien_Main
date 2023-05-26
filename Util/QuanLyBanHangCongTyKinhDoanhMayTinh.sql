create database QuanLyBanHangCongTyKinhDoangMayTinh
go

SELECT * 
FROM sys.foreign_keys

EXEC sp_fkeys tblNhaCungCap

go

/*create table tblNhomHang
(
sManhom nvarchar(10) not null,
sMahang nvarchar(10),
sTennhom nvarchar(30),
iSoLuong int
contranst
)
drop table tblNhomHang
--drop table tblNhomHang
go
alter table tblNhomHang
ADD CONSTRAINT PK_tblNhomhang primary key(sManhom)
go
alter table tblNhomHang
ADD CONSTRAINT Fk_tblHanghoa primary key(sMahang),
CONSTRAINT FK_nhom_Hanghoa foreign key(sManhom)
references tblNhomhang(sManhom)
go
*/
drop table tblAcount
create table tblAcount(
	id nvarchar(30),
	userName nvarchar(50),
	userPassword nvarchar(50),
	ueserRole nvarchar(10)
)

/*alter table tblAcount 
add constraint FK_Key_NhanVien_Acount 
foreign key (id) 
references tblNhanVien(sMaNV)
go*/

create table tblHangHoa
(
sMahang nvarchar(10) not null,
sTenhang nvarchar(30),
sMausac nvarchar(20),
fKichthuoc float,
sDactinhkythuat nvarchar(30),
sManhom nvarchar(10)
)
go

alter table tblHanghoa
ADD CONSTRAINT PK_tblHanghoa primary key(sMahang),
CONSTRAINT FK_nhom_Hanghoa foreign key(sManhom)
references tblNhomhang(sManhom)
go

CREATE TABLE tblKhachHang
(
sMaKH nvarchar(30) not null,
sTenKH nvarchar(30) not null,
sDiachi nvarchar(50) not null,
sDienthoai nvarchar(12)
constraint PK_tblKhachHang PRIMARY KEY (sMaKH)
);
go

CREATE TABLE tblNhanVien
(
sMaNV nvarchar(30),
sTenNV nvarchar(30) not null,
sDiachi nvarchar(50) not null,
sDienthoai nvarchar(12) not null,
bGioiTinh bit,
dNgaysinh datetime,
dNgayvaolam datetime
constraint PK_tblNhanVien PRIMARY KEY (sMaNV)
);
go
alter table tblNhanVien add userRole nvarchar(10)

/*CREATE TABLE tblNhaCungCap
(
sMaNCC nvarchar(30)  not null,
sTenNhaCC nvarchar(50) ,
sDienthoai nvarchar(12) null
CONSTRAINT PK_tblNhaCungCap PRIMARY Key(sMaNCC)
);
go*/
create table tblHoaDonNhapHang
(
sMaHDnhap nvarchar(30) not null,
dNgaynhap datetime,
sMaNV nvarchar(30) references tblNhanVien(sMaNV),
sMaNCC nvarchar(30)
)

alter table tblHoaDonNhapHang
ADD CONSTRAINT PK_tblHoaDonNH primary key(sMaHDnhap)

alter table tblHoaDonNhapHang
ADD constraint FK_DNH_NCC foreign key(sMaNCC)
references tblNhaCungCap(sMaNCC)
go


go

/*create table tblCTHoaDonNhapHang
(
iId int primary key not null identity,
sMaHDnhap nvarchar(30) not null,
sMahang nvarchar(10) not null,
fSoluong float,
fGianhap float
CONSTRAINT FK_CTDNH_sMaHDnhap foreign key(sMaHDnhap)
references tblHoaDonNhapHang([sMaHDnhap]),
CONSTRAINT FK_CTDNH_sMaHang foreign key(sMahang)
references tblHangHoa(sMahang)
)
go
--alter table tblCTHoaDonNhapHang
--ADD CONSTRAINT FK_CTDNH_sMaHang foreign key(sMahang)
--references tblHangHoa(sMahang),
--CONSTRAINT FK_CTDNH_sMaHDnhap foreign key(sMaHDnhap)
--references tblHoaDonNhapHang([sMaHDnhap])*/
go
create table tblHoaDonBanHang
(
sMaHDban nvarchar(10) primary key,
sMaNV nvarchar(30) references tblNhanVien(sMaNV),
sMaKH nvarchar(30) references tblKhachHang(sMaKH),
dNgayban datetime,
)
create table tblCTHoaDonBanHang
(
iId int primary key not null identity ,
sMaHDban nvarchar(10) not null,
sMahang nvarchar(10) not null,
fSoluong float,
fGiaban float,
fBaohanh float
)
alter table tblCTHoaDonBanHang
ADD CONSTRAINT FK_CTDBH_sMaHang foreign key(sMahang)
references tblHangHoa(sMahang),
CONSTRAINT FK_CTDBH_sMaHDnhap foreign key(sMaHDban)
references tblHoaDonBanHang(sMaHDban)



--Nhân viên
-- insert info
go
alter proc getAllNhanVien
as
begin
	   SELECT 
		[sMaNV], [sTenNV], [bGioiTinh] , [sDienthoai], [dNgayvaolam] , [dNgaysinh] , [sDiachi],[userRole]
	FROM [dbo].[tblNhanVien]
end
go

go
alter proc insertInforNhanVien(
	@sMaNhanVien nvarchar(30) null,
	@sTenNhanVien nvarchar(50),
	@bGioiTinh bit,
	@sDiaChi nvarchar(50),
	@sDienThoai nvarchar(50),
	@dNgaySinh nvarchar(50),
	@dNgayVaoLam nvarchar(50))
as
begin
	insert into [dbo].[tblNhanVien]([sMaNV],[sTenNV],[bGioiTinh] ,[sDiachi],[sDienthoai],[dNgaysinh],[dNgayvaolam], [userRole] , [TrangThai] )
	values (@sMaNhanVien ,@sTenNhanVien, @bGioiTinh,@sDiaChi , @sDienThoai , @dNgaySinh, @dNgayVaoLam , N'NV' , 1 )
	
	insert into tblAcount([id],[userName], [userPassword],[ueserRole])
	values (@sMaNhanVien ,N''+@sTenNhanVien+'@gmail.com' , '1' , 'NV' )
	update tblAcount set userName = REPLACE(userName , ' ', '');
end
go

alter proc deleteNhanVien(@sMaNhanVien nvarchar(30))
as
begin
	update  tblNhanVien set TrangThai = 0
	where sMaNV = @sMaNhanVien
	select [sMaNV],[sTenNV],[bGioiTinh] ,[sDiachi],[sDienthoai],[dNgaysinh],[dNgayvaolam], [userRole] 
	from [dbo].[tblNhanVien]
	where TrangThai = 1;
end
go
--alter table tblNhanVien
--add TrangThai int default 1
--update tblNhanVien
--set TrangThai = 0
-- sMaNV = N'nv01'

select * from tblNhanVien 

--select * from tblHoaDonBanHang
--exec deleteNhanVien N'nv02'
alter table tblNhanVien add sTuoi nvarchar(10)
go
update tblNhanVien set sTuoi = year(getdate()) - year(dNgaysinh)
select * from tblNhanVien
go
alter proc UpdateNhanVien(
	@sMaNhanVien nvarchar(30) null,
	@sTenNhanVien nvarchar(50),
	@bGioiTinh bit,
	@sDiaChi nvarchar(50),
	@sDienThoai nvarchar(50),
	@dNgaySinh datetime,
	@dNgayVaoLam datetime,
	@userRole nvarchar(10),
	@sGhiChu nvarchar(40)
	)
as
begin
	update tblNhanVien 
	set 
		sTenNV= @sTenNhanVien ,
		bGioiTinh = @bGioiTinh ,
		sDiachi= @sDiaChi ,
		sDienthoai =@sDienThoai ,
		dNgaysinh =@dNgaySinh ,
		dNgayVaoLam = @dNgayVaoLam,
		userRole = @userRole,
		sGhiChu = @sGhiChu
		where sMaNV = @sMaNhanVien;
end
go

go
alter proc SearchNhanVien(
	@sMaNhanVien nvarchar(30) null,
	@sTenNhanVien nvarchar(50),
	@bGioiTinh nvarchar(10),
	@sDiaChi nvarchar(50),
	@sDienThoai nvarchar(50),
	@dNgaySinh nvarchar(5),
	@dThangSinh nvarchar(5),
	@dNamSinh nvarchar(5),
	@dNgayVaoLam nvarchar(5),
	@dThangVaoLam nvarchar(5),
	@dNamVaoLam nvarchar(5),
	@userRole nvarchar(10)
)
as
begin
	select [sMaNV], [sTenNV], [bGioiTinh] , [sDienthoai], [dNgayvaolam] , [dNgaysinh] , [sDiachi],[userRole] 
	from [dbo].[tblNhanVien]
	where
		[sMaNV] like N'%'+@sMaNhanVien+'%' and
		[sTenNV] like N'%'+@sTenNhanVien+'%' and
		[sDiachi] like N'%'+@sDiaChi+'%' and
		[sDienthoai] like N'%'+@sDienThoai+'%' and
		[bGioiTinh] like N'%'+@bGioiTinh+'%' and
		convert(nvarchar(5), day([dNgaysinh])) like N'%'+@dNgaySinh+'%' and
		convert(nvarchar(5), month([dNgaysinh])) like N'%'+@dThangSinh+'%' and
		convert(nvarchar(5), year([dNgaysinh])) like N'%'+@dNamSinh+'%' and
		convert(nvarchar(5), day([dNgayvaolam])) like N'%'+@dNgayVaoLam+'%' and
		convert(nvarchar(5), month([dNgayvaolam])) like N'%'+@dThangVaoLam+'%' and
		convert(nvarchar(5), year([dNgayvaolam])) like N'%'+@dNamVaoLam+'%'and
		[userRole] like N''+@userRole+''
		
end
go
exec  SearchNhanVien '' ,N'Đặng Ngọc Trang','','','','','','','','','',''



--KHACH HANG
go
alter proc insertKhachHang(
	@sMaKh nvarchar(30),
	@sTenKh nvarchar(30),
	@sDiaChi nvarchar(30),
	@sDienThoai nvarchar(30)
)
as
begin
	insert into [dbo].[tblKhachHang]([sMaKH],[sTenKH],[sDiachi],[sDienthoai])
	values (@sMaKh , @sTenKh,@sDiaChi , @sDienThoai)
end
go

go
alter proc UpdateKhachHang(
	@sMaKh nvarchar(30),
	@sTenKh nvarchar(30),
	@sDiaChi nvarchar(30),
	@sDienThoai nvarchar(30)
)
as
begin
	update [dbo].[tblKhachHang] 
	SET
	[sTenKH] = @sTenKh,[sDiachi] = @sDiaChi,[sDienthoai] = @sDienThoai
	where [sMaKH] = @sMaKh;
end
go

alter proc DeleteKhachHang(
	@sMaKh nvarchar(30)
)
as
begin
	DELETE [dbo].[tblKhachHang]
	where [sMaKH] = @sMaKh
end
go

--Hóa đơn bán hàng
alter proc insertHoaDonBanHang
(
@sMaHDban nvarchar(50) ,
@sMaNV nvarchar(50) ,
@sMaKH nvarchar(50) ,
@dNgayban nvarchar(50) 
)
as
begin
	insert into [dbo].[tblHoaDonBanHang]([sMaHDban],[sMaNV],[sMaKH],[dNgayban])
	values (@sMaHDban,@sMaNV,@sMaKH,@dNgayban)
end
go
alter proc UpdateHoaDonBanHang(
	@sMaHDban nvarchar(50) ,
	@sMaNV nvarchar(50) ,
	@sMaKH nvarchar(50) ,
	@dNgayban nvarchar(50) 
)
as
begin
	update tblHoaDonBanHang 
	set 
		sMaNV = @sMaNV,
		sMaKH = @sMaKH,
		dNgayban = @dNgayban
		where sMaHDban = @sMaHDban
end
go
alter proc DeleteHoaDonBanHang
@MaHD nvarchar(40)
as
begin
	DELETE [dbo].[tblHoaDonBanHang] 
	WHERE [sMaHDban] = @MaHD
end
go
--create proc ReportHoaDonBanHang
--create proc SearchHoaDonBanHang
--create proc getAllHoaDonBanHang

--Chi tiết hóa đơn bán hàng
go
alter proc insertChiTietHoaDonBanHang(
		@sMaHDban nvarchar(30),
		@sMahang nvarchar(30),
		@fSoluong float,
		@fGiaban float,
		@fBaohanh float
)
as
begin
	insert into [dbo].[tblCTHoaDonBanHang](sMaHDban,sMahang,fSoluong,fGiaban,fBaohanh)
	values (@sMaHDban,@sMahang,@fSoluong,@fGiaban,@fBaohanh)
end

go
alter proc UpdateChiTietHoaDonBanHang(
		@id int,
		@sMaHDban nvarchar(30),
		@sMahang nvarchar(30),
		@fSoluong float,
		@fGiaban float,
		@fBaohanh float
)
as 
begin
	update tblCTHoaDonBanHang set
	sMahang = @sMahang,
	fSoluong = @fSoluong,
	fGiaban = @fGiaban,
	fBaohanh = @fBaohanh
	where iId = @id
end
go
alter proc DeleteChiTietHoaDonBanHang(
@id int
)
as
begin
	Delete tblCTHoaDonBanHang where iId = @id
end
go

--Hoa Don Nhap Hang
alter table [dbo].[tblHoaDonNhapHang] add  sLienHe nvarchar(20)
alter table [dbo].[tblHoaDonNhapHang] add  sMahang nvarchar(10) 
alter table [dbo].[tblHoaDonNhapHang] add  iSoluong int
alter table [dbo].[tblHoaDonNhapHang] add  fGiaNhap float
alter table [dbo].[tblHoaDonNhapHang] ADD CONSTRAINT FK_CTHDN_HANG_HOA foreign key(sMahang)
references tblHangHoa(sMahang)

go
alter proc insertHoaDonNhapHang(
		@sMaHDnhap nvarchar(30)
      ,@dNgaynhap nvarchar(30) 
      ,@sMaNV nvarchar(30)
      ,@sMaNCC nvarchar(30)
      ,@sLienHe nvarchar(30)
      ,@sMahang nvarchar(30)
      ,@fGiaNhap float
      ,@iSoluong int
)
as
begin
	insert into tblHoaDonNhapHang([sMaHDnhap],[dNgaynhap],[sMaNV] ,[sMaNCC],[sLienHe],[sMahang],[fGiaNhap],[iSoluong])
	values(@sMaHDnhap , @dNgaynhap , @sMaNV , @sMaNCC, @sLienHe , @sMahang , @fGiaNhap, @iSoluong)
end
go

go
alter proc UpdateHoaDonNhapHang(
	@sMaHDnhap nvarchar(30)
      ,@dNgaynhap nvarchar(30) 
      ,@sMaNV nvarchar(30)
      ,@sMaNCC nvarchar(30)
      ,@sLienHe nvarchar(30)
      ,@sMahang nvarchar(30)
      ,@fGiaNhap float
      ,@iSoluong int
)
as
begin
	update [dbo].[tblHoaDonNhapHang] 
	set 
		dNgaynhap = @dNgaynhap,
		sMaNV = @sMaNV,
		sMaNCC = @sMaNCC,
		sLienHe = @sLienHe,
		sMahang = @sMahang,
		fGiaNhap = @fGiaNhap,
		iSoluong = @iSoluong
		where sMaHDnhap = @sMaHDnhap
end
go

alter proc DeleteHoaDonNhapHang(@MaHDNhap nvarchar(20))
as
begin
	delete [dbo].[tblHoaDonNhapHang] 
	where sMaHDnhap = @MaHDNhap
end
go

--Acount
alter proc getOneAcount(
	@userName nvarchar(30),
	@passWord nvarchar(30)
)
as
begin
select 
[sMaNV],[sTenNV],[bGioiTinh] ,[sDiachi],[sDienthoai],[dNgaysinh],[dNgayvaolam] , [userName],[userPassword],[ueserRole]      
from tblNhanVien nv inner join tblAcount acc 
on acc.userName = N''+@userName+'' and acc.userPassword = @passWord and nv.sMaNV = acc.id
group by [sMaNV], [sTenNV],[bGioiTinh] ,[sDiachi],[sDienthoai],[dNgaysinh],[dNgayvaolam],[userName],[userPassword],[ueserRole]
end
go

exec getOneAcount N'Lưuquangtrung@gmail.com' , N'1'

go
alter proc updatePassword(
	@id nvarchar(30),
	@userPassword nvarchar(30),
	@userNewPassword  nvarchar(30)
)
as
begin
	update tblAcount set userPassword = @userNewPassword
	where userPassword = @userPassword and id = @id
end
go