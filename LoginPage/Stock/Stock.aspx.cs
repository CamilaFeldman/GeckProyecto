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
            MySqlCommand cmd = new MySqlCommand("SELECT nombre AS Producto, stock AS Stock, marcas AS Categoria, proveedor AS Proveedor, precio AS Precio  FROM deck.producto_especifico ORDER BY Producto ASC;", Conexion.ObtenerConexion());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();


            if (!IsPostBack)
            {
                ListItem i;
                i = new ListItem("Producto A-Z", "1");
                DropDownList1.Items.Add(i);
                i = new ListItem("Producto Z-A", "2");
                DropDownList1.Items.Add(i);
                i = new ListItem("Proveedor", "3");
                DropDownList1.Items.Add(i);
                i = new ListItem("Precio", "4");
                DropDownList1.Items.Add(i);
            }



        }

        protected void Buscar_Click(object sender, EventArgs e)
        {

            MySqlCommand cmd = new MySqlCommand("SELECT nombre AS Producto, stock AS Stock, marcas AS Categoria, proveedor AS Proveedor, precio AS Precio  FROM deck.producto_especifico WHERE nombre LIKE ('%" + Filtrado.Text + "%') || proveedor LIKE ('%" + Filtrado.Text + "%') ", Conexion.ObtenerConexion());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (DropDownList1.SelectedValue == "1")
            {
                MySqlCommand cmdd = new MySqlCommand("SELECT nombre AS Producto, stock AS Stock, marcas AS Categoria, proveedor AS Proveedor, precio AS Precio  FROM deck.producto_especifico ORDER BY Producto ASC;", Conexion.ObtenerConexion());
                MySqlDataAdapter daa = new MySqlDataAdapter(cmdd);
                DataSet dss = new DataSet();
                daa.Fill(dss);
                GridView1.DataSource = dss.Tables[0];
                GridView1.DataBind();
            }
            if (DropDownList1.SelectedValue == "2")
            {
                MySqlCommand cmdd = new MySqlCommand("SELECT nombre AS Producto, stock AS Stock, marcas AS Categoria, proveedor AS Proveedor, precio AS Precio  FROM deck.producto_especifico ORDER BY Producto DESC;", Conexion.ObtenerConexion());
                MySqlDataAdapter daa = new MySqlDataAdapter(cmdd);
                DataSet dss = new DataSet();
                daa.Fill(dss);
                GridView1.DataSource = dss.Tables[0];
                GridView1.DataBind();
            }
            if (DropDownList1.SelectedValue == "3")
            {
                MySqlCommand cmdd = new MySqlCommand("SELECT nombre AS Producto, stock AS Stock, marcas AS Categoria, proveedor AS Proveedor, precio AS Precio  FROM deck.producto_especifico ORDER BY Proveedor ASC;", Conexion.ObtenerConexion());
                MySqlDataAdapter daa = new MySqlDataAdapter(cmdd);
                DataSet dss = new DataSet();
                daa.Fill(dss);
                GridView1.DataSource = dss.Tables[0];
                GridView1.DataBind();
            }
            if (DropDownList1.SelectedValue == "4")
            {
                MySqlCommand cmdd = new MySqlCommand("SELECT nombre AS Producto, stock AS Stock, marcas AS Categoria, proveedor AS Proveedor, precio AS Precio  FROM deck.producto_especifico ORDER BY Precio DESC;", Conexion.ObtenerConexion());
                MySqlDataAdapter daa = new MySqlDataAdapter(cmdd);
                DataSet dss = new DataSet();
                daa.Fill(dss);
                GridView1.DataSource = dss.Tables[0];
                GridView1.DataBind();
            }

        }

        protected void Editar_Click(object sender, EventArgs e)
        {

            GridViewRow seleccion = GridView1.SelectedRow; // lo tuve q crear para q no salte excepcion

            if (seleccion == null)
            {

            }
            else
            {
                string idProducto;
                string idProveedor;
                idProducto = GridView1.SelectedRow.Cells[1].Text;
                idProveedor = GridView1.SelectedRow.Cells[4].Text;
                Response.Redirect("~/Productos/Productos.aspx?idProducto=" + idProducto + "&idProveedor=" + idProveedor);


            }



        }
    }
}