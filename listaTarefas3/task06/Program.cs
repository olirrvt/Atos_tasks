namespace HelloWorld;
class Program
{
    // 6- Escreva um programa em C# leia 20 números e que conte a quantidade de números pares e ímpares digitados por 
    // um usuário. Apresente o resultado.

    static void Main(string[] args)
    {
        int numeros, impares = 0, pares = 0;

        for(int i = 0; i <= 20; i++)
        {
            Console.Write($"Digite 20 números ({i}): ");
            numeros = int.Parse(Console.ReadLine());

            if (numeros % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }
        }

        Console.WriteLine($"Numeros Pares: {pares} números.");
        Console.WriteLine($"Numeros Impares: {impares} números.");

    }
}