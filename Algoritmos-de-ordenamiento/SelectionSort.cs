//MAX  - EXTRAIDO EN SU MAYORIA DEL LIBRO CSHARP-DATA-STRUCTURES-AND-ALGORITHMS

/*
El algoritmo de Selection Sort funciona seleccionando repetidamente el elemento más pequeño del subarreglo no ordenado y colocándolo al principio del subarreglo ordenado. 
En cada iteración, se busca el elemento mínimo en el subarreglo no ordenado y se intercambia con el primer elemento del subarreglo no ordenado.
*/


public static class SelectionSort
{
    // Método para ordenar un arreglo utilizando el algoritmo de Selection Sort
    public static void Sort<T>(T[] array) where T : IComparable
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minIndex = i;
            T minValue = array[i];
            
            // Buscar el elemento mínimo en el subarreglo no ordenado
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j].CompareTo(minValue) < 0)
                {
                    minIndex = j;
                    minValue = array[j];
                }
            }
            
            // Intercambiar el elemento mínimo con el primer elemento del subarreglo no ordenado
            Swap(array, i, minIndex);
        }
    }
    
    // Método para intercambiar dos elementos en un arreglo
    private static void Swap<T>(T[] array, int first, int second)
    {
        T temp = array[first];
        array[first] = array[second];
        array[second] = temp;
    }
}
