namespace task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrizA = new int[5,3];

            for(int linha = 0; linha < 5; linha++)
             {
               Console.Write("Digite um valor para a primeira coluna: ");
               matrizA[linha, 0] = int.Parse(Console.ReadLine());

                // Somando o valor e colocando na segunda coluna
                matrizA[linha, 1] = matrizA[linha, 0] + 10;
               
                // Fazendo o dobro
                matrizA[linha, 2] = matrizA[linha, 0] * 2;
             }

            for(int linha = 0; linha < 5; linha++)
            {
                for(int coluna = 0; coluna < 3; coluna++)
                {
                    Console.WriteLine($"{matrizA[linha, coluna]} \t");
                }
                Console.WriteLine();
            }
        }
    }
}

//1) Crie uma Matriz 5x3. Na primeira coluna, solicite que o usuário preencha.
//A 2ª coluna, some 10 aos elementos da 1ª coluna.
//Na 3º coluna, armazene o dobro dos elementos da 1ª coluna.

/*
   0  0  0
   0  0  0
   0  0  0
   0  0  0
   0  0  0
*/