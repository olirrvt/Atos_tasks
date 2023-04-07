namespace HelloWorld;

class Atletas
{

    // 10 - Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).
    // O programa deve mostrar os dados do atleta mais novo e mais alto.

    static void Main(string[] args)
    {
        string nomeA, nomeB;
        int idadeA, idadeB;
        double alturaA, alturaB;

        // Informações do Primeiro Atleta

        Console.WriteLine("Digite o nome do primeiro atleta:");
        nomeA = Console.ReadLine();

        Console.WriteLine("Digite a idade do primeiro atleta:");
        idadeA = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a altura do primeiro atleta:");
        alturaA = double.Parse(Console.ReadLine());

        // Informações do Segundo Atleta

        Console.WriteLine("Digite o nome do segundo atleta:");
        nomeB = Console.ReadLine();

        Console.WriteLine("Digite a idade do segundo atleta:");
        idadeB = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a altura do segundo atleta:");
        alturaB = double.Parse(Console.ReadLine());

        // Mostrar os dados do atleta mais novo e mais alto.

        if(idadeA < idadeB)
        {
            Console.Write($"O atleta {nomeA} é mais novo");

            if(alturaA > alturaB)
            {
                Console.Write($" e mais alto");
            }
            else
            {
                Console.Write(", mas não é mais alto");
            }

        }
        else if(idadeB < idadeA)
        {
            Console.Write($"O atleta {nomeB} é mais novo");

            if(alturaB > alturaA)
            {
                Console.Write($" e mais alto");
            }
            else
            {
                Console.Write(", mas não é mais alto");
            }
        }
        else
        {
            Console.WriteLine("Os atletas possuem a mesma idade e altura!");
        }

    }
}