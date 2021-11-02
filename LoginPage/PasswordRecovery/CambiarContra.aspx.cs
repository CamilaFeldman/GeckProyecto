using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using System.Drawing;
using System.Configuration;
using System.Data.SqlClient;

namespace LoginPage.PasswordRecovery
{
    public partial class CambiarContra : System.Web.UI.Page
    {
        string mail;
        string código;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["mail"] != null)
            {
                mail = Convert.ToString(Session["mail"]);
            }
            if (Session["código"] != null)
            {
                código = Convert.ToString(Session["código"]);
            }

            Label1.Text = string.Format("Ingrese el código de 6 dígitos enviado a {0}", mail);
            Repeat.ForeColor = Color.Blue;
            Repeat.Text = "¿No ha recibido el código?";
        }

        protected void AcceptButton(object sender, EventArgs e)
        {
            if (txtCode.Text.Trim() == código)
            {
                Repeat.Visible = false;
                Label1.Visible = false;
                txtCode.Visible = false;
                Accept.Visible = false;
                Label2.Visible = false;
                SendAgain.Visible = false;
                NuevaPass.Visible = true;
                txtPass.Visible = true;
                RepetirPass.Visible = true;
                txtRepetir.Visible = true;
                End.Visible = true;


            }
            else
            {
                Label2.ForeColor = Color.Red;
                Label2.Text = "El código ingresado no coincide. Intente nuevamente.";

            }
        }

        protected void EndButton(object sender, EventArgs e)
        {

            if (txtPass.Text.Trim() == txtRepetir.Text.Trim())
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE usuarios SET password=@pass WHERE email=@mail;", Conexion.ObtenerConexion());
                cmd.Parameters.AddWithValue("@mail", mail);
                cmd.Parameters.AddWithValue("@pass", txtPass.Text.Trim());
                cmd.CommandType = CommandType.Text;

                MySqlDataReader reader;

                reader = cmd.ExecuteReader();

                Label3.ForeColor = Color.Green;
                Label3.Text = "Su contraseña ha sido cambiada correctamente.";
                string URL = "~/Login/LoginPage.aspx";
                URL = Page.ResolveClientUrl(URL);
                Response.AddHeader("REFRESH", "2;" + URL + "");
            }
            else
            {
                Label3.ForeColor = Color.Red;
                Label3.Text = "Las contraseñas no coinciden. Vuelva a intentarlo.";
            }
        }

        protected void SendAgain_Click(object sender, EventArgs e)
        {
            Repeat.ForeColor = Color.Green;
            Repeat.Text = "Código reenviado con éxito.";
            MySqlCommand cmd = new MySqlCommand("SELECT password FROM usuarios WHERE email=@mail;", Conexion.ObtenerConexion());
            cmd.Parameters.AddWithValue("@mail", mail);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            int randomNumber = new Random().Next(100000, 999999);
            Session["código"] = Convert.ToString(randomNumber);

            if (Session["código"] != null)
            {
                código = Convert.ToString(Session["código"]);
            }

            MailMessage mm = new MailMessage();
            mm.From = new MailAddress("officialdeckproject@gmail.com");
            mm.To.Add(mail);
            mm.Subject = "Password Recovery";
            mm.Body = string.Format("Hola,<br /><br />Tu código es {0}.<br /><br />Gracias.", randomNumber);
            mm.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 25;
            smtp.Credentials = new NetworkCredential("officialdeckproject@gmail.com", "proyectoseptimo");
            smtp.EnableSsl = true;
            smtp.Send(mm);

        }
    }
}