namespace HelloWorld;

class Program
{

    // 15 - Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados 
    // da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados 
    // e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00. 
    // Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.

    static void Main(string[] args)
    {
        
     int litrosPorMetros = 3;
     int litrosPorLatas = 18;
     double precoPorLatas = 80.0;

    Console.WriteLine("Loja de Tintas - Cálculo de Quantidade de Latas e Preço Total");
    Console.Write("Digite a área a ser pintada em metros quadrados: ");
    int area = int.Parse(Console.ReadLine());

    // Calculando a área para ser pintada => Quantos litros por metros e quantas latas.
    int litrosNecessarios = area / litrosPorMetros;
    int latasNecessarias = (int)Math.Ceiling((double)litrosNecessarios / litrosPorLatas);

    // Calculando o preço total das tintas
    double precoTotal = latasNecessarias * precoPorLatas;

    Console.WriteLine();
    Console.WriteLine($"Quantidade de Latas: {latasNecessarias}");
    Console.WriteLine($"Preço Total: R$ {precoTotal.ToString("F2")}");

    }
}