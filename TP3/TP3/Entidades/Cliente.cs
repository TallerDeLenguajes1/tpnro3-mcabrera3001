using System;
using System.Collections.Generic;
using System.Text;

namespace TP3
{
    public class Cliente
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
}
