<?php

require_once("config.php");

$name = $_GET['nom_materia'];
$sql ="INSERT INTO materias(name) VALUES ('".$name."')";

$result = mysqli_query($conn,$sql);

if(!$result){
    die("Error en la query".mysqli_error($conn));
}
echo $_GET['otro'];
?>