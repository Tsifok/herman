<?php 

$direction = "localhost";
$user = "root";
$password = "";
$name_bd = "escuela";


$conn = mysqli_connect($direction,$user,$password,$name_bd);

if(!$conn){
    die(mysqli_connect_error());
}

$sql_verification = "SELECT name FROM materias WHERE name = '".$_POST['materia']."'";
$sql_verf_result = mysqli_query($conn,$sql_verification);
$raw = (mysqli_fetch_assoc($sql_verf_result));



if(!empty($_POST)){
    if($raw['name'] == $_POST['materia'])
    {
        ?>
        <script>alert("el nombre ya esta en uso");</script>
        <?php
        header("Location: index.php");
    }
    else{
        $sql_consulta = "INSERT INTO materias(name) VALUES ('".$_POST['materia']."')";
        $sql_result = mysqli_query($conn,$sql_consulta);
        
        if(!$sql_result){
            die(mysqli_error($conn));
        }
    }
}

?>