using System.Reflection;

namespace task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrizA = new int[4, 4];

            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    Console.Write($"Digite o elemento [{i}, {j}] da matriz: ");
                    matrizA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Elementos da diagonal principal:");

            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                Console.Write($"{matrizA[i, i]} | ");
                // Exibe o valor da diagonal principal
            }
            
            Console.WriteLine();
        }
    }

}

// 3) Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!
/*

    6  3  3  3 
    3  4  3  3
    3  3  5  3
    3  3  3  6
 */