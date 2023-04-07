using System;
namespace HelloWorld;


class Vendas
{
    // 8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
    // Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas.
    // Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas.
    // E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10% do 
    // total de vendas.

    static void Main(string[] args)
    {
        int codigo;
        double salario, salarioFinal, acrescimo, totalVendas;
        string nome;

        Console.WriteLine("Digite o seu nome:");
        nome = Console.ReadLine();

        Console.WriteLine("Digite o seu código:");
        codigo = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o seu salário:");
        salario = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o seu total de vendas no mês:");
        totalVendas = double.Parse(Console.ReadLine());

        if(totalVendas >= 500 && totalVendas < 1000)
        {
            acrescimo = 0.05 * salario;
            salarioFinal = acrescimo + salario;

            Console.WriteLine("_____________________");
            Console.WriteLine("");
            Console.WriteLine($"Nome do Funcionário: {nome}");
            Console.WriteLine($"Código do Funcionário: {codigo}");
            Console.WriteLine($"O seu total de vendas: {totalVendas}");
            Console.WriteLine($"Reajuste do salário: 5%");
            Console.WriteLine($"Esse é o seu salário final: {salarioFinal}");
            Console.WriteLine("_____________________");

        }
        else if(totalVendas > 1000 && totalVendas < 5000)
        {

            acrescimo = 0.07 * salario;
            salarioFinal = acrescimo + salario;

            Console.WriteLine("_____________________");
            Console.WriteLine("");
            Console.WriteLine($"Nome do Funcionário: {nome}");
            Console.WriteLine($"Código do Funcionário: {codigo}");
            Console.WriteLine($"O seu total de vendas: {totalVendas}");
            Console.WriteLine($"Reajuste do salário: 7%");
            Console.WriteLine($"Esse é o seu salário final: {salarioFinal}");
            Console.WriteLine("_____________________");
        }
        else if (totalVendas > 5000)
        {
            acrescimo = 0.10 * salario;
            salarioFinal = acrescimo + salario;

            Console.WriteLine("_____________________");
            Console.WriteLine("");
            Console.WriteLine($"Nome do Funcionário: {nome}");
            Console.WriteLine($"Código do Funcionário: {codigo}");
            Console.WriteLine($"O seu total de vendas: {totalVendas}");
            Console.WriteLine($"Reajuste do salário: 10%");
            Console.WriteLine($"Esse é o seu salário final: {salarioFinal}");
            Console.WriteLine("_____________________");

        }

    }

}