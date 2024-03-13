using System;
using System.Collections.Generic;

namespace Lab06_BruteForce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Brute Force Algorithm!!");
            var text = "THIS IS A SIMPLE TEST";
            var pattern = "SIMPLE";
            Console.WriteLine($"Text = {text}");
            Console.WriteLine($"Pattern = {pattern}");
            PrintTextWithIndices(text);
            Console.WriteLine("1.0 Single word search");
            int patternIndexFound = FindSinglePatternText(text, pattern);
            if (patternIndexFound > 0)
            {
                Console.WriteLine($"Pattern '{pattern}' found at index: {patternIndexFound}");
            }
            else
            {
                Console.WriteLine($"No pattern found for '{pattern}'");
            }
            Console.WriteLine();
            Console.WriteLine("2.0 Word search in all text");
            pattern = "IS";
            List<int> patternsIndexFound = FindPatternText(text, pattern);
            if (patternsIndexFound.Count > 0)
            {
                foreach (var index in patternsIndexFound)
                {
                    Console.WriteLine($"Pattern '{pattern}' found at index: {index}");
                }
            }
            else
            {
                Console.WriteLine($"No patterns found for '{pattern}'");
            }
            Console.WriteLine();
            Console.WriteLine("3.0 Words array search in all text");
            // Array of words to find
            List<string> words = new List<string> { "THIS", "IS", "SIMPLE" };
            foreach (var word in words)
            {
                patternsIndexFound = FindPatternText(text, word);
                if (patternsIndexFound.Count > 0)
                {
                    foreach (var index in patternsIndexFound)
                    {
                        Console.WriteLine($"Pattern '{word}' found at index: {index}");
                    }
                }
                else
                {
                    Console.WriteLine($"No patterns found for '{word}'");
                }
            }
        }

        // Método para buscar un solo patrón en el texto
        static int FindSinglePatternText(string text, string pattern)
        {
            // Implementa la lógica para encontrar el patrón en el texto
            // y devuelve el índice donde se encuentra el patrón.
            // Si no se encuentra, devuelve -1.
            return text.IndexOf(pattern);
        }

        // Método para buscar un patrón en todo el texto y devolver
        // una lista de índices donde se encuentra el patrón.
        static List<int> FindPatternText(string text, string pattern)
        {
            List<int> indices = new List<int>();
            int index = -1;
            while (true)
            {
                index = text.IndexOf(pattern, index + 1);
                if (index == -1)
                    break;
                indices.Add(index);
            }
            return indices;
        }

        // Método para imprimir el texto con los índices y caracteres correspondientes
        static void PrintTextWithIndices(string text)
        {
            Console.WriteLine("Indices: ");
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write($"({i:00}, {text[i]}) ");
            }
            Console.WriteLine();
            Console.WriteLine("Text: ");
            foreach (var character in text)
            {
                Console.Write($"{character,-3} ");
            }
            Console.WriteLine();
        }
    }
}
