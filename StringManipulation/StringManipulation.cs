using System;

public class DiferenciaSumaParesImpares {
    public static int Diferencia(int[] matriz) {
        int sumaImpares = 0;
        int sumaPares = 0;

        foreach (int numero in matriz) {
            if (numero % 2 == 0) {
                sumaPares += numero;
            } else {
                sumaImpares += numero;
            }
        }

        int diferencia = sumaImpares - sumaPares;
        return diferencia;
    }

public static void Main(string[] args) {
        int[] matriz = { 1, 5, 8, 9, 2, 7 };
        int diferencia = Diferencia(matriz);
        Console.WriteLine($"La diferencia entre la suma de impares y pares es: {diferencia}");
    }
}