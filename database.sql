--DROP DATABASE IF EXISTS HotelManagement;
--CREATE DATABASE HotelManagement;
--go
--USE HotelManagement;
--go
--select * from TaiKhoan;
--select * from KhachHang;
--0
CREATE TABLE TaiKhoan
(
	mataikhoan						int						identity primary key,
	tentaikhoan						varchar(100)			unique check(len(tentaikhoan)>6),
	matkhau							varchar(60)				not null,
	loaitaikhoan					varchar(20)				check(loaitaikhoan in ('khachhang','letan','vesinh','ketoan','buongphong','bellman')),
	bikhoa							bit						not null
);

--1
CREATE TABLE KhachHang
(
	makhachhang						int						identity,
	tenkhachhang					nvarchar(100)			not null,
	diachi							nvarchar(100)			not null,
	sodienthoai						varchar(10)				unique not null,
	sofax							varchar(50)				,
	email							varchar(100)			unique not null,
	cccd							varchar(20)				unique not null,
	mataikhoan						int						not null,
	primary key(makhachhang),
	constraint fk_KhachHang_taikhoan foreign key (mataikhoan) references TaiKhoan(mataikhoan)
);

--2
CREATE TABLE Doan
(	
	madoan							int						identity,
	soluong							int						not null check(soluong > 1),
	truongdoan						int						not null,
	primary key(madoan),
	constraint fk_truongdoan foreign key (truongdoan) references KhachHang(makhachhang)
);

--3
CREATE TABLE ThanhVien
(
	sothutu							int						not null,
	madoan							int						not null,
	hoten							nvarchar(100)			not null,
	cccd							varchar(20)				,
	primary key (sothutu,madoan),
	constraint fk_ThanhVien_madoan foreign key (madoan) references Doan(madoan)
);

--4
CREATE TABLE DoiTac
(
	madoitac						int						identity,
	tendoitac						nvarchar(100)			not null,
	sodienthoai						varchar(10)				not null,
	email							varchar(100)			not null,
	primary key(madoitac)
);

--5
CREATE TABLE TourDuLich
(
	matour							int						identity primary key,
	tentour							nvarchar(100)			not null,
	gia								float					not null check(gia > 0),
	songay							int						not null check(songay > 0),
	madoitac						int						not null,
	constraint fk_TourDuLich_madoitac foreign key (madoitac) references DoiTac(madoitac)
);

--6
CREATE TABLE DatTour 
(
	madattour						int						identity primary key,
	matour							int						not null,
	makhachhang						int						not null,
	thoigiankhoihanh				datetime				not null,
	thoigiantrove					datetime				not null,
	soluonghanhkhach				int						not null check(soluonghanhkhach>0),
	constraint ck_thoigiantrove check(thoigiantrove > thoigiankhoihanh),
	constraint fk_DatTour_matour foreign key (matour) references TourDuLich(matour),
	constraint fk_DatTour_makhachhang foreign key (makhachhang) references KhachHang(makhachhang)
);

--7
CREATE TABLE NhanVien
(
	manhanvien						int					identity primary key,
	ten								nvarchar(100)		not null,
	loai							varchar(10)			not null check(loai in ('letan','vesinh','ketoan','buongphong','bellman')),
	luong							float				not null check(luong > 0),
	ngaybatdau						date				default getdate(),
	trangthai						nvarchar(20)		not null check(trangthai in (N'còn làm việc',N'đã nghỉ việc')),
	mataikhoan						int					not null,
	constraint fk_NhanVien_taikhoan foreign key (mataikhoan) references TaiKhoan(mataikhoan)
);

--8
CREATE TABLE PhieuDatPhong
(
	maphieudatphong					int					identity primary key,
	yeucaudatbiet					nvarchar(100)		,
	sodemluutru						int					not null check(sodemluutru > 0),
	ngayden							date				not null,
	makhachhang						int					not null,
	checkin							bit					not null,
	nhanviencheckout				int					,
	nhanvienvesinh					int					,
	constraint fk_PhieuDatPhong_makhachhang foreign key (makhachhang) references KhachHang(makhachhang) ,
	constraint fk_PhieuDatPhong_nhanviencheckout	foreign key(nhanviencheckout) references NhanVien(manhanvien) ,
	constraint fk_PhieuDatPhong_nhanvienvesinh	foreign key(nhanvienvesinh) references NhanVien(manhanvien)
);

 
--9
CREATE TABLE PhieuDanhGia
(
	maphieudanhgia					int					identity primary key,
	noidung							nvarchar(200)		,
	diem							int					not null check(diem>0 and diem<=10),
	makhachhang						int					not null,
	maphieudatphong					int					not null,
	constraint fk_PhieuDanhGia_makhachhang foreign key (makhachhang) references KhachHang(makhachhang),
	constraint fk_PhieuDanhGia_maphieudatphong foreign key (maphieudatphong) references PhieuDatPhong(maphieudatphong)

);

--10
CREATE TABLE PhieuVanChuyenHanhLy
(
	maphieuvanchuyen				int					identity primary key,
	ghichu							nvarchar(100)		,
	thoigian						datetime			,
	maphieudatphong					int					not null,
	manhanvienphutrach				int					not null,
	constraint fk_PhieuVanChuyenHanhLy_maphieudatphong foreign key (maphieudatphong) references PhieuDatPhong(maphieudatphong),
	constraint fk_PhieuVanChuyenHanhLy_manhanvienphutrach foreign key (manhanvienphutrach) references NhanVien(manhanvien)
);


--11
CREATE TABLE HanhLy
(
	mahanhly						int					identity primary key,
	maphieuvanchuyen				int					not null,
	ten								nvarchar(100)		not null,
	dacdiem							nvarchar(100)		,
	constraint fk_HanhLy_maphieuvanchuyen foreign key (maphieuvanchuyen) references PhieuVanChuyenHanhLy(maphieuvanchuyen)
);

CREATE TABLE LoaiPhong
(
	maloaiphong						int					identity primary key,
	tenloaiphong					varchar(5)			not null unique,
);

--12
CREATE TABLE Phong
(
	maphong							int					identity primary key,
	sophong							varchar(5)			not null unique,
	gia								float				not null check(gia>0),
	bikhoa							bit					not null default 0,
	tinhtrang						nvarchar(20)		not null check(tinhtrang in (N'đã sẵn sàng',N'chưa sẵn sàng')),
	maloaiphong						int 				,
	constraint fk_Phong_loaiphong foreign key (maloaiphong) references LoaiPhong(maloaiphong)
);


--12.1
CREATE TABLE ThucPham
(
	mathucpham						int					identity primary key,
	tenthucpham						nvarchar(50)		unique not null check(len(tenthucpham)>0),
	soluongton						int					check(soluongton>=0),
	gia								float				check(gia>=0),
);	

--12.3
CREATE TABLE NoiThat
(
	manoithat						int					identity primary key,
	ten								nvarchar(50)		unique not null check(len(ten)>0),		
	gia								float				check(gia>0),
	maphong							int					not null,
	constraint fk_NoiThat_maphong foreign key (maphong) references Phong(maphong) 
);
--12.4
CREATE TABLE PhieuHuHongNoiThat
(
	maphieudatphong					int					not null,
	manoithat						int					not null,
	giatienden						float				check(giatienden>=0),
	primary key(maphieudatphong,manoithat),
	constraint fk_PhieuHuHongNoiThat_maphieudatphong foreign key (maphieudatphong) references PhieuDatPhong(maphieudatphong),
	constraint fk_PhieuHuHongNoiThat_manoithat foreign key (manoithat) references NoiThat(manoithat)
);


--13
CREATE TABLE PhieuDatPhongChiTiet
(
	maphong							int					not null,
	maphieudatphong					int					not null,
	primary key(maphong,maphieudatphong),
	constraint fk_PhieuDatPhongChiTiet_maphong foreign key (maphong) references Phong(maphong),
	constraint fk_PhieuDatPhongChiTiet_maphieudatphong foreign key (maphieudatphong) references PhieuDatPhong(maphieudatphong)
);


--12.2
CREATE TABLE PhieuSuDungThucPham
(
	maphieudatphong					int					not null,
	maphong							int					not null,
	mathucpham						int					not null,
	soluong							int					check(soluong > 0),
	dongia							float				check(dongia>0),
	primary key(maphieudatphong,maphong,mathucpham),
	constraint fk_PhieuSuDungThucPham_maphieudatphongchitiet foreign key (maphong,maphieudatphong) references PhieuDatPhongChiTiet(maphong,maphieudatphong),
	constraint fk_PhieuSuDungThucPham_mathucpham foreign key (mathucpham) references ThucPham(mathucpham)
);

--14
CREATE TABLE KhuyenMai
(
	makhuyenmai						int					identity primary key,
	tenkhuyenmai					nvarchar(100)		not null,
	thoigianbatdau					date				not null,
	thoigianketthuc					date				not null,
	ngaykhoa						date				,
	constraint ck_thoigianketthuc check(thoigianketthuc > thoigianbatdau),
	constraint ck_ngaykhoa check((ngaykhoa > thoigianbatdau and ngaykhoa <thoigianketthuc) or ngaykhoa is null)
);


--15
CREATE TABLE ApDungKhuyenMai
(
	id								int					identity primary key,
	makhuyenmai						int					,
	maphong							int					,
	constraint unique_pk_apdungkhuyenmai unique(makhuyenmai,maphong),
	constraint fk_ApDungKhuyenMai_makhuyenmai foreign key(makhuyenmai) references KhuyenMai(makhuyenmai),
	constraint fk_ApDungKhuyenMai_maphong foreign key(maphong) references Phong(maphong)
);


