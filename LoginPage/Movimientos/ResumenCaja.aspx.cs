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
    public partial class ResumenCaja : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            MySqlCommand command = new MySqlCommand();

            command.Connection = Conexion.ObtenerConexion();
            command.CommandText = "SELECT * FROM caja WHERE (idcaja=@inicio)";
            command.Parameters.AddWithValue("@inicio", "0");
            command.CommandType = CommandType.Text;


            MySqlDataReader reader;

            reader = command.ExecuteReader();
            if (reader.Read())
            {
                string Inicio = reader["inicio_caja"].ToString();
                string Final = reader["final_caja"].ToString();

                InicioCajaTxt.Text = Inicio;
                CierreCajaTxt.Text = Final;
                IngresoTxt.Text = Convert.ToString(Convert.ToInt32(Final) - Convert.ToInt32(Inicio));

            }

            


        }

        protected void ContinuarBtn_Click(object sender, EventArgs e)
        {

            MySqlCommand comando3 = new MySqlCommand(string.Format("DELETE FROM movimientos"), Conexion.ObtenerConexion());

            comando3.ExecuteNonQuery();

            MySqlCommand command = new MySqlCommand();
            command.Connection = Conexion.ObtenerConexion();
            command.CommandText = "UPDATE caja SET final_caja=0 AND inicio_caja=0 WHERE (idcaja=@idcaja)";
            command.Parameters.AddWithValue("@idcaja", "0");
            command.CommandType = CommandType.Text;
            MySqlDataReader reader;
            reader = command.ExecuteReader();

            Response.Write("<script languaje=javascript>window.close();</script>");

        }
    }
}