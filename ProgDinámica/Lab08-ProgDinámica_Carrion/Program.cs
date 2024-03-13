using System;
using System.Diagnostics;

namespace Lab08_ProgDinámica_Carrion
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 45; // Cambiar este valor para calcular un número diferente en la serie de Fibonacci.

            // Implementación estándar (recursiva)
            Console.WriteLine("Calculando el número de Fibonacci de manera estándar (recursiva)...");
            var swRecursivo = Stopwatch.StartNew(); // Cronómetro para la implementación recursiva.
            int resultRecursivo = CalcularFibonacciRecursivo(n);
            swRecursivo.Stop();
            Console.WriteLine($"El número de Fibonacci para ({n}) es: {resultRecursivo}");
            Console.WriteLine($"Tiempo de ejecución (recursivo): {swRecursivo.Elapsed.TotalMilliseconds} ms"); // Imprimir tiempo transcurrido en milisegundos.

            // Implementación con enfoque top-down (memorización)
            Console.WriteLine("\nCalculando el número de Fibonacci con enfoque top-down (memorización)...");
            var swTopDown = Stopwatch.StartNew(); // Cronómetro para la implementación top-down.
            int resultTopDown = CalcularFibonacciTopDown(n);
            swTopDown.Stop();
            Console.WriteLine($"El número de Fibonacci para ({n}) es: {resultTopDown}");
            Console.WriteLine($"Tiempo de ejecución (top-down): {swTopDown.Elapsed.TotalMilliseconds} ms"); // Imprimir tiempo transcurrido en milisegundos.

            // Implementación con enfoque bottom-up (tabulación)
            Console.WriteLine("\nCalculando el número de Fibonacci con enfoque bottom-up (tabulación)...");
            var swBottomUp = Stopwatch.StartNew(); // Cronómetro para la implementación bottom-up.
            int resultBottomUp = CalcularFibonacciBottomUp(n);
            swBottomUp.Stop();
            Console.WriteLine($"El número de Fibonacci para ({n}) es: {resultBottomUp}");
            Console.WriteLine($"Tiempo de ejecución (bottom-up): {swBottomUp.Elapsed.TotalMilliseconds} ms"); // Imprimir tiempo transcurrido en milisegundos.
        }

        // Implementación estándar (recursiva)
        static int CalcularFibonacciRecursivo(int n)
        {
            if (n <= 1)
                return n;
            return CalcularFibonacciRecursivo(n - 1) + CalcularFibonacciRecursivo(n - 2); // Llamadas recursivas.
        }

        // Implementación con enfoque top-down (memorización)
        static int CalcularFibonacciTopDown(int n)
        {
            int[] memo = new int[n + 1]; // Array para almacenar los resultados previamente calculados.
            return CalcularFibonacciTopDownHelper(n, memo);
        }

        static int CalcularFibonacciTopDownHelper(int n, int[] memo)
        {
            if (n <= 1)
                return n;

            if (memo[n] == 0) // Comprobar si el resultado ya está en el array memo.
                memo[n] = CalcularFibonacciTopDownHelper(n - 1, memo) + CalcularFibonacciTopDownHelper(n - 2, memo); // Llamadas recursivas y almacenamiento en memo.

            return memo[n]; // Devolver el resultado almacenado en memo.
        }

        // Implementación con enfoque bottom-up (tabulación)
        static int CalcularFibonacciBottomUp(int n)
        {
            int[] fib = new int[n + 1]; // Array para almacenar los resultados desde el inicio.
            fib[0] = 0;
            fib[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2]; // Cálculo del resultado y almacenamiento en fib.
            }

            return fib[n]; // Devolver el resultado almacenado en fib.
        }
    }
}
