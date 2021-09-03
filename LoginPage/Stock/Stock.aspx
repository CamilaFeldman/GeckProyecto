<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Stock.aspx.cs" Inherits="LoginPage.Stock.Stock" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css">
    .gvclass table th {text-align:center;}
    </style>


    <br />
    <asp:TextBox ID="Filtrado" runat="server"></asp:TextBox>
    <asp:Button ID="Buscar" runat="server" Text="Buscar" OnClick="Buscar_Click" />
    <br />
    <br />
    <p>Ordenar por:</p>
    <asp:DropDownList ID="DropDownList1" runat="server" Height="26px" Width="126px"></asp:DropDownList>
    <asp:Button ID="Button1" runat="server" Text="Ordenar" OnClick="Button1_Click" />
    <br />
    <br />
    <div class="gvclass">
    <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Height="181px" Width="1013px" HorizontalAlign="Center" AutoGenerateColumns="False">
        <AlternatingRowStyle BackColor="#DCDCDC" />
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Select" Text="Select" >
            <ItemStyle Width="20px" />
            </asp:ButtonField>
            <asp:BoundField DataField="Producto" HeaderText="Producto" />
            <asp:BoundField DataField="Stock" HeaderText="Stock" />
            <asp:BoundField DataField="Categoria" HeaderText="Categoria" />
            <asp:BoundField DataField="Proveedor" HeaderText="Proveedor" />
            <asp:BoundField DataField="Precio" HeaderText="Precio" />
        </Columns>
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" Wrap="True" Font-Underline="True" />
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
    <asp:Button ID="Editar" runat="server" Text="Editar" OnClick="Editar_Click" />
    <br />
</asp:Content>
