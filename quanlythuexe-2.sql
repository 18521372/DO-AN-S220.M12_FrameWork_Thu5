-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Máy chủ: localhost:3307
-- Thời gian đã tạo: Th12 13, 2021 lúc 11:55 AM
-- Phiên bản máy phục vụ: 10.4.19-MariaDB
-- Phiên bản PHP: 8.0.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `quanlythuexe`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `ctthuexe`
--

CREATE TABLE `ctthuexe` (
  `id` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `sodienthoai` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `email` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `batdau` date NOT NULL,
  `ketthuc` date NOT NULL,
  `trangthai` varchar(2) COLLATE utf8_unicode_ci NOT NULL,
  `tongtien` int(11) NOT NULL,
  `thanhtoan` varchar(15) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `ctthuexe`
--

INSERT INTO `ctthuexe` (`id`, `sodienthoai`, `email`, `batdau`, `ketthuc`, `trangthai`, `tongtien`, `thanhtoan`) VALUES
('THUE0001', '0124124412', 'av@gmail.com', '2021-11-23', '2021-11-27', 'kt', 100000000, 'da thanh toan'),
('THUE0002', '0112456889', 'bv@gmail.com', '2021-11-25', '2021-11-27', 'kt', 80000000, 'da thanh toan'),
('THUE0003', '0124124412', 'av@gmail.com', '2021-11-23', '2021-11-27', 'kt', 70000000, 'da thanh toan'),
('THUE0004', '0124124412', 'av@gmail.com', '2021-11-23', '2021-11-27', 'kt', 90000000, 'da thanh toan'),
('THUE0005', '0124124412', 'avas@gmail.com', '2021-11-23', '2021-11-30', 'kt', 110000000, 'da thanh toan'),
('THUE0006', '0124124412', 'avas@gmail.com', '2021-11-23', '2021-11-30', 'kt', 80000000, 'da thanh toan'),
('THUE0008', '0124124412', 'avas@gmail.com', '2021-11-23', '2021-11-30', 'kt', 70000000, 'da thanh toan'),
('THUE0009', '0124124412', 'avas@gmail.com', '2021-11-23', '2021-11-30', 'kt', 50000000, 'da thanh toan'),
('THUE0010', '0124124412', 'avas@gmail.com', '2021-11-23', '2021-11-30', 'kt', 40000000, 'da thanh toan'),
('THUE0011', '0124124412', 'avas@gmail.com', '2021-11-23', '2021-11-30', 'kt', 95000000, 'da thanh toan'),
('THUE0012', '0124124412', 'avas@gmail.com', '2021-11-23', '2021-11-30', 'kt', 80000000, 'da thanh toan'),
('THUE0013', '0124124412', 'avas@gmail.com', '2021-11-23', '2021-11-30', 'kt', 76000000, 'da thanh toan'),
('THUE0014', '0124124412', 'avas@gmail.com', '2021-11-23', '2021-11-30', 'kt', 65000000, 'da thanh toan'),
('THUE0015', '0124124412', 'avas@gmail.com', '2021-11-23', '2021-11-30', 'kt', 100000000, 'da thanh toan'),
('THUE0016', '0124124412', 'avas@gmail.com', '2021-11-23', '2021-11-30', 'kt', 100000000, 'da thanh toan'),
('THUE0017', '0124124412', 'avas@gmail.com', '2021-11-23', '2021-11-30', 'kt', 87000000, 'da thanh toan'),
('THUE0018', '0124124412', 'avas@gmail.com', '2021-11-23', '2021-11-30', 'kt', 100000000, 'da thanh toan'),
('THUE0019', '0984566378', 'cuc123@gmail.com', '2021-12-16', '2021-12-22', 'kt', 9000000, 'da thanh toan'),
('THUE0020', '0984566378', 'cuc123@gmail.com', '2021-11-16', '2021-11-22', 'kt', 9000000, 'da thanh toan');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `nguoidung`
--

CREATE TABLE `nguoidung` (
  `id` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `ten` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `email` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `diachi` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `gioitinh` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `ngaysinh` date NOT NULL,
  `id_card` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `password` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `sodienthoai` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `quyen_id` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `nguoidung`
--

INSERT INTO `nguoidung` (`id`, `ten`, `email`, `diachi`, `gioitinh`, `ngaysinh`, `id_card`, `password`, `sodienthoai`, `quyen_id`) VALUES
('US0001', 'Nguyen Van Ca', 'ca123@gmail.com', 'Bien Hoa, Dong Nai', 'Nam', '1991-02-03', '3466538677364', 'ca123', '0984324568', 1),
('US0002', 'Nguyen Thi Cuc', 'cuc123@gmail.com', 'Ho Chi Minh', 'Nu', '1993-12-11', '3532538674453', 'cuc123', '0983451236', 1),
('US0003', 'Mai Xuan Hung', 'hung@gmail.com', 'Ho Chi Minh', 'Nam', '1999-06-05', '4567347721423', 'hung', '0984566378', 1),
('US0004', 'Le Van Thien', 'thienlez@gmail.com', 'Tra Vinh', 'Nam', '2000-02-09', '2377659807564', 'thienle', '0984456387', 1),
('US0005', 'Le Xuan Thien', 'thienle@gmail.com', 'Ha Noi', 'Nam', '1986-11-22', '4334676549986', 'thienle', '0918763343', 1),
('US0006', 'Huynh A', 'ha123@gmail.com', 'Trang Bom, Dong Nai', 'Nam', '1995-01-03', '4234523526439', 'ca123', '0984324568', 2),
('US0007', 'Tran Trang', 'tt123@gmail.com', 'Bien Hoa, Dong Nai', 'Nam', '1991-02-03', '12412124125', 'ca123', '0214124524', 1),
('US0008', 'Chau C', 'cc123@gmail.com', 'Bien Hoa, Dong Nai', 'Nu', '1989-02-03', '124125125', 'ca123', '0241466732', 1),
('US0009', 'Cao Lau', 'ca123@gmail.com', 'Thu Duc, Ho Chi Minh', 'Nam', '1991-02-03', '3466538677364', 'ca123', '0124124512', 2),
('US0010', 'Dinh Hao', 'dh123@gmail.com', 'Thu Duc, Ho Chi Minh', 'Nam', '1991-02-03', '3466538677364', 'ca123', '0913581285', 2),
('US0011', 'Huynh B', 'hb123@gmail.com', 'Trang Bom, Dong Nai', 'Nam', '1995-01-03', 'qq24112', 'ca123', '0984324568', 1),
('US0012', 'Tran Dan', 'td123@gmail.com', 'Bien Hoa, Dong Nai', 'Nam', '1991-02-03', '12412124125', 'ca123', '0214124524', 1),
('US0013', 'Chau D', 'cd123@gmail.com', 'Bien Hoa, Dong Nai', 'Nu', '1989-02-03', '124125125', 'ca123', '0241466732', 1),
('US0014', 'Cao Hung', 'ca123@gmail.com', 'Thu Duc, Ho Chi Minh', 'Nam', '1991-02-03', '3466538677364', 'ca123', '0124124512', 2),
('US0015', 'Dinh Luc', 'dh123@gmail.com', 'Thu Duc, Ho Chi Minh', 'Nam', '1991-02-03', '3466538677364', 'ca123', '0913581285', 1),
('US0016', 'Huynh C', 'hb123@gmail.com', 'Trang Bom, Dong Nai', 'Nam', '1995-01-03', 'qq24112', 'ca123', '0984324568', 1),
('US0017', 'Tran Thi', 'td123@gmail.com', 'Bien Hoa, Dong Nai', 'Nam', '1991-02-03', '12412124125', 'ca123', '0214124524', 2),
('US0018', 'Chau Thi No', 'cd123@gmail.com', 'Bien Hoa, Dong Nai', 'Nu', '1989-02-03', '124125125', 'ca123', '0241466732', 2);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `quyen`
--

CREATE TABLE `quyen` (
  `id` int(1) NOT NULL,
  `tenquyen` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `mota` varchar(40) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `quyen`
--

INSERT INTO `quyen` (`id`, `tenquyen`, `mota`) VALUES
(1, 'Nguoi dung', '--'),
(2, 'Nha quan ly', '--');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `thuexe`
--

CREATE TABLE `thuexe` (
  `id` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `nsd_id` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `xe_id` varchar(10) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `thuexe`
--

INSERT INTO `thuexe` (`id`, `nsd_id`, `xe_id`) VALUES
('THUE0001', 'US0001', 'XE0001'),
('THUE0002', 'US0002', 'XE0002'),
('THUE0003', 'US0002', 'XE0003'),
('THUE0004', 'US0004', 'XE0004'),
('THUE0005', 'US0005', 'XE0005'),
('THUE0006', 'US0006', 'XE0006'),
('THUE0007', 'US0007', 'XE0007'),
('THUE0008', 'US0004', 'XE0004'),
('THUE0009', 'US0005', 'XE0005'),
('THUE0010', 'US0006', 'XE0006'),
('THUE0011', 'US0011', 'XE0011'),
('THUE0012', 'US0012', 'XE0009'),
('THUE0013', 'US0012', 'XE0013'),
('THUE0014', 'US0014', 'XE0010'),
('THUE0015', 'US0015', 'XE0015'),
('THUE0016', 'US0016', 'XE0016'),
('THUE0017', 'US0017', 'XE0017'),
('THUE0018', 'US0018', 'XE0018'),
('THUE0019', 'US0004', 'XE0003'),
('THUE0020', 'US0002', 'XE0001');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `thuonghieu`
--

CREATE TABLE `thuonghieu` (
  `id` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `tenth` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `quocgia` varchar(40) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `thuonghieu`
--

INSERT INTO `thuonghieu` (`id`, `tenth`, `quocgia`) VALUES
('T001', 'FORD', 'USA'),
('T002', 'Honda', 'Japan'),
('T003', 'Hyundai', 'Korea'),
('T004', 'Toyota', 'Japan'),
('T005', 'Isuzu', 'Japan'),
('T006', 'KIA', 'Korea'),
('T007', 'Mercedes Benz', 'Germany'),
('T008', 'BMW', 'Germany'),
('T010', 'Audi', 'Germany'),
('T011', 'Lamborghini', 'Italia'),
('T012', 'Volvo', 'Switzerland'),
('T013', 'Maserati', 'Italia'),
('T014', 'Aston Martin', 'England'),
('T015', 'Bently', 'England'),
('T016', 'Vinfast', 'Vietnam'),
('T017', 'Mitsubishi', 'Japan'),
('T018', 'Chevrolet', 'USA'),
('T019', 'Lexus', 'Japan'),
('T020', 'Mazda', 'Japan'),
('T021', 'Nissan', 'Japan'),
('T022', 'Subaru', 'Japan');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `trangthai`
--

CREATE TABLE `trangthai` (
  `ten` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `code` varchar(2) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `trangthai`
--

INSERT INTO `trangthai` (`ten`, `code`) VALUES
('cho duyet', 'cd'),
('dang thue', 'dt'),
('san sang', 'ss'),
('tam dung', 'td');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `trangthaithue`
--

CREATE TABLE `trangthaithue` (
  `id` varchar(2) COLLATE utf8_unicode_ci NOT NULL,
  `motta` varchar(10) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `trangthaithue`
--

INSERT INTO `trangthaithue` (`id`, `motta`) VALUES
('cl', 'cho lay'),
('dt', 'dang thue'),
('kt', 'ket thuc');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `xe`
--

CREATE TABLE `xe` (
  `id` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `csh_id` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `tenxe` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `thuonghieu` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `vitri` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `bienso` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `giathue` int(20) NOT NULL,
  `ngaythue` date NOT NULL,
  `trangthai_id` varchar(2) COLLATE utf8_unicode_ci NOT NULL,
  `loainhienlieu` varchar(10) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `xe`
--

INSERT INTO `xe` (`id`, `csh_id`, `tenxe`, `thuonghieu`, `vitri`, `bienso`, `giathue`, `ngaythue`, `trangthai_id`, `loainhienlieu`) VALUES
('XE0001', 'US0001', 'Toyota', 'T001', 'Ho Chi Minh', '59B1-12425', 5000000, '2021-11-02', 'dt', 'Xang'),
('XE0002', 'US0001', 'Yamaha', 'T002', 'Ho Chi Minh', '59B1-11242', 5000000, '2020-10-13', 'ss', 'Xang'),
('XE0003', 'US0003', 'Lamboghini', 'T003', 'Ho Chi Minh', '59B1-21412', 10000000, '2021-12-02', 'cd', 'Xang'),
('XE0004', 'US0004', 'Rollroyce', 'T004', 'Ho Chi Minh', '60B1-12425', 50000000, '2021-12-07', 'cd', 'Xang'),
('XE0005', 'US0001', 'Ferrari', 'T005', 'Da Nang', '59B1-99999', 55000000, '2021-11-02', 'td', 'Xang'),
('XE0006', 'US0006', 'Bugatti', 'T006', 'Ho Chi Minh', '59B1-77777', 52000000, '2021-11-25', 'ss', 'Xang'),
('XE0007', 'US0001', 'Yamaha 2', 'T002', 'Da Nang', '59B1-11242', 5000000, '2021-11-25', 'dt', 'Xang'),
('XE0008', 'US0008', 'Huyndai', 'T007', 'Ho Chi Minh', '59B1-12345', 10000000, '2021-11-30', 'cd', 'Xang'),
('XE0009', 'US0009', 'Rollroyce', 'T004', 'Da Nang', '60B1-12425', 50000000, '2021-12-25', 'cd', 'Xang'),
('XE0010', 'US0010', 'Ferrari', 'T005', 'Da Nang', '59B1-99999', 55000000, '2021-11-20', 'td', 'Xang'),
('XE0011', 'US0011', 'Bugatti', 'T006', 'Ho Chi Minh', '59B1-77777', 52000000, '2021-11-25', 'ss', 'Xang'),
('XE0012', 'US0012', 'Yamaha', 'T002', 'Da Nang', '59B1-17775', 5000000, '2021-11-25', 'dt', 'Xang'),
('XE0013', 'US0013', 'Lamboghini', 'T003', 'Ho Chi Minh', '59B1-21412', 10000000, '2021-12-25', 'cd', 'Xang'),
('XE0014', 'US0014', 'Aston Martin 1', 'T014', 'Da Nang', '60B1-12425', 50000000, '2021-12-25', 'ss', 'Xang'),
('XE0015', 'US0001', 'Ferrari', 'T005', 'Ho Chi Minh', '59B1-99999', 55000000, '2021-11-20', 'td', 'Xang'),
('XE0016', 'US0016', 'Bugatti', 'T006', 'Da Nang', '59B1-77777', 52000000, '2021-11-25', 'ss', 'Xang'),
('XE0017', 'US0017', 'Yamaha', 'T016', 'Da Nang', '59B1-11242', 5000000, '2021-11-25', 'dt', 'Xang'),
('XE0018', 'US0018', 'Lamboghini', 'T003', 'Ho Chi Minh', '59B1-21412', 10000000, '2021-12-25', 'cd', 'Xang'),
('XE0019', 'US0004', 'Rollroyce', 'T004', 'Da Nang', '60B1-12425', 50000000, '2021-12-25', 'cd', 'Xang'),
('XE0020', 'US0001', 'Ferrari', 'T005', 'Ho Chi Minh', '59B1-99999', 55000000, '2021-11-20', 'td', 'Xang');

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `ctthuexe`
--
ALTER TABLE `ctthuexe`
  ADD PRIMARY KEY (`id`),
  ADD KEY `tt_tx` (`trangthai`);

--
-- Chỉ mục cho bảng `nguoidung`
--
ALTER TABLE `nguoidung`
  ADD PRIMARY KEY (`id`),
  ADD KEY `quyen_id` (`quyen_id`);

--
-- Chỉ mục cho bảng `quyen`
--
ALTER TABLE `quyen`
  ADD PRIMARY KEY (`id`);

--
-- Chỉ mục cho bảng `thuexe`
--
ALTER TABLE `thuexe`
  ADD PRIMARY KEY (`id`),
  ADD KEY `nsd_id` (`nsd_id`),
  ADD KEY `xe_id` (`xe_id`);

--
-- Chỉ mục cho bảng `thuonghieu`
--
ALTER TABLE `thuonghieu`
  ADD PRIMARY KEY (`id`);

--
-- Chỉ mục cho bảng `trangthai`
--
ALTER TABLE `trangthai`
  ADD PRIMARY KEY (`code`);

--
-- Chỉ mục cho bảng `trangthaithue`
--
ALTER TABLE `trangthaithue`
  ADD PRIMARY KEY (`id`);

--
-- Chỉ mục cho bảng `xe`
--
ALTER TABLE `xe`
  ADD PRIMARY KEY (`id`),
  ADD KEY `csh_xe` (`csh_id`),
  ADD KEY `trangthai_id` (`trangthai_id`),
  ADD KEY `thuonghieu_id` (`thuonghieu`);

--
-- Các ràng buộc cho các bảng đã đổ
--

--
-- Các ràng buộc cho bảng `ctthuexe`
--
ALTER TABLE `ctthuexe`
  ADD CONSTRAINT `ct_id` FOREIGN KEY (`id`) REFERENCES `thuexe` (`id`),
  ADD CONSTRAINT `tt_tx` FOREIGN KEY (`trangthai`) REFERENCES `trangthaithue` (`id`);

--
-- Các ràng buộc cho bảng `nguoidung`
--
ALTER TABLE `nguoidung`
  ADD CONSTRAINT `quyen_id` FOREIGN KEY (`quyen_id`) REFERENCES `quyen` (`id`);

--
-- Các ràng buộc cho bảng `thuexe`
--
ALTER TABLE `thuexe`
  ADD CONSTRAINT `nsd_id` FOREIGN KEY (`nsd_id`) REFERENCES `nguoidung` (`id`),
  ADD CONSTRAINT `xe_id` FOREIGN KEY (`xe_id`) REFERENCES `xe` (`id`);

--
-- Các ràng buộc cho bảng `xe`
--
ALTER TABLE `xe`
  ADD CONSTRAINT `csh_xe` FOREIGN KEY (`csh_id`) REFERENCES `nguoidung` (`id`),
  ADD CONSTRAINT `thuonghieu_id` FOREIGN KEY (`thuonghieu`) REFERENCES `thuonghieu` (`id`),
  ADD CONSTRAINT `trangthai_id` FOREIGN KEY (`trangthai_id`) REFERENCES `trangthai` (`code`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
