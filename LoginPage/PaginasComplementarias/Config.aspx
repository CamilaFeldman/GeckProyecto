<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Config.aspx.cs" Inherits="LoginPage.PaginasComplementarias.Config" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="content-wrapper">
    <div class="content">
    <asp:Label ID="SucursalLbl" runat="server" Text="Seleccionar sucursal predeterminada" ></asp:Label>
    <br />
    <asp:DropDownList ID="SucursalDdl" runat="server" AutoPostBack="True"  DataTextField="nombre" DataValueField="nombre" OnSelectedIndexChanged="SucursalDdl_SelectedIndexChanged"></asp:DropDownList>
    </div></div>

</asp:Content>
