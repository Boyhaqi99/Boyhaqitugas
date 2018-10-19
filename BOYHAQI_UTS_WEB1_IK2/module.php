<?php

if(isset($_GET['mod'])){
	$page = $_GET['mod'];
	
	switch($page) {
		case "produkform":
		include "page/produkform.php";
		break;
		case "list":
		include "page/list.php";
		break;
		case "edit":
		include "page/edit.php";
		break;
	}
	}else{
		echo "module tidak ditemukan";
	}