using System;
using System.Collections.Generic;
using System.Text;

namespace TP3
{
    public enum Estado
    {
        pendiente,
        entregado,
    };

    public class Pedido
    {
        int nroPedido;
        string observaciones;
        Estado estadoPedido;
        Cliente nuevoCliente;

        public int NroPedido { get => nroPedido; set => nroPedido = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public Estado EstadoPedido { get => estadoPedido; set => estadoPedido = value; }
        public Cliente Cliente { get => nuevoCliente; set => nuevoCliente = value; }

        Random rand = new Random();
        public Pedido(int nro, int idCliente, string nombreCliente, string direccionCliente, int celularCliente)
        {
            nroPedido = nro;
            estadoPedido = Estado.pendiente;
            Cliente = new Cliente(idCliente, nombreCliente, direccionCliente, celularCliente);
        }
    }
}
