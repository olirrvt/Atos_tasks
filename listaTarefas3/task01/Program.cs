namespace HelloWorld;
class Program
{
    static void Main(string[] args)
    {
        int num, max = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Digite o {i}º número: ");
            num = int.Parse(Console.ReadLine());

            if (num > max)
            {
                max = num;
            }
        }

        Console.WriteLine($"O maior número digitado foi: {max}");
    }
}