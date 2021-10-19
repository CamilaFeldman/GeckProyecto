<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PasswordRecovery.aspx.cs" Inherits="LoginPage.PasswordRecovery.PasswordRecovery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<br />
<br />
<br />
<h1 class="formulario-mail">Ingresar mail a recuperar</h1>
<br />
<asp:TextBox ID="txtEmail" runat="server" Width = "250" />
<br />
<asp:Label ID="lblMessage" runat="server" />
<br />
<asp:Button Text="Send" runat="server" OnClick="SendEmail" />
<br />
<a ID="href" runat="server" href="/Login/RegisterPage.aspx" Visible="false" class="registrarse">¿Aún no está registrado?</a>

</asp:Content>
