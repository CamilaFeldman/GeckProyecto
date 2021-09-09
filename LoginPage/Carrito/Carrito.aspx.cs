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

            MySqlDataReader reader;

            reader = cmd.ExecuteReader();
            if (reader.Read())
            {

                string Nombre = reader["nombre"].ToString();
                int Stock = 1;
                string Sucursal = reader["sucursal"].ToString();
                int Precio = Convert.ToInt32(reader["precio"].ToString());
                int PrecioFinal = Stock * Precio;

                CarritoDAL.AgregarCarrito(Nombre, Stock, Sucursal, Precio, PrecioFinal);

                MySqlCommand comando2 = new MySqlCommand("SELECT nombre, cantidad, sucursal, precio_unitario, precio_final FROM carrito ", Conexion.ObtenerConexion());
                MySqlDataAdapter DA = new MySqlDataAdapter(comando2);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                GridView1.DataSource = DS.Tables[0];
                GridView1.DataBind();


            }
            /*
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            */
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            MySqlCommand comando3 = new MySqlCommand(string.Format("DELETE FROM carrito"), Conexion.ObtenerConexion());

            comando3.ExecuteNonQuery();

            GridView1.DataBind();
        }
    }
}