<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="LoginPage.Login.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="~/Bootstrap\BootstrapLogin.css" type="text/css" media="screen"/>
</head>
<body>
    <img src="/Imagenes/Vector4.png" class="Vector-4"/>
    <h2 class="formulario-titulo">Registro</h2>
    <div class="rectangulo-google">
    <p class="texto-google">o ingresar con google</p>
    </div> 
    <form id="form1" runat="server">
        <h3 class="formulario-mail-register">Ingresar email</h3>
        <div class="formulario-barra-register"><asp:TextBox ID="TextBox1" runat="server" class="completar-email"></asp:TextBox></div>
        <h3 class="formulario-repetirUsuario-register">Nombre de usuario</h3>
        <div class="formulario-barra2-register"><asp:TextBox ID="TextBox2" runat="server" class="completar-email"></asp:TextBox></div>
        <h3 class="formulario-contraseña-register">Contraseña:</h3>
        <div class="formulario-barra3-register"><asp:TextBox ID="TextBox3" runat="server" type="password" class="completar-email"></asp:TextBox></div>
        <h3 class="formulario-repetirContraseña-register">Repetir contraseña:</h3>
        <div class="formulario-barra4-register"><asp:TextBox ID="TextBox4" runat="server" type="password" class="completar-email"></asp:TextBox></div>
        <asp:Label ID="Label1" runat="server" Text="Este mail ya existe" Visible="false" class="errorRegistro"></asp:Label>
        <asp:Label ID="Label2" runat="server" Text="Hay espacios vacios" Visible="false" class="errorRegistro"></asp:Label>
        <asp:Label ID="Label3" runat="server" Text="Las contraseñas no coinciden" Visible="false" class="errorRegistro"></asp:Label>
        <asp:Label ID="Label4" runat="server" Text="La contraseña debe tener entre 8 y 20 caracteres" Visible="false" class="errorRegistro"></asp:Label>
        <asp:Button ID="Button2" runat="server" class="login-rectangulo-register" OnClick="Button2_Click1"/>
        <p class="ya-registrado">¿Ya está registrado?</p>
        <a href="/Login/LoginPage.aspx" class="loguearse">Login</a>
    </form>
</body>
</html>
