<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>TestPage</title>
</head>
<body>
<h1>Register here:</h1>
    <form action="../app/RegisterManager.php">
        <div class="form-group">
            <label for="username">Username: </label>
            <input name="username" type="text" id="username">
            <label for="email">Email: </label>
            <input name="email" id="email">
            <label for="password">Password: </label>
            <input name="password" type="password" id="password">
            <label for="confirmPassword">Confirm password: </label>
            <input name="confirmPassword" type="password" id="confirmPassword">
        </div>
        <input type="submit" value="submit">
    </form>
    <h1>Login:</h1>
    <form action="../app/LoginManager.php">
        <div class="form-group">
            <label for="username">Username: </label>
            <input name="username" type="text" id="username">
            <label for="password">Password: </label>
            <input name="password" type="password" id="password">
        </div>
        <input type="submit" value="submit">
    </form>
</body>
</html>