<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="LoginPage.Login.LoginPage" %>

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
              
              
             <form>
                    
                    <h3 class="formulario-mail">Ingresar email</h3>
                    <div class="formulario-barra"><input id="Text1" type="text" class="completar-email"/></div>
                    <h3 class="formulario-contraseña">Contraseña:</h3>
                    <div class="formulario-barra2"><input id="Text2" type="password" class="completar-email"/></div>
                    <a href="/PagHome/PagHome.aspx" class="login-rectangulo"></a>
                    <a href="/PagHome/PagHome.aspx" class="login-texto">Login</a>
                    <p class="recordar-contraseña">¿No recuerda su contraseña?</p>
                    <p class="no-registrado">¿Aún no está registrado?</p>
                    <a href="/Login/RegisterPage.aspx" class="registrarse">Registrarse</a>
                    
                 
             </form>

      

</body>
</html>
