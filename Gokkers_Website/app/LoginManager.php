<?php
namespace App;

require_once("DataComparer.php");

if (isset($_GET["username"], $_GET["password"]))
{
    $username = $_GET["username"];
    $password = $_GET["password"];

    $dataComaparer = new DataComparer($username, $password);
    $message = $dataComaparer->Compare();
}
else
{
    $message = "Login failed";
}
header("location: ../public/test.php?message=$message");
?>