using System;
using System.Diagnostics;
using System.Numerics;

namespace Lab09_DivideYVenceras_Carrion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definición de los dos números a multiplicar
            BigInteger numero1 = BigInteger.Parse("123456789012345678901234567890");
            BigInteger numero2 = BigInteger.Parse("987654321098765432109876543210");

            // Inicialización del cronómetro para medir el tiempo de ejecución
            Stopwatch stopwatch = new Stopwatch();

            // Multiplicación estándar
            Console.WriteLine("");
            Console.WriteLine("Multiplicación estándar");
            Console.WriteLine("");
            stopwatch.Start();
            BigInteger resultadoStandard = numero1 * numero2;
            stopwatch.Stop();
            Console.WriteLine("Resultado (Multiplicación estándar): " + resultadoStandard);
            Console.WriteLine("Tiempo tomado (Multiplicación estándar): " + stopwatch.Elapsed);

            // Multiplicación usando el método BigInteger.Multiply
            Console.WriteLine("");
            Console.WriteLine("Multiplicación usando el método BigInteger.Multiply");
            Console.WriteLine("");
            stopwatch.Reset();
            stopwatch.Start();
            BigInteger resultadoBigInteger = BigInteger.Multiply(numero1, numero2);
            stopwatch.Stop();
            Console.WriteLine("Resultado (BigInteger.Multiply): " + resultadoBigInteger);
            Console.WriteLine("Tiempo tomado (BigInteger.Multiply): " + stopwatch.Elapsed);

            // Multiplicación usando el algoritmo Karatsuba
            Console.WriteLine("");
            Console.WriteLine("Multiplicación usando el algoritmo Karatsuba");
            Console.WriteLine("");
            stopwatch.Reset();
            stopwatch.Start();
            BigInteger resultadoKaratsuba = KaratsubaMultiplication(numero1, numero2);
            stopwatch.Stop();
            Console.WriteLine("Resultado (Karatsuba): " + resultadoKaratsuba);
            Console.WriteLine("Tiempo tomado (Karatsuba): " + stopwatch.Elapsed);
        }

        // Implementación del algoritmo de Karatsuba
        static BigInteger KaratsubaMultiplication(BigInteger x, BigInteger y)
        {
            int n = Math.Max(x.ToString().Length, y.ToString().Length);

            if (n <= 2)
                return BigInteger.Multiply(x, y);

            int m = n / 2;

            BigInteger high1 = BigInteger.Divide(x, BigInteger.Pow(10, m));
            BigInteger low1 = x % BigInteger.Pow(10, m);

            BigInteger high2 = BigInteger.Divide(y, BigInteger.Pow(10, m));
            BigInteger low2 = y % BigInteger.Pow(10, m);

            BigInteger z0 = KaratsubaMultiplication(low1, low2);
            BigInteger z1 = KaratsubaMultiplication(low1 + high1, low2 + high2);
            BigInteger z2 = KaratsubaMultiplication(high1, high2);

            return (z2 * BigInteger.Pow(10, 2 * m)) + ((z1 - z2 - z0) * BigInteger.Pow(10, m)) + z0;
        }
    }
}
