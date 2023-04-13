namespace Matrizes;
class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[10];
        int pares = 0, impares = 0;

        for(int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Digite o valor do {i + 1}° número: ");
            numeros[i] = int.Parse(Console.ReadLine());

             if(numeros[i] % 2 == 0)
             {
                pares++;
             }
             else
             {
                impares++;
             }
        }

        Console.WriteLine($"Quantidade de números pares: {pares} números");
        Console.WriteLine($"Quantidade de números impares: {impares} números");
    }
}

// Escreva um algoritmo que leia os valores para um vetor de 10 elementos e então mostre na tela a quantidade de números pares e ímpares.