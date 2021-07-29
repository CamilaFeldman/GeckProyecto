using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
        public static bool MailVerif(ProveedoresBLL pProveedores)
        {

            MySqlCommand command = new MySqlCommand(/*string.Format("SELECT * from usuarios where(email, password) values('{0}','{1}')", pCliente.Mail, pCliente.Password), Conexion.ObtenerConexion()*/);

            command.Connection = Conexion.ObtenerConexion();
            command.CommandText = "select * from proveedor_especifico where (email=@user)";
            command.Parameters.AddWithValue("@user", pProveedores.Email);
            command.CommandType = CommandType.Text;

            MySqlDataReader reader;

            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
                return false;

        }

    }
}