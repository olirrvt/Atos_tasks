namespace HelloWorld;
class Program
{
    static void Main(string[] args)
    {
        int numero;
        string opcao = "s";
        bool next = true;


        for(;next;)
        {   
            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            if(numero > -1)
            {
                Console.Write($"Os números pares entre 1 e {numero}: ");
                
                for(int i = 1; i <= numero; i++)
                {
                    if(i % 2 == 0)
                    {
                        Console.Write($"{i} ");
                    }
                    else if(numero == 1 || numero == 0)
                    {
                        Console.WriteLine("Não existe números pares entre 1 e 0");
                    }
                }

                Console.WriteLine("");
                Console.WriteLine("Deseja digitar outro número (S/N)? ");
                opcao = Console.ReadLine();
                next = opcao.ToLower() == "s" ? true : false; 
            } 
            else
            {
                Console.WriteLine("Número Inválido, tente digitar um número maior que '-1':");
            }

        }
    }
}