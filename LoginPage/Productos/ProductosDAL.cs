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
            command.CommandText = "select * from producto_especifico where (nombre=@user && proveedor=@proveedor)";
            command.Parameters.AddWithValue("@user", idProducto);
            command.Parameters.AddWithValue("@proveedor", idProveedor);
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


        public static ProductosBLL Editar(string idProducto, string idProveedor)
        {

            MySqlCommand command = new MySqlCommand(/*string.Format("SELECT * from usuarios where(email, password) values('{0}','{1}')", pCliente.Mail, pCliente.Password), Conexion.ObtenerConexion()*/);

            command.Connection = Conexion.ObtenerConexion();
            command.CommandText = "select * from producto_especifico where (nombre=@user && proveedor=@proveedor)";
            command.Parameters.AddWithValue("@user", idProducto);
            command.Parameters.AddWithValue("@proveedor", idProveedor);
            command.CommandType = CommandType.Text;

            // try
            //{
            MySqlDataReader reader;

            reader = command.ExecuteReader();
            if (reader.Read())
            {

                string Precio = reader["precio"].ToString();
                string Categoria = reader["marcas"].ToString();
                string Stock = reader["stock"].ToString();
                string CantidadMinima = reader["cant_min"].ToString();
                string CantidadMaxima = reader["cant_max"].ToString();
                string PresentacionComercial = reader["presentacion"].ToString();
                string Sucursal = reader["sucursal"].ToString();

                ProductosBLL recProducto = new ProductosBLL(Precio, Categoria, Stock, CantidadMinima, CantidadMaxima, PresentacionComercial, Sucursal);

                return recProducto;
            }
            else
            {
                ProductosBLL Nada = new ProductosBLL();
                return Nada;
            }

            // }
            // catch (Exception)
            //{
            //    return "";
            //}


        }
        public static void Eliminar(string lNombre, string lProveedor)
        {
            string nombre = lNombre;
            string proveedor = lProveedor;

            MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM producto_especifico WHERE nombre = '" + nombre + "' &&  proveedor = '" + proveedor + "'"), Conexion.ObtenerConexion());

            comando.ExecuteNonQuery();

        }
        
        public static void Actualizar(ProductosBLL pProductos)
        {

            MySqlCommand command = new MySqlCommand(/*string.Format("SELECT * from usuarios where(email, password) values('{0}','{1}')", pCliente.Mail, pCliente.Password), Conexion.ObtenerConexion()*/);

            command.Connection = Conexion.ObtenerConexion();       
            command.CommandText = "UPDATE producto_especifico SET nombre=@nombre, precio=@precio, marcas=@marcas, stock=@stock, proveedor=@proveedor, cant_min=@cant_min, cant_max=@cant_max, presentacion=@presentacion, sucursal=@sucursal where (id=@id)";
            command.Parameters.AddWithValue("@id", pProductos.Id);
            command.Parameters.AddWithValue("@nombre", pProductos.Nombre);
            command.Parameters.AddWithValue("@precio", pProductos.Precio);
            command.Parameters.AddWithValue("@marcas", pProductos.Marcas);
            command.Parameters.AddWithValue("@stock", pProductos.Stock);
            command.Parameters.AddWithValue("@proveedor", pProductos.Proveedor);
            command.Parameters.AddWithValue("@cant_min", pProductos.CantidadMinima);
            command.Parameters.AddWithValue("@cant_max", pProductos.CantidadMaxima);
            command.Parameters.AddWithValue("@presentacion", pProductos.Presentacion);
            command.Parameters.AddWithValue("@sucursal", pProductos.Sucursal);
            command.CommandType = CommandType.Text;


            MySqlDataReader reader;

            reader = command.ExecuteReader();
            /*if (reader.Read())
            {
                string Nombre = reader["nombre"].ToString();
                string Proveedor = reader["proveedor"].ToString();
                string Precio = reader["precio"].ToString();
                string Categoria = reader["marcas"].ToString();
                string Stock = reader["stock"].ToString();
                string CantidadMinima = reader["cant_min"].ToString();
                string CantidadMaxima = reader["cant_max"].ToString();
                string PresentacionComercial = reader["presentacion"].ToString();
                string Sucursal = reader["sucursal"].ToString();

                ProductosBLL recProducto = new ProductosBLL(Nombre, Proveedor, Precio, Categoria, Stock, CantidadMinima, CantidadMaxima, PresentacionComercial, Sucursal);

                return recProducto;
            }
            else
            {
                ProductosBLL Nada = new ProductosBLL();
                return Nada;
            }
            */


        }
    }

}