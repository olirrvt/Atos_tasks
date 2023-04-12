namespace HelloWorld;
class Program
{
    static void Main(string[] args)
    {
        int somaNum = 0;

        for(int i = 1; i <= 100; i++)
        {
            somaNum += i;
        }

        Console.WriteLine($"A soma dos 100 primeiros números inteiros é: {somaNum}.");
    }
}