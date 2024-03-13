using System;
using System.Diagnostics;

namespace Ejercicio_Recursividad
{
    class Program
    {
        static void Main()
        {
            
            Stopwatch stopwatch = new Stopwatch();

              int repetir; // Declarar la variable repetir aquí
              string input;
              int number;
     
            do{


            Console.WriteLine("Por favor digite una opcion:");
            Console.WriteLine("1) Serie de Fibonacci (Iterativa):");  
            Console.WriteLine("2) Serie de Fibonacci (Recursiva):");
            Console.Write("Por favor digite una opcion:");
            input = Console.ReadLine();
            number = int.Parse(input);
            

            if(number == 1){

    /************************************OPCION 1***************************************/

            Console.WriteLine("Serie de Fibonacci (Iterativa):");

      
            Console.Write("Ingrese el numero de datos a trabajar en la serie: ");
            input = Console.ReadLine();
            int n = int.Parse(input); // Número de elementos de la serie de Fibonacci

            stopwatch.Start();

            for (int i = 0; i < n; i++)
            {

                //Se manda a llamar al metodo FibonacciIteractivo teniendo como parametro los (i) elementos
                Console.WriteLine(FibonacciIterativo(i));
            }

            stopwatch.Stop();
            Console.WriteLine("Tiempo de ejecución (Iterativa): " + stopwatch.Elapsed + " con (" + n + ") elementos en la serie");

            stopwatch.Reset();
         
            }else{
    /************************************OPCION 2***************************************/
           
            Console.WriteLine("Serie de Fibonacci (Recursiva):");

            Console.Write("Ingrese el numero de datos a trabajar en la serie: ");
            input = Console.ReadLine();
            int n = int.Parse(input); // Número de elementos de la serie de Fibonacci

            stopwatch.Start();
            for (int i = 0; i < n; i++)
            
            {
                //Se manda a llamar al metodo FibonacciRecursivo teniendo como parametro los (i) elementos
                Console.WriteLine(FibonacciRecursivo(i));
            }

            stopwatch.Stop();
            Console.WriteLine("Tiempo de ejecución (Recursiva): " + stopwatch.Elapsed + " con (" + n + ") elementos en la serie");
            stopwatch.Reset();
        }
        

            Console.WriteLine ("Desea repetir?");

            Console.WriteLine("1) Si");  
            Console.WriteLine("2) No");
            Console.Write("Por favor digite una opcion:");
            string bucle = Console.ReadLine();
            repetir = int.Parse(bucle);

            }while(repetir == 1);

        }

        // Método para calcular la serie de Fibonacci de forma iterativa
        static long FibonacciIterativo(int n)
        {
            if (n <= 1)
                return n;

            long num1 = 0;
            long num2 = 1;
            long result = 0;

            for (int i = 2; i <= n; i++)
            {
                result = num1 + num2;
                num1 = num2;
                num2 = result;
            }

            return result;
        }

        // Método para calcular la serie de Fibonacci de forma recursiva
        static long FibonacciRecursivo(int n)
        {
            if (n <= 1)
                return n;

            return FibonacciRecursivo(n - 1) + FibonacciRecursivo(n - 2);
        }
    }
}
