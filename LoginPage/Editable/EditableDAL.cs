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
            MySqlCommand comando2 = new MySqlCommand(string.Format("INSERT INTO sucursales(nombre, direccion) values('{0}','{1}')", pEditable.Nombre, pEditable.Direccion), Conexion.ObtenerConexion());

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

            MySqlCommand command = new MySqlCommand();

            command.Connection = Conexion.ObtenerConexion();
            command.CommandText = "SELECT * FROM sucursales WHERE (nombre=@user)";
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
            MySqlCommand comando2 = new MySqlCommand(string.Format("INSERT INTO categorias(nombre) values('{0}')", pEditable.NombreCategoria), Conexion.ObtenerConexion());

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

            MySqlCommand command = new MySqlCommand();

            command.Connection = Conexion.ObtenerConexion();
            command.CommandText = "SELECT * FROM categorias WHERE (nombre=@user)";
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