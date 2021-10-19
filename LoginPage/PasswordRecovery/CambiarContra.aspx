<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CambiarContra.aspx.cs" Inherits="LoginPage.PasswordRecovery.CambiarContra" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" class="formulario-mail"/>
    <br />
    <asp:TextBox ID="txtCode" runat="server" Width = "250" Autocomplete="off"/>
    <br />
    <br />
    <asp:Button ID="Accept" Text="Aceptar" runat="server" OnClick="AcceptButton" />
    <br />
    <asp:Label ID="Label2" runat="server" class="texto-google"/>
    <br />
    <asp:Label ID="Repeat" runat="server" class="texto-google"/>
    <asp:Button ID="SendAgain" Text="Enviar nuevamente" runat="server" OnClick="SendAgain_Click"/>
    <br />
    <br />
    <h1 ID="NuevaPass" runat="server" class="formulario-mail" Visible="false">Ingresar nueva contraseña</h1>
    <br />
    <asp:TextBox ID="txtPass" runat="server" type="password" Width = "250" Visible="false" AutoComplete="off"/>
    <br />
    <br />
    <h1 ID="RepetirPass" runat="server" class ="formulario-mail" Visible="false">Repetir contraseña nueva</h1>
    <br />
    <asp:TextBox ID="txtRepetir" runat="server" type="password" Width = "250" Visible="false" AutoComplete="off"/>
    <br />
    <br />
    <asp:Button ID="End" Text="Finalizar" runat="server" OnClick="EndButton" Visible="false"/>
    <br />
    <asp:Label ID="Label3" runat="server" class="texto-google"/>
</asp:Content>
