namespace HelloWorld;
class Program
{
    static void Main(string[] args)
    {
        int x, y, potencia = 1;

        Console.Write("Digite o valor de x: ");
        x = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor de y: ");
        y = int.Parse(Console.ReadLine());

        for (int i = 1; i <= y; i++)
        {
            potencia *= x;
        }
        
        Console.WriteLine($"{x} elevado a {y} é igual a {potencia}");
    }
}