using LoginPage.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginPage.Login
{
    public partial class LoginPage : System.Web.UI.Page
    {
        private string verificar;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Usuarios pCliente = new Usuarios(TextBox1.Text, TextBox2.Text);
            bool ingreso = UsuariosDAL.Login(pCliente);

            if (TextBox1.Text == "admin" && TextBox2.Text == "admin")
            {
                Session["administrador"] = "Si";
                verificar = "Si";
                Session["verificar"] = verificar;
                Response.Redirect("~/HomePage.aspx");
            }

            if (ingreso == true)
            {
                verificar = "Si";
                Session["verificar"] = verificar;
                Response.Write("<script>alert('Se ingresó correctamente')</script>");
                Response.Redirect("~/HomePage.aspx");

            }
            else
            {

                Label1.Visible = true;
                Label2.Visible = false;
            }
            if (pCliente.Mail == String.Empty || pCliente.Password == String.Empty)
            {
                Label1.Visible = false;
                Label2.Visible = true;

            }
        }


    }
}