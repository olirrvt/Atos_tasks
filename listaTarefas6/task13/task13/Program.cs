using System;

namespace task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrizA = new int[5, 5];
            Random random = new Random();

            // Leitura da Matriz A com números Aleatórios
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    matrizA[i, j] = random.Next(0, 50);
                }
            }

            // Cálculo das somas das diagonais
            int somaDiagonalPrincipal = 0;
            int somaDiagonalSecundaria = 0;

            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                somaDiagonalPrincipal += matrizA[i, i];
                somaDiagonalSecundaria += matrizA[i, matrizA.GetLength(0) - 1 - i];
            }

            //Saída da Matriz
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    Console.Write(matrizA[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Verificação das somas
            if (somaDiagonalPrincipal == somaDiagonalSecundaria)
            {
                Console.WriteLine("A soma dos elementos da diagonal principal é igual à soma dos elementos da diagonal secundária.");
            }
            else
            {
                Console.WriteLine("A soma dos elementos da diagonal principal é diferente da soma dos elementos da diagonal secundária.");
            }

            Console.ReadLine();
        }
    }
}


//13) Escreva um programa que leia uma matriz de ordem 5 (ou seja, 5x5)
// e verifique se a soma dos elementos da diagonal principal é igual a soma dos elementos da 
// diagonal secundária.
