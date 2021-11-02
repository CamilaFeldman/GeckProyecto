<%@ Page Title="Home Page" Language="C#" MasterPageFile="/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LoginPage._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
 <div class="content-wrapper">
    <!-- Content Header (Page header) -->
    <div class="content-header">
      <div class="container-fluid">
        <div class="row mb-2">
          <div class="col-sm-6">
            <h1 class="m-0">Home Page</h1>
          </div><!-- /.col -->
          <div class="col-sm-6">
            <ol class="breadcrumb float-sm-right">
              <li class="breadcrumb-item"><a href="/Stock/Stock.aspx">Stock</a></li>
              <li class="breadcrumb-item active">Home</li>
            </ol>
          </div><!-- /.col -->
        </div><!-- /.row -->
      </div><!-- /.container-fluid -->
    </div>
    <!-- /.content-header -->
 <!-- Main content -->
    <div class="content">
      <div class="container-fluid">
        <div class="row">
          
          <div class="col-lg-6">
            <div class="card">
              <div class="card-header">
                <h5 class="m-0">Mi Cuenta</h5>
              </div>
              <div class="card-body">
                <h6 class="card-title">Special title treatment</h6>

                <p class="card-text">With supporting text below as a natural lead-in to additional content.</p>
                <a href="PaginasComplementarias/micuenta.aspx" class="btn btn-primary">Go somewhere</a>
              </div>
            </div>

            <div class="card card-primary card-outline">
              <div class="card-header">
                <h5 class="m-0">¿Quiènes somos?</h5>
              </div>
              <div class="card-body">
                <h6 class="card-title">Special title treatment</h6>

                <p class="card-text">With supporting text below as a natural lead-in to additional content.</p>
                <a href="PaginasComplementarias/SobreNosotros.aspx" class="btn btn-primary">Go somewhere</a>
              </div>
            </div>
          </div>
          
            <div class="col-lg-6">
            <div class="card">
              <div class="card-header">
                <h5 class="m-0">Tutoriales</h5>
              </div>
              <div class="card-body">
                <h6 class="card-title">Special title treatment</h6>

                <p class="card-text">With supporting text below as a natural lead-in to additional content.</p>
                <a href="PaginasComplementarias/tutoriales.aspx" class="btn btn-primary">Go somewhere</a>
              </div>
            </div>

            <div class="card card-primary card-outline">
              <div class="card-header">
                <h5 class="m-0">Actualizaciones</h5>
              </div>
              <div class="card-body">
                <h6 class="card-title">Special title treatment</h6>

                <p class="card-text">With supporting text below as a natural lead-in to additional content.</p>
                <a href="PaginasComplementarias/actualizaciones.aspx" class="btn btn-primary">Go somewhere</a>
              </div>
            </div>
          </div>
            
<div class="col-lg-6">
            <div class="card">
              <div class="card-header">
                <h5 class="m-0">Soporte</h5>
              </div>
              <div class="card-body">
                <h6 class="card-title">Special title treatment</h6>

                <p class="card-text">With supporting text below as a natural lead-in to additional content.</p>
                <a href="PaginasComplementarias/contacto.aspx" class="btn btn-primary">Go somewhere</a>
              </div>
            </div>
             <div class="card card-primary card-outline">
              <div class="card-header">
                <h5 class="m-0">Preguntas Frecuentes</h5>
              </div>
              <div class="card-body">
                <h6 class="card-title">Special title treatment</h6>

                <p class="card-text">With supporting text below as a natural lead-in to additional content.</p>
                <a href="PaginasComplementarias/preguntasfrecuentes.aspx" class="btn btn-primary">Go somewhere</a>
              </div>
            </div>
          

            </div>
            
            
            
          </div>
          <!-- /.col-md-6 -->
        </div>
        <!-- /.row -->
      </div><!-- /.container-fluid -->
    </div>
    <!-- /.content -->

     </div>
     <!-- Main Footer -->
  <footer class="main-footer">
    <!-- To the right -->
    <div class="float-right d-none d-sm-inline">
      Anything you want
    </div>
    <!-- Default to the left -->
    <strong>Copyright &copy; 2014-2021 <a href="https://adminlte.io">AdminLTE.io</a>.</strong> All rights reserved.
  </footer>
</asp:Content>