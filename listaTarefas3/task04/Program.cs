namespace HelloWorld;
class Program
{
    static void Main(string[] args)
    {
        int numX;

        Console.Write("Digite o número que você deseja calcular o fatorial: ");
        numX = int.Parse(Console.ReadLine());

        int fat = 1;
        for (int i = 1; i <= numX; i++)
        {
            fat *= i;
        }

        Console.WriteLine($"O fatorial de {numX} é {fat}");
    }
}