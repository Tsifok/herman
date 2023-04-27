<?php 
$host = 'localhost';
$user = 'root';
$password = '';
$table_name = 'escuela';

$conn = mysqli_connect($host, $user, $password, $table_name);

if (!$conn) {
    die('error al conectar la bd' . mysqli_connect_error());
}




?>