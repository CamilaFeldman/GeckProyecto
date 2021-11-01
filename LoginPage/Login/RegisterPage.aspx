<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="LoginPage.Login.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="~/Bootstrap\BootstrapLogin.css" type="text/css" media="screen"/>
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
    <body class="hold-transition register-page">
    <form id="form1" runat="server">
<div class="register-box">
  <div class="card card-outline card-primary">
    <div class="card-header text-center">
      <asp:Label ID="RegistrarseLbl" runat="server" Text="Register" Font-Bold="true" Font-Size="Large"></asp:Label>
    </div>
    <div class="card-body">
        <div class="input-group mb-3">
        <asp:TextBox ID="TextBox1" runat="server" type="email" class="form-control" placeholder="Email"></asp:TextBox>
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-envelope"></span>
            </div>
          </div>           
        </div>
        <div class="input-group mb-3">
        <asp:TextBox ID="TextBox2" runat="server" class="form-control" placeholder="Nombre"></asp:TextBox>
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-user"></span>
            </div>
          </div>
        </div>
        <div class="input-group mb-3">
        <asp:TextBox ID="TextBox3" runat="server" type="password" class="form-control" placeholder="Password"></asp:TextBox>
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-lock"></span>
            </div>
          </div>
        </div>
        <div class="input-group mb-3">
        <asp:TextBox ID="TextBox4" runat="server" type="password" class="form-control" placeholder="Retype password"></asp:TextBox>
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-lock"></span>
            </div>
          </div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Este mail ya existe" Visible="false" class="errorRegistro"></asp:Label>
        <asp:Label ID="Label2" runat="server" Text="Hay espacios vacios" Visible="false" class="errorRegistro"></asp:Label>
        <asp:Label ID="Label3" runat="server" Text="Las contraseñas no coinciden" Visible="false" class="errorRegistro"></asp:Label>
        <asp:Label ID="Label4" runat="server" Text="La contraseña debe tener entre 8 y 20 caracteres" Visible="false" class="errorRegistro"></asp:Label>
        <asp:Label ID="Label5" runat="server" Text="Se ingresó correctamente" Visible="false" class="correctoRegistro"></asp:Label>    
          <!-- /.col -->
          <div class="col-4">
          <asp:Button ID="Button2" text="Register" runat="server" type="submit" class="btn btn-primary btn-block" OnClick="Button2_Click1"/>
          </div>
          <!-- /.col -->
        </div>
     

      <a href="LoginPage.aspx" class="text-center">Log In</a>
    </div>
    <!-- /.form-box -->
  </div><!-- /.card -->
</div>
<!-- /.register-box -->

<!-- jQuery -->
<script src="../../plugins/jquery/jquery.min.js"></script>
<!-- Bootstrap 4 -->
<script src="../../plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
<!-- AdminLTE App -->
<script src="../../dist/js/adminlte.min.js"></script>
</form>
</body>
</html>

