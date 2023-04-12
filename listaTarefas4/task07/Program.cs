namespace MainProgram;
class Program
{
    static void Main(string[] args)
    {
        int idade;
        string nome;
        double salario;

        Console.Write("Digite o seu nome: ");
        nome = Console.ReadLine();

        for(;true;)
        {   
            // Se o nome for um número
            if(nome.All(char.IsDigit) && !(nome == ""))
            {
                Console.Write("O nome não pode ser um número. Por favor, insira o seu nome.");
                break;
            }
            // Se o nome estiver vazio
            else if(string.IsNullOrWhiteSpace(nome))
            {
                Console.Write("O nome não pode estar vazio. Por favor, digite um nome.");
                break;
            }
            // Caso as condições do NOME estejam corretas. Iremos ver a idade.
            else
            {
                Console.Write("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());

                for(;true;)
                {
                    if(idade <= 0)
                    {
                        Console.WriteLine("Idade inválida, tente digitar outra idade.");
                        break;
                    }
                    else
                    {
                        for(;true;)
                        {
                            Console.Write("Informe o seu salário: ");
                            salario = double.Parse(Console.ReadLine());

                            if(salario <= 0)
                            {
                                Console.WriteLine("O salário está inválido.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Informações do Funcionário");
                                Console.WriteLine("---------------------------");
                                Console.WriteLine($"Nome do Funcionário: {nome}");
                                Console.WriteLine($"Idade do Funcionário: {idade}");
                                Console.WriteLine($"Salário do Funcionário: {salario}");
                                break;
                            }
                        }
                        break;
                    }
                }
                break;
            }
        }

    }
}