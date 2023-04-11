namespace HelloWorld;
class Program
{
    static void Main(string[] args)
    {
        int nAlunos, nProvas;
        double nota = 0, media = 0;

        Console.Write("Digite o número de alunos que tem na turma: ");
        nAlunos = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de avaliações que foram passadas para a turma: ");
        nProvas = int.Parse(Console.ReadLine());
        
        for(int i = 1; i <= nAlunos; i++)
        {
            double somaNotas = 0;
            for(int j = 1; j <= nProvas; j++)
            {
                Console.WriteLine($"Quantos pontos o {i}° aluno tirou na {j}° avaliação?");
                nota = double.Parse(Console.ReadLine());
                somaNotas += nota;
            }
                media = somaNotas / nProvas;
                Console.WriteLine($"A média do {i}° aluno final foi {media}");
        }
    }
}