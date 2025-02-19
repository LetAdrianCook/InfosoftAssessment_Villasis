-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 19, 2025 at 10:14 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `alexis`
--

-- --------------------------------------------------------

--
-- Table structure for table `adminuser`
--

CREATE TABLE `adminuser` (
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `adminuser`
--

INSERT INTO `adminuser` (`username`, `password`) VALUES
('alexis', 'alexis123456');

-- --------------------------------------------------------

--
-- Table structure for table `clients`
--

CREATE TABLE `clients` (
  `clientID` int(20) NOT NULL,
  `firstName` varchar(50) NOT NULL,
  `middleName` varchar(50) NOT NULL,
  `lastName` varchar(50) NOT NULL,
  `gender` varchar(20) NOT NULL,
  `birthDate` date NOT NULL,
  `dateCreated` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `clients`
--

INSERT INTO `clients` (`clientID`, `firstName`, `middleName`, `lastName`, `gender`, `birthDate`, `dateCreated`) VALUES
(1, 'Adrian', 'Galia', 'Villasis', 'Male', '2002-08-25', '2025-02-19'),
(2, 'Johna', 'mimi', 'Smith', 'Female', '1993-02-02', '2025-02-19'),
(4, 'Jane', 'Smith', 'Layla', 'Male', '1998-02-19', '2025-02-19'),
(5, 'Jordan', 'Smith', 'Mane', 'Male', '1998-02-19', '2025-02-19');

-- --------------------------------------------------------

--
-- Table structure for table `equipments`
--

CREATE TABLE `equipments` (
  `equipmentID` int(20) NOT NULL,
  `equipmentName` varchar(50) NOT NULL,
  `serviceType` varchar(50) NOT NULL,
  `quantity` int(20) NOT NULL,
  `dateCreated` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `equipments`
--

INSERT INTO `equipments` (`equipmentID`, `equipmentName`, `serviceType`, `quantity`, `dateCreated`) VALUES
(1, 'Plunger', 'Plumbing', 2, '2025-02-19'),
(2, 'Electrical Tape', 'Electrical', 200, '2025-02-19');

-- --------------------------------------------------------

--
-- Table structure for table `schedule`
--

CREATE TABLE `schedule` (
  `billingID` int(20) NOT NULL,
  `clientID` int(20) NOT NULL,
  `scheduledDate` date NOT NULL,
  `totalAmount` decimal(10,2) NOT NULL,
  `dateCreated` date NOT NULL,
  `status` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `schedule`
--

INSERT INTO `schedule` (`billingID`, `clientID`, `scheduledDate`, `totalAmount`, `dateCreated`, `status`) VALUES
(4, 1, '2025-02-19', 1000.00, '2025-02-19', 'UNPAID'),
(5, 1, '2025-02-21', 4750.00, '2025-02-19', 'UNPAID'),
(6, 5, '2025-02-19', 3400.00, '2025-02-19', 'UNPAID'),
(7, 2, '2025-02-19', 3900.00, '2025-02-19', 'UNPAID'),
(9, 5, '2025-02-22', 2000.00, '2025-02-19', 'UNPAID'),
(10, 1, '2025-02-28', 1900.00, '2025-02-19', 'UNPAID'),
(11, 1, '2025-04-23', 900.00, '2025-02-19', 'UNPAID'),
(12, 1, '2025-02-27', 900.00, '2025-02-19', 'UNPAID'),
(13, 2, '2025-04-24', 1000.00, '2025-02-19', 'UNPAID'),
(14, 4, '2025-07-24', 10350.00, '2025-02-19', 'UNPAID'),
(15, 2, '2025-04-11', 3400.00, '2025-02-19', 'UNPAID'),
(16, 1, '2025-03-13', 3750.00, '2025-02-19', 'UNPAID'),
(17, 5, '2025-04-09', 1500.00, '2025-02-19', 'UNPAID'),
(18, 2, '2025-02-24', 3150.00, '2025-02-19', 'UNPAID'),
(19, 1, '2025-05-16', 1500.00, '2025-02-19', 'PAID');

-- --------------------------------------------------------

--
-- Table structure for table `selectedservices`
--

CREATE TABLE `selectedservices` (
  `selectedID` int(20) NOT NULL,
  `billingID` int(20) NOT NULL,
  `serviceID` int(20) NOT NULL,
  `hourlyRate` decimal(10,2) NOT NULL,
  `hoursRendered` int(20) NOT NULL,
  `total` decimal(10,2) NOT NULL,
  `date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `selectedservices`
--

INSERT INTO `selectedservices` (`selectedID`, `billingID`, `serviceID`, `hourlyRate`, `hoursRendered`, `total`, `date`) VALUES
(9, 4, 1, 500.00, 2, 1000.00, '2025-02-19'),
(10, 4, 2, 450.00, 2, 900.00, '2025-02-19'),
(11, 5, 1, 500.00, 5, 2500.00, '2025-02-19'),
(12, 5, 2, 450.00, 5, 2250.00, '2025-02-19'),
(13, 6, 2, 450.00, 2, 900.00, '2025-02-19'),
(14, 6, 1, 500.00, 5, 2500.00, '2025-02-19'),
(15, 7, 2, 450.00, 2, 900.00, '2025-02-19'),
(16, 7, 1, 500.00, 6, 3000.00, '2025-02-19'),
(17, 8, 1, 500.00, 2, 1000.00, '2025-02-19'),
(18, 9, 1, 500.00, 4, 2000.00, '2025-02-19'),
(19, 10, 1, 500.00, 2, 1000.00, '2025-02-19'),
(20, 10, 2, 450.00, 2, 900.00, '2025-02-19'),
(21, 11, 2, 450.00, 2, 900.00, '2025-02-19'),
(22, 12, 2, 450.00, 2, 900.00, '2025-02-19'),
(23, 13, 1, 500.00, 2, 1000.00, '2025-02-19'),
(24, 14, 2, 450.00, 23, 10350.00, '2025-02-19'),
(25, 15, 2, 450.00, 2, 900.00, '2025-02-19'),
(26, 15, 1, 500.00, 5, 2500.00, '2025-02-19'),
(27, 16, 4, 750.00, 5, 3750.00, '2025-02-19'),
(28, 17, 4, 750.00, 2, 1500.00, '2025-02-19'),
(29, 18, 4, 750.00, 3, 2250.00, '2025-02-19'),
(30, 18, 2, 450.00, 2, 900.00, '2025-02-19'),
(31, 19, 4, 750.00, 2, 1500.00, '2025-02-19');

-- --------------------------------------------------------

--
-- Table structure for table `services`
--

CREATE TABLE `services` (
  `serviceID` int(20) NOT NULL,
  `serviceName` varchar(20) NOT NULL,
  `hourlyRate` decimal(10,2) NOT NULL,
  `dateCreated` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `services`
--

INSERT INTO `services` (`serviceID`, `serviceName`, `hourlyRate`, `dateCreated`) VALUES
(1, 'Plumbing', 500.00, '2025-02-19'),
(2, 'Electrical', 450.00, '2025-02-19'),
(3, 'Carpentry Works', 650.00, '2025-02-19'),
(4, 'Masonry', 750.00, '2025-02-19');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `clients`
--
ALTER TABLE `clients`
  ADD PRIMARY KEY (`clientID`);

--
-- Indexes for table `equipments`
--
ALTER TABLE `equipments`
  ADD PRIMARY KEY (`equipmentID`);

--
-- Indexes for table `schedule`
--
ALTER TABLE `schedule`
  ADD PRIMARY KEY (`billingID`);

--
-- Indexes for table `selectedservices`
--
ALTER TABLE `selectedservices`
  ADD PRIMARY KEY (`selectedID`);

--
-- Indexes for table `services`
--
ALTER TABLE `services`
  ADD PRIMARY KEY (`serviceID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `clients`
--
ALTER TABLE `clients`
  MODIFY `clientID` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `equipments`
--
ALTER TABLE `equipments`
  MODIFY `equipmentID` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `schedule`
--
ALTER TABLE `schedule`
  MODIFY `billingID` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `selectedservices`
--
ALTER TABLE `selectedservices`
  MODIFY `selectedID` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;

--
-- AUTO_INCREMENT for table `services`
--
ALTER TABLE `services`
  MODIFY `serviceID` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
