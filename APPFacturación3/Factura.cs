using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPFacturación3
{
    class Factura
    {
        //datos del cliente
        public int idFactura;
        public int idCliente;
        public string nombreCliente;
        public string fecha;

        //datos del productos

        public int idProducto;
        public string nombreProducto;
        public int stock;
        public int valor;
        public int subtotalProducto = 0;
        public int estadoProducto = 1;
        public int cantidadVendida;

        public int totalFactura = 0;

        public List<Cliente> listaClientes = new List<Cliente>();
        public List<Producto> listaProductos = new List<Producto>();
        public List<Factura> listaFactura = new List<Factura>();

        public int IdFactura { get => idFactura; set => idFactura = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public int TotalFactura { get => totalFactura; set => totalFactura = value; }

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int Stock { get => stock; set => stock = value; }
        public int Valor { get => valor; set => valor = value; }

        public int SubtotalProducto { get => subtotalProducto; set => subtotalProducto = value; }
        public int EstadoProducto { get => estadoProducto; set => estadoProducto = value; }
        public int CantidadVendida { get => cantidadVendida; set => cantidadVendida = value; }

        public int PrecioXCantidad(int cantidad, int precio)
        {
            return cantidad * precio;
        }

    }
}
