<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="LoginPage.Carrito.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <style type="text/css">
    .gvclass table th {text-align:center;}
    </style>
    <br />
    <asp:Label ID="Buscar" runat="server" Text="Buscar"></asp:Label>
    <br />
    <asp:TextBox ID="BuscarTxt" runat="server"></asp:TextBox>
    <asp:Button ID="BuscarBtn" runat="server" Text="Buscar" OnClick="BuscarBtn_Click" />
    <br /><br />
    <div class="gvclass">
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Height="254px" Width="751px" HorizontalAlign="Center" AutoGenerateColumns="False">
        <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:BoundField DataField="nombre" HeaderText="Producto" />
                <asp:BoundField DataField="stock" HeaderText="Cantidad" />
                <asp:BoundField DataField="sucursal" HeaderText="Sucursal" />
                <asp:BoundField DataField="precio" HeaderText="Precio unitario" />
                <asp:BoundField HeaderText="Precio final" />
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
    
</asp:Content>
