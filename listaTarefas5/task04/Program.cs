namespace Vetores;
class Program
{
    static void Main(string[] args)
    {
        // Vetor 1
        int[] num1 = new int[10];
        // Vetor 2
        int[] num2 = new int[10];
        // Vetor para multiplicar
        int[] multiplicador = new int[10]; 

        Console.WriteLine("1° LISTA DE NÚMEROS");
        for(int i = 0; i < num1.Length; i++)
        {
            Console.Write($"Digite o valor do {i + 1}° número: ");
            num1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("2° LISTA DE NÚMEROS");
        for(int i = 0; i < num2.Length; i++)
        {
            Console.Write($"Digite o valor do {i + 1}° número: ");
            num2[i] = int.Parse(Console.ReadLine());
        }

        // Multiplicando os números
        for(int i = 0; i < multiplicador.Length; i++)
        {
            multiplicador[i] = num1[i] * num2[i];
        }
        
        // Mostrando os números
        Console.WriteLine("RESULTADO DAS MULTIPLICAÇÕES");
        for(int i = 0; i < multiplicador.Length; i++)
        {
            Console.WriteLine($"Os números na posição {i} multiplicados resulta em {multiplicador[i]}");
        }
    }
}

// 4.	Escreva um algoritmo que leia dois vetores de 10 posições e faça a multiplicação dos elementos de mesmo índice, colocando o resultado em um terceiro vetor. Mostre o vetor resultante.