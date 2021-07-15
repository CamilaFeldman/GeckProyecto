using LoginPage.Usuario;
using static LoginPage.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginPage.Login
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click1(object sender, EventArgs e)
        {

            Conexion.ObtenerConexion();
            Response.Write("<script>alert('Conexion')</script>");

            Usuarios pCliente = new Usuarios(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text);

            if(pCliente.Password != pCliente.rePassword)
            {
                Response.Write("<script>alert('Las contraseñas no coinciden')</script>");
            }
            else
            {
                int resultado = UsuariosDAL.Agregar(pCliente);
            }

            

        }
    }
}