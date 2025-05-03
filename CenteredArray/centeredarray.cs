using System;

public class MatrizCentrada {
    public static int EsMatrizCentrada(int[] matriz) {
        // Verificamos si la longitud de la matriz es impar
        if (matriz.Length % 2 == 0) {
            return 0;
        }

        // Encontramos el índice del elemento central
        int indiceCentral = matriz.Length / 2;

        // Comparamos cada elemento con el elemento central
        for (int i = 0; i < matriz.Length; i++) {
            if (i != indiceCentral && matriz[i] <= matriz[indiceCentral]) {
                return 0;
            }
        }

        // Si todos los elementos pasan la prueba, la matriz es centrada
        return 1;
    }

    public static void Main(string[] args) {
        int[] matriz = { 7, 8, 9, 10, 11 };
        int resultado = EsMatrizCentrada(matriz);

        if (resultado == 1) {
            Console.WriteLine("La matriz es una matriz centrada");
        } else {
            Console.WriteLine("La matriz no es una matriz centrada");
        }
    }
}