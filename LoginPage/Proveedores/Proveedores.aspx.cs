using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginPage.Proveedores
{
    public partial class Proveedores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            ProveedoresBLL pProveedores = new ProveedoresBLL(Nombre.Text, Direccion.Text, Telefono.Text, Email.Text);

            if(pProveedores.Nombre == String.Empty || pProveedores.Direccion == String.Empty || pProveedores.Telefono == String.Empty || pProveedores.Email == String.Empty)
            {

                EspaciosVacios.Visible = true;

            }
            else
            {

                EspaciosVacios.Visible = false;
                int resultado = ProveedoresDAL.Agregar(pProveedores);
                Nombre.Text = String.Empty;
                Direccion.Text = String.Empty;
                Telefono.Text = String.Empty;
                Email.Text = String.Empty;

            }    

            

        }
    }
}