using System;
using System.Collections.Generic;

// Clase para representar una actividad

//CARRION MAX

class Activity
{
    public char Name { get; set; }   // Nombre de la actividad
    public int Start { get; set; }   // Tiempo de inicio de la actividad
    public int Finish { get; set; }  // Tiempo de finalización de la actividad

    public Activity(char name, int start, int finish)
    {
        Name = name;
        Start = start;
        Finish = finish;
    }
}

class ActivitySelection
{
    // Función que implementa el algoritmo voraz para seleccionar actividades
    public static List<Activity> GreedyActivitySelection(List<Activity> activities)
    {
        List<Activity> selectedActivities = new List<Activity>();

        // Ordenar las actividades según su tiempo de finalización de forma ascendente
        activities.Sort((a, b) => a.Finish.CompareTo(b.Finish));

        // Seleccionar la primera actividad (la de menor tiempo de finalización)
        selectedActivities.Add(activities[0]);
        int previousFinish = activities[0].Finish;

        // Iterar sobre las actividades restantes y seleccionar las compatibles
        for (int i = 1; i < activities.Count; i++)
        {
            if (activities[i].Start >= previousFinish)
            {
                // Si el tiempo de inicio de la actividad actual es mayor o igual al tiempo de finalización
                // de la actividad previamente seleccionada, entonces es compatible y la añadimos a la lista
                selectedActivities.Add(activities[i]);
                previousFinish = activities[i].Finish; // Actualizamos el tiempo de finalización previo
            }
        }

        return selectedActivities; // Devolvemos la lista de actividades seleccionadas
    }
}

class Program
{
    // Función para imprimir las actividades seleccionadas
    public static void PrintSelectedActivities(List<Activity> activities)
    {
        Console.WriteLine("Actividades seleccionadas:");
        foreach (var activity in activities)
        {
            Console.WriteLine($"Actividad {activity.Name} - Inicio: {activity.Start}, Fin: {activity.Finish}");
        }
    }

    // Método principal para probar el algoritmo
    static void Main()
    {
        // Datos de las actividades proporcionadas
        char[] names = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
        int[] starts = { 1, 0, 5, 3, 6, 8, 8, 12 };
        int[] finishes = { 4, 6, 7, 9, 10, 11, 12, 16 };

        List<Activity> activities = new List<Activity>();

        // Crear objetos Activity y agregarlos a la lista de actividades
        for (int i = 0; i < names.Length; i++)
        {
            activities.Add(new Activity(names[i], starts[i], finishes[i]));
        }

        // Llamar al algoritmo voraz para seleccionar las actividades compatibles
        List<Activity> selectedActivities = ActivitySelection.GreedyActivitySelection(activities);

        // Imprimir las actividades seleccionadas
        PrintSelectedActivities(selectedActivities);
    }
}
