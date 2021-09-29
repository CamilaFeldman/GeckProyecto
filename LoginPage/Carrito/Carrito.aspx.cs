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

            if (!IsPostBack)
            {

                MySqlCommand comando2 = new MySqlCommand("SELECT nombre, cantidad, sucursal, precio_unitario, precio_final FROM carrito ", Conexion.ObtenerConexion());
                MySqlDataAdapter DA = new MySqlDataAdapter(comando2);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                GridView1.DataSource = DS.Tables[0];
                GridView1.DataBind();

                DataTable dt = GetData();

                Session["data"] = dt;

                GridView1.DataSource = dt;
                GridView1.DataBind();

            }



            ActualizarPrecio();

        }

        private DataTable GetData()
        {
            try
            {

                MySqlCommand comando2 = new MySqlCommand("SELECT nombre, cantidad, sucursal, precio_unitario, precio_final FROM carrito ", Conexion.ObtenerConexion());
                MySqlDataAdapter DA = new MySqlDataAdapter(comando2);
                DataTable dt = new DataTable();
                DA.Fill(dt);

                return dt;
                
            }
            catch (Exception)
            {
                
                return null;
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

                bool comparacion = CarritoDAL.CompararProducto(Nombre);

                if (comparacion == true)
                {
                    CarritoDAL.AgregarCarrito(Nombre, Stock, Sucursal, Precio, PrecioFinal);
                }
                else
                {
                    Response.Write("<script>alert('Ya se encuentra en el carrito')</script>");
                }


                MySqlCommand comando2 = new MySqlCommand("SELECT nombre, cantidad, sucursal, precio_unitario, precio_final FROM carrito ", Conexion.ObtenerConexion());
                MySqlDataAdapter DA = new MySqlDataAdapter(comando2);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                GridView1.DataSource = DS.Tables[0];
                GridView1.DataBind();

                ActualizarPrecio();

                DataTable dt = GetData();

                Session["data"] = dt;

            }

        }

        

        protected void Actualizar_Click(object sender, EventArgs e)
        {

            ActualizarPrecio();
            
        }


        protected void FinalizarCompra_Click(object sender, EventArgs e)
        {

            bool operacionExitosa = false;
            CarritoDAL.EliminarCarrito();

            for (int counter = 0; counter < (GridView1.Rows.Count); counter++)
            {
                try
                {

                    string Nombre = GridView1.Rows[counter].Cells[0].Text;
                    TextBox txtValor = GridView1.Rows[counter].Cells[1].FindControl("txtQuantity") as TextBox;                   
                    int Stock = Convert.ToInt32(txtValor.Text);
                    string Sucursal = GridView1.Rows[counter].Cells[2].Text;
                    int Precio = Convert.ToInt32(GridView1.Rows[counter].Cells[3].Text);
                    int PrecioFinal = Convert.ToInt32(GridView1.Rows[counter].Cells[4].Text);

                    bool verificarstock = CarritoDAL.VerificarStock(Nombre, Sucursal, Stock);

                    if(verificarstock == true)
                    {
                        CarritoDAL.RestarStock(Nombre, Sucursal, Stock);
                        operacionExitosa = true;
                        Response.Write("<script language=JavaScript> alert('Su venta fue realizada exitosamente'); </script>");

                    }
                    else
                    {
                        Response.Write("<script language=JavaScript> alert('No se puede realizar ya que no hay suficiente stock'); </script>");
                        operacionExitosa = false;
                        
                    }
                    



                }
                catch (Exception)
                {

                }

            }
            if(operacionExitosa == true)
            {

                CarritoDAL.EliminarCarrito();
                Cargar();

            }
            

        }

        protected void GridView1_RowDeleting1(object sender, GridViewDeleteEventArgs e)
        {

            DataTable dt = (DataTable)Session["data"];
            dt.Rows.RemoveAt(e.RowIndex);

            //Guardo los nuevos valores
            Session["data"] = dt;

            GridView1.DataSource = dt;
            GridView1.DataBind();

        }

        private void Cargar()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT nombre, cantidad, sucursal, precio_unitario, precio_final FROM carrito ", Conexion.ObtenerConexion());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
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

                    TextBox txtValor = GridView1.Rows[counter].Cells[1].FindControl("txtQuantity") as TextBox;

                    cantidad[counter] = Convert.ToInt32(txtValor.Text);

                    precio[counter] = Convert.ToInt32(GridView1.Rows[counter].Cells[3].Text);

                    GridView1.Rows[counter].Cells[4].Text = Convert.ToString(cantidad[counter] * precio[counter]);

                    precioFinal[counter] = Convert.ToInt32(GridView1.Rows[counter].Cells[4].Text);

                    sumaFinal = sumaFinal + precioFinal[counter];

                    DataTable dt = GetData();

                    Session["data"] = dt;

                }
                catch (Exception)
                {

                }

            }

            PrecioTotal.Text = Convert.ToString(sumaFinal);

        }

    }
}