using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporte_de_Peliculas
{
    internal class Program
    {
        /*
         
        Desarrollar un programa que permita registrar información de películas: nombre, director, año estreno y genero. 
        La información se debe almacenar en un archivo de texto. Mediante un menú de usuario se debe permitir grabar nuevas 
        películas y acceder al listado completo de películas grabadas.

        */
        static void Main(string[] args)
        {
            string entrada; //Esto es una entrada

            do
            {

                Console.Clear(); //Esto es un limpiador de la pantalla

                mostrarMenu(); //Esta funcion muestra el menu del programa

                entrada = Console.ReadLine();

                switch (entrada)
                {
                    case "A":
                    case "a":
                        escribirArchivo();
                        break;

                    case "B":
                    case "b":
                        leerArchivo();
                        break;

                    default:
                        mostrarError();
                        break;
                }


            } while (entrada != "X" && entrada != "X");

            Console.ReadKey();
        }

        static void mostrarMenu()
        {

            Console.WriteLine("======== REGISTRO DE PELICULAS ==========\n");
            Console.WriteLine("A. Registrar Peliula");
            Console.WriteLine("B. Mostrar el listado de toda la pelicula");
            Console.WriteLine("\n=========================================");
            Console.Write("Ingrese la opcion deseada: ");
        }

        static void escribirArchivo()
        {

            Console.Clear();

            int i;
            string texto = "";
            string ruta = @"C:\mi_archivo.txt";

            Console.Write("Ingrese el texto a grabar: ");
            texto = Console.ReadLine();

            StreamWriter writer = File.AppendText(ruta);
            writer.WriteLine(texto);

            for (i = 1; i < 5; i++)
            {
                if (i == 1)
                {
                    Console.Write("\nTitulo de la pelicula: ");
                    texto = Console.ReadLine();
                    writer.WriteLine(texto);
                }
                else if (i == 2)
                {
                    Console.Write("\nDirector de la pelicula: ");
                    texto = Console.ReadLine();
                    writer.WriteLine(texto);
                }
                else if (i == 3)
                {
                    Console.Write("\nAño de la publicacion de la pelicula: ");
                    texto = Console.ReadLine();
                    writer.WriteLine(texto);
                }
                else
                {
                    Console.Write("\nGenero de la pelicula: ");
                    texto = Console.ReadLine();
                    writer.WriteLine(texto);
                }
            }

            writer.Close();

            Console.Clear();
        }

        static void leerArchivo()
        {

            Console.Clear();

            string ruta = @"C:\mi_archivo.txt";
            string linea = "";

            StreamReader file = new StreamReader(ruta);

            while ((linea = file.ReadLine()) != null)
            {
                Console.WriteLine(linea);
            }

            file.Close();
            Console.ReadKey();
        }

        static void mostrarError()
        {
            Console.Clear();
            Console.WriteLine("Opcion INVALIDA, pruebe con otra: ");
            Console.ReadKey();
        }
    }
}

