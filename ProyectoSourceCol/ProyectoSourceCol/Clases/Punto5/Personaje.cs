/*
 * !--------- Prueba de SourceCol -----------!
 * Autor: Cristian Rendon Rodriguez
 * Version: 1.0
 * Fecha de inicio: 28/09/2022
 * Fecha de entrega: 1/10/2022
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSourceCol.Clases.Punto5
{

        /*usando el pegado especial de visualestudio, pegue una clase json de un personaje y lo convirtio a objeto*/
        public class Personaje
        {
            public int id { get; set; }
            public string name { get; set; }
            public string status { get; set; }
            public string species { get; set; }
            public string type { get; set; }
            public string gender { get; set; }
            public Origin origin { get; set; }
            public Location location { get; set; }
            public string image { get; set; }
            public string[] episode { get; set; }
            public string url { get; set; }
            public DateTime created { get; set; }
        }

        public class Origin
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Location
        {
            public string name { get; set; }
            public string url { get; set; }
        }

}
