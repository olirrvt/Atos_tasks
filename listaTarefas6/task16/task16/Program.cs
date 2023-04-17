namespace task16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrizA = new int[3, 4];
            int[,] matrizB = new int[4, 3];
            Random random = new Random();

            // Leitura da Matriz A com números Aleatórios
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    matrizA[i, j] = random.Next(0, 50);
                }
            }

            // Transposição da matriz A para a matriz B
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    matrizB[j, i] = matrizA[i, j];
                }
            }

            // Impressão das matrizes A e B na tela
            Console.WriteLine("Matriz A:");
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    Console.Write(matrizA[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Matriz B:");
            for (int i = 0; i < matrizB.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    Console.Write(matrizB[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

// 16) Escreva um algoritmo para transpor uma matriz 3x4 para outra 4x3. 
// Transpor uma matriz significa transformar suas linhas em colunas e vice-versa.
