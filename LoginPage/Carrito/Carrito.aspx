<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="LoginPage.Carrito.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <style type="text/css">
    .gvclass table th {text-align:center;}
    </style>
    <br />
    <asp:Label ID="SelecSucursal" runat="server" Text="Seleccionar sucursal"></asp:Label>
    <br />
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True"  DataTextField="nombre" DataValueField="nombre" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="142px"></asp:DropDownList>
    <br />
    <asp:Label ID="SelecProducto" runat="server" Text="Seleccionar producto" Visible="false"></asp:Label>
    <br />
    <asp:DropDownList ID="DropDownList2" Visible="false" runat="server" AutoPostBack="True"  DataTextField="nombre" DataValueField="nombre" Width="201px"></asp:DropDownList>
    <br />
    <br />
    <asp:Button ID="BuscarBtn" runat="server" Text="Agregar al carrito" OnClick="BuscarBtn_Click" Width="136px" />
    <br /><br />
    <div class="gvclass">
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Height="254px" Width="751px" HorizontalAlign="Center" AutoGenerateColumns="False" OnRowDeleting="GridView1_RowDeleting1">
        <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:BoundField DataField="nombre" HeaderText="Producto" />
                <asp:TemplateField HeaderText="Cantidad">
                 <ItemTemplate>
                <asp:TextBox runat="server" ID="txtQuantity" Columns="3" Text="1"></asp:TextBox><br />
                </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="sucursal" HeaderText="Sucursal" />
                <asp:BoundField DataField="precio_unitario" HeaderText="Precio unitario" />
                <asp:BoundField DataField="precio_final" HeaderText="Precio final" />
                <asp:ButtonField ButtonType="Button" CommandName="DELETE" Text="Borrar" />
            </Columns>
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#0000A9" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#000065" />
    </asp:GridView>

    </div>
    <br />
    <asp:Label ID="TextoPrecioTotal" runat="server" Text="Precio total:"></asp:Label>
    <asp:Label ID="PrecioTotal" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <asp:Button ID="Actualizar" runat="server" Text="Actualizar precio" Height="28px" Width="162px" OnClick="Actualizar_Click" />
    <asp:Button ID="FinalizarCompra" runat="server" Text="Finalizar compra" Height="28px" Width="152px" OnClick="FinalizarCompra_Click" />

    <br />
    
    
</asp:Content>
