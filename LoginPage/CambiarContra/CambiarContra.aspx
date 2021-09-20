<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CambiarContra.aspx.cs" Inherits="LoginPage.CambiarContra.CambiarContra" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h3 class="formulario-mail">Cambie su contraseña</h3>
        <h3 class="formulario-mail">Ingrese su correo electrónico</h3>        
        <div class="formulario-barra"><asp:TextBox ID="TextBox1" runat="server" class="completar-email" AutoComplete="Off" OnTextChanged="TextBox1_TextChanged"></asp:TextBox></div>
        <asp:Button ID="Button1" runat="server" Text="Mandar mail de confirmación" class="login-rectangulo" OnClick="Button1_Click"/>
        <br />
        <asp:Label ID="Label1" runat="server"/>
    </form>
</body>
</html>
