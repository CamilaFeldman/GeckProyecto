<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResumenCaja.aspx.cs" Inherits="LoginPage.Movimientos.ResumenCaja" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="InicioCaja" runat="server" Text="El monto al inicio de caja era de:"></asp:Label>
            <asp:TextBox ID="InicioCajaTxt" runat="server" ReadOnly="True" Width="64px"></asp:TextBox>
            <br />
            <asp:Label ID="CierreCaja" runat="server" Text="El monto al final de caja era de:"></asp:Label>
            <asp:TextBox ID="CierreCajaTxt" runat="server" ReadOnly="True" Width="63px"></asp:TextBox>
            <br />
            <asp:Label ID="Ingreso" runat="server" Text="El ingreso de caja es de:"></asp:Label>
            <asp:TextBox ID="IngresoTxt" runat="server" ReadOnly="True" Width="74px"></asp:TextBox>
            <br />
            <asp:Button ID="ContinuarBtn" runat="server" Text="Continuar" OnClick="ContinuarBtn_Click" Width="119px" />
        </div>
    </form>
</body>
</html>
