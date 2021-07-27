using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginPage.Productos
{
    public class ProductosBLL
    {

        public string Nombre { get; set; }
        public string Precio { get; set; }
        public string Marcas { get; set; }
        public string Stock { get; set; }
        public string Proveedor { get; set; }
        public string CantidadMinima { get; set; }
        public string CantidadMaxima { get; set; }
        public string Presentacion { get; set; }


        public ProductosBLL()
        {

        }
        public ProductosBLL(string lNombre, string lPrecio, string lMarcas, string lStock, string lProveedor, string lCantidadMinima, string lCantidadMaxima, string lPresentacion)
        {
            this.Nombre = Nombre;
            this.Precio = Precio;
            this.Marcas = Marcas;
            this.Stock = Stock;
            this.Proveedor = Proveedor;
            this.CantidadMinima = CantidadMinima;
            this.CantidadMaxima = CantidadMaxima;
            this.Presentacion = Presentacion;
        }
       

    }
}