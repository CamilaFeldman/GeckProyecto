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
    public partial class PasswordRecovery : System.Web.UI.Page
    {
        string password;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SendEmail(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT password FROM usuarios WHERE email=@mail;", Conexion.ObtenerConexion());
            cmd.Parameters.AddWithValue("@mail", txtEmail.Text.Trim());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            int randomNumber = new Random().Next(100000, 999999);
            Session["código"] = Convert.ToString(randomNumber);
            Session["mail"] = Convert.ToString(txtEmail.Text.Trim());

            MySqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.Read())
            {
                password = sdr["password"].ToString();
            }


            if (!string.IsNullOrEmpty(password))
            {
                MailMessage mm = new MailMessage();
                mm.From = new MailAddress("officialdeckproject@gmail.com");
                mm.To.Add(txtEmail.Text.Trim());
                mm.Subject = "Password Recovery";
                mm.Body = string.Format("Hola,<br /><br />Tu código es {0}.<br /><br />Gracias.", randomNumber);
                mm.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 25;
                smtp.Credentials = new NetworkCredential("officialdeckproject@gmail.com", "proyectoseptimo");
                smtp.EnableSsl = true;
                smtp.Send(mm);
                Response.Redirect("~/PasswordRecovery/CambiarContra.aspx");
            }
            else
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "Este mail no se encuentra registrado.";
                href.Visible = true;
            }
        }
    }
}