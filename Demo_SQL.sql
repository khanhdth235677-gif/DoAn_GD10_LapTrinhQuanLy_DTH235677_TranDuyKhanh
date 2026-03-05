	SELECT * FROM NhanVien

INSERT INTO NhanVien
(HoTen, NgaySinh, DiaChi, GioiTinh, DanToc, CCCD, NoiCap, ChucVu, PhongBanID, DienThoai, Email, NgayVaoLam, TrangThai)
VALUES
(N'Nguyễn Văn A','1995-05-10',N'Hồ Chí Minh',N'Nam',N'Kinh','456789012345',N'HCM',N'Nhân viên',2,'0901234567','a@gmail.com','2023-01-10',N'Đang làm'),

(N'Lê Thị C','1998-09-15',N'Đà Nẵng',N'Nữ',N'Kinh','567890123456',N'Đà Nẵng',N'Thư ký',3,'0902345678','c@gmail.com','2023-02-15',N'Đang làm'),

(N'Phan Văn H','1992-12-01',N'Cần Thơ',N'Nam',N'Kinh','678901234567',N'Cần Thơ',N'Quản lý',4,'0903456789','h@gmail.com','2022-12-01',N'Đang làm');

SELECT * FROM PhongBan

INSERT INTO PhongBan (TenPhongBan, MoTa)
VALUES
(N'Kế toán', N'Quản lý tài chính và kế toán'),
(N'Nhân sự', N'Quản lý nhân viên'),
(N'Công nghệ thông tin', N'Quản lý hệ thống và phần mềm'),
(N'Kinh doanh', N'Phụ trách bán hàng và doanh thu'),
(N'Marketing', N'Quảng bá và tiếp thị sản phẩm');


SELECT * FROM PhongBan
INSERT INTO PhongBan (TenPhongBan)
VALUES 
(N'IT'),
(N'Nhân sự'),
(N'Kế toán'),
(N'Marketing')
INSERT INTO DuAn
(TenDuAn, NgayBatDau, NgayKetThuc)
VALUES
(N'Website bán hàng', '2024-01-01', '2024-06-30'),
(N'Phần mềm quản lý nhân sự', '2024-03-01', '2024-12-30'),
(N'Ứng dụng mobile bán hàng', '2024-02-01', '2024-10-01')
INSERT INTO PhanCongDuAn
(NhanVienID, DuAnID, VaiTro, GiaTri)
VALUES
(1, 1, N'Developer', 80),
(1, 2, N'Backend', 90),
(2, 2, N'Project Manager', 95),
(3, 1, N'Tester', 70),
(3, 3, N'Mobile Developer', 85)

INSERT INTO NhanVien
(HoTen, NgaySinh, GioiTinh, DienThoai, DiaChi, Email, CCCD, DanToc, NoiCap,
NgayVaoLam, TrangThai, PhongBanID, HinhAnh)
VALUES
(N'Nguyễn Văn An','1995-03-10',N'Nam','0901111111',N'Hà Nội',
'an@gmail.com','123456789',N'Kinh',N'Hà Nội',
'2022-01-10',N'Đang làm',16,'Anh_Avatar1.PNG'),

(N'Trần Thị Bình','1997-05-20',N'Nữ','0902222222',N'TP.HCM',
'binh@gmail.com','987654321',N'Kinh',N'TP.HCM',
'2023-02-15',N'Đang làm',17,'Anh_Avatar2.PNG'),

(N'Lê Văn Cường','1994-07-12',N'Nam','0903333333',N'Đà Nẵng',
'cuong@gmail.com','456789123',N'Kinh',N'Đà Nẵng',
'2021-06-01',N'Đang làm',18,'Anh_Avatar3.PNG')
INSERT INTO PhongBan (TenPhongBan)
VALUES
(N'IT'),
(N'Nhân sự'),
(N'Kế toán')
SELECT * FROM PhongBan

SELECT * FROM PhanCongDuAn 
SELECT * FROM DuAn
SELECT * FROM PhongBan
SELECT * FROM NhanVien

DELETE FROM PhanCongDuAn
DELETE FROM DuAn
DELETE FROM PhongBan
DELETE FROM NhanVien

