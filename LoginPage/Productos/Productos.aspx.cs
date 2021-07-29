using System;
using System.Collections.Generic;
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

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //int condicion=0;
            Conexion.ObtenerConexion();

            if (Nombre.Text == String.Empty || Precio.Text.Length == 0 || Marcas.Text == String.Empty || Stock.Text.Length == 0 || Proveedor.Text == String.Empty || CantidadMinima.Text.Length == 0 || CantidadMaxima.Text.Length == 0 || PresentacionComercial.Text == String.Empty)
            {
                EspaciosVacios.Visible = true;
                IngresoIncorrecto.Visible = false;
                CantidadRequerida.Visible = false;
            }
            else
            {
              
                try
                {
                    ProductosBLL pProductos = new ProductosBLL(Nombre.Text, Convert.ToInt32(Precio.Text), Marcas.Text, Convert.ToInt32(Stock.Text), Proveedor.Text, Convert.ToInt32(CantidadMinima.Text), Convert.ToInt32(CantidadMaxima.Text), PresentacionComercial.Text);
                    
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
                        Proveedor.Text = String.Empty;
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
    }
}