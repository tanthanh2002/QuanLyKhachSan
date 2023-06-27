use HotelManagement
go

select * from TaiKhoan;
select * from DichVu;
select * from LoaiPhong;
select * from Phong;
select * from CungCapDichVu;

-- tai khoan
-- mk: 123
INSERT INTO TaiKhoan(tentaikhoan,matkhau,loaitaikhoan,bikhoa) VALUES('khachhang123','$2a$10$IgBjONP.H/Ys9QT6nTKEp.9KHORO69w6Dpffsp738b52kqkf7ezzC','khachhang',0);
INSERT INTO TaiKhoan(tentaikhoan,matkhau,loaitaikhoan,bikhoa) VALUES('letan123','$2a$10$IgBjONP.H/Ys9QT6nTKEp.9KHORO69w6Dpffsp738b52kqkf7ezzC','letan',0);
INSERT INTO TaiKhoan(tentaikhoan,matkhau,loaitaikhoan,bikhoa) VALUES('buongphong','$2a$10$IgBjONP.H/Ys9QT6nTKEp.9KHORO69w6Dpffsp738b52kqkf7ezzC','buongphong',0);

go
-- loai phong
INSert into LoaiPhong(tenloaiphong) values ('dong');
INSert into LoaiPhong(tenloaiphong) values ('bac');
INSert into LoaiPhong(tenloaiphong) values ('vang');
go
-- phong
INSert into Phong(sophong, gia, bikhoa, tinhtrang, maloaiphong) values ('101', 100000, 1, N'Đã sẵn sàng', 1);
INSert into Phong(sophong, gia, bikhoa, tinhtrang, maloaiphong) values ('102', 100000, 1, N'Chưa sẵn sàng', 1);
INSert into Phong(sophong, gia, bikhoa, tinhtrang, maloaiphong) values ('103', 100000, 0, N'Đã sẵn sàng', 2);
INSert into Phong(sophong, gia, bikhoa, tinhtrang, maloaiphong) values ('104', 100000, 1, N'Đã sẵn sàng', 1);
INSert into Phong(sophong, gia, bikhoa, tinhtrang, maloaiphong) values ('105', 100000, 0, N'Đã sẵn sàng', 1);
INSert into Phong(sophong, gia, bikhoa, tinhtrang, maloaiphong) values ('106', 100000, 0, N'Đã sẵn sàng', 1);
INSert into Phong(sophong, gia, bikhoa, tinhtrang, maloaiphong) values ('107', 100000, 0, N'Đã sẵn sàng', 1);
go

-- dich vu
INSert into DichVu(tendichvu, gia) values ('karaoke', 123456);
INSert into DichVu(tendichvu, gia) values ('an sang', 123456);
INSert into DichVu(tendichvu, gia) values ('ca phe', 123456);
go

-- cung cap dich vu
INSert into CungCapDichVu(madichvu, maloaiphong) values (1, 1);
INSert into CungCapDichVu(madichvu, maloaiphong) values (2, 1);
INSert into CungCapDichVu(madichvu, maloaiphong) values (3, 1);
INSert into CungCapDichVu(madichvu, maloaiphong) values (2, 3);
INSert into CungCapDichVu(madichvu, maloaiphong) values (3, 3);

use HotelManagement
go

select * from taikhoan;
select * from khachhang;
-- khac hang
insert into khachhang(tenkhachhang, diachi, sodienthoai, sofax, email, cccd, mataikhoan)
values ('van duc phuoc','q5','123123123','123','abc@gmail.com','123123123',1)

insert into khachhang(tenkhachhang, diachi, sodienthoai, sofax, email, cccd, mataikhoan)
values ('quanlyluhanh','q2','452178933','123','ab12c@gmail.com','456789123',7)

select * from tourdulich;

-- insert tour
insert into TourDuLich(tentour,gia, songay, madoitac) 
values ('SG - Da Lat',123456789,3,1)

