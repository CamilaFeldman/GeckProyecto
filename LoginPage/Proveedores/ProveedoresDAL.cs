using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginPage.Proveedores
{
    public class ProveedoresDAL
    {

        public static int Agregar(ProveedoresBLL pProveedores)
        {
            int retorno = 0;
            MySqlCommand comando3 = new MySqlCommand(string.Format("INSERT into proveedor_especifico(nombre, direccion, telefono, email) values('{0}','{1}' , '{2}', '{3}')",pProveedores.Nombre, pProveedores.Direccion, pProveedores.Telefono, pProveedores.Email), Conexion.ObtenerConexion());

            retorno = comando3.ExecuteNonQuery();

            return retorno;

        }

    }
}