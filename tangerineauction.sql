-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Feb 29, 2024 at 05:31 PM
-- Server version: 5.7.24
-- PHP Version: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `tangerineauction`
--

-- --------------------------------------------------------

--
-- Table structure for table `tangerineslots`
--

CREATE TABLE `tangerineslots` (
  `id` int(10) NOT NULL,
  `CurrentRate` int(10) NOT NULL DEFAULT '0',
  `FromUser` varchar(100) DEFAULT NULL,
  `IconID` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tangerineslots`
--

INSERT INTO `tangerineslots` (`id`, `CurrentRate`, `FromUser`, `IconID`) VALUES
(21, 2000, 'sva_work@inbox.ru', 4),
(22, 1111, 'sva_work@inbox.ru', 2),
(23, 2333, 'sva_work@inbox.ru', 4),
(24, 0, NULL, 2),
(25, 0, NULL, 4),
(26, 0, NULL, 5);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(10) NOT NULL,
  `mail` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `mail`, `password`) VALUES
(2, 'sva_work@inbox.ru', '12345'),
(3, 'en79s@mail.ru', '12345');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tangerineslots`
--
ALTER TABLE `tangerineslots`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tangerineslots`
--
ALTER TABLE `tangerineslots`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
