<?php
namespace App;

use mysqli;
include ("databaseConnector.php");


class dataSender
{
    private $username;
    private $email;
    private $password;
    private $dbc;

    public function __construct($username, $email, $password, $confirmPassword)
    {
        $this->dbc = Connect();
        $this->username = $username;
        $this->email = $email;
        $this->password = $password;
        $this->confirmPassword = $confirmPassword;
    }

    public function Send()
    {
        if ($this->password == $this->confirmPassword)
        {
            $sql = "INSERT INTO users (username, email, password)"
                . "VALUES ('$this->username', '$this->email', '$this->password')";
            mysqli_query($this->dbc,$sql);
        }
        header("location:../public/test.php");
    }
}