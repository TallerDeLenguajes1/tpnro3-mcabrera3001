using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "Pedro", "Juan", "Maria", "Romina", "Horacio", "Oscar", "Walter", "Rodrigo" };
            string[] direcciones = { "BarrioNorte", "ZonaSur", "Manatial", "LaBanda", "Alderetes" };

            List<Cadete> cadetes = new List<Cadete>();
            Cadete nuevoCadete;
            Pedido nuevoPedido;
            List<Pedido> pedidos = new List<Pedido>();
            
            Random rand = new Random();

            //creo los cadetes, los agrego a la lista y luego los agrego a la cadeteria
            for (int i = 0; i < 3; i++)
            {
                nuevoCadete = new Cadete(i, nombres[rand.Next(7)], direcciones[rand.Next(4)], rand.Next(155000000, 157000000), pedidos);
                cadetes.Add(nuevoCadete);
            }
            Cadeteria Rappi = new Cadeteria("Rappi", cadetes);

            //creo los pedidos, junto con el cliente y los agrego a la lista de cada cadete
            for (int i = 0; i < 10; i++)
            {
                nuevoPedido = new Pedido(i, i, nombres[rand.Next(7)], direcciones[rand.Next(4)], rand.Next(155000000, 157000000));
                cadetes[rand.Next(1,3)].agregarPedidos(nuevoPedido);
            }

            foreach (Cadete cadeteX in cadetes)
            {
                Console.WriteLine("Nombre Cadete: " + cadeteX.NombreCadete);
                Console.WriteLine("Cantidad de Pedidos: " + cadeteX.CantidadaPedidos);
                foreach (Pedido pedidoX in cadeteX.ListaDePedidos)
                {
                    Console.WriteLine(pedidoX.EstadoPedido);
                }
            }
      
            
            
        }
    }
}
