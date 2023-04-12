using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int quadrado;

            for (int i = 15; i <= 200; i++)
            {
                quadrado = i * i;
                Console.WriteLine($"O quadrado de {i} é {quadrado}");
            }
        }
    }
}


// 17. Apresentar os quadrados dos números inteiros de 15 a 200.