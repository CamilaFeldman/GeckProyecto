<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Movimientos.aspx.cs" Inherits="LoginPage.Movimientos.Movimientos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="content-wrapper">
          <div class="content">

    <style type="text/css">
    .gvclass table th {text-align:center;}
    </style>
    <div class="gvclass">

<asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Height="258px" Width="720px" HorizontalAlign="Center" AutoGenerateColumns="False">
        <AlternatingRowStyle BackColor="#DCDCDC" />
        <Columns>
            <asp:ButtonField HeaderText="Selec" Text="Botón" ButtonType="Button" />
            <asp:BoundField HeaderText="Nombre" DataField="nombre" />
            <asp:BoundField HeaderText="Cantidad" DataField="cantidad" />
            <asp:BoundField HeaderText="Sucursal" DataField="sucursal" />
            <asp:BoundField HeaderText="Precio unitario" DataField="precio_unitario" />
            <asp:BoundField HeaderText="Fecha" DataField="fecha" />
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
    <asp:Label ID="Precio" runat="server" Text="El precio total es:"></asp:Label>
    <asp:TextBox ID="PrecioTotal" runat="server" ReadOnly="True"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="AbrirCajaBtn" runat="server" Text="Abrir monto de caja" OnClick="AbrirCajaBtn_Click" Width="219px" />
    <br />
    <br />
    <asp:Button ID="CerrarCajaBtn" runat="server" Text="Cerrar monto de caja" OnClick="CerrarCajaBtn_Click" Width="219px" />
    <br />
   </div>
</div>
</asp:Content>

