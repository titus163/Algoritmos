using System;
using System.Collections.Generic;

public class ElementosComunes {
    public static int[] EncontrarElementosComunes(int[] primero, int[] segundo) {
        // Verificación de entrada
        if (primero.Length == 0 || segundo.Length == 0) {
            return new int[0];
        }

        // HashSet para almacenar elementos únicos de la primera matriz
        HashSet<int> primeroConjunto = new HashSet<int>(primero);

        // HashSet para almacenar elementos únicos de la segunda matriz
        HashSet<int> segundoConjunto = new HashSet<int>(segundo);

        // Lista para almacenar elementos comunes
        List<int> elementosComunes = new List<int>();

        // Recorrer la segunda matriz
        foreach (int elemento in segundo) {
            // Si el elemento está en el conjunto de la primera matriz, es un elemento común
            if (primeroConjunto.Contains(elemento)) {
                elementosComunes.Add(elemento);
            }
        }

        // Ordenar los elementos comunes
        elementosComunes.Sort();

        // Convertir la lista de elementos comunes a una matriz
        int[] matrizComunes = elementosComunes.ToArray();

        return matrizComunes;
    }

    public static void Main(string[] args) {
        int[] primero = { 1, 2, 3, 4, 5 };
        int[] segundo = { 4, 5, 6, 7, 8 };

        int[] elementosComunes = EncontrarElementosComunes(primero, segundo);
        Console.WriteLine($"Elementos comunes: {string.Join(", ", elementosComunes)}");
    }
}