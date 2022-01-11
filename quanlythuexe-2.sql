-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Máy chủ: localhost:3307
-- Thời gian đã tạo: Th1 11, 2022 lúc 08:27 AM
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

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `dangnhap`
--

CREATE TABLE `dangnhap` (
  `mand` varchar(10) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `dangnhap`
--

INSERT INTO `dangnhap` (`mand`) VALUES
('US0006');

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
('US0001', 'Nguyen Van Ca', 'ca123@gmail.com', 'Bien Hoa, Dong Nai', 'Nam', '1991-02-03', '3466538677364', 'ca123', '0984324566', 1),
('US0002', 'Nguyen Thi Cuc', 'cuc123@gmail.com', 'Ho Chi Minh', 'Nu', '1993-12-11', '3532538674453', 'cuc123', '0983451235', 1),
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
('T018', 'Chevrolet', 'USA');

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
  `loainhienlieu` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `img` varchar(100) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `xe`
--

INSERT INTO `xe` (`id`, `csh_id`, `tenxe`, `thuonghieu`, `vitri`, `bienso`, `giathue`, `ngaythue`, `trangthai_id`, `loainhienlieu`, `img`) VALUES
('XE001', 'US0001', 'Kia Morning', 'T006', 'Hồ Chí Minh', '51B1 - 17654', 200000, '0001-01-01', 'ss', 'Xăng', '7f8634d5-0572-4d14-a663-afda016fb5d5.jpg'),
('XE0010', 'US0002', 'lamborghini aventador', 'T011', 'Hồ Chí Minh', '51B7-98765', 3000000, '0001-01-01', 'ss', 'Xăng', 'a1c032bd-f394-435a-8322-a1678a451b66.jpg'),
('XE0011', 'US0002', 'lamborghini huracan', 'T011', 'Hồ Chí Minh', '51B7-76553', 6000000, '2022-01-11', 'ss', 'Xăng', '7eaa4d8a-2cf0-4220-b0ad-7f37e60d3fda.jpg'),
('XE0012', 'US0004', 'vinfast lux a2.0', 'T016', 'Hồ Chí Minh', '51B2-12775', 2000000, '2022-01-11', 'ss', 'Xăng', '8592605c-6fe2-4a0d-9bdd-775dffe4ac4e.jpg'),
('XE002', 'US0003', 'Kia Morning', 'T006', 'Hồ Chí Minh', '59C5-17662', 500000, '2022-01-11', 'ss', 'Xăng', '4f34a624-1b57-4bc1-878c-a272b410d102.jpg'),
('XE003', 'US0001', 'Mercedes-AMG', 'T007', 'Hồ Chí Minh', '53B7-42144', 3000000, '2022-01-11', 'ss', 'Xăng', '8592605c-6fe2-4a0d-9bdd-775dffe4ac4e.jpg'),
('XE004', 'US0006', 'ford mustang', 'T001', 'Hồ Chí Minh', '51B7-19999', 4000000, '2022-01-11', 'ss', 'Xăng', 'a1b00524-806d-4ca4-8eed-ec7f931cae07.jpg'),
('XE005', 'US0008', 'honda civic', 'T002', 'Hồ Chí Minh', '51B2-56546', 300000, '2022-01-11', 'ss', 'Xăng', 'd0307be6-5a0c-4025-b607-3a2862c080ac.jpg'),
('XE006', 'US0001', 'honda city', 'T002', 'Hồ Chí Minh', '84B1-75563', 300000, '2022-01-11', 'ss', 'Xăng', '0ec1dc5e-f8b2-4c5a-b7de-4ea807a37442.jpg'),
('XE007', 'US0011', 'Hyundai Kona', 'T003', 'Hồ Chí Minh', '51B1-12321', 300000, '2022-01-11', 'ss', 'Xăng', 'd7407e81-33a7-4375-876b-777ccdcdf3c3.jpg'),
('XE008', 'US0015', 'isuzu mux', 'T005', 'Hồ Chí Minh', '51C7-66331', 400000, '2022-01-11', 'ss', 'Xăng', '43252e7b-13a9-4309-995a-d1c339907111.jpg'),
('XE009', 'US0002', 'bmw i8', 'T008', 'Hồ Chí Minh', '51A1-12345', 5000000, '2022-01-11', 'ss', 'Xăng', '4b551ce1-e897-4988-8a7c-e3ff86400090.jpg');

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
