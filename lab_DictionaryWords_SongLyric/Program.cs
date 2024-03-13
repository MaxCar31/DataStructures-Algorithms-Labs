using System;
using System.Collections.Generic;
using System.IO;

namespace CarrionMax
{
    class Program
    {
        static void Main(string[] args)

        {
 	        Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine();
            Console.WriteLine("******************************");
            Console.WriteLine("*                            *");
            Console.WriteLine("*      LYRICS DICTIONARY     *");
            Console.WriteLine("*                            *");
            Console.WriteLine("******************************");
            Console.WriteLine("By Max Carrion");

            Console.ResetColor();

            // Datos de la canción
            string tituloDeCancion = "Canción: Tides";
            string AutorDeLaCancion = "Autor: Ed Sheeran";
            Console.WriteLine(tituloDeCancion);
            Console.WriteLine(AutorDeLaCancion);
            Console.WriteLine();

            // Lee el archivo de letras de la canción
            string rutaLetraDeCancion = "SongLyric.txt";
            string LetraDeCancion = File.ReadAllText(rutaLetraDeCancion);

            // Lee el archivo de palabras del diccionario
            string rutaDicionario = "DictionaryWords.txt";
            string[] DicionarioDePalabras = File.ReadAllLines(rutaDicionario);

            // Divide las palabras de la canción en una lista
            List<string> cancionPalabras = new List<string>(LetraDeCancion.Split(' ', StringSplitOptions.RemoveEmptyEntries));

            int palabrasCoincidentes = 0;
            int palabrasTotales = cancionPalabras.Count;

            // Recorre las palabras de la canción y verifica si están en el diccionario
            foreach (string word in cancionPalabras)
            {
                bool estaEnDiccionario = VerificarDiccionario(DicionarioDePalabras, word);

                if (estaEnDiccionario)
                {
                    palabrasCoincidentes++;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.Write(word + " ");
            }

            Console.ResetColor();
            Console.WriteLine();

            // Calcula el porcentaje de palabras coincidentes con el diccionario
            double porcentajeCoincidencia = (double)palabrasCoincidentes / palabrasTotales * 100;
            string porcentajeFormateado = porcentajeCoincidencia.ToString("0.00");


            Console.WriteLine($"Palabras coincidentes: {palabrasCoincidentes}");
            Console.WriteLine($"Palabras totales: {palabrasTotales}");
            Console.WriteLine($"Porcentaje de coincidencia: {porcentajeFormateado}%");

            // Espera a que el usuario presione una tecla para salir
            Console.ReadKey();
        }

        static bool VerificarDiccionario(string[] dicionarioPalabras, string word)
        {
            // Crea una pila  llamada pilaDeDicionario y la inicializa con los elementos del arreglo dicionarioPalabras
            Stack<string> pilaDeDicionario = new Stack<string>(dicionarioPalabras);

            // Variable booleana para indicar si la palabra se encuentra en el diccionario
            bool estaEnDiccionario = false;

            // Ciclo while que se repite mientras la pila dictionaryStack tenga elementos
            while (pilaDeDicionario.Count > 0)
            {
                // Extrae el elemento en la parte superior de la pila y lo asigna a la variable dictPalabra
                string dictPalabra = pilaDeDicionario.Pop();

                // Compara si dictPalabra es igual a la palabra actual, ignorando las diferencias de mayúsculas y minúsculas
                if (dictPalabra.Equals(word, StringComparison.OrdinalIgnoreCase))
                {
                    // Si la palabra coincide, se asigna true a la variable estaEnDiccionario y se sale del ciclo
                    estaEnDiccionario = true;
                    break;
                }
            }

            return estaEnDiccionario;
        }
    }
}

