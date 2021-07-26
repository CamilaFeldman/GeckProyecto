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

            Usuarios pCliente = new Usuarios(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text);
            int condicion = 0;
            bool mailverif;

            mailverif = UsuariosDAL.Register(pCliente);

            if(mailverif == true)
            {
                Label1.Visible = true;
                Label2.Visible = false;
                Label3.Visible = false;
                Label4.Visible = false;
                //Response.Write("<script>alert('Este mail ya existe')</script>");
                condicion = 1;
            }

            if(pCliente.Mail == String.Empty || pCliente.User == String.Empty || pCliente.Password == String.Empty || pCliente.rePassword == String.Empty)
            {
                Label1.Visible = false;
                Label2.Visible = true;
                Label3.Visible = false;
                Label4.Visible = false;
                //Response.Write("<script>alert('Hay espacios vacíos')</script>");
                condicion = 1;
            }

            if(pCliente.Password.Length < 8 || pCliente.Password.Length > 20)
            {

                Label1.Visible = false;
                Label2.Visible = false;
                Label3.Visible = false;
                Label4.Visible = true;
                condicion = 1;
            }

            if(pCliente.Password != pCliente.rePassword)
            {
                Label1.Visible = false;
                Label2.Visible = false;
                Label3.Visible = true;
                Label4.Visible = false;
                //Response.Write("<script>alert('Las contraseñas no coinciden')</script>");
                condicion = 1;
            }
            if(condicion != 1)
            {
                int resultado = UsuariosDAL.Agregar(pCliente);
                Response.Write("<script>alert('Se ingresó correctamente')</script>");
            }

            

        }
    }
}