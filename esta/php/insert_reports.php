<?php
    require_once("config.php");
    if(isset($_POST['rep_why'])){
        $rep_why = $_POST['rep_why'];
        $description = $_POST['description'];

        $insert = "INSERT INTO reports(rep_why,description) VALUE('".$rep_why."','".$description."')";
        $query = mysqli_query($conn,$insert);

        if(!$query){
            die("mal la consulta");
        }
    }
?>