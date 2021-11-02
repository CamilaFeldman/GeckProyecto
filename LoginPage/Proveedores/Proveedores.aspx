<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Proveedores.aspx.cs" Inherits="LoginPage.Proveedores.Proveedores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="content-wrapper">
    <div class="content">
    <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
    <asp:TextBox ID="Nombre" runat="server"></asp:TextBox>
    <asp:Label ID="Label2" runat="server" Text="Dirección"></asp:Label>
    <asp:TextBox ID="Direccion" runat="server"></asp:TextBox>
    <asp:Label ID="Label3" runat="server" Text="Telefono"></asp:Label>
    <asp:TextBox ID="Telefono" runat="server"></asp:TextBox>
    <asp:Label ID="Label4" runat="server" Text="Email"></asp:Label>
    <asp:TextBox ID="Email" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Agregar" OnClick="Button1_Click" />
    <asp:Label ID="EspaciosVacios" runat="server" Text="Completar espacios vacíos" Visible="false"></asp:Label>
    <asp:Label ID="MailProveedor" runat="server" Text="Ya existe un proveedor con este mail" Visible ="false"></asp:Label>
        </div></div>
</asp:Content>
