using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPFacturación3
{
    class Cliente
    {
        public int documento;
        public string nombreCliente;
        public int telefono;
        public int edad;
        public int estado = 1;

        public int Documento { get => documento; set => documento = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
