<?php
namespace App;

require_once("DataSender.php");

if (isset($_GET["email"], $_GET["username"], $_GET["password"], $_GET["confirmPassword"]) && filter_var($_GET["email"], FILTER_VALIDATE_EMAIL))
{
    $username = $_GET["username"];
    $email = $_GET["email"];
    $password = $_GET["password"];
    $confirmPassword = $_GET["confirmPassword"];
    $validator = new DataValidator();
    $sender = new DataSender($username, $email, $password, $confirmPassword);
    $message = $sender->Send();
}
else
{
    $message = "Something went wrong, please try again.";
}
header("location: ../public/test.php?message=$message");