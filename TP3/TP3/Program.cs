using System;
using System.Collections.Generic;
using System.Threading.Tasks;



namespace TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cadeteria Rappi = new Cadeteria("Rappi");
            HelperDeCadeteria.CrearCadetes(Rappi);
            HelperDeCadeteria.crearPedidos(Rappi);
            HelperDeCadeteria.mostrarPedidos(Rappi);
            
        }
    }
}
