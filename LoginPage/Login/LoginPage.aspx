﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="LoginPage.Login.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
    <link rel="stylesheet" href="~\Bootstrap\BootstrapLogin.css" type="text/css" media="screen"/>
</head>
<body>       
        </>
         <img src="/Imagenes/Vector4.png" class="Vector-4"/> 
             <h2 class="formulario-titulo">Login</h2>
             <div class="rectangulo-google">
                 <p class="texto-google">o ingresar con google</p>
             </div> 
              
              
             <form id="form1" runat="server">
                    <h3 class="formulario-mail">Ingresar email</h3>
                    <div class="formulario-barra"><asp:TextBox ID="TextBox1" runat="server" class="completar-email" AutoCompleteType="None"></asp:TextBox></div>
                    <h3 class="formulario-contraseña">Contraseña:</h3>
                    <div class="formulario-barra2"><asp:TextBox ID="TextBox2" type="password" runat="server" class="completar-email"></asp:TextBox></div>
                    <asp:Label ID="Label1" runat="server" Text="Usuario no encontrado" Visible="false" class="noExisteCuenta"></asp:Label>
                    <asp:Label ID="Label2" runat="server" Text="Completar espacios vacios" Visible="false" class="noExisteCuenta"></asp:Label>
                    <asp:Button ID="Button1" runat="server" Text="" class="login-rectangulo" OnClick="Button1_Click"/>
                    <p class="recordar-contraseña">¿No recuerda su contraseña?</p>
                    <p class="no-registrado">¿Aún no está registrado?</p>
                    <a href="/Login/RegisterPage.aspx" class="registrarse">Registrarse</a>
             </form>

      

</body>
</html>
