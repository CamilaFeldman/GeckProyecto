<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="LoginPage.Login.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="~\Bootstrap\BootstrapLogin.css" type="text/css" media="screen"/>
</head>
<body>
    <img src="/Imagenes/Vector4.png" class="Vector-4"/>
    <h2 class="formulario-titulo">Registro</h2>
    <div class="rectangulo-google">
    <p class="texto-google">o ingresar con google</p>
    </div> 
    <form>
        <h3 class="formulario-mail-register">Ingresar email</h3>
        <div class="formulario-barra-register"><input id="Text1" type="text" class="completar-email"/></div>
        <h3 class="formulario-repetirUsuario-register">Repetir usuario</h3>
        <div class="formulario-barra2-register"><input id="Text2" type="text" class="completar-email"/></div>
        <h3 class="formulario-contraseña-register">Contraseña:</h3>
        <div class="formulario-barra3-register"><input id="Text3" type="password" class="completar-email"/></div>
        <h3 class="formulario-repetirContraseña-register">Repetir contraseña:</h3>
        <div class="formulario-barra4-register"><input id="Text4" type="password" class="completar-email"/></div>
        <div class="login-texto-register">Registro</div>
        <div class="login-rectangulo-register"></div>
        <p class="ya-registrado">¿Ya está registrado?</p>
        <a href="/Login/LoginPage.aspx" class="loguearse">Login</a>
    </form>
</body>
</html>
