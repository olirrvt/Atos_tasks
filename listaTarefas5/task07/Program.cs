namespace Vetores;
class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[10];

        for(int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Digite o valor do {i + 1}° número: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Os números Pares da lista:");
        for(int i = 0; i < numeros.Length; i++)
        {
            if(numeros[i] % 2 == 0)
            {
                Console.Write($"{numeros[i]} |");
            }
        }
    }
}

// 7.	Fazer um algoritmo que leia dez números inteiros armazenando-os em um vetor e escreva primeiramente todos os números pares lidos e após todos os ímpares. Exemplo:
// a.	lê: 		|7|40|3|9|21|0|63|31|7|22|
// b.	escreve: 	|40|0|22|7|3|9|21|63|31|7|