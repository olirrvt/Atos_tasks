namespace task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrizA = new int[3, 3];
            int somaLinhas1 = 0, somaLinhas2 = 0, somaLinhas3 = 0;
            int somaColunas1 = 0, somaColunas2 = 0, somaColunas3 = 0;

            // Pedindo para preencher a Matriz
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    Console.WriteLine($"Preencha a matriz [{i}, {j}]");
                    matrizA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Soma e saída das Linhas
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                somaLinhas1 += matrizA[i, 0];
                somaLinhas2 += matrizA[i, 1];
                somaLinhas3 += matrizA[i, 2];
            }

            Console.WriteLine($"Soma das linhas 1 = {somaLinhas1}");
            Console.WriteLine($"Soma das linhas 2 = {somaLinhas2}");
            Console.WriteLine($"Soma das linhas 3 = {somaLinhas3}");
            Console.WriteLine("------------------------------------");

            // Soma e saída das colunas
            for (int j = 0; j < matrizA.GetLength(1); j++)
            {
                somaColunas1 += matrizA[0, j];
                somaColunas2 += matrizA[1, j];
                somaColunas3 += matrizA[2, j];
            }

            Console.WriteLine($"Soma das Colunas 1 = {somaColunas1}");
            Console.WriteLine($"Soma das Colunas 2 = {somaColunas2}");
            Console.WriteLine($"Soma das Colunas 3 = {somaColunas3}");
        }
    }
}

//2) Solicite ao usuário, preencher uma Matriz 3x3

//  Informe ao usuário:

//  * A soma dos elementos de cada linha
//	-Ex: Linha 1: 30
//       Linha 2: 17

//  * A soma dos elementos de cada coluna
//	-Ex: Coluna 1: 23
//       Coluna 2: 36

/*
    2 2 2 
    2 2 2
    2 2 2
 */