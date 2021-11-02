using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginPage.PaginasComplementarias
{
    public partial class Config : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MySqlCommand OrdenSqlSelect = new MySqlCommand("SELECT nombre FROM sucursales", Conexion.ObtenerConexion());
                MySqlDataAdapter da = new MySqlDataAdapter(OrdenSqlSelect.CommandText, Conexion.ObtenerConexion());
                DataSet ds = new DataSet();
                da.Fill(ds);
                this.SucursalDdl.DataSource = ds;
                this.SucursalDdl.DataBind();

            }

            Session["sucursal"] = SucursalDdl.SelectedValue;

        }

        protected void SucursalDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["sucursal"] = SucursalDdl.SelectedValue;
            }
        }
    }
}