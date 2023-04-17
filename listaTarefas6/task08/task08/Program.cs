using System;

namespace task08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrizA = new int[4, 4];
            int[,] matrizInversa = new int[4, 4];
            Random random = new Random();

            // Leitura da Matriz com números Aleatórios
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    matrizA[i, j] = random.Next(0, 50);
                }
            }

            // Mostra a matriz na ordem
            Console.WriteLine("Matriz na ordem direta:");
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    Console.Write(matrizA[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Cria a matriz na ordem inversa
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    matrizInversa[matrizA.GetLength(0) - i - 1, matrizA.GetLength(1) - j - 1] = matrizA[i, j];
                }
            }

            // Mostra a matriz na ordem inversa
            Console.WriteLine("Matriz na ordem inversa:");
            for (int i = 0; i < matrizInversa.GetLength(0); i++)
            {
                for (int j = 0; j < matrizInversa.GetLength(1); j++)
                {
                    Console.Write(matrizInversa[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