INSERT INTO PhongBan (TenPhongBan)
VALUES
(N'Kinh doanh'),
(N'Marketing'),
(N'IT Support');
INSERT INTO NhanVien (ChucVu)
VALUES
(N'Giám đốc'),
(N'Nhân viên'),
(N'THục tập sinh')
INSERT INTO NhanVien
(HoTen, NgaySinh, GioiTinh, DienThoai, DiaChi, Email, CCCD, DanToc, NoiCap,
NgayVaoLam, TrangThai, PhongBanID, HinhAnh)
VALUES
(N'Nguyễn Văn An','1995-03-10',N'Nam','0901111111',N'Hà Nội',
'an@gmail.com','123456789',N'Kinh',N'Hà Nội',
'2022-01-10',N'Đang làm',19,'Anh_Avatar1.PNG'),

(N'Trần Thị Bình','1997-05-20',N'Nữ','0902222222',N'TP.HCM',
'binh@gmail.com','987654321',N'Kinh',N'TP.HCM',
'2023-02-15',N'Đang làm',20,'Anh_Avatar2.PNG'),

(N'Lê Văn Cường','1994-07-12',N'Nam','0903333333',N'Đà Nẵng',
'cuong@gmail.com','456789123',N'Kinh',N'Đà Nẵng',
'2021-06-01',N'Đang làm',21,'Anh_Avatar3.PNG')
INSERT INTO DuAn (TenDuAn, NgayBatDau, NgayKetThuc)
VALUES
(N'Website bán hàng','2024-01-01','2024-06-30'),
(N'Phần mềm quản lý nhân sự','2024-03-01','2024-12-30'),
(N'Ứng dụng mobile bán hàng','2024-02-01','2024-10-01')
INSERT INTO PhanCongDuAn
(NhanVienID, DuAnID, VaiTro, GiaTri)
VALUES
(24,4,N'Developer',80),
(25,5,N'Backend',90),
(26,6,N'Project Manager',95)



INSERT INTO DuAn
(MaDuAn, TenDuAn, MoTa, KhachHang, PhongBanID, NguoiQuanLyID,
 NgayBatDau, NgayKetThucDuKien, NgayKetThucThucTe,
 GiaTriHopDong, TinhTrang, TienDo, GhiChu)
VALUES
-- Dự án 1
('DA001', N'Website bán hàng', N'Xây dựng website thương mại điện tử',
 N'Công ty ABC', 22, 34,
 '2024-01-01', '2024-06-01', NULL,
 50000000, N'Đang thực hiện', 60, N'Đúng tiến độ'),

-- Dự án 2
('DA002', N'Phần mềm quản lý nhân sự', N'Hệ thống quản lý nhân sự nội bộ',
 N'Công ty XYZ', 23, 35,
 '2024-03-01', '2024-08-01', NULL,
 80000000, N'Đang thực hiện', 40, N'Đang phát triển'),

-- Dự án 3
('DA003', N'Ứng dụng mobile bán hàng', N'App bán hàng trên Android/iOS',
 N'Công ty DEF', 24, 36,
 '2024-02-01', '2024-07-01', '2024-06-20',
 60000000, N'Hoàn thành', 100, N'Hoàn thành sớm');




 INSERT INTO NhanVien
(HoTen, NgaySinh, GioiTinh, DienThoai, DiaChi, Email, CCCD, DanToc, NoiCap,
 NgayVaoLam, TrangThai, PhongBanID, HinhAnh)
VALUES
(N'Phạm Minh Tuấn', '1996-04-12', N'Nam', '0911111111', N'Hà Nội',
'tuan@gmail.com', '111222333', N'Kinh', N'Hà Nội',
'2023-01-10', N'Đang làm', 22, 'avatar4.png'),

(N'Nguyễn Thị Lan', '1998-09-21', N'Nữ', '0922222222', N'TP.HCM',
'lan@gmail.com', '222333444', N'Kinh', N'TP.HCM',
'2023-05-15', N'Đang làm', 23, 'avatar5.png'),

(N'Trần Quốc Bảo', '1995-12-05', N'Nam', '0933333333', N'Đà Nẵng',
'bao@gmail.com', '333444555', N'Kinh', N'Đà Nẵng',
'2022-11-01', N'Đang làm', 24, 'avatar6.png');