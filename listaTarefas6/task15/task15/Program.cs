using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        int[,] matriz1 = new int[4, 4];
        int[,] matriz2 = new int[4, 4];
        int[,] matrizResultado = new int[4, 4];

        Console.WriteLine("Matriz 1:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                matriz1[i, j] = random.Next(10);
                Console.Write($"{matriz1[i, j]}");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nMatriz 2:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                matriz2[i, j] = random.Next(10);
                Console.Write($"{matriz2[i, j]}");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nA matriz resultante é:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                matrizResultado[i, j] = matriz1[i, j] + matriz2[i, j];
                Console.Write($"{matrizResultado[i, j]}");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}

/* 15) Escreva um programa em C# para ler os valores e somar duas matrizes 4 x 4. 
 * Mostrar a matriz resultante.*/