namespace HelloWorld;
class Program
{
    static void Main(string[] args)
    {
        int somaPares = 0;

        for(int i = 1; i <= 500; i++)
        {
            if(i % 2 == 0)
            {
                somaPares += i;
            }
        }

        Console.WriteLine($"A soma dos números pares de 1 a 500 é {somaPares}.");
    }
}

// 13. Elaborar um programa que apresente o somatório dos valores pares existentes 
// entre 1 e 500.