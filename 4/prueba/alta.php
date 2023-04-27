<?php
// ve que el form no este vacio
if(!empty($_POST['materia'])){
    
    //se conecta al la bd
    $direction = "localhost";
    $user = "root";
    $password = "";
    $name_bd = "escuela";
    $conn = mysqli_connect($direction,$user,$password,$name_bd);
    //verifica la conxion
    if(!$conn){
        die(mysqli_connect_error());
    }

    //consulta para verificar que lo ingresado no este repetido
    $sql_verification = "SELECT * FROM materias WHERE name = '".$_POST['materia']."'";
    $sql_verf_ressult = mysqli_query($conn,$sql_verification);
    $row = mysqli_fetch_assoc($sql_verf_ressult);
    //verifica la consulta anterior 
    if(!$sql_verf_ressult){
        die('error en query'.mysqli_errno($conn));
    }
    //verifica que los valores no sean iguales, sino redirige al form
    if($row['name'] == $_POST['materia']){
        
        header("location: formulario.php?err=1");
    }
    //si los datos no son repetidos se los ingresa a la tabla 
    else{
        $sql_insert = "INSERT INTO materias(name) VALUES ('".$_POST['materia']."')";
        $sql_verf_insert = mysqli_query($conn,$sql_insert);

        if(!$sql_verf_insert){
            die('Problema query Insert'.mysqli_error($conn));
            header("location: formulario.php?err=0");
        }

    }
}
else{
    header("location: formulario.php?err=2");
}




?>