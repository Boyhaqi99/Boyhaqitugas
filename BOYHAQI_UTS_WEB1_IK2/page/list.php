<?php include "proses/koneksi.php"; ?>
<table class= "table table-bordered">
	<thead>
	<tr>
	<th>No</th>
	<th>Gambar</th>
	<th>Nama Produk</th>
	<th>Kategori</th>
	<th>Harga</th>
	<th>Aksi</th>


<?php
$querys = "SELECT * FROM produk";
$res   = mysql_query($querys);
$no =1;
while($row=mysql_fetch_array($res)){
	?>
	<tr>
	<td><?php echo $no; ?></td>
	<td><img src="<?php echo $row['Foto_produk']; ?>" width="80"></td>
	<td><?php echo $row['Nama_produk']; ?></td>
	<td><?php echo $row['Kategori_id']; ?></td>
	<td><?php echo $row['harga']; ?></td>
	<td>
		<a href = "index.php?mod=edit&id=<?php echo $row['Kode_produk']; ?>"> Edit </a> |
		<a onClick="return confirm('Anda Yakin Akan Menghapus Data ini?');" href = "proses/delete.php?id=<?php echo $row['Kode_produk']; ?>"> Delete </a>
		</td>
	</tr>

<?php $no++;} ?>

</tbody>