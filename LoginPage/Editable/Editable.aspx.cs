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
    }
}