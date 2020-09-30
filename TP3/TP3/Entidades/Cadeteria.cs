using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TP3
{



    public class Cadeteria
    {
        string nombre;
        List<Cadete> listaDeCadetes;

        public string Nombre { get => nombre; set => nombre = value; }
        public List<Cadete> ListaDeCadetes { get => listaDeCadetes; set => listaDeCadetes = value; }

        public Cadeteria(string Nombre)
        {
            this.Nombre = Nombre;
            listaDeCadetes = new List<Cadete>();
        }

        public void agregarCadetes(Cadete nuevoCadete)
        {
            ListaDeCadetes.Add(nuevoCadete);
        }
    }

 
}
