<?php

include "Koneksi.php";
$Kode_produk		= getAutoId('Kode_produk', 'produk', 'PRD');
$Nama_produk		= $_POST['Nama_produk'];
$Kategori_id		= $_POST['Kategori_id'];
$harga				= $_POST['harga'];


$namaFile = $_FILES['Foto_produk'] ['name'];
$namasementara = $_FILES['Foto_produk'] ['tmp_name'];
$dirUpload = "../Foto_produk/";

$terupload = move_uploaded_file($namasementara, $dirUpload.$namaFile);

$Foto_produk		= "Foto_produk/".$namaFile;


$query ="INSERT INTO `produk`
			(`Kode_produk`, `Nama_produk`, `Kategori_id`, `harga`, `Foto_produk`)
			VALUES ('$Kode_produk', '$Nama_produk', '$Kategori_id', '$harga', '$Foto_produk')";
			
		
mysql_query ($query);

header ("location:../index.php?mod=produkform");