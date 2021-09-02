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
        protected void Page_Load(object sender, EventArgs e)
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

                MySqlCommand SucursalSelect = new MySqlCommand("SELECT nombre FROM deck.sucursales", Conexion.ObtenerConexion());
                MySqlDataAdapter DAA = new MySqlDataAdapter(SucursalSelect.CommandText, Conexion.ObtenerConexion());
                DataSet DSS = new DataSet();
                DAA.Fill(DSS);
                this.Sucursal.DataSource = DSS;
                this.Sucursal.DataBind();

                if (Request.QueryString["idProducto"] == null || Request.QueryString["idProveedor"] == null)
                {

                }
                else
                {
                    Nombre.Text = Request.QueryString["idProducto"].ToString();
                    DropDownList1.Text = Request.QueryString["idProveedor"].ToString();

                    try
                    {
                        ProductosBLL recProducto = new ProductosBLL();

                        recProducto = ProductosDAL.CompararProducto(Nombre.Text, DropDownList1.Text);

                        Precio.Text = recProducto.sPrecio;
                        Marcas.Text = recProducto.Marcas;
                        Stock.Text = recProducto.sStock;
                        CantidadMinima.Text = recProducto.sCantidadMinima;
                        CantidadMaxima.Text = recProducto.sCantidadMaxima;
                        PresentacionComercial.Text = recProducto.Presentacion;
                        Sucursal.Text = recProducto.Sucursal;


                    }
                    catch(Exception)
                    {

                    }


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
                    ProductosBLL pProductos = new ProductosBLL(Nombre.Text, Convert.ToInt32(Precio.Text), Marcas.Text, Convert.ToInt32(Stock.Text), DropDownList1.SelectedValue ,Convert.ToInt32(CantidadMinima.Text), Convert.ToInt32(CantidadMaxima.Text), PresentacionComercial.Text, Sucursal.SelectedValue);
                    
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
                        Marcas.Text = String.Empty;
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