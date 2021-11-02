<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CambiarContra.aspx.cs" Inherits="LoginPage.PasswordRecovery.CambiarContra" %>
 <!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <title>Recover Password</title>

  <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700&display=fallback">
  <!-- Font Awesome -->
  <link rel="stylesheet" href="/AdminLTE-3.1.0/plugins/fontawesome-free/css/all.min.css"/>
  <!-- icheck bootstrap -->
  <link rel="stylesheet" href="/AdminLTE-3.1.0/plugins/icheck-bootstrap/icheck-bootstrap.min.css"/>
  <!-- Theme style -->
  <link href="/AdminLTE-3.1.0/plugins/fontawesome-free/css/all.min.css" rel="stylesheet" />
  <!-- Theme style -->
   <link href="/AdminLTE-3.1.0/dist/css/adminlte.min.css" rel="stylesheet" />
</head>
<form runat="server">
<body class="hold-transition login-page">
<div class="login-box">
  <div class="card card-outline card-primary">
    <div class="card-body">
      <p class="login-box-msg">Estás a un solo paso de recuperar tu contraseña</p><br />
        <asp:Label ID="Label1" runat="server" class="formulario-mail"/><br />
        <div class="input-group mb-3">
            <asp:TextBox ID="txtCode" runat="server" Width = "250" Autocomplete="off" class="form-control"/><br />
            <asp:Button ID="Accept" Text="Aceptar" runat="server" OnClick="AcceptButton" />
            <asp:Label ID="Label2" runat="server" class="texto-google"/>
            <br />
          <asp:Label ID="Repeat" runat="server" class="texto-google"/>          
        </div>
        <div class="input-group mb-3">
            <h1 ID="NuevaPass" runat="server" class="formulario-mail" Visible="false">Ingresar nueva contraseña</h1>
            <asp:TextBox ID="txtPass" runat="server" type="password" Width = "250" Visible="false" AutoComplete="off"/>
             <asp:Button ID="SendAgain" Text="Enviar nuevamente" runat="server" class="btn btn-primary btn-block" OnClick="SendAgain_Click"/>
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
        </div>
        <div class="row">       
          <!-- /.col -->
        </div>
      <p class="mt-3 mb-1">
        <a href="../Login/LoginPage.aspx">Login</a>
      </p>
    </div>
    <!-- /.login-card-body -->
  </div>
</div>
<!-- /.login-box -->

<!-- jQuery -->
<script src="../../plugins/jquery/jquery.min.js"></script>
<!-- Bootstrap 4 -->
<script src="../../plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
<!-- AdminLTE App -->
<script src="../../dist/js/adminlte.min.js"></script>
</body>
</form>
</html>
