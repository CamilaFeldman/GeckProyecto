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
    public partial class Movimientos : System.Web.UI.Page
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


            MySqlCommand comando = new MySqlCommand("SELECT nombre, cantidad, sucursal, precio_unitario, fecha FROM movimientos ", Conexion.ObtenerConexion());
            MySqlDataAdapter DA = new MySqlDataAdapter(comando);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            GridView1.DataSource = DS.Tables[0];
            GridView1.DataBind();


            ActualizarPrecio();

        }
        private void ActualizarPrecio()
        {

            int[] cantidad = new int[GridView1.Rows.Count];
            int[] precio = new int[GridView1.Rows.Count];
            int[] precioFinal = new int[GridView1.Rows.Count];
            int sumaFinal = 0;

            for (int counter = 0; counter < (GridView1.Rows.Count); counter++)
            {
                try
                {

                    cantidad[counter] = Convert.ToInt32(GridView1.Rows[counter].Cells[2].Text);

                    precio[counter] = Convert.ToInt32(GridView1.Rows[counter].Cells[4].Text);

                    precioFinal[counter] = (Convert.ToInt32(cantidad[counter]) * Convert.ToInt32(precio[counter]));

                    sumaFinal = sumaFinal + precioFinal[counter];


                }
                catch (Exception)
                {

                }

            }

            PrecioTotal.Text = Convert.ToString(sumaFinal);

        }

        protected void AbrirCajaBtn_Click(object sender, EventArgs e)
        {

            Response.Write("<script>window.open('AbrirCaja.aspx','popup','width=500,height=300') </script>");

        }

        protected void CerrarCajaBtn_Click(object sender, EventArgs e)
        {

            Response.Write("<script>window.open('CerrarCaja.aspx','popup','width=500,height=300') </script>");

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string idNombre;
                string idCantidad;
                idNombre = GridView1.SelectedRow.Cells[1].Text;
                idCantidad = GridView1.SelectedRow.Cells[2].Text;
                string sucursal = Session["sucursal"].ToString();

                MySqlCommand command = new MySqlCommand();

                command.Connection = Conexion.ObtenerConexion();
                command.CommandText = "UPDATE producto_especifico SET stock = stock+@cantidad WHERE (nombre=@nombre AND sucursal=@sucursal)";
                command.Parameters.AddWithValue("@nombre", idNombre);
                command.Parameters.AddWithValue("@cantidad", idCantidad);
                command.Parameters.AddWithValue("@sucursal", idCantidad);
                command.CommandType = CommandType.Text;


                command.ExecuteNonQuery();

                MySqlCommand comando2 = new MySqlCommand(string.Format("DELETE FROM movimientos WHERE nombre = '" + idNombre + "'"), Conexion.ObtenerConexion());

                comando2.ExecuteNonQuery();

                MySqlCommand comando = new MySqlCommand("SELECT nombre, cantidad, sucursal, precio_unitario, fecha FROM movimientos ", Conexion.ObtenerConexion());
                MySqlDataAdapter DA = new MySqlDataAdapter(comando);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                GridView1.DataSource = DS.Tables[0];
                GridView1.DataBind();
            }
            catch (Exception)
            {
                Response.Write("<script>alert('Se debe seleccionar una sucursal en configuración')</script>");
            }



        }
    }
}