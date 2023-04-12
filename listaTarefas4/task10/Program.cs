namespace HelloWorld;
class Program
{
    static void Main(string[] args)
    {
        string nome, sexo;
        int idade, contMasc = 0, contFem = 0, contInf30 = 0, contSup60 = 0, somaIdadeFem = 0;
        double mediaFem;




        for(int i = 1; i < 50; i++)
        {
            Console.Write($"Você é a {i}° pessoa, Digite o seu nome: ");
            nome = Console.ReadLine();

            Console.Write($"{i}°- Digite a sua idade: ");
            idade = int.Parse(Console.ReadLine());
            
            Console.Write($"{i}°- Digite o seu sexo: ");
            sexo = Console.ReadLine().ToLower();

            // Verificação do Genêro do usuário
            contMasc = sexo == "masculino" ? contMasc + 1 : contMasc;
            contFem = sexo == "feminino" ? contFem + 1 : contFem;

            // Idade inferior a 30
            contInf30 = idade < 30 ? contInf30 + 1 : contInf30;
            contSup60 = idade > 60 ? contSup60 + 1 : contSup60;

            // Somando a idade das mulheres
            somaIdadeFem = sexo == "feminino" ? idade + idade : idade;
        }

        mediaFem = (double)somaIdadeFem / contFem;
    }
}