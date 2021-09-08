using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginPage.Editable
{
    public partial class Editable : System.Web.UI.Page
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

            Cargar();
            CargarCategoria();
        }

        private void Cargar()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT nombre, direccion FROM sucursales", Conexion.ObtenerConexion());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

        private void CargarCategoria()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT nombre FROM categorias", Conexion.ObtenerConexion());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView2.DataSource = ds.Tables[0];
            GridView2.DataBind();
        }

        protected void agregar_Click(object sender, EventArgs e)
        {
            DataSet dt;
            EditableBLL pEditable = new EditableBLL(nombreSucursalTxt.Text, direccionSucursalTxt.Text);

            bool Comparacion = EditableDAL.Comparar(pEditable);

            if (Comparacion == true)
            {
                Response.Write("<script language=JavaScript> alert('Ya existe esa sucursal'); </script>");
            }
            else
            {
                if(nombreSucursalTxt.Text == String.Empty || direccionSucursalTxt.Text == String.Empty)
                {
                    Completar.Visible = true;
                }
                else
                {
                    int resultado = EditableDAL.Agregar(pEditable);
                    Completar.Visible = false;
                }
                
            }

            Cargar();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string idNombre;

                idNombre = GridView1.SelectedRow.Cells[0].Text;
            }
            catch (Exception)
            {

            }


        }

        protected void eliminar_Click(object sender, EventArgs e)
        {
            try
            {

                GridViewRow seleccion = GridView1.SelectedRow; // lo tuve q crear para q no salte excepcion

                if (seleccion == null)
                {

                }
                else
                {
                    string idNombre;
                    idNombre = GridView1.SelectedRow.Cells[0].Text;

                    EditableDAL.Eliminar(idNombre);
                }



            }
            catch (Exception)
            {

            }

            Cargar();
        }

        protected void AgregarCategoria_Click(object sender, EventArgs e)
        {

            EditableBLL pEditable = new EditableBLL(NuevaCategoria.Text);

            bool Comparacion = EditableDAL.CompararCategoria(pEditable);

            if (Comparacion == true)
            {
                Response.Write("<script language=JavaScript> alert('Ya existe esa categoria'); </script>");
            }
            else
            {
                if (NuevaCategoria.Text == String.Empty)
                {
                    Completar.Visible = true;
                }
                else
                {
                    int resultado = EditableDAL.AgregarCategoria(pEditable);
                    Completar.Visible = false;
                }

            }

            CargarCategoria();

        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                string idCategoria;

                idCategoria = GridView2.SelectedRow.Cells[0].Text;
            }
            catch (Exception)
            {

            }

        }

        protected void EliminarCategoria_Click(object sender, EventArgs e)
        {

            try
            {

                GridViewRow seleccion = GridView2.SelectedRow; // lo tuve q crear para q no salte excepcion

                if (seleccion == null)
                {

                }
                else
                {
                    string idNombre;
                    idNombre = GridView2.SelectedRow.Cells[0].Text;

                    EditableDAL.EliminarCategoria(idNombre);
                }



            }
            catch (Exception)
            {

            }

            CargarCategoria();

        }
    }
}