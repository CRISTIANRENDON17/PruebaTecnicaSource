/*
 * !--------- Prueba de SourceCol -----------!
 * Autor: Cristian Rendon Rodriguez
 * Version: 1.0
 * Fecha de inicio: 28/09/2022
 * Fecha de entrega: 1/10/2022
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

/*
 * Consultar la api publica de Rick and Morty y Muestre por consola el nombre de cada personaje
 */

namespace ProyectoSourceCol.Clases.Punto5
{
    internal class Punto5
    {
        /* No se consumir una API en c#, pero si se consultar: https://www.youtube.com/watch?v=yPgfLYaqMn8&ab_channel=Benjam%C3%ADnCamacho */
        public async void ListarPersinajes(String StringNumero)
        {
            // Evalua si el string es un numero o no, si es numero = true, sino false
            int numeroValue;
            bool isNumber = int.TryParse(StringNumero, out numeroValue);
            //Console.WriteLine(isNumber);
            //Console.WriteLine(numeroValue);
            if (isNumber == false) //valida si realmente ingreso un numero
            {
                Console.WriteLine("No ingreso un numero, ingresaste letras");
            }
            else if(isNumber == true && numeroValue < 826)
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://rickandmortyapi.com/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("User-Agent", "Awesome-Otacat-App");

                Console.WriteLine("!-------------Lista de nombres------------!");

                for (int i = 1; i <= numeroValue; i++)
                {
                    HttpResponseMessage response = await client.GetAsync("https://rickandmortyapi.com/api/character/" + i);
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        var personaje = JsonConvert.DeserializeObject<Personaje>(json);
                        Console.WriteLine(i + "." + "nombre: " + personaje.name);
                    }
                }
            }else if(numeroValue >= 826)
            {
                Console.WriteLine("Ingresaste una cifra mayor de personajes actualmente, ingrese menos de 826");
            }
        }

    }
}
