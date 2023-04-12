namespace HelloWorld;
class Program
{
    static void Main(string[] args)
    {
        int qtdFilhos;
        int entre1e3 = 0, entre4e7 = 0, maisq8 = 0, semFilho = 0;
        
        for(int i = 1; i < 30; i++)
        {
            Console.WriteLine($"Você é a {i}° pessoa da pesquisa, quantos filhos você tem?");
            qtdFilhos = int.Parse(Console.ReadLine());

            // Condição Ternária para verificar a quantidade de filhos de cada pessoa
            entre1e3 = qtdFilhos >= 1 && qtdFilhos <= 3 ? entre1e3 + 1 : entre1e3;
            entre4e7 = qtdFilhos > 4 && qtdFilhos < 7 ? entre4e7 +1 : entre4e7;
            maisq8 = qtdFilhos > 8 ? maisq8 +1 : maisq8;
            semFilho = qtdFilhos == 0 ? semFilho +1 : semFilho;
        }
            Console.WriteLine($"-------------------------");
            Console.WriteLine($"Número total da pesquisa");
            Console.WriteLine($"-------------------------");
            Console.WriteLine("");
            Console.WriteLine($"Pessoas com filhos entre 1 e 3: {entre1e3} pessoas");
            Console.WriteLine($"Pessoas com filhos entre 4 e 7: {entre4e7} pessoas");
            Console.WriteLine($"Pessoas com filhos mais de 8 filhos: {maisq8} pessoas");
            Console.WriteLine($"Pessoas sem filhos: {semFilho} pessoas");
            Console.WriteLine("");
            Console.WriteLine($"-------------------------");
        
    }
} 
