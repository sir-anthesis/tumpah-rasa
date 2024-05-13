<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TumpahRasa.Pages.TumpahRasa.Login" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <script src="https://kit.fontawesome.com/64d58efce2.js" crossorigin="anonymous"></script>
    <link rel="stylesheet" href="../../App_Themes/LoginTheme/style3.css" />
    <title>Login and register</title>
</head>

<body>
    <div class="container">
        <form runat="server" class="forms-container">
            <div class="signin-signup">
                <div id="form" class="sign-in-form">
                    <h2 class="title">Log in</h2>
                    <div class="input-field">
                        <i class="fas fa-user"></i>
                        <input type="text" placeholder="Username" name="lname" />
                    </div>
                    <div class="input-field">
                        <i class="fas fa-lock"></i>
                        <input type="password" placeholder="Password" name="lpw" />
                    </div>
                    <div style="display: flex; gap: 1rem; justify-content: start; width: 22rem;">
                        <asp:CheckBox ID="checkremember" runat="server" />
                        <asp:Label ID="Label1" runat="server" Text="Remember Me"></asp:Label>
                    </div>
                    <asp:Button ID="Button1" runat="server" Text="Login" CssClass="btn solid" OnClick="BtnLogin" />
                </div>

                <div id="form" class="sign-up-form">
                    <h2 class="title">Register</h2>
                    <div class="input-field">
                        <i class="fas fa-user"></i>
                        <input type="text" placeholder="Username" name="rname" />
                    </div>
                    <div class="input-field">
                        <i class="fas fa-envelope"></i>
                        <input type="email" placeholder="Email" name="remail" />
                    </div>
                    <div class="input-field">
                        <i class="fas fa-lock"></i>
                        <input type="password" placeholder="Password" name="rpw" />
                    </div>
                    <asp:Button ID="Button2" runat="server" Text="Register" CssClass="btn" OnClick="BtnRegister" />
                </div>
            </div>
        </form>

        <div class="panels-container">
            <div class="panel left-panel">
                <div class="content">
                    <h3>New here ?</h3>
                    <p> Welcome to Tumpah Rasa, your digital kitchen of endless culinary inspiration!</p>
                    <button class="btn transparent" id="sign-up-btn">Register</button>
                </div>
                <img src="../../App_Themes/LoginTheme/img/img1.jpg" class="image" alt="" />
            </div>
            <div class="panel right-panel">
                <div class="content">
                    <h3>One of us ?</h3>
                    <p>
                         Welcome to Tumpah Rasa, your digital kitchen of endless culinary inspiration!
                    </p>
                    <button class="btn transparent" id="sign-in-btn">Login</button>
                </div>
                <img src="../../App_Themes/LoginTheme/img/img2.jpg" class="image" alt="" />
            </div>
        </div>
    </div>

    <script src="../../App_Themes/LoginTheme/app.js"></script>
</body>

</html>
