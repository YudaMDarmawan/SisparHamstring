-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Dec 07, 2017 at 07:00 AM
-- Server version: 10.1.13-MariaDB
-- PHP Version: 5.6.23

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbspk`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_ediag`
--

CREATE TABLE `tbl_ediag` (
  `kddiagnosa` varchar(16) NOT NULL,
  `diagnosa` varchar(50) NOT NULL,
  `solusi` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_ediag`
--

INSERT INTO `tbl_ediag` (`kddiagnosa`, `diagnosa`, `solusi`) VALUES
('R01', 'Bicep Femoris', 'Beristirahat dari aktivitas yang terlalu berat, mengompres bengkak dengan es beberapa kali sehari, menggunakan celana yang bersepeda untuk mengatasi bengkak, pada cedera parah misalkan otot robek akan memerlukan operasi untuk memperbaiki otot.'),
('R02', 'Semitendinonus', 'Beristirahat dari aktivitas yang terlalu berat, mengompres bengkak dengan es beberapa kali sehari, membebat pada bagian yang bengkak.'),
('R03', 'Semimembranosus', 'Beristirahat dari aktivitas yang terlalu berat, menggunakan kruk sebagai alat bantu berjalan, mengompres bengkak dengan es beberapa kali sehari, membebat pada bagian yang bengkak.'),
('P001', 'Radang Tenggorokan', 'banyak minum dan instirahat');

-- --------------------------------------------------------

--
-- Table structure for table `tentrypertanyaan`
--

CREATE TABLE `tentrypertanyaan` (
  `kdpertanyaan` varchar(10) NOT NULL,
  `pertanyaan` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tentrypertanyaan`
--

INSERT INTO `tentrypertanyaan` (`kdpertanyaan`, `pertanyaan`) VALUES
('P01', 'Apakah merasa nyeri pada bagian lateral?'),
('P02', 'Apakah merasa nyeri pada bagian medial?'),
('P03', 'Apakah nyeri dipaha belakang yang berlangsung tiba-tiba ketika beraktifitas?'),
('P04', 'Apakah nyeri dipaha belakang yang berlangsung tiba-tiba setelah beraktifitas?'),
('P05', 'Apakah otot terasa robek atau putus?'),
('P06', 'Apakah terjadi bengkak dalam beberapa jam setelah cedera terjadi?'),
('P07', 'Apakah terjadi bengkak secara cepat?'),
('P08', 'Apakah bagian cedera terasa lunak?'),
('P09', 'Apakah bagian cedera terasa keras?'),
('P10', 'Apakah kaki bagia belakang lebam?'),
('P11', 'Apakah otot melemah? '),
('P12', 'Apakah kaki tidak mampu mengangkat beban?'),
('P13', 'Apakah kaki merasa sakit sekali bila digerakan?'),
('P14', 'Apakah kaki merasa tidak terlalu sakit sekali bila digerakan?');

-- --------------------------------------------------------

--
-- Table structure for table `tuser`
--

CREATE TABLE `tuser` (
  `kduser` varchar(16) NOT NULL,
  `nama` varchar(35) NOT NULL,
  `password` varchar(20) NOT NULL,
  `level` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tuser`
--

INSERT INTO `tuser` (`kduser`, `nama`, `password`, `level`) VALUES
('Dr. Radi', 'Dr. Radi', 'abcde', 'Dokter'),
('Admin', 'Yusuf', 'Admin', 'Admin');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
