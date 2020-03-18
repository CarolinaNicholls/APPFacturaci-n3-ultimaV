using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPFacturación3
{
    class Producto
    {
        public int idProducto;
        public string nombreProducto;
        public int stock;
        public int valor;
        public int estadoProducto = 1;
        public int cantidadVendida;

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int Stock { get => stock; set => stock = value; }
        public int Valor { get => valor; set => valor = value; }
        public int EstadoProducto { get => estadoProducto; set => estadoProducto = value; }
        public int CantidadVendida { get => cantidadVendida; set => cantidadVendida = value; }

        public int valorTotalProd(int cantidad, int valor)
        {
            return this.valor * this.cantidadVendida;
        }

        public int inventario(int cantidadCliente)
        {
            return this.stock - cantidadCliente;
        }
    }
}
