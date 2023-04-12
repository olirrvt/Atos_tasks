namespace HelloWorld;
class Program
{
    static void Main(string[] args)
    {
        string opcao;
        bool next = true;
        int peso1 = 2, peso2 = 1, peso3 = 2, peso4 = 4, somaDosPesos = 9;
        double nota1, nota2, nota3, nota4, mediaPonderada = 0;

        do
        {   
            Console.Write("Digite a primeira nota do aluno: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota do aluno: ");
            nota2 = double.Parse(Console.ReadLine());
            
            Console.Write("Digite a terceira nota do aluno: ");
            nota3 = double.Parse(Console.ReadLine());

            Console.Write("Digite a quarta nota do aluno: ");
            nota4 = double.Parse(Console.ReadLine());

            // Tirando a média ponderada
            mediaPonderada = ((nota1 * peso1) + (nota2 * peso2) + (nota3 * peso3) + (nota4 * peso4)) /  somaDosPesos;

            double mediaArredondada = Math.Round(mediaPonderada, 2);

            if(mediaArredondada >= 7)
            {
                Console.WriteLine("APROVADO");
                Console.WriteLine($"A média desse aluno foi {mediaArredondada}.");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"A média desse aluno foi {mediaArredondada}.");
            }
            

            // Verificando se o usuário ainda quer continuar o programa
            Console.Write("Deseja saber a média de mais um aluno (S/N)? ");
            opcao = Console.ReadLine().ToLower();

            next = opcao == "n" ? false : true;
        }
        while(next);
    }
}

// Média ponderada é o peso / peso das notas 
// 15. Ler 4 valores referentes a notas escolares de um aluno e imprimir uma mensagem dizendo se ele está aprovado 
// ou reprovado, após ter calculado sua média ponderando, considerando pesos 2, 1, 2, e 4, respectivamente. 
// Considerar nota 7,0 como mínima para aprovação.
