using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginPage
{
    public class Conexion
    {

        public static MySqlConnection ObtenerConexion()
        {

            MySqlConnection conectar = new MySqlConnection("server = 127.0.0.1; database = deck; Uid = root; pwd = ;");

            conectar.Open();

            return conectar;
        }



    }
}