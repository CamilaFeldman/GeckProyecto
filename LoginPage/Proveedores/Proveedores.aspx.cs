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
        private string verificacion;
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
                bool mailverif;

                mailverif = ProveedoresDAL.MailVerif(pProveedores);

                if(mailverif == true)
                {
                    EspaciosVacios.Visible = false;
                    MailProveedor.Visible = true;
                }
                else
                {
                    MailProveedor.Visible = false;
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
}