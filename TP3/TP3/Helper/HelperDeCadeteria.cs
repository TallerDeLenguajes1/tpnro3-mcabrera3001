using System;
using System.Collections.Generic;
using System.Text;


namespace TP3
{
    public static class HelperDeCadeteria
    {
        static string[] nombres = { "Pedro", "Juan", "Maria", "Romina", "Horacio", "Oscar", "Walter", "Rodrigo" };
        static string[] direcciones = { "BarrioNorte", "ZonaSur", "Manatial", "LaBanda", "Alderetes" };
        static Random rand = new Random();

        public static void CrearCadetes(Cadeteria cadeteria)
        {
            for (int i = 0; i < 3; i++)
            {
                Cadete nuevoCadete = new Cadete(i, nombres[rand.Next(7)], direcciones[rand.Next(4)], rand.Next(155000000, 157000000));
                cadeteria.agregarCadetes(nuevoCadete);
            }
        }

         public static void crearPedidos(Cadeteria cadeteria)
        {
            for (int i = 0; i < 10; i++)
            {
                Pedido nuevoPedido = new Pedido(i, i, nombres[rand.Next(7)], direcciones[rand.Next(4)], rand.Next(155000000, 157000000));
                cadeteria.ListaDeCadetes[rand.Next(0, 3)].agregarPedidos(nuevoPedido);

            }
        }

          public static void mostrarPedidos(Cadeteria cadeteria)
        {
            foreach (Cadete cadeteX in cadeteria.ListaDeCadetes)
            {
                Console.WriteLine("Nombre Cadete: " + cadeteX.NombreCadete);
                Console.WriteLine("Cantidad de Pedidos: " + cadeteX.CantidadaPedidos);
                foreach (Pedido pedidoX in cadeteX.ListaDePedidos)
                {
                    Console.WriteLine("Pedido n° " + pedidoX.NroPedido);
                    Console.WriteLine("Nombre del Cliente: " + pedidoX.Cliente.NombreCliente);
                }
                Console.WriteLine(" ----------------- ");
            }
        }
    }
}
