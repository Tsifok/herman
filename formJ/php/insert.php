<?php

require_once "config.php";

if(isset($_POST['rep_why']))
{
    $rep_why = $_POST['rep_why'];
    $description = $_POST['description'];
    $query = "INSERT INTO reports(rep_why,description) VALUES('".$rep_why."','".$description."')";

    $result = mysqli_query($conn,$query);
    if(!$result){
        mysqli_error($conn);
    }




/*
    $select = "SELECT rep_why as name FROM reports WHERE rep_why = '".$rep_why."'";
    $result2 = mysqli_query($conn,$select);
    if(!$result2){
        mysqli_error($conn);
    }
    $row = mysqli_fetch_assoc($result2);
    echo $row['name'];
*/
}

?>