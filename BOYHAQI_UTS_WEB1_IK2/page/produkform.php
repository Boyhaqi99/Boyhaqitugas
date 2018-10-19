<h1><b>INPUT DATA BARANG</b></h1>
<?php	

	    
		
		$id = "";
		$Nama_produk="";
		$Kategori_id="";
		$harga="";
		$action ="proses/produk_add.php";
		if(isset($_GET['id'])) {
			$id = $_GET['id'];
		include"Koneksi.php";
		$query = "select * from produk where Kode_produk ='".$id."'";
		$row = mysql_query($query);
		$res = mysql_fetch_array($row);
		$Nama_produk = $res['Nama_produk'];
		$Kategori= $res['Kategori_id'];
		$harga= $res['harga'];
		$action ="proses/produk_update.php";
		
		}

?>

<form class="from-horizontal" method= "POST" action="<?php echo $action; ?>" enctype="multipart/form-data">
<input type="hidden" value="<?php echo $id; ?>" name="id">
  <div class="form-group">
    <label class="control-label col-sm-4">Nama Produk :</label>
    <div class="col-sm-10">
    <input type="text" class="form-control" value="<?php echo $Nama_produk; ?>" placeholder="Nama Produk" name="Nama_produk" >
  </div>
  </div>
  
  <div class="form-group">
   <label class="control-label col-sm-2">Kategori :</label>
	<div class="col-sm-10">
	<select name="Kategori_id" class="form-control">
			<?php
			include"Koneksi.php";
			$query = "select * from kategori";
			$hasil = mysql_query($query);
			while ($qtabel = mysql_fetch_assoc($hasil))
			{
				echo '<option value="'.$qtabel['Kategori_id'].'">'.$qtabel['Kategori_desc'].'</option>';				
			}
			?>
		</select>
  </div>
   </div> 
  
  <div class="form-group">
   <label class="control-label col-sm-2">Harga :</label>
    <div class="col-sm-10">
    <input type="text" class="form-control" value="<?php echo $harga; ?>"  placeholder="harga" name="harga">
  </div>
   </div>
  
    <div class="form-group">
   <label class="control-label col-sm-2">Gambar :</label>
    <div class="col-sm-10">
    <input type="file" class="form-control" name="Foto_produk">
  </div>
   </div>
   
  
   <button type="submit" class="btn btn-primary">Simpan</button>
   <button type="reset" class="btn btn-danger">Batal</button>
</form>