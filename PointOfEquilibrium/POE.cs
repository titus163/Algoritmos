using System;

public class POE {
    public static int EncontrarPOE(int[] a) {
        // Verificación de entrada
        if (a.Length == 0) {
            return -1;
        }

        // Suma total de la matriz
        int sumaTotal = 0;
        foreach (int valor in a) {
            sumaTotal += valor;
        }

        // Suma izquierda
        int sumaIzquierda = 0;

        // Recorrer la matriz
        for (int i = 0; i < a.Length; i++) {
            // Calcular la suma derecha
            int sumaDerecha = sumaTotal - (a[i] + sumaIzquierda);

            // Verificar si el índice actual es un POE
            if (sumaIzquierda == sumaDerecha) {
                return i;
            }

            // Actualizar la suma izquierda
            sumaIzquierda += a[i];
        }

        // No se encontró POE
        return -1;
    }

    public static void Main(string[] args) {
        int[] a = { 1, 2, 3, 4, 3, 2, 1 };
        int poe = EncontrarPOE(a);
        Console.WriteLine($"Punto de equilibrio: {poe}");
    }
}