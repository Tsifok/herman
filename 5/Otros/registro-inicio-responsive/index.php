<!DOCTYPE html>
<html>
<head>
    <link rel="stylesheet" href="css/centrar.css">
</head>
<body>

<div id="container">
    <form action="/action_page.php">
        <label for="f-uname">Username</label><br>
        <input type="text" id="f-uname" name="f-uname" placeholder="Username"><br>
        <div id="m-uname">Mensaje error</div>

        <label for="f-email">Email</label><br>
        <input type="email" id="f-email" name="f-email" placeholder="Email"><br>
        <div id="m-email">Mensaje error</div>

        <label for="f-pass1">Password</label><br>        
        <input type="password" id="f-pass1" name="f-pass1" placeholder="Password"><br>
        
        <label for="f-pass2">Confirm password</label><br>
        <input type="password" id="f-pass2" name="f-pass2" placeholder="Password"><br><br>

        <input type="submit" value="Submit">
    </form> 
</div>

<script src="js/jQuery.js"></script>
<script src="js/validation.js"></script>
</body>
</html>

