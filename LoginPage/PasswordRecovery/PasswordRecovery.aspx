<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PasswordRecovery.aspx.cs" Inherits="LoginPage.PasswordRecovery.PasswordRecovery" %>
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
    <form runat="server">
    <body class="hold-transition login-page">
<div class="login-box">
  <div class="card card-outline card-primary">
    <div class="card-header text-center">
      <asp:Label ID="Label1" runat="server" Text="Recuperar contraseña"></asp:Label>
    </div>
    <div class="card-body">
      <form action="recover-password.html" method="post">
        <div class="input-group mb-3">
          <asp:TextBox ID="txtEmail" runat="server" Width = "250" type="email" class="form-control" placeholder="Email"/>
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-envelope"></span>
            </div>
          </div>
        </div>
        <div class="row">
          <div class="col-12">              
            <asp:Button Text="Pedir contraseña" runat="server" OnClick="SendEmail" type="submit" class="btn btn-primary btn-block"/>
          </div>
          <!-- /.col -->
           <asp:Label ID="lblMessage" runat="server"></asp:Label>
            <a ID="href" runat="server" href="/Login/RegisterPage.aspx" Visible="false" class="registrarse">¿Aún no está registrado?</a>
        </div>
      </form>
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

