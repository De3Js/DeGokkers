<?php
namespace App;

require_once("DatabaseConnector.php");
require_once("RegisterValidator.php");

class dataSender
{
    private $username;
    private $email;
    private $password;
    private $dbc;
    private $validator;

    public function __construct($username, $email, $password, $confirmPassword)
    {
        $this->dbc = Connect();
        $this->username = $username;
        $this->email = $email;
        $this->password = $password;
        $this->confirmPassword = $confirmPassword;
        $this->validator = new DataValidator();
    }

    public function Send()
    {
        $errorMessage = $this->validator->Validate($this->email, $this->username, $this->password, $this->confirmPassword, $this->dbc);
        if ($errorMessage == "Succesfully Registered")
        {
            $hashedPassword = password_hash($this->password, PASSWORD_DEFAULT);
        $sql = "INSERT INTO users (username, email, password)"
            . "VALUES ('$this->username', '$this->email', '$hashedPassword')";
        $this->dbc->query($sql);
        }

        return $errorMessage;
    }
}