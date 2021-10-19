using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginPage.Editable
{
    public class EditableBLL
    {

        public string Nombre { get; set; }
        public string Direccion { get; set; }
        
        public string NombreCategoria { get; set; }

        public EditableBLL()
        {

        }

        public EditableBLL(string lNombreCategoria)
        {

            this.NombreCategoria = lNombreCategoria;

        }

        public EditableBLL(string lNombre, string lDireccion)
        {

            this.Nombre = lNombre;
            this.Direccion = lDireccion;

        }


    }
}