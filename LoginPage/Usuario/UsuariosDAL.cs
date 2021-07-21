using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginPage.Usuario
{
    public class UsuariosDAL
    {

        public static int Agregar(Usuarios pCliente)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT into usuarios(email, nombre, password) values('{0}','{1}' , '{2}')",  pCliente.Mail, pCliente.User, pCliente.Password), Conexion.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();

            return retorno;

        }

        public static bool Login(Usuarios pCliente)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "select * from usuarios where (email=@user and password=@pass)";
            command.Parameters.AddWithValue("@user", pCliente.Mail);
            command.Parameters.AddWithValue("@pass", pCliente.Password);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())//Obtenemos los datos de la columna y asignamos a los campos de la Cache de Usuario
                {            
                    Usuarios.Mail = reader.GetString(2);
                    UserCache.Email = reader.GetString(6);
                }
                return true;
            }
            else
                return false;
        }
    }
      


    
}