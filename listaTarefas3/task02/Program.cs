namespace HelloWorld;
class Program
{
    static void Main(string[] args)
    {
        int numX;

        Console.WriteLine("Digite um número que deseje fazer a tabuada:");
        numX = int.Parse(Console.ReadLine());

        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"{i} x {numX} = {numX * i}");
        }

    }
}