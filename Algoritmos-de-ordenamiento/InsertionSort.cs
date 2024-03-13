//MAX  - EXTRAIDO EN SU MAYORIA DEL LIBRO CSHARP-DATA-STRUCTURES-AND-ALGORITHMS

/*

El algoritmo de Insertion Sort funciona de la siguiente manera: se divide el arreglo en dos partes, una parte ordenada y una parte no ordenada. 
En cada iteración, se toma el primer elemento del subarreglo no ordenado y se inserta en la posición correcta dentro del subarreglo ordenado, 
desplazando los elementos mayores hacia la derecha.

*/


public static class InsertionSort
{
    // Método para ordenar un arreglo utilizando el algoritmo de Insertion Sort
    public static void Sort<T>(T[] array) where T : IComparable
    {
        for (int i = 1; i < array.Length; i++)
        {
            int j = i;
            
            // Desplazar los elementos hacia la derecha hasta encontrar la posición correcta para el elemento actual
            while (j > 0 && array[j].CompareTo(array[j - 1]) < 0)
            {
                Swap(array, j, j - 1);
                j--;
            }
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
