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
            int condicion = 0;

            if(pCliente.Mail == String.Empty || pCliente.User == String.Empty || pCliente.Password == String.Empty || pCliente.rePassword == String.Empty)
            {
                Response.Write("<script>alert('Hay espacios vacíos')</script>");
                condicion = 1;
            }

            if(pCliente.Password != pCliente.rePassword)
            {
                Response.Write("<script>alert('Las contraseñas no coinciden')</script>");
                condicion = 1;
            }
            if(condicion != 1)
            {
                int resultado = UsuariosDAL.Agregar(pCliente);
            }

            

        }
    }
}