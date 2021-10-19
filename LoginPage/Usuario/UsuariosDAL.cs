using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LoginPage.Usuario
{
    public class UsuariosDAL: Conexion
    {

        public static int Agregar(Usuarios pCliente)
        {
            int retorno = 0;
            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO usuarios(email, nombre, password) values('{0}','{1}' , '{2}')", pCliente.Mail, pCliente.User, pCliente.Password), Conexion.ObtenerConexion());

                retorno = comando.ExecuteNonQuery();
            }
            catch(Exception)
            {
               
            }
           

            return retorno;

        }
        
        public static bool Login(Usuarios pCliente)
        {
       
            MySqlCommand command = new MySqlCommand();

            command.Connection = Conexion.ObtenerConexion();
            command.CommandText = "SELECT * FROM usuarios WHERE (email=@user and password=@pass)";
            command.Parameters.AddWithValue("@user", pCliente.Mail);
            command.Parameters.AddWithValue("@pass", pCliente.Password);
            command.CommandType = CommandType.Text;

            try
            {
                MySqlDataReader reader;

                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }

            
            
        }

        public static bool Register(Usuarios pCliente)
        {

            MySqlCommand command = new MySqlCommand();

            command.Connection = Conexion.ObtenerConexion();
            command.CommandText = "SELECT * FROM usuarios WHERE (email=@user)";
            command.Parameters.AddWithValue("@user", pCliente.Mail);
            command.CommandType = CommandType.Text;

            try
            {
                MySqlDataReader reader;

                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    return true;
                }
                else
                    return false;
            }
            catch(Exception)
            {
                return false;
            }
            

        }

    }
      


    
}