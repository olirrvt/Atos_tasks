using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numLista = new int[20];

            for (int i = 0; i < numLista.Length; i++)
            {
                Console.Write($"Digite o valor do {i + 1}° número: ");
                numLista[i] = int.Parse(Console.ReadLine());

                int num = numLista[i];
                bool numeroPrimo = true;

                for (int j = 2; j < num; j++)
                {
                    if (num % j == 0)
                    {
                        numeroPrimo = false;
                        break;
                    }
                }

                if (numeroPrimo)
                {
                    Console.WriteLine($"O número {num} é primo.");
                }
                else
                {
                    Console.WriteLine($"O número {num} não é primo.");
                }
            }
        }
    }
}


// 3.	Escreva um algoritmo que leia os valores para um vetor de 20 elementos e então mostre na tela o índice da posição dos valores correspondentes a números primos.