insert into TourDuLich(tentour,gia, songay, madoitac) 
values ('SG - PhuQuoc',123456789,4,1)

insert into TourDuLich(tentour,gia, songay, madoitac) 
values ('SG - Da Nang',123456789,5,1)

select * from DoiTac;

-- doi tac
insert into DoiTac(tendoitac, sodienthoai, email) values ('phuong trang', '123123123','aaaaa')

select * from DatTour

-- dat tour
insert into DatTour(matour, makhachhang, thoigiankhoihanh, thoigiantrove, soluonghanhkhach)
values (1,1,'2023-06-15','2023-06-18',2)

-- thuc pham
insert into ThucPham(tenthucpham, soluongton, gia) values ('coca',100,10000);
insert into ThucPham(tenthucpham, soluongton, gia) values ('pepsi',50,10000);
insert into ThucPham(tenthucpham, soluongton, gia) values ('banh mi',100,15000);

select * from Phong;
select * from NoiThat;

-- noi that
insert into NoiThat (ten, gia, maphong) values ('giuong A',5000000,1);
insert into NoiThat (ten, gia, maphong) values ('Tu A',5000000,1);
insert into NoiThat (ten, gia, maphong) values ('Ban A',5000000,1);
insert into NoiThat (ten, gia, maphong) values ('Ghe A',5000000,1);

insert into NoiThat (ten, gia, maphong) values ('giuong B',3000000,2);
insert into NoiThat (ten, gia, maphong) values ('Tu B',3000000,2);
insert into NoiThat (ten, gia, maphong) values ('Ban B',3000000,2);
insert into NoiThat (ten, gia, maphong) values ('Ghe B',3000000,2);

select * from KhachHang;
select * from PhieuDatPhong;
select * from TaiKhoan;
select * from NhanVien;
-- insert nhan vien;
insert into NhanVien (ten, luong, loai,trangthai, mataikhoan) values ('nguyen van a',123456,'letan',N'còn làm việc',6)
insert into NhanVien (ten, luong, loai,trangthai, mataikhoan) values ('nguyen thi b',456123,'buongphong',N'còn làm việc',8)
-- phieu dat phong
insert into PhieuDatPhong (sodemluutru, ngayden, makhachhang, checkin) values (3, '2023-06-15', 1, 1)
insert into PhieuDatPhong (sodemluutru, ngayden, makhachhang, checkin) values (2, '2023-06-01', 1, 0)
insert into PhieuDatPhong (sodemluutru, ngayden, makhachhang, checkin) values (5, '2023-06-14', 5, 1)
update PhieuDatPhong
set nhanviencheckout=5
where maphieudatphong=2

update PhieuDatPhong
set nhanvienvesinh=6
where maphieudatphong=2

select * from PhieuDatPhongChiTiet;
select * from Phong;
update phong
set maloaiphong =2
where maphong=4

-- PhieuDatPhongChiTiet
insert into PhieuDatPhongChiTiet (maphong, maphieudatphong) values (1,1)
insert into PhieuDatPhongChiTiet (maphong, maphieudatphong) values (1,2)

insert into PhieuDatPhongChiTiet (maphong, maphieudatphong) values (2,2)
insert into PhieuDatPhongChiTiet (maphong, maphieudatphong) values (4,2)
insert into PhieuDatPhongChiTiet (maphong, maphieudatphong) values (5,2)
insert into PhieuDatPhongChiTiet (maphong, maphieudatphong) values (7,2)



select * from PhieuSuDungThucPham;

select * from KhachHang;
select * from PhieuDatPhong;

select * from TaiKhoan;

select * from CungCapDichVu;
update CungCapDichVu
set maloaiphong=2
where maloaiphong=3;

select * from PhieuDatPhong;
select * from PhieuDatPhongChiTiet;
select * from KhachHang;

update PhieuDatPhongChiTiet
set maphieudatphong=3
where maphieudatphong=2;
