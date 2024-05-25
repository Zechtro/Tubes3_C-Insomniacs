-- SQLite dump for tubes3_stima24

PRAGMA foreign_keys=OFF;

-- Table structure for table `biodata`
DROP TABLE IF EXISTS `biodata`;

CREATE TABLE `biodata` (
  `NIK` TEXT NOT NULL,
  `nama` TEXT DEFAULT NULL,
  `tempat_lahir` TEXT DEFAULT NULL,
  `tanggal_lahir` TEXT DEFAULT NULL,
  `jenis_kelamin` TEXT DEFAULT NULL,
  `golongan_darah` TEXT DEFAULT NULL,
  `alamat` TEXT DEFAULT NULL,
  `agama` TEXT DEFAULT NULL,
  `status_perkawinan` TEXT DEFAULT NULL,
  `pekerjaan` TEXT DEFAULT NULL,
  `kewarganegaraan` TEXT DEFAULT NULL,
  PRIMARY KEY (`NIK`)
);

-- Dumping data for table `biodata`
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

-- Table structure for table `sidik_jari`
DROP TABLE IF EXISTS `sidik_jari`;

CREATE TABLE `sidik_jari` (
  `berkas_citra` TEXT,
  `nama` TEXT DEFAULT NULL
);

-- Dumping data for table `sidik_jari`
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

PRAGMA foreign_keys=ON;
