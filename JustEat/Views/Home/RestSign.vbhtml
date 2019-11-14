<!DOCTYPE html>
<html>
<style>
body {font-family: Arial, Helvetica, sans-serif;}
* {box-sizing: border-box}
    {align-content:center;
    }

/* Full-width input fields */
input[type=text], input[type=password] {
  width: 50%;
  padding: 15px;
  align-items: center;
  margin: 5px 0 22px 0;
  display: inline-block;
  border: none;
  background: #f1f1f1;
  text-align:center;
  
}

input[type=text]:focus, input[type=password]:focus {
  background-color: #ddd;
  outline: none;
}

hr {
  border: 1px solid #f1f1f1;
  margin-bottom: 25px;
}

/* Set a style for all buttons */
button {
  background-color: #4CAF50;
  color: white;
  padding: 14px 20px;
  margin: 8px 0;
  border: none;
  cursor: pointer;
  width: 100%;
  opacity: 0.9;
}

button:hover {
  opacity:1;
}

/* Extra styles for the cancel button */
.cancelbtn {
  padding: 14px 20px;
  background-color: #f44336;
}

/* Float cancel and signup buttons and add an equal width */
.cancelbtn, .signupbtn {
  float: left;
  width: 50%;
}

/* Add padding to container elements */
.container {
  padding: 16px;
}

/* Clear floats */
.clearfix::after {
  content: "";
  clear: both;
  display: table;
}

</style>
<body >

    <form method="post" style="border:1px solid #ccc" text-align:center>
       
        <div class="container">
            <center>
                <h1>Sign Up</h1>
                <p>Please fill in this form to create an account.</p>
                <p style="position:absolute; left: 800px">Already have an account?   @Html.ActionLink("Sign In", "SignIn", "Restaurant")  </p>
                <hr>

            </center>
            <label for="name"><b>Restaurant Name</b></label> <br>
            <input type="text" placeholder="Enter Name" name="name" required> <br>
            <label for="category"><b>Category</b></label> <br>

            <select style="position: absolute; left: 220px;">
                <option value="thai">Thai</option>
                <option value="chinese">Chinese</option>
                <option value="indian">Indian</option>
                <option value="mexican">Mexican</option>
            </select> <br> <br>

            <label for="email"><b>Email</b></label> <br>
            <input type="text" placeholder="Enter Email" name="email" required> <br>

            <label for="phone"><b>Phone</b></label> <br>
            <input type="text" placeholder="Enter Phone Number" name="phone" required> <br>


            <label for="location"><b>Location</b></label> <br>
            <input type="text" placeholder="Enter Location" name="location" required> <br>

            <label for="psw"><b>Password</b></label> <br>
            <input type="password" placeholder="Enter Password" name="psw" required>  <br>

            <label for="psw-repeat"><b>Repeat Password</b></label> <br>
            <input type="password" placeholder="Repeat Password" name="psw-repeat" required>  <br>

            <label>
                <input type="checkbox" checked="checked" name="remember" style="margin-bottom:15px"> Remember me
            </label>

            <p>By creating an account you agree to our <a href="#" style="color:dodgerblue">Terms & Privacy</a>.</p>

            <div class="clearfix">
                <button type="button" class="cancelbtn">Cancel</button>
                <button type="submit" class="signupbtn">Sign Up</button>
            </div>
        </div>
    </form>

</body>
</html>
