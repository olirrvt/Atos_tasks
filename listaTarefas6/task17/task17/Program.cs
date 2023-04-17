using System;

namespace task17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrizA = new int[10, 10];
            Random random = new Random();

            // Leitura da Matriz A com números Aleatórios
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    matrizA[i, j] = random.Next(0, 50);
                }
            }

            // Encontrar o maior elemento da matriz e a linha onde ele está
            int maior = matrizA[0, 0];
            int linhaMaior = 0;
            int colunaMaior = 0;

            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    if (matrizA[i, j] > maior)
                    {
                        maior = matrizA[i, j];
                        linhaMaior = i;
                        colunaMaior = j;
                    }
                }
            }

            // Encontrar o menor elemento da linha onde o maior elemento está
            int menor = matrizA[linhaMaior, 0];

            for (int j = 0; j < matrizA.GetLength(1); j++)
            {
                if (matrizA[linhaMaior, j] < menor)
                {
                    menor = matrizA[linhaMaior, j];
                }
            }

            // Imprimir o resultado
            Console.WriteLine($"O menor elemento da linha {linhaMaior + 1} que contém o maior elemento {maior} é {menor}");
            Console.WriteLine($"Linha: {linhaMaior + 1}, Coluna: {colunaMaior + 1}");
        }
    }
}

// 17) Desafio: Fazer um algoritmo que leia uma matriz de 10 linhas por 10 colunas
// e escreva o elemento minimax, ou seja, o menor elemento da linha onde se encontra o 
// maior elemento da matriz. Escreva também a linha e a coluna onde foi encontrado.
