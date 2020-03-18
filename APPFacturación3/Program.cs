using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPFacturación3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> listaClientes = new List<Cliente>();
            List<Factura> listaFacturas = new List<Factura>();
            List<Producto> listaProductos = new List<Producto>();
           
            string seguir = "si";
            int doc;
            string datoModificar;
            int idFactura = 0;
            bool resp = true;


            while (seguir != "no")
            {
                int respuestaInicio;
                Console.WriteLine("Elija una opción");
                Console.WriteLine("(1) para gestion de clientes (2) para gestion de productos (3) para facturación (4) Gestión de reportes (5) Para salir del programa");
                respuestaInicio = int.Parse(Console.ReadLine());

                if (respuestaInicio == 1)
                {
                    //gestion clientes:

                    int rtaCliente;
                    Console.WriteLine("(1) Agregar Cliente (2) Modificar cliente (3) cambiar estado cliente (4) Listar Clientes (5) salir del modulo clientes.");
                    rtaCliente = int.Parse(Console.ReadLine());

                    if (rtaCliente == 1)
                    {
                        //TODO: agregar cliente
                        Cliente cliente = new Cliente();

                        Console.WriteLine("Ingrese el documento del cliente");
                        cliente.documento = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el nombre del cliente");
                        cliente.nombreCliente = Console.ReadLine();
                        Console.WriteLine("Ingrese el telefono");
                        cliente.telefono = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la edad del cliente");
                        cliente.edad = int.Parse(Console.ReadLine());


                        listaClientes.Add(cliente);
                    }
                    else if (rtaCliente == 2)
                    {
                        //TODO: modificar cliente

                        Console.WriteLine("Digite el documento del cliente a modificar");
                        doc = int.Parse(Console.ReadLine());

                        for (int i = 0; i < listaClientes.Count; i++)
                        {
                            if (doc == listaClientes[i].documento && listaClientes[i].estado == 1)
                            {
                                Console.WriteLine("Desea modificar: nombre, edad o telefono");
                                datoModificar = Console.ReadLine();
                                switch (datoModificar)
                                {
                                    case "nombre":
                                        Console.WriteLine("Ingrese el nuevo nombre");
                                        string nomCliente = Console.ReadLine();
                                        listaClientes[i].nombreCliente = nomCliente;
                                        break;
                                    case "edad":
                                        Console.WriteLine("Ingrese la nueva edad");
                                        int edadCliente = int.Parse(Console.ReadLine());
                                        listaClientes[i].edad = edadCliente;
                                        break;
                                    case "telefono":
                                        Console.WriteLine("Ingrese el nuevo telefono");
                                        int telCliente = int.Parse(Console.ReadLine());
                                        listaClientes[i].telefono = telCliente;
                                        break;
                                }
                            }
                        }
                    }
                    else if (rtaCliente == 3)
                    {
                        //TODO: cambiar estado cliente
                        Console.WriteLine("Digite el documento del cliente a modificar el estado");
                        doc = int.Parse(Console.ReadLine());
                        for (int i = 0; i < listaClientes.Count; i++)
                        {
                            if (doc == listaClientes[i].documento)
                            {
                                Console.WriteLine("Estado modificar: (1) para habilitar o (0) para deshabilitar");
                                int estadoModificar = int.Parse(Console.ReadLine());
                                switch (estadoModificar)
                                {
                                    case 1:
                                        listaClientes[i].estado = estadoModificar;
                                        break;
                                    case 0:

                                        listaClientes[i].estado = estadoModificar;
                                        break;
                                }
                            }
                        }
                    }
                    else if (rtaCliente == 4)
                    {
                        //TODO: listar clientes

                        int rtaListar;
                        Console.WriteLine("(1) listar clientes por documento (2) listar todos los clientes.");
                        rtaListar = int.Parse(Console.ReadLine());

                        if (rtaListar == 1)
                        {
                            //listar por documento

                            Console.WriteLine("Ingrese el numero del documento");
                            doc = int.Parse(Console.ReadLine());

                            foreach (var client in listaClientes)
                            {
                                if (client.documento == doc)
                                {
                                    Console.WriteLine("nombre: " + client.NombreCliente
                                   + " documento: " + client.Documento
                                   + " telefono: " + client.Telefono
                                   + " edad: " + client.Edad
                                   + " estado: " + client.Estado);
                                }
                            }
                        }
                        else if (rtaListar == 2)
                        {
                            //listar todos los clientes

                            foreach (Cliente client in listaClientes)
                            {
                                Console.WriteLine("nombre: " + client.NombreCliente
                                        + " documento: " + client.Documento
                                        + " telefono: " + client.Telefono
                                        + " edad: " + client.Edad
                                        + " estado: " + client.Estado);
                            }

                        }
                    }
                }

                else if (respuestaInicio == 2)
                {
                    //gestion productos
                    int rtaProductos;
                    Console.WriteLine("(1) Agregar Producto (2) Modificar estado de Producto (3) Modificar producto (4) listar Producto");
                    rtaProductos = int.Parse(Console.ReadLine());

                    if (rtaProductos == 1)
                    {
                        //Agregar producto
                        Producto producto = new Producto();

                        Console.WriteLine("Ingrese el codigo del producto");
                        producto.idProducto = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el nombre del producto");
                        producto.nombreProducto = Console.ReadLine();
                        Console.WriteLine("Ingrese el valor del producto");
                        producto.valor = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el stock del producto");
                        producto.stock = int.Parse(Console.ReadLine());

                        listaProductos.Add(producto);
                    }
                    else if (rtaProductos == 2)
                    {
                        //Modificar estado producto

                        Console.WriteLine("Ingrese el codigo del producto a cambiar de estado");
                        int codModificar = int.Parse(Console.ReadLine());

                        for (int i = 0; i < listaProductos.Count; i++)
                        {
                            if (codModificar == listaProductos[i].idProducto)
                            {
                                Console.WriteLine("(0) para deshabilitar producto, (1) para habilitar");
                                int cambEstadoP = int.Parse(Console.ReadLine());
                                switch (cambEstadoP)
                                {
                                    case 1:
                                        listaProductos[i].estadoProducto = cambEstadoP;
                                        break;
                                    case 0:
                                        listaProductos[i].estadoProducto = cambEstadoP;
                                        break;
                                }
                            }
                        }
                    }

                    else if (rtaProductos == 3)
                    {
                        //Modificar producto
                        Console.WriteLine("Digite el codigo del producto a modificar");
                        doc = int.Parse(Console.ReadLine());

                        for (int i = 0; i < listaProductos.Count; i++)
                        {
                            if (doc == listaProductos[i].IdProducto)
                            {

                                Console.WriteLine("Desea modificar: nombre, precio o stock");
                                datoModificar = Console.ReadLine();
                                switch (datoModificar)
                                {
                                    case "nombre":
                                        Console.WriteLine("Ingrese el nuevo nombre del producto");
                                        string nomProducto = Console.ReadLine();
                                        listaProductos[i].nombreProducto = nomProducto;
                                        break;
                                    case "precio":
                                        Console.WriteLine("Ingrese el nuevo precio");
                                        int precioProducto = int.Parse(Console.ReadLine());
                                        listaProductos[i].valor = precioProducto;
                                        break;
                                    case "stock":
                                        Console.WriteLine("Ingrese el nuevo stock");
                                        int stockproduct = int.Parse(Console.ReadLine());
                                        listaProductos[i].stock = stockproduct;
                                        break;
                                }
                            }
                        }
                    }
                    else if (rtaProductos == 4)
                    {
                        //Listar producto

                        int rtaListar;
                        Console.WriteLine("(1) listar producto por id (2) listar todos los productos.");
                        rtaListar = int.Parse(Console.ReadLine());

                        if (rtaListar == 1)
                        {
                            //listar por id producto
                            Producto producto = new Producto();

                            Console.WriteLine("Ingrese el numero del id");
                            doc = int.Parse(Console.ReadLine());

                            foreach (var product in listaProductos)
                            {
                                if (product.idProducto == doc)
                                {
                                    Console.WriteLine("codigo producto: " + product.IdProducto
                                   + " nombre: " + product.NombreProducto
                                   + " valor: " + product.Valor
                                   + " stock: " + product.Stock
                                   + " estado: " + product.EstadoProducto);
                                }
                            }
                        }
                        else if (rtaListar == 2)
                        {
                            //listar todos los productos

                            foreach (Producto product in listaProductos)
                            {
                                Console.WriteLine("codigo producto: " + product.IdProducto
                                   + " nombre: " + product.NombreProducto
                                   + " valor: " + product.Valor
                                   + " stock: " + product.Stock
                                   + " estado: " + product.EstadoProducto);
                            }

                        }
                    }
                }
               
                else if (respuestaInicio == 3)
                {
                    //facturar
                    Cliente clienteFactura = new Cliente();
                    

                    int rtaFacturar;
                    string rtaFactura;


                    Console.WriteLine("(1) Agregar Factura (2) listar facturas");
                    rtaFacturar = int.Parse(Console.ReadLine());

                    if (rtaFacturar == 1)
                    {
                        resp = true;

                        while (resp)
                        {
                            Factura nuevaFactura = new Factura();
                            idFactura++;
                            nuevaFactura.IdFactura = idFactura;
                            int idProducto;

                            Console.WriteLine("Ingrese la fecha");
                            string fecha = Console.ReadLine();

                            nuevaFactura.Fecha = fecha;

                            //datos del cliente:

                            Console.WriteLine("ingrese el id del cliente");
                            int idCliente = int.Parse(Console.ReadLine());

                            for (int i = 0; i < listaClientes.Count; i++)
                            {
                                if (idCliente == listaClientes[i].documento)
                                {
                                    nuevaFactura.IdCliente = listaClientes[i].documento;
                                    nuevaFactura.NombreCliente = listaClientes[i].NombreCliente;
                                    Console.WriteLine("datos agregados...");
                                }

                                
                            }

                           
                            bool agregar = true;
                            while (agregar)
                            {
                                //agrego producto a listaFacturas:
                                Producto producto = new Producto();

                                Console.WriteLine("ingrese el codigo del producto");
                                idProducto = int.Parse(Console.ReadLine());

                                for (int p = 0; p < listaProductos.Count; p++)
                                {

                                    if (idProducto == listaProductos[p].idProducto)
                                    {
                                        Console.WriteLine("Ingrese la cantidad ");
                                        int cantidad = int.Parse(Console.ReadLine());
                                        producto.IdProducto = listaProductos[p].idProducto;
                                        producto.NombreProducto = listaProductos[p].nombreProducto;
                                        if (listaProductos[p].stock < cantidad)
                                        {
                                            Console.WriteLine("No hay stock suficientes, hay: " + listaProductos[p].Stock);
                                        }
                                        else if (listaProductos[p].stock > 0)
                                        {
                                            producto.CantidadVendida = cantidad;
                                            producto.Stock = listaProductos[p].inventario(producto.CantidadVendida);

                                            //Actualizo stock en listaProductos:
                                            listaProductos[p].Stock = producto.Stock;

                                            producto.Valor = listaProductos[p].Valor;

                                            //sacor valor total por producto
                                            nuevaFactura.SubtotalProducto = nuevaFactura.PrecioXCantidad(producto.CantidadVendida, producto.Valor);

                                            //saco valor total por factura
                                            nuevaFactura.TotalFactura = nuevaFactura.totalFactura + nuevaFactura.SubtotalProducto;
                                        }
                                        else if (listaProductos[p].stock == 0)
                                        {
                                            Console.WriteLine("no hay productos");
                                        }
                                        else if (idProducto != listaProductos[p].idProducto)
                                        {
                                            Console.WriteLine("El producto no existe en inventario");
                                        }

                                        nuevaFactura.listaProductos.Add(producto);
                                        

                                        Console.WriteLine("desea agregar mas productos???");
                                        rtaFactura = Console.ReadLine();

                                        if (rtaFactura.Equals("si"))
                                        {
                                            agregar = true;
                                        }
                                        else if (rtaFactura.Equals("no"))
                                        {
                                            agregar = false;
                                        }
                                    }
                                }
                            }
                            
                            listaFacturas.Add(nuevaFactura);
                          
                            Console.WriteLine("desea agregar mas facturas???");
                            string masFacturas = Console.ReadLine();

                            if (masFacturas.Equals("si"))
                            {
                                resp = true;
                            }
                            else if (masFacturas.Equals("no"))
                            {
                                resp = false;
                            }
                        }

                    }
                    else if (rtaFacturar == 2)
                    {
                        //listar las facturas por codigo
                        Console.WriteLine("(1) para listar por codigo factura (2) todas las facturas");
                        int rta = int.Parse(Console.ReadLine());
                        if (rta == 1)
                        {
                            Console.WriteLine("Ingrese el numero de la factura");
                            doc = int.Parse(Console.ReadLine());


                            foreach (var factura in listaFacturas)
                            {
                                if (doc == factura.idFactura)
                                {
                                    Console.WriteLine("----------Encabezado Factura----------");
                                    Console.WriteLine("Numero de factura : " + factura.idFactura
                                        + " Fecha: " + factura.fecha + " Cliente: " + factura.nombreCliente
                                        + " Total factura: " + factura.totalFactura );

                                    Console.WriteLine("----------Detalle Factura----------");

                                    foreach (Producto producto in factura.listaProductos)
                                    {
                                        Console.WriteLine("NombreProducto: " + producto.NombreProducto
                                            + " Cantidad: " + producto.CantidadVendida + " Valor Unitario: $"
                                            + producto.Valor + " SubTotal: $" + ( producto.CantidadVendida * producto.Valor) );
                                        
                                    }
                                }
                            }


                        }
                        else if (rta == 2)
                        {
                            //listar todas las facturas

                            foreach (Factura factura in listaFacturas)
                            {
                                Console.WriteLine("----------Encabezado Factura----------");
                                    Console.WriteLine("Numero de factura : " + factura.idFactura
                                        + " Fecha: " + factura.fecha + " Cliente: " + factura.nombreCliente
                                        + " Total factura: " + factura.totalFactura );

                                    Console.WriteLine("----------Detalle Factura----------");

                                    foreach (Producto producto in factura.listaProductos)
                                    {
                                        Console.WriteLine("NombreProducto: " + producto.NombreProducto
                                            + " Cantidad: " + producto.CantidadVendida + " Valor Unitario: $"
                                            + producto.Valor + " SubTotal: $" + ( producto.CantidadVendida * producto.Valor) );
                                        
                                    }
                                Console.WriteLine("");
                                Console.WriteLine("----------------------------------------------");
                                Console.WriteLine("");
                            }
                            
                        }
                    }
                }
                else if (respuestaInicio == 4)
                {
                    //reportes
                    int rtaReportes;
                    Console.WriteLine("(1) Clientes > 30 años (2) Producto con Stock<2 (3) Facturas>200.000$.");
                    rtaReportes = int.Parse(Console.ReadLine());

                    if (rtaReportes == 1)
                    {
                        Console.WriteLine("Los clientes mayores a 30 años son: ");

                        foreach (Cliente client in listaClientes)
                        {
                            if (client.edad >= 30)
                            {
                                Console.WriteLine("nombre: " + client.NombreCliente
                                                    + " documento: " + client.Documento
                                                    + " telefono: " + client.Telefono
                                                    + " edad: " + client.Edad
                                                    + " estado: " + client.Estado);

                            }

                        }
                        Console.WriteLine("");
                    }
                    else if (rtaReportes == 2)
                    {
                        Console.WriteLine("Los productos con <2 Stock son: ");

                        foreach (Producto product in listaProductos)
                        {
                            if (product.stock <= 2)
                            {
                                Console.WriteLine("codigo producto: " + product.IdProducto
                               + " nombre: " + product.NombreProducto
                               + " valor: " + product.Valor
                               + " stock: " + product.Stock
                               + " estado: " + product.EstadoProducto);
                            }
                        }
                        Console.WriteLine("");

                    }
                    else if (rtaReportes == 3)
                    {
                        Console.WriteLine("Las facturas mayores a $200.000 son: ");

                        foreach (Factura factur in listaFacturas)
                        {
                            if (factur.totalFactura >= 200000)
                            {
                                Console.WriteLine("Id Factura: " + factur.IdFactura
                                    + " Fecha: " + factur.Fecha
                                    + " Total Factura: " + factur.totalFactura);
                            }
                        }
                    }
                }
                Console.WriteLine("desea volver al menú principal para cambiar de módulo?");
                string rtaSeguir = Console.ReadLine();

                if (rtaSeguir.Equals("no"))
                {
                    seguir = "no";
                }
            }
        }
    }
    }

