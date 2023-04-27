<?php 
require_once "setting.php";

$select = "SELECT * FROM mil_registros";
$query_num_rows = mysqli_query($conn,$select);

if(!$query_num_rows){mysqli_error($conn);}

define("MAX_ROW_PAG",   10);

$total_pages = ceil(mysqli_num_rows($query_num_rows)/MAX_ROW_PAG);

if(isset($_GET['pag'])){
    
    if(isset($_GET['bandera']) && $_GET['bandera'] == "last" ){
        $start = ($total_pages-1) * MAX_ROW_PAG;
    }elseif(isset($_GET['bandera']) && $_GET['bandera'] == "beginning" ){
        $pag = 1;
        $start = ($pag-1) * MAX_ROW_PAG;
    }else{
        $pag = $_GET['pag'];
        $start = ($pag-1) * MAX_ROW_PAG;
    }

}else{
    $pag = 1;
    $start = ($pag-1) * MAX_ROW_PAG;
}


$query_select = "SELECT * FROM mil_registros LIMIT ".$start.",".MAX_ROW_PAG;
$result = mysqli_query($conn,$query_select);
if(!$result){ die("error de consulta"); }

// $a = mysqli_fetch_all($result, MYSQLI_ASSOC);
// foreach($a as $valores){
//     echo "<tr><th>".$valores['id']."</th><td>".$valores['content']."</td></tr>";
// }

foreach($result as $key => $resultado) {
    $mensaje2[] = [
        "id" => $resultado['id'],
        "content" => $resultado['content']
    ];
}
    $mensaje =
    [
        'max_reg' => $total_pages,
        'demas' => $mensaje2,
        'bandera' => isset($_GET['bandera']) ? $_GET['bandera'] : ""
    ];


header("Content-Type: application/json; charset=utf-8");
return print_r(json_encode($mensaje));