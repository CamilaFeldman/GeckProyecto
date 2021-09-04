using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

        public static void Eliminar(string lNombre)
        {
            string nombre = lNombre;


            MySqlCommand comando2 = new MySqlCommand(string.Format("DELETE FROM sucursales WHERE nombre = '" + nombre + "'"), Conexion.ObtenerConexion());

            comando2.ExecuteNonQuery();

        }

        public static bool Comparar(EditableBLL pEditable)
        {

            MySqlCommand command = new MySqlCommand(/*string.Format("SELECT * from usuarios where(email, password) values('{0}','{1}')", pCliente.Mail, pCliente.Password), Conexion.ObtenerConexion()*/);

            command.Connection = Conexion.ObtenerConexion();
            command.CommandText = "select * from sucursales where (nombre=@user)";
            command.Parameters.AddWithValue("@user", pEditable.Nombre);
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
        public static int AgregarCategoria(EditableBLL pEditable)
        {
            int retorno = 0;
            MySqlCommand comando2 = new MySqlCommand(string.Format("INSERT into categorias(nombre) values('{0}')", pEditable.NombreCategoria), Conexion.ObtenerConexion());

            retorno = comando2.ExecuteNonQuery();

            return retorno;

        }
        public static void EliminarCategoria(string lNombre)
        {
            string nombre = lNombre;

            MySqlCommand comando2 = new MySqlCommand(string.Format("DELETE FROM categorias WHERE nombre = '" + nombre + "'"), Conexion.ObtenerConexion());

            comando2.ExecuteNonQuery();

        }
        public static bool CompararCategoria(EditableBLL pEditable)
        {

            MySqlCommand command = new MySqlCommand(/*string.Format("SELECT * from usuarios where(email, password) values('{0}','{1}')", pCliente.Mail, pCliente.Password), Conexion.ObtenerConexion()*/);

            command.Connection = Conexion.ObtenerConexion();
            command.CommandText = "select * from categorias where (nombre=@user)";
            command.Parameters.AddWithValue("@user", pEditable.NombreCategoria);
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
        
    }
}