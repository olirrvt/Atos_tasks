using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[10];

            for (int i = 0; i < valores.Length; i++)
            {
                Console.Write($"Digite o valor do {i + 1}° número: ");
                valores[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(valores);

            Console.WriteLine("Valores ordenados:");

            for (int i = 0; i < valores.Length; i++)
            {
                Console.Write($" {valores[i]} |");
            }
        }
    }
}


// 9.	Escreva um algoritmo que leia os valores para um vetor de 10 elementos, 
//e em seguida ordene em ordem crescente os valores desse vetor, utilizando um vetor auxiliar.