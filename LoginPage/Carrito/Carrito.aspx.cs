using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginPage.Carrito
{
    public partial class Carrito : System.Web.UI.Page
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

        protected void BuscarBtn_Click(object sender, EventArgs e)
        {

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT nombre, stock, sucursal, precio FROM producto_especifico WHERE nombre=@nombre";
            cmd.Connection = Conexion.ObtenerConexion();
            cmd.Parameters.AddWithValue("@nombre", BuscarTxt.Text);
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();

        }
    }
}