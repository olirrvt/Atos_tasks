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
        
        // Mostrando a entrada original
        Console.WriteLine("Entrada original: ");
        for(int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"{numeros[i]} |");
        }

        // Invertendo as ordens
        Array.Reverse(numeros);

        Console.WriteLine("");
        Console.WriteLine("Reverso: ");
        for(int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"{numeros[i]} |");
        }
    }
}

// 6.	Fazer um algoritmo que leia dez números e escreva-os na ordem contrária à ordem de leitura. Exemplo:
// a.	lê: 		|7|40|3|9|21|0|63|31|7|22|
// b.	escreve: 	|22|7|31|63|0|21|9|3|40|7|
