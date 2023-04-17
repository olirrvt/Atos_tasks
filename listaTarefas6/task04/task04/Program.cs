using System.Reflection;

namespace task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qtdPares = 0, qtdimpares = 0, qtdPositivos = 0, qtdNegativos = 0, qtdZero = 0;
            int[,] matrizA = new int[5, 5];

            for(int i = 0; i < matrizA.GetLength(0); i++)
            {
                for(int j = 0; j < matrizA.GetLength(1); j++)
                {
                    Console.WriteLine($"Digite o elemento [{i}, {j}] da matriz:");
                    matrizA[i, j] = int.Parse(Console.ReadLine());
                } 
            }
            
            for(int i = 0; i < matrizA.GetLength(0); i++)
            {
                for(int j = 0; j < matrizA.GetLength(1); j++)
                {
                    // Par ou impar?
                    if (matrizA[i, j] % 2 == 0)
                    {
                        qtdPares++;
                    }
                    else
                    { 
                        qtdimpares++; 
                    }

                    // Positivo, negativo ou zero?
                    if (matrizA[i, j] > 0)
                    {
                        qtdPositivos++;
                    }
                    else if (matrizA[i, j] == 0)
                    {
                       qtdZero++;
                    }
                    else 
                    { 
                        qtdNegativos++;
                    }
                }
            }

            Console.WriteLine("INFORMAÇÕES DOS NÚMEROS");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"Quantidade de números pares: {qtdPares} números");
            Console.WriteLine($"Quantidade de números ímpares: {qtdimpares} números");
            Console.WriteLine($"Quantidade de números positivos: {qtdPositivos} números");
            Console.WriteLine($"Quantidade de números negativos: {qtdNegativos} números");
            Console.WriteLine($"Quantidade de zeros: {qtdZero} zeros");
            Console.WriteLine("-------------------------------------------------");
        }
    }
}

// 4) Popule uma matriz 5x5 e informe:
// - Quantos números são pares
// - Quantos números são impares
// - Quantos números são positivos
// - Quantos números são negativos
// - Quantos zeros existem!