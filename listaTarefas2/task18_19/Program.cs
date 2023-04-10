namespace HelloWorld;
class Program
{
    static void Main(string[] args)
    {

        // Informações de entrada
        
        int n1, n2, n3;

        Console.WriteLine("Digite o primeiro número:");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o terceiro número:");
        n3 = int.Parse(Console.ReadLine());

        // Lógica para falar qual número é maior.

        if(n1 > n2 && n1 > n3 )
        {
            Console.WriteLine($"N1 maior: {n1}.");
        }
        if(n2 > n1 && n2 > n3)
        {
            Console.WriteLine($"N2 maior: {n2}.");
        }
        if(n3 > n1 && n3 > n2)
        {
            Console.WriteLine($"N3 maior: {n3}.");
        }


        // Lógica do Task 19

        Console.WriteLine("Ordem crescente");

        // Caso o número 1 seja maior.

        if(n1 > n2 && n1 > n3)
        {
                Console.WriteLine(n1);
            if(n2 > n3)
            {
                Console.WriteLine(n2);
            }
            else if(n3 > n2)
            {
                Console.WriteLine(n3);
            }
        }

        // Caso o número 2 seja maior.

        if(n2 > n1 && n2 > n3)
        {
                Console.WriteLine(n2);
            if(n1 > n3)
            {
                Console.WriteLine(n1);
            }
            else if(n3 > n1)
            {
                Console.WriteLine(n3);
            }
        }

        // Caso o número 3 seja maior.

        if(n3 > n1 && n3 > n2)
        {
                Console.WriteLine(n3);
            if(n1 > n2)
            {
                Console.WriteLine(n1);
            }
            else if(n2 > n1)
            {
                Console.WriteLine(n2);
            }
        }

    }
}