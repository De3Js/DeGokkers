<?php
namespace App;
session_start();
require_once("DataComparer.php");

if (isset($_POST["username"], $_POST["password"]))
{
    $username = $_POST["username"];
    $password = $_POST["password"];
    $dataComparer = new DataComparer($username, $password);
    $message = $dataComparer->Compare();

    if ($message == "Succesfully logged in.")
    {
        $_SESSION["logged"]=true;
    }
    else
    {
        $_SESSION["logged"]=false;
    }
    $_SESSION["error"]=$message;
}
else
{
    $message = "Login failed";
    $_SESSION["logged"]=false;
    $_SESSION["error"]=$message;
}
header("location: ../public/index.php");
?>