using System;
using System.Collections.Generic;

namespace AlgoritmoOrdenamiento
{
    // Clase principal del programa
    class Program
    {
        static void Main(string[] args)
        {
            int numElementos = 10000; // Número de elementos que va a tener el arreglo
            DateTime tiempoInicio, tiempoFinal;
            TimeSpan executionTime;
            Random random = new Random();
            int[] arregloPrueba = new int[numElementos];

            tiempoInicio = DateTime.Now;

            // Llenado del arreglo con números aleatorios
            for (int i = 0; i < arregloPrueba.Length; i++)
            {
                arregloPrueba[i] = random.Next();
                Console.Write(arregloPrueba[i] + " - ");
            }

            // Toma del tiempo de inicio
            tiempoFinal = DateTime.Now;
            executionTime = tiempoFinal - tiempoInicio;
            Console.WriteLine(" ");
            Console.WriteLine("\nArray initialization took: " + executionTime);
            Console.WriteLine(" ");
            
            // Creación de clones de los arreglos
            int[] arraySelection = (int[])arregloPrueba.Clone();
            int[] arrayInsertion = (int[])arregloPrueba.Clone();
            int[] arrayBubble1 = (int[])arregloPrueba.Clone();
            int[] arrayBubble2 = (int[])arregloPrueba.Clone();
            int[] arrayQuick = (int[])arregloPrueba.Clone();

            // Diccionario para almacenar los tiempos de ejecución por algoritmo
            Dictionary<string, TimeSpan> executionTimes = new Dictionary<string, TimeSpan>();

            // Ordenamiento con función incorporada (Array.Sort)
            tiempoInicio = DateTime.Now;
            Array.Sort(arrayBubble1);
            tiempoFinal = DateTime.Now;
            executionTime = tiempoFinal - tiempoInicio;
            executionTimes.Add("Array Sort using built-in function", executionTime);

            // Ordenamiento con algoritmo de Selection Sort
            tiempoInicio = DateTime.Now;
            SelectionSort.Sort(arraySelection);
            tiempoFinal = DateTime.Now;
            executionTime = tiempoFinal - tiempoInicio;
            executionTimes.Add("Array Sort using SelectionSort", executionTime);

            // Ordenamiento con algoritmo de Insertion Sort
            tiempoInicio = DateTime.Now;
            InsertionSort.Sort(arrayInsertion);
            tiempoFinal = DateTime.Now;
            executionTime = tiempoFinal - tiempoInicio;
            executionTimes.Add("Array Sort using InsertSort", executionTime);

            // Ordenamiento con algoritmo de Bubble Sort
            tiempoInicio = DateTime.Now;
            BurbujaSort.Sort(arrayBubble2);
            tiempoFinal = DateTime.Now;
            executionTime = tiempoFinal - tiempoInicio;
            executionTimes.Add("Array Sort using BubbleSort", executionTime);

            // Ordenamiento con algoritmo de Quick Sort
            tiempoInicio = DateTime.Now;
            QuickSorti.Sort(arrayQuick);
            tiempoFinal = DateTime.Now;
            executionTime = tiempoFinal - tiempoInicio;
            executionTimes.Add("Array Sort using QuickSort", executionTime);

            // Ordenar los tiempos de ejecución por orden ascendente
            var sortedExecutionTimes = executionTimes.OrderBy(x => x.Value);

            // Mostrar los tiempos de ejecución ordenados

            Console.WriteLine("A continuacion se imprime los tiempo de menor a mayor");

            foreach (var item in sortedExecutionTimes)
            {
                Console.WriteLine(" ");
                Console.WriteLine(item.Key + ": " + item.Value);
                Console.WriteLine(" ");
            }
     
            Console.WriteLine("El metodo de ordenamiento mas eficiente es la función incorporada y el menos eficiente con respecto al tiempo BubbleSort con 10.000 elementos");
        
        
        }
    }
}
