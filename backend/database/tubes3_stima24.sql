-- MySQL dump 10.13  Distrib 8.0.36, for Linux (x86_64)
--
-- Host: localhost    Database: tubes3_stima24
-- ------------------------------------------------------
-- Server version	8.0.36-0ubuntu0.22.04.1

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `biodata`
--

DROP TABLE IF EXISTS `biodata`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `biodata` (
  `NIK` varchar(16) NOT NULL,
  `nama` varchar(100) DEFAULT NULL,
  `tempat_lahir` varchar(50) DEFAULT NULL,
  `tanggal_lahir` date DEFAULT NULL,
  `jenis_kelamin` enum('Laki-Laki','Perempuan') DEFAULT NULL,
  `golongan_darah` varchar(5) DEFAULT NULL,
  `alamat` varchar(255) DEFAULT NULL,
  `agama` varchar(50) DEFAULT NULL,
  `status_perkawinan` enum('Belum Menikah','Menikah','Cerai') DEFAULT NULL,
  `pekerjaan` varchar(100) DEFAULT NULL,
  `kewarganegaraan` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`NIK`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `biodata`
--

LOCK TABLES `biodata` WRITE;
/*!40000 ALTER TABLE `biodata` DISABLE KEYS */;
/*!40000 ALTER TABLE `biodata` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sidik_jari`
--

DROP TABLE IF EXISTS `sidik_jari`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sidik_jari` (
  `berkas_citra` text,
  `nama` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sidik_jari`
--

LOCK TABLES `sidik_jari` WRITE;
/*!40000 ALTER TABLE `sidik_jari` DISABLE KEYS */;
/*!40000 ALTER TABLE `sidik_jari` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-05-04 15:57:34

INSERT INTO `biodata` (`NIK`, `nama`, `tempat_lahir`, `tanggal_lahir`, `jenis_kelamin`, `golongan_darah`, `alamat`, `agama`, `status_perkawinan`, `pekerjaan`, `kewarganegaraan`) VALUES
('3201010101010001', '4nD 5nrY', 'Bandung', '1985-01-15', 'Laki-Laki', 'O', 'Jl. Kebon Jeruk No.15, Bandung', 'Islam', 'Menikah', 'Pengusaha', 'Indonesia'),
('3201010101010002', 'rtn 5r', 'Jakarta', '1992-07-24', 'Perempuan', 'A', 'Jl. Mangga Dua Raya No.8, Jakarta', 'Hindu', 'Belum Menikah', 'Desainer', 'Indonesia'),
('3201010101010003', 'ag5 prYG', 'Surabaya', '1990-03-30', 'Laki-Laki', 'B', 'Jl. Pahlawan No.22, Surabaya', 'Kristen', 'Cerai', 'Guru', 'Indonesia'),
('3201010101010004', 'dw1 ksm', 'Yogyakarta', '1988-11-12', 'Perempuan', 'AB', 'Jl. Malioboro No.101, Yogyakarta', 'Budha', 'Menikah', 'Arsitek', 'Indonesia'),
('3201010101010005', 'B4MBnG r5wnt0', 'Semarang', '1991-05-19', 'Laki-Laki', 'O', 'Jl. Setiabudi No.45, Semarang', 'Konghucu', 'Menikah', 'Dokter', 'Indonesia'),
('3201010101010006', 's4r Dw1', 'Bali', '1989-09-09', 'Perempuan', 'B', 'Jl. Uluwatu No.33, Bali', 'Islam', 'Belum Menikah', 'Seniman', 'Indonesia'),
('3201010101010007', 'tony r4hrJ', 'Medan', '1993-02-21', 'Laki-Laki', 'A', 'Jl. Merdeka No.77, Medan', 'Kristen', 'Menikah', 'Insinyur', 'Indonesia'),
('3201010101010008', 'lnd a65tn4', 'Palembang', '1986-08-14', 'Perempuan', 'AB', 'Jl. Rajawali No.5, Palembang', 'Hindu', 'Cerai', 'Pengacara', 'Indonesia'),
('3201010101010009', 'rUdy hrTaNt0', 'Makassar', '1990-12-23', 'Laki-Laki', 'O', 'Jl. Sultan Hasanuddin No.11, Makassar', 'Budha', 'Menikah', 'Konsultan', 'Indonesia'),
('3201010101010010', 'j551c kum4lA', 'Bandar Lampung', '1995-04-04', 'Perempuan', 'A', 'Jl. Diponegoro No.101, Bandar Lampung', 'Konghucu', 'Belum Menikah', 'Akuntan', 'Indonesia');

INSERT INTO `sidik_jari` (`berkas_citra`, `nama`) VALUES
('test/99_M_Left_index_finger.BMP', 'Andi Sunarya'),
('test/99_M_Left_middle_finger.BMP', 'Ratna Sari'),
('test/99_M_Left_ring_finger.BMP', 'Agus Prayogo'),
('test/99_M_Left_thumb_finger.BMP', 'Dewi Kusuma'),
('test/99_M_Right_index_finger.BMP', 'Bambang Riswanto'),
('test/99_M_Right_little_finger.BMP', 'Sari Dewi'),
('test/99_M_Right_middle_finger.BMP', 'Tony Raharja'),
('test/99_M_Right_ring_finger.BMP', 'Linda Agustina'),
('test/99_M_Right_thumb_finger.BMP', 'Rudy Hartanto'),
('test/99_M_Left_little_finger.BMP', 'Jessica Kumala');