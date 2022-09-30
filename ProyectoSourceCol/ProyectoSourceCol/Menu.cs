/*
 * !--------- Prueba de SourceCol -----------!
 * Autor: Cristian Rendon Rodriguez
 * Version: 1.0
 * Fecha de inicio: 28/09/2022
 * Fecha de entrega: 1/10/2022
 */


using ProyectoSourceCol.Clases;
using ProyectoSourceCol.Clases.Punto4;
using ProyectoSourceCol.Clases.Punto5;

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
                case "2":
                    {
                        Imprimir("\n" + "\n" + "!-----------Punto2----------!" + "\n" + "\n" + "Ingrese un valor (numerico):");
                        string Cadena = Console.ReadLine();
                        Punto2 punto2 = new Punto2(); //crea un objeto de la clase Punto2 para poder usar sus metodos
                        punto2.ValidadFibonacci(Cadena);
                        break;
                    }
                case "3":
                    {
                        Imprimir("\n" + "\n" + "!-----------Punto3----------!" + "\n" + "\n");
                        /*se podria trabajar con arraylist y usar metodos de arreglos propios de arraylist pero 
                         por temas de practica y de conocimientos se hara con arreglos e metodos normales y tambien numeros aleatorios*/
                        int[] arreglo = new int[10];
                        Punto3 punto3 = new Punto3(); //crea un objeto de la clase Punto3 para poder usar sus metodos
                        arreglo = punto3.CrearArrelo(arreglo);
                        arreglo = punto3.OrganizarArreglo(arreglo);
                        punto3.MostrarArreglo(arreglo);
                        break;
                    }
                case "4":
                    {
                        Imprimir("\n" + "\n" + "!-----------Punto4----------!" + "\n" + "\n");

                        Punto4 punto4 = new Punto4();
                        List<Car> list = new List<Car>();
                        list = punto4.ArmarLista();
                        list = punto4.MostrarLista(list);
                        list = punto4.ListaClasificada(list);
                        //Console.WriteLine(list);
                        break;
                    }
                case "5":
                    {
                        Imprimir("\n" + "\n" + "!----------------------Punto5----------------------!" + "\n" + "\n");
                        Imprimir("Ingrese cuantos personajes quiere enlistar  max(825 personajes):");
                        string Cadena = Console.ReadLine();
                        Punto5 punto5 = new Punto5();
                        punto5.ListarPersinajes(Cadena);
                        /* coloco un pause, porque como la funcion es asyncrona entonces cargaria el menu de 
                         * nuevo otra vez y despues pintaria los personajes en pantalla, asi evito el conflicto*/
                        Console.WriteLine("Espere un momento a que la data cargue, y presiona cualquier tecla para continuar" + "\n");
                        Console.ReadLine();

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