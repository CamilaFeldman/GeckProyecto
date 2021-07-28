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

            Conexion.ObtenerConexion();
            ProductosBLL pProductos = new ProductosBLL(Nombre.Text, Convert.ToInt32(Precio.Text), Marcas.Text, Convert.ToInt32(Stock.Text), Proveedor.Text, Convert.ToInt32(CantidadMinima.Text), Convert.ToInt32(CantidadMaxima.Text), PresentacionComercial.Text);

            int resultado = ProductosDAL.Agregar(pProductos);
            Response.Write("<script>alert('Se ingresó correctamente')</script>");
           
        }
    }
}