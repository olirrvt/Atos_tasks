namespace HelloWorld;
class Program
{
    static void Main(string[] args)
    {
        int numero = 51;


        // Verificando se o número é menor ou igual que 50
        while (numero >= 50)
        {
            Console.WriteLine("Digite um número abaixo de 50 para fazer a verificação: ");
            numero = int.Parse(Console.ReadLine());
        }

        do
        {
            Console.WriteLine(numero * 3);
            numero *= 3;
        }
        while (numero < 250);
    }
}

// 16. Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da 
// multiplicação sucessiva de N por 3 enquanto o produto for menor que 250 
// (N*3; N*3*3; N*3*3*3; etc).