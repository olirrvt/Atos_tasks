using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, m, resultado;

            Console.Write("Digite o valor de uma base: ");
            n = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de um expoente: ");
            m = double.Parse(Console.ReadLine());

            resultado = Math.Pow(n, m);
            Console.Write($"O valor {n} elevado a {m} é igual a {resultado}");
        }
    }
}

// 18. Elaborar um programa que apresente o valor de uma potência de uma base qualquer 
// elevada a um expoente qualquer, ou seja, NM.