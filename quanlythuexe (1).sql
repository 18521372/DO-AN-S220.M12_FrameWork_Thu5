-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Máy chủ: localhost:3307
-- Thời gian đã tạo: Th10 15, 2021 lúc 08:24 AM
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
-- Cấu trúc bảng cho bảng `nguoidung`
--

CREATE TABLE `nguoidung` (
  `id` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `ten` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `email` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `diachi` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `gioitinh` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `id_card` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `password` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `sodienthoai` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `quyen_id` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `quyen`
--

CREATE TABLE `quyen` (
  `id` int(1) NOT NULL,
  `tenquyen` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `mota` varchar(40) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `thuexe`
--

CREATE TABLE `thuexe` (
  `id` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `sodienthoai` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `email` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `ten` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `nsd_id` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `xe_id` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `batdau` date NOT NULL,
  `ketthuc` date NOT NULL,
  `vitri` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `trangthai` varchar(10) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `thuonghieu`
--

CREATE TABLE `thuonghieu` (
  `id` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `tenth` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `quocgia` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `logo` varchar(100) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `trangthai`
--

CREATE TABLE `trangthai` (
  `ten` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `code` varchar(2) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `xe`
--

CREATE TABLE `xe` (
  `id` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `csh_id` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `tenxe` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `bienso` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `trangthai_id` varchar(2) COLLATE utf8_unicode_ci NOT NULL,
  `giathue` int(20) NOT NULL,
  `ngaythue` date NOT NULL,
  `th_id` varchar(2) COLLATE utf8_unicode_ci NOT NULL,
  `loainhienlieu` varchar(10) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Chỉ mục cho các bảng đã đổ
--

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
-- Chỉ mục cho bảng `xe`
--
ALTER TABLE `xe`
  ADD PRIMARY KEY (`id`),
  ADD KEY `csh_xe` (`csh_id`),
  ADD KEY `th_id` (`th_id`);

--
-- Các ràng buộc cho các bảng đã đổ
--

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
  ADD CONSTRAINT `th_id` FOREIGN KEY (`th_id`) REFERENCES `trangthai` (`code`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
