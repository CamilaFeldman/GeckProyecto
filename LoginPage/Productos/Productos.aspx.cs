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

            ProductosBLL pProductos = new ProductosBLL(Nombre.Text, Precio.Text, Marcas.Text, Stock.Text, Proveedor.Text, CantidadMinima.Text, CantidadMaxima.Text, PresentacionComercial.Text);

            ProductosDAL.Agregar(pProductos);
            Response.Write("<script>alert('Se ingresó correctamente')</script>");

        }
    }
}