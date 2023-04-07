namespace HelloWorld;

class CalculadoraImc
{  
// 6 - Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma pessoa.
// O programa deve calcular o Indice de Massa Corpórea (IMC), exibi-lo ao usuário e informar sua situação conforme a tabela.

// O cálculo do imc = peso / (altura * altura)
// IMC

// menor que 18                 -> baixo peso
// maior que 18 e menor que 25  -> peso normal
// maior que 25 e menor que 30  -> sobrepeso
// maior que 30 e menor que 35  -> obesidade
// maior que 35                 -> obesidade grau sério

    static void Main(string[] args)
    {
        string nome;
        double altura, peso, imc, calculo;

        Console.WriteLine("Digite o seu nome em caixa alta:");
        nome = Console.ReadLine().ToUpper();

        Console.WriteLine("Digite o seu peso:");
        peso = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a sua altura:");
        altura = double.Parse(Console.ReadLine());

        
        // Lógica do IMC
        calculo =  peso / (altura * altura);
        // Arredondei os números decimais com o método Math.Round
        imc = Math.Round(calculo * 10000,2);

        Console.WriteLine(imc);

        // Lógica da Tabela
        if(imc < 18)
        {
            Console.WriteLine($"{nome}, O seu IMC é igual a {imc}. Você está em BAIXO PESO");
        }
        else if(imc > 18 && imc < 25)
        {
            Console.WriteLine($"{nome}, O seu IMC é igual a {imc}. Você está com o PESO NORMAL");
        }
        else if(imc > 25 && imc < 30)
        {
            Console.WriteLine($"{nome}, O seu IMC é igual a {imc}. Você está em SOBREPESO");
        }
        else if(imc > 30 && imc < 35)
        {
            Console.WriteLine($"{nome}, O seu IMC é igual a {imc}. Você está em OBESIDADE");
        }
        else
        {
            Console.WriteLine($"{nome}, O seu IMC é igual a {imc}. você está em OBESIDADE");
        }


    }
}