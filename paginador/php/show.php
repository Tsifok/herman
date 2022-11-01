<?php 
require_once "setting.php";

$select = "SELECT * FROM mil_registros";
$query_num_rows = mysqli_query($conn,$select);
if(!$query_num_rows){mysqli_error($conn);}
define("MAX_ROW_PAG",   10);
$total_pages = ceil(mysqli_num_rows($query_num_rows)/MAX_ROW_PAG);

if(isset($_GET['pag'])){
    $pag = $_GET['pag'];
}else{
    $pag = 1;
}
$start = ($pag-1) * MAX_ROW_PAG;

$query_select = "SELECT * FROM mil_registros LIMIT ".$start.",".MAX_ROW_PAG;
$result = mysqli_query($conn,$query_select);
if(!$result){ mysqli_error($conn); }

$a = mysqli_fetch_all($result, MYSQLI_ASSOC);
foreach($a as $valores){
    echo "<tr><th>".$valores['id']."</th><td>".$valores['content']."</td></tr>";
}


