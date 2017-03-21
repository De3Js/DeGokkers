<?php
namespace App;

require_once("DataComparer.php");


if (isset($_POST["username"], $_POST["password"]))
{
    $username = $_POST["username"];
    $password = $_POST["password"];

    $dataComaparer = new DataComparer($username, $password);
    $message = $dataComaparer->Compare();
}
else
{
    $message = "Login failed";
}
header("location: ../public/index.php?message=$message");
?>