using System;

namespace task06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrizA = new int[5, 5];
            int maiorValor = -1;
            // Numero Aleatorio
            Random random = new Random();
            
            // Leitura da Matriz com números Aleatórios
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    matrizA[i, j] = random.Next(0, 9);
                }
            }            
            
            // Encontrando o  maior valor da matriz
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    maiorValor = matrizA[i, j] > maiorValor ? matrizA[i, j] : maiorValor;
                }
            }

            Console.WriteLine($"O maior valor da matriz é: {maiorValor}");
            
        }
    }
}

//6) Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0-9.
//Após isso determine o maior número da matriz.
//Random random = new Random();
//int randomNumber = random.Next(0, 100);
