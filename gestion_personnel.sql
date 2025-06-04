-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 03, 2025 at 09:24 PM
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
-- Database: `gestion_personnel`
--

-- --------------------------------------------------------

--
-- Table structure for table `absence`
--

CREATE TABLE `absence` (
  `idpersonnel` int(11) NOT NULL,
  `datedebut` date NOT NULL,
  `datefin` date DEFAULT NULL,
  `idmotif` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `datefin`, `idmotif`) VALUES
(1, '2024-04-24', '2024-07-24', 3),
(1, '2024-05-05', '2024-08-04', 1),
(1, '2024-05-29', '2024-07-25', 4),
(1, '2024-06-14', '2024-07-26', 4),
(1, '2024-06-15', '2024-07-24', 4),
(2, '2024-04-05', '2024-07-22', 4),
(2, '2024-05-05', '2024-07-14', 1),
(2, '2024-05-22', '2024-07-15', 2),
(2, '2024-06-19', '2024-07-22', 3),
(3, '2023-01-11', '2023-01-12', 3),
(3, '2023-01-13', '2023-01-15', 1),
(3, '2024-05-05', '2025-05-06', 4),
(3, '2024-05-15', '2024-07-26', 1),
(3, '2024-05-22', '2024-05-23', 3),
(3, '2024-06-23', '2024-06-25', 4),
(3, '2024-06-24', '2024-07-13', 2),
(3, '2025-05-16', '2025-05-17', 3),
(4, '2024-04-12', '2024-08-25', 4),
(4, '2024-05-09', '2024-08-13', 3),
(4, '2024-05-23', '2024-08-10', 1),
(4, '2024-06-04', '2024-07-08', 2),
(4, '2024-06-19', '2024-07-16', 3),
(5, '2024-04-09', '2024-08-18', 4),
(5, '2024-04-24', '2024-07-24', 3),
(5, '2024-05-21', '2024-08-13', 4),
(5, '2024-05-22', '2024-07-07', 4),
(5, '2024-05-29', '2024-08-18', 4),
(6, '2023-01-05', '2023-01-06', 2),
(6, '2023-05-22', '2023-06-28', 1),
(6, '2024-04-18', '2024-07-14', 1),
(6, '2024-04-22', '2024-04-28', 2),
(6, '2024-05-12', '2024-06-14', 1),
(6, '2024-06-11', '2024-06-15', 1),
(7, '2024-04-12', '2024-07-03', 3),
(7, '2024-04-16', '2024-07-21', 1),
(7, '2024-04-25', '2024-07-05', 3),
(7, '2024-04-29', '2024-07-24', 1),
(7, '2024-05-14', '2024-08-05', 2),
(7, '2024-12-06', '2024-12-07', 4),
(8, '2024-01-22', '2024-01-23', 4),
(8, '2024-03-10', '2024-03-16', 1),
(8, '2024-04-24', '2024-04-29', 3),
(9, '2024-04-19', '2024-08-04', 1),
(9, '2024-04-22', '2024-07-29', 3),
(9, '2024-05-03', '2024-07-12', 1),
(9, '2024-05-27', '2024-07-29', 2),
(9, '2024-05-30', '2024-08-25', 4),
(10, '2024-04-10', '2024-08-06', 2),
(10, '2024-05-05', '2024-07-20', 4),
(10, '2024-05-06', '2024-07-02', 4),
(10, '2024-05-15', '2024-08-16', 4),
(10, '2024-06-10', '2024-08-18', 1);

-- --------------------------------------------------------

--
-- Table structure for table `motif`
--

CREATE TABLE `motif` (
  `idmotif` int(11) NOT NULL,
  `libelle` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Table structure for table `personnel`
--

CREATE TABLE `personnel` (
  `idpersonnel` int(11) NOT NULL,
  `nom` varchar(100) NOT NULL,
  `prenom` varchar(100) NOT NULL,
  `tel` varchar(20) DEFAULT NULL,
  `mail` varchar(100) DEFAULT NULL,
  `idservice` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `nom`, `prenom`, `tel`, `mail`, `idservice`) VALUES
(1, 'Langley', 'Roth', '1-453-233-3366', 'scelerisque@icloud.couk', 1),
(2, 'Hopper', 'Adria', '1-324-477-1373', 'porttitor.interdum@hotmail.ca', 2),
(3, 'Faulkner', 'Wallace', '1-406-554-9761', 'purus.duis.elementum@google.org', 3),
(4, 'Strickland', 'Skyler', '1-536-338-6855', 'egestas.ligula@yahoo.ca', 1),
(5, 'Ochoa', 'Vera', '1-438-346-7186', 'enim.etiam.gravida@yahoo.ca', 2),
(6, 'Hopkins', 'Tanisha', '(825) 234-7845', 'maecenas.malesuada.fringilla@icloud.edu', 3),
(7, 'Frye', 'Yvette', '(243) 497-1214', 'cursus.in@protonmail.net', 1),
(8, 'Armstrong', 'Remedios', '1-642-421-1247', 'facilisis@google.couk', 2),
(9, 'Schwartz', 'Linus', '1-421-615-0993', 'eu.nibh.vulputate@aol.couk', 3),
(10, 'Saunders', 'Stephen', '1-131-631-0482', 'erat.semper.rutrum@icloud.ca', 1),
(26, 'Dupont', 'Louis', '+33364363634', 'louis.dupont@gmail.com', 2);

-- --------------------------------------------------------

--
-- Table structure for table `responsable`
--

CREATE TABLE `responsable` (
  `login` varchar(64) NOT NULL,
  `pwd` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('admin', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8');

-- --------------------------------------------------------

--
-- Table structure for table `service`
--

CREATE TABLE `service` (
  `idservice` int(11) NOT NULL,
  `nom` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `absence`
--
ALTER TABLE `absence`
  ADD PRIMARY KEY (`idpersonnel`,`datedebut`),
  ADD KEY `idmotif` (`idmotif`);

--
-- Indexes for table `motif`
--
ALTER TABLE `motif`
  ADD PRIMARY KEY (`idmotif`);

--
-- Indexes for table `personnel`
--
ALTER TABLE `personnel`
  ADD PRIMARY KEY (`idpersonnel`),
  ADD KEY `idservice` (`idservice`);

--
-- Indexes for table `service`
--
ALTER TABLE `service`
  ADD PRIMARY KEY (`idservice`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `personnel`
--
ALTER TABLE `personnel`
  MODIFY `idpersonnel` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `absence`
--
ALTER TABLE `absence`
  ADD CONSTRAINT `absence_ibfk_1` FOREIGN KEY (`idpersonnel`) REFERENCES `personnel` (`idpersonnel`),
  ADD CONSTRAINT `absence_ibfk_2` FOREIGN KEY (`idmotif`) REFERENCES `motif` (`idmotif`);

--
-- Constraints for table `personnel`
--
ALTER TABLE `personnel`
  ADD CONSTRAINT `personnel_ibfk_1` FOREIGN KEY (`idservice`) REFERENCES `service` (`idservice`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
