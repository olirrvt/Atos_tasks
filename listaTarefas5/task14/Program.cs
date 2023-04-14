using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listaDeNumeros = new int[10];
            Console.WriteLine("Para o código, considere que:");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("0- Termina o Algoritmo");
            Console.WriteLine("1- Mostra o valor na ordem correta");
            Console.WriteLine("2- Mostra o valor na ordem inversa");
            Console.WriteLine("-----------------------------------");
            while (true)
            {
                for(int i = 0; i < listaDeNumeros.Length; i++)
                {
                    Console.Write($"Digite o valor do {i + 1}° número: ");
                    listaDeNumeros[i] = int.Parse(Console.ReadLine());
                }
                Console.Write($"Digite um código do procedimento: ");
                int codigoNumerico = int.Parse(Console.ReadLine());
                switch (codigoNumerico)
                {
                    case 0:
                        return;
                    case 1:
                        Console.WriteLine("Vetor na ordem em que foi lido:");
                        for (int i = 0; i < listaDeNumeros.Length; i++)
                        {
                            Console.Write($"{listaDeNumeros[i]} ");
                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("Vetor na ordem inversa:");
                        for (int i = listaDeNumeros.Length - 1; i >= 0; i--)
                        {
                            Console.Write($"{listaDeNumeros[i]} ");
                        }
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Código inválido. Tente novamente.");
                        break;
                }
            }
        }
    }
}