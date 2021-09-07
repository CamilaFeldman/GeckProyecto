using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginPage.Productos
{
    public partial class Productos : System.Web.UI.Page
    {
        string verificacion;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["verificar"] != null)
            {
                verificacion = Convert.ToString(Session["verificar"]);

            }
            if (verificacion != "Si")
            {
                Response.Redirect("~/Login/LoginPage.aspx");
            }
            else
            {
                if (!IsPostBack)
                {
                
                    MySqlCommand OrdenSqlSelect = new MySqlCommand("SELECT nombre FROM proveedor_especifico", Conexion.ObtenerConexion());
                    MySqlDataAdapter da = new MySqlDataAdapter(OrdenSqlSelect.CommandText, Conexion.ObtenerConexion());
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    this.DropDownList1.DataSource = ds;
                    this.DropDownList1.DataBind();
                
                    MySqlCommand CategoriaSelect = new MySqlCommand("SELECT nombre FROM deck.categorias", Conexion.ObtenerConexion());
                    MySqlDataAdapter DA = new MySqlDataAdapter(CategoriaSelect.CommandText, Conexion.ObtenerConexion());
                    DataSet DS = new DataSet();
                    DA.Fill(DS);
                    this.Marcas.DataSource = DS;
                    this.Marcas.DataBind();

                    MySqlCommand SucursalSqlSelect = new MySqlCommand("SELECT nombre FROM sucursales", Conexion.ObtenerConexion());
                    MySqlDataAdapter du = new MySqlDataAdapter(SucursalSqlSelect.CommandText, Conexion.ObtenerConexion());
                    DataSet DU = new DataSet();
                    du.Fill(DU);
                    this.Sucursales.DataSource = DU;
                    this.Sucursales.DataBind();
                }
            }
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //int condicion=0;
            Conexion.ObtenerConexion();

            if (Nombre.Text == String.Empty || Precio.Text.Length == 0 || Marcas.Text == String.Empty || Stock.Text.Length == 0 ||  CantidadMinima.Text.Length == 0 || CantidadMaxima.Text.Length == 0 || PresentacionComercial.Text == String.Empty)
            {
                EspaciosVacios.Visible = true;
                IngresoIncorrecto.Visible = false;
                CantidadRequerida.Visible = false;
            }
            else
            {
              
                try
                {
                    ProductosBLL pProductos = new ProductosBLL(Nombre.Text, Convert.ToInt32(Precio.Text), Marcas.Text, Convert.ToInt32(Stock.Text), DropDownList1.SelectedValue ,Convert.ToInt32(CantidadMinima.Text), Convert.ToInt32(CantidadMaxima.Text), PresentacionComercial.Text, Sucursales.SelectedValue);
                    
                   if(pProductos.CantidadMinima > pProductos.CantidadMaxima)
                    {
                        EspaciosVacios.Visible = false;
                        IngresoIncorrecto.Visible = false;
                        CantidadRequerida.Visible = true;
                    }
                    else
                    {

                        int resultado = ProductosDAL.Agregar(pProductos);
                        EspaciosVacios.Visible = false;
                        IngresoIncorrecto.Visible = false;
                        CantidadRequerida.Visible = false;
                        Response.Write("<script>alert('Se ingresó correctamente')</script>");
                        Nombre.Text = String.Empty;
                        Precio.Text = String.Empty;
                        Stock.Text = String.Empty;
                        CantidadMinima.Text = String.Empty;
                        CantidadMaxima.Text = String.Empty;
                        PresentacionComercial.Text = String.Empty;
                    }

                    
                    

                }
                catch(Exception)
                {
                    IngresoIncorrecto.Visible = true;
                    EspaciosVacios.Visible = false;
                    CantidadRequerida.Visible = false;
                }
            
            }       
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

       
    }
}