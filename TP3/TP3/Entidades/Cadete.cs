using System;
using System.Collections.Generic;
using System.Text;


namespace TP3
{
    public class Cadete
    {
        int idCadete;
        string nombreCadete;
        string direccionCadete;
        int celularCadete;
        int cantidadaPedidos;
        List<Pedido> listaDePedidos;


        public int IdCadete { get => idCadete; set => idCadete = value; }
        public string NombreCadete { get => nombreCadete; set => nombreCadete = value; }
        public string DireccionCadete { get => direccionCadete; set => direccionCadete = value; }
        public int CelularCadete { get => celularCadete; set => celularCadete = value; }
        public int CantidadaPedidos { get => cantidadaPedidos; set => cantidadaPedidos = value; }
        public List<Pedido> ListaDePedidos { get => listaDePedidos; set => listaDePedidos = value; }

        public Cadete(int idCadete, string nombreCadete, string direccionCadete, int CelularCadete)
        {
            this.IdCadete = idCadete;
            this.NombreCadete = nombreCadete;
            this.DireccionCadete = direccionCadete;
            this.celularCadete = CelularCadete;
            this.CantidadaPedidos = cantidadaPedidos;
            ListaDePedidos = new List<Pedido>();
        }

        public void agregarPedidos(Pedido nuevoPedido)
        {
            CantidadaPedidos++;
            ListaDePedidos.Add(nuevoPedido);
        }
        public void quitarPedidos(int pedido)
        {
            cantidadaPedidos--;

        }
    }
}
