using System;

public class InvierteEntero {
    public static int Invertir(int numero) {
        // Validación de entrada
        if (numero <= 0) {
            return 0;
        }

        // Inversión del entero
        int invertido = 0;
        while (numero > 0) {
            int digito = numero % 10;
            invertido = invertido * 10 + digito;
            numero /= 10;
        }

        return invertido;
    }

    public static void Main(string[] args) {
        int numero = 123;
        int numeroInvertido = Invertir(numero);
        Console.WriteLine($"Número invertido: {numeroInvertido}");
    }
}