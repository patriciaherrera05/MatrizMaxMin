using System;

namespace MatrizMaxMin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- MATRIZ BIDIMENSIONAL ----");

            int filas;
            while (true)
            {
                Console.Write("Ingrese el número de filas (mayor que 0): ");
                if (int.TryParse(Console.ReadLine(), out filas) && filas > 0)
                    break;
                Console.WriteLine("Entrada inválida. Intente de nuevo.");
            }

            int columnas;
            while (true)
            {
                Console.Write("Ingrese el número de columnas (mayor que 0): ");
                if (int.TryParse(Console.ReadLine(), out columnas) && columnas > 0)
                    break;
                Console.WriteLine("Entrada inválida. Intente de nuevo.");
            }

            int[,] matriz = new int[filas, columnas];

            Console.WriteLine("\n--- INGRESO DE VALORES ---");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    while (true)
                    {
                        Console.Write($"Elemento [{i},{j}]: ");
                        if (int.TryParse(Console.ReadLine(), out matriz[i, j]))
                            break;
                        Console.WriteLine("Entrada inválida. Ingrese un número entero.");
                    }
                }
            }

            Console.WriteLine("\n--- MATRIZ INGRESADA ---");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int max = matriz[0, 0];
            int min = matriz[0, 0];
            int filaMax = 0, colMax = 0;
            int filaMin = 0, colMin = 0;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (matriz[i, j] > max)
                    {
                        max = matriz[i, j];
                        filaMax = i;
                        colMax = j;
                    }

                    if (matriz[i, j] < min)
                    {
                        min = matriz[i, j];
                        filaMin = i;
                        colMin = j;
                    }
                }
            }

            Console.WriteLine($"\nMayor valor: {max} en posición [{filaMax},{colMax}]");
            Console.WriteLine($"Menor valor: {min} en posición [{filaMin},{colMin}]");
        }
    }
}
