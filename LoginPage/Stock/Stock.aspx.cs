using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginPage.Stock
{
    public partial class Stock : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT nombre AS Producto, stock AS Stock, proveedor AS Proveedor, precio AS Precio  FROM deck.producto_especifico;", Conexion.ObtenerConexion());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

        protected void Buscar_Click(object sender, EventArgs e)
        {

            MySqlCommand cmd = new MySqlCommand("SELECT nombre AS Producto, stock AS Stock, proveedor AS Proveedor, precio AS Precio  FROM deck.producto_especifico WHERE nombre LIKE ('%" + Filtrado.Text + "%') || proveedor LIKE ('%" + Filtrado.Text + "%') ", Conexion.ObtenerConexion());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();

        }
    }
}