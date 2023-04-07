using System;
namespace HelloWorld;

class FindByString
{
    static void Main(string[] args)
    {
        string palavra, frase, palavraMin, fraseMin;

        Console.WriteLine("Digite uma frase: ");
        frase = Console.ReadLine();
        fraseMin = frase.ToLower();

        Console.WriteLine("Digite uma palavra: ");
        palavra = Console.ReadLine();
        palavraMin = palavra.ToLower();

        if(fraseMin.Contains(palavraMin))
        {
            Console.WriteLine($"A palavra {palavra} está dentro da frase: {frase} ");
        }
        else
        {
            Console.WriteLine("A palavra não foi encontrada!");
        }

    }
}