using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginPage.Editable
{
    public class EditableDAL
    {

        public static int Agregar(EditableBLL pEditable)
        {
            int retorno = 0;
            MySqlCommand comando2 = new MySqlCommand(string.Format("INSERT into sucursales(nombre, direccion) values('{0}','{1}')", pEditable.Nombre, pEditable.Direccion), Conexion.ObtenerConexion());

            retorno = comando2.ExecuteNonQuery();

            return retorno;

        }


    }
}