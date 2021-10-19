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

        public string Sucursal { get; set; }
        public string Fecha { get; set; }

        //variables para recuperar producto

        public int Id { get; set; }
        //
        public string sPrecio { get; set; }
        public string sStock { get; set; }
        public string sCantidadMinima { get; set; }
        public string sCantidadMaxima { get; set; }

        public ProductosBLL()
        {

        }
        public ProductosBLL(string lNombre, int lPrecio, string lMarcas, int lStock, string lProveedor, int lCantidadMinima, int lCantidadMaxima, string lPresentacion, string lSucursal)
        {
            this.Nombre = lNombre;
            this.Precio = lPrecio;
            this.Marcas = lMarcas;
            this.Stock = lStock;
            this.Proveedor = lProveedor;
            this.CantidadMinima = lCantidadMinima;
            this.CantidadMaxima = lCantidadMaxima;
            this.Presentacion = lPresentacion;
            this.Sucursal = lSucursal;

        }

        public ProductosBLL(string lNombre, int lPrecio, string lMarcas, int lStock, string lProveedor, int lCantidadMinima, int lCantidadMaxima, string lPresentacion, string lSucursal, string lFecha)
        {
            this.Nombre = lNombre;
            this.Precio = lPrecio;
            this.Marcas = lMarcas;
            this.Stock = lStock;
            this.Proveedor = lProveedor;
            this.CantidadMinima = lCantidadMinima;
            this.CantidadMaxima = lCantidadMaxima;
            this.Presentacion = lPresentacion;
            this.Sucursal = lSucursal;
            this.Fecha = lFecha;

        }

        public ProductosBLL(string lPrecio, string lMarcas, string lStock, string lCantidadMinima, string lCantidadMaxima, string lPresentacion, string lSucursal)
        {
            this.sPrecio = lPrecio;
            this.Marcas = lMarcas;
            this.sStock = lStock;
            this.sCantidadMinima = lCantidadMinima;
            this.sCantidadMaxima = lCantidadMaxima;
            this.Presentacion = lPresentacion;
            this.Sucursal = lSucursal;

        }
        
        public ProductosBLL(string lNombre, string lProveedor, string lPrecio, string lMarcas, string lStock, string lCantidadMinima, string lCantidadMaxima, string lPresentacion, string lSucursal)
        {
            this.Nombre = lNombre;
            this.Proveedor = lProveedor;
            this.sPrecio = lPrecio;
            this.Marcas = lMarcas;
            this.sStock = lStock;
            this.sCantidadMinima = lCantidadMinima;
            this.sCantidadMaxima = lCantidadMaxima;
            this.Presentacion = lPresentacion;
            this.Sucursal = lSucursal;

        }
        public ProductosBLL(int lId, string lNombre, int lPrecio, string lMarcas, int lStock, string lProveedor, int lCantidadMinima, int lCantidadMaxima, string lPresentacion, string lSucursal, string lFecha)
        {
            this.Id = lId;
            this.Nombre = lNombre;
            this.Proveedor = lProveedor;
            this.Precio = lPrecio;
            this.Marcas = lMarcas;
            this.Stock = lStock;
            this.CantidadMinima = lCantidadMinima;
            this.CantidadMaxima = lCantidadMaxima;
            this.Presentacion = lPresentacion;
            this.Sucursal = lSucursal;
            this.Fecha = lFecha;

        }

    }
}