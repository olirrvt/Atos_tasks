namespace Vetores;
class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[10];
        int menorValor = int.MaxValue;
        int indiceDoMenorValor = 0;
        
        for(int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Digite o valor do {i + 1}° número: ");
            numeros[i] = int.Parse(Console.ReadLine());

            // Procurando o menor valor na lista
            menorValor = numeros[i] < menorValor ? numeros[i] : menorValor;
        }

        // Procurando a posição do menor valor
        // Método indexOf.
        indiceDoMenorValor = Array.IndexOf(numeros, menorValor);

        Console.WriteLine($"O menor valor da lista é o {menorValor}");
        Console.WriteLine($"Ele está na posição {indiceDoMenorValor + 1}");
    }
}

// 5.	Escreva um algoritmo que leia um vetor de 80 elementos inteiros. Encontre e mostre o menor elemento e a sua posição.
