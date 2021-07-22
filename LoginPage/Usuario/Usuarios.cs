using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginPage.Usuario
{
    public class Usuarios
    {

        public string Mail { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string rePassword { get; set; }

        public Usuarios() { }

        public Usuarios(string lMail, string lUser, string lPassword, string lrePassword)
        {

            this.Mail = lMail;
            this.User = lUser;
            this.Password = lPassword;
            this.rePassword = lrePassword;



        }

        public Usuarios(string lMail, string lPassword)
        {
            this.Mail = lMail;
            this.Password = lPassword;
        }

    }
}