<?php
session_start();
$_SESSION["message" ] = "";
$mysqli = new mysqli("localhost", "root", "", "accounts");

if($_SERVER["REQUEST_METHOD"] == "POST")
{
    //two passwords are equal to each other
    if($_POST["password"] == $_POST["confirmpassword"])
    {
        $username = $mysqli->real_escape_string($_POST["username"]);
        $email = $mysqli->real_escape_string($_POST["email"]);
        $username = md5($_POST["password"]); //md5 hash password security

        $_SESSION["username"] = $username;
        $sql = "INSERT INTO users (username, email, password) " . "VALUES ('$username', '$email', '$password')";

        if($mysqli->query($sql) == true)
        {
            $_SESSION['message'] = "Regristration succesfull! added $username to the database!";
        }
    }
}

?>
<div class="Register ">
    <h1>Create an account</h1>
    <form class="form" action="form.php" method="post" enctype="multipart/form-data" autocomplete="off">
        <div class="alert alert-error"><?= $_SESSION["message"] ?></div>
        <input type="text" placeholder="User Name" name="username" required />
        <input type="email" placeholder="Email" name="email" required />
        <input type="password" placeholder="Password" name="password" autocomplete="new-password" required />
        <input type="password" placeholder="Confirm Password" name="confirmpassword" autocomplete="new-password" required />
        <input type="submit" value="Register"/>
    </form>
</div>
