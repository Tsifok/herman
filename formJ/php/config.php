<?php
$direction = "localhost";
$user = "root";
$password = "";
$name_bd = "escuela";

$conn = mysqli_connect($direction,$user,$password,$name_bd);
if(!$conn){
    die('Fatal error to connect bd'.mysqli_connect_error());
}

?>