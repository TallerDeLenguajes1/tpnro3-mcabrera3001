using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TP3
{
    

    enum Estado
    {
        enviado,
        entregado,
    };
    class Cadeteria
    {
        string nombre;
        List<Cadete> cadetes;

        public string Nombre { get => nombre; set => nombre = value; }
        public List<Cadete> Cadetes { get => cadetes; set => cadetes = value; }

        public Cadeteria(string Nombre)
        {
            this.Nombre = Nombre;
            Cadetes = new List<Cadete>();
        }

        public void agregarCadetes(Cadete nuevoCadete)
        {
            Cadetes.Add(nuevoCadete);
        }
    }

    class Pedido
    {
        int nroPedido;
        string observaciones;
        Estado estadoPedido;

        public int NroPedido { get => nroPedido; set => nroPedido = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public Estado EstadoPedido { get => estadoPedido; set => estadoPedido = value; }

        Random rand = new Random();
        public Pedido(int nro, int idCliente, string nombreCliente, string direccionCliente, int celularCliente)
        {
            nroPedido = nro;
            estadoPedido = Estado.enviado;
            Cliente nuevoCliente = new Cliente(idCliente, nombreCliente, direccionCliente, celularCliente);
        }
    }

    class Cliente
    {
        int idCliente;
        string nombreCliente;
        string direccionCliente;
        int celularCliente;

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string DireccionCliente { get => DireccionCliente; set => DireccionCliente = value; }
        public int CelularCliente { get => celularCliente; set => celularCliente = value; }

        public Cliente(int idCliente, string nombreCliente, string direccionCliente, int celularCliente)
        {
            this.celularCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.direccionCliente = direccionCliente;
            this.celularCliente = celularCliente;
        }
    }
    class Cadete
    {
        int idCadete;
        string nombreCadete;
        string direccionCadete;
        int celularCadete;
        List<Pedido> pedidos;
 

        public int IdCadete { get => idCadete; set => idCadete = value; }
        public string NombreCadete { get => nombreCadete; set => nombreCadete = value; }
        public string DireccionCadete { get => direccionCadete; set => direccionCadete = value; }
        public int CelularCadete { get => celularCadete; set => celularCadete = value; }
        internal List<Pedido> Pedidos { get => pedidos; set => pedidos = value; }

        public Cadete(int idCadete, string nombreCadete , string direccionCadete, int CelularCadete)
        {
            this.IdCadete = idCadete;
            this.NombreCadete = nombreCadete;
            this.DireccionCadete = direccionCadete;
            this.celularCadete = CelularCadete;

        }

        public void agregarPedidos(Pedido nuevoPedido)
        {
            Pedidos.Add(nuevoPedido);
        }


    }
}