--16
--ALTER TABLE dbo.HoaDon 
--ALTER COLUMN tiendichvu FLOAT NULL;
--ALTER TABLE dbo.HoaDon
--DROP CONSTRAINT CK__HoaDon__tinhtran__09A971A2;
--ALTER TABLE dbo.HoaDon
--ADD CONSTRAINT CHK_tinhtrang
--CHECK (tinhtrang IN (N'đang chờ', N'đã thanh toán', N'đã cọc'));

CREATE TABLE HoaDon
(
	mahoadon						int					identity primary key,
	tiendichvu						float				null check(tiendichvu > 0),
	tienthucpham					float				not null check(tienthucpham > 0),
	tienhuhongnoithat				float				not null check(tienhuhongnoithat > 0),
	tongtien						float				not null check(tongtien > 0),
	sotiendathanhtoan				float				not null ,
	maphieudatphong					int					not null,
	maketoan						int					,
	tinhtrang						nvarchar(20)		check(tinhtrang in (N'đang chờ',N'đã thanh toán','đã cọc')),
	constraint fk_HoaDon_maphieudatphong foreign key (maphieudatphong) references PhieuDatPhong(maphieudatphong),
	constraint fk_HoaDon_maketoan foreign key (maketoan) references NhanVien(manhanvien),
	constraint ck_sotiendathanhtoan check(sotiendathanhtoan > 0 and sotiendathanhtoan <= tongtien)
);

--17
CREATE TABLE DichVu
(
	madichvu						int					identity primary key,
	tendichvu						nvarchar(100)		not null,
	gia								float				check(gia>0)
);

--18
CREATE TABLE CungCapDichVu
(
	id								int					primary key identity,
	madichvu						int					not null,
	maloaiphong							int					not null,
	constraint unique_pk_cungcapdichvu unique(madichvu,maloaiphong),
	constraint fk_CungCapDichVu_madichvu foreign key (madichvu) references DichVu(madichvu),
	constraint fk_CungCapDichVu_maloaiphong foreign key (maloaiphong) references LoaiPhong(maloaiphong)
);

--19
CREATE TABLE PhieuSuDungDichVu
(
	maphieu							int					identity primary key,
	tongtien						float				check(tongtien >= 0),
	maletan							int					not null,
	maphieudatphong					int					not null,
	constraint fk_PhieuSuDungDichVu_maphong foreign key (maphieudatphong) references PhieuDatPhong(maphieudatphong)
);

--20
CREATE TABLE PhieuSuDungDichVuChiTiet
(
	madichvu						int					not null,
	maphieusudungdichvu				int					not null,
	soluong							int					check(soluong>=1),
	thoigiansudung					int					check(thoigiansudung>0),
	thoigianbatdau					datetime			not null,
	dongia							float				check(dongia>0),
	tenkhachhang					nvarchar(20)		not null,
	primary key(madichvu,maphieusudungdichvu),
	constraint fk_PhieuSuDungDichVuChiTiet_madichvu foreign key (madichvu) references DichVu(madichvu),
	constraint fk_PhieuSuDungDichVuChiTiet_maphieusudungdichvu foreign key (maphieusudungdichvu) references PhieuSuDungDichVu(maphieu)
);


--insert data
--INSERT INTO KhachHang(tenkhachhang,diachi,sodienthoai,sofax,email,cccd) VALUES (N'Dương Tấn Thành',N'Q1, TPHCM','098283183','220302','email1@gmail.com','12341232');
--INSERT INTO KhachHang(tenkhachhang,diachi,sodienthoai,sofax,email,cccd) VALUES (N'Nguyễn Khắc Tấn',N'Q1, TPHCM','098273183','22202','email2@gmail.com','123412332');
--INSERT INTO KhachHang(tenkhachhang,diachi,sodienthoai,sofax,email,cccd) VALUES (N'Văn Đức Phước',N'Q2, TPHCM','09855183','220302','email3@gmail.com','123433232');
--INSERT INTO KhachHang(tenkhachhang,diachi,sodienthoai,sofax,email,cccd) VALUES (N'Lương Văn Triều',N'Q3, TPHCM','098283444','277702','email4@gmail.com','1233232');
--INSERT INTO KhachHang(tenkhachhang,diachi,sodienthoai,sofax,email,cccd) VALUES (N'Nguyễn Hoài Sơn',N'Q5, TPHCM','0985583','220222','email5@gmail.com','19999232');

--INSERT INTO TaiKhoan(tentaikhoan,matkhau,loaitaikhoan,bikhoa) VALUES('khachhang','123456','khachhang',0);