<?php
session_start();
?>
<!DOCTYPE html>
<html>
  <head>
    <meta charset="utf-8">
    <title>DeGokkers</title>
    <meta name="description" content="">
    <link rel="apple-touch-icon" href="apple-touch-icon.png">
    <link rel="stylesheet" href="Css/normal.css">
  </head>
  <body>
    <nav>
      <div class="wrapper">
          <img src="Images/degokkers_logo.png" alt="gokkerslogo">
          <ul>
            <li><a href="#hero">HOME</a></li>
            <li><a href="#features">FEATURES</a></li>
            <li><a href="#login">LOGIN/REGISTER</a></li>
            <li><a href="#download">DOWNLOAD</a></li>
            <li><a href="#promote">PROMOTE</a></li>
          </ul>
      </div>
    </nav>
    <div class="hero" id="hero">
      <div class="wrapper">
        <div class="slider_images">
          <img class="Slides" src="Images/slide1.JPG" alt="slide1">
          <img class="Slides" src="Images/slide2.JPG" alt="slide1">
        </div>
        <script>
          var myIndex = 0;
          carousel();
          function carousel() {
              var i;
              var x = document.getElementsByClassName("Slides");
              for (i = 0; i < x.length; i++) {
                 x[i].style.display = "none";
              }
              myIndex++;
              if (myIndex > x.length) {myIndex = 1}
              x[myIndex-1].style.display = "block";
              setTimeout(carousel, 5000); // Change image every 5 seconds
          }
        </script>
      </div>
    </div>
    <div class="features" id="features">
      <h2>FEATURES</h2>
      <div class="wrapper">
        <div class="smasher">
          <h3>SMASHER</h3>
          <p>
          smasher is een van de gamemode's die in gokkers game te vinden is. de bedoeling is dat je zo snel mogelijk op een toets druk zodat je vlooi als eerste bij de finish line is om te winnen. het is dus een erg competitive game.
          </p>
        </div>
        <div class="simulator">
          <h3>SIMULATOR</h3>
          <p>
            simulator is een van de gamemode's die in de gokkers game te vinden is. de bedoeling is dat je geld inzet op een van de vlooie waarvan je denk dat die gaat winnen als je vlooi dan ook daadwerkelijk wint wordt je inzet bedrag verdubbelt en terug gegeven
          </p>
        </div>
      </div>
    </div>
    <div class="login" id="login">
      <h2>LOGIN / REGISTER</h2>
      <div class="wrapper">
        <div class="loginfield">
            <?php
            if ( isset($_SESSION["error"]))
            {
                echo "<h2> Error: </h2>";
                echo "<h3>" . $_SESSION["error"] . "</h3>";
                unset($_SESSION["error"]);
            }
            ?>
          <h3>Login</h3>
            <!-- login field -->
          <form class="loginform" id="login" action="../app/LoginManager.php" method="post" accept-charset="UTF-8">
              <label class="formlabel" for="username">Username: </label>
              <input class="forminput" placeholder="Username" name="username" type="text" id="username">
              <label class="formlabel" for="password">Password: </label>
              <input class="forminput" placeholder="Password" name="password" type="password" id="password">
              <input class="formsubmit" type="submit" value="Submit">
          </form>
        </div>
        <div class="registerfield" id="register">
            <?php
            if ( isset($_SESSION["reg_error"]))
            {
                echo "<h2> Errors: </h2>";
                foreach ($_SESSION["reg_error"] as $error)
                {
                    echo "<h3>" . $error . "</h3>";
                }
                unset($_SESSION["reg_error"]);
            }
            ?>
          <h3>Register</h3>
            <!-- register field -->
          <form class="registerform" <id="register" action="../app/RegisterManager.php" method="post" enctype="multipart/form-data" autocomplete="off">
            <!-- register label username -->
            <label class="formlabel" for="Username">Username*:</label>
            <!-- register input username -->
            <input class="forminput" type="text" placeholder="Username" name="username"  maxlength="50" required id="username" />
            <!-- register label password -->
            <label class="formlabel" for="password">Password*:</label>
            <!-- register input password -->
            <input class="forminput" type="password" placeholder="Password" name="password" maxlength="50" id="password"/>
            <!-- register label password confirmd -->
            <label class="formlabel" for="confirmPassword">Confirm Password*:</label>
            <!-- register input password confirm -->
            <input class="forminput" type="password" name="confirmPassword" placeholder="Confirm Password" id="confirmPassword" maxlength="50">
            <!-- register label email -->
            <label class="formlabel" for="email">Email*:</label>
            <!-- register input email -->
            <input class="forminput" type="email" placeholder="Email" name="email" maxlength="50" id="email"/>
            <!-- register summit -->
            <input class="formsubmit" type="submit" value="Submit">
          </form>
        </div>
      </div>
    </div>
    <div class="promote"id="promote">
      <h2>PROMOTION</h2>
      <div class="wrapper">
        <div class="videoplayer">
          <h3>PROMOTIE VIDEO</h3>
          <iframe src="https://www.youtube.com/embed/mPo4W-35-js"></iframe>
        </div>
      </div>
    </div>

    <div class="download">
        <h2>DOWNLOAD</h2>
        <div class="wrapper">
            <div class="download_content">
                <?php
                if (isset($_SESSION["logged"]))
                {
                    if ($_SESSION["logged"] == true) {
                        echo "<a href=\"game\" download> download</a>";
                    }
                    else
                    {
                        echo "<p> You must be logged in to download.</p>";
                    }
                }
                else
                {
                    echo "<p> You must be logged in to download.</p>";
                }
                ?>
            </div>
        </div>
    </div>
    <footer>
      <div class="wrapper">
        <div class="footer_content">
            <ul>
              <li>Jean Pierre Slimmen</li>
              <li>Joost Lont</li>
              <li>Joey Oonincx</li>
            </ul>
            <img src="Images/degokkers_logo.png" alt="gokkers-logo">
            <ul>
              <li>jpslimmen@gmail.com</li>
              <li>Joost.lont@xs4all.nl</li>
              <li>Joeyoonincx@hotmail.com</li>
            </ul>
        </div>
      </div>
    </footer>
  </body>
</html>
