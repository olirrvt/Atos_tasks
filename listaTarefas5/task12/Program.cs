using System.Linq;
using System;
namespace HelloWorld;
class Program
{
    static void Main(string[] args)
    {
        int[] valores = new int[10];
        int numeroEscolhido, posicaoDoNumeroEscolhido;
        bool numeroExiste;
        for(int i = 0; i < valores.Length; i++)
        {
            Console.Write($"Digite o valor do {i + 1}° número: ");
            valores[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Digite um número que deseja procurar: ");
        numeroEscolhido = int.Parse(Console.ReadLine());
        numeroExiste = valores.Contains(numeroEscolhido);
        if(numeroExiste)
        {
            posicaoDoNumeroEscolhido = Array.IndexOf(valores, numeroEscolhido);
            Console.WriteLine($"O número {numeroEscolhido} existe na lista.");
            Console.WriteLine($"E se encontra na posição {posicaoDoNumeroEscolhido} da lista.");
        }
        else
        {
            Console.WriteLine($"O número {numeroEscolhido} não existe na lista.");
        }
    }
}