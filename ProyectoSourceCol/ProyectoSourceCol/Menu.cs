/*
 * !--------- Prueba de SourceCol -----------!
 * Autor: Cristian Rendon Rodriguez
 * Version: 1.0
 * Fecha de inicio: 28/09/2022
 * Fecha de entrega: 1/10/2022
 */


using ProyectoSourceCol.Clases;

internal class Menu
{
    //se usa para que sea mas facil y corto imprimir una data en consola
    static void Imprimir(string data)
    {
        Console.WriteLine(data);
    }
    private static void Main(string[] args)
    {
        //se inicializan variables
        bool Bandera = false;
        string Opcion;

        do  //se crea el ciclo que dara paso al menu para la prueba
        {
            Opcion = "";
            Imprimir("*---------Bienvenido al menu---------*");
            Imprimir("* Elija una opcion:                  *");
            Imprimir("* 1. Cortar Cadena al caracter 20    *");
            Imprimir("* 2. Serie Fibonacci validar #       *");
            Imprimir("* 3. Ordenar arreglo mayor a menor   *");
            Imprimir("* 4. Listar modelos de max 5 años    *");
            Imprimir("* 5. Listar Nombres de Api Rick & Mor*");
            Imprimir("*------------------------------------*");
            Opcion = Console.ReadLine();

            switch (Opcion)
            {
                case "1":
                    {
                        Imprimir("\n" + "\n" + "!-----------Punto1----------!" + "\n" + "\n" + "Ingrese una cadena:");
                        string Cadena = Console.ReadLine();
                        Punto1 punto1 = new Punto1(); //crea un objeto de la clase Punto1 para poder usar sus metodos
                        string AuxCadena = punto1.RecibirCadenaHasta20(Cadena);
                        Imprimir("\n" + "Cadena Original: " + Cadena);
                        Imprimir("\n" + "Cadena Recortada: " + AuxCadena + "\n");
                        break;
                    }
                default:
                    {
                        Imprimir("\n" + "\n" + "\n" + "Te has equivocado de opcion, por favor vuelve a ingresar los datos" + "\n" + "\n" + "\n");
                        break;
                    }
            }

        } while (Bandera != true);
    }
}