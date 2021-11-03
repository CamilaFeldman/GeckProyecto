<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Editable.aspx.cs" Inherits="LoginPage.Editable.Editable" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="content-wrapper">
          <div class="content">
    <style type="text/css">
    .gvclass table th {text-align:center;}
    </style>

    <asp:Label ID="categorias" runat="server" Text="Catergorias"></asp:Label>
    <br />

  <div class="gvclass">
      <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" HorizontalAlign="Center" CellPadding="4" ForeColor="#333333" GridLines="None" Height="116px" Width="250px" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
          <AlternatingRowStyle BackColor="White" />
          <Columns>
              <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
              <asp:ButtonField ButtonType="Button" Text="Select" CommandName="Select" />
          </Columns>
          <EditRowStyle BackColor="#7C6F57" />
          <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
          <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" Font-Size="Large" />
          <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
          <RowStyle BackColor="#E3EAEB" Font-Size="Medium" HorizontalAlign="Center" />
          <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
          <SortedAscendingCellStyle BackColor="#F8FAFA" />
          <SortedAscendingHeaderStyle BackColor="#246B61" />
          <SortedDescendingCellStyle BackColor="#D4DFE1" />
          <SortedDescendingHeaderStyle BackColor="#15524A" />
      </asp:GridView>
      <br />
    </div>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Nueva categoría"></asp:Label>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
    <br />
    <asp:TextBox ID="NuevaCategoria" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="AgregarCategoria" runat="server" Text="Agregar" OnClick="AgregarCategoria_Click" />
    <br />
    <asp:Button ID="EliminarCategoria" runat="server" Text="Eliminar" OnClick="EliminarCategoria_Click" />
    <br />

    <br />

    <asp:Label ID="sucursales" runat="server" Text="Sucursales"></asp:Label>
    <div class="gvclass">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="60px" Width="361px" HorizontalAlign="Center" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
            <asp:BoundField DataField="direccion" HeaderText="direccion" SortExpression="direccion" />
            <asp:ButtonField ButtonType="Button" CommandName="Select" Text="Select" />
        </Columns>
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" Font-Size="25px" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
    </div>
    <asp:Label ID="Completar" runat="server" Text="Completar espacios vacíos" Visible="false"></asp:Label>
    <br />
    <asp:Label ID="nuevaSucursal" runat="server" Text="Nueva Sucursal"></asp:Label>
    <br />
    <asp:Label ID="nombreSucursal" runat="server" Text="Nombre de la sucursal"></asp:Label>
    <asp:TextBox ID="nombreSucursalTxt" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="direccionSucursal" runat="server" Text="Direccion de la sucursal"></asp:Label>
    <asp:TextBox ID="direccionSucursalTxt" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="agregar" runat="server" Text="Agregar" OnClick="agregar_Click" />

    <br />
    <asp:Button ID="eliminar" runat="server" Text="Eliminar" OnClick="eliminar_Click" />

              </div></div>
</asp:Content>
