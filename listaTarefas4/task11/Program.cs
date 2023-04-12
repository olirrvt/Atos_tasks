namespace HelloWorld;
class Program
{
    static void Main(string[] args)
    {
        int qtdAlunos = 0;
        float notas, notaAlta = 0, notaBaixa = float.MaxValue, auxNotaBaixa;
        // Nota baixa é iniciada com o máximo valor para que o valor que o valor seja sempre o mais baixo possível.

        for(int i = 1; true ; i++)
        {
            // Coletando informações
            Console.WriteLine("Se deseja encerrar o programa, digite '-1'.");
            Console.Write($"Digite a nota do {i}° aluno: ");
            notas = float.Parse(Console.ReadLine());

            if(notas == -1)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("CLASSIFICAÇÃO DAS NOTAS");
                Console.WriteLine("-----------------------");
                Console.WriteLine($"Nota mais alta: {notaAlta}");
                Console.WriteLine($"Nota mais baixa: {notaBaixa}");
                Console.WriteLine("-----------------------");
                Console.WriteLine($"Quantidade de Alunos na Turma: {qtdAlunos}");
                break;
            }

            // Verificando se a nota é mais alta
            notaAlta = notas > notaAlta ? notas : notaAlta;

            // Verificando se a nota é a mais baixa
            auxNotaBaixa = notas;
            notaBaixa = auxNotaBaixa < notaBaixa ? auxNotaBaixa : notaBaixa;

            qtdAlunos++;
        }


    }
}

// 11. Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa, 
// a média aritmética da turma e a quantidade de alunos da turma. Usar -1 para encerrar a leitura.
