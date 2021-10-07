using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginPage.Movimientos
{
    public partial class AbrirCaja : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void IngresarMontoBtn_Click(object sender, EventArgs e)
        {

            AgregarCarrito(Convert.ToInt32(IngresarMontoTxt.Text));
            Response.Write("<script languaje=javascript>window.close();</script>");

        }

        public static void AgregarCarrito(int MontoInicio)
        {

            MySqlCommand command = new MySqlCommand();
            command.Connection = Conexion.ObtenerConexion();
            command.CommandText = "UPDATE caja SET inicio_caja=@inicio_caja WHERE (idcaja=@idcaja)";
            command.Parameters.AddWithValue("@idcaja", "0");
            command.Parameters.AddWithValue("@inicio_caja", MontoInicio);
            command.CommandType = CommandType.Text;
            MySqlDataReader reader;
            reader = command.ExecuteReader();



        }
    }
}