<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="LoginPage.Productos.Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
    <asp:TextBox ID="Nombre" runat="server" AutoComplete="Off"></asp:TextBox>
    <asp:Label ID="Label2" runat="server" Text="Precio"></asp:Label>
    <asp:TextBox ID="Precio" runat="server" AutoComplete="Off"></asp:TextBox>
    <asp:Label ID="Label3" runat="server" Text="Categoria"></asp:Label>
    <asp:DropDownList ID="Marcas" runat="server" Height="37px" Width="160px" AutoPostBack="True"  DataTextField="nombre" DataValueField="nombre"></asp:DropDownList>
    <asp:Label ID="Label4" runat="server" Text="Stock"></asp:Label>
    <asp:TextBox ID="Stock" runat="server" AutoComplete="Off"></asp:TextBox>
    <asp:Label ID="Label5" runat="server" Text="Proveedor"></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True"  DataTextField="nombre" DataValueField="nombre" Height="36px" Width="168px"></asp:DropDownList>
    <asp:Label ID="Label6" runat="server" Text="Cantidad mínima"></asp:Label>
    <asp:TextBox ID="CantidadMinima" runat="server" AutoComplete="Off"></asp:TextBox>
    <asp:Label ID="Label7" runat="server" Text="Cantidad máxima"></asp:Label>
    <asp:TextBox ID="CantidadMaxima" runat="server" AutoComplete="Off"></asp:TextBox>
    <asp:Label ID="Label8" runat="server" Text="Presentación comercial"></asp:Label>
    <asp:TextBox ID="PresentacionComercial" runat="server"></asp:TextBox>
    <asp:Label ID="Label9" runat="server" Text="Sucursal"></asp:Label>
    <asp:DropDownList ID="Sucursal" runat="server" Height="37px" Width="160px" AutoPostBack="True"  DataTextField="nombre" DataValueField="nombre"></asp:DropDownList>
    <asp:Button ID="Button1" runat="server" Text="Agregar" OnClick="Button1_Click" />
    <asp:Button ID="Eliminar" runat="server" Text="Eliminar" OnClick="Eliminar_Click" />
    <asp:Label ID="EspaciosVacios" runat="server" Text="Completar espacios vacíos" Visible="false"></asp:Label>
    <asp:Label ID="IngresoIncorrecto" runat="server" Text="Algun campo mal ingresado" Visible="false"></asp:Label>
    <asp:Label ID="CantidadRequerida" runat="server" Text="La cantidad mínima es mayor a la máxima" Visible ="false"></asp:Label>

</asp:Content>
