namespace HelloWorld;
class Program
{
    static void Main(string[] args)
    {
        int numero;


        for(;true;)
        {
            Console.Write($"Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            if(numero == 0)
            {
                Console.WriteLine("Finalizado.");
                break;
            }
            else if(numero % 2 == 0)
            {
                Console.WriteLine($"O número {numero} é par.");
                continue;
            }
            else
            {
                Console.WriteLine($"O número {numero} é ímpar.");
                continue;
            }

        }

    }
}