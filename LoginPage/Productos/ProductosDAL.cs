using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LoginPage.Productos
{
    public class ProductosDAL
    {

        public static int Agregar(ProductosBLL pProductos)
        {
            int retorno = 0;
            MySqlCommand comando2 = new MySqlCommand(string.Format("INSERT into producto_especifico(nombre, precio, marcas, stock, proveedor, cant_min, cant_max, presentacion, sucursal) values('{0}','{1}' , '{2}', '{3}','{4}' , '{5}', '{6}', '{7}', '{8}')", pProductos.Nombre, pProductos.Precio, pProductos.Marcas, pProductos.Stock, pProductos.Proveedor, pProductos.CantidadMinima, pProductos.CantidadMaxima, pProductos.Presentacion, pProductos.Sucursal), Conexion.ObtenerConexion());

            retorno = comando2.ExecuteNonQuery();

            return retorno;

        }


        public static bool CompararProducto(string idProducto, string idProveedor)
        {

            MySqlCommand command = new MySqlCommand(/*string.Format("SELECT * from usuarios where(email, password) values('{0}','{1}')", pCliente.Mail, pCliente.Password), Conexion.ObtenerConexion()*/);

            command.Connection = Conexion.ObtenerConexion();
            command.CommandText = "select * from productos where (nombre=@user && proveedor=@proveedor)";
            command.Parameters.AddWithValue("@user", idProducto);
            command.Parameters.AddWithValue("@proveedor", idProveedor);
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