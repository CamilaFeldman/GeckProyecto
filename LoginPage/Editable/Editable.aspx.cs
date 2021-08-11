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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void agregar_Click(object sender, EventArgs e)
        {
            DataSet dt;
            EditableBLL pEditable = new EditableBLL(nombreSucursalTxt.Text, direccionSucursalTxt.Text);
            int resultado = EditableDAL.Agregar(pEditable);

            GridView1.DataBind();
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
                    
                    if(seleccion == null)
                {

                }
                    else
                {
                    string idNombre;
                    idNombre = GridView1.SelectedRow.Cells[0].Text;

                    EditableDAL.Eliminar(idNombre);
                }
                    

                
            }
            catch(Exception)
            {
                
            }

            GridView1.DataBind();
        }
    }
}