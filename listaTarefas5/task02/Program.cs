namespace Vetores;
class Program
{
    static void Main(string[] args)
    {
        int[] num1 = new int[20];
        int[] num2 = new int[20];
        int[] somaNum = new int [20];

        // Pegando a primeira lista
        Console.WriteLine("1° LISTA DE NÚMEROS");
        for(int i = 0; i < num1.Length; i++)
        {
            Console.Write($"Digite o {i + 1}° número da lista: ");
            num1[i] = int.Parse(Console.ReadLine());
        } 

        // Pegando a segunda lista
        Console.WriteLine("2° LISTA DE NÚMEROS");
        for(int i = 0; i < num2.Length; i++)
        {
            Console.Write($"Digite o {i + 1}° número da lista: ");
            num2[i] = int.Parse(Console.ReadLine());
        }

        // Fazendo a soma das listas
        for(int i = 0; i < somaNum.Length; i++)
        {
            somaNum[i] = num1[i] + num2[i];
        }
        Console.WriteLine("SOMA DAS LISTAS");
        for(int i = 0; i < somaNum.Length; i++)
        {
            Console.WriteLine($"O valor da soma dos índices {i} é {somaNum[i]}");
        }
    }
}


// 2.	Escreva um algoritmo que leia valores para dois vetores de 20 elementos e então realize a soma dos elementos da mesma posição, armazenando o resultado em um outro vetor.