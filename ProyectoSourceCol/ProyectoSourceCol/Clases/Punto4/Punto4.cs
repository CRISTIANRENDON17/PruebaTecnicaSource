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

/*
 * Elabora un metodo el cual reciba una lista de tipo Car(brand,model,color) Y con Linq hacer una consulta
 * que me devuelva los autos cuyo el metodo se maximo de hace 5 años
 */

namespace ProyectoSourceCol.Clases.Punto4
{
    internal class Punto4
    {
        public string generarColor()
        {
            string Color = "";
            Random myObject = new Random();//genera un numero aleatorio
            int numero = myObject.Next(0, 3);
            if (numero == 0)
            {
                Color = "Amarillo";
            }
            else if (numero == 1)
            {
                Color = "Azul";
            }
            else
            {
                Color = "Rojo";
            }

            return Color;
        }
        public List<Car> ArmarLista()
        {
            //llena una lista de tipo car, con 20 carros, y solo cambia el numero del modelo con
            //un aleatorio que esta entre 0 a 10 años
            List<Car> lista = new List<Car>();
            Random myObject = new Random();//genera un numero aleatorio
            for (int i = 0; i < 20; i++)
            {
                string brand = "Brand " + i;
                Car car = new Car(brand, myObject.Next(0, 10), generarColor());//crea y llena en el contructor un objeto de tipo car
                lista.Add(car);//agrega a la lista, con el metodo add, se va llenando en orden de llegada
            }
            return lista;
        }
        public List<Car> MostrarLista(List<Car> list) //me lista todos los carros con toda su data
        {
            Console.WriteLine("Lista de todos los carros");
            list.ForEach((x) =>
            {
                Car car = (Car)x;
                int ano = (int)car.getModel();
                string brand = (string)car.getBrand();
                string color = (string)car.getColor();
                Console.WriteLine(brand + " - " + "Model: " + ano + "  - Color: " + color);
            });
            Console.WriteLine("\n");
            return list;
        }

        public List<Car> ListaClasificada(List<Car> list) //me lista solo los carros con el modelo que quiero ver
        {
            Console.WriteLine("\n" + "Lista de los carros con modelo de maximo 5 años");
            list.ForEach((x) => {
                Car car = (Car)x;
                int ano = (int)car.getModel();
                if (ano < 6)
                {
                    string brand = (string)car.getBrand();
                    string color = (string)car.getColor();
                    Console.WriteLine(brand + " - " + "Model: " + ano + "  - Color: " + color);
                }
            });
            Console.WriteLine("\n");
            return list;
        }
    }
}
