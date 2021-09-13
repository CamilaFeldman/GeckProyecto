using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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

        public static void EliminarCarrito()
        {

            MySqlCommand comando3 = new MySqlCommand(string.Format("DELETE FROM carrito"), Conexion.ObtenerConexion());

            comando3.ExecuteNonQuery();


        }

    }
}