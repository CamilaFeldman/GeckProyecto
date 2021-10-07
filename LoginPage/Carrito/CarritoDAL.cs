using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LoginPage.Carrito
{
    public class CarritoDAL
    {

        public static void AgregarCarrito(string Nombre, int Stock, string Sucursal, int Precio, int PrecioFinal)
        {

            MySqlCommand comando = new MySqlCommand(string.Format("INSERT into carrito(nombre, cantidad, sucursal, precio_unitario, precio_final) values('{0}','{1}' , '{2}', '{3}', '{4}')", Nombre, Stock, Sucursal, Precio, PrecioFinal), Conexion.ObtenerConexion());

            comando.ExecuteNonQuery();

        }

        public static void AgregarMovimientos(string Nombre, int Cantidad, string Sucursal, int Precio)
        {

            MySqlCommand comando = new MySqlCommand(string.Format("INSERT into movimientos(nombre, cantidad, sucursal, precio_unitario, fecha) values('{0}','{1}' , '{2}', '{3}', '{4}')", Nombre, Cantidad, Sucursal, Precio, DateTime.Now.ToString()), Conexion.ObtenerConexion());

            comando.ExecuteNonQuery();

        }
        public static void EliminarCarrito()
        {

            MySqlCommand comando3 = new MySqlCommand(string.Format("DELETE FROM carrito"), Conexion.ObtenerConexion());

            comando3.ExecuteNonQuery();


        }

        public static bool CompararProducto(string idProducto)
        {

            MySqlCommand command = new MySqlCommand();

            command.Connection = Conexion.ObtenerConexion();
            command.CommandText = "SELECT * FROM carrito where (nombre=@user)";
            command.Parameters.AddWithValue("@user", idProducto);
            command.CommandType = CommandType.Text;


            MySqlDataReader reader;

            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public static bool VerificarStock(string lNombre, string lSucursal, int lCantidad)
        {

            MySqlCommand command = new MySqlCommand();

            command.Connection = Conexion.ObtenerConexion();
            command.CommandText = "SELECT stock FROM producto_especifico WHERE (nombre=@producto AND sucursal=@sucursal)";
            command.Parameters.AddWithValue("@producto", lNombre);
            command.Parameters.AddWithValue("@sucursal", lSucursal);
            command.CommandType = CommandType.Text;


            MySqlDataReader reader;

            reader = command.ExecuteReader();
            if (reader.Read())
            {

                int Stock = Convert.ToInt32(reader["stock"].ToString());
                int StockRestante = Stock - lCantidad;
                if(StockRestante > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

                
            }
            else
            {
                return false;
            }

        }

        public static void RestarStock(string lNombre, string lSucursal, int lCantidad)
        {

            string nombre = lNombre;
            string sucursal = lSucursal;
            int cantidad = lCantidad;

            MySqlCommand command = new MySqlCommand();

            command.Connection = Conexion.ObtenerConexion();
            command.CommandText = "UPDATE producto_especifico SET stock = stock-@cantventa WHERE (nombre=@producto AND sucursal=@sucursal)";
            command.Parameters.AddWithValue("@producto", nombre );
            command.Parameters.AddWithValue("@sucursal", sucursal);
            command.Parameters.AddWithValue("@cantventa", cantidad);
            command.CommandType = CommandType.Text;


            command.ExecuteNonQuery();

        }

    }
}