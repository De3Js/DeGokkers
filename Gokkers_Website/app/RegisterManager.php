<?php
namespace App;
require_once("DataSender.php");

session_start();

if (isset($_POST["email"], $_POST["username"], $_POST["password"], $_POST["confirmPassword"]) && filter_var($_POST["email"], FILTER_VALIDATE_EMAIL))
{
    $username = $_POST["username"];
    $email = $_POST["email"];
    $password = $_POST["password"];
    $confirmPassword = $_POST["confirmPassword"];
    $validator = new DataValidator();
    $sender = new DataSender($username, $email, $password, $confirmPassword);
    $message = $sender->Send();
}
else
{
    $message = "Something went wrong, please try again.";
}
header("location: ../public/index.php?message=$message");