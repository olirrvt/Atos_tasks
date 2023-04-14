using System;

namespace HelloWorld;
class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[100];
        int qtdVezesAparece2 = 0, qtdVezesAparece4 = 0, qtdVezesAparece8 = 0;
        for(int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Digite o {i + 1}° número da lista: ");
             numeros[i] = int.Parse(Console.ReadLine());
             if(numeros[i] == -1)
             {
                break;
             }
        }
        for(int i = 0; i < numeros.Length; i++)
        {
            if(numeros[i] == 2)
            {
                qtdVezesAparece2++;
            }
            if(numeros[i] == 4)
            {
                qtdVezesAparece4++;
            }
            if(numeros[i] == 8)
            {
                qtdVezesAparece8++;
            }
        }
        Console.WriteLine($"Quantidade de vezes que aparece o número '2': {qtdVezesAparece2} vezes.");
        Console.WriteLine($"Quantidade de vezes que aparece o número '4': {qtdVezesAparece4} vezes.");
        Console.WriteLine($"Quantidade de vezes que aparece o número '8': {qtdVezesAparece8} vezes.");
    }
}