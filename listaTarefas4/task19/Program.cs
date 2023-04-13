namespace HelloWorld;
class Program
{
    static void Main(string[] args)
    {
        bool next = true;
        string opcao;
        int numFilhos, qtdPessoasSalarioAte100 = 0, qtdPessoas = 0;
        double salario, maiorSalario = -1, mediaFilhos = 0, mediaSalario = 0;
        while(next)
        {
            // Somando a quantidade de pessoas
            qtdPessoas++;
            Console.WriteLine("Quantos filhos você tem?");
            numFilhos = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o seu salário?");
            salario = double.Parse(Console.ReadLine());
            // Tirando a média dos dados
            mediaFilhos = numFilhos / (double)qtdPessoas;
            mediaSalario = salario / qtdPessoas;
            // Verificando o maior salário
            maiorSalario = salario > maiorSalario ? salario : maiorSalario;
            // Verificando se o salário vai até 100
            if (salario <= 100)
            {
                qtdPessoasSalarioAte100++;
            }
            // Perguntando se a pessoa quer encerrar o programa
            Console.WriteLine("Deseja cadastrar os dados de outra pessoa (S/N)?");
            opcao = Console.ReadLine().ToLower();
            if (opcao == "n")
            {
                next = false;
            }
        }
        double percentualPessoasSalarioAte100 = (qtdPessoasSalarioAte100 / (double)qtdPessoas);
        // Resposta
        Console.WriteLine("-------------------------");
        Console.WriteLine("INFORMAÇÕES DA POPULAÇÃO");
        Console.WriteLine("-------------------------");
        Console.WriteLine($"Média de número de filhos: {mediaFilhos}");
        Console.WriteLine($"Média dos salários: {mediaSalario}");
        Console.WriteLine($"O maior dos salários: {maiorSalario}");
        Console.WriteLine($"Percentual de pessoas com salário até R$100: {percentualPessoasSalarioAte100}");
        Console.WriteLine("-------------------------");
    }
}
// 19. A prefeitura de uma cidade fez uma pesquisa entre seus habitantes,
// coletando dados sobre o salário e número de filhos. A prefeitura deseja saber:
// a) média do salário da população;
// b) média do número de filhos;
// c) maior salário;
// d) percentual de pessoas com salário até R$ 100,00.
// O final da leitura de dados se dará com a entrada de um salário negativo.