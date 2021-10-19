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
    public partial class CerrarCaja : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void IngresarMontoBtn_Click(object sender, EventArgs e)
        {

            CerrarCajaFinal(Convert.ToInt32(IngresarMontoTxt.Text));
            Response.Write("<script>window.open('ResumenCaja.aspx','popup','width=500,height=300') </script>");
            Response.Write("<script languaje=javascript>window.close();</script>");

        }

        public static void CerrarCajaFinal(int MontoInicio)
        {

            MySqlCommand command = new MySqlCommand();
            command.Connection = Conexion.ObtenerConexion();
            command.CommandText = "UPDATE caja SET final_caja=@final_caja WHERE (idcaja=@idcaja)";
            command.Parameters.AddWithValue("@idcaja", "0");
            command.Parameters.AddWithValue("@final_caja", MontoInicio);
            command.CommandType = CommandType.Text;
            MySqlDataReader reader;
            reader = command.ExecuteReader();



        }
    }
}