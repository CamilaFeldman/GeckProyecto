using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginPage.Productos
{
    public class ProductosBLL
    {

        public string Nombre { get; set; }
        public int Precio { get; set; }
        public string Marcas { get; set; }
        public int Stock { get; set; }
        public string Proveedor { get; set; }
        public int CantidadMinima { get; set; }
        public int CantidadMaxima { get; set; }
        public string Presentacion { get; set; }


        public ProductosBLL()
        {

        }
        public ProductosBLL(string lNombre, int lPrecio, string lMarcas, int lStock, string lProveedor, int lCantidadMinima, int lCantidadMaxima, string lPresentacion)
        {
            this.Nombre = lNombre;
            this.Precio = lPrecio;
            this.Marcas = lMarcas;
            this.Stock = lStock;
            this.Proveedor = lProveedor;
            this.CantidadMinima = lCantidadMinima;
            this.CantidadMaxima = lCantidadMaxima;
            this.Presentacion = lPresentacion;
        }
       

    }
}