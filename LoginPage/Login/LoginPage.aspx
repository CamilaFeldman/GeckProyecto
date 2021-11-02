<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="LoginPage.Login.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
     <!-- Google Font: Source Sans Pro -->
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
    <form id="form1" runat="server">
    <body class="hold-transition login-page">
<div class="login-box">
  <!-- /.login-logo -->
  <div class="card card-outline card-primary">
    <div class="card-header text-center">
     <asp:Label ID="LoginHeader" runat="server" Text="Log In" Font-Bold="true" Font-Size="Large"></asp:Label>
    </div>
    <div class="card-body">
      <form action="../../index3.html" method="post">
        <div class="input-group mb-3">
        <asp:TextBox ID="TextBox1" runat="server" class="form-control" placeholder="Email"></asp:TextBox>
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-envelope"></span>
            </div>
          </div>
        </div>
        <div class="input-group mb-3">
        <asp:TextBox ID="TextBox2" runat="server" type="password" class="form-control" placeholder="Password"></asp:TextBox>
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-lock"></span>
            </div>
          </div>         
        </div>
            <asp:Label ID="Label1" runat="server" Text="No se encontró usuario" Visible="false" ForeColor="Red"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="Completar espacios vacíos" Visible="false" ForeColor="Red"></asp:Label>
        <div class="row">          
          <!-- /.col -->
          <div class="col-4">
            <asp:Button ID="Button1" runat="server" Text="Log in" class="btn btn-primary btn-block" OnClick="Button1_Click"/>
          </div>
          <!-- /.col -->
        </div>
      </form>

      

      <p class="mb-1">
        <a href="../PasswordRecovery/PasswordRecovery.aspx">¿Olvidaste tu contraseña?</a>
      </p>
      <p class="mb-0">
        <a href="RegisterPage.aspx" class="text-center">Registrarse</a>
      </p>
    </div>
    <!-- /.card-body -->
  </div>
  <!-- /.card -->
</div>
<!-- /.login-box -->

<!-- jQuery -->
<script src="../../plugins/jquery/jquery.min.js"></script>
<!-- Bootstrap 4 -->
<script src="../../plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
<!-- AdminLTE App -->
<script src="../../dist/js/adminlte.min.js"></script>
</form>
</html>
