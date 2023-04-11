namespace HelloWorld;
class Program
{
    static void Main(string[] args)
    {
        int idade;
        
        Console.Write("Informe sua idade: ");

        for(;true;)
        {
            idade = int.Parse(Console.ReadLine());

            if(idade > 0)
            {
                Console.WriteLine($"Sua idade é {idade}.");
                break;
            }

            Console.Write("Idade inválida, digite uma idade: ");
        }

    }
}

// 6. Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados, 
// ou seja, repita a leitura até que ela esteja correta (maior do que zero). 
// Ao final, mostre a idade digitada.