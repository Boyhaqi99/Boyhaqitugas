-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versi server:                 10.1.21-MariaDB - mariadb.org binary distribution
-- OS Server:                    Win32
-- HeidiSQL Versi:               9.4.0.5125
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Membuang struktur basisdata untuk dbproduk
CREATE DATABASE IF NOT EXISTS `dbproduk` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `dbproduk`;

-- membuang struktur untuk table dbproduk.kategori
CREATE TABLE IF NOT EXISTS `kategori` (
  `Kategori_id` varchar(50) NOT NULL,
  `Kategori_desc` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Kategori_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Membuang data untuk tabel dbproduk.kategori: ~2 rows (lebih kurang)
/*!40000 ALTER TABLE `kategori` DISABLE KEYS */;
INSERT INTO `kategori` (`Kategori_id`, `Kategori_desc`) VALUES
	('K001', 'Makanan'),
	('K002', 'Minuman'),
	('K003', 'Jajanan Ringan');
/*!40000 ALTER TABLE `kategori` ENABLE KEYS */;

-- membuang struktur untuk table dbproduk.produk
CREATE TABLE IF NOT EXISTS `produk` (
  `Kode_produk` varchar(20) NOT NULL,
  `Nama_produk` varchar(50) DEFAULT NULL,
  `Kategori_id` varchar(15) DEFAULT NULL,
  `harga` int(11) DEFAULT NULL,
  `Foto_produk` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`Kode_produk`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Membuang data untuk tabel dbproduk.produk: ~0 rows (lebih kurang)
/*!40000 ALTER TABLE `produk` DISABLE KEYS */;
/*!40000 ALTER TABLE `produk` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
