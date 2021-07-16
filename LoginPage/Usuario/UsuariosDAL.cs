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
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT into register(mail, nombreUsuario, contraseña, reContraseña) values('{0}','{1}' , '{2}' , '{3}' )",  pCliente.Mail, pCliente.User, pCliente.Password, pCliente.rePassword), Conexion.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();

            return retorno;

        }



    }
}