<?php
include"Koneksi.php";

$id = $_POST['id'];
$Nama_produk = $_POST['Nama_produk'];
$Kategori = $_POST['Kategori'];
$harga = $_POST['harga'];

$query = "UPDATE produk SET
		Nama_produk='$Nama_produk',
		Kategori_id=$Kategori,
		harga=$harga
		WHERE Kode_produk='$id'";
		mysql_query($query);
		echo $query;
		
		//header("location:../index.php?mod=list");