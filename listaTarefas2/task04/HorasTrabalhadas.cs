namespace HelloWorld;
class HorasTrabalhadas
{

    // 4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora recebido por cada um deles. 
    // Mostrar na tela qual dos professores tem o maior salário total.

    static void Main(string[] args)
    {
        int horas1, horas2, numMes;
        double salario1, salario2, total1, total2;
        string diaDoMes;

        // Lógica do dia do mês para calcular o salário

        Console.WriteLine("Em qual mês você quer calcular o salário do professor?");
        diaDoMes = Console.ReadLine().ToLower();

        if ((diaDoMes == "abril") || (diaDoMes == "junho") || (diaDoMes == "setembro") || (diaDoMes == "novembro"))
        {
            numMes = 30;
        }
        else if(diaDoMes == "fevereiro")
        {
            numMes = 28;
        }
        else
        {
            numMes = 31;
        }

        // Informações do Primeiro Professor.

        Console.WriteLine("Quantas horas o primeiro professor trabalha por dia?");
        horas1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Quanto o primeiro professor ganha por hora?");
        salario1 = double.Parse(Console.ReadLine());

        total1 = (horas1 * salario1) * numMes;

        // Informações do segundo professor
        Console.WriteLine("Quantas horas o segundo professor trabalha por dia?");
        horas2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Quanto o segundo professor ganha por hora?");
        salario2 = double.Parse(Console.ReadLine());

        total2 = (horas2 * salario2) * numMes;

        // Lógica para saber quem ganha mais.
        
        if(total1 > total2)
        {
            Console.WriteLine($"O primeiro professor ganha mais, no total de R${horas1 * salario1},00 por dia. Totalizando R${total1},00 por mês");
        }
        else if(total2 > total1)
        {
            Console.WriteLine($"O segundo professor ganha mais, no total de R${horas2 * salario2},00 por dia. Totalizando R${total2},00 por mês");

        }
        else
        {
            Console.WriteLine($"Os dois professores tem salários iguais. Ao total de R${total2},00 por mês");
        }
    }
}