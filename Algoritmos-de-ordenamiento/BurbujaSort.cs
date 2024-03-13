
//MAX - EXTRAIDO EN SU MAYORIA DEL LIBRO CSHARP-DATA-STRUCTURES-AND-ALGORITHMS


/*

El método Sort recorre el arreglo y compara elementos adyacentes, intercambiándolos si están desordenados. 
Esto se repite hasta que el arreglo esté completamente ordenado. El método utiliza el método CompareTo para realizar las comparaciones entre elementos.

El método Swap es un método privado que se utiliza para intercambiar dos elementos en el arreglo. 
Toma como parámetros el arreglo y las posiciones de los elementos a intercambiar, y realiza el intercambio utilizando una variable temporal temp.

*/

public static class BurbujaSort {
    // Método para ordenar un arreglo utilizando el algoritmo de ordenación de burbuja
    public static void Sort<T>(T[] array) where T : IComparable
    {
        // Recorre el arreglo
        for (int i = 0, n = array.Length; i < n - 1; i++)
        {
            // Realiza comparaciones y realiza intercambios si es necesario
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j].CompareTo(array[j + 1]) > 0)
                    Swap(array, j, j + 1); // Llama al método Swap para intercambiar elementos
            }
        }
    }

    // Método privado para intercambiar dos elementos en un arreglo
    private static void Swap<T>(T[] array, int first, int second)
    {
        T temp = array[first];
        array[first] = array[second];
        array[second] = temp;
    }
}
