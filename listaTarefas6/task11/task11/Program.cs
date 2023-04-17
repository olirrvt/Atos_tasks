namespace task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] matrizA = new double[3, 3];
            double[,] matrizResultante = new double[3, 3];
            Random random = new Random();

            // Leitura da Matriz com números Aleatórios
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    matrizA[i, j] = random.NextDouble();
                }
            }

            // Cálculo da soma dos índices
            double somaIndices = 0;
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    somaIndices += (i + j);
                }
            }

            // Cálculo da nova matriz resultante
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    matrizResultante[i, j] = matrizA[i, j] / somaIndices;
                }
            }

            // Impressão da nova matriz resultante
            for (int i = 0; i < matrizResultante.GetLength(0); i++)
            {
                for (int j = 0; j < matrizResultante.GetLength(1); j++)
                {
                    Console.Write(matrizResultante[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

//11) Leia uma matriz A de tipo double de dimenção 3x3,
// Crie uma nova matriz resultante da divisão dos elementos da matriz A pela soma dos seus indices.

