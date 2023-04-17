namespace task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrizA = new int[4, 4];
            Random random = new Random();

            // Leitura da Matriz A com números Aleatórios
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    matrizA[i, j] = random.Next(0, 50);
                }
            }

            Console.WriteLine("Valores que a soma dos indices é par:");

            // Somando os índices
            int somaIndices = 0;
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    somaIndices += (i + j);
                    if(somaIndices % 2 == 0)
                    {
                        Console.Write($"{matrizA[i, j]} | ");
                    }
                }
            }

        }
    }
}

//12) Escreva um programa que leia os valores de uma matriz 4x3,
// e em seguida mostre na tela apenas os valores cuja soma dos índices (i+j) seja um número par.