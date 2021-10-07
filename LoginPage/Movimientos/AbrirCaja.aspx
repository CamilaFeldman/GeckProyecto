<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AbrirCaja.aspx.cs" Inherits="LoginPage.Movimientos.AbrirCaja" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="IngresarMonto" runat="server" Text="Ingresar monto de caja al inicio del turno"></asp:Label>
            <br /><br />
            <asp:TextBox ID="IngresarMontoTxt" runat="server" Width="238px"></asp:TextBox>
            <br /><br />
            <asp:Button ID="IngresarMontoBtn" runat="server" Text="Aceptar" OnClick="IngresarMontoBtn_Click" Width="100px" />
        </div>
    </form>
</body>
</html>
