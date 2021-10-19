using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginPage.Proveedores
{
    public class ProveedoresBLL
    {

        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public ProveedoresBLL()
        {

        }

        public ProveedoresBLL(string lNombre, string lDireccion, string lTelefono, string lEmail)
        {

            this.Nombre = lNombre;
            this.Direccion = lDireccion;
            this.Telefono = lTelefono;
            this.Email = lEmail;

        }

    }
}