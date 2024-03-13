using System;
using System.Diagnostics;

class Program
{
    static Random random = new Random();

    static void Main(string[] args)
    {

        Console.WriteLine("MAX CARRION GR1SW ESTRUCTURA DE DATOS Y ALGORITMOS");
      // Verificación de número primo
        long primeNumber = 1000000007;
        Stopwatch primeStopwatch = new Stopwatch();
        primeStopwatch.Start();
        IsPrime(primeNumber);
        primeStopwatch.Stop();
        Console.WriteLine($"Tiempo de ejecución (verificación primo): {primeStopwatch.Elapsed} ms");

        // Verificación de número primo usando enfoque aleatorizado
        Stopwatch randomPrimeStopwatch = new Stopwatch();
        randomPrimeStopwatch.Start();
        IsPrimeRandomized(primeNumber);
        randomPrimeStopwatch.Stop();
        Console.WriteLine($"Tiempo de ejecución (verificación primo aleatorizado): {randomPrimeStopwatch.Elapsed} ms");

        // Implementación del Quicksort con arreglo ordenado
        int[] sortedArray = GenerateSortedArray(10000);
        Stopwatch sortedStopwatch = new Stopwatch();
        sortedStopwatch.Start();
        QuickSort(sortedArray, 0, sortedArray.Length - 1);
        sortedStopwatch.Stop();
        Console.WriteLine($"Tiempo de ejecución (Quicksort ordenado): {sortedStopwatch.Elapsed} ms");

        // Implementación del Quicksort aleatorizado con arreglo aleatorio
        int[] randomArray = GenerateRandomArray(10000);
        Stopwatch randomStopwatch = new Stopwatch();
        randomStopwatch.Start();
        QuickSort(randomArray, 0, randomArray.Length - 1);
        randomStopwatch.Stop();
        Console.WriteLine($"Tiempo de ejecución (Quicksort aleatorio): {randomStopwatch.Elapsed} ms");
  
    }
    

    static bool IsPrime(long number)
    {
        if (number <= 1)
            return false;
        if (number <= 3)
            return true;
        if (number % 2 == 0 || number % 3 == 0)
            return false;

        long sqrt = (long)Math.Sqrt(number);
        for (long i = 5; i <= sqrt; i += 6)
        {
            if (number % i == 0 || number % (i + 2) == 0)
                return false;
        }

        return true;
    }

    static bool IsPrimeRandomized(long number)
    {
        int iterations = 5;
        for (int i = 0; i < iterations; i++)
        {
            long randomValue = random.Next(2, (int)Math.Sqrt(number) + 1);
            if (number % randomValue == 0)
                return false;
        }
        return true;
    }

    static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = RandomizedPartition(arr, low, high);

            QuickSort(arr, low, pivotIndex - 1);
            QuickSort(arr, pivotIndex + 1, high);
        }
    }

    static int RandomizedPartition(int[] arr, int low, int high)
    {
        int randomIndex = random.Next(low, high + 1);
        Swap(arr, randomIndex, high);
        return Partition(arr, low, high);
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                Swap(arr, i, j);
            }
        }

        Swap(arr, i + 1, high);
        return i + 1;
    }

    static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    static int[] GenerateSortedArray(int size)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = i;
        }
        return array;
    }

    static int[] GenerateRandomArray(int size)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(100000);
        }
        return array;
    }
}
