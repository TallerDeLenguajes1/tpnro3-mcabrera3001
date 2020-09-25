using System;

namespace TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "Pedro", "Juan", "Maria", "Romina", "Horacio", "Oscar", "Walter", "Rodrigo" };
            string[] direcciones = { "BarrioNorte", "ZonaSur", "Manatial", "LaBanda", "Alderetes" };

            Cadeteria RappiMensajes = new Cadeteria("RappiMensajes");
            Random rand = new Random();

            for (int i = 0; i < 3; i++)
            {
                Cadete nuevoCadete = new Cadete(i, nombres[rand.Next(7)], direcciones[rand.Next(4)], rand.Next(155000000, 157000000));
                RappiMensajes.Cadetes.Add(nuevoCadete);
            }
            

            for (int i = 0; i < 10; i++)
            {
                
                
                //creo el pedido junto con el cliente y lo agrego a cada lista de cada cadete
                Pedido nuevoPedido = new Pedido(rand.Next(100), rand.Next(100), nombres[rand.Next(7)], direcciones[rand.Next(4)], rand.Next(rand.Next(155000000, 157000000)));
                nuevoCadete.agregarPedidos(nuevoPedido);

            }


      
            
            
        }
    }
}
