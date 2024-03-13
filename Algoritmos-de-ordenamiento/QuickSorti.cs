//MAX - EXTRAIDO EN SU MAYORIA DEL LIBRO CSHARP-DATA-STRUCTURES-AND-ALGORITHMS 


/**
El método QuickSort es un método recursivo que divide el arreglo en subarreglos más pequeños y los ordena de forma recursiva. 
Utiliza el método Partition para encontrar la posición correcta del pivote y luego realiza las llamadas recursivas para los subarreglos izquierdo y derecho.
*/

public static class QuickSorti {
    // Método para ordenar un arreglo utilizando el algoritmo de QuickSort
    public static void Sort<T>(T[] array) where T : IComparable
    {
        QuickSort(array, 0, array.Length - 1);
    }

    // Método recursivo para realizar el ordenamiento QuickSort
    public static void QuickSort<T>(T[] array, int left, int right) where T : IComparable
    {
        if (left < right)
        {
            int pivotIndex = Partition(array, left, right);
            QuickSort(array, left, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, right);
        }
    }

    // Método para realizar la partición en QuickSort
    public static int Partition<T>(T[] array, int left, int right) where T : IComparable
    {
        T pivot = array[right]; // Se elige el último elemento como pivote
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (array[j].CompareTo(pivot) <= 0)
            {
                i++;
                Swap(array, i, j); // Intercambia elementos si son menores o iguales al pivote
            }
        }

        Swap(array, i + 1, right); // Coloca el pivote en su posición correcta
        return i + 1;
    }

    // Método para intercambiar dos elementos en un arreglo
    public static void Swap<T>(T[] array, int first, int second)
    {
        T temp = array[first];
        array[first] = array[second];
        array[second] = temp;
    }
}
