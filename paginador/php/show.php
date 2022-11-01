<?php 
require_once "setting.php";

$select = "SELECT * FROM mil_registros";
$query_num_rows = mysqli_query($conn,$select);
if(!$query_num_rows){mysqli_error($conn);}

$total_pages = mysqli_num_rows($query_num_rows);
define("MAX_ROW_PAG",   10);

if(isset($_GET['pag'])){
    $pag = $_GET['pag'];
}else{
    $pag = 1;
}
$start = ($pag-1) * MAX_ROW_PAG;

$query_select = "SELECT * FROM mil_registros LIMIT ".$start.",".MAX_ROW_PAG;
$result = mysqli_query($conn,$query_select);
if(!$result){ mysqli_error($conn); }

while($rows = mysqli_fetch_all($result)){
    if(isset($rows)){
        echo "<th>".$rows['id']."</th><td>".$rows['content']."</td>";
    }
    
}













?>